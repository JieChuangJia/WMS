using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
namespace WMS_Interface
{
    public class SysLogViewData
    {
        private BindingList<SysLogViewDataModel> sysLogData = new BindingList<SysLogViewDataModel>();
        public BindingList<SysLogViewDataModel> SysLogData
        {
            get { return this.sysLogData; }
            set { this.sysLogData = value; }
        }
    }

    public class SysLogViewDataModel
    {
        public DataTable SysLogData { get; set; }
        public SysLogViewDataModel()
        { }

    }
}
