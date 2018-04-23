using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PalletManageViewData
    {
        private BindingList<TrayGoodsListModel> palletInforData = new BindingList<TrayGoodsListModel>();
        public BindingList<TrayGoodsListModel> PalletInforData
        {
            get { return this.palletInforData; }
            set { this.palletInforData = value; }
        }

        private BindingList<PalletListData> palletList = new BindingList<PalletListData>();
        public BindingList<PalletListData> PalletList
        {
            get { return this.palletList; }
            set { this.palletList = value; }
        }
        private BindingList<GoodsDataModel> palletGoodsData = new BindingList<GoodsDataModel>();
        public BindingList<GoodsDataModel> PalletGoodsData
        {
            get { return this.palletGoodsData; }
            set { this.palletGoodsData = value; }
        }
        public PalletManageViewData()
        { }
    }
    public class PalletListData
    {
        public string 托盘条码 { get; set; }
        public string 配盘工位名称 { get; set; }
        public DateTime 配盘时间 { get; set; }
        public string 按计划配盘 { get; set; }
        public string 计划代码 { get; set; }

            
        public PalletListData()
        { }
    }
}
