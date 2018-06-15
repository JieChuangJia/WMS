using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class RoleManaPresenter :BasePresenter<IRoleManaView>
    {
        private SysRoleBll bllRole = new SysRoleBll();
        Action<string> showRoleProperty = null;
        public RoleManaPresenter(IRoleManaView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }

        public void ResgistShowRoleProperty(Action<string> showRoleProperty)
        {
            this.showRoleProperty = showRoleProperty; 
        }
        public void QueryRoleList(string roleInfo)
        {
            if (this.showRoleProperty == null)
            {
                return;
            }
            this.showRoleProperty(roleInfo);

        }

        public bool DeleteRole(string roleName)
        {
            return bllRole.Delete(roleName);
        }

    }
}
