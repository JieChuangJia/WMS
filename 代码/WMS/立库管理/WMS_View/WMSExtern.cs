using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
   public class WMSExtern:IWMSExtern
   {
       View_GoodsBLL bllView_Goods = new View_GoodsBLL();
       Goods_PropertyBll bllProperty = new Goods_PropertyBll();
       PlanBll bllPlan = new PlanBll();
       Plan_ListBll bllPlanList = new Plan_ListBll();
       Plan_TypeBll bllPlanType = new Plan_TypeBll();

       View_GoodsBLL bllViewGoods = new View_GoodsBLL();
       GoodsBll bllGoods = new GoodsBll();
       StockBll bllStock = new StockBll();
       Stock_ListBll bllStockList = new Stock_ListBll();
       View_Plan_StockListBLL bllViewPlanStockList = new View_Plan_StockListBLL();
       WH_CellBll bllCell = new WH_CellBll();
       View_CellBLL bllViewCell = new View_CellBLL();
       View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
     
       WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
       private static WMSExtern wmsExtern = null;

       //public event EventHandler<PutwayEventArgs> PutwayEventHandler;
       private WMSExtern()
       { }
       public static WMSExtern GetWMSExtern()
       {
           if(wmsExtern == null)
           {
               wmsExtern = new WMSExtern();
           }
           return wmsExtern;
       }
       //private void PutwayEventHandler(object sender,PutwayEventArgs e)
       //{
       //  View_Plan_StockListModel planStock =  bllViewPlanStockList.GetModelByPalletCode(e.PalletCode);

       //}
       public bool AddExternPlan(string planCode, string planTypeName, string planPerson, DateTime planDate, string warehouseCode,List<PlanListModel> planDetailList, ref string restr)
       {
           try
           {
               Plan_TypeModel planType = bllPlanType.GetModelByName(planTypeName);
               if (planType == null)
               {
                   restr = "计划类型错误！";
                   return false;
               }
               if (planDetailList == null || planDetailList.Count == 0)
               {
                   restr = "请为计划添加物料信息！";
                   return false;
               }
               PlanMainModel checkPlan = bllPlan.GetModelByPlanCode(planCode);
               if (checkPlan != null)
               {
                   restr = "计划编号已存在：[" + planCode + "]";
                   return false;
               }

               PlanMainModel plan = new PlanMainModel();

               plan.Plan_Code = planCode;
               plan.Plan_ID = Guid.NewGuid().ToString();
               plan.Plan_Type_ID = planType.Plan_Type_ID;
               plan.Plan_Create_Time = planDate;
               plan.Plan_Status = EnumPlanStatus.待执行.ToString();
               plan.Plan_Operater = planPerson;
               plan.Plan_Remark = warehouseCode;
               bllPlan.Add(plan);
               if (planDetailList == null)
               {
                   return false;
               }
               foreach (PlanListModel goods in planDetailList)
               {
                   Plan_ListModel planList = new Plan_ListModel();
                   GoodsModel goodsModel = bllGoods.GetModelByCode(goods.物料编码);
                   if (goodsModel == null)
                   {

                       restr = "物料编码错误！";
                       return false;
                   }
                   planList.Goods_ID = goodsModel.Goods_ID;
                   planList.Plan_ID = plan.Plan_ID;
                   planList.Plan_List_Finished_Quantity = "0";
                   planList.Plan_List_ID = Guid.NewGuid().ToString();
                   planList.Plan_List_Ordered_Quantity = "0";
                   planList.Plan_List_Quantity = goods.计划数量;
                   planList.Plan_List_Remark = goods.物料批次;
                   bllPlanList.Add(planList);
               }

               return true;
           }
           catch (Exception ex)
           {
               restr = "计划添加失败" + ex.StackTrace.ToString();
               return false;
           }
       }
    }
}
