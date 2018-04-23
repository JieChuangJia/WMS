using CommonMoudle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;

namespace WMS_Service
{
    public class WMS_Svr_Manager
    {
        WCFManager<IWMSToWCSSvr> wmsServ = new WCFManager<IWMSToWCSSvr>();

        WmsToWcsSvr wmsToWcsSr = new WmsToWcsSvr();
        public WMS_Svr_Manager()
        {
            this.wmsServ.SetServiceContractObj(wmsToWcsSr);
        }

        public bool StartWMSServ(Uri servAddr, ref string restr)
        {
            return wmsServ.Start(servAddr, ref restr);
        }
        public bool StopWMSServ(ref string restr)
        {
            return wmsServ.Stop(ref restr);
        }
    }
}
