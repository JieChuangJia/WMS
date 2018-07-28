using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WHStation
    {
        public string WHStationLogic { get; set; }
        public string WHCellID { get; set; }
        public string WareHouseID{ get; set; }

        public string WHStationLogicType { get; set; }
        public string WHStationLogicName { get; set; }

    }
    public interface IAddAndModifyWHStationView : IBaseView
    {
        void ShowWareHouseCodeList(List<string> wareHouseCodeList);
        void ShowStationTypeList(List<string> items);
        void ShowStationIDList(List<string> items);
    }
}
