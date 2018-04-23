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
    public class GoodsPropertyModel
    {
        public string 属性名称 { get; set; }
        public string 属性值 { get; set; }
    }
    public class GoodsDataModel
    {
        public string 物料编码 { get; set; }
        public string 物料类别 { get; set; }

        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        public string 启用 { get; set; }
        public string 保质期 { get; set; }
        public string 启用报警 { get; set; }

        public string 物料内部编码 { get; set; }

        public GoodsDataModel()
        { }

    }
}
