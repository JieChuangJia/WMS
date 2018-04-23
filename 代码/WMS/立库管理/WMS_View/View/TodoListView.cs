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
    public partial class TodoListView : ChildViewBase,ITodoListView
    {
        TodoListPresenter presenter = null;
        public TodoListView()
        {
            InitializeComponent();

        }

        private void PlanQueryView_Load(object sender, EventArgs e)
        {
            BindGridData();
           
            this.dateEdit_StartTime.DateTime = DateTime.Now.AddMonths(-1);
            this.dateEdit_EndTime.DateTime = DateTime.Now;
        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new  TodoListPresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";
            Bitmap bitmap = ImageResource.PrepareWork.ToBitmap();
            this.IWmsFrame.AddTitlePage("计划管理", ref restr);
            this.IWmsFrame.AddGroup("计划管理", "计划操作", ref restr);
            this.IWmsFrame.AddButtonItem("计划管理", "计划操作", "待办工作", bitmap, ShowTabEventHandler, ref restr);
        }

        public void IniPlanTypeList(List<string> planTypeList)
        {
            this.ce_PlanType.Properties.Items.Clear();

            if (planTypeList == null)
            {
                return;
            }
            this.ce_PlanType.Properties.Items.Add("所有");
            foreach (string plantype in planTypeList)
            {
                this.ce_PlanType.Properties.Items.Add(plantype);
            }
            if (this.ce_PlanType.Properties.Items.Count > 0)
            {
                this.ce_PlanType.SelectedIndex = 0;
            }
        }
    
        private void BindGridData()
        {
            this.gc_PlanList.DataBindings.Clear();
            this.gc_PlanList.DataBindings.Add("DataSource", ViewDataManager.TODOLISTDATA, "PlanData", false, DataSourceUpdateMode.OnPropertyChanged);
            this.gc_PlanGoodsList.DataBindings.Clear();
            this.gc_PlanGoodsList.DataBindings.Add("DataSource", ViewDataManager.TODOLISTDATA, "PlanDetailData", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

    

        private void sb_TrayQuery_Click(object sender, EventArgs e)
        {
            this.presenter.QueryPlan(this.dateEdit_StartTime.DateTime, this.dateEdit_EndTime.DateTime, this.ce_PlanType.Text.Trim(), this.te_PlanID.Text.Trim());

        }

        private void sb_ExePlan_Click(object sender, EventArgs e)
        {
            if (this.gv_PlanList == null || this.gv_PlanList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_PlanList.GetSelectedRows()[0];
            string planCode = this.gv_PlanList.GetRowCellValue(currRow, "计划单号").ToString();
            this.presenter.ExePlan(planCode);
        }

        private void gv_PlanList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gv_PlanList == null || this.gv_PlanList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_PlanList.GetSelectedRows()[0];
            string planCode = this.gv_PlanList.GetRowCellValue(currRow, "计划单号").ToString();
            this.presenter.QueryPlanList(planCode);
        }
         

    }
}