using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS_Interface;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using WMS_Database;
using Storage;
namespace WMS_Kernel
{
    public partial class StationShowView : ChildViewBase,IStorageView
    {
        public StorageViewPresenter Presenter = null;
        private delegate void RefreshDataInvoke();
        private delegate void RefreshPosInvoke(List<Positions> posList);
        public StationShowView()
        {
            InitializeComponent();
        
        }
        private void StationShowView_Load(object sender, EventArgs e)
        {
            Presenter.Init();
            CellGoodsDetailDataBind();
            WareAreaDataBind();
        }
     

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            Presenter = new StorageViewPresenter(this,wmsFrame);
            string restr = "";
         
            Bitmap bitmap = ImageResource.StationShow.ToBitmap();
            this.IWmsFrame.AddTitlePage("库存管理", ref restr);
            this.IWmsFrame.AddGroup("库存管理", "库存操作", ref restr);
            this.IWmsFrame.AddButtonItem("库存管理", "库存操作", "货位显示", bitmap, ShowTabEventHandler, ref restr);

            this.IWmsFrame.SetTabChangeEvent(TabChangeEventHandler);
        }

        private void TabChangeEventHandler(object sender, EventArgs e)
        {
            DevExpress.XtraTabbedMdi.MdiTabPageEventArgs tabEventArgs = e as DevExpress.XtraTabbedMdi.MdiTabPageEventArgs;
            if (tabEventArgs.Page == null)
            {
                return;
            }
            if (tabEventArgs.Page.Text == "货位显示")
            {
                RefreshData();
                this.Presenter.GetWareArea(this.cbe_HouseList.Text.Trim());
            }
        }
        /// <summary>
        /// 刷新界面货位
        /// </summary>
        /// <param name="posList"></param>
        public void RefreshPos(List<Positions> posList)
        {
            if (this.storageControl1.InvokeRequired)
            {
                RefreshPosInvoke rpi = new RefreshPosInvoke(RefreshPos);
                this.storageControl1.Invoke(rpi, new object[1] { posList });
            }
            else
            {
                this.storageControl1.DataSour = posList;
            }
        }
      

        public void RefreshData()
        {
            if (this.InvokeRequired)
            {
                RefreshDataInvoke rdi = new RefreshDataInvoke(RefreshData);
                this.Invoke(rdi);
            }
            else
            {
                if (this.cbe_Row.Text == "")
                { return; }
               
                this.Presenter.RefreshPosData(this.cbe_HouseList.Text, this.cbe_Row.Text,this.cbe_PosTypeList.Text.Trim());
            }

        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }
        public void SetRowTxt(string rowIndex)
        {
            this.cbe_Row.Text = rowIndex;
        }
        public void SetPosTxt(string posType)
        {
            this.cbe_PosTypeList.Text = posType;
        }
        public void RefreshHouseListData(List<WH_WareHouseModel> houseList)
        {
            this.cbe_HouseList.Properties.Items.Clear();
            if(houseList == null)
            {
                return;
            }
            foreach(WH_WareHouseModel house in houseList)
            {
                this.cbe_HouseList.Properties.Items.Add(house.WareHouse_Name);
            }
            if(houseList.Count>0)
            {
                this.cbe_HouseList.SelectedIndex = 0;
            }
         
        }
        private void CellGoodsDetailDataBind()
        {
            this.gc_CellGoodsDetail.DataBindings.Clear();
            this.gc_CellGoodsDetail.DataBindings.Add("DataSource", ViewDataManager.STORAGEVIEWDATA, "CellGoodsDetailData", false, DataSourceUpdateMode.OnPropertyChanged);
            
        }

        private void WareAreaDataBind()
        {
            this.gc_Area.DataBindings.Clear();
            this.gc_Area.DataBindings.Add("DataSource", ViewDataManager.WAREAREAVIEWDATA, "AreaColorListData", false, DataSourceUpdateMode.OnPropertyChanged);
            
        }
        public void BingHouseRowData(List<string> rowList)
        {
            this.cbe_Row.Properties.Items.Clear();
            if(rowList == null)
            {
                return;
            }
            foreach (string row in rowList)
            {
                this.cbe_Row.Properties.Items.Add(row);
            }
            if (rowList.Count > 0)
            {
                this.cbe_Row.SelectedIndex = 0;
            }
         
        }
           
        public void InitPosTypeList(List<string> posList)
        {
           
            if (posList == null)
            {
                return;
            }
            this.cbe_PosTypeList.Properties.Items.Clear();
            foreach (string pos in posList)
            {
                this.cbe_PosTypeList.Properties.Items.Add(pos);
            }
            if (posList.Count > 0)
            {
                this.cbe_PosTypeList.SelectedIndex = 0;
            }
         
        }
    
     

        private void cbe_HouseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.storageControl1.DataSour = null;
            this.storageControl1.selectPositions = null;
            string houseName = this.cbe_HouseList.Text.Trim();
            this.storageControl1.selectPositions = null;
            if(houseName=="")
            {
                return;
            }
            this.Presenter.InitHouseRowList(houseName);
            string rowstr = this.cbe_Row.Text.Trim();
            if (rowstr == "")
            {
                return;
            }
            this.Presenter.InitPosList(houseName, int.Parse(rowstr));
            this.Presenter.GetWareArea(houseName);
            RefreshData();
        }

        private void cbe_Row_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.storageControl1.selectPositions = null;
            this.Presenter.InitPosList(this.cbe_HouseList.Text.Trim(), int.Parse(this.cbe_Row.Text.Trim()));
            RefreshData();
        }

        private void sBtn_Query_Click(object sender, EventArgs e)
        {
            this.storageControl1.selectPositions = null;
            string cellName = this.te_CellName.Text.Trim();
            string[] cellRcl = cellName.Split('-');

            if(cellRcl == null || cellRcl.Length != 3)
            {
                this.ShowMessage("信息提示","货位名称格式错误！示例1-2-4为一排二列四层。");
                return;
            }
            int columnth =0;
            int layerth =0;
            bool colConvert = int.TryParse(cellRcl[1],out columnth);
            bool layerConvert = int.TryParse(cellRcl[2], out layerth);
            if(colConvert==false||layerConvert == false)
            {
                this.ShowMessage("信息提示", "货位名称格式错误！示例1-2-4为一排二列四层。");
                return;
            }
            ViewDataManager.STORAGEVIEWDATA.CellGoodsDetailData.Clear();
            GsSearch(columnth, layerth);
           
        }

        public void GsSearch(int columnth, int layerth)
        {

            Positions pos = this.storageControl1.GetPositionsByCL(columnth - 1, layerth - 1);
            if (pos == null)
            {
                this.ShowMessage("信息提示", "当前排！没有查到此货位！请检查货位名称！");
                return;
            }
                this.storageControl1.selectPositions = pos;

                if (pos.Location.X + pos.Width > this.storageControl1.Width - 10)//垂直滚动条宽度10
                {
                    int hScrollValue = pos.Location.X + pos.Width - this.storageControl1.Width + 50;
                    if (hScrollValue > this.storageControl1.HorizontalScroll.Maximum)
                    {
                        hScrollValue = this.storageControl1.HorizontalScroll.Maximum;
                    }
                    this.storageControl1.HorizontalScroll.Value = hScrollValue;
                    this.storageControl1.HorizontalScroll.Value = hScrollValue;
                }
                else
                {
                    this.storageControl1.HorizontalScroll.Value = 0;
                    this.storageControl1.HorizontalScroll.Value = 0;
                }
                if (pos.Location.Y + pos.Height > this.storageControl1.Height - 10)//横向滚动条宽度10
                {
                    int vScrollValue = pos.Location.Y - this.storageControl1.Height + 50;
                    if (vScrollValue > this.storageControl1.VerticalScroll.Maximum)
                    {
                        vScrollValue = this.storageControl1.VerticalScroll.Maximum;
                    }
                    this.storageControl1.VerticalScroll.Value = vScrollValue;//设置两次才好使
                    this.storageControl1.VerticalScroll.Value = vScrollValue;
                }
                else
                {
                    this.storageControl1.VerticalScroll.Value = 0;
                    this.storageControl1.VerticalScroll.Value = 0;
                }
                this.storageControl1.Invalidate();
                this.storageControl1.Invalidate();

        }

        private void sb_Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void storageControl1_PositionsClick(object sender, StorageControl.ClickPositionsEventArgs e)
        {
            this.storageControl1.selectPositions = e.Positions;
          
            OnClickGs();
        }
        private void OnClickGs( )
        {
            if (this.storageControl1.selectPositions != null && this.storageControl1.selectPositions.Visible == true)
            {
                this.Presenter.GetGSDetail(this.storageControl1.selectPositions.GoodsSiteID.ToString());
                //OnShowExterProperty();
            }
            
        }

        private void cbe_PosTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Presenter.RefreshPosData(this.cbe_HouseList.Text.Trim(), this.cbe_Row.Text.Trim(),this.cbe_PosTypeList.Text.Trim());
        }

        private void sb_QueryByPalletCode_Click(object sender, EventArgs e)
        {
            ViewDataManager.STORAGEVIEWDATA.CellGoodsDetailData.Clear();
            this.storageControl1.selectPositions = null;
            this.Presenter.GetCellDetailByPalletCode(this.cbe_HouseList.Text.Trim(), this.te_PalletCode.Text.Trim());
        }

        private void tsmi_ModifyStatus_Click(object sender, EventArgs e)
        {
            if (this.IWmsFrame.RoleLevel > 1)
            {
                this.ShowMessage("信息提示", "当前用户没有此功能的操作权限！");
                return;
            }
            OnModifyGsStatus();
        }

        private void OnModifyGsStatus()
        {
            if (this.IWmsFrame.RoleLevel > 2)
            {
                ShowMessage("信息提示", "当前用户没有此功能的操作权限！");

                return;
            }
            if (this.storageControl1.selectPositions == null)
            {
                MessageBox.Show("请选中要要修改的货位！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CellStatusView egsv = new CellStatusView();
            egsv.ShowDialog();
            if (egsv.IsSure == true)
            {
                if (this.AskMessage("询问？","您确定要修改选中货位状态么？") !=0)
                {
                    return;
                }

                string cellID = this.storageControl1.selectPositions.GoodsSiteID;
                this.Presenter.ModifyGsStatus( cellID, egsv.GSStatus, egsv.GSTaskStatus);

            }
        }

        private void sb_CellSet_Click(object sender, EventArgs e)
        {
            List<int> rows = this.Presenter.GetHouseRCL(this.cbe_HouseList.Text.Trim(), 0);
            List<int> cols = this.Presenter.GetHouseRCL(this.cbe_HouseList.Text.Trim(), 1);
            List<int> layers = this.Presenter.GetHouseRCL(this.cbe_HouseList.Text.Trim(), 2);
            List<string> cellPos = new List<string>();
            foreach (string item in this.cbe_PosTypeList.Properties.Items)
            {
                cellPos.Add(item);
            }
            CellSetView csv = new CellSetView(this.cbe_HouseList.Text.Trim(), int.Parse(this.cbe_Row.Text.Trim()), this.Presenter, cols, layers, cellPos);
            csv.ShowDialog();
        }

        private void tsmi_Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void tsmi_UnUseGs_Click(object sender, EventArgs e)
        {
            if(this.IWmsFrame.RoleLevel>2)
            {
                ShowMessage( "信息提示","当前用户没有此功能的操作权限！");
              
                return;
            }
            if (this.AskMessage("询问", "您确定要禁用选中货位吗？") != 0)
            {
                return;
            }
            if (null == this.storageControl1.selectPositions)
            {
                ShowMessage("信息提示", "请选择要禁用的货位！");
                return;
            }
            this.Presenter.SetGsStatus(this.storageControl1.selectPositions.GoodsSiteID, false);
        }

        private void tsmi_UseGs_Click(object sender, EventArgs e)
        {
            if (this.IWmsFrame.RoleLevel > 2)
            {
                ShowMessage("信息提示", "当前用户没有此功能的操作权限！");

                return;
            }
            if (this.AskMessage("询问", "您确定要启用选中货位吗？") != 0)
            {
                return;
            }
            if (null == this.storageControl1.selectPositions)
            {
                ShowMessage("信息提示", "请选择要启用的货位！");
                return;
            }
            this.Presenter.SetGsStatus(this.storageControl1.selectPositions.GoodsSiteID, true);
        }

        private void tsmi_StartPos_Click(object sender, EventArgs e)
        {
            if (this.storageControl1.selectPositions == null)
            {
                return;
            }
            Positions pos = this.storageControl1.selectPositions;
            if (pos == null)
            {
                return;
            }
            MoveHouseProModel moveHouseProModel = new MoveHouseProModel();
            moveHouseProModel.HouseName = this.cbe_HouseList.Text.Trim();
            moveHouseProModel.CellName =( pos.Rowth +1)+ "排-" + pos.Columnth + "列-" + pos.Layer + "层";
            moveHouseProModel.CellPos = (EnumCellPos)Enum.Parse(typeof(EnumCellPos), this.cbe_PosTypeList.Text.Trim());
            moveHouseProModel.CellChildID = pos.GoodsSiteID;
            this.te_Start.Tag = moveHouseProModel;
            this.te_Start.Text = moveHouseProModel.HouseName + ":" + moveHouseProModel.CellName + ":" + moveHouseProModel.CellPos;
           
        }

        private void tsmi_EndPos_Click(object sender, EventArgs e)
        {
            if (this.storageControl1.selectPositions == null)
            {
                return;
            }
            Positions pos = this.storageControl1.selectPositions;
            if (pos == null)
            {
                return;
            }
            MoveHouseProModel moveHouseProModel = new MoveHouseProModel();
            moveHouseProModel.HouseName = this.cbe_HouseList.Text.Trim();
            moveHouseProModel.CellName = (pos.Rowth +1)+ "排-" + pos.Columnth + "列-" + pos.Layer+"层";
            moveHouseProModel.CellPos = (EnumCellPos)Enum.Parse(typeof(EnumCellPos), this.cbe_PosTypeList.Text.Trim());
            moveHouseProModel.CellChildID = pos.GoodsSiteID;
            this.te_EndPos.Tag = moveHouseProModel;
            this.te_EndPos.Text = moveHouseProModel.HouseName + ":" + moveHouseProModel.CellName + ":" + moveHouseProModel.CellPos;
        }

        private bool CheckSameHouse()
        {
            MoveHouseProModel stPro = (MoveHouseProModel)this.te_Start.Tag;
            MoveHouseProModel edPro = (MoveHouseProModel)this.te_EndPos.Tag;
            if(stPro==null || edPro ==null)
            {
                return false;
            }
            if(stPro.HouseName != edPro.HouseName)
            {
                return false;
            }
            return true;
        }

        private void sb_Move_Click(object sender, EventArgs e)
        {
            if(this.AskMessage("询问","您确定要移动当前设置库存么？")!=0)
            {
                return;
            }
            if (this.te_Start.Text.Trim() == "")
            {
                this.ShowMessage("信息提示", "请选择起始货位！");
                return;
            }
            if (this.te_EndPos.Text.Trim() =="")
            {
                this.ShowMessage("信息提示", "请选择目标货位！");
                return;
            }
            if(CheckSameHouse() == false)
            {
                this.ShowMessage("信息提示", "只能在同一个库房进行移库！");
                return;
            }
               MoveHouseProModel stPro = (MoveHouseProModel)this.te_Start.Tag;
            MoveHouseProModel edPro = (MoveHouseProModel)this.te_EndPos.Tag;
            if(stPro==null || edPro ==null)
            {
                return ;
            }
            this.Presenter.MoveHouse(stPro.CellChildID, edPro.CellChildID);
             
        }

        private void gv_Area_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "区域颜色")
            {
                object colorObj = e.CellValue;
                string[] colorArray = colorObj.ToString().Split(',');
                e.Appearance.BackColor = Color.FromArgb(Convert.ToByte(colorArray[0]), Convert.ToByte(colorArray[1]), Convert.ToByte(colorArray[2]));
                e.Appearance.BackColor2 = Color.FromArgb(Convert.ToByte(colorArray[0]), Convert.ToByte(colorArray[1]), Convert.ToByte(colorArray[2]));
                e.Appearance.ForeColor = Color.FromArgb(Convert.ToByte(colorArray[0]), Convert.ToByte(colorArray[1]), Convert.ToByte(colorArray[2]));
            }  
        }

        private void tsm_StockAdjust_Click(object sender, EventArgs e)
        {
            if (this.IWmsFrame.RoleLevel > 2)
            {
                ShowMessage("信息提示", "当前用户没有此功能的操作权限！");

                return;
            }
            if (this.storageControl1.selectPositions == null)
            {
                return;
            }
            Positions pos = this.storageControl1.selectPositions;
            if (pos == null)
            {
                return;
            }
            StockAdjustView sav = new StockAdjustView(pos.GoodsSiteID);
            sav.Init(this.IWmsFrame);
            sav.ShowDialog();
            RefreshData();
            OnClickGs();
        }

        private void storageControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Point pt = new Point();
            pt.X = e.X;
            pt.Y = e.Y;
            Positions pos = this.storageControl1.GetPostionsByPt(pt);
            if (pos == null)
            {
                this.storageControl1.selectPositions = null;
            }
        }

        //  private void RefreshColor()
        //{
        //    if (this.gv_Area.RowCount == 0)
        //    {
        //        return;
        //    }
        //    for(int i = 0;i<this.gv_Area.RowCount;i++)
        //    {
        //        string areaColor = this.gv_Area.GetRowCellValue(i, "区域颜色").ToString();
        //        string[] colorArray = areaColor.Split(',');
        //        this.gv_Area.

        //    }
            
            
        //}

    }
}