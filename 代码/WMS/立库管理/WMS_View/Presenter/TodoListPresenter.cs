using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;


namespace WMS_Kernel
{
    public class TodoListPresenter:BasePresenter<ITodoListView>
    {
        View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
        PlanBll bllPlan = new PlanBll();
        Plan_TypeBll bllPlanType = new Plan_TypeBll();
        View_PlanMainBLL bllPlanMain = new View_PlanMainBLL();
        DateTime querySDate = DateTime.Now;
        DateTime queryEDate = DateTime.Now;
        string queryPlanType = "";
        string queryPlanCode = "";
        public TodoListPresenter(ITodoListView view,IWMSFrame wmsFrame):base(view,wmsFrame)
        { }
        public override void Init()
        {
            InitPlanTypeList();
        }
        public void QueryPlan(DateTime startDate, DateTime endDate, string planType, string planCode)
        {
            this.querySDate = startDate;
            this.queryEDate = endDate;
            this.queryPlanType = planType;
            this.queryPlanCode = planCode;
            ViewDataManager.TODOLISTDATA.PlanDetailData.Clear();
            List<View_PlanMainModel> planList = bllPlanMain.GetTodoListPlan(startDate, endDate, planType, planCode);
            ViewDataManager.TODOLISTDATA.PlanData.Clear();
            if (planList == null || planList.Count == 0)
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
                if (plan.Plan_End_Time!= null)
                {
                    planData.完成时间 =plan.Plan_End_Time.ToString();
                }
            
                planData.制单人 = plan.Plan_Operater;
                if (plan.Plan_Create_Time!= null)
                {
                    planData.制单日期 = 
                        plan.Plan_Create_Time.ToString();
                }
                
                planData.状态 = plan.Plan_Status;
                planData.备注 = plan.Plan_Remark;
                ViewDataManager.TODOLISTDATA.PlanData.Add(planData);
            }
        }
        public void QueryPlanList(string planCode)
        {
            List<View_PlanListModel> planList = bllViewPlanList.GetModelByPlanCode(planCode);
            ViewDataManager.TODOLISTDATA.PlanDetailData.Clear();
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
                //planDetailData.生产日期 = (DateTime)plan.Goods_ProduceDate;
                planDetailData.完成数量 = plan.Plan_List_Finished_Quantity.ToString();
                planDetailData.物料编码 = plan.Goods_Code;
                planDetailData.物料名称 = plan.Goods_Name;
                //planDetailData.下达数量 = plan.Plan_List_Ordered_Quantity.ToString();
                ViewDataManager.TODOLISTDATA.PlanDetailData.Add(planDetailData);

            }
        }
        public void CompletePlanManual(string planCode)
        {
            if (this.View.AskMessage("询问", "您确定要手动完成此计划么？") != 0)
            {
                return;
            }
            PlanMainModel plan = bllPlan.GetModelByPlanCode(planCode);
            if(plan == null)
            {
                this.View.ShowMessage("信息提示", "");
                return;
            }
            plan.Plan_Status = EnumPlanStatus.完成.ToString();
            bllPlan.Update(plan);
            this.WmsFrame.WriteLog("代办工作逻辑", "", "提示", "计划手动完成成功！");
            QueryPlan(this.querySDate, this.queryEDate, this.queryPlanType, this.queryPlanCode);
        }
        public void DeletePlanList(string planCode)
        {

            if (this.View.AskMessage("询问", "您确定要删除此计划么？") != 0)
            {
                return;
            }
            PlanMainModel planModel = bllPlan.GetModelByPlanCode(planCode);
            if (planModel == null)
            {
                return;
            }
            if (planModel.Plan_Status != EnumPlanStatus.待执行.ToString())
            {
                this.View.ShowMessage("提示", "只有待执行的计划可以删除！");
                return;
            }
            bllPlan.Delete(planModel.Plan_ID);
            QueryPlan(this.querySDate, this.queryEDate, this.queryPlanType, this.queryPlanCode);
        }
        private void InitPlanTypeList()
        {
            List<Plan_TypeModel> planTypeList = bllPlanType.GetModelList("");
            List<string> planList = new List<string>();
            foreach (Plan_TypeModel type in planTypeList)
            {
                planList.Add(type.Plan_Type_Name);

            }
            this.View.IniPlanTypeList(planList);
        }

        public void ExePlan(string planCode)
        {
            PlanMainModel planModel = bllPlan.GetModelByPlanCode(planCode);
            if(planModel!=null&&planModel.Plan_Status==EnumPlanStatus.待执行.ToString())
            {
                planModel.Plan_Status = EnumPlanStatus.执行中.ToString();
                planModel.Plan_Begin_Time = DateTime.Now;
                Plan_TypeModel plantype =bllPlanType.GetModel( planModel.Plan_Type_ID);
                if(plantype == null)
                {this.View.ShowMessage("信息提示","计划类型错误！");
                    return;
                }
                bllPlan.Update(planModel);
                this.WmsFrame.WriteLog("待办工作", "", "提示", "计划["+planModel.Plan_Code+"]，计划名称："+plantype.Plan_Type_Name+",开始执行！");
            }
            else
            {
                this.WmsFrame.WriteLog("待办工作", "", "提示", "只有状态为【待执行】的任务可以执行！");
            }
            QueryPlan(this.querySDate, this.queryEDate, this.queryPlanType, this.queryPlanCode);
        }
        
    }
}
