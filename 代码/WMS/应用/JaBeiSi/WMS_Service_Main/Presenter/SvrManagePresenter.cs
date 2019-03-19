using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aoyou_Service;
using WMS_Service;
using WMS_Interface;
using WMS_JBS_Service;

namespace WMS_Service_Main
{
    public class SvrManagePresenter : BasePresenter<ISvrManaView>
    {
        JBS_Service_Manager jsbService = new JBS_Service_Manager();
       
        WMS_Svr_Manager wmsSvrManager = new WMS_Svr_Manager();
        IWMSFrame wmsFrame = null;
        StatusManager statusManager = new StatusManager();
        public SvrManagePresenter(ISvrManaView view)
            : base(view)
        { }
        public void Init(IWMSFrame wmsFrame)
        {
            this.wmsFrame = wmsFrame;
            statusManager.Init(wmsFrame);
        }
        public void StartWMSSvr(Uri svrAddr)
        {
            string restr = "";
            if (wmsSvrManager.StartWMSServ(svrAddr, ref restr) == false)
            {
                this.View.ShowMessage("信息提示", "WMS服务接口启动失败：" + restr);
                this.wmsFrame.WriteLog("服务管理", "", "错误", "WMS服务接口启动失败！");
                return;
            }
            else
            {
                this.wmsFrame.WriteLog("服务管理", "", "提示", "WMS服务接口启动成功！");
            }

        
        }
        public void StopWMSSvr(Uri svrAddr)
        {
            string restr = "";
            if (wmsSvrManager.StartWMSServ(svrAddr, ref restr) == false)
            {
                this.View.ShowMessage("信息提示", "WMS服务接口停止失败：" + restr);
                this.wmsFrame.WriteLog("服务管理", "", "错误", "WMS服务接口停止失败！");
                return;
            }
            else
            {
                this.wmsFrame.WriteLog("服务管理", "", "提示", "WMS服务接口停止成功！");
            }
        }
       
        public void StartERPSvr(Uri svrAddr)
        {
            string restr = "";
            if (jsbService.StartERPService(svrAddr, ref restr) == false)
            {
                this.View.ShowMessage("信息提示", "ERP服务接口启动失败：" + restr);
                this.wmsFrame.WriteLog("服务管理", "", "错误", "ERP服务接口启动失败！");
                return;
            }
            else
            {
                this.wmsFrame.WriteLog("服务管理", "", "提示", "ERP服务接口启动成功！");
            }
        }

        public void StopERPSvr()
        { 
            string str ="";
            this.jsbService.StopERPService(ref str);
        }

    }
}
