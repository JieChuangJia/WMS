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
namespace WMS_Kernel
{
    public partial class StockQueryView : ChildViewBase, IStockQueryView
    {
        StockQueryPresenter presenter = null;
        public StockQueryView()
        {
            InitializeComponent();

        }

        private void StockQueryView_Load(object sender, EventArgs e)
        {
            this.presenter.Init();
            BindGridData();
             
         
         
        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new StockQueryPresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.PlanQuery.ToBitmap();
            this.IWmsFrame.AddTitlePage("库存管理", ref restr);
            this.IWmsFrame.AddGroup("库存管理", "库存管理", ref restr);
            this.IWmsFrame.AddButtonItem("库存管理", "库存管理", "库存查询", bitmap, ShowTabEventHandler, ref restr);


           
        }

        public void IniHouseList(List<string> items)
        {
            this.cbe_HouseList.Properties.Items.Clear();

            if (items == null)
            {
                return;
            }
            //this.cbe_HouseList.Properties.Items.Add("所有");
            foreach (string item in items)
            {
                this.cbe_HouseList.Properties.Items.Add(item);
            }
            if (this.cbe_HouseList.Properties.Items.Count > 0)
            {
                this.cbe_HouseList.SelectedIndex = 0;
            }
        }
        
        public void IniRowList(List<string> items)
        {
            this.cbe_Row.Properties.Items.Clear();

            if (items == null)
            {
                return;
            }
            this.cbe_Row.Properties.Items.Add("所有");
            foreach (string item in items)
            {
                this.cbe_Row.Properties.Items.Add(item);
            }
            if (this.cbe_Row.Properties.Items.Count > 0)
            {
                this.cbe_Row.SelectedIndex = 0;
            }
        }
        public void IniColList(List<string> items)
        {
            this.cbe_Col.Properties.Items.Clear();

            if (items == null)
            {
                return;
            }
            this.cbe_Col.Properties.Items.Add("所有");
            foreach (string item in items)
            {
                this.cbe_Col.Properties.Items.Add(item);
            }
            if (this.cbe_Col.Properties.Items.Count > 0)
            {
                this.cbe_Col.SelectedIndex = 0;
            }
        }

        public void IniLayerList(List<string> items)
        {
            this.cbe_Layer.Properties.Items.Clear();

            if (items == null)
            {
                return;
            }
            this.cbe_Layer.Properties.Items.Add("所有");
            foreach (string item in items)
            {
                this.cbe_Layer.Properties.Items.Add(item);
            }
            if (this.cbe_Layer.Properties.Items.Count > 0)
            {
                this.cbe_Layer.SelectedIndex = 0;
            }
        }
        public void IniMaterialCateList(List<string> items)
        {
            this.cbe_MaterialCate.Properties.Items.Clear();

            if (items == null)
            {
                return;
            }
            this.cbe_MaterialCate.Properties.Items.Add("所有");
            foreach (string item in items)
            {
                this.cbe_MaterialCate.Properties.Items.Add(item);
            }
            if (this.cbe_MaterialCate.Properties.Items.Count > 0)
            {
                this.cbe_MaterialCate.SelectedIndex = 0;
            }
        }
        public void IniPalletList(List<string> items)
        {
            this.cbe_PalletCode.Properties.Items.Clear();

            if (items == null)
            {
                return;
            }
            this.cbe_PalletCode.Properties.Items.Add("所有");
            foreach (string item in items)
            {
                this.cbe_PalletCode.Properties.Items.Add(item);
            }
            if (this.cbe_PalletCode.Properties.Items.Count > 0)
            {
                this.cbe_PalletCode.SelectedIndex = 0;
            }
        }
        private void BindGridData()
        {
            this.gc_CellList.DataBindings.Clear();
            this.gc_CellList.DataBindings.Add("DataSource", ViewDataManager.STOCKQUERYDATAVIEWDATA, "StockList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.gC_CellDetailList.DataBindings.Clear();
            this.gC_CellDetailList.DataBindings.Add("DataSource", ViewDataManager.STOCKQUERYDATAVIEWDATA, "StockDetailList", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        private void gc_PlanList_Click(object sender, EventArgs e)
        {
            if (this.gv_CellList == null || this.gv_CellList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择货位！");
                return;
            }
            int currRow = this.gv_CellList.GetSelectedRows()[0];
            string cellCode = this.gv_CellList.GetRowCellValue(currRow, "货位编码").ToString();
            this.presenter.QueryStockDetail(cellCode);
            //this.presenter.QueryPlanList(planCode);

        }

        private void sb_TrayQuery_Click(object sender, EventArgs e)
        {
        //    if ((this.dateEdit_EndTime.DateTime - this.dateEdit_StartTime.DateTime).TotalSeconds < 0)
        //    {
        //        this.ShowMessage("信息提示", "开始时间大于结束时间！");
        //        return;
        //    }
            //this.presenter.QueryPlan(this.dateEdit_StartTime.DateTime, this.dateEdit_EndTime.DateTime, this.ce_PlanType.Text.Trim(), this.cbe_PlanStatus.Text.Trim(), this.te_PlanID.Text.Trim());
            if(this.cbe_PalletCode.Text == "")
            {
                this.ShowMessage("信息提示", "请输入托盘条码！");
                return;
            }
            StockQueryParm paramModel = new StockQueryParm();
            paramModel.HouseName = this.cbe_HouseList.Text.Trim();
            paramModel.Rowth = this.cbe_Row.Text.Trim();
            paramModel.Colth = this.cbe_Col.Text.Trim();
            paramModel.Layer = this.cbe_Layer.Text.Trim();
            paramModel.MaterialCate = this.cbe_MaterialCate.Text.Trim();
            paramModel.PalletCode = this.cbe_PalletCode.Text.Trim();

            this.presenter.QueryStock(paramModel);
        }
         
        private void gv_PlanList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gv_CellList == null || this.gv_CellList.GetSelectedRows().Count() == 0)
            {
                //this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = e.FocusedRowHandle;
            //string planCode = this.gv_CellList.GetRowCellValue(currRow, "计划单号").ToString();
            //this.presenter.QueryPlanList(planCode);
        }

        private void cbe_HouseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string houseName = this.cbe_HouseList.Text.Trim();
            this.presenter.InitHouseRowList(houseName);
        }

        private void cbe_Row_SelectedIndexChanged(object sender, EventArgs e)
        {
            string houseName = this.cbe_HouseList.Text.Trim();
            string row = this.cbe_Row.Text.Trim();
            this.presenter.InitHouseColList(houseName,row);
        }

        private void cbe_Col_SelectedIndexChanged(object sender, EventArgs e)
        {
            string houseName = this.cbe_HouseList.Text.Trim();
            string row = this.cbe_Row.Text.Trim();
            string col = this.cbe_Col.Text.Trim();
            this.presenter.InitHouseLayerList(houseName, row,col);
        }

    

    }
}