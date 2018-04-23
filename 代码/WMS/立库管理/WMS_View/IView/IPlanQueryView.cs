using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface IPlanQueryView:IBaseView
    {
        void IniPlanTypeList(List<string> planTypeList);
    }
}
