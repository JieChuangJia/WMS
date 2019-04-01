using System;
using System.Data;
using System.Collections.Generic;
 
namespace WMS_Database
{
    /// <summary>
    /// View_Manage_Cell
    /// </summary>
    public partial class View_Manage_CellBLL
    {
        private readonly WMS_Database.View_Manage_CellDAL dal = new WMS_Database.View_Manage_CellDAL();
        public View_Manage_CellBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Mange_ID, string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Mange_Start_Cell_ID, string Manage_BreakDown_Status, string Manage_Operater, string Mange_End_Cell_ID, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Cell_Chlid_Position, string Cell_Child_InOut, int Cell_Child_Order, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_InOut, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Remark, string Manage_Type_Group, string Cell_Code, string Area_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Reserve1, string Cell_Chlid_ID, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Reserve1, DateTime Mange_CreateTime)
        {
            return dal.Exists(Mange_ID, Plan_ID, Mange_Type_ID, Mange_Status, Mange_Stock_Barcode, Mange_Full_Flag, Mange_Start_Cell_ID, Manage_BreakDown_Status, Manage_Operater, Mange_End_Cell_ID, Manage_Begin_Time, Manage_End_Time, Manage_Remark, Cell_Chlid_Position, Cell_Child_InOut, Cell_Child_Order, Manage_Type_Code, Manage_Type_Name, Manage_Type_InOut, Manage_Type_Order, Manage_Type_Flag, Manage_Type_Remark, Manage_Type_Group, Cell_Code, Area_ID, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, Cell_Reserve1, Cell_Chlid_ID, Cell_Child_Model, Cell_Child_Status, Cell_Child_Run_Status, Cell_Child_Flag, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Cell_Child_Reserve1, Mange_CreateTime);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_Manage_CellModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_Manage_CellModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Mange_ID, string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Mange_Start_Cell_ID, string Manage_BreakDown_Status, string Manage_Operater, string Mange_End_Cell_ID, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Cell_Chlid_Position, string Cell_Child_InOut, int Cell_Child_Order, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_InOut, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Remark, string Manage_Type_Group, string Cell_Code, string Area_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Reserve1, string Cell_Chlid_ID, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Reserve1, DateTime Mange_CreateTime)
        {

            return dal.Delete(Mange_ID, Plan_ID, Mange_Type_ID, Mange_Status, Mange_Stock_Barcode, Mange_Full_Flag, Mange_Start_Cell_ID, Manage_BreakDown_Status, Manage_Operater, Mange_End_Cell_ID, Manage_Begin_Time, Manage_End_Time, Manage_Remark, Cell_Chlid_Position, Cell_Child_InOut, Cell_Child_Order, Manage_Type_Code, Manage_Type_Name, Manage_Type_InOut, Manage_Type_Order, Manage_Type_Flag, Manage_Type_Remark, Manage_Type_Group, Cell_Code, Area_ID, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, Cell_Reserve1, Cell_Chlid_ID, Cell_Child_Model, Cell_Child_Status, Cell_Child_Run_Status, Cell_Child_Flag, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Cell_Child_Reserve1, Mange_CreateTime);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_Manage_CellModel GetModel(string Mange_ID, string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Mange_Start_Cell_ID, string Manage_BreakDown_Status, string Manage_Operater, string Mange_End_Cell_ID, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Cell_Chlid_Position, string Cell_Child_InOut, int Cell_Child_Order, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_InOut, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Remark, string Manage_Type_Group, string Cell_Code, string Area_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Reserve1, string Cell_Chlid_ID, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Reserve1, DateTime Mange_CreateTime)
        {

            return dal.GetModel(Mange_ID, Plan_ID, Mange_Type_ID, Mange_Status, Mange_Stock_Barcode, Mange_Full_Flag, Mange_Start_Cell_ID, Manage_BreakDown_Status, Manage_Operater, Mange_End_Cell_ID, Manage_Begin_Time, Manage_End_Time, Manage_Remark, Cell_Chlid_Position, Cell_Child_InOut, Cell_Child_Order, Manage_Type_Code, Manage_Type_Name, Manage_Type_InOut, Manage_Type_Order, Manage_Type_Flag, Manage_Type_Remark, Manage_Type_Group, Cell_Code, Area_ID, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, Cell_Reserve1, Cell_Chlid_ID, Cell_Child_Model, Cell_Child_Status, Cell_Child_Run_Status, Cell_Child_Flag, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Cell_Child_Reserve1, Mange_CreateTime);
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
        public List<WMS_Database.View_Manage_CellModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_Manage_CellModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_Manage_CellModel> modelList = new List<WMS_Database.View_Manage_CellModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_Manage_CellModel model;
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
        public List<View_Manage_CellModel> GetWattingTaskByDeviceCode(string deviceCode)
        {
            string sqlStr = "Device_Code ='" + deviceCode + "' and Mange_Status='待执行' order by Mange_CreateTime asc";
            List<View_Manage_CellModel> manageList = GetModelList(sqlStr);
            return manageList;
        }
        public List<View_Manage_CellModel> GetListByPlanID(string planID)
        {
            string sqlStr = "[Plan_ID] ='" + planID + "'";
            List<View_Manage_CellModel> manageList = GetModelList(sqlStr);
            return manageList;
        }
        #endregion  ExtensionMethod
    }
}

