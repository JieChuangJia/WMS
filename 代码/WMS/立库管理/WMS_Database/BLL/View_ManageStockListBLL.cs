using System;
using System.Data;
using System.Collections.Generic;
 
namespace WMS_Database
{
    /// <summary>
    /// View_ManageStockList
    /// </summary>
    public partial class View_ManageStockListBLL
    {
        private readonly WMS_Database.View_ManageStockListDAL dal = new WMS_Database.View_ManageStockListDAL();
        public View_ManageStockListBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Mange_Type_ID, string Stock_List_ID, string Manage_List_Quantity, string Plan_List_ID, string Stock_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Manage_List_ID, string Manage_List_Remark, string Goods_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Mange_ID)
        {
            return dal.Exists(Plan_ID, Mange_Type_ID, Stock_List_ID, Manage_List_Quantity, Plan_List_ID, Stock_ID, Mange_Status, Mange_Stock_Barcode, Mange_Full_Flag, Manage_BreakDown_Status, Mange_Start_Cell_ID, Mange_End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Manage_Remark, Manage_List_ID, Manage_List_Remark, Goods_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Stock_List_Entry_Time, Stock_List_Update_Time, Stock_List_Remark, Cell_Child_ID, Stock_Tray_Barcode, Stock_Full_Flag, Stock_Remark, Mange_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_ManageStockListModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_ManageStockListModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Plan_ID, string Mange_Type_ID, string Stock_List_ID, string Manage_List_Quantity, string Plan_List_ID, string Stock_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Manage_List_ID, string Manage_List_Remark, string Goods_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Mange_ID)
        {

            return dal.Delete(Plan_ID, Mange_Type_ID, Stock_List_ID, Manage_List_Quantity, Plan_List_ID, Stock_ID, Mange_Status, Mange_Stock_Barcode, Mange_Full_Flag, Manage_BreakDown_Status, Mange_Start_Cell_ID, Mange_End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Manage_Remark, Manage_List_ID, Manage_List_Remark, Goods_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Stock_List_Entry_Time, Stock_List_Update_Time, Stock_List_Remark, Cell_Child_ID, Stock_Tray_Barcode, Stock_Full_Flag, Stock_Remark, Mange_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_ManageStockListModel GetModel(string Plan_ID, string Mange_Type_ID, string Stock_List_ID, string Manage_List_Quantity, string Plan_List_ID, string Stock_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Manage_List_ID, string Manage_List_Remark, string Goods_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Mange_ID)
        {

            return dal.GetModel(Plan_ID, Mange_Type_ID, Stock_List_ID, Manage_List_Quantity, Plan_List_ID, Stock_ID, Mange_Status, Mange_Stock_Barcode, Mange_Full_Flag, Manage_BreakDown_Status, Mange_Start_Cell_ID, Mange_End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Manage_Remark, Manage_List_ID, Manage_List_Remark, Goods_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Stock_List_Entry_Time, Stock_List_Update_Time, Stock_List_Remark, Cell_Child_ID, Stock_Tray_Barcode, Stock_Full_Flag, Stock_Remark, Mange_ID);
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
        public List<WMS_Database.View_ManageStockListModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_ManageStockListModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_ManageStockListModel> modelList = new List<WMS_Database.View_ManageStockListModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_ManageStockListModel model;
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
        public List<View_ManageStockListModel> GetModelListByManageID(string manageID)
        {
            string sqlStr = "Mange_ID ='" + manageID +"'";
            return GetModelList(sqlStr);
        }

        #endregion  ExtensionMethod
    }
}

