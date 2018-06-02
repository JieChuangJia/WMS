using System;
using System.Data;
using System.Collections.Generic;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	public partial class Stock_ListBll
	{
		private readonly Stock_ListDal dal=new Stock_ListDal();
        public Stock_ListBll()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Stock_List_ID)
        {
            return dal.Exists(Stock_List_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Stock_ListModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.Stock_ListModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Stock_List_ID)
        {

            return dal.Delete(Stock_List_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Stock_List_IDlist)
        {
            return dal.DeleteList(Stock_List_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.Stock_ListModel GetModel(string Stock_List_ID)
        {

            return dal.GetModel(Stock_List_ID);
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
        public List<WMS_Database.Stock_ListModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.Stock_ListModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.Stock_ListModel> modelList = new List<WMS_Database.Stock_ListModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.Stock_ListModel model;
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
        public Stock_ListModel GetModelByPalletCode(string palletCode)
        {
            string sqlstr = "Stock_List_Box_Barcode ='" + palletCode +"'";
            List<Stock_ListModel> stockList = GetModelList(sqlstr);
            if(stockList!= null&& stockList.Count>0)
            {
                return stockList[0];
            }
            else
            {
                return null;
            }
        }
        public bool DeleteByStockID(string stockID)
        {
            return dal.DeleteByStockID(stockID);
        }

        public List<Stock_ListModel> GetListByStockID(string StockID)
        {
            string sqlStr = "Stock_ID = '" + StockID + "'";
            return GetModelList(sqlStr);

        }
		#endregion  ExtensionMethod
	}
}

