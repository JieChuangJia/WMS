using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;
namespace WMS_Kernel
{
    public class PlanInputPresenter:BasePresenter<IPlanInputView>
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
        WH_CellBll bllCell = new WH_CellBll();
        View_CellBLL bllViewCell = new View_CellBLL();
        View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
        WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        public PlanInputPresenter(IPlanInputView view,IWMSFrame wmsFrame):base(view,wmsFrame)
        { }

        public override void Init()
        {
            IniPlanType();
        }
        public void ShowGoodsList(string goodsInfor)
        {
            List<View_GoodsModel> goodsList = bllView_Goods.GetModelByGoosInfo(goodsInfor);
            ViewDataManager.PLANINPUTDATA.GoodsListData.Clear();
            if (goodsList == null)
            {
                return;
            }

            //ViewDataManager.GOODSVIEWDATA.GoodsListData.Clear();
            foreach (View_GoodsModel goods in goodsList)
            {
                GoodsDataModel gsdModel = new GoodsDataModel();
                gsdModel.单位 = goods.Goods_Unit;
                gsdModel.启用 = goods.Goods_Flag;
                gsdModel.物料编码 = goods.Goods_Code;
                gsdModel.物料类别 = goods.Goods_Category;
                gsdModel.物料名称 = goods.Goods_Name;
                gsdModel.物料内部编码 = goods.Goods_ID.ToString();

                ViewDataManager.PLANINPUTDATA.GoodsListData.Add(gsdModel);
            }

        }
        public void AddPlanGoods(string goodsCode, decimal planGoodsNum)
        {
            if (goodsCode.Trim() == "")
            {
                this.View.ShowMessage("信息提示", "物料编号错误！");
                return;
            }
            if (planGoodsNum ==0)
            {
                this.View.ShowMessage("信息提示", "请输入物料计划数量！");
                return;
            }
            if (IsExistPalletGoods(goodsCode) == true)
            {
                this.View.ShowMessage("信息提示", "此物料已经在配盘中！");
                return;
            }
        
            View_GoodsModel goodsModel = bllViewGoods.GetModelByGoodsCode(goodsCode);
            if (goodsModel == null)
            {
                this.View.ShowMessage("信息提示", "不存在此物料！");
                return;
            }
            PlanListModel plm = new PlanListModel();
            plm.规格型号 = goodsModel.Goods_Model;
            plm.计划数量 = planGoodsNum.ToString();
            plm.计量单位 = goodsModel.Goods_Unit;
            plm.完成数量 = "0";
            plm.物料编码 = goodsCode;
            plm.物料名称 = goodsModel.Goods_Name;
            //plm.下达数量 = "0";
            plm.计划列表编码 = Guid.NewGuid().ToString();
            ViewDataManager.PLANINPUTDATA.PlanListData.Add(plm);
        }

        public void DeletePlanGoods(string goodsCode)
        {
            for (int i = 0; i < ViewDataManager.PLANINPUTDATA.PlanListData.Count; i++)
            {
                PlanListModel tglm = ViewDataManager.PLANINPUTDATA.PlanListData[i];
                if (tglm.物料编码 == goodsCode)
                {
                    ViewDataManager.PLANINPUTDATA.PlanListData.Remove(tglm);
                    break;
                }

            }
        }

        public void AddPlan(string planCode,string planTypeName,string planPerson,DateTime planDate,string remark)
        {
            try
            {
                Plan_TypeModel planType = bllPlanType.GetModelByName(planTypeName);
                if (planType == null)
                {
                    this.View.ShowMessage("信息提示", "计划类型错误！");
                    return;
                }
                if(ViewDataManager.PLANINPUTDATA.PlanListData.Count()==0)
                {
                    this.View.ShowMessage("信息提示", "请为计划添加物料信息！");
                    return;
                }
                PlanMainModel checkPlan = bllPlan.GetModelByPlanCode(planCode);
                if(checkPlan!= null)
                {
                    this.View.ShowMessage("信息提示", "计划编号已存在：["+planCode+"]");
                    return;
                }
                PlanMainModel plan = new PlanMainModel();
                plan.Plan_Code = planCode;
                plan.Plan_ID = Guid.NewGuid().ToString();
                plan.Plan_Type_ID = planType.Plan_Type_ID;
                plan.Plan_Create_Time = planDate;
                plan.Plan_Status = EnumPlanStatus.待执行.ToString();
                plan.Plan_Operater = planPerson;
                plan.Plan_Remark = remark;

                bllPlan.Add(plan);
                foreach (PlanListModel goods in ViewDataManager.PLANINPUTDATA.PlanListData)
                {
                    Plan_ListModel planList = new Plan_ListModel();
                    GoodsModel goodsModel = bllGoods.GetModelByCode(goods.物料编码);
                    if(goods == null)
                    {
                        this.WmsFrame.WriteLog("PlanInputPresenter", "", "错误", "物料编码错误！");
                        return;
                    }
                    planList.Goods_ID = goodsModel.Goods_ID;
                    planList.Plan_ID = plan.Plan_ID;
                    planList.Plan_List_Finished_Quantity = "0";
                    planList.Plan_List_ID = goods.计划列表编码;
                    planList.Plan_List_Ordered_Quantity = "0";
                    planList.Plan_List_Quantity = goods.计划数量;
                    bllPlanList.Add(planList);
                }
                this.View.ShowMessage("信息提示", "计划添加成功！");
            }
            catch(Exception ex)
            {
                this.View.ShowMessage("信息提示", "计划添加失败！"+ ex.Message);
            }
        }
        private bool IsExistPalletGoods(string goodsCode)
        {
            foreach (PlanListModel goods in ViewDataManager.PLANINPUTDATA.PlanListData)
            {
                if (goods.物料编码 == goodsCode)
                {
                    return true;
                }
            }
            return false;
        }
        private void IniPlanType()
        {
            List<Plan_TypeModel> planTypeList = bllPlanType.GetModelList("");
            List<string> typeList = new List<string>();
            foreach(Plan_TypeModel planType in planTypeList)
            {
                typeList.Add(planType.Plan_Type_Name);
            }
            this.View.IniPlanType(typeList);
        }
    }
}
