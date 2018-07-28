using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WHCell
    {
        public string WareHouseID { get; set; }
        public string CellID { get; set; }
        public string AreaID { get; set; }
        public string CellCode { get; set; }
        public string CellName { get; set; }
        public string CellInOut { get; set; }
        public string DeviceCode { get; set; }
        public string CellType { get; set; }
    }
    public interface IAddAndModifyWHCellView : IBaseView
    {
        void ShowAreaIDList(List<string> areaIDList);
    }
}
