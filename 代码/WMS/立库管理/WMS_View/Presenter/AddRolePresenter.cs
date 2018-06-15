using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class AddRolePresenter : BasePresenter<IAddRoleView>
    {
        private SysRoleBll bllRole = new SysRoleBll();
        private SysUserBll bllUser = new SysUserBll();
        public AddRolePresenter(IAddRoleView view)
            : base(view,null)
        { }

        public bool AddRoleModel(UserRole role)
        {
            SysRoleModel roleModel = bllRole.GetModel(role.RoleName);
            if(roleModel != null)
            {
                bllRole.Delete(role.RoleName);
            }
            roleModel = new SysRoleModel();
            roleModel.SysRole_Name = role.RoleName;
            roleModel.SysRole_Desc = role.RoleDesc;
            roleModel.SysRole_Level = role.RoleLevel;
            roleModel.SysRole_Remark = role.RoleRemark;
            return bllRole.Add(roleModel);
        }

        public bool ModifyRoleModel(string oldRoleName, UserRole role)
        {

            List<SysUserModel> userList = bllUser.GetModelListByRoleName(oldRoleName);
            
            SysRoleModel roleModel = bllRole.GetModel(oldRoleName);
            if (roleModel != null)
            {
                bllRole.Delete(oldRoleName);
            }
            roleModel = new SysRoleModel();
            roleModel.SysRole_Name = role.RoleName;
            roleModel.SysRole_Desc = role.RoleDesc;
            roleModel.SysRole_Level = role.RoleLevel;
            roleModel.SysRole_Remark = role.RoleRemark;
            if (!(bllRole.Add(roleModel)))
            {
                return false;
            }
            if (userList != null && userList.Count != 0)
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    userList[i].SysRole_Name = role.RoleName;
                    bllUser.Add(userList[i]);
                }
            }
            return true;

        }

    }
}
