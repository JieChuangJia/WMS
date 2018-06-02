using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class TrayGoodsManageViewData
    {
        private BindingList<TrayGoodsViewModel> trayGoodsData = new BindingList<TrayGoodsViewModel>();
        public BindingList<TrayGoodsViewModel> TrayGoodsData
        {
            get { return this.trayGoodsData; }
            set { this.trayGoodsData = value; }
        }
        public TrayGoodsManageViewData()
        { }
    }
    public class TrayGoodsViewModel
    {
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public string 数量 { get; set; }
        public string 存储库房 { get; set; }
        public string 存储库区 { get; set; }
        public string 存储货位 { get; set; }
        public string 托盘条码 { get; set; }
        public string 是否满盘 { get; set; }
        //public string 生产日期 { get; set; }
        public string 入库时间 { get; set; }
        
        public string 更新时间 { get; set; }

    }

    
}
