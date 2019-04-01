using CommonMoudle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;
namespace WMS_Kernel
{
   public class UnShelveWithoutPlanPresenter:BasePresenter<IUnShelveWithoutPlanView>
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

       private static View_ManageStockListBLL bllViewManageStockList = new View_ManageStockListBLL();


       private static StockBll bllStock = new StockBll();

       PlanBll bllPlan = new PlanBll();
       Plan_ListBll bllPlanList = new Plan_ListBll();

       View_ManageBLL bllViewManage = new View_ManageBLL();
       View_ManageListBLL bllViewManageList = new View_ManageListBLL();
       View_PlanMainBLL bllViewPlanMain = new View_PlanMainBLL();
       WH_Station_LogicBLL bllStationLogic = new WH_Station_LogicBLL();
       WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
       Func<UnShelveParams, ReturnObject> allowUnShelve = null;
       public UnShelveWithoutPlanPresenter(IUnShelveWithoutPlanView view, IWMSFrame wmsFrame)
           : base(view, wmsFrame)
       {

       }
       public override void Init()
       {
       
           IniHouseList();
           //GetUnShelveStation();
       }

     
       public void IniUnShelveStationList(string houseName)
       {
           WH_WareHouseModel house = bllWareHouse.GetModelByName(houseName);
           if (house == null)
           {
               return;
           }
           string houseID = "";
           //if (houseName == "A1库房" || houseName == "A2库房" || houseName == "A3库房" || houseName == "A4库房" || houseName == "A5库房")
           //{
           //    houseID = "1-5库房";
           //}
           //else
           //{
           houseID = house.WareHouse_ID;
           //}
           List<WH_Station_LogicModel> staionList = bllStationLogic.GetModelListByHouseIDAndCellType(houseID, EnumCellType.下架工位.ToString());
           List<string> stationList = new List<string>();


           foreach (WH_Station_LogicModel station in staionList)
           {
               stationList.Add(station.WH_Station_Logic_Name);
           }
           this.View.IniTargetList(stationList);
       }
     
       private void IniHouseList()
       {
           List<WH_WareHouseModel> houseList = bllWareHouse.GetModelList("");
           this.View.IniHouseName(houseList);

          
       }
       public void IniRclp(string hoseName)
       {
           List<string> rows = bllViewCell.GetGsRCLData(hoseName, 0);
           List<string> cols = bllViewCell.GetGsRCLData(hoseName, 1);
           List<string> layers = bllViewCell.GetGsRCLData(hoseName, 2);
           List<string> poses = bllViewCell.GetGsRCLData(hoseName, 3);

           this.View.IniRows(rows);
           this.View.IniCols(cols);
           this.View.IniLayers(layers);
           this.View.IniPoses(poses);
       }
       public void RegistUnShelve(Func<UnShelveParams, ReturnObject> unShelve)
       {
           this.allowUnShelve = unShelve;
       }
       //public void IniRows(string houseName)
       //{
       //    //IniPutawayList(houseName);
       //    WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
       //    if (wareHouse == null)
       //    {
       //        this.View.ShowMessage("信息提示", "库房不存在！");
       //        return;
       //    }
       //    List<string> rowList = bllViewCell.GetRCL(wareHouse.WareHouse_ID, 0, 0, 0, 0);
       //    this.View.IniRows(rowList);
       //    //List<View_CellModel> cellList = bllViewCell.GetPutawayCellList(houseName);
       //    //this.View.IniCellList(cellList);
       //}
       public void IniCols(string houseName, int rowth)
       {
           WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
           if (wareHouse == null)
           {
               this.View.ShowMessage("信息提示", "库房不存在！");
               return;
           }
           List<string> colList = bllViewCell.GetRCL(wareHouse.WareHouse_ID, rowth, 0, 0, 1);
           this.View.IniCols(colList);
       }
       public void IniLayers(string houseName, int rowth, int colth)
       {
           WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
           if (wareHouse == null)
           {
               this.View.ShowMessage("信息提示", "库房不存在！");
               return;
           }
           List<string> layers = bllViewCell.GetRCL(wareHouse.WareHouse_ID, rowth, colth, 0, 2);
           this.View.IniLayers(layers);
       }
       public void IniPos(string houseName, int rowth, int colth, int layerth)
       {
           WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
           if (wareHouse == null)
           {
               this.View.ShowMessage("信息提示", "库房不存在！");
               return;
           }
           List<string> poses = bllViewCell.GetRCL(wareHouse.WareHouse_ID, rowth, colth, layerth, 3);
           this.View.IniPoses(poses);
       }
       public void GetUnShelveStation(string houseName)
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
           WH_WareHouseModel house = bllWareHouse.GetModelByName(houseName);
           if (house == null)
           {
               this.View.ShowMessage("信息提示", "不存在此库房");
               return;
           }

           List<WH_Station_LogicModel> staionList = bllStationLogic.GetStationListByType(house.WareHouse_ID, EnumCellType.下架工位.ToString());
           List<string> stationList = new List<string>();


           foreach (WH_Station_LogicModel station in staionList)
           {
               stationList.Add(station.WH_Station_Logic_Name);
           }
           this.View.IniTargetList(stationList);

       }
      
       public void QueryStockInfor(string houseName,string row,string col,string layer,string pos,string palletCode,string materialInfo)
       {
           //if (houseName== "")
           //{
           //    this.View.ShowMessage("信息提示", "请输入库房名称！");
           //    return;
           //}
           //string querySql =
           List<View_StockListModel> stockList = bllViewStockList.GetStockList(houseName, row, col, layer, pos, palletCode, materialInfo);

           var sdf = stockList.Distinct(new ListCompare<View_StockListModel>((x, y)
               => x.Stock_Tray_Barcode == y.Stock_Tray_Barcode));

           List<View_StockListModel> distintStockList = sdf.ToList();
           ViewDataManager.UNSHELVEWITHPPLANVIEWDATA.PalletData.Clear();
           ViewDataManager.UNSHELVEWITHPPLANVIEWDATA.PalletInforData.Clear();
           if (distintStockList == null || distintStockList.Count == 0)
           {
               this.View.ShowMessage("信息提示", "库房无库存信息！");
               return;
           }
           foreach (View_StockListModel stock in distintStockList)
           {
               PalletData palletInfor = new PalletData();
               palletInfor.库房 = stock.WareHouse_Name;
               palletInfor.存储货位 = stock.Cell_Name + "-" + stock.Cell_Chlid_Position;
               palletInfor.存储库区 = stock.Area_Name;
               palletInfor.更新时间 = stock.Stock_List_Update_Time.ToString();
               
               palletInfor.入库时间 = stock.Stock_List_Entry_Time.ToString();
                
               palletInfor.托盘条码 = stock.Stock_Tray_Barcode;
              
               ViewDataManager.UNSHELVEWITHPPLANVIEWDATA.PalletData.Add(palletInfor);
           }

       }

       public void PalletDetail(string palletCode)
       {
           List<View_StockListModel> stockList = bllViewStockList.GetModelListByPalletCode(palletCode, EnumCellType.货位.ToString());

           ViewDataManager.UNSHELVEWITHPPLANVIEWDATA.PalletInforData.Clear();
           if (stockList == null || stockList.Count == 0)
           {
               this.View.ShowMessage("信息提示", "托盘无物料信息！");
               return;
           }
           foreach (View_StockListModel stock in stockList)
           {
               PalletInfor palletInfor = new PalletInfor();
               palletInfor.库房 = stock.WareHouse_Name;
               palletInfor.存储货位 = stock.Cell_Name + "-" + stock.Cell_Chlid_Position;
               palletInfor.存储库区 = stock.Area_Name;
               palletInfor.更新时间 = stock.Stock_List_Update_Time.ToString();
               palletInfor.规格型号 = stock.Goods_Model;
               palletInfor.计量单位 = stock.Goods_Unit;
               palletInfor.入库时间 = stock.Stock_List_Entry_Time.ToString();
               //palletInfor.生产日期 = stock.Goods_ProduceDate;
               palletInfor.是否满盘 = stock.Stock_Full_Flag;

               palletInfor.数量 = stock.Stock_List_Quantity;
               palletInfor.托盘条码 = stock.Stock_Tray_Barcode;
               palletInfor.物料编码 = stock.Goods_Code;
               palletInfor.物料名称 = stock.Goods_Name;
               ViewDataManager.UNSHELVEWITHPPLANVIEWDATA.PalletInforData.Add(palletInfor);
           }
       }

       public void UnShelveTask(string palletCode, string houseName, string unshelveStationName)
       {
           string planCode = "-1";
           //查看当前是否已经有此托盘条码的上架管理任务
           View_Manage_ListModel manageWait = bllViewManageList.GetModelByPalletCodeAndTaskType(palletCode, EnumManageTaskType.下架.ToString(), EnumManageTaskStatus.待执行.ToString());
           View_Manage_ListModel manageRun = bllViewManageList.GetModelByPalletCodeAndTaskType(palletCode, EnumManageTaskType.下架.ToString(), EnumManageTaskStatus.执行中.ToString());

           if (manageWait != null||manageRun!=null)
           {
               //this.WmsFrame.WriteLog("下架逻辑", "", "提示", "当前托盘下架任务已经下发！");
               this.View.ShowMessage("信息提示", "当前托盘下架任务已经下发！");
               return;
           }

           string restr = "";

           string manageID = "";

           //if(CheckMaterialNum(ref restr) == false)//先不加个数校验
           //{
           //    this.View.ShowMessage("信息提示", restr);
           //    return ;
           //}
          
           ReturnObject allowCreateTask = new ReturnObject();
           allowCreateTask.Status = true;
           if (this.allowUnShelve != null)
           {
               UnShelveParams unshelveParams = new UnShelveParams();
               allowCreateTask = this.allowUnShelve(unshelveParams);
           }
           if (allowCreateTask.Status == false)
           {
               this.View.ShowMessage("信息提示", allowCreateTask.Describe);
               return;
           }

           if (CommonMoudle.TaskHandleMethod.CreateUnshelveManageTask(planCode, palletCode, houseName, unshelveStationName, ref manageID, ref restr) == false)
           {
               this.WmsFrame.WriteLog("下架逻辑", "", "提示", restr);
               return;
           }


           //下架管理任务生成完毕后需要更新货位状态,计划状态根据管理任务状态更新
           if (UpateCellStatus(palletCode, EnumGSOperate.出库, EnumGSTaskStatus.锁定) == false)
           {
               return;
           }
           this.WmsFrame.WriteLog("下架逻辑", "", "提示", restr);
       }
        

       private bool CheckMaterialNum(ref string restr)
       {
           Dictionary<string, float> materialNum = new Dictionary<string, float>();
           for (int i = 0; i < ViewDataManager.UNSHELVEPALNDATA.PalletInforData.Count; i++)
           {
               PalletInfor trayGoodsModel = ViewDataManager.UNSHELVEPALNDATA.PalletInforData[i];
               if (materialNum.Keys.Contains(trayGoodsModel.物料编码) == false)
               {
                   materialNum[trayGoodsModel.物料编码] =float.Parse( trayGoodsModel.数量);
                   continue;
               }
               materialNum[trayGoodsModel.物料编码] += float.Parse(trayGoodsModel.数量);
           }
           foreach (KeyValuePair<string, float> keyValue in materialNum)
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
           foreach (PlanListModel planDetail in ViewDataManager.UNSHELVEPALNDATA.PlanListData)
           {
               if (planDetail.物料编码 == materialCode)
               {
                   return (int.Parse(planDetail.计划数量) - int.Parse(planDetail.下达数量));
               }
           }
           return 0;
       }

       private bool UpateCellStatus(string palletCode, EnumGSOperate cellOperStatus, EnumGSTaskStatus taskStatus)
       {
           View_StockListModel stockModel = bllViewStockList.GetModelByPalletCode(palletCode, EnumCellType.货位.ToString());
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
