using System;
using System.Data;
using System.Collections.Generic;
 
namespace WMS_Database
{
    /// <summary>
    /// WH_Cell_Operate_Record
    /// </summary>
    public partial class WH_Cell_Operate_RecordBLL
    {
        private readonly WMS_Database.WH_Cell_Operate_RecordDAL dal = new WMS_Database.WH_Cell_Operate_RecordDAL();
        public WH_Cell_Operate_RecordBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WH_Cell_Oper_RecID)
        {
            return dal.Exists(WH_Cell_Oper_RecID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_Cell_Operate_RecordModel model)
        {
            dal.DeleteOperate(30);
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.WH_Cell_Operate_RecordModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string WH_Cell_Oper_RecID)
        {

            return dal.Delete(WH_Cell_Oper_RecID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string WH_Cell_Oper_RecIDlist)
        {
            return dal.DeleteList(WH_Cell_Oper_RecIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.WH_Cell_Operate_RecordModel GetModel(string WH_Cell_Oper_RecID)
        {

            return dal.GetModel(WH_Cell_Oper_RecID);
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
        public List<WMS_Database.WH_Cell_Operate_RecordModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.WH_Cell_Operate_RecordModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.WH_Cell_Operate_RecordModel> modelList = new List<WMS_Database.WH_Cell_Operate_RecordModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.WH_Cell_Operate_RecordModel model;
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
        public DataTable GetOperate(DateTime stDt, DateTime edDt, string operateType, bool likeQueryChecked, string likeQueryValue,string houseName,bool gsChecked,string gsName)
     
        {
            return dal.GetOperate(stDt, edDt, operateType, likeQueryChecked, likeQueryValue,houseName,gsChecked,gsName);
        }
        #endregion  ExtensionMethod
    }
}

