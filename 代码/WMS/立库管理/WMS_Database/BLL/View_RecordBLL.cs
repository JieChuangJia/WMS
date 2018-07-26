using System;
using System.Data;
using System.Collections.Generic;
 
namespace WMS_Database
{
    /// <summary>
    /// View_Record
    /// </summary>
    public partial class View_RecordBLL
    {
        private readonly WMS_Database.View_RecordDAL dal = new WMS_Database.View_RecordDAL();
        public View_RecordBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Manage_Type_Code, string Stock_Tray_Barcode, string Start_Cell_ID, string End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Record_Remark, string Record_ID, string Plan_List_ID, string Goods_ID, string Record_Box_Barcode, string Record_List_Quantity, string Record_List_Remark, string Record_List_Reserve1, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Batch, string Goods_Model, string Goods_Suppier_Code, string Goods_Desc, string Goods_Level, string Record_List_ID, string Record_OperateType)
        {
            return dal.Exists(Plan_ID, Manage_Type_Code, Stock_Tray_Barcode, Start_Cell_ID, End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Record_Remark, Record_ID, Plan_List_ID, Goods_ID, Record_Box_Barcode, Record_List_Quantity, Record_List_Remark, Record_List_Reserve1, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Batch, Goods_Model, Goods_Suppier_Code, Goods_Desc, Goods_Level, Record_List_ID, Record_OperateType);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_RecordModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_RecordModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Plan_ID, string Manage_Type_Code, string Stock_Tray_Barcode, string Start_Cell_ID, string End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Record_Remark, string Record_ID, string Plan_List_ID, string Goods_ID, string Record_Box_Barcode, string Record_List_Quantity, string Record_List_Remark, string Record_List_Reserve1, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Batch, string Goods_Model, string Goods_Suppier_Code, string Goods_Desc, string Goods_Level, string Record_List_ID, string Record_OperateType)
        {

            return dal.Delete(Plan_ID, Manage_Type_Code, Stock_Tray_Barcode, Start_Cell_ID, End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Record_Remark, Record_ID, Plan_List_ID, Goods_ID, Record_Box_Barcode, Record_List_Quantity, Record_List_Remark, Record_List_Reserve1, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Batch, Goods_Model, Goods_Suppier_Code, Goods_Desc, Goods_Level, Record_List_ID, Record_OperateType);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_RecordModel GetModel(string Plan_ID, string Manage_Type_Code, string Stock_Tray_Barcode, string Start_Cell_ID, string End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Record_Remark, string Record_ID, string Plan_List_ID, string Goods_ID, string Record_Box_Barcode, string Record_List_Quantity, string Record_List_Remark, string Record_List_Reserve1, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Batch, string Goods_Model, string Goods_Suppier_Code, string Goods_Desc, string Goods_Level, string Record_List_ID, string Record_OperateType)
        {

            return dal.GetModel(Plan_ID, Manage_Type_Code, Stock_Tray_Barcode, Start_Cell_ID, End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Record_Remark, Record_ID, Plan_List_ID, Goods_ID, Record_Box_Barcode, Record_List_Quantity, Record_List_Remark, Record_List_Reserve1, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Batch, Goods_Model, Goods_Suppier_Code, Goods_Desc, Goods_Level, Record_List_ID, Record_OperateType);
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
        public List<WMS_Database.View_RecordModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_RecordModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_RecordModel> modelList = new List<WMS_Database.View_RecordModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_RecordModel model;
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

        #endregion  ExtensionMethod
    }
}

