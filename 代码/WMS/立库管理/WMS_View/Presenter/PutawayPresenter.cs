using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;
using WMS_Database;

namespace WMS_Kernel
{
    public class PutawayPresenter:BasePresenter<IPutawayView>
    {
        View_StockListBLL bllViewStockList = new View_StockListBLL();
        WH_CellBll bllCell = new WH_CellBll();
        View_CellBLL bllViewCell = new View_CellBLL();
        View_Plan_StockListBLL bllViewPalnStockList = new View_Plan_StockListBLL();

        ManageBll bllManage = new ManageBll();
        Manage_ListBll bllManageList = new Manage_ListBll();
        Stock_ListBll bllStockList = new Stock_ListBll();
        StockBll bllStock = new StockBll();
        WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        WH_Station_LogicBLL bllStationLogic = new WH_Station_LogicBLL();
        Plan_ListBll bllPlanList = new Plan_ListBll();

        public PutawayPresenter(IPutawayView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }
        public void Init()
        {
            IniPutawayList();
            IniHouseList();
        }
        public void QueryPalletInfor(string palletNum)
        {
            if(palletNum == "")
            {
                this.View.ShowMessage("信息提示", "请输入托盘条码！");
                return;
            }
            List<View_StockListModel> stockList = bllViewStockList.GetModelListByPalletCode(palletNum,EnumCellType.配盘工位.ToString());
            ViewDataManager.PUTAWAYVIEWDATA.PalletInforData.Clear();
            if(stockList == null||stockList.Count ==0)
            {
                this.View.ShowMessage("信息提示", "库房无此托盘信息！");
                return;
            }
            foreach( View_StockListModel stock in stockList)
            {
                PalletInfor palletInfor = new PalletInfor();
                palletInfor.存储货位 = stock.Cell_Name;
                palletInfor.存储库区 = stock.Area_Name;
                palletInfor.更新时间 = stock.Stock_List_Update_Time;
                palletInfor.规格型号 = stock.Goods_Model;
                palletInfor.计量单位 = stock.Goods_Unit;
                palletInfor.入库时间 = stock.Stock_List_Entry_Time;
                palletInfor.生产日期 = stock.Goods_ProduceDate;
                palletInfor.是否满盘 = stock.Stock_Full_Flag;
                palletInfor.数量 = int.Parse(stock.Stock_List_Quantity);
                palletInfor.托盘条码 = stock.Stock_Tray_Barcode;
                palletInfor.物料编码 = stock.Goods_Code;
                palletInfor.物料名称 = stock.Goods_Name;
                ViewDataManager.PUTAWAYVIEWDATA.PalletInforData.Add(palletInfor);
            }
            
        }
        private void IniHouseList()
        {
            List<WH_WareHouseModel> houseList = bllWareHouse.GetModelList("");
            this.View.IniHouseName(houseList);
        }
        private void IniPutawayList()
        {
            List<WH_Station_LogicModel> cellList = bllStationLogic.GetStationListByType(EnumCellType.上架工位.ToString());
            if(cellList == null)
            {
                return;
            }
            List<string> staList = new List<string>();
            foreach(WH_Station_LogicModel sta in cellList)
            {
                staList.Add(sta.WH_Station_Logic_Name);
            }
            this.View.IniPutawayList(staList);
        }
        public void IniCellList(string houseName)
        {
            List<View_CellModel> cellList = bllViewCell.GetPutawayCellList(houseName);
            this.View.IniCellList(cellList);
        }

        public void PutawayTask(string palletCode,string houseName, string putawayStationName, bool isAssign,string targetCell, bool isEmptyPallet)
        {
            if (palletCode == "")
            {
                this.View.ShowMessage("信息提示", "请输入托盘条码！");
                return;
            }
            if(isEmptyPallet == false)//不是空托盘，没有库存判断
            {
                StockModel stock = bllStock.GetModelByTrayCode(palletCode);
                if(stock == null)
                {
                    this.View.ShowMessage("信息提示", "请配盘入库！");
                    return;
                }             
            }

            ManageModel manageTemp = bllManage.GetModelByPalletCode(palletCode);
            if (manageTemp != null)
            {
                this.View.ShowMessage("信息提示", "当前托盘已经生成上架任务！");
                return;
            }
            string manageID = "";
            if (CreateManageTask(palletCode,houseName, putawayStationName, isAssign,targetCell, isEmptyPallet, ref manageID) == false)
            {
                return;
            }
            if (CreateManageListTask(manageID, palletCode) == false)
            {
                return;
            }
            this.WmsFrame.WriteLog("上架逻辑", "", "提示", "上架任务下达成功！");
        }

        private bool CreateManageTask(string palletCode, string houseName,string putawayStationName, bool isAssign,string targetStation, bool isEmptyPallet,ref string manageID)
        {
            ManageModel manage = new ManageModel();
            WH_Station_LogicModel stationCell = bllStationLogic.GetStationByName(putawayStationName);
            if (stationCell == null)
            {
                this.WmsFrame.WriteLog("上架逻辑", "", "提示", "上架站台不存在！");
                return false;
            }
            WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
            if(wareHouse == null)
            {
                this.WmsFrame.WriteLog("上架逻辑", "", "提示", "库房名称错误！");
                return false;
                     
            }
           View_StockListModel stock=bllViewStockList.GetModelByPalletCode(palletCode,EnumCellType.货位.ToString());
            if(stock!= null)
            {
                this.View.ShowMessage("信息提示", "库存中已经有此托盘条码！");
                return false;
            }
            View_CellModel targetCell = null;
            if (isAssign == true)//分配货位要做校验
            {
                string[] targetPos = targetStation.Split('-');
                if (targetPos == null || targetPos.Length != 2)
                {
                    this.WmsFrame.WriteLog("上架逻辑", "", "提示", "指定货位格式错误！");
                    return false;
                }
                string cellName = targetPos[0];
                string cellPos = targetPos[1];
                targetCell = bllViewCell.GetCell(wareHouse.WareHouse_ID, cellName, cellPos);

            }
            else
            {
                targetCell = bllViewCell.GetCell(wareHouse.WareHouse_ID);
            }

            if (targetCell == null)
            {
                this.WmsFrame.WriteLog("上架逻辑", "", "提示", "库房已满，没有货位可以申请了！");
                return false;
            }
            if(targetCell.Cell_Child_Run_Status!=EnumGSTaskStatus.完成.ToString()&&targetCell.Cell_Child_Status!=EnumCellStatus.空闲.ToString() )
            {
                this.WmsFrame.WriteLog("上架逻辑", "", "提示", "指定货位已经被占用！");
                return false;
            }

            manage.Mange_ID = Guid.NewGuid().ToString();

            manage.Mange_Start_Cell_ID = stationCell.Cell_Child_ID;
            manage.Mange_End_Cell_ID = targetCell.Cell_Chlid_ID;
            manage.Mange_Status = EnumManageTaskStatus.待执行.ToString();
            manage.Manage_BreakDown_Status = "待分解";
            manage.Mange_Stock_Barcode = palletCode;
            if (isEmptyPallet == true)
            {
                manage.Mange_Type_ID = "7";// EnumManageTaskType.空托盘上架.ToString();
            }
            else
            {
                manage.Mange_Type_ID ="6";//上架
            }
            View_Plan_StockListModel plan = bllViewPalnStockList.GetModelByPalletCode(palletCode);
            if (plan == null)
            {
                this.WmsFrame.WriteLog("上架逻辑", "", "提示", "当前库存没有对应计划！");
                return false;
            }
           

            manage.Plan_ID = plan.Plan_ID;

            manageID = manage.Mange_ID;
            bllManage.Add(manage);
            return true;
        }
        private bool CreateManageListTask(string manageID, string palletCode)
        {
            List<View_StockListModel> stockList = bllViewStockList.GetModelListByPalletCode(palletCode,EnumCellType.配盘工位.ToString());
            if (stockList == null)
            {
                this.WmsFrame.WriteLog("上架逻辑", "", "提示", "储存为空！");
                return false;
            }
            //View_Plan_StockListModel plan = bllViewPalnStockList.GetModelByPalletCode(palletCode);

            foreach (View_StockListModel stock in stockList)
            {
                Manage_ListModel manageListModel = new Manage_ListModel();
                Plan_ListModel planList = bllPlanList.GetModel(stock.Plan_List_ID);
                
                planList.Plan_List_Ordered_Quantity = stock.Stock_List_Quantity;
                bllPlanList.Update(planList);

                manageListModel.Manage_List_ID = Guid.NewGuid().ToString();
                manageListModel.Manage_List_Quantity = stock.Stock_List_Quantity;
                manageListModel.Mange_ID = manageID;
                manageListModel.Stock_List_ID = stock.Stock_List_ID;
                bllManageList.Add(manageListModel);
            }
            return true;
        }
    }
}
