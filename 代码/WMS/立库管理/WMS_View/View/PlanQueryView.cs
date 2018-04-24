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
    public partial class PlanQueryView : ChildViewBase,IPlanQueryView
    {
        PlanQueryPresenter presenter = null;
        public PlanQueryView()
        {
            InitializeComponent();

        }

        private void PlanQueryView_Load(object sender, EventArgs e)
        {
            BindGridData();
            IniPlanStatusList();
            this.dateEdit_StartTime.DateTime = DateTime.Now.AddMonths(-1);
            this.dateEdit_EndTime.DateTime = DateTime.Now;
         
        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new PlanQueryPresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.PlanQuery.ToBitmap();
            this.IWmsFrame.AddTitlePage("计划管理", ref restr);
            this.IWmsFrame.AddGroup("计划管理", "计划管理", ref restr);
            this.IWmsFrame.AddButtonItem("计划管理", "计划管理", "计划查询", bitmap, ShowTabEventHandler, ref restr);


           
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
        private void IniPlanStatusList( )
        {
            this.cbe_PlanStatus.Properties.Items.Clear();

           
            this.cbe_PlanStatus.Properties.Items.Add("所有");
            foreach (string planStatus in Enum.GetNames(typeof(EnumPlanStatus)))
            {
                this.cbe_PlanStatus.Properties.Items.Add(planStatus);
            }
            if (this.cbe_PlanStatus.Properties.Items.Count > 0)
            {
                this.cbe_PlanStatus.SelectedIndex = 0;
            }
        }
        private void BindGridData()
        {
            this.gc_PlanList.DataBindings.Clear();
            this.gc_PlanList.DataBindings.Add("DataSource", ViewDataManager.PLANQUERYDATA, "PlanData", false, DataSourceUpdateMode.OnPropertyChanged);
            this.gc_PlanGoodsList.DataBindings.Clear();
            this.gc_PlanGoodsList.DataBindings.Add("DataSource", ViewDataManager.PLANQUERYDATA, "PlanDetailData", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        private void gc_PlanList_Click(object sender, EventArgs e)
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

        private void sb_TrayQuery_Click(object sender, EventArgs e)
        {
            this.presenter.QueryPlan(this.dateEdit_StartTime.DateTime, this.dateEdit_EndTime.DateTime, this.ce_PlanType.Text.Trim(), this.cbe_PlanStatus.Text.Trim(), this.te_PlanID.Text.Trim());

        }
         
        private void gv_PlanList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gv_PlanList == null || this.gv_PlanList.GetSelectedRows().Count() == 0)
            {
                //this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_PlanList.GetSelectedRows()[0];
            string planCode = this.gv_PlanList.GetRowCellValue(currRow, "计划单号").ToString();
            this.presenter.QueryPlanList(planCode);
        }
         

    }
}