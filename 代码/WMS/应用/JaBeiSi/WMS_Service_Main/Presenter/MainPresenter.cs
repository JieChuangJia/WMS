using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aoyou_Service;
using WMS_Service;
using WMS_Database;

namespace WMS_Service_Main
{
    public class MainPresenter
    {
        private SysLogBLL bllSysLog = new SysLogBLL();
        AoyouSvrManager aoyouSvrManager = new AoyouSvrManager();
        WMS_Svr_Manager wmsSvrManger = new WMS_Svr_Manager();
        public MainPresenter()
        { }

        public bool AddDBLog(SysLogModel logModel)
        {
            if (logModel == null)
            {
                return false;
            }
            return bllSysLog.Add(logModel);
        }
    }
}
