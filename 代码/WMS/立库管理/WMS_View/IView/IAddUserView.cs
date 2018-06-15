using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;

namespace WMS_Kernel
{
    public class User
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRoleName { get; set; }
        public string UserReserve { get; set; }


    }
    public interface IAddUserView
    {

    }
}
