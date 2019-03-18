using System;
using System.Data;
using System.Collections.Generic;
  
namespace WMS_Database
{
    /// <summary>
    /// Goods_Unit
    /// </summary>
    public partial class Goods_UnitBLL
    {
        private readonly WMS_Database.Goods_UnitDAL dal = new WMS_Database.Goods_UnitDAL();
        public Goods_UnitBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_Unit_ID)
        {
            return dal.Exists(Goods_Unit_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Goods_UnitModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.Goods_UnitModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Goods_Unit_ID)
        {

            return dal.Delete(Goods_Unit_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Goods_Unit_IDlist)
        {
            return dal.DeleteList(Goods_Unit_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.Goods_UnitModel GetModel(string Goods_Unit_ID)
        {

            return dal.GetModel(Goods_Unit_ID);
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
        public List<WMS_Database.Goods_UnitModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.Goods_UnitModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.Goods_UnitModel> modelList = new List<WMS_Database.Goods_UnitModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.Goods_UnitModel model;
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
        public Goods_UnitModel GetModelByCode(string unitCode)
        {

            string sqlStr = "[Goods_Unit_Code]='" + unitCode+"'";
            List<Goods_UnitModel> unitList = GetModelList(sqlStr);
            if(unitList!= null&&unitList.Count>0)
            {
                return unitList[0];
            }
            else
            {
                return null;
            }
        }
        public bool DeleteByCode(string unitCode)
        {
            return dal.DeleteByCode(unitCode);
        }
        #endregion  ExtensionMethod
    }
}

