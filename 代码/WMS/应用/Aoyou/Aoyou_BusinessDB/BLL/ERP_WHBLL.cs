using System;
using System.Data;
using System.Collections.Generic;
  
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// ERP_WH
    /// </summary>
    public partial class ERP_WHBLL
    {
        private readonly Aoyou_BusinessDB.ERP_WHDAL dal = new Aoyou_BusinessDB.ERP_WHDAL();
        public ERP_WHBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_WH_ID)
        {
            return dal.Exists(ERP_WH_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Aoyou_BusinessDB.ERP_WHModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Aoyou_BusinessDB.ERP_WHModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ERP_WH_ID)
        {

            return dal.Delete(ERP_WH_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string ERP_WH_IDlist)
        {
            return dal.DeleteList(ERP_WH_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Aoyou_BusinessDB.ERP_WHModel GetModel(string ERP_WH_ID)
        {

            return dal.GetModel(ERP_WH_ID);
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
        public List<Aoyou_BusinessDB.ERP_WHModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Aoyou_BusinessDB.ERP_WHModel> DataTableToList(DataTable dt)
        {
            List<Aoyou_BusinessDB.ERP_WHModel> modelList = new List<Aoyou_BusinessDB.ERP_WHModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Aoyou_BusinessDB.ERP_WHModel model;
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
        public bool UpdateWH(ERP_WHModel wh)
        {
            if(wh==null)
            {
                return false;
            }
            ERP_WHModel whModel = GetModelByWHCode(wh.ERP_WH_Code);
            if(whModel == null)
            {
                Add(wh);
            }
            else
            {
                Update(wh);
            }
            return true;
        }
        public ERP_WHModel GetModelByWHCode(string houseCode)
        {
            string sqlStr = "ERP_WH_Code ='" + houseCode +"'";
            List<ERP_WHModel> houseList = GetModelList(sqlStr);
            if(houseList!=null&&houseList.Count>0)
            {
                return houseList[0];
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

