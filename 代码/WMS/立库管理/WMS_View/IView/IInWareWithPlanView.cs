using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface IInWareWithPlanView:IBaseView
    {
        void IniHouseName(List<WH_WareHouseModel> houseList);
        void IniPlanList(List<View_PlanMainModel> planList);
        void IniTargetPos(List<string> stationList);
    }
}
