using System;
using System.Data;
using System.Collections.Generic;
 
namespace WMS_Database
{
    /// <summary>
    /// View_StockList
    /// </summary>
    public partial class View_StockListBLL
    {
        private readonly WMS_Database.View_StockListDAL dal = new WMS_Database.View_StockListDAL();
        public View_StockListBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Stock_ID, string Stock_List_ID, string Plan_List_ID, string Goods_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Cell_ID, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Status, string Cell_Child_Model, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_Type, string Cell_InOut, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string WareHouse_ID, string Area_Code, string Area_Type, string Area_Name, int Area_Order, string Area_Flag, string Area_BackColor, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, DateTime Goods_ProduceDate, string Goods_Asset, int Goods_Shelf_Life, string Goods_Department, string Goods_Remark, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Flag, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag, string WareHouse_Remark)
        {
            return dal.Exists(Cell_Child_ID, Stock_Tray_Barcode, Stock_Full_Flag, Stock_Remark, Stock_ID, Stock_List_ID, Plan_List_ID, Goods_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Stock_List_Entry_Time, Stock_List_Update_Time, Cell_ID, Cell_Chlid_ID, Cell_Chlid_Position, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Status, Cell_Child_Model, Cell_Child_Run_Status, Cell_Child_Flag, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Area_ID, Cell_Code, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_Type, Cell_InOut, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, WareHouse_ID, Area_Code, Area_Type, Area_Name, Area_Order, Area_Flag, Area_BackColor, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Suppier_Code, Goods_Model, Goods_Desc, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Order, Goods_Flag, Goods_Danger, Goods_Category, Goods_ProduceDate, Goods_Asset, Goods_Shelf_Life, Goods_Department, Goods_Remark, Goods_Class_Parent_ID, Goods_Class_Code, Goods_Class_Name, Goods_Class_Remark, Goods_Class_Order, Goods_Class_Flag, WareHouse_Code, WareHouse_Name, WareHouse_Type, WareHouse_Flag, WareHouse_Remark);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_StockListModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_StockListModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Stock_ID, string Stock_List_ID, string Plan_List_ID, string Goods_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Cell_ID, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Status, string Cell_Child_Model, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_Type, string Cell_InOut, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string WareHouse_ID, string Area_Code, string Area_Type, string Area_Name, int Area_Order, string Area_Flag, string Area_BackColor, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, DateTime Goods_ProduceDate, string Goods_Asset, int Goods_Shelf_Life, string Goods_Department, string Goods_Remark, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Flag, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag, string WareHouse_Remark)
        {

            return dal.Delete(Cell_Child_ID, Stock_Tray_Barcode, Stock_Full_Flag, Stock_Remark, Stock_ID, Stock_List_ID, Plan_List_ID, Goods_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Stock_List_Entry_Time, Stock_List_Update_Time, Cell_ID, Cell_Chlid_ID, Cell_Chlid_Position, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Status, Cell_Child_Model, Cell_Child_Run_Status, Cell_Child_Flag, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Area_ID, Cell_Code, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_Type, Cell_InOut, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, WareHouse_ID, Area_Code, Area_Type, Area_Name, Area_Order, Area_Flag, Area_BackColor, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Suppier_Code, Goods_Model, Goods_Desc, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Order, Goods_Flag, Goods_Danger, Goods_Category, Goods_ProduceDate, Goods_Asset, Goods_Shelf_Life, Goods_Department, Goods_Remark, Goods_Class_Parent_ID, Goods_Class_Code, Goods_Class_Name, Goods_Class_Remark, Goods_Class_Order, Goods_Class_Flag, WareHouse_Code, WareHouse_Name, WareHouse_Type, WareHouse_Flag, WareHouse_Remark);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_StockListModel GetModel(string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Stock_ID, string Stock_List_ID, string Plan_List_ID, string Goods_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Cell_ID, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Status, string Cell_Child_Model, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_Type, string Cell_InOut, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string WareHouse_ID, string Area_Code, string Area_Type, string Area_Name, int Area_Order, string Area_Flag, string Area_BackColor, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, DateTime Goods_ProduceDate, string Goods_Asset, int Goods_Shelf_Life, string Goods_Department, string Goods_Remark, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Flag, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag, string WareHouse_Remark)
        {

            return dal.GetModel(Cell_Child_ID, Stock_Tray_Barcode, Stock_Full_Flag, Stock_Remark, Stock_ID, Stock_List_ID, Plan_List_ID, Goods_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Stock_List_Entry_Time, Stock_List_Update_Time, Cell_ID, Cell_Chlid_ID, Cell_Chlid_Position, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Status, Cell_Child_Model, Cell_Child_Run_Status, Cell_Child_Flag, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Area_ID, Cell_Code, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_Type, Cell_InOut, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, WareHouse_ID, Area_Code, Area_Type, Area_Name, Area_Order, Area_Flag, Area_BackColor, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Suppier_Code, Goods_Model, Goods_Desc, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Order, Goods_Flag, Goods_Danger, Goods_Category, Goods_ProduceDate, Goods_Asset, Goods_Shelf_Life, Goods_Department, Goods_Remark, Goods_Class_Parent_ID, Goods_Class_Code, Goods_Class_Name, Goods_Class_Remark, Goods_Class_Order, Goods_Class_Flag, WareHouse_Code, WareHouse_Name, WareHouse_Type, WareHouse_Flag, WareHouse_Remark);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_StockListModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_StockListModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_StockListModel> modelList = new List<WMS_Database.View_StockListModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_StockListModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        public List<View_StockListModel> GetModelListByPalletCode(string palletCode,string cellType)
        {
            string sqlStr = "Stock_Tray_Barcode = '" + palletCode + "' and Cell_Type = '" + cellType+"'";
            return GetModelList(sqlStr);

        }
        public List<View_StockListModel> GetModelListByPalletCode(string palletCode)
        {
            string sqlStr = "Stock_Tray_Barcode = '" + palletCode + "'";
            return GetModelList(sqlStr);

        }
        public List<View_StockListModel> GetModelListByCellID(string cellChildID)
        {
            string sqlStr = "Cell_Child_ID='" + cellChildID+"'";
            return GetModelList(sqlStr);
        }
        public View_StockListModel GetModelByPalletCode(string palletCode, string cellType)
        {
            string sqlStr = "Stock_Tray_Barcode = '" + palletCode + "'and Cell_Type = '" + cellType + "'";
            List<View_StockListModel> stockList= GetModelList(sqlStr);
            if(stockList!= null&&stockList.Count>0)
            {
                return stockList[0];
            }
            else
            {
                return null;
            }

        }
        public View_StockListModel GetModelByHousePallet(string houseID,string palletCode, string cellType)
        {
            string sqlStr = "WareHouse_ID = '"+houseID+"' and Stock_Tray_Barcode = '" + palletCode + "'and Cell_Type = '" + cellType + "'";
            List<View_StockListModel> stockList = GetModelList(sqlStr);
            if (stockList != null && stockList.Count > 0)
            {
                return stockList[0];
            }
            else
            {
                return null;
            }

        }
        public List<View_StockListModel> GetModelListByGoodsCode(string goodsCode,string cellType)
        {
            string sqlStr = "Goods_Code = '" + goodsCode + "' and Cell_Type ='" + cellType + "' order by Stock_List_Entry_Time asc";
            return GetModelList(sqlStr);

        }
        public List<View_StockListModel> GetModelList(string palletPos,string planCode)
        {
            string sqlStr = " Cell_Name='" + palletPos + "'";
            if(planCode != "所有")
            {
                sqlStr += " and Plan_List_ID in (select Plan_List_ID from View_PlanList where Plan_Code ='" + planCode + "')";
            }
            
            return GetModelList(sqlStr);
        }
        public List<View_StockListModel> GetPalletStock(string palletCode, string cellName)
        {
            string sqlStr = "Stock_Tray_Barcode = '" + palletCode + "' and Cell_Name='" + cellName + "' and Cell_Type='配盘工位'";
            return GetModelList(sqlStr);
        }

        public List<string> GetPalletCodeList()
        {
            DataSet ds = dal.GetPalletCodeList();
            List<string> palletList = new List<string>();
            if(ds!= null && ds.Tables.Count>0)
            {
              for(int i=0;i<ds.Tables[0].Rows.Count;i++)
              {
                  
                string pallet=  ds.Tables[0].Rows[i][0].ToString();
                palletList.Add(pallet);
              }
              return palletList;
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

