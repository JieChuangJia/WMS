﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;
using WMS_Database;
using CommonMoudle;

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
            string restr = "";
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
            EnumManageTaskType manaTask = EnumManageTaskType.空托盘上架;
            if (isEmptyPallet == true)
            {
                manaTask = EnumManageTaskType.空托盘上架;
            }
            else
            {
                manaTask = EnumManageTaskType.上架;
            }
            if (TaskHandleMethod.CreatePutawayManageTask(palletCode, houseName, putawayStationName, isAssign, targetCell, manaTask, ref manageID, ref restr) == false)
            {
                this.WmsFrame.WriteLog("上架逻辑", "", "提示", "创建管理任务失败：" + restr);
                return;
            }
            //if (TaskHandleMethod.CreatePutawayManageListTask(manageID, palletCode, ref restr) == false)
            //{
            //    this.WmsFrame.WriteLog("上架逻辑", "", "提示", "创建管理任务列表失败：" + restr);
            //    return;
            //}
            this.WmsFrame.WriteLog("上架逻辑", "", "提示", "上架任务下达成功！");
        }

        public void IniPutawayPalletCode()
        {
            List<string> palletList = bllViewStockList.GetPalletCodeList();



            this.View.IniPalletCode(palletList);
        }

      
    }
}
