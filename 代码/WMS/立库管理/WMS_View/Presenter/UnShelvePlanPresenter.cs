using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class UnShelvePlanPresenter:BasePresenter<IUnShelvePlanView>
    {
       
        View_StockListBLL bllViewStockList = new View_StockListBLL();
        View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
        Stock_ListBll bllStockList = new Stock_ListBll();
        Manage_ListBll bllManageList = new Manage_ListBll();
        WH_CellBll bllCell = new WH_CellBll();
        WH_Cell_ChildrenBll bllCellChild = new WH_Cell_ChildrenBll();
        View_CellBLL bllViewCell = new View_CellBLL();
        View_Plan_StockListBLL bllViewPlanStockList = new View_Plan_StockListBLL();
        ManageBll bllManage = new ManageBll();

        PlanBll bllPlan = new PlanBll();
        Plan_ListBll bllPlanList = new Plan_ListBll();

        View_ManageBLL bllViewManage = new View_ManageBLL();
        View_ManageListBLL bllViewManageList = new View_ManageListBLL();
        View_PlanMainBLL bllViewPlanMain = new View_PlanMainBLL();
        WH_Station_LogicBLL bllStationLogic = new WH_Station_LogicBLL();
        
        public UnShelvePlanPresenter(IUnShelvePlanView view,IWMSFrame wmsFrame):base(view,wmsFrame)
        { }
        public override void Init()
        {
            IniPlanList();
            GetUnShelveStation();
        }
       
        public void IniPlanList()
        {
            List<View_PlanMainModel> planList = bllViewPlanMain.GetPlanListByStatus("2", EnumPlanStatus.执行中.ToString());//下架
            this.View.IniPlanList(planList);
        }
        public void QueryPlan(string planCode)
        {
            //List<View_Plan_StockListModel> stockList = bllViewStockList.GetModelByPlanID(planID);
            List<View_PlanListModel> planList = bllViewPlanList.GetModelByPlanCode(planCode);

            ViewDataManager.UNSHELVEPALNDATA.PlanListData.Clear();
            if (planList == null || planList.Count == 0)
            {
                this.View.ShowMessage("信息提示", "无此计划信息！");
                return;
            }
            foreach (View_PlanListModel stockModel in planList)
            {
                PlanListModel planModel = new PlanListModel();
                planModel.规格型号 = stockModel.Goods_Model;
                planModel.计划数量 = stockModel.Plan_List_Quantity;
                planModel.计量单位 = stockModel.Goods_Unit;
                planModel.完成数量 = stockModel.Plan_List_Finished_Quantity.ToString();
                planModel.物料编码 = stockModel.Goods_Code;
                planModel.物料名称 = stockModel.Goods_Name;
                planModel.下达数量 = stockModel.Plan_List_Ordered_Quantity.ToString();
                planModel.计划列表编码 = stockModel.Plan_List_ID;
                planModel.计划单号 = stockModel.Plan_ID;
                if (stockModel.Plan_Create_Time!= null)
                {
                    planModel.计划创建时间 = stockModel.Plan_Create_Time.ToString();
                }
               
                ViewDataManager.UNSHELVEPALNDATA.PlanListData.Add(planModel);
            }

            
        }
        private void GetUnShelveStation()
        {
            //if (palletCode.Trim() == "")
            //{
            //    this.View.ShowMessage("信息提示", "请选择指定货位下架！");
            //    return;
            //}
            //View_StockListModel stockListModel = bllViewStockList.GetModelByPalletCode(palletCode,EnumCellType.货位.ToString());
            //if(stockListModel == null)
            //{
            //    this.View.ShowMessage("信息提示", "此货位无库存！");
            //    return;
            //}
            List<WH_Station_LogicModel> staionList = bllStationLogic .GetStationListByType(EnumCellType.下架工位.ToString());
            List<string> stationList = new List<string>();


            foreach (WH_Station_LogicModel station in staionList)
            {
                stationList.Add(station.WH_Station_Logic_Name);
            }
            this.View.IniTargetList(stationList);

        }

        public void QueryStockInfor(string goodsCode)
        {
            if (goodsCode.Trim() == "")
            {
                this.View.ShowMessage("信息提示", "请输入物料编码！");
                return;
            }
            List<View_StockListModel> stockList = bllViewStockList.GetModelListByGoodsCode(goodsCode,EnumCellType.货位.ToString());
            ViewDataManager.UNSHELVEPALNDATA.PalletInforData.Clear();
            if (stockList == null || stockList.Count == 0)
            {
                this.View.ShowMessage("信息提示", "库房无此物料信息！");
                return;
            }
            foreach (View_StockListModel stock in stockList)
            {
                PalletInfor palletInfor = new PalletInfor();
                palletInfor.库房 = stock.WareHouse_Name;
                palletInfor.存储货位 = stock.Cell_Name+"-"+stock.Cell_Chlid_Position;
                palletInfor.存储库区 = stock.Area_Name;
                palletInfor.更新时间 = stock.Stock_List_Update_Time.ToString();
                palletInfor.规格型号 = stock.Goods_Model;
                palletInfor.计量单位 = stock.Goods_Unit;
                palletInfor.入库时间 = stock.Stock_List_Entry_Time.ToString();
                //palletInfor.生产日期 = stock.Goods_ProduceDate;
                palletInfor.是否满盘 = stock.Stock_Full_Flag;
               
                palletInfor.数量 = int.Parse(stock.Stock_List_Quantity);
                palletInfor.托盘条码 = stock.Stock_Tray_Barcode;
                palletInfor.物料编码 = stock.Goods_Code;
                palletInfor.物料名称 = stock.Goods_Name;
                ViewDataManager.UNSHELVEPALNDATA.PalletInforData.Add(palletInfor);
            }

        }

        public void UnShelveTask(string planCode,string palletCode, string unshelveStationName)
        {
            //查看当前是否已经有此托盘条码的上架管理任务
            View_Manage_ListModel manage = bllViewManageList.GetModelByPalletCodeAndTaskType(palletCode, EnumManageTaskType.下架.ToString(), EnumManageTaskStatus.待执行.ToString());
            if(manage!=null)
            {
                //this.WmsFrame.WriteLog("下架逻辑", "", "提示", "当前托盘下架任务已经下发！");
                this.View.ShowMessage("信息提示", "当前托盘下架任务已经下发！");
                return;
            }
            string restr = "";

            string manageID = "";

            if (CommonMoudle.TaskHandleMethod.CreateUnshelveManageTask(planCode, palletCode, unshelveStationName, ref manageID,ref restr) == false)
            {
                this.WmsFrame.WriteLog("下架逻辑", "", "提示", restr);
                return;
            }
           
            //下架管理任务生成完毕后需要更新货位状态,计划状态根据管理任务状态更新
            if(UpateCellStatus(palletCode, EnumGSOperate.出库, EnumGSTaskStatus.锁定) == false)
            {
                return;
            }
            this.WmsFrame.WriteLog("下架逻辑", "", "提示","托盘："+palletCode+ "下达下架任务成功！");
        }

    
        private bool UpateCellStatus(string palletCode, EnumGSOperate cellOperStatus, EnumGSTaskStatus taskStatus)
        {
            View_StockListModel stockModel = bllViewStockList.GetModelByPalletCode(palletCode,EnumCellType.货位.ToString());
            if (stockModel == null)
            {
                this.WmsFrame.WriteLog("下架逻辑", "", "提示", "更新货位状态时，没有找到所选物料库存！");
                return false;
            }
            WH_Cell_ChildrenModel cellChildModel = bllCellChild.GetModel(stockModel.Cell_Child_ID);
            if (cellChildModel == null)
            {
                this.WmsFrame.WriteLog("下架逻辑", "", "提示", "更新货位状态时，没有找到所选物料货位！");
                return false;
            }
            cellChildModel.Cell_Child_Run_Status = taskStatus.ToString();
            cellChildModel.Cell_Child_Operate_Type = cellOperStatus.ToString();
            bllCellChild.Update(cellChildModel);
            this.WmsFrame.WriteLog("下架逻辑", "", "提示", "更新货位状态成功！");
            return true;
        }
        
            
    }
}
