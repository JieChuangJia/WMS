using System;
using System.Data;
using System.Collections.Generic;
namespace WMS_Database
{
	/// <summary>
	/// Goods
	/// </summary>
	public partial class GoodsBll
	{
		private readonly GoodsDal dal=new GoodsDal();
        public GoodsBll()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_ID)
        {
            return dal.Exists(Goods_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.GoodsModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.GoodsModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Goods_ID)
        {

            return dal.Delete(Goods_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Goods_IDlist)
        {
            return dal.DeleteList(Goods_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.GoodsModel GetModel(string Goods_ID)
        {

            return dal.GetModel(Goods_ID);
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
        public List<WMS_Database.GoodsModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.GoodsModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.GoodsModel> modelList = new List<WMS_Database.GoodsModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.GoodsModel model;
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
        public GoodsModel GetModelByCode(string goodsCode)
        {
            string sqlStr = "Goods_Code = '" + goodsCode +"'";
            List<GoodsModel> goodsList = GetModelList(sqlStr);
            if(goodsList != null&& goodsList.Count>0)
            {
                return goodsList[0];
            }
            else
            {
                return null;
            }
        }
        public GoodsModel GetModelByReserve1(string goodsInnerCode)
        {
            string sqlStr = "Goods_Reserve1 = '" + goodsInnerCode + "'";
            List<GoodsModel> goodsList = GetModelList(sqlStr);
            if (goodsList != null && goodsList.Count > 0)
            {
                return goodsList[0];
            }
            else
            {
                return null;
            }
        }
        public bool DeleteByCode(string goodsCode)
        {
            return dal.DeleteByCode(goodsCode);
        }
		#endregion  ExtensionMethod
	}
}

