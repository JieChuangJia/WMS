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
    public partial class UnShelvePlanView : ChildViewBase,IUnShelvePlanView
    {
        UnShelvePlanPresenter presenter = null;
        public UnShelvePlanView()
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
            presenter = new UnShelvePlanPresenter(this, wmsFrame);
            presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.MaterialLoad.ToBitmap();
            this.IWmsFrame.AddTitlePage("任务管理", ref restr);
            this.IWmsFrame.AddGroup("任务管理", "任务操作", ref restr);
            this.IWmsFrame.AddButtonItem("任务管理", "任务操作", "按计划下架", bitmap, ShowTabEventHandler, ref restr);
            this.IWmsFrame.SetTabChangeEvent(TabChangeEventHandler);
        }
        private void TabChangeEventHandler(object sender, EventArgs e)
        {
            DevExpress.XtraTabbedMdi.MdiTabPageEventArgs tabEventArgs = e as DevExpress.XtraTabbedMdi.MdiTabPageEventArgs;
            if (tabEventArgs.Page == null)
            {
                return;
            }
            if (tabEventArgs.Page.Text == "按计划下架")
            {
                this.presenter.IniPlanList();
            }
        }
  
        private void BindGridData()
        {
            this.gc_PlanList.DataBindings.Clear();
            this.gc_PlanList.DataBindings.Add("DataSource", ViewDataManager.UNSHELVEPALNDATA, "PlanListData", false, DataSourceUpdateMode.OnPropertyChanged);
            this.gc_Stock.DataBindings.Clear();
            this.gc_Stock.DataBindings.Add("DataSource", ViewDataManager.UNSHELVEPALNDATA, "PalletInforData", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        public void IniPlanList(List<View_PlanMainModel> planList)
        {
            this.cbe_PlanList.Properties.Items.Clear();

            if (planList == null)
            {
                return;
            }
            foreach (View_PlanMainModel plan in planList)
            {
                this.cbe_PlanList.Properties.Items.Add(plan.Plan_Code);
            }
            if (this.cbe_PlanList.Properties.Items.Count > 0)
            {
                this.cbe_PlanList.SelectedIndex = 0;
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

        
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        private void cbe_PlanList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sb_PlanQuery_Click(object sender, EventArgs e)
        {
            if (this.cbe_PlanList.Text.Trim() == "")
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            this.presenter.QueryPlan(this.cbe_PlanList.Text.Trim()); 
        }

        private void gc_PlanList_Click(object sender, EventArgs e)
        {
            if (this.gv_PlanList == null || this.gv_PlanList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_PlanList.GetSelectedRows()[0];
            string goodsCode = this.gv_PlanList.GetRowCellValue(currRow, "物料编码").ToString();

            this.presenter.QueryStockInfor(goodsCode);
        }

        private void gc_Stock_Click(object sender, EventArgs e)
        {
            //if (this.gv_PlanList == null || this.gv_PlanList.GetSelectedRows().Count() == 0)
            //{
            //    this.ShowMessage("信息提示", "请选择计划编号！");
            //    return;
            //}
            //if(this.gv_Stock.GetSelectedRows().Count()==0)
            //{
            //    return;
            //}
            //int currRow = this.gv_Stock.GetSelectedRows()[0];
            //string palletCode = this.gv_Stock.GetRowCellValue(currRow, "托盘条码").ToString();

            //this.presenter.GetUnShelveStation(palletCode);
        }

        private void sb_UnShelveTask_Click(object sender, EventArgs e)
        {
            int status = this.AskMessage("信息提示", "您确定下架当前选中物料么？");
            if (status != 0)
            {
                return;
            }

            if (this.gv_PlanList == null || this.gv_PlanList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            if(this.gv_Stock.GetSelectedRows().Count()==0)
            {
                this.ShowMessage("信息提示", "请选择要下架的库存！");
                
                return;
            }
            int currRow = this.gv_Stock.GetSelectedRows()[0];
            string palletCode = this.gv_Stock.GetRowCellValue(currRow, "托盘条码").ToString();
            string unshelveStationName = this.ce_TargetStation.Text.Trim();
            this.presenter.UnShelveTask(this.cbe_PlanList.Text.Trim(),palletCode, unshelveStationName);
        }

        private void gv_PlanList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gv_PlanList == null || this.gv_PlanList.GetSelectedRows().Count() == 0)
            {
                //this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_PlanList.GetSelectedRows()[0];
            string goodsCode = this.gv_PlanList.GetRowCellValue(currRow, "物料编码").ToString();

            this.presenter.QueryStockInfor(goodsCode);
        }

    
 
    
    }
}