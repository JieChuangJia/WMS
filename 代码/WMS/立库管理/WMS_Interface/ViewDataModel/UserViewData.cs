using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class UserViewData
    {
        private BindingList<UserDataModel> userListData = new BindingList<UserDataModel>();
        public BindingList<UserDataModel> UserListData { get { return this.userListData; } set { this.userListData = value; } }


        public UserViewData()
        { }
    }

    public class UserDataModel
    {
        public string 用户名称 { get; set; }
        public string 用户密码 { get; set; }

        public string 角色名称 { get; set; }
        public string 用户预留 { get; set; }

        public UserDataModel()
        { }

    }
}
