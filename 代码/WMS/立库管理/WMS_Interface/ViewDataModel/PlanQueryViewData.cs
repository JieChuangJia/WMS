using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PlanQueryViewData
    {
        private BindingList<PlanData> planData = new BindingList<PlanData>();
        public BindingList<PlanData> PlanData { get { return this.planData; } set { this.planData = value; } }

        private BindingList<PlanDataDetail> planDetailData = new BindingList<PlanDataDetail>();
        public BindingList<PlanDataDetail> PlanDetailData { get { return this.planDetailData; } set { this.planDetailData = value; } }
        public PlanQueryViewData()
        { }
    }
   
}
