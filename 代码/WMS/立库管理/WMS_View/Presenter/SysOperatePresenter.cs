using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WMS_Interface;
using WMS_Database;

namespace WMS_Kernel
{
   public class SysOperatePresenter:BasePresenter<ISysOperateView>
    {
       WH_Cell_Operate_RecordBLL bllCellOperate = new WH_Cell_Operate_RecordBLL();
       WH_WareHouseBll bllHouse = new WH_WareHouseBll();
       public SysOperatePresenter(ISysOperateView view, IWMSFrame wmsFrame)
           : base(view, wmsFrame)
       {

       }
       public override void Init() 
       {
           InitHouseList();
       }
       public void Query(DateTime stDt, DateTime edDt, string operateType, bool likeQueryChecked, string likeQueryValue,string houseName,bool gsChecked,string gsName)
       {
           DataTable dt = bllCellOperate.GetOperate(stDt, edDt, operateType, likeQueryChecked, likeQueryValue, houseName,gsChecked,gsName);
           this.View.ShowOperate(dt);
       }
       private void InitHouseList()
       {
           List<WH_WareHouseModel> houseList = bllHouse.GetModelList("");

           this.View.IniHouseName(houseList);
       }
    }
}
