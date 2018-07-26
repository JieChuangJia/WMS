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
    public partial class RecordQueryView : ChildViewBase, IRecordQueryView
    {
        RecordQueryPresenter presenter = null;
        public RecordQueryView()
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
            this.presenter = new RecordQueryPresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.PlanQuery.ToBitmap();
            this.IWmsFrame.AddTitlePage("日志", ref restr);
            this.IWmsFrame.AddGroup("日志", "日志", ref restr);
            this.IWmsFrame.AddButtonItem("日志", "日志", "搬运记录查询", bitmap, ShowTabEventHandler, ref restr);


           
        }

        public void IniPlanTypeList(List<string> planTypeList)
        {
            //this.cbe_RecordType.Properties.Items.Clear();

            //if (planTypeList == null)
            //{
            //    return;
            //}
            //this.cbe_RecordType.Properties.Items.Add("所有");
            //foreach (string plantype in planTypeList)
            //{
            //    this.cbe_RecordType.Properties.Items.Add(plantype);
            //}
            //if (this.cbe_RecordType.Properties.Items.Count > 0)
            //{
            //    this.cbe_RecordType.SelectedIndex = 0;
            //}
        }
       
        private void BindGridData()
        {
            this.gc_RecordList.DataBindings.Clear();
            this.gc_RecordList.DataBindings.Add("DataSource", ViewDataManager.RECORDQUERYDATA, "RecordList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.gc_RecordDetail.DataBindings.Clear();
            this.gc_RecordDetail.DataBindings.Add("DataSource", ViewDataManager.RECORDQUERYDATA, "RecordDetailList", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        private void gc_PlanList_Click(object sender, EventArgs e)
        {
            if (this.gv_RecordList == null || this.gv_RecordList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_RecordList.GetSelectedRows()[0];
            string planCode = this.gv_RecordList.GetRowCellValue(currRow, "计划单号").ToString();
             

        }

        private void sb_TrayQuery_Click(object sender, EventArgs e)
        {
            if ((this.dateEdit_EndTime.DateTime - this.dateEdit_StartTime.DateTime).TotalSeconds < 0)
            {
                this.ShowMessage("信息提示", "开始时间大于结束时间！");
                return;
            }
            
        }
         
        private void gv_PlanList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gv_RecordList == null || this.gv_RecordList.GetSelectedRows().Count() == 0)
            {
                //this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = e.FocusedRowHandle;
            string planCode = this.gv_RecordList.GetRowCellValue(currRow, "计划单号").ToString();
          
        }

     

    }
}