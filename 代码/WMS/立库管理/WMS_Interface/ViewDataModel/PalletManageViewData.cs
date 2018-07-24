using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PalletManageViewData
    {
        private BindingList<PalletGoodsListModel> palletInforData = new BindingList<PalletGoodsListModel>();
        public BindingList<PalletGoodsListModel> PalletInforData
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
    /// <summary>
    /// 配盘列表数据模型
    /// </summary>
    public class PalletGoodsListModel
    {
     
        public int 数量 { get; set; }
        //public DateTime 生产日期 { get; set; }
        public string 托盘条码 { get; set; }
        public string 物料编码 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        //public string 保质期 { get; set; }
    }

    public class PalletListData
    {
        public string 托盘条码 { get; set; }
        public string 配盘工位名称 { get; set; }
        public string 配盘时间 { get; set; }
        public string 按计划配盘 { get; set; }
        public string 计划单号 { get; set; }

            
        public PalletListData()
        { }
    }
}
