using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class RoleViewData
    {
        private BindingList<RoleDataModel> roleListData = new BindingList<RoleDataModel>();
        public BindingList<RoleDataModel> RoleListData { get { return this.roleListData; } set { this.roleListData = value; } }


        public RoleViewData()
        { }
    }

  
}
