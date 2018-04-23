using System;
using System.Data;
using System.Collections.Generic;
 
namespace WMS_Database
{
    /// <summary>
    /// View_PlanMain
    /// </summary>
    public partial class View_PlanMainBLL
    {
        private readonly WMS_Database.View_PlanMainDAL dal = new WMS_Database.View_PlanMainDAL();
        public View_PlanMainBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_Type_ID, string Plan_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_Begin_Time, DateTime Plan_End_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Plan_Type_Code, string Plan_Type_Name, string Plan_Type_Group, string Plan_Type_Remark, string Plan_Type_InOut, int Plan_Type_Order, string Plan_Type_Flag)
        {
            return dal.Exists(Plan_Type_ID, Plan_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_Begin_Time, Plan_End_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_Remark, Plan_Type_Code, Plan_Type_Name, Plan_Type_Group, Plan_Type_Remark, Plan_Type_InOut, Plan_Type_Order, Plan_Type_Flag);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_PlanMainModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_PlanMainModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Plan_Type_ID, string Plan_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_Begin_Time, DateTime Plan_End_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Plan_Type_Code, string Plan_Type_Name, string Plan_Type_Group, string Plan_Type_Remark, string Plan_Type_InOut, int Plan_Type_Order, string Plan_Type_Flag)
        {

            return dal.Delete(Plan_Type_ID, Plan_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_Begin_Time, Plan_End_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_Remark, Plan_Type_Code, Plan_Type_Name, Plan_Type_Group, Plan_Type_Remark, Plan_Type_InOut, Plan_Type_Order, Plan_Type_Flag);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_PlanMainModel GetModel(string Plan_Type_ID, string Plan_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_Begin_Time, DateTime Plan_End_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Plan_Type_Code, string Plan_Type_Name, string Plan_Type_Group, string Plan_Type_Remark, string Plan_Type_InOut, int Plan_Type_Order, string Plan_Type_Flag)
        {

            return dal.GetModel(Plan_Type_ID, Plan_ID, Plan_Serial_Num, Plan_Code, Plan_Create_Time, Plan_Begin_Time, Plan_End_Time, Plan_Bill_Time, Plan_Status, Plan_Operater, Plan_From_Dept, Plan_To_Dept, Plan_From_User, Plan_To_User, Plan_Import_Flag, Plan_Remark, Plan_Type_Code, Plan_Type_Name, Plan_Type_Group, Plan_Type_Remark, Plan_Type_InOut, Plan_Type_Order, Plan_Type_Flag);
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
        public List<WMS_Database.View_PlanMainModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_PlanMainModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_PlanMainModel> modelList = new List<WMS_Database.View_PlanMainModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_PlanMainModel model;
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
        public List<View_PlanMainModel> GetModelList(DateTime startDate, DateTime endDate, string planType, string planStatus, string planCode)
        {
            string sqlStr = "Plan_Create_Time >= '" + startDate.ToString("yyyy-MM-dd 0:00:00") + "'and Plan_Create_Time <= '" + endDate.ToString("yyyy-MM-dd 23:59:59") + "'";
            if (planType != "所有")
            {
                sqlStr += " and Plan_Type_Name ='" + planType + "'";
            }
            if (planStatus != "所有")
            {
                sqlStr += " and Plan_Status='" + planStatus + "'";
            }
            if (planCode.Trim() != "")
            {
                sqlStr += " and Plan_Code='" + planCode + "'";
            }

            return GetModelList(sqlStr);
        }
        public List<View_PlanMainModel> GetTodoListPlan(DateTime startDate, DateTime endDate, string planType, string planCode)
        {
            string sqlStr = "Plan_Create_Time >= '" + startDate.ToString("yyyy-MM-dd 0:00:00") + "'and Plan_Create_Time <= '" + endDate.ToString("yyyy-MM-dd 23:59:59") + "' and Plan_Status !='完成'";
            if (planType != "所有")
            {
                sqlStr += " and Plan_Type_Name ='" + planType + "'";
            }
        
            if (planCode.Trim() != "")
            {
                sqlStr += " and Plan_Code='" + planCode + "'";
            }

            return GetModelList(sqlStr);
        }

        public List<View_PlanMainModel> GetPlanListByStatus(string planType, string planStatus)
        {
            string sqlStr = "Plan_Status ='" + planStatus + "' and Plan_Type_InOut='" + planType + "'";
            List<View_PlanMainModel> planList = GetModelList(sqlStr);
            return planList;
        }
		
        #endregion  ExtensionMethod
    }
}

