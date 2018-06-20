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

    public class RoleDataModel
    {
        public string 角色名称 { get; set; }
        public int 角色等级 { get; set; }

        public string 角色描述 { get; set; }
        public string 角色备注 { get; set; }

        public RoleDataModel()
        { }

    }
}
