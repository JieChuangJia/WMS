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

        InWareWithoutPlanView inWareWithoutPlanView = new InWareWithoutPlanView();

        PutawayView materialUnloadView = new PutawayView();

        OutWareWithoutPlanView outWareWithoutPlanView = new OutWareWithoutPlanView();

        InWareWithPlanView inWareWithPlanView = new InWareWithPlanView();

        UnShelvePlanView materialLoadWithPlanView = new UnShelvePlanView();

        OutWareWithPlanView outWarePlanView = new OutWareWithPlanView();

        PalletManaView pallerManaView = new PalletManaView();

        StationShowView stationView = new StationShowView();

        PlanQueryView planQueryView = new PlanQueryView();

        WareQueryView wareQueryView = new WareQueryView();

        StockTakingUnshelveView stocktakingUnshelveView = new StockTakingUnshelveView();

        public WmsViewManager()
        { }
        public void InitView(IWMSFrame wmsFrame)
        {

            modPV.FormClosing += FormCloseEventHandler;
            modPV.Init(wmsFrame);

            roleView.FormClosing += FormCloseEventHandler;
            roleView.Init(wmsFrame);

            userView.FormClosing += FormCloseEventHandler;
            userView.Init(wmsFrame);

            limitView.FormClosing += FormCloseEventHandler;
            limitView.Init(wmsFrame);

            wareLimitView.FormClosing += FormCloseEventHandler;
            wareLimitView.Init(wmsFrame);

            materialView.FormClosing += FormCloseEventHandler;
            materialView.Init(wmsFrame);

            taskView.FormClosing += FormCloseEventHandler;
            taskView.Init(wmsFrame);

            planManaView.FormClosing += FormCloseEventHandler;
            planManaView.Init(wmsFrame);

            prepareView.FormClosing += FormCloseEventHandler;
            prepareView.Init(wmsFrame);


            inWareWithPlanView.FormClosing += FormCloseEventHandler;
            inWareWithPlanView.Init(wmsFrame);

            materialUnloadView.FormClosing += FormCloseEventHandler;
            materialUnloadView.Init(wmsFrame);

        

            materialLoadWithPlanView.FormClosing += FormCloseEventHandler;
            materialLoadWithPlanView.Init(wmsFrame);

            stocktakingUnshelveView.FormClosing += FormCloseEventHandler;
            stocktakingUnshelveView.Init(wmsFrame);

            //outWarePlanView.FormClosing += FormCloseEventHandler;
            //outWarePlanView.Init(wmsFrame);

            pallerManaView.FormClosing += FormCloseEventHandler;
            pallerManaView.Init(wmsFrame);

            stationView.FormClosing += FormCloseEventHandler;
            stationView.Init(wmsFrame);

            planQueryView.FormClosing += FormCloseEventHandler;
            planQueryView.Init(wmsFrame);

            wareQueryView.FormClosing += FormCloseEventHandler;
            wareQueryView.Init(wmsFrame);

            outWareWithoutPlanView.FormClosing += FormCloseEventHandler;
            outWareWithoutPlanView.Init(wmsFrame);

            inWareWithoutPlanView.FormClosing += FormCloseEventHandler;
            inWareWithoutPlanView.Init(wmsFrame);

       
        }

        public void ResgistShowMaterialProperty(Action<string> showMaterialProperty)
        {
            this.materialView.presenter.ResgistShowMaterialProperty(showMaterialProperty);
        }
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
