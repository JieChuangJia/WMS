using System;
using System.Data;
using System.Collections.Generic;

namespace WMS_Database
{
    /// <summary>
    /// View_PlanList
    /// </summary>
    public partial class View_PlanListBLL
    {
        private readonly WMS_Database.View_PlanListDAL dal = new WMS_Database.View_PlanListDAL();
        public View_PlanListBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Remark, string Goods_Department, int Goods_Shelf_Life, string Goods_Asset, DateTime Goods_ProduceDate, string Goods_Danger, string Goods_Category, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Flag, string Goods_Class_Reserve1, string Goods_Class_Reserve2, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Goods_ID, string Plan_List_Status, string Plan_List_Remark, string Plan_List_Resever1, string Plan_List_Resever2, string Plan_List_ID, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_Begin_Time, DateTime Plan_End_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Plan_Type_Code, string Plan_Type_Name, string Plan_Type_Group, string Plan_Type_InOut, int Plan_Type_Order, string Plan_Type_Remark, string Plan_Type_Flag, string Goods_Batch)
        {
            return dal.Exists(Plan_ID, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Suppier_Code, Goods_Model, Goods_Desc, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Order, Goods_Flag, Goods_Remark, Goods_Department, Goods_Shelf_Life, Goods_Asset, Goods_ProduceDate, Goods_Danger, Goods_Category, Goods_Class_Parent_ID, Goods_Class_Code, Goods_Class_Name, Goods_Class_Remark, Goods_Class_Order, Goods_Class_Flag, Goods_Class_Reserve1, Goods_Class_Reserve2, Plan_List_Quantity, Plan_List_Ordered_Quantity, Plan_List_Finished_Quantity, Goods_ID, Plan_List_Status, Plan_List_Remark, Plan_List_Resever1, Plan_List_Resever2, Plan_List_ID, Plan_Type_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_Begin_Time, Plan_End_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_Remark, Plan_Type_Code, Plan_Type_Name, Plan_Type_Group, Plan_Type_InOut, Plan_Type_Order, Plan_Type_Remark, Plan_Type_Flag, Goods_Batch);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_PlanListModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_PlanListModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Plan_ID, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Remark, string Goods_Department, int Goods_Shelf_Life, string Goods_Asset, DateTime Goods_ProduceDate, string Goods_Danger, string Goods_Category, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Flag, string Goods_Class_Reserve1, string Goods_Class_Reserve2, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Goods_ID, string Plan_List_Status, string Plan_List_Remark, string Plan_List_Resever1, string Plan_List_Resever2, string Plan_List_ID, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_Begin_Time, DateTime Plan_End_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Plan_Type_Code, string Plan_Type_Name, string Plan_Type_Group, string Plan_Type_InOut, int Plan_Type_Order, string Plan_Type_Remark, string Plan_Type_Flag, string Goods_Batch)
        {

            return dal.Delete(Plan_ID, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Suppier_Code, Goods_Model, Goods_Desc, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Order, Goods_Flag, Goods_Remark, Goods_Department, Goods_Shelf_Life, Goods_Asset, Goods_ProduceDate, Goods_Danger, Goods_Category, Goods_Class_Parent_ID, Goods_Class_Code, Goods_Class_Name, Goods_Class_Remark, Goods_Class_Order, Goods_Class_Flag, Goods_Class_Reserve1, Goods_Class_Reserve2, Plan_List_Quantity, Plan_List_Ordered_Quantity, Plan_List_Finished_Quantity, Goods_ID, Plan_List_Status, Plan_List_Remark, Plan_List_Resever1, Plan_List_Resever2, Plan_List_ID, Plan_Type_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_Begin_Time, Plan_End_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_Remark, Plan_Type_Code, Plan_Type_Name, Plan_Type_Group, Plan_Type_InOut, Plan_Type_Order, Plan_Type_Remark, Plan_Type_Flag, Goods_Batch);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_PlanListModel GetModel(string Plan_ID, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Remark, string Goods_Department, int Goods_Shelf_Life, string Goods_Asset, DateTime Goods_ProduceDate, string Goods_Danger, string Goods_Category, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Flag, string Goods_Class_Reserve1, string Goods_Class_Reserve2, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Goods_ID, string Plan_List_Status, string Plan_List_Remark, string Plan_List_Resever1, string Plan_List_Resever2, string Plan_List_ID, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_Begin_Time, DateTime Plan_End_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Plan_Type_Code, string Plan_Type_Name, string Plan_Type_Group, string Plan_Type_InOut, int Plan_Type_Order, string Plan_Type_Remark, string Plan_Type_Flag, string Goods_Batch)
        {

            return dal.GetModel(Plan_ID, Goods_Class_ID, Goods_Code, Goods_Name, Goods_Type, Goods_Suppier_Code, Goods_Model, Goods_Desc, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Order, Goods_Flag, Goods_Remark, Goods_Department, Goods_Shelf_Life, Goods_Asset, Goods_ProduceDate, Goods_Danger, Goods_Category, Goods_Class_Parent_ID, Goods_Class_Code, Goods_Class_Name, Goods_Class_Remark, Goods_Class_Order, Goods_Class_Flag, Goods_Class_Reserve1, Goods_Class_Reserve2, Plan_List_Quantity, Plan_List_Ordered_Quantity, Plan_List_Finished_Quantity, Goods_ID, Plan_List_Status, Plan_List_Remark, Plan_List_Resever1, Plan_List_Resever2, Plan_List_ID, Plan_Type_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_Begin_Time, Plan_End_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_Remark, Plan_Type_Code, Plan_Type_Name, Plan_Type_Group, Plan_Type_InOut, Plan_Type_Order, Plan_Type_Remark, Plan_Type_Flag, Goods_Batch);
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
        public List<WMS_Database.View_PlanListModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_PlanListModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_PlanListModel> modelList = new List<WMS_Database.View_PlanListModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_PlanListModel model;
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
        public List<View_PlanListModel> GetModelByPlanID(string planID)
        {
            string sqlStr = "Plan_ID = '" + planID + "'";
            List<View_PlanListModel> planList = GetModelList(sqlStr);
            return planList;
        }
        public List<View_PlanListModel> GetModelByPlanCode(string planCode)
        {
            string sqlStr = "Plan_Code = '" + planCode + "'";
            List<View_PlanListModel> planList = GetModelList(sqlStr);
            return planList;
        }
        public List<View_PlanListModel> GetModelList(string planType, string planStatus)
        {
            string sqlStr = "Plan_Status = '" + planStatus + "' and Plan_Type_InOut = '" + planType + "'";
            return GetModelList(sqlStr);
        }
        public View_PlanListModel GetModelByPlanListID(string planListID)
        {
            string sqlStr = "Plan_List_ID = '" + planListID + "'";
            List<View_PlanListModel> planList = GetModelList(sqlStr);
            if (planList != null && planList.Count > 0)
            {
                return planList[0];
            }
            else
            {
                return null;
            }
        }

        public List<View_PlanListModel> GetModelListByPlanAndGoodsID(string planID,string goodsID)
        {
            string sqlStr = "Plan_ID ='" + planID + "' and Goods_ID='" +goodsID+"'";
            return GetModelList(sqlStr);
        }
        #endregion  ExtensionMethod
    }
}

