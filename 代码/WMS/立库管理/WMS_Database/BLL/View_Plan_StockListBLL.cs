using System;
using System.Data;
using System.Collections.Generic;

namespace WMS_Database
{
    /// <summary>
    /// View_Plan_StockList
    /// </summary>
    public partial class View_Plan_StockListBLL
    {
        private readonly WMS_Database.View_Plan_StockListDAL dal = new WMS_Database.View_Plan_StockListDAL();
        public View_Plan_StockListBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Stock_List_ID, string Stock_ID, string Plan_List_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, string Goods_ID, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Code, string Goods_Class_ID, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Level, string Goods_Limit_Lower_Quantity, string Goods_Remark, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Stock_Tray_Barcode, string Stock_Full_Flag, string WareHouse_ID, string Area_Type, string Area_Code, string Area_Name, int Area_Order, string Area_Flag, string Area_BackColor, string Area_Remark, string Area_Reserve1, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag, string WareHouse_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, string Plan_ID, string Plan_Remark, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, int Goods_Shelf_Life, DateTime Goods_ProduceDate, int Goods_Order, string Goods_Type, string Area_ID, string Cell_Code, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Status, string Cell_Child_Model, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Goods_Suppier_Code)
        {
            return dal.Exists(Stock_List_ID, Stock_ID, Plan_List_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Goods_ID, Stock_List_Entry_Time, Stock_List_Update_Time, Stock_List_Remark, Goods_Code, Goods_Class_ID, Goods_Name, Goods_Desc, Goods_Model, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Level, Goods_Limit_Lower_Quantity, Goods_Remark, Goods_Flag, Goods_Danger, Goods_Category, Goods_Asset, Goods_Department, Goods_Reserve1, Goods_Reserve2, Stock_Tray_Barcode, Stock_Full_Flag, WareHouse_ID, Area_Type, Area_Code, Area_Name, Area_Order, Area_Flag, Area_BackColor, Area_Remark, Area_Reserve1, WareHouse_Code, WareHouse_Name, WareHouse_Type, WareHouse_Flag, WareHouse_Remark, Plan_Type_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_End_Time, Plan_Begin_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_List_Quantity, Plan_List_Ordered_Quantity, Plan_ID, Plan_Remark, Plan_List_Finished_Quantity, Plan_List_Status, Plan_List_Remark, Goods_Shelf_Life, Goods_ProduceDate, Goods_Order, Goods_Type, Area_ID, Cell_Code, Cell_Chlid_ID, Cell_Chlid_Position, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Status, Cell_Child_Model, Cell_Child_Run_Status, Cell_Child_Flag, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, Goods_Suppier_Code);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_Plan_StockListModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_Plan_StockListModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Stock_List_ID, string Stock_ID, string Plan_List_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, string Goods_ID, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Code, string Goods_Class_ID, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Level, string Goods_Limit_Lower_Quantity, string Goods_Remark, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Stock_Tray_Barcode, string Stock_Full_Flag, string WareHouse_ID, string Area_Type, string Area_Code, string Area_Name, int Area_Order, string Area_Flag, string Area_BackColor, string Area_Remark, string Area_Reserve1, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag, string WareHouse_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, string Plan_ID, string Plan_Remark, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, int Goods_Shelf_Life, DateTime Goods_ProduceDate, int Goods_Order, string Goods_Type, string Area_ID, string Cell_Code, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Status, string Cell_Child_Model, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Goods_Suppier_Code)
        {

            return dal.Delete(Stock_List_ID, Stock_ID, Plan_List_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Goods_ID, Stock_List_Entry_Time, Stock_List_Update_Time, Stock_List_Remark, Goods_Code, Goods_Class_ID, Goods_Name, Goods_Desc, Goods_Model, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Level, Goods_Limit_Lower_Quantity, Goods_Remark, Goods_Flag, Goods_Danger, Goods_Category, Goods_Asset, Goods_Department, Goods_Reserve1, Goods_Reserve2, Stock_Tray_Barcode, Stock_Full_Flag, WareHouse_ID, Area_Type, Area_Code, Area_Name, Area_Order, Area_Flag, Area_BackColor, Area_Remark, Area_Reserve1, WareHouse_Code, WareHouse_Name, WareHouse_Type, WareHouse_Flag, WareHouse_Remark, Plan_Type_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_End_Time, Plan_Begin_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_List_Quantity, Plan_List_Ordered_Quantity, Plan_ID, Plan_Remark, Plan_List_Finished_Quantity, Plan_List_Status, Plan_List_Remark, Goods_Shelf_Life, Goods_ProduceDate, Goods_Order, Goods_Type, Area_ID, Cell_Code, Cell_Chlid_ID, Cell_Chlid_Position, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Status, Cell_Child_Model, Cell_Child_Run_Status, Cell_Child_Flag, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, Goods_Suppier_Code);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_Plan_StockListModel GetModel(string Stock_List_ID, string Stock_ID, string Plan_List_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, string Goods_ID, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Code, string Goods_Class_ID, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Level, string Goods_Limit_Lower_Quantity, string Goods_Remark, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Stock_Tray_Barcode, string Stock_Full_Flag, string WareHouse_ID, string Area_Type, string Area_Code, string Area_Name, int Area_Order, string Area_Flag, string Area_BackColor, string Area_Remark, string Area_Reserve1, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag, string WareHouse_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, string Plan_ID, string Plan_Remark, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, int Goods_Shelf_Life, DateTime Goods_ProduceDate, int Goods_Order, string Goods_Type, string Area_ID, string Cell_Code, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Status, string Cell_Child_Model, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Goods_Suppier_Code)
        {

            return dal.GetModel(Stock_List_ID, Stock_ID, Plan_List_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Goods_ID, Stock_List_Entry_Time, Stock_List_Update_Time, Stock_List_Remark, Goods_Code, Goods_Class_ID, Goods_Name, Goods_Desc, Goods_Model, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Level, Goods_Limit_Lower_Quantity, Goods_Remark, Goods_Flag, Goods_Danger, Goods_Category, Goods_Asset, Goods_Department, Goods_Reserve1, Goods_Reserve2, Stock_Tray_Barcode, Stock_Full_Flag, WareHouse_ID, Area_Type, Area_Code, Area_Name, Area_Order, Area_Flag, Area_BackColor, Area_Remark, Area_Reserve1, WareHouse_Code, WareHouse_Name, WareHouse_Type, WareHouse_Flag, WareHouse_Remark, Plan_Type_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_End_Time, Plan_Begin_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_List_Quantity, Plan_List_Ordered_Quantity, Plan_ID, Plan_Remark, Plan_List_Finished_Quantity, Plan_List_Status, Plan_List_Remark, Goods_Shelf_Life, Goods_ProduceDate, Goods_Order, Goods_Type, Area_ID, Cell_Code, Cell_Chlid_ID, Cell_Chlid_Position, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Status, Cell_Child_Model, Cell_Child_Run_Status, Cell_Child_Flag, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, Goods_Suppier_Code);
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
        public List<WMS_Database.View_Plan_StockListModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_Plan_StockListModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_Plan_StockListModel> modelList = new List<WMS_Database.View_Plan_StockListModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_Plan_StockListModel model;
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
        public List<View_Plan_StockListModel> GetModelListByCellID(string cellID)
        {
            string sqlStr = "Cell_Chlid_ID = '" + cellID+"'";
            List<View_Plan_StockListModel> stockListGoods = GetModelList(sqlStr);
            return stockListGoods;
        }

        public List<View_Plan_StockListModel> GetModelListByPlanID(string planID)
        {
            string sqlStr = "Plan_ID = " + planID;
            List<View_Plan_StockListModel> stockListGoods = GetModelList(sqlStr);
            return stockListGoods;
        }
       public View_Plan_StockListModel GetModelByPalletCode(string palletCode)
        {
            string sqlStr = "Stock_Tray_Barcode = '" + palletCode +"'";
            List<View_Plan_StockListModel> stockList = GetModelList(sqlStr);
           if(stockList!=null&&stockList.Count>0)
           {
               return stockList[0];
           }
           else
           {
               return null;
           }
        }
        #endregion  ExtensionMethod

    }
}

