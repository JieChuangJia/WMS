using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PutawayViewData
    {
        private BindingList<PalletInfor> palletInforData = new BindingList<PalletInfor>();
        public BindingList<PalletInfor> PalletInforData
        {
            get { return this.palletInforData; }
            set { this.palletInforData = value; }
        }
        public PutawayViewData()
        { }
    }
    public class PalletInfor
    {
        public string 托盘条码 { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public int 数量 { get; set; }
        public DateTime ?生产日期 { get; set; }
        public string 存储货位 { get; set; }
        public string 计量单位 { get; set; }
        public string 是否满盘 { get; set; }
        public string 存储库区 { get; set; }
        public DateTime ?入库时间 { get; set; }
        public DateTime ?更新时间 { get; set; }


    }
}
