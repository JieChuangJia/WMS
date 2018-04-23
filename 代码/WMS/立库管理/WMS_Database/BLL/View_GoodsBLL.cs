using System;
using System.Data;
using System.Collections.Generic;
 
 
namespace WMS_Database
{
    /// <summary>
    /// View_Goods
    /// </summary>
    public partial class View_GoodsBLL
    {
        private readonly WMS_Database.View_GoodsDAL dal = new WMS_Database.View_GoodsDAL();
        public View_GoodsBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_Class_ID, string Goods_ID, string Goods_Code, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, string Goods_Remark, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Goods_Reserve3, string Goods_Reserve4, string Goods_Reserve5, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Reserve1, string Goods_Class_Flag, string Goods_Class_Reserve2, string Goods_Class_Reserve4, string Goods_Class_Reserve3, string Goods_Class_Reserve5, string Goods_Type, string Goods_Suppier_Code)
        {
            return dal.Exists(Goods_Class_ID, Goods_ID, Goods_Code, Goods_Name, Goods_Desc, Goods_Model, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Remark, Goods_Order, Goods_Flag, Goods_Danger, Goods_Category, Goods_Asset, Goods_Department, Goods_Reserve1, Goods_Reserve2, Goods_Reserve3, Goods_Reserve4, Goods_Reserve5, Goods_Class_Parent_ID, Goods_Class_Code, Goods_Class_Name, Goods_Class_Remark, Goods_Class_Order, Goods_Class_Reserve1, Goods_Class_Flag, Goods_Class_Reserve2, Goods_Class_Reserve4, Goods_Class_Reserve3, Goods_Class_Reserve5, Goods_Type, Goods_Suppier_Code);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_GoodsModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_GoodsModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Goods_Class_ID, string Goods_ID, string Goods_Code, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, string Goods_Remark, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Goods_Reserve3, string Goods_Reserve4, string Goods_Reserve5, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Reserve1, string Goods_Class_Flag, string Goods_Class_Reserve2, string Goods_Class_Reserve4, string Goods_Class_Reserve3, string Goods_Class_Reserve5, string Goods_Type, string Goods_Suppier_Code)
        {

            return dal.Delete(Goods_Class_ID, Goods_ID, Goods_Code, Goods_Name, Goods_Desc, Goods_Model, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Remark, Goods_Order, Goods_Flag, Goods_Danger, Goods_Category, Goods_Asset, Goods_Department, Goods_Reserve1, Goods_Reserve2, Goods_Reserve3, Goods_Reserve4, Goods_Reserve5, Goods_Class_Parent_ID, Goods_Class_Code, Goods_Class_Name, Goods_Class_Remark, Goods_Class_Order, Goods_Class_Reserve1, Goods_Class_Flag, Goods_Class_Reserve2, Goods_Class_Reserve4, Goods_Class_Reserve3, Goods_Class_Reserve5, Goods_Type, Goods_Suppier_Code);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_GoodsModel GetModel(string Goods_Class_ID, string Goods_ID, string Goods_Code, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, string Goods_Remark, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Goods_Reserve3, string Goods_Reserve4, string Goods_Reserve5, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Reserve1, string Goods_Class_Flag, string Goods_Class_Reserve2, string Goods_Class_Reserve4, string Goods_Class_Reserve3, string Goods_Class_Reserve5, string Goods_Type, string Goods_Suppier_Code)
        {

            return dal.GetModel(Goods_Class_ID, Goods_ID, Goods_Code, Goods_Name, Goods_Desc, Goods_Model, Goods_Level, Goods_Unit, Goods_Limit_Upper_Quantity, Goods_Limit_Lower_Quantity, Goods_Remark, Goods_Order, Goods_Flag, Goods_Danger, Goods_Category, Goods_Asset, Goods_Department, Goods_Reserve1, Goods_Reserve2, Goods_Reserve3, Goods_Reserve4, Goods_Reserve5, Goods_Class_Parent_ID, Goods_Class_Code, Goods_Class_Name, Goods_Class_Remark, Goods_Class_Order, Goods_Class_Reserve1, Goods_Class_Flag, Goods_Class_Reserve2, Goods_Class_Reserve4, Goods_Class_Reserve3, Goods_Class_Reserve5, Goods_Type, Goods_Suppier_Code);
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
        public List<WMS_Database.View_GoodsModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_GoodsModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_GoodsModel> modelList = new List<WMS_Database.View_GoodsModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_GoodsModel model;
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
        public List<View_GoodsModel> GetModelByGoosInfo(string goodsInfor)
        {
            if(goodsInfor.Trim() == "")
            {
                return GetModelList("");
            }
            string sqlStr = "Goods_Code like '%" + goodsInfor + "%' or Goods_Name like '%" + goodsInfor + "%'";
            List<View_GoodsModel> goodsList = GetModelList(sqlStr);
            if (goodsList != null && goodsList.Count != 0)
            {
                return goodsList;
            }
            else
            {
                return null;
            }
          
        }
        public View_GoodsModel GetModelByGoodsCode(string goodsCode)
        {
            string sqlStr = "Goods_Code  ='" + goodsCode + "'";
            List<View_GoodsModel> goodsList = GetModelList(sqlStr);
            if (goodsList != null && goodsList.Count != 0)
            {
                return goodsList[0];
            }
            else
            {
                return null;
            }
        }
      
        #endregion  ExtensionMethod
    }
}

