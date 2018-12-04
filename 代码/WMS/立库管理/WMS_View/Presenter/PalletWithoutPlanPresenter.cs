using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;
namespace WMS_Kernel
{
   public class PalletWithoutPlanPresenter:BasePresenter<IPalletWithoutPlanView>
   {
       View_Plan_StockListBLL bllViewStockList = new View_Plan_StockListBLL();
       View_GoodsBLL bllViewGoods = new View_GoodsBLL();
       GoodsBll bllGoods = new GoodsBll();
       StockBll bllStock = new StockBll();
       Stock_ListBll bllStockList = new Stock_ListBll();
       WH_CellBll bllCell = new WH_CellBll();
       View_CellBLL bllViewCell = new View_CellBLL();
       View_PlanListBLL bllViewPlanList = new View_PlanListBLL();

       PlanBll bllPlan = new WMS_Database.PlanBll();
       Plan_ListBll bllPlanList = new Plan_ListBll();
       View_PlanMainBLL bllViewPlanMain = new View_PlanMainBLL();
       WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
       WH_Station_LogicBLL bllStationLogic = new WH_Station_LogicBLL();

       string currPlanCode = "";
       public PalletWithoutPlanPresenter(IPalletWithoutPlanView view,IWMSFrame wmsFrame):base(view,wmsFrame)
       {

       }

       public override void Init()
       {
           //IniHouseList();

           IniTargetPos();
       }

       public void QueryPlan(string goodsInfor)
       {
           List<View_GoodsModel> goodsList = bllViewGoods.GetModelByGoosInfo(goodsInfor);
           ViewDataManager.PALLETWITHOUTPLANDATA.PalletGoodsData.Clear();
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
               gsdModel.规格型号 = goods.Goods_Model;
               ViewDataManager.PALLETWITHOUTPLANDATA.PalletGoodsData.Add(gsdModel);
           }
       }
       public void AddTrayGoods( string trayCode, int goodsNum, string goodsCode, string planCode)
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
           if (IsExistPalletGoods(trayCode, goodsCode) == true)
           {
               this.View.ShowMessage("信息提示", "此物料已经在配盘中！");
               return;
           }
           View_GoodsModel goodsModel = bllViewGoods.GetModelByGoodsCode(goodsCode);
           if (goodsModel == null)
           {
               return;
           }
           PalletGoodsList tglm = new PalletGoodsList();
            
           tglm.托盘条码 = trayCode;
           tglm.单位 = goodsModel.Goods_Unit;
           tglm.规格型号 = goodsModel.Goods_Model;
           //tglm.生产日期 = createDatetime;
           tglm.数量 = goodsNum;
           tglm.物料编码 = goodsCode;

           ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData.Add(tglm);
       }
       private bool IsExistPalletGoods(string palletCode, string goodsCode)
       {
           foreach (PalletGoodsList goods in ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData)
           {
               if (goods.物料编码 == goodsCode && goods.托盘条码 == palletCode)
               {
                   return true;
               }
           }
           return false;
       }
       
       public void TrayConfirm( string recCellName)
       {
           try
           {
               //View_PlanListModel planlistView = bllViewPlanList.GetModelByPlanListID(planListID);
               //if (planlistView == null)
               //{
               //    return;
               //}
               //if (planlistView.Plan_Status == EnumPlanStatus.完成.ToString())
               //{
               //    this.View.ShowMessage("信息提示", "已完成的计划不允许再进行配盘操作！");
               //    return;
               //}
               string restr = "";
               if (ViewDataManager.PALLETWITHOUTPLANDATA.PalletGoodsData.Count == 0)
               {
                   this.View.ShowMessage("信息提示", "请添加配盘物料！");
                   return;
               }
               //if (isFull == true)
               //{
               //    stock.Stock_Full_Flag = "1";
               //}
               //else
               //{
               //    stock.Stock_Full_Flag = "0";
               //}
               //WH_WareHouseModel house = bllWareHouse.GetModelByName(houseName);
               //if (house == null)
               //{
               //    restr = "库房对象为空！";
               //    return ;
               //}
               WH_CellModel cell = bllCell.GetStationByName(recCellName);
               if (cell == null)
               {
                   this.View.ShowMessage("信息提示", "配盘地点错误！");
                   return;
               }
               List<string> distinctTray = new List<string>();
               foreach (PalletGoodsList tray in ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData)
               {
                   if (distinctTray.Contains(tray.托盘条码) == false)
                   {
                       distinctTray.Add(tray.托盘条码);
                   }
               }
               foreach (string tray in distinctTray)
               {
                   StockModel stockModel = bllStock.GetModelByTrayCode(tray);
                   if (stockModel != null)
                   {
                       this.View.ShowMessage("信息提示", "托盘条码" + tray + "已经在库存中，请确认托盘条码！");
                       ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData.Clear();
                       return;
                   }
               }

               //if (CheckMaterialNum(ref restr) == false)//不做校验了
               //{
               //    this.View.ShowMessage("信息提示", restr);
               //    return;
               //}
               foreach (string tray in distinctTray)
               {
                   StockModel stock = new StockModel();
                   stock.Stock_ID = Guid.NewGuid().ToString();
                   stock.Cell_Child_ID = cell.Cell_ID;
                   stock.Stock_Tray_Barcode = tray;
                   bllStock.Add(stock);

                   for (int i = 0; i < ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData.Count; i++)
                   {
                       PalletGoodsList trayGoodsModel = ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData[i];
                       if (trayGoodsModel.托盘条码 != tray)
                       {
                           continue;
                       }
                       Stock_ListModel stockList = new Stock_ListModel();
                       stockList.Stock_List_ID = Guid.NewGuid().ToString();
                       stockList.Stock_ID = stock.Stock_ID;

                       GoodsModel goods = bllGoods.GetModelByCode(trayGoodsModel.物料编码);
                       if (goods == null)
                       {
                           continue;
                       }
                       stockList.Goods_ID = goods.Goods_ID;
                       stockList.Plan_List_ID = "-1";
                       stockList.Stock_List_Box_Barcode = trayGoodsModel.托盘条码;
                       stockList.Stock_List_Entry_Time = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                       
                      
                       stockList.Stock_List_Quantity = trayGoodsModel.数量.ToString();
                  
                       bllStockList.Add(stockList);

                       //if (UpdatePlanNum(trayGoodsModel.计划列表编号, goods.Goods_ID, trayGoodsModel.数量, ref restr) == false)
                       //{
                       //    this.WmsFrame.WriteLog("按计划配盘", "", "提示", restr);
                       //}

                   }

               }
               ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData.Clear();//配盘完成后清除数据            
               this.View.ShowMessage("信息提示", "配盘成功！");
           }
           catch (Exception ex)
           {
               this.View.ShowMessage("信息提示", "配盘失败！" + ex.Message);
           }

       }

       private bool UpdatePlanNum(string planListID, string materialCode, int materialNum, ref string restr)
       {

           Plan_ListModel planListModel = bllPlanList.GetModel(planListID);
           if (planListModel == null)
           {
               restr = "计划列表编码错误：" + planListID;
               return false;
           }
           int orderNum = 0;
           if (planListModel.Plan_List_Ordered_Quantity.Trim() != "")
           {
               orderNum = int.Parse(planListModel.Plan_List_Ordered_Quantity);
           }
           orderNum += materialNum;
           planListModel.Plan_List_Ordered_Quantity = orderNum.ToString();
           bllPlanList.Update(planListModel);
           return true;
       }

       private bool CheckMaterialNum(ref string restr)
       {
           Dictionary<string, int> materialNum = new Dictionary<string, int>();
           for (int i = 0; i < ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData.Count; i++)
           {
               TrayGoodsListModel trayGoodsModel = ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData[i];
               if (materialNum.Keys.Contains(trayGoodsModel.物料编码) == false)
               {
                   materialNum[trayGoodsModel.物料编码] = trayGoodsModel.数量;
                   continue;
               }
               materialNum[trayGoodsModel.物料编码] += trayGoodsModel.数量;
           }
           foreach (KeyValuePair<string, int> keyValue in materialNum)
           {
               int planNum = GetPlanMateriNum(keyValue.Key);
               if (keyValue.Value > planNum)
               {
                   restr = "物料：" + keyValue.Key + "超出计划剩余的数量（计划数量-下达数量）";
                   return false;
               }
           }
           return true;
       }

       private int GetPlanMateriNum(string materialCode)
       {
           foreach (PlanListModel planDetail in ViewDataManager.PALLETWITHPLANDATA.PlanListData)
           {
               if (planDetail.物料编码 == materialCode)
               {
                   return (int.Parse(planDetail.计划数量) - int.Parse(planDetail.下达数量));
               }
           }
           return 0;
       }
       public void DeleteTrayGoods(string pallet, string goodsCode)
       {
           for (int i = 0; i < ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData.Count; i++)
           {
               PalletGoodsList tglm = ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData[i];
               if (tglm.物料编码 == goodsCode && pallet == tglm.托盘条码)
               {
                   ViewDataManager.PALLETWITHOUTPLANDATA.PalletInforData.Remove(tglm);
                   break;
               }

           }
       }
       /// <summary>
       ///  配盘数据，建立库存
       /// </summary> 
       /// <param name="trayCode">托盘码</param>
       /// <param name="targetHouseName">目标库房名称</param>
       /// <param name="targetStationName">目标站台名称，可做成配置</param>
       /// <param name="inputType">入库类型</param>
       /// <param name="isFull">满盘标识</param>
       public void TrayGoodsRecord(string trayCode, string targetHouseName, string targetStationName, string inputType, bool isFull)
       {
           //判断当前托盘是否已经在库存中了
           StockModel stock = bllStock.GetModelByTrayCode(trayCode);
           if (stock != null)
           {
               this.View.ShowMessage("信息提示", "已经存在此托盘库存！");
               return;
           }

           StockModel stockModel = new StockModel();
           stockModel.Cell_Child_ID = "-1";
           if (isFull == true)
           {
               stockModel.Stock_Full_Flag = "1";
           }
           else
           {
               stockModel.Stock_Full_Flag = "0";
           }

           foreach (TrayGoodsListModel goods in ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData)
           {

           }

       }
       private void IniHouseList()
       {
           List<WH_WareHouseModel> houseList = bllWareHouse.GetModelList("");
           this.View.IniHouseName(houseList);
       }


       private void IniTargetPos()
       {
           //WH_WareHouseModel house = bllWareHouse.GetModelByName(houseName);
           //if (house == null)
           //{
           //    this.View.ShowMessage("信息提示", "不存在此库房");
           //    return;
           //}
           List<string> statinList = bllStationLogic.GetStationCellName();

           //List<string> palletSta = new List<string>();
           //if (statinList == null)
           //{
           //    this.View.ShowMessage("信息提示", "此库房不存在配盘工位，请检查配置！");
           //    return;
           //}
           //List<string> statinList = bllStationLogic.GetStationCellName();
           //foreach (WH_Station_LogicModel station in statinList)
           //{
           //    palletSta.Add(station.WH_Station_Logic_Name);
           //}
           this.View.IniTargetPos(statinList);
       }
    }
}
