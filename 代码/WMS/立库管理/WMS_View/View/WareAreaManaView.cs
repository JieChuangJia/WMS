using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS_Interface;
using DevExpress.XtraBars;
using WMS_Database;
using System.Drawing;

namespace WMS_Kernel
{
    public partial class WareAreaManaView : ChildViewBase, IWareAreaManaView
    {
        public WareAreaManaPresenter presenter = null;
        private AddAndModifyAreaView operAreaView = null;
        public WareAreaManaView()
        {
            InitializeComponent();
            operAreaView = new AddAndModifyAreaView();
            operAreaView.MyEvent += new AddAndModifyAreaView.MyDelegate(RefreshArea);
        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new WareAreaManaPresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.WareHouseArea.ToBitmap();
            this.IWmsFrame.AddTitlePage("库存管理", ref restr);
            this.IWmsFrame.AddGroup("库存管理", "库存操作", ref restr);
            this.IWmsFrame.AddButtonItem("库存管理", "库存操作", "库存区域设置", bitmap, ShowTabEventHandler, ref restr);
        }

        #region 实现方法
        public void RefreshHouseListData(List<string> houseList)
        {
            this.cbe_HouseList.Properties.Items.Clear();
            if (houseList == null)
            {
                return;
            }
            foreach (string houseName in houseList)
            {
                this.cbe_HouseList.Properties.Items.Add(houseName);
            }
            if (houseList.Count > 0)
            {
                this.cbe_HouseList.SelectedIndex = 0;
            }

        }
        #endregion


        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            if (this.IWmsFrame.RoleLevel > 2)
            {
                this.ShowMessage("信息提示", "当前用户没有此操作权限！");
                return;
            }
            this.IWmsFrame.ShowView(this, true);
        }

        private void AreaListDataBind()
        {
            this.gc_AreaList.DataBindings.Clear();
            this.gc_AreaList.DataBindings.Add("DataSource", ViewDataManager.WAREAREAVIEWDATA, "AreaListData", false, DataSourceUpdateMode.OnPropertyChanged);
           
        }

        private void RefreshArea()
        {
            this.presenter.QueryAreaList(this.cbe_HouseList.Text.Trim());
        }

        private void sb_DeleteArea_Click(object sender, EventArgs e)
        {
            if (this.AskMessage("信息提示", "您确定要删除选中库房区域么？") != 0)
            {
                return;

            }
         
          
            if (this.gv_AreaList.GetSelectedRows() == null || this.gv_AreaList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要删除的库房区域！");
                return;
            }
            int currRow = this.gv_AreaList.GetSelectedRows()[0];
            string areaID = this.gv_AreaList.GetRowCellValue(currRow, "区域编号").ToString();
            string areaName = this.gv_AreaList.GetRowCellValue(currRow, "区域名称").ToString();
            if(areaName == "默认库区")
            {
                this.ShowMessage("信息提示", "默认库区，不允许删除！");
                return;
            }
            if (this.presenter.DeleteArea(areaID))
            {
                this.ShowMessage("信息提示", "库房区域删除成功！");
            }
            else
            {
                this.ShowMessage("信息提示", "库房区域删除失败！");
            }
            RefreshArea();
        }

        private void sb_AddArea_Click(object sender, EventArgs e)
        {
            WareArea area = new WareArea();
            area.WareHouseName = this.cbe_HouseList.Text.Trim();
            operAreaView.operateName = "添加";
            operAreaView.area = area;
            operAreaView.ShowDialog();
        }

        private void sb_ModifyArea_Click(object sender, EventArgs e)
        {
            if (this.gv_AreaList.GetSelectedRows() == null || this.gv_AreaList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要修改的库房区域！");
                return;
            }
            int currRow = this.gv_AreaList.GetSelectedRows()[0];
            WareArea area = new WareArea();
            area.AreaID = this.gv_AreaList.GetRowCellValue(currRow, "区域编号").ToString();
            area.AreaName = this.gv_AreaList.GetRowCellValue(currRow, "区域名称").ToString();
            area.WareHouseID = this.gv_AreaList.GetRowCellValue(currRow, "库房名称").ToString();
            area.AreaCode = this.gv_AreaList.GetRowCellValue(currRow, "区域编码").ToString();
            area.AreaType = this.gv_AreaList.GetRowCellValue(currRow, "区域类型").ToString();
            //area.AreaEnableStatus = this.gv_AreaList.GetRowCellValue(currRow, "区域启用状态").ToString();
            string backColorRGB = this.gv_AreaList.GetRowCellValue(currRow, "区域颜色").ToString();

            area.AreaBackColor =backColorRGB;
            operAreaView.operateName = "修改";
            operAreaView.area = area;
            operAreaView.ShowDialog();
        }

        private void sb_QueryWare_Click(object sender, EventArgs e)
        {
            RefreshArea();
        }

        private void WareAreaManaView_Load(object sender, EventArgs e)
        {
            this.presenter.InitHouseList();
            AreaListDataBind();

        }

        private void gv_AreaList_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
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
    }
}