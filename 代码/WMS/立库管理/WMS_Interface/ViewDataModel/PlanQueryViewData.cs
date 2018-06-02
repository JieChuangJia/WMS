using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PlanQueryViewData
    {
        private BindingList<PlanData> planData = new BindingList<PlanData>();
        public BindingList<PlanData> PlanData { get { return this.planData; } set { this.planData = value; } }

        private BindingList<PlanDataDetail> planDetailData = new BindingList<PlanDataDetail>();
        public BindingList<PlanDataDetail> PlanDetailData { get { return this.planDetailData; } set { this.planDetailData = value; } }
        public PlanQueryViewData()
        { }
    }
    public class PlanData
    {
        public string 计划单号 { get; set; }
        public string 计划类型 { get; set; }
        public string 状态 { get; set; }
        public string 制单日期 { get; set; }
        public string 开始时间 { get; set; }
        public string 完成时间 { get; set; }
        public string 制单人 { get; set; }
        //public string 供应商 { get; set; }
        //public string 领料部门 { get; set; }
        public string 备注 { get; set; }
        public PlanData()
        { }
    }

    public class PlanDataDetail
    {
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        //public string 批次号 { get; set; }
        //public DateTime 生产日期 { get; set; }
        public string 计量单位 { get; set; }
        public string 计划数量 { get; set; }
        //public string 下达数量 { get; set; }
        public string 完成数量 { get; set; }
        public string 备注 { get; set; }
        public PlanDataDetail()
        { }
    }
}
