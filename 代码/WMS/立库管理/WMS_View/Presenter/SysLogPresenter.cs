using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WMS_Interface;
using WMS_Database;

namespace WMS_Kernel
{
   public class SysLogPresenter:BasePresenter<ISysLogView>
    {
       SysLogBLL bllSyslog = new SysLogBLL();

       public SysLogPresenter(ISysLogView view,IWMSFrame wmsFrame):base(view,wmsFrame)
       {

       }
       public void Query(DateTime stDt, DateTime edDt, string level, bool likeQueryChecked, string likeQueryValue)
       {
           DataTable dt = bllSyslog.GetLog(stDt, edDt, level, likeQueryChecked, likeQueryValue);
           this.View.ShowLog(dt);
       }
    }
}
