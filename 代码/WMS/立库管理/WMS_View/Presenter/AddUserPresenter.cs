using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class AddUserPresenter : BasePresenter<IAddUserView>
    {
        private SysUserBll bllUser = new SysUserBll();
        private SysRoleBll bllRole = new SysRoleBll();
        public AddUserPresenter(IAddUserView view)
            : base(view,null)
        { }

        public List<string> LoadRoleName()
        {
            List<SysRoleModel> modelList = bllRole.GetModelList("");
            if(modelList == null || modelList.Count == 0)
            {
                return null;
            }
            List<string> nameList = new List<string>();
            for(int i = 0;i<modelList.Count;i++)
            {
                nameList.Add(modelList[i].SysRole_Name);
            }
            return nameList;
        }

        public bool AddUserModel(User user)
        {
            SysUserModel model = bllUser.GetModel(user.UserName);
            if(model != null)
            {
                bllUser.Delete(model.SysUser_Name);
            }
            model = new SysUserModel();
            model.SysUser_Name = user.UserName;
            model.SysUser_Password = user.UserPassword;
            model.SysRole_Name = user.UserRoleName;
            model.SysUser_Reserve = user.UserReserve;
            return bllUser.Add(model);
        }

        public bool ModifyUserModel(string oldUserName, User user)
        {
            SysUserModel model = bllUser.GetModel(oldUserName); 
            if(model == null)
            {
                return false;
            }
            model.SysUser_Name = user.UserName;
            model.SysUser_Password = user.UserPassword;
            model.SysRole_Name = user.UserRoleName;
            model.SysUser_Reserve = user.UserReserve;
            return bllUser.Update(model);
        }

        public bool ModUserPassword(User user)
        {
            SysUserModel model = bllUser.GetModel(user.UserName);
            if (model == null)
            {
                return false;
            }
            model.SysUser_Password = user.UserPassword;
            return bllUser.Update(model);
        }

        public bool CheckLoginUser(User user,ref int roleLevel)
        {
            SysUserModel model = bllUser.GetModel(user.UserName);
            if(model == null)
            {
                return false;
            }
            SysRoleModel role = bllRole.GetModel(model.SysRole_Name);
            if(role == null)
            {
                return false;
            }
            roleLevel = role.SysRole_Level;
            return true;
        }

        public bool CheckLoginPassword(User user)
        {
            SysUserModel model = bllUser.GetModel(user.UserName);
            if (model == null)
            {
                return false;
            }
            if(string.Compare(model.SysUser_Password,user.UserPassword) == 0)
            {
                return true;
            }
            return false;
        }

    }
}
