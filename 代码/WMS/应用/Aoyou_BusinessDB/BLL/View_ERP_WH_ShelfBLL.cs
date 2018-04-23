using System;
using System.Data;
using System.Collections.Generic;
 
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// View_ERP_WH_Shelf
    /// </summary>
    public partial class View_ERP_WH_ShelfBLL
    {
        private readonly Aoyou_BusinessDB.View_ERP_WH_ShelfDAL dal = new Aoyou_BusinessDB.View_ERP_WH_ShelfDAL();
        public View_ERP_WH_ShelfBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_Shelf_VG_Code, string ERP_Shelf_VG_Name, string ERP_Shelf_VG_VList_Code, string ERP_Shelf_VG_VList_Name, string ERP_WH_CreateGroup, string ERP_WH_UseGroup, string ERP_WH_Name, string ERP_WH_Code, string ERP_WH_Property, string ERP_WH_VG_ID, string ERP_Shelf_VG_VList_ID, string ERP_WH_VG_REL_Value, string ERP_WH_ID, string ERP_WH_VG_Name, string ERP_WH_VG_Code, string Expr2, string ERP_Shelf_VG_ID, string ERP_WH_Enabled, string ERP_WH_Default_Status)
        {
            return dal.Exists(ERP_Shelf_VG_Code, ERP_Shelf_VG_Name, ERP_Shelf_VG_VList_Code, ERP_Shelf_VG_VList_Name, ERP_WH_CreateGroup, ERP_WH_UseGroup, ERP_WH_Name, ERP_WH_Code, ERP_WH_Property, ERP_WH_VG_ID, ERP_Shelf_VG_VList_ID, ERP_WH_VG_REL_Value, ERP_WH_ID, ERP_WH_VG_Name, ERP_WH_VG_Code, Expr2, ERP_Shelf_VG_ID, ERP_WH_Enabled, ERP_WH_Default_Status);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Aoyou_BusinessDB.View_ERP_WH_ShelfModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Aoyou_BusinessDB.View_ERP_WH_ShelfModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ERP_Shelf_VG_Code, string ERP_Shelf_VG_Name, string ERP_Shelf_VG_VList_Code, string ERP_Shelf_VG_VList_Name, string ERP_WH_CreateGroup, string ERP_WH_UseGroup, string ERP_WH_Name, string ERP_WH_Code, string ERP_WH_Property, string ERP_WH_VG_ID, string ERP_Shelf_VG_VList_ID, string ERP_WH_VG_REL_Value, string ERP_WH_ID, string ERP_WH_VG_Name, string ERP_WH_VG_Code, string Expr2, string ERP_Shelf_VG_ID, string ERP_WH_Enabled, string ERP_WH_Default_Status)
        {

            return dal.Delete(ERP_Shelf_VG_Code, ERP_Shelf_VG_Name, ERP_Shelf_VG_VList_Code, ERP_Shelf_VG_VList_Name, ERP_WH_CreateGroup, ERP_WH_UseGroup, ERP_WH_Name, ERP_WH_Code, ERP_WH_Property, ERP_WH_VG_ID, ERP_Shelf_VG_VList_ID, ERP_WH_VG_REL_Value, ERP_WH_ID, ERP_WH_VG_Name, ERP_WH_VG_Code, Expr2, ERP_Shelf_VG_ID, ERP_WH_Enabled, ERP_WH_Default_Status);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Aoyou_BusinessDB.View_ERP_WH_ShelfModel GetModel(string ERP_Shelf_VG_Code, string ERP_Shelf_VG_Name, string ERP_Shelf_VG_VList_Code, string ERP_Shelf_VG_VList_Name, string ERP_WH_CreateGroup, string ERP_WH_UseGroup, string ERP_WH_Name, string ERP_WH_Code, string ERP_WH_Property, string ERP_WH_VG_ID, string ERP_Shelf_VG_VList_ID, string ERP_WH_VG_REL_Value, string ERP_WH_ID, string ERP_WH_VG_Name, string ERP_WH_VG_Code, string Expr2, string ERP_Shelf_VG_ID, string ERP_WH_Enabled, string ERP_WH_Default_Status)
        {

            return dal.GetModel(ERP_Shelf_VG_Code, ERP_Shelf_VG_Name, ERP_Shelf_VG_VList_Code, ERP_Shelf_VG_VList_Name, ERP_WH_CreateGroup, ERP_WH_UseGroup, ERP_WH_Name, ERP_WH_Code, ERP_WH_Property, ERP_WH_VG_ID, ERP_Shelf_VG_VList_ID, ERP_WH_VG_REL_Value, ERP_WH_ID, ERP_WH_VG_Name, ERP_WH_VG_Code, Expr2, ERP_Shelf_VG_ID, ERP_WH_Enabled, ERP_WH_Default_Status);
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
        public List<Aoyou_BusinessDB.View_ERP_WH_ShelfModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Aoyou_BusinessDB.View_ERP_WH_ShelfModel> DataTableToList(DataTable dt)
        {
            List<Aoyou_BusinessDB.View_ERP_WH_ShelfModel> modelList = new List<Aoyou_BusinessDB.View_ERP_WH_ShelfModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Aoyou_BusinessDB.View_ERP_WH_ShelfModel model;
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

        #endregion  ExtensionMethod
    }
}

