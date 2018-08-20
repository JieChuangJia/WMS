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
    
}
