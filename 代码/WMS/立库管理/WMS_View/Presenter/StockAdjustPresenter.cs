using CommonMoudle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;
namespace WMS_Kernel
{
    public class StockAdjustPresenter : BasePresenter<IStockAdjustView>
   {
       View_Plan_StockListBLL bllViewPlanStockList = new View_Plan_StockListBLL();
       View_StockListBLL bllViewStockList = new View_StockListBLL();
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
       WH_Cell_ChildrenBll bllChildCell = new WH_Cell_ChildrenBll();
       
       public StockAdjustPresenter(IStockAdjustView view, IWMSFrame wmsFrame)
           : base(view, wmsFrame)
       {

       }

       public override void Init()
       {

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
               ViewDataManager.STOCKADJUSTVIEWDATA.PalletGoodsData.Add(gsdModel);
           }
       }
       public void AddTrayGoods( string trayCode, string goodsNum, string goodsCode, string planCode)
       {
           if (trayCode.Trim() == "")
           {
               this.View.ShowMessage("信息提示", "请输入托盘条码！");
               return;
           }
           if (goodsNum == "")
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

           ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData.Add(tglm);
       }
       private bool IsExistPalletGoods(string palletCode, string goodsCode)
       {
           foreach (PalletGoodsList goods in ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData)
           {
               if (goods.物料编码 == goodsCode && goods.托盘条码 == palletCode)
               {
                   return true;
               }
           }
           return false;
       }
       
       public void TrayConfirm( string cellID)
       {
           try
           {
               
               string restr = "";
               //if (ViewDataManager.STOCKADJUSTVIEWDATA.PalletGoodsData.Count == 0)
               //{
               //    this.View.ShowMessage("信息提示", "请添加配盘物料！");
               //    return;
               //}

               List<View_Plan_StockListModel> oldStockList = bllViewPlanStockList.GetModelListByCellID(cellID);

               View_CellModel cell = bllViewCell.GetModelByChildCellID(cellID);
               if (cell == null)
               {
                   this.View.ShowMessage("信息提示", "库存货位错误！");
                   return;
               }
               if (cell.Cell_Child_Flag != "1")
               {
                   this.View.ShowMessage("信息提示", "被禁用的货位不允许调整库存！");
                  // this.WmsFrame.WriteLog("库存调整", "", "提示", "被禁用的货位不允许调整库存!");
                   return;
               }
               if(cell.Cell_Child_Status == EnumGSTaskStatus.锁定.ToString())
               {
                   this.View.ShowMessage("信息提示", "被锁定的货位不允许调整库存！请等待任务执行完成再调整！");
                   return;
               }
               if( ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData.Count==0)//清空库存
               {
                   if(this.View.AskMessage("信息提示", "您确定要清空此货位库存么？")!=0)
                   {
                       return;
                   }
                   string operteDetail = cell.WareHouse_Name + "：[" + cell.Cell_Name + "]库存手动清空！";
                   TaskHandleMethod.AddCellOperRecord(cellID, EnumGSOperateType.手动修改状态, operteDetail, ref restr);
                   TaskHandleMethod.DeleteStockByCellChildID(cellID);
                   if( AddRecord(cellID, EnumCellStatus.空闲, EnumGSTaskStatus.完成,ref restr)==false)
                   {
                       this.View.ShowMessage("信息提示", "库存状态、操作记录更新失败！");
                       return;
                   }
                   return;
               }
               List<string> distinctTray = new List<string>();
               foreach (PalletGoodsList tray in ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData)
               {
                   if (distinctTray.Contains(tray.托盘条码) == false)
                   {
                       distinctTray.Add(tray.托盘条码);
                   }
               }
               if(distinctTray.Count>1)
               {
                   this.View.ShowMessage("信息提示", "一个货位只允许有一个托盘！");
                   return;
               }
               foreach (string tray in distinctTray)
               {
                   List<StockModel> stockListModel = bllStock.GetModelListByTrayCode(tray);
                   foreach(StockModel stockModel in stockListModel)
                   {
                       if (stockModel != null && stockModel.Cell_Child_ID != cellID)
                       {
                           this.View.ShowMessage("信息提示", "托盘条码" + tray + "已经在库存中，请确认托盘条码！");
                           ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData.Clear();
                           return;
                       }
                   }
               }
               TaskHandleMethod.DeleteStockByCellChildID(cellID);//先清空库存在往里添加
               foreach (string tray in distinctTray)
               {
                   StockModel stock = new StockModel();
                   stock.Stock_ID = Guid.NewGuid().ToString();
                   stock.Cell_Child_ID = cell.Cell_Chlid_ID;
                   stock.Stock_Tray_Barcode = tray;
                   bllStock.Add(stock);

                   for (int i = 0; i < ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData.Count; i++)
                   {
                       PalletGoodsList trayGoodsModel = ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData[i];
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
                       if (oldStockList != null && oldStockList.Count>0)//计划编号从原来库存里获取
                       {
                           stockList.Plan_List_ID = oldStockList[0].Plan_List_ID;
                           if(oldStockList[0].Plan_List_ID !="-1")
                           {
                               if (UpdatePlanNum(oldStockList[0].Plan_List_ID, goods.Goods_ID, trayGoodsModel.数量.ToString(), ref restr) == false)
                               {
                                   this.WmsFrame.WriteLog("按计划配盘", "", "提示", restr);
                               }
                           }
                           
                       }
                       else//如果没有库存默认为无计划
                       {
                           stockList.Plan_List_ID = "-1";
                       }
                   
                       stockList.Stock_List_Box_Barcode = trayGoodsModel.托盘条码;
                       stockList.Stock_List_Entry_Time = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));                             
                       stockList.Stock_List_Quantity = trayGoodsModel.数量.ToString();
                       bllStockList.Add(stockList);

                   }

               }
               if (AddRecord(cellID, EnumCellStatus.满位, EnumGSTaskStatus.完成, ref restr) == false)
               {
                   this.View.ShowMessage("信息提示", "库存状态、操作记录更新失败！");
                   return;
               } 
               string operteStockDetail = cell.WareHouse_Name + "：[" + cell.Cell_Name + "]库存手动调整成功！！";

               TaskHandleMethod.AddCellOperRecord(cellID, EnumGSOperateType.手动修改状态, operteStockDetail, ref restr);
            
               ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData.Clear();//配盘完成后清除数据            
               this.View.ShowMessage("信息提示", "库存调整成功！");
           }
           catch (Exception ex)
           {
               this.View.ShowMessage("信息提示", "库存调整失败！" + ex.Message);
           }

       }
       private bool AddRecord(string cellID, EnumCellStatus cellStatus, EnumGSTaskStatus cellTaskStatus, ref string restr)
       {
           WH_Cell_ChildrenModel oldgsm = bllChildCell.GetModel(cellID);
           if (oldgsm == null)
           {
               return false;
           }
           if (oldgsm.Cell_Child_Flag != "1")
           {
               this.WmsFrame.WriteLog("库存看板", "", "提示", "被禁用的货位不允许修改状态!");
               return false;
           }
           View_CellModel cellModel = bllViewCell.GetModelByChildCellID(cellID);

           string operteStatusDetail = cellModel.WareHouse_Name + "：[" + cellModel.Cell_Name + "]货位状态由[" + oldgsm.Cell_Child_Status + "]变更为[空闲]；" + "货位任务状态由[" + oldgsm.Cell_Child_Run_Status + "]变更为[完成]";

           oldgsm.Cell_Child_Status = cellStatus.ToString();
           oldgsm.Cell_Child_Run_Status = cellTaskStatus.ToString();
           bllChildCell.Update(oldgsm);
           TaskHandleMethod.AddCellOperRecord(cellID, EnumGSOperateType.手动修改状态, operteStatusDetail, ref restr);

           return true;
       }
       private bool UpdatePlanNum(string planListID, string materialCode, string materialNum, ref string restr)
       {

           Plan_ListModel planListModel = bllPlanList.GetModel(planListID);
           if (planListModel == null)
           {
               restr = "计划列表编码错误：" + planListID;
               return false;
           }
           float orderNum = 0;
           if (planListModel.Plan_List_Ordered_Quantity.Trim() != "")
           {
               orderNum = int.Parse(planListModel.Plan_List_Ordered_Quantity);
           }
           orderNum +=float.Parse( materialNum);
           planListModel.Plan_List_Ordered_Quantity = orderNum.ToString();
           bllPlanList.Update(planListModel);
           return true;
       }
 
       public void DeleteTrayGoods(string pallet, string goodsCode)
       {
           for (int i = 0; i < ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData.Count; i++)
           {
               PalletGoodsList tglm = ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData[i];
               if (tglm.物料编码 == goodsCode && pallet == tglm.托盘条码)
               {
                   ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData.Remove(tglm);
                   break;
               }

           }
       }

       public void LoadStock(string cellID)
       {
           ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData.Clear();
           List<View_StockListModel> stockList = bllViewStockList.GetModelListByCellID(cellID);
           if(stockList!= null&& stockList.Count>0)
           {
               foreach (View_StockListModel stock in stockList)
               {
                   PalletGoodsList pgl = new PalletGoodsList();
                   pgl.单位 = stock.Goods_Unit;
                   pgl.规格型号 = stock.Goods_Model;
                   pgl.数量 = stock.Stock_List_Quantity;
                   pgl.托盘条码 = stock.Stock_Tray_Barcode;
                   pgl.物料编码 = stock.Goods_Code;

                   ViewDataManager.STOCKADJUSTVIEWDATA.PalletInforData.Add(pgl);
               }
           }
       }

      
    }
}
