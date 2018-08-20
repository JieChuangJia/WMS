using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PalletWithPlanViewData
    {
        private BindingList<PlanListModel> planListData = new BindingList<PlanListModel>();
        public BindingList<PlanListModel> PlanListData
        {
            get { return this.planListData; }
            set { this.planListData = value; }
        }
        private BindingList<TrayGoodsListModel> trayGoodsListData = new BindingList<TrayGoodsListModel>();
        public BindingList<TrayGoodsListModel> TrayGoodsListData
        {
            get { return this.trayGoodsListData; }
            set { this.trayGoodsListData = value; }
        }
        public PalletWithPlanViewData()
        { }

    }


}
