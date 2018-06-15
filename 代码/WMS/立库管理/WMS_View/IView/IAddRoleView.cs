using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;

namespace WMS_Kernel
{
    public class UserRole
    {
        public string RoleName { get; set; }
        public int RoleLevel { get; set; }
        public string RoleDesc { get; set; }
        public string RoleRemark { get; set; }


    }
    public interface IAddRoleView
    {
      
    }
}
