using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface IStockTakingUnshelveView:IBaseView
    {
        void RefreshHouseListData(List<WH_WareHouseModel> houseList);
        void InitPosTypeList(List<string> posList);
    }
}
