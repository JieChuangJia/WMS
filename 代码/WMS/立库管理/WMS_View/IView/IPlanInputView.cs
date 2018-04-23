using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface IPlanInputView:IBaseView
    {
        void IniPlanType(List<string> typeList);
    }
}
