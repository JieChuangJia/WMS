using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PlanInputDataViewModel
    {
        private BindingList<GoodsDataModel> goodsListData = new BindingList<GoodsDataModel>();
        public BindingList<GoodsDataModel> GoodsListData { get { return this.goodsListData; } set { this.goodsListData = value; } }

        private BindingList<PlanListModel> planData = new BindingList<PlanListModel>();
        public BindingList<PlanListModel> PlanListData
        {
            get { return this.planData; }
            set { this.planData = value; }
        }

        public PlanInputDataViewModel()
        { }
    }
}
