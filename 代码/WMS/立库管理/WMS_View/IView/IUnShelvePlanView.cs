using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;


namespace WMS_Kernel
{
    public interface IUnShelvePlanView:IBaseView
    {
        void IniPlanList(List<View_PlanMainModel> planList);
        void IniTargetList(List<string> targetStationList);
    }
}
