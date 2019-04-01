using System;
using System.Data;
using System.Collections.Generic;
 
namespace JBS_APPDB
{
    /// <summary>
    /// ERP_Plan_Report
    /// </summary>
    public partial class ERP_Plan_ReportBLL
    {
        private readonly JBS_APPDB.ERP_Plan_ReportDAL dal = new JBS_APPDB.ERP_Plan_ReportDAL();
        public ERP_Plan_ReportBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_Plan_Report_ID)
        {
            return dal.Exists(ERP_Plan_Report_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(JBS_APPDB.ERP_Plan_ReportModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(JBS_APPDB.ERP_Plan_ReportModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ERP_Plan_Report_ID)
        {

            return dal.Delete(ERP_Plan_Report_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string ERP_Plan_Report_IDlist)
        {
            return dal.DeleteList(ERP_Plan_Report_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public JBS_APPDB.ERP_Plan_ReportModel GetModel(string ERP_Plan_Report_ID)
        {

            return dal.GetModel(ERP_Plan_Report_ID);
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
        public List<JBS_APPDB.ERP_Plan_ReportModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<JBS_APPDB.ERP_Plan_ReportModel> DataTableToList(DataTable dt)
        {
            List<JBS_APPDB.ERP_Plan_ReportModel> modelList = new List<JBS_APPDB.ERP_Plan_ReportModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                JBS_APPDB.ERP_Plan_ReportModel model;
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
        public List<ERP_Plan_ReportModel> GetUnReportModelList()
        {
            string sqlStr = "[ERP_Plan_IsReported]=0";
            return GetModelList(sqlStr);
        }
        public ERP_Plan_ReportModel GetModelByPlanCode(string planCode)
        {
            string sqlStr = "[ERP_Plan_Code]='" +planCode+"'";
            List<ERP_Plan_ReportModel> planList = GetModelList(sqlStr);
            if(planList!=null&&planList.Count>0)
            {
                return planList[0];
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

