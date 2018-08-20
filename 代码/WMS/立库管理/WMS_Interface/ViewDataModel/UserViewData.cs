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

  
}
