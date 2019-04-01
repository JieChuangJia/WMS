using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonMoudle;
using WMS_Database;


namespace WMS_JBS_Service
{

    public class JBS_Service_Manager
    {

        WCFManager<IWMS_To_ERP> erpServ = new WCFManager<IWMS_To_ERP>();

        public   WMS_To_ERPPresenter erpSvrPresenter = new WMS_To_ERPPresenter();
        private static JBS_Service_Manager serviceManager = null;
        private  JBS_Service_Manager()
        {
            this.erpServ.SetServiceContractObj(erpSvrPresenter);
        }
        public static JBS_Service_Manager GetServiceManager()
        {
            if (serviceManager == null)
            {
                serviceManager = new JBS_Service_Manager();
            }
            return serviceManager;
        }
        public bool StartERPService(Uri servAddr, ref string restr)
        {
            return erpServ.Start(servAddr, EnumWCFProtocol.WebHttp, ref restr);
        }
        public bool StopERPService(ref string restr)
        {
            return erpServ.Stop(ref restr);
        }
    }
}
