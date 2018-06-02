using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;

namespace WMS_Interface
{
    public class StorageViewData
    {
        private BindingList<CellGoodsDetailModel> cellGoodsDetailData = new BindingList<CellGoodsDetailModel>();
        public BindingList<CellGoodsDetailModel> CellGoodsDetailData { get { return this.cellGoodsDetailData; } set { this.cellGoodsDetailData = value; } }

       
        public StorageViewData()
        { }
    }

    public class CellGoodsDetailModel
    {
        public string 托盘条码 { get; set; }
        public string 物料条码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        //public string 生产日期 { get;set; }
            
        public string 数量 { get; set; }
        public string 存储货位 { get; set; }
        public string 计量单位 { get; set; }
        public string 是否满盘 { get; set; }
        public string 存储库区 { get; set; }
        public string 入库时间 { get; set; }
        public string 更新时间 { get; set; }
        public CellGoodsDetailModel()
        { }

       
    }

    
}
