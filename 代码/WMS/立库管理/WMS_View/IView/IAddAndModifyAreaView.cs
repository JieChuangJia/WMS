using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WareArea
    {
        public string AreaID { get; set; }
        public string WareHouseID { get; set; }

        public string WareHouseName { get; set; }
        public string AreaName { get; set; }
        public string AreaEnableStatus { get; set; }
        public string AreaBackColor { get; set; }
        public string AreaCode { get; set; }
        public string AreaType { get; set; }



    }
    public interface IAddAndModifyAreaView:IBaseView
    {
        
    }
}
