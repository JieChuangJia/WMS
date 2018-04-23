using System;
using System.Data;
using System.Collections.Generic;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	public partial class Plan_TypeBll
	{
        private readonly Plan_TypeDal dal = new Plan_TypeDal();
        public Plan_TypeBll()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_Type_ID)
        {
            return dal.Exists(Plan_Type_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Plan_TypeModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.Plan_TypeModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Plan_Type_ID)
        {

            return dal.Delete(Plan_Type_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Plan_Type_IDlist)
        {
            return dal.DeleteList(Plan_Type_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.Plan_TypeModel GetModel(string Plan_Type_ID)
        {

            return dal.GetModel(Plan_Type_ID);
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
        public List<WMS_Database.Plan_TypeModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.Plan_TypeModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.Plan_TypeModel> modelList = new List<WMS_Database.Plan_TypeModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.Plan_TypeModel model;
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
        public Plan_TypeModel GetModelByName(string planName)
        {
            string sqlStr = "Plan_Type_Name ='" + planName + "'";
            List<Plan_TypeModel> planTypeList = GetModelList(sqlStr);
            if(planTypeList!= null&&planTypeList.Count>0)
            {
                return planTypeList[0];
            }
            else
            {
                return null;
            }
        }

        public Plan_TypeModel GetModelByCode(string planCode)
        {
            string sqlStr = "Plan_Type_Code ='" + planCode + "'";
            List<Plan_TypeModel> planTypeList = GetModelList(sqlStr);
            if (planTypeList != null && planTypeList.Count > 0)
            {
                return planTypeList[0];
            }
            else
            {
                return null;
            }
        }

		#endregion  ExtensionMethod
	}
}

