using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface IPutawayView:IBaseView
    {
        void IniPutawayList(List<string> cellList);
        //void IniCellList(List<View_CellModel> cellList);
        void IniRows(List<string> rows);
        void IniCols(List<string> cols);
        void IniLayers(List<string> layers);
        void IniPoses(List<string> poses);

        void IniHouseName(List<WH_WareHouseModel> houseList);
        void IniPalletCode(List<string> palletCode);
    }
}
