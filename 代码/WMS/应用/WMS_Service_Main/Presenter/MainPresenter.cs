using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aoyou_Service;
using WMS_Service;

namespace WMS_Service_Main
{
    public class MainPresenter
    {
        AoyouSvrManager aoyouSvrManager = new AoyouSvrManager();
        WMS_Svr_Manager wmsSvrManger = new WMS_Svr_Manager();
        public MainPresenter()
        { }
    }
}
