using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface IPalletManageView:IBaseView
    {
        void IniHouseName(List<WH_WareHouseModel> houseList);
        void IniPalletPos(List<string> stationList);

        void IniPlanList(List<string> planList);
    }
}
