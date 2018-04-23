using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface IStorageView:IBaseView
    {
        void RefreshHouseListData(List<WH_WareHouseModel> houseList);
        void BingHouseRowData(List<string> rowList);
        void RefreshPos(List<Positions> posList);
        void InitPosTypeList(List<string> posList);

        void SetPosTxt(string posType);
         void RefreshData();
        void GsSearch(int columnth, int layerth);
    }
}
