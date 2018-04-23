using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class UnShelvePlanViewData
    {
        private BindingList<PlanListModel> planListData = new BindingList<PlanListModel>();
        public BindingList<PlanListModel> PlanListData
        {
            get { return this.planListData; }
            set { this.planListData = value; }
        }

        private BindingList<PalletInfor> palletInforData = new BindingList<PalletInfor>();
        public BindingList<PalletInfor> PalletInforData
        {
            get { return this.palletInforData; }
            set { this.palletInforData = value; }
        }
       public UnShelvePlanViewData()
        { }
    }
}
