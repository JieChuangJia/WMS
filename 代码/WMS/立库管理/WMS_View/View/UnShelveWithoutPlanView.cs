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
using WMS_Database;
namespace WMS_Kernel
{
    public partial class UnShelveWithoutPlanView : ChildViewBase,IUnShelveWithoutPlanView
    {
        UnShelveWithoutPlanPresenter presenter = null;
        public UnShelveWithoutPlanView()
        {
            InitializeComponent();

        }
        private void UnShelvePlanView_Load(object sender, EventArgs e)
        {
            BindGridData();
        }


        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            presenter = new  UnShelveWithoutPlanPresenter(this, wmsFrame);
            presenter.Init();
         
            string restr = "";

            Bitmap bitmap = ImageResource.UnshelveWithoutPlan.ToBitmap();
            this.IWmsFrame.AddTitlePage("任务管理", ref restr);
            this.IWmsFrame.AddGroup("任务管理", "无计划任务", ref restr);
            this.IWmsFrame.AddButtonItem("任务管理", "无计划任务", "无计划下架", bitmap, ShowTabEventHandler, ref restr);
            this.IWmsFrame.SetTabChangeEvent(TabChangeEventHandler);
        }
        #region ui接口
        public void IniHouseName(List<WH_WareHouseModel> houseList)
        {
            this.cbe_HouseName.Properties.Items.Clear();

            if (houseList == null)
            {
                return;
            }
            foreach (WH_WareHouseModel house in houseList)
            {
                this.cbe_HouseName.Properties.Items.Add(house.WareHouse_Name);
            }
            if (this.cbe_HouseName.Properties.Items.Count > 0)
            {
                this.cbe_HouseName.SelectedIndex = 0;
            }
        }


        public void IniTargetList(List<string> targetStationList)
        {
            this.ce_TargetStation.Properties.Items.Clear();

            if (targetStationList == null)
            {
                return;
            }
            foreach (string station in targetStationList)
            {
                this.ce_TargetStation.Properties.Items.Add(station);
            }
            if (this.ce_TargetStation.Properties.Items.Count > 0)
            {
                this.ce_TargetStation.SelectedIndex = 0;
            }
        }

        public void IniCols(List<string> items)
        {
            this.cbe_Col.Properties.Items.Clear();
            this.cbe_Col.Properties.Items.Add("所有");
            if (items == null)
            {
                return;
            }

            foreach (string item in items)
            {
                this.cbe_Col.Properties.Items.Add(item);
            }
            if (this.cbe_Col.Properties.Items.Count > 0)
            {
                this.cbe_Col.SelectedIndex = 0;
            }
        }

        public void IniLayers(List<string> items)
        {
            this.cbe_Layer.Properties.Items.Clear();
            this.cbe_Layer.Properties.Items.Add("所有");
            if (items == null)
            {
                return;
            }

            foreach (string item in items)
            {
                this.cbe_Layer.Properties.Items.Add(item);
            }
            if (this.cbe_Layer.Properties.Items.Count > 0)
            {
                this.cbe_Layer.SelectedIndex = 0;
            }
        }

        public void IniRows(List<string> items)
        {
            this.cbe_Row.Properties.Items.Clear();
            this.cbe_Row.Properties.Items.Add("所有");
            if (items == null)
            {
                return;
            }

            foreach (string item in items)
            {
                this.cbe_Row.Properties.Items.Add(item);
            }
            if (this.cbe_Row.Properties.Items.Count > 0)
            {
                this.cbe_Row.SelectedIndex = 0;
            }
        }

        public void IniPoses(List<string> items)
        {
            this.cbe_PosTypeList.Properties.Items.Clear();
            this.cbe_PosTypeList.Properties.Items.Add("所有");
            if (items == null)
            {
                return;
            }

            foreach (string item in items)
            {
                this.cbe_PosTypeList.Properties.Items.Add(item);
            }
            if (this.cbe_PosTypeList.Properties.Items.Count > 0)
            {
                this.cbe_PosTypeList.SelectedIndex = 0;
            }
        }
        #endregion
        private void TabChangeEventHandler(object sender, EventArgs e)
        {
            DevExpress.XtraTabbedMdi.MdiTabPageEventArgs tabEventArgs = e as DevExpress.XtraTabbedMdi.MdiTabPageEventArgs;
            if (tabEventArgs.Page == null)
            {
                return;
            }
            if (tabEventArgs.Page.Text == "无计划下架")
            {
              
            }
        }

        private void BindGridData()
        {

            this.gc_StockDetail.DataBindings.Clear();
            this.gc_StockDetail.DataBindings.Add("DataSource", ViewDataManager.UNSHELVEWITHPPLANVIEWDATA, "PalletInforData", false, DataSourceUpdateMode.OnPropertyChanged);
            this.gc_Stock.DataBindings.Clear();
            this.gc_Stock.DataBindings.Add("DataSource", ViewDataManager.UNSHELVEWITHPPLANVIEWDATA, "PalletData", false, DataSourceUpdateMode.OnPropertyChanged);

        }
      


        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

    

        private void gc_Stock_Click(object sender, EventArgs e)
        {
            if (this.gv_Stock == null || this.gv_Stock.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要下架的库存！");
                return;
            }
            if (this.gv_Stock.GetSelectedRows().Count() == 0)
            {
                return;
            }
            int currRow = this.gv_Stock.GetSelectedRows()[0];
            string houseName = this.gv_Stock.GetRowCellValue(currRow, "库房").ToString();
            string palletCode = this.gv_Stock.GetRowCellValue(currRow, "托盘条码").ToString();
            this.presenter.IniUnShelveStationList(houseName);
            this.presenter.PalletDetail(palletCode);
        }

        private void sb_UnShelveTask_Click(object sender, EventArgs e)
        {
            if(this.ce_TargetStation.Text.Trim() == "")
            {
                this.ShowMessage("信息提示", "请在库存清单中选中要出库的托盘！");
                return;
            }
            int status = this.AskMessage("信息提示", "您确定下架当前选中物料么？");
            if (status != 0)
            {
                return;
            }

     
            if(this.gv_Stock.GetSelectedRows().Count()==0)
            {
                this.ShowMessage("信息提示", "请选择要下架的库存！");
                
                return;
            }
            int currRow = this.gv_Stock.GetSelectedRows()[0];
            string palletCode = this.gv_Stock.GetRowCellValue(currRow, "托盘条码").ToString();
            string houseName = this.gv_Stock.GetRowCellValue(currRow, "库房").ToString();
            string unshelveStationName = this.ce_TargetStation.Text.Trim();
            this.presenter.UnShelveTask( palletCode, houseName, unshelveStationName);
            this.presenter.QueryStockInfor(this.cbe_HouseName.Text.Trim(), this.cbe_Row.Text.Trim(), this.cbe_Col.Text.Trim()
               , this.cbe_Layer.Text.Trim(), this.cbe_PosTypeList.Text.Trim(), this.te_PalletCode.Text.Trim());
        }

     

        private void cbe_HouseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbe_HouseName.Text.Trim() == "")
            {
                return;
            }
            this.presenter.IniRclp(this.cbe_HouseName.Text.Trim());
            this.presenter.IniUnShelveStationList(this.cbe_HouseName.Text.Trim());
        }

        private void sb_Query_Click(object sender, EventArgs e)
        {
            this.presenter.QueryStockInfor(this.cbe_HouseName.Text.Trim(), this.cbe_Row.Text.Trim(), this.cbe_Col.Text.Trim()
                , this.cbe_Layer.Text.Trim(), this.cbe_PosTypeList.Text.Trim(), this.te_PalletCode.Text.Trim());
        }

        private void gv_Stock_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gv_Stock == null || this.gv_Stock.GetSelectedRows().Count() == 0)
            { 
                return;
            }
            if (this.gv_Stock.GetSelectedRows().Count() == 0)
            {
                return;
            }
            int currRow = this.gv_Stock.GetSelectedRows()[0];
            string houseName = this.gv_Stock.GetRowCellValue(currRow, "库房").ToString();
            string palletCode = this.gv_Stock.GetRowCellValue(currRow, "托盘条码").ToString();
         
            this.presenter.PalletDetail(palletCode);
        }
      

        //private void cbe_Row_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.cbe_Row.Text.Trim() == "" || this.cbe_Row.Text.Trim()=="所有")
        //    {
        //        //this.ShowMessage("信息提示","行不能为空");
        //        this.cbe_Layer.Text = "所有";
        //        this.cbe_Col.Text = "所有";
        //        this.cbe_PosTypeList.Text = "所有";
        //        return;
        //    }
        //    int rowth = int.Parse(this.cbe_Row.Text.Trim());

        //    this.presenter.IniCols(this.cbe_HouseName.Text.Trim(), rowth);
        //}

        //private void cbe_Col_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.cbe_Row.Text.Trim() == "" || this.cbe_Col.Text.Trim()=="所有")
        //    {
        //        this.cbe_Layer.Text = "所有";
        //        this.cbe_Col.Text = "所有";
        //        this.cbe_PosTypeList.Text = "所有";
            
        //        return;
        //    }
        //    if (this.cbe_Col.Text.Trim() == "")
        //    {
        //        this.ShowMessage("信息提示", "列不能为空");
        //        return;
        //    }
        //    int rowth = int.Parse(this.cbe_Row.Text.Trim());
        //    int colth = int.Parse(this.cbe_Col.Text.Trim());
        //    this.presenter.IniLayers(this.cbe_HouseName.Text.Trim(), rowth, colth);
        //}

        //private void cbe_Layer_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.cbe_Row.Text.Trim() == "" || this.cbe_Col.Text.Trim() == "所有"||this.cbe_Layer.Text.Trim()=="所有")
        //    {
        //        //this.ShowMessage("信息提示", "行不能为空");
        //        return;
        //    }
        //    if (this.cbe_Col.Text.Trim() == "")
        //    {
        //        this.ShowMessage("信息提示", "列不能为空");
        //        return;
        //    }
        //    if (this.cbe_Layer.Text.Trim() == "")
        //    {
        //        this.ShowMessage("信息提示", "层不能为空");
        //        return;
        //    }
        //    int rowth = int.Parse(this.cbe_Row.Text.Trim());
        //    int colth = int.Parse(this.cbe_Col.Text.Trim());
        //    int layerth = int.Parse(this.cbe_Layer.Text.Trim());
        //    this.presenter.IniPos(this.cbe_HouseName.Text.Trim(), rowth, colth, layerth);
        //}

       
    
 
    
    }
}