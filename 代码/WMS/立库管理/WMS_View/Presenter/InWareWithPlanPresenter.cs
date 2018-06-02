using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
 
using WMS_Interface;

namespace WMS_Kernel
{
   public class InWareWithPlanPresenter:BasePresenter<IInWareWithPlanView>
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
       public InWareWithPlanPresenter(IInWareWithPlanView view,IWMSFrame wmsFrame) :base(view,wmsFrame)
       {
        
       }

       public override void Init()
       {
           IniHouseList();
           IniPlanList();
           IniTargetPos();
       }

       public void QueryPlan(string planCode)
       {
           //List<View_Plan_StockListModel> stockList = bllViewStockList.GetModelByPlanID(planID);
           List<View_PlanListModel> planList = bllViewPlanList.GetModelByPlanCode(planCode);
           this.currPlanCode = planCode;
           ViewDataManager.PALLETWITHPLANDATA.PlanListData.Clear();
           if (planList == null || planList.Count == 0)
           {
               this.View.ShowMessage("信息提示", "无此计划信息！");
               return;
           }
           foreach (View_PlanListModel stockModel in planList)
           {
               PlanListModel planModel = new PlanListModel();
               planModel.计划列表编码 = stockModel.Plan_List_ID;
               planModel.计划单号 = planCode;
               planModel.规格型号 = stockModel.Goods_Model;
               planModel.计量单位 = stockModel.Goods_Unit;
               planModel.完成数量 = stockModel.Plan_List_Finished_Quantity.ToString();
               planModel.物料编码 = stockModel.Goods_Code;
               planModel.物料名称 = stockModel.Goods_Name;
               planModel.计划数量 = stockModel.Plan_List_Quantity;
               planModel.下达数量 = stockModel.Plan_List_Ordered_Quantity.ToString();
               //planModel.计划列表编码 = stockModel.Plan_List_ID;
               ViewDataManager.PALLETWITHPLANDATA.PlanListData.Add(planModel);
           }

          
       }
       public void AddTrayGoods(string planListID,string trayCode,int goodsNum,string goodsCode,string planCode)
       {
           if(trayCode.Trim() == "")
           {
               this.View.ShowMessage("信息提示", "请输入托盘条码！");
               return;
           }
           if (goodsNum == 0)
           {
               this.View.ShowMessage("信息提示", "请输入物料配盘数量！");
               return;
           }
           if (IsExistPalletGoods(trayCode,goodsCode) == true)
          {
              this.View.ShowMessage("信息提示", "此物料已经在配盘中！");
              return;
          }
           View_GoodsModel goodsModel = bllViewGoods.GetModelByGoodsCode(goodsCode);
           if(goodsModel ==null)
           {
               return;
           }
           TrayGoodsListModel tglm = new TrayGoodsListModel();
           tglm.计划单号 = planCode;
           tglm.计划列表编号 = planListID;
           tglm.托盘条码 = trayCode;
           tglm.单位 = goodsModel.Goods_Unit;
           tglm.规格型号 = goodsModel.Goods_Model;
           //tglm.生产日期 = createDatetime;
           tglm.数量 = goodsNum;
           tglm.物料编码 = goodsCode;
           
           ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData.Add(tglm);
       }
       private bool IsExistPalletGoods(string palletCode,string goodsCode)
       {
           foreach(TrayGoodsListModel goods in   ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData)
           {
               if (goods.物料编码 == goodsCode && goods.托盘条码 == palletCode)
               {
                   return true;
               }
           }
           return false;
       }

       public void TrayConfirm(string planListID, string recCellName)
       {
           try
           {
               string restr ="";
               if( ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData.Count ==0)
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
               WH_Station_LogicModel cell = bllStationLogic.GetStationByName( recCellName);
               if (cell == null)
               {
                   this.View.ShowMessage("信息提示", "配盘地点错误！");
                   return;
               }
               List<string> distinctTray = new List<string>();
               foreach(TrayGoodsListModel tray in ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData)
               {
                 if(distinctTray.Contains(tray.托盘条码) == false)
                 {
                     distinctTray.Add(tray.托盘条码);
                 }
               }
             foreach(string tray in distinctTray)
             {
                 StockModel stockModel = bllStock.GetModelByTrayCode(tray);
                 if (stockModel != null)
                 {
                     this.View.ShowMessage("信息提示", "托盘条码" + tray + "已经在库存中，请确认托盘条码！");
                     return;
                 }
             }

               if(CheckMaterialNum(ref restr) == false)
               {
                   this.View.ShowMessage("信息提示", restr);
                   return ;
               }
             foreach (string tray in distinctTray)
             {
                 StockModel stock = new StockModel();
                 stock.Stock_ID = Guid.NewGuid().ToString();
                 stock.Cell_Child_ID = cell.Cell_Child_ID;
                 stock.Stock_Tray_Barcode = tray;
                 bllStock.Add(stock);

                 for (int i = 0; i < ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData.Count; i++)
                 {
                     TrayGoodsListModel trayGoodsModel = ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData[i];
                     if(trayGoodsModel.托盘条码 != tray)
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
                     stockList.Plan_List_ID = trayGoodsModel.计划列表编号;
                     stockList.Stock_List_Box_Barcode = trayGoodsModel.托盘条码;
                     stockList.Stock_List_Entry_Time = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                     stockList.Stock_List_Quantity = trayGoodsModel.数量.ToString();

                     bllStockList.Add(stockList);

                     if (UpdatePlanNum(trayGoodsModel.计划列表编号, goods.Goods_ID, trayGoodsModel.数量, ref restr) == false)
                     {
                         this.WmsFrame.WriteLog("按计划配盘", "", "提示", restr);
                     }
                   
                 }
                 ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData.Clear();//配盘完成后清除数据
                 QueryPlan(this.currPlanCode);
             }
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
               if(materialNum.Keys.Contains(trayGoodsModel.物料编码) == false)
               {
                   materialNum[trayGoodsModel.物料编码] = trayGoodsModel.数量;
                   continue;
               }
               materialNum[trayGoodsModel.物料编码] += trayGoodsModel.数量;
           }
           foreach(KeyValuePair<string,int> keyValue in materialNum)
           {
               int planNum = GetPlanMateriNum(keyValue.Key);
               if(keyValue.Value > planNum)
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
       public void DeleteTrayGoods(string pallet,string goodsCode)
       {
           for (int i = 0; i < ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData.Count;i++ )
           {
               TrayGoodsListModel tglm = ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData[i];
               if(tglm.物料编码 == goodsCode&&pallet == tglm.托盘条码)
               {
                   ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData.Remove(tglm);
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
       public void TrayGoodsRecord(string trayCode,string targetHouseName,string targetStationName,string inputType,bool isFull)
       {
           //判断当前托盘是否已经在库存中了
           StockModel stock =  bllStock.GetModelByTrayCode(trayCode);
           if(stock!= null)
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
     
           foreach(TrayGoodsListModel goods in ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData)
           {
               
           }

       }
       private void IniHouseList()
       {
           //List<WH_WareHouseModel> houseList = bllWareHouse.GetModelList("");
           //this.View.IniHouseName(houseList);
       }
       public void IniPlanList()
       {
           List<View_PlanMainModel> planList = bllViewPlanMain.GetPlanListByStatus("1",EnumPlanStatus.执行中.ToString());//上架
           this.View.IniPlanList(planList);
       }

       private void IniTargetPos()
       {
           //WH_WareHouseModel house = bllWareHouse.GetModelByName(wareHouseName);
           //if(house ==null)
           //{
           //    this.View.ShowMessage("信息提示", "不存在此库房");
           //    return;
           //}
           List<WH_Station_LogicModel> statinList = bllStationLogic.GetStationListByType( EnumCellType.配盘工位.ToString());

           List<string> palletSta = new List<string>();
           if(statinList == null)
           {
               this.View.ShowMessage("信息提示", "此库房不存在配盘工位，请检查配置！");
               return;
           }
           foreach(WH_Station_LogicModel station in statinList)
           {
               palletSta.Add(station.WH_Station_Logic_Name);
           }
           this.View.IniTargetPos(palletSta);
       }


    }
}
