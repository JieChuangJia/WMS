using System;
using System.Data;
using System.Collections.Generic;
namespace WMS_Database
{
	/// <summary>
	/// Manage
	/// </summary>
	public partial class ManageBll
	{
		private readonly ManageDal dal=new ManageDal();
        public ManageBll()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Mange_ID)
        {
            return dal.Exists(Mange_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.ManageModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.ManageModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Mange_ID)
        {
            DeleteManage(30);

            return dal.Delete(Mange_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Mange_IDlist)
        {
            return dal.DeleteList(Mange_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.ManageModel GetModel(string Mange_ID)
        {

            return dal.GetModel(Mange_ID);
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
        public List<WMS_Database.ManageModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.ManageModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.ManageModel> modelList = new List<WMS_Database.ManageModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.ManageModel model;
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
        public ManageModel GetModelByPalletCode(string palletCode)
        {
            string sqlStr = "Mange_Stock_Barcode = '" + palletCode + "' and Mange_Status!='已完成'";
            List<ManageModel> manageList = GetModelList(sqlStr);
            if(manageList!= null&&manageList.Count>0)
            {
                return manageList[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 删除指定天数的历史管理任务
        /// </summary>
        /// <param name="days"></param>
        /// <returns></returns>

        public bool DeleteManage(int days)
        {
            return dal.DeleteManage(days);
        }

		#endregion  ExtensionMethod
	}
}

