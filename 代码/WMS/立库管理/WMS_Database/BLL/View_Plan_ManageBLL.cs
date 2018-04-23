using System;
using System.Data;
using System.Collections.Generic;
 
namespace WMS_Database
{
    /// <summary>
    /// View_Plan_Manage
    /// </summary>
    public partial class View_Plan_ManageBLL
    {
        private readonly WMS_Database.View_Plan_ManageDAL dal = new WMS_Database.View_Plan_ManageDAL();
        public View_Plan_ManageBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Mange_ID, string Manage_List_ID, string Stock_List_ID, string Manage_List_Quantity, string Manage_List_Remark, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Goods_ID, string Plan_List_ID, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Stock_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, DateTime Goods_ProduceDate, string Goods_Asset, int Goods_Shelf_Life, string Goods_Department, string Cell_ID, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Row, int Cell_Column, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Flag, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID)
        {
            return dal.Exists(Plan_ID, Mange_Type_ID, Mange_Status, Mange_Stock_Barcode, Mange_Full_Flag, Manage_BreakDown_Status, Mange_Start_Cell_ID, Mange_End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Manage_Remark, Mange_ID, Manage_List_ID, Stock_List_ID, Manage_List_Quantity, Manage_List_Remark, Plan_List_Quantity, Plan_List_Ordered_Quantity, Plan_List_Finished_Quantity, Plan_List_Status, Plan_List_Remark, Plan_Type_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_End_Time, Plan_Begin_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_Remark, Goods_ID, Plan_List_ID, Cell_Child_ID, Stock_Tray_Barcode, Stock_Full_Flag, Stock_Remark, Stock_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Stock_List_Entry_Time, Stock_List_Update_Time, Stock_List_Remark, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Suppier_Code, Goods_Model, Goods_Desc, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Order, Goods_Flag, Goods_Danger, Goods_Category, Goods_ProduceDate, Goods_Asset, Goods_Shelf_Life, Goods_Department, Cell_ID, Area_ID, Cell_Code, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Row, Cell_Column, Cell_Chlid_ID, Cell_Chlid_Position, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Model, Cell_Child_Status, Cell_Child_Flag, Cell_Child_Run_Status, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_Plan_ManageModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_Plan_ManageModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Mange_ID, string Manage_List_ID, string Stock_List_ID, string Manage_List_Quantity, string Manage_List_Remark, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Goods_ID, string Plan_List_ID, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Stock_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, DateTime Goods_ProduceDate, string Goods_Asset, int Goods_Shelf_Life, string Goods_Department, string Cell_ID, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Row, int Cell_Column, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Flag, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID)
        {

            return dal.Delete(Plan_ID, Mange_Type_ID, Mange_Status, Mange_Stock_Barcode, Mange_Full_Flag, Manage_BreakDown_Status, Mange_Start_Cell_ID, Mange_End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Manage_Remark, Mange_ID, Manage_List_ID, Stock_List_ID, Manage_List_Quantity, Manage_List_Remark, Plan_List_Quantity, Plan_List_Ordered_Quantity, Plan_List_Finished_Quantity, Plan_List_Status, Plan_List_Remark, Plan_Type_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_End_Time, Plan_Begin_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_Remark, Goods_ID, Plan_List_ID, Cell_Child_ID, Stock_Tray_Barcode, Stock_Full_Flag, Stock_Remark, Stock_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Stock_List_Entry_Time, Stock_List_Update_Time, Stock_List_Remark, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Suppier_Code, Goods_Model, Goods_Desc, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Order, Goods_Flag, Goods_Danger, Goods_Category, Goods_ProduceDate, Goods_Asset, Goods_Shelf_Life, Goods_Department, Cell_ID, Area_ID, Cell_Code, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Row, Cell_Column, Cell_Chlid_ID, Cell_Chlid_Position, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Model, Cell_Child_Status, Cell_Child_Flag, Cell_Child_Run_Status, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_Plan_ManageModel GetModel(string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Mange_ID, string Manage_List_ID, string Stock_List_ID, string Manage_List_Quantity, string Manage_List_Remark, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Goods_ID, string Plan_List_ID, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Stock_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, DateTime Goods_ProduceDate, string Goods_Asset, int Goods_Shelf_Life, string Goods_Department, string Cell_ID, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Row, int Cell_Column, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Flag, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID)
        {

            return dal.GetModel(Plan_ID, Mange_Type_ID, Mange_Status, Mange_Stock_Barcode, Mange_Full_Flag, Manage_BreakDown_Status, Mange_Start_Cell_ID, Mange_End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Manage_Remark, Mange_ID, Manage_List_ID, Stock_List_ID, Manage_List_Quantity, Manage_List_Remark, Plan_List_Quantity, Plan_List_Ordered_Quantity, Plan_List_Finished_Quantity, Plan_List_Status, Plan_List_Remark, Plan_Type_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_End_Time, Plan_Begin_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_Remark, Goods_ID, Plan_List_ID, Cell_Child_ID, Stock_Tray_Barcode, Stock_Full_Flag, Stock_Remark, Stock_ID, Stock_List_Box_Barcode, Stock_List_Quantity, Stock_List_Entry_Time, Stock_List_Update_Time, Stock_List_Remark, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Suppier_Code, Goods_Model, Goods_Desc, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Order, Goods_Flag, Goods_Danger, Goods_Category, Goods_ProduceDate, Goods_Asset, Goods_Shelf_Life, Goods_Department, Cell_ID, Area_ID, Cell_Code, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Row, Cell_Column, Cell_Chlid_ID, Cell_Chlid_Position, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Model, Cell_Child_Status, Cell_Child_Flag, Cell_Child_Run_Status, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID);
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
        public List<WMS_Database.View_Plan_ManageModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_Plan_ManageModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_Plan_ManageModel> modelList = new List<WMS_Database.View_Plan_ManageModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_Plan_ManageModel model;
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
        public List<View_Plan_ManageModel> GetModelList(string taskType, string taskStatus)
        {
            string sqlstr = " 1=1";
            if (taskType != "所有")
            {
                sqlstr += "and Mange_Status ='" + taskStatus + "' ";
            }
            if (taskStatus != "所有")
            {
                sqlstr += "  and Mange_Type_ID= '" + taskType + "'";
            }

            return GetModelList(sqlstr);
        }
        #endregion  ExtensionMethod
    }
}

