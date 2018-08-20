using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public  class GoodsViewData
    {
        private BindingList<GoodsDataModel> goodsListData = new BindingList<GoodsDataModel>();
        public BindingList<GoodsDataModel> GoodsListData { get { return this.goodsListData; } set { this.goodsListData = value; } }


        private BindingList<GoodsPropertyModel> goodsPropertyList = new BindingList<GoodsPropertyModel>();
        public BindingList<GoodsPropertyModel> GoodsPropertyList
        {
            get { return this.goodsPropertyList; }
            set { this.goodsPropertyList = value; }
        }
        public GoodsViewData()
        { }

    }

}
