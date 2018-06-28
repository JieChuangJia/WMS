using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;
using WMS_Database;


namespace WMS_Kernel
{
    public class PlanQueryPresenter:BasePresenter<IPlanQueryView>
    {
        View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
        Plan_TypeBll bllPlanType = new Plan_TypeBll();
        View_PlanMainBLL bllPlanMain = new View_PlanMainBLL();
         
        public PlanQueryPresenter(IPlanQueryView view,IWMSFrame wmsFrame):base(view,wmsFrame)
        { }
        public override void Init()
        {
            InitPlanTypeList();
        }
        public void QueryPlan(DateTime startDate,DateTime endDate,string planType,string planStatus,string planCode)
        {
            ViewDataManager.PLANQUERYDATA.PlanDetailData.Clear();
            List<View_PlanMainModel> planList = bllPlanMain.GetModelList(startDate, endDate, planType, planStatus, planCode);
            ViewDataManager.PLANQUERYDATA.PlanData.Clear();
            if(planList == null||planList.Count==0)
            {
                return;
            }
            foreach (View_PlanMainModel plan in planList)
            {
                PlanData planData = new PlanData();
                //planData.供应商 = plan.Plan_From_Dept;
                planData.计划单号 = plan.Plan_Code;
                planData.计划类型 = plan.Plan_Type_Name;
                if (plan.Plan_Begin_Time!= null)
                {
                    planData.开始时间 =plan.Plan_Begin_Time.ToString();
                }
               
                //planData.领料部门 = plan.Plan_To_Dept;
                if (plan.Plan_End_Time !=null)
                {
                    planData.完成时间 = plan.Plan_End_Time.ToString();
                }
              
                planData.制单人 = plan.Plan_Operater;
                if (plan.Plan_Create_Time != null)
                {
                    planData.制单日期 = plan.Plan_Create_Time.ToString();
                }
               
                planData.状态 = plan.Plan_Status;
                planData.备注 = plan.Plan_Remark;
                ViewDataManager.PLANQUERYDATA.PlanData.Add(planData);
            }
        }
        public void QueryPlanList(string planCode)
        {
            List<View_PlanListModel> planList = bllViewPlanList.GetModelByPlanCode(planCode);
            ViewDataManager.PLANQUERYDATA.PlanDetailData.Clear();
            if (planList == null || planList.Count == 0)
            {
                return;
            }
            foreach (View_PlanListModel plan in planList)
            {
                PlanDataDetail planDetailData = new PlanDataDetail();
                planDetailData.规格型号 = plan.Goods_Model;
                planDetailData.计划数量 = plan.Plan_List_Quantity.ToString();
                planDetailData.计量单位 = plan.Goods_Unit;
                //planDetailData.批次号 = plan.Goods_Batch;
                //if (plan.Goods_ProduceDate!=null)
                //{
                //    planDetailData.生产日期 = (DateTime)plan.Goods_ProduceDate;
                //}
                planDetailData.完成数量 = plan.Plan_List_Finished_Quantity.ToString();
                planDetailData.物料编码 = plan.Goods_Code;
                planDetailData.物料名称 = plan.Goods_Name;
                //planDetailData.下达数量 = plan.Plan_List_Ordered_Quantity.ToString();
                ViewDataManager.PLANQUERYDATA.PlanDetailData.Add(planDetailData);
               
            }
        }
        private void InitPlanTypeList()
        {
            List<Plan_TypeModel> planTypeList = bllPlanType.GetModelList("");
            List<string> planList = new List<string>();
            foreach(Plan_TypeModel type in planTypeList)
            {
                planList.Add(type.Plan_Type_Name);

            }
            this.View.IniPlanTypeList(planList);
        }
    }
}
