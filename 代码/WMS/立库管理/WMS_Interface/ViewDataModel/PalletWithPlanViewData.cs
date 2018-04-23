using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PalletWithPlanViewData
    {
        private BindingList<PlanListModel> planListData = new BindingList<PlanListModel>();
        public BindingList<PlanListModel> PlanListData
        {
            get { return this.planListData; }
            set { this.planListData = value; }
        }
        private BindingList<TrayGoodsListModel> trayGoodsListData = new BindingList<TrayGoodsListModel>();
        public BindingList<TrayGoodsListModel> TrayGoodsListData
        {
            get { return this.trayGoodsListData; }
            set { this.trayGoodsListData = value; }
        }
        public PalletWithPlanViewData()
        { }

    }

public class PlanListModel
{
    public string 计划列表编码 { get; set; }
    public string 物料编码 { get; set; }
    public string 物料名称 { get; set; }
    public string 规格型号 { get; set; }
    public string 计划数量 { get; set; }
    public string 计量单位 { get; set; }
    //public string 下达数量 { get; set; }
    public string 完成数量 { get; set; }
   
    public PlanListModel()
    { }
}

    /// <summary>
    /// 配盘列表数据模型
    /// </summary>
    public class TrayGoodsListModel
    {
        public int 数量 { get; set; }
        public DateTime 生产日期 { get; set; }
        public string 托盘条码 { get; set; }
        public string 物料编码 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        public string 保质期 { get; set; }
    }
}
