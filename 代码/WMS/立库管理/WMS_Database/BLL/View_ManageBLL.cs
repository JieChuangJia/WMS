using System;
using System.Data;
using System.Collections.Generic;
 
namespace WMS_Database
{
    /// <summary>
    /// View_Manage
    /// </summary>
    public partial class View_ManageBLL
    {
        private readonly WMS_Database.View_ManageDAL dal = new WMS_Database.View_ManageDAL();
        public View_ManageBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Mange_Type_ID, string Mange_Stock_Barcode, string Mange_Status, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_Group, string Manage_Type_Remark, string Manage_Type_InOut, string Mange_ID, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Reserve1, string Manage_Type_Reserve2, string Manage_Remark, string Mange_Reserve1, DateTime Mange_CreateTime)
        {
            return dal.Exists(Plan_ID, Mange_Type_ID, Mange_Stock_Barcode, Mange_Status, Mange_Full_Flag, Manage_BreakDown_Status, Mange_Start_Cell_ID, Mange_End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Manage_Type_Code, Manage_Type_Name, Manage_Type_Group, Manage_Type_Remark, Manage_Type_InOut, Mange_ID, Manage_Type_Order, Manage_Type_Flag, Manage_Type_Reserve1, Manage_Type_Reserve2, Manage_Remark, Mange_Reserve1, Mange_CreateTime);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_ManageModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_ManageModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Plan_ID, string Mange_Type_ID, string Mange_Stock_Barcode, string Mange_Status, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_Group, string Manage_Type_Remark, string Manage_Type_InOut, string Mange_ID, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Reserve1, string Manage_Type_Reserve2, string Manage_Remark, string Mange_Reserve1, DateTime Mange_CreateTime)
        {

            return dal.Delete(Plan_ID, Mange_Type_ID, Mange_Stock_Barcode, Mange_Status, Mange_Full_Flag, Manage_BreakDown_Status, Mange_Start_Cell_ID, Mange_End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Manage_Type_Code, Manage_Type_Name, Manage_Type_Group, Manage_Type_Remark, Manage_Type_InOut, Mange_ID, Manage_Type_Order, Manage_Type_Flag, Manage_Type_Reserve1, Manage_Type_Reserve2, Manage_Remark, Mange_Reserve1, Mange_CreateTime);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_ManageModel GetModel(string Plan_ID, string Mange_Type_ID, string Mange_Stock_Barcode, string Mange_Status, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_Group, string Manage_Type_Remark, string Manage_Type_InOut, string Mange_ID, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Reserve1, string Manage_Type_Reserve2, string Manage_Remark, string Mange_Reserve1, DateTime Mange_CreateTime)
        {

            return dal.GetModel(Plan_ID, Mange_Type_ID, Mange_Stock_Barcode, Mange_Status, Mange_Full_Flag, Manage_BreakDown_Status, Mange_Start_Cell_ID, Mange_End_Cell_ID, Manage_Operater, Manage_Begin_Time, Manage_End_Time, Manage_Type_Code, Manage_Type_Name, Manage_Type_Group, Manage_Type_Remark, Manage_Type_InOut, Mange_ID, Manage_Type_Order, Manage_Type_Flag, Manage_Type_Reserve1, Manage_Type_Reserve2, Manage_Remark, Mange_Reserve1, Mange_CreateTime);
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
        public List<WMS_Database.View_ManageModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_ManageModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_ManageModel> modelList = new List<WMS_Database.View_ManageModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_ManageModel model;
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
        public List<View_ManageModel> GetModelList(DateTime dtStart, DateTime dtEnd, string taskType, string taskStatus)
        {
            string startTime = dtStart.ToString("yyyy-MM-dd 0:00:00");
            string endTime = dtEnd.ToString("yyyy-MM-dd 23:59:59");
            string sqlstr = " 1=1 and Mange_CreateTime >='" + startTime + "' and Mange_CreateTime<='" + endTime + "'";
            if (taskStatus != "所有")
            {
                sqlstr += "and Mange_Status ='" + taskStatus + "' ";
            }
            if (taskType != "所有")
            {
                sqlstr += "  and Manage_Type_Name = '" + taskType + "'";
            }
            sqlstr += "   order by Mange_CreateTime desc";
            return GetModelList(sqlstr);
        }

        public List<View_ManageModel> GetWattingTask()
        {
            string sqlStr = "Mange_Status='待执行'";
            List<View_ManageModel> manageList = GetModelList(sqlStr);
            return manageList;
        }
        #endregion  ExtensionMethod
    }
}

