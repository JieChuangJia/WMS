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
    public partial class TaskListView : ChildViewBase,ITaskListView
    {
        private TaskListPresenter presenter = null;

        public TaskListView()
        {
            InitializeComponent();
        }
        private void TaskListView_Load(object sender, EventArgs e)
        {
            DataBingding();
            IniTaskStatusList();
            IniTaskTypeList();
        }


        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new TaskListPresenter(this, wmsFrame);
            string restr = "";

            Bitmap bitmap = ImageResource.TaskList.ToBitmap();
            this.IWmsFrame.AddTitlePage("任务管理", ref restr);
            this.IWmsFrame.AddGroup("任务管理", "任务操作", ref restr);
            this.IWmsFrame.AddButtonItem("任务管理", "任务操作", "任务列表", bitmap, ShowTabEventHandler, ref restr);
        }
        private void DataBingding()
        {
            this.gc_TaskList.DataBindings.Clear();
            this.gc_TaskList.DataBindings.Add("DataSource", ViewDataManager.TASKLISTDATA, "TaskListData", false, DataSourceUpdateMode.OnPropertyChanged);
            this.gc_TaskDetail.DataBindings.Clear();
            this.gc_TaskDetail.DataBindings.Add("DataSource", ViewDataManager.TASKLISTDATA, "TaskDetailData", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }
        private void IniTaskStatusList()
        {
            this.cbe_TaskStatus.Properties.Items.Clear();
            this.cbe_TaskStatus.Properties.Items.Add("所有");
          
            for (int i = 0; i < Enum.GetNames(typeof(EnumManageTaskStatus)).Count(); i++)
            {
                string taskStatus = Enum.GetNames(typeof(EnumManageTaskStatus))[i];
                this.cbe_TaskStatus.Properties.Items.Add(taskStatus);
            }
            if (this.cbe_TaskStatus.Properties.Items.Count > 0)
            {
                this.cbe_TaskStatus.SelectedIndex = 0;
            }
        }

        private void IniTaskTypeList()
        {
            this.cbEdit_TaskType.Properties.Items.Clear();
            this.cbEdit_TaskType.Properties.Items.Add("所有");
            
            for (int i = 0; i < Enum.GetNames(typeof(EnumManageTaskType)).Count(); i++)
            {
                string taskType = Enum.GetNames(typeof(EnumManageTaskType))[i];
                this.cbEdit_TaskType.Properties.Items.Add(taskType);
            }
          
            if (this.cbEdit_TaskType.Properties.Items.Count > 0)
            {
                this.cbEdit_TaskType.SelectedIndex = 0;
            }
        }

        private void sb_TaskQuery_Click(object sender, EventArgs e)
        {
            this.presenter.QueryTask(this.cbEdit_TaskType.Text.Trim(), this.cbe_TaskStatus.Text.Trim());
        }

        //private void gc_TaskList_Click(object sender, EventArgs e)
        //{
        //    if (this.gv_TaskList == null || this.gv_TaskList.GetSelectedRows().Count() == 0)
        //    {
        //        this.ShowMessage("信息提示", "请选择计划编号！");
        //        return;
        //    }
        //    int currRow = this.gv_TaskList.GetSelectedRows()[0];
        //    string palletCode = this.gv_TaskList.GetRowCellValue(currRow, "托盘条码").ToString();
        //    this.presenter.QueryTaskDetail(palletCode);
        //}

        private void sb_TaskComplete_Click(object sender, EventArgs e)
        {
            if(this.AskMessage("询问","您确定要手动完成选中任务？")!= 0)
            {
                return;
            }
            if (this.gv_TaskList == null || this.gv_TaskList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_TaskList.GetSelectedRows()[0];
            string palletCode = this.gv_TaskList.GetRowCellValue(currRow, "托盘条码").ToString();
            this.presenter.CompleteTaskManual(palletCode);
        }

        private void gv_TaskList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gv_TaskList == null || this.gv_TaskList.GetSelectedRows().Count() == 0)
            {
                //this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_TaskList.GetSelectedRows()[0];
            string palletCode = this.gv_TaskList.GetRowCellValue(currRow, "托盘条码").ToString();
            this.presenter.QueryTaskDetail(palletCode);
        }
 
    }
}