using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PalletWithoutPlanViewData
    {
        private BindingList<PalletGoodsList> palletInforData = new BindingList<PalletGoodsList>();
        public BindingList<PalletGoodsList> PalletInforData
        {
            get { return this.palletInforData; }
            set { this.palletInforData = value; }
        }


        private BindingList<GoodsDataModel> palletGoodsData = new BindingList<GoodsDataModel>();
        public BindingList<GoodsDataModel> PalletGoodsData
        {
            get { return this.palletGoodsData; }
            set { this.palletGoodsData = value; }
        }

        public PalletWithoutPlanViewData()
        { }
    }

    public class PlanListModel
    {
        public string 计划单号 { get; set; }
        public string 计划列表编码 { get; set; }
        public string 计划创建时间 { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public string 计划数量 { get; set; }
        public string 计量单位 { get; set; }
        public string 下达数量 { get; set; }
        public string 完成数量 { get; set; }

        public PlanListModel()
        { }
    }

    /// <summary>
    /// 配盘列表数据模型
    /// </summary>
    public class TrayGoodsListModel
    {
        public string 计划单号 { get; set; }
        public string 计划列表编号 { get; set; }
        public string 数量 { get; set; }
        //public DateTime 生产日期 { get; set; }
        public string 托盘条码 { get; set; }
        public string 物料编码 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        //public string 保质期 { get; set; }
    }
}
