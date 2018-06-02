using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class TaskListViewData
    {
        private BindingList<ManageTask> taskListData = new BindingList<ManageTask>();
        public BindingList<ManageTask> TaskListData { get { return this.taskListData; } set { this.taskListData = value; } }

        private BindingList<PalletInfor> taskDetailData = new BindingList<PalletInfor>();
        public BindingList<PalletInfor> TaskDetailData { get { return this.taskDetailData; } set { this.taskDetailData = value; } }

    }
    public class ManageTask
    {
        public string 托盘条码 { get; set; }
        public string 任务类型 { get; set; }
        public string 任务状态 { get; set; }
      
        public string 起始位置 { get; set; }
        public string 终止位置 { get; set; }
        public string 操作员 { get; set; }
        public string 开始时间 { get; set; }
        //public string 结束时间 { get; set; }


        public ManageTask()
        { }
    }
}
