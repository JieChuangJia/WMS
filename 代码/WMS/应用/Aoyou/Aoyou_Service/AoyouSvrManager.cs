using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonMoudle;
using WMSTools;

namespace Aoyou_Service
{
    public class AoyouSvrManager
    {
        WCFManager<IWMS_To_ERP> erpServ = new WCFManager<IWMS_To_ERP>();
        WCFManager<IWMS_To_MES> mesServ = new WCFManager<IWMS_To_MES>();

        WMS_To_ERPPresenter erpSvrPresenter = new WMS_To_ERPPresenter();
        WMS_To_MESPresenter mesSvrPreseter = new WMS_To_MESPresenter();
        public AoyouSvrManager()
        {
            this.erpServ.SetServiceContractObj(erpSvrPresenter);
            this.mesServ.SetServiceContractObj(mesSvrPreseter);
        }
        
        public bool StartERPServ(Uri servAddr,ref string restr)
        {
            return erpServ.Start(servAddr,EnumWCFProtocol.BasicHttp, ref restr); 
        }
        public bool StopERPServ(ref string restr)
        {
            return erpServ.Stop(ref restr);
        }
        public bool StartMESServ(Uri servAddr,ref string restr)
        {
            return mesServ.Start(servAddr, EnumWCFProtocol.BasicHttp,ref restr);
        }

        public bool StopMESServ(ref string restr)
        {
            return mesServ.Stop(ref restr);
        }

        public void GetTest()
        {
            //WMSTools.BusinessOperation.CreatePurchaseInStock()
        }

    }
}
