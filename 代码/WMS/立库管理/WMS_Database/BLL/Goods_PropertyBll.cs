using System;
using System.Data;
using System.Collections.Generic;
namespace WMS_Database
{
	/// <summary>
	/// Goods_Property
	/// </summary>
	public partial class Goods_PropertyBll
	{
		private readonly Goods_PropertyDal dal=new Goods_PropertyDal();
        public Goods_PropertyBll()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_Property_ID)
        {
            return dal.Exists(Goods_Property_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Goods_PropertyModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.Goods_PropertyModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Goods_Property_ID)
        {

            return dal.Delete(Goods_Property_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Goods_Property_IDlist)
        {
            return dal.DeleteList(Goods_Property_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.Goods_PropertyModel GetModel(string Goods_Property_ID)
        {

            return dal.GetModel(Goods_Property_ID);
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
        public List<WMS_Database.Goods_PropertyModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.Goods_PropertyModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.Goods_PropertyModel> modelList = new List<WMS_Database.Goods_PropertyModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.Goods_PropertyModel model;
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
        public List<Goods_PropertyModel> GetModelListByGoodsID(string goodsID)
        {
            string sqlStr = "Goods_ID = '" +goodsID+"'";
            List<Goods_PropertyModel> propertyList = GetModelList(sqlStr);
            if(propertyList!=null && propertyList.Count>0)
            {
                return propertyList;
            }
            else
            {
                return null;
            }
        }
        public Goods_PropertyModel GetModelByPropertyCode(string goods_id,string goods_Property_Code)
        {
            string sqlStr = "Goods_Property_Code = '" + goods_Property_Code + "' and Goods_ID = '" + goods_id + "'";
            List<Goods_PropertyModel> propertyList = GetModelList(sqlStr);
            if (propertyList != null && propertyList.Count > 0)
            {
                return propertyList[0];
            }
            else
            {
                return null;
            }
        }
        public bool DeleteByGoodsCode(string goodsCode)
        {
            return dal.DeleteByGoodsCode(goodsCode);
        }
		#endregion  ExtensionMethod
	}
}

