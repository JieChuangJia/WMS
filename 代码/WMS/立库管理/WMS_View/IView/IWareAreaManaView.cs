using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Kernel
{
    public interface IWareAreaManaView
    {
        void RefreshHouseListData(List<string> houseList);
    }
}
