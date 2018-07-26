using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class StockQueryDataViewModel
    {
        private BindingList<StockViewModel> stockList = new BindingList<StockViewModel>();
        public BindingList<StockViewModel> StockList
        {
            get { return this.stockList; }
            set { this.stockList = value; }
        }

        private BindingList<StockDetailViewModel> stockDetailList = new BindingList<StockDetailViewModel>();
        public BindingList<StockDetailViewModel> StockDetailList
        {
            get { return this.stockDetailList; }
            set { this.stockDetailList = value; }
        }
    }

    public class StockViewModel
    {
        public string 货位编码 { get; set; }
        public string 库房名称 { get; set; }
        public string 库区 { get; set; }
        public string 货位名称 { get; set; }
        public string 位置 { get; set; }
        public string 入库时间 { get; set; }

    }
    public class StockDetailViewModel
    {
        public string 托盘条码 { get; set; }
        public string 物料名称 { get; set; }
        public string 物料编码 { get; set; }
        public string 物料类别 { get; set; }
        public string 物料个数 { get; set; }
    }
}
