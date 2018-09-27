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
        //Action<string> showRoleProperty = null;
        public RoleManaPresenter(IRoleManaView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }

        //public void ResgistShowRoleProperty(Action<string> showRoleProperty)
        //{
        //    this.showRoleProperty = showRoleProperty; 
        //}
        public void QueryRoleList(string roleInfo)
        {

            List<SysRoleModel> roleList = bllRole.GetModelByRoleInfo(roleInfo);
            ViewDataManager.ROLEVIEWDATA.RoleListData.Clear();
            if (roleList == null)
            {
                return;
            }

            foreach (SysRoleModel role in roleList)
            {
                RoleDataModel roleModel = new RoleDataModel();
                roleModel.角色名称 = role.SysRole_Name;
                roleModel.角色备注 = role.SysRole_Remark;
                roleModel.角色描述 = role.SysRole_Desc;
                roleModel.角色等级 = role.SysRole_Level;
                ViewDataManager.ROLEVIEWDATA.RoleListData.Add(roleModel);
            }

        }

        public bool DeleteRole(string roleName)
        {
            return bllRole.Delete(roleName);
        }

    }
}
