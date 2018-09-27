using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WHHouse
    {
        public string WareHouse_ID { get; set; }
        public string WareHouse_Code { get; set; }
        public string WareHouse_Name { get; set; }
        public string WareHouse_Type { get; set; }
        public string WareHouse_Flag { get; set; }
        public string WareHouse_Remark { get; set; }
    }
    public interface IAddAndModifyWHHouseView : IBaseView
    {
    }
}
