using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public interface IWMSExtern
    {
        bool AddExternPlan(string planCode, string planTypeName, string planPerson, DateTime planDate, string warehouseCode, List<PlanListModel> planDetailList, ref string restr);
        //event EventHandler<PutwayEventArgs> PutwayEventHandler;
    }
}
