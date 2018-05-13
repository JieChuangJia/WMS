using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class PalletManagePresenter:BasePresenter<IPalletManageView>
    {
        WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        View_CellBLL bllViewCell = new View_CellBLL();
        View_StockListBLL bllViewStockList = new View_StockListBLL();
        Plan_ListBll bllPlanList = new Plan_ListBll();
        View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
         View_GoodsBLL bllView_Goods = new View_GoodsBLL();
         View_GoodsBLL bllViewGoods = new View_GoodsBLL();
         StockBll bllStock = new StockBll();
         Stock_ListBll bllStockList = new Stock_ListBll();
         WH_Station_LogicBLL bllStationLogic = new WH_Station_LogicBLL();
         GoodsBll bllGoods = new GoodsBll();
        public PalletManagePresenter(IPalletManageView view,IWMSFrame wmsFrame):base(view,wmsFrame)
        { }
        public override void Init()
        {
            IniHouseList();
            IniPalletPos();
        }
        private void IniHouseList()
        {
            List<WH_WareHouseModel> houseList = bllWareHouse.GetModelList("");
            this.View.IniHouseName(houseList);
        }
        private void IniPalletPos()
        {
            List<View_CellModel> cellList = bllViewCell.GetPalletStation();
            this.View.IniPalletPos(cellList);
        }
        public void QueryPalletInfo(string palletCode,string palletCellName)
        {
            List<View_StockListModel> stockList = bllViewStockList.GetPalletStock(palletCode, palletCellName);
            ViewDataManager.PALLETMANAGEDATA.PalletInforData.Clear();
            if(stockList==null)
            {
                return;
            }
            foreach (View_StockListModel stock in stockList)
            {
                TrayGoodsListModel pallet = new TrayGoodsListModel();
                pallet.保质期 = stock.Goods_Shelf_Life.ToString();
                pallet.单位 = stock.Goods_Unit;
                pallet.规格型号 = stock.Goods_Model;
                pallet.托盘条码 = stock.Stock_Tray_Barcode;
                pallet.生产日期 = (DateTime)stock.Goods_ProduceDate;
                pallet.数量 = int.Parse(stock.Stock_List_Quantity);
                pallet.物料编码 = stock.Goods_Code;

                
                ViewDataManager.PALLETMANAGEDATA.PalletInforData.Add(pallet);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="palletPos">配盘工位</param>
        public void QueryPallet(string houseName,string palletPos)
        {
            List<View_StockListModel> stockList = bllViewStockList.GetModelList(houseName, palletPos);
            ViewDataManager.PALLETMANAGEDATA.PalletList.Clear();
            if(stockList == null)
            {
                return;
            }
            foreach(View_StockListModel stock in stockList)
            {
                PalletListData pallet = new PalletListData();
                if(stock.Plan_List_ID =="-1")
                {
                    pallet.按计划配盘 = "否";
                }
                else
                {
                    pallet.按计划配盘 = "是";
                    View_PlanListModel planList = bllViewPlanList.GetModelByPlanListID(stock.Plan_List_ID);
                    pallet.计划代码 = planList.Plan_Code;
                }
                pallet.配盘时间 =(DateTime) stock.Stock_List_Entry_Time;
                pallet.托盘条码 = stock.Stock_Tray_Barcode;
                pallet.配盘工位名称 = stock.Cell_Name;
                ViewDataManager.PALLETMANAGEDATA.PalletList.Add(pallet);
                
            }
        }

        public void ShowGoods(string goodsInfor)
        {
            List<View_GoodsModel> goodsList = bllView_Goods.GetModelByGoosInfo(goodsInfor);
            ViewDataManager.PALLETMANAGEDATA.PalletGoodsData.Clear();
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

                ViewDataManager.PALLETMANAGEDATA.PalletGoodsData.Add(gsdModel);
            }
        }

        public void AddTrayGoods(string trayCode, int goodsNum, DateTime createDatetime, string goodsCode)
        {
            if (trayCode.Trim() == "")
            {
                this.View.ShowMessage("信息提示", "请输入托盘条码！");
                return;
            }
            if (goodsNum == 0)
            {
                this.View.ShowMessage("信息提示", "请输入物料配盘数量！");
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
                return;
            }
            TrayGoodsListModel tglm = new TrayGoodsListModel();
            tglm.单位 = goodsModel.Goods_Unit;
            tglm.规格型号 = goodsModel.Goods_Model;
            tglm.托盘条码 = trayCode;
            tglm.生产日期 = createDatetime;
            tglm.数量 = goodsNum;
            tglm.物料编码 = goodsCode;

            ViewDataManager.PALLETMANAGEDATA.PalletInforData.Add(tglm);
        }
        public void DeleteTrayGoods(string goodsCode)
        {
            for (int i = 0; i < ViewDataManager.PALLETMANAGEDATA.PalletInforData.Count; i++)
            {
                TrayGoodsListModel tglm = ViewDataManager.PALLETMANAGEDATA.PalletInforData[i];
                if (tglm.物料编码 == goodsCode)
                {
                    ViewDataManager.PALLETMANAGEDATA.PalletInforData.Remove(tglm);
                    break;
                }

            }
        }

        public void TrayConfirm( bool isFull, string palletCode, string recCellName)
        {
            try
            {
                if (ViewDataManager.PALLETMANAGEDATA.PalletInforData.Count == 0)
                {
                    this.View.ShowMessage("信息提示", "请添加配盘物料！");
                    return;
                }
               
                WH_Station_LogicModel cell = bllStationLogic.GetStationByName(recCellName);
                if (cell == null)
                {
                    this.View.ShowMessage("信息提示", "接口地点错误！");
                    return;
                }
                StockModel stockModel = bllStock.GetModelByTrayCode(palletCode);
                if (stockModel == null)
                {
                    this.View.ShowMessage("信息提示", "此托盘条码不在库存中！");
                    return;
                }
                stockModel.Cell_Child_ID = cell.Cell_Child_ID;
                stockModel.Stock_Tray_Barcode = palletCode;
                if (isFull == true)
                {
                    stockModel.Stock_Full_Flag = "1";
                }
                else
                {
                    stockModel.Stock_Full_Flag = "0";
                }
              
                bllStock.Update(stockModel);
                Stock_ListModel stockListTemp = bllStockList.GetModelByPalletCode(palletCode);
                if(stockListTemp == null)
                {
                    this.View.ShowMessage("信息提示", "此托盘中没有物料！");
                    return;
                }
                bllStockList.DeleteByStockID(stockModel.Stock_ID);
                for (int i = 0; i < ViewDataManager.PALLETMANAGEDATA.PalletInforData.Count; i++)
                {
                    Stock_ListModel stockList = new Stock_ListModel();
                    stockList.Stock_List_ID = Guid.NewGuid().ToString();
                    stockList.Stock_ID = stockModel.Stock_ID;
                    TrayGoodsListModel trayGoodsModel = ViewDataManager.PALLETMANAGEDATA.PalletInforData[i];
                    GoodsModel goods = bllGoods.GetModelByCode(trayGoodsModel.物料编码);
                    if (goods == null)
                    {
                        continue;
                    }
                    stockList.Goods_ID = goods.Goods_ID;
                    stockList.Plan_List_ID = stockListTemp.Plan_List_ID;
                    stockList.Stock_List_Box_Barcode = palletCode;
                    stockList.Stock_List_Entry_Time = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    stockList.Stock_List_Quantity = trayGoodsModel.数量.ToString();
                    bllStockList.Add(stockList);

                }
                this.View.ShowMessage("信息提示", "配盘成功！");
            }
            catch (Exception ex)
            {
                this.View.ShowMessage("信息提示", "配盘失败！" + ex.Message);
            }

        }
        private bool IsExistPalletGoods(string goodsCode)
        {
            foreach (TrayGoodsListModel goods in ViewDataManager.PALLETMANAGEDATA.PalletInforData)
            {
                if (goods.物料编码 == goodsCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
