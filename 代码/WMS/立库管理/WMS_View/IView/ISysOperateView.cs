using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface ISysOperateView:IBaseView
    {
        void IniHouseName(List<WH_WareHouseModel> houseList);
        void ShowOperate(DataTable operate);
    }
  
}
