using System;
using System.Data;
using System.Collections.Generic;
namespace WMS_Database
{
	/// <summary>
	/// Plan
	/// </summary>
	public partial class PlanBll
	{
		private readonly PlanDal dal=new PlanDal();
		public PlanBll()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID)
        {
            return dal.Exists(Plan_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.PlanMainModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.PlanMainModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Plan_ID)
        {

            return dal.Delete(Plan_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Plan_IDlist)
        {
            return dal.DeleteList(Plan_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.PlanMainModel GetModel(string Plan_ID)
        {

            return dal.GetModel(Plan_ID);
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
        public List<WMS_Database.PlanMainModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.PlanMainModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.PlanMainModel> modelList = new List<WMS_Database.PlanMainModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.PlanMainModel model;
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
        public List<PlanMainModel> GetModelList(DateTime startDate, DateTime endDate, string planType, string planStatus, string planCode)
        {
            string sqlStr = "Plan_Create_Time >= '" + startDate + "'and Plan_Create_Time <= '" + endDate + "'";
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
        public void DeleteByPlanCode(string planCode)
        {
            PlanMainModel plan = GetModelByPlanCode(planCode);
            if(plan!=null)
            {
                Delete(plan.Plan_ID);
            }
        }
        public PlanMainModel GetModelByPlanCode(string planCode)
        {
            string sqlStr = "Plan_Code ='" + planCode+"'";
            List<PlanMainModel> planList = GetModelList(sqlStr);
            if(planList!=null&&planList.Count>0)
            {
                return planList[0];
            }
            else
            {
                return null;
            }
        }
      
        public void UpdatePlan(PlanMainModel plan)
        {
            PlanMainModel planMain = GetModelByPlanCode(plan.Plan_Code);
            if(planMain != null)
            {
                Delete(planMain.Plan_ID);
            }
            //else
            //{
            //    Update(plan);
            //}
            Add(plan);
        }
		#endregion  ExtensionMethod
	}
}

