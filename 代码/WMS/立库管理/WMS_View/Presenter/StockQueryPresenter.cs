using CommonMoudle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
   public class StockQueryPresenter:BasePresenter<IStockQueryView>
   {
       WH_WareHouseBll bllHouse = new WH_WareHouseBll();
       WH_AreaBll bllArea = new WH_AreaBll();
       Goods_ClassBll bllMaterialClasl = new Goods_ClassBll();

       View_Plan_StockListBLL bllViewPlanStockList = new View_Plan_StockListBLL();

       View_CellBLL bllViewCell = new View_CellBLL();
       View_StockListBLL bllViewStockList = new View_StockListBLL();
       

       WH_Cell_ChildrenBll bllChildCell = new WH_Cell_ChildrenBll();
       WH_CellBll bllCell = new WH_CellBll();
       public StockQueryPresenter(IStockQueryView view,IWMSFrame wms):base(view,wms)
       {
          
       }
       public override void  Init()
       {
           InitHouseList();
           IniMaterialList();
           this.View.IniPalletList(new List<string>());
       }

       private void InitHouseList()
       {
           List<WH_WareHouseModel> houseList = bllHouse.GetModelList("");
           List<string> items = new List<string>();
           foreach(WH_WareHouseModel item in houseList)
           {
               items.Add(item.WareHouse_Name);
           }
           this.View.IniHouseList(items);
       }
       private void IniMaterialList()
       {
           
           List<string> items = bllMaterialClasl.GetDistinctGoods();
          
           this.View.IniMaterialCateList(items);
       }

       public void InitHouseRowList(string houseName)
       {
           WH_WareHouseModel wareHouse = bllHouse.GetModelByName(houseName);
           if (wareHouse == null)
           {
               return;
           }
           List<string> rowList = bllCell.GetRowListByDeviceCode(wareHouse.WareHouse_ID);
           this.View.IniRowList(rowList);
       }

       public void InitHouseColList(string houseName,string row)
       {
           WH_WareHouseModel wareHouse = bllHouse.GetModelByName(houseName);
           if (wareHouse == null)
           {
               return;
           }
           List<string> items = bllCell.GetColListByHouseRow(wareHouse.WareHouse_ID,row);
           this.View.IniColList(items);
       }
       public void InitHouseLayerList(string houseName, string row,string col)
       {
           WH_WareHouseModel wareHouse = bllHouse.GetModelByName(houseName);
           if (wareHouse == null)
           {
               return;
           }
           List<string> items = bllCell.GetLayerListByHouseRowCol(wareHouse.WareHouse_ID, row,col);
           this.View.IniLayerList(items);
       }
       public void QueryStockDetail(string cellCode)
       {
           ViewDataManager.STOCKQUERYDATAVIEWDATA.StockDetailList.Clear();
           List<View_StockListModel> stockList = bllViewStockList.GetStockDetail(cellCode);
           foreach(View_StockListModel stockDetail in stockList)
           {
               StockDetailViewModel sdm = new StockDetailViewModel();
               sdm.托盘条码 = stockDetail.Stock_Tray_Barcode;
               sdm.物料编码 = stockDetail.Goods_Code;
               sdm.物料个数 = stockDetail.Stock_List_Quantity;
               sdm.物料类别 = stockDetail.Goods_Class_Name;
               sdm.物料名称 = stockDetail.Goods_Name;
               ViewDataManager.STOCKQUERYDATAVIEWDATA.StockDetailList.Add(sdm);
           }
         
       }
       public void QueryStock(StockQueryParm stockParam)
       {
           Goods_ClassModel goodsClass = bllMaterialClasl.GetModelByClassName(stockParam.MaterialCate);
           string materialClassID = stockParam.MaterialCate;

           if (materialClassID != "所有")
           {

               if (goodsClass != null)
               {

                   materialClassID = goodsClass.Goods_Class_ID;
               }
               else
               {
                   this.View.ShowMessage("信息提示", "物料类别错误！");
               }
           }
           ViewDataManager.STOCKQUERYDATAVIEWDATA.StockList.Clear();
           ViewDataManager.STOCKQUERYDATAVIEWDATA.StockDetailList.Clear();
           List<View_StockListModel> stockList =bllViewStockList.GetListByParams(stockParam.HouseName, stockParam.Rowth, stockParam.Colth, stockParam.Layer, materialClassID, stockParam.PalletCode);


         


           var sdf = stockList.Distinct(new ListCompare<View_StockListModel>((x, y)
                => x.Stock_Tray_Barcode == y.Stock_Tray_Barcode));
           List<View_StockListModel> distinctStockList = sdf.ToList();
           //foreach (View_StockListModel vsm in stockList)
           //{
           //    var existPallet = distinctStockList.Where(s => s.Stock_Tray_Barcode == vsm.Stock_Tray_Barcode);
           //    if (existPallet == null || existPallet.Count() == 0)
           //    {
           //        distinctStockList.Add(vsm);
           //    }
           //}

           foreach (View_StockListModel item in distinctStockList)
           {
               StockViewModel svm = new StockViewModel();
               svm.货位编码 = item.Cell_Chlid_ID;
               svm.货位名称 = item.Cell_Name;
               svm.库房名称 = item.WareHouse_Name;
               svm.库区 = item.Area_Name;
               svm.位置 = item.Cell_Chlid_Position;
               if (item.Stock_List_Entry_Time != null)
               {
                   svm.入库时间 = item.Stock_List_Entry_Time.ToString();
               }


               ViewDataManager.STOCKQUERYDATAVIEWDATA.StockList.Add(svm);
           }
       }


    }
}
