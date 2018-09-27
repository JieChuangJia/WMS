using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class UserManaPresenter :BasePresenter<IUserManaView>
    {
        private SysUserBll bllUser = new SysUserBll();
       
        private GoodsBll bllGoods = new GoodsBll();
        public UserManaPresenter(IUserManaView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }
        
        public void QueryUserList(string showUserProperty)
        {
            List<SysUserModel> userList = bllUser.GetModelByUserInfo(showUserProperty);
            ViewDataManager.USERVIEWDATA.UserListData.Clear();
            if (userList == null)
            {
                return;
            }

            foreach (SysUserModel user in userList)
            {
                UserDataModel userModel = new UserDataModel();
                userModel.用户名称 = user.SysUser_Name;
                userModel.用户预留 = user.SysUser_Reserve;
                userModel.用户密码 = user.SysUser_Password;
                userModel.角色名称 = user.SysRole_Name;
                ViewDataManager.USERVIEWDATA.UserListData.Add(userModel);
            }

        }

     

     

        public bool DeleteUser(string userName)
        {
            return bllUser.Delete(userName);
        }

    }
}
