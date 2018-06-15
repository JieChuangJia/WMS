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
        Action<string> showUserProperty = null;
        private GoodsBll bllGoods = new GoodsBll();
        public UserManaPresenter(IUserManaView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }
        public void ResgistShowUserProperty(Action<string> showUserProperty)
        {
            this.showUserProperty = showUserProperty; 
        }
        public void QueryUserList(string showUserProperty)
        {
            if (this.showUserProperty == null)
            {
                return;
            }
            this.showUserProperty(showUserProperty);

        }

        public bool DeleteUser(string userName)
        {
            return bllUser.Delete(userName);
        }

    }
}
