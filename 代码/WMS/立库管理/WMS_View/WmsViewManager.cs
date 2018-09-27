using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WmsViewManager
    {
        ModPasswordView modPV = new ModPasswordView();
        RoleManaView roleView = new RoleManaView();

        UserManaView userView = new UserManaView();

        LimitManaView limitView = new LimitManaView();

        WareLimitManaView wareLimitView = new WareLimitManaView();

        MaterialManaView materialView = new MaterialManaView();

        TaskListView taskView = new TaskListView();

        PlanImportView planManaView = new PlanImportView();

        TodoListView prepareView = new TodoListView();

        PutawayView materialUnloadView = new PutawayView();
        InWareWithPlanView inWareWithPlanView = new InWareWithPlanView();
        UnShelvePlanView materialLoadWithPlanView = new UnShelvePlanView();
        PalletManaView pallerManaView = new PalletManaView();

        StationShowView stationView = new StationShowView();

        StockQueryView stockQueryView = new StockQueryView();

        PlanQueryView planQueryView = new PlanQueryView();

        WareQueryView wareQueryView = new WareQueryView();

        WHCellView cellView = new WHCellView();
        WHStationView stationLogicView = new WHStationView();

        StockTakingUnshelveView stocktakingUnshelveView = new StockTakingUnshelveView();
        SysLogView sysLogView = new SysLogView();
        WareAreaManaView wareAreaManaView = new WareAreaManaView();
        RecordQueryView recordQueryView = new RecordQueryView();
        PalletWithoutPlanView palletWithoutPlanView = new PalletWithoutPlanView();
        UnShelveWithoutPlanView unshelveWithoutPlanView = new UnShelveWithoutPlanView();
        WHManaView houseManaView = new WHManaView();
        public WmsViewManager()
        { }
        public void InitView(IWMSFrame wmsFrame, List<WMSFuncModule> moduleList)
        {

            modPV.FormClosing += FormCloseEventHandler;
            modPV.Init(wmsFrame);//密码修改

            roleView.FormClosing += FormCloseEventHandler;
            roleView.Init(wmsFrame);//角色管理

            userView.FormClosing += FormCloseEventHandler;
            userView.Init(wmsFrame);//用户管理

            limitView.FormClosing += FormCloseEventHandler;
            limitView.Init(wmsFrame);//权限管理

            wareLimitView.FormClosing += FormCloseEventHandler;
            wareLimitView.Init(wmsFrame);

            materialView.FormClosing += FormCloseEventHandler;
            materialView.Init(wmsFrame);//物料管理

            if(moduleList.Contains(WMSFuncModule.计划录入) == true)
            {
                planManaView.FormClosing += FormCloseEventHandler;
                planManaView.Init(wmsFrame);//计划录入
            }
          
            taskView.FormClosing += FormCloseEventHandler;
            taskView.Init(wmsFrame);//任务管理

            if(moduleList.Contains(WMSFuncModule.待办工作)== true)
            {
                prepareView.FormClosing += FormCloseEventHandler;
                prepareView.Init(wmsFrame);//代办工作
            }

            if (moduleList.Contains(WMSFuncModule.按计划配盘) == true)
            {
                inWareWithPlanView.FormClosing += FormCloseEventHandler;
                inWareWithPlanView.Init(wmsFrame);//按计划配盘
            }

            materialUnloadView.FormClosing += FormCloseEventHandler;
            materialUnloadView.Init(wmsFrame);//上架


            if (moduleList.Contains(WMSFuncModule.按计划下架) == true)
            {
                materialLoadWithPlanView.FormClosing += FormCloseEventHandler;
                materialLoadWithPlanView.Init(wmsFrame);//按计划下架
            }

            stocktakingUnshelveView.FormClosing += FormCloseEventHandler;
            stocktakingUnshelveView.Init(wmsFrame);
            
        
            pallerManaView.FormClosing += FormCloseEventHandler;
            pallerManaView.Init(wmsFrame);//配盘管理

            stockQueryView.FormClosing += FormCloseEventHandler;
            stockQueryView.Init(wmsFrame);//库存查询

            stationView.FormClosing += FormCloseEventHandler;
            stationView.Init(wmsFrame);//库存看板
            if (moduleList.Contains(WMSFuncModule.计划查询) == true)
            {
                planQueryView.FormClosing += FormCloseEventHandler;
                planQueryView.Init(wmsFrame);//计划查询
            }
            wareQueryView.FormClosing += FormCloseEventHandler;
            wareQueryView.Init(wmsFrame);
            
           
         
            wareAreaManaView.FormClosing += FormCloseEventHandler;
            wareAreaManaView.Init(wmsFrame);

            cellView.FormClosing += FormCloseEventHandler;
            cellView.Init(wmsFrame);

            stationLogicView.FormClosing += FormCloseEventHandler;
            stationLogicView.Init(wmsFrame);

            sysLogView.FormClosing += FormCloseEventHandler;
            sysLogView.Init(wmsFrame);
            if (moduleList.Contains(WMSFuncModule.搬运记录) == true)
            {
                recordQueryView.FormClosing += FormCloseEventHandler;
                recordQueryView.Init(wmsFrame);
            }
            if (moduleList.Contains(WMSFuncModule.无计划配盘) == true)
            {
                palletWithoutPlanView.FormClosing += FormCloseEventHandler;
                palletWithoutPlanView.Init(wmsFrame);//无计划配盘
            }
            if (moduleList.Contains(WMSFuncModule.无计划下架) == true)
            {
                unshelveWithoutPlanView.FormClosing += FormCloseEventHandler;
                unshelveWithoutPlanView.Init(wmsFrame);//无计划下架
            }
houseManaView.FormClosing += FormCloseEventHandler;
            houseManaView.Init(wmsFrame);
        }

        public void ResgistShowMaterialProperty(Action<string> showMaterialProperty)
        {
            this.materialView.presenter.ResgistShowMaterialProperty(showMaterialProperty);
        }
        public void RegistAllowPutaway(Func<bool> AllowPutaway)
        {
            this.materialUnloadView.presenter.RegistAllowPutaway(AllowPutaway);
        }
        //public void ResgistShowUserProperty(Action<string> showUserProperty)
        //{
        //    this.userView.presenter.ResgistShowUserProperty(showUserProperty);
        //}

        //public void ResgistShowRoleProperty(Action<string> showRoleProperty)
        //{
        //    this.roleView.presenter.ResgistShowRoleProperty(showRoleProperty);
        //}

        //public void ResgistShowAreaProperty(Action<string> showAreaProperty)
        //{
        //    this.wareAreaManaView.presenter.ResgistShowAreaProperty(showAreaProperty);
        //}

        private void FormCloseEventHandler(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Form f = (Form)sender;
                f.Visible = false;
            }

        }
    }
}
