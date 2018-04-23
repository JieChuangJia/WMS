using System;
using System.Data;
using System.Collections.Generic;
 
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// ERP_Shelf_VG_VList
    /// </summary>
    public partial class ERP_Shelf_VG_VListBLL
    {
        private readonly Aoyou_BusinessDB.ERP_Shelf_VG_VListDAL dal = new Aoyou_BusinessDB.ERP_Shelf_VG_VListDAL();
        public ERP_Shelf_VG_VListBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_Shelf_VG_VList_ID)
        {
            return dal.Exists(ERP_Shelf_VG_VList_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Aoyou_BusinessDB.ERP_Shelf_VG_VListModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Aoyou_BusinessDB.ERP_Shelf_VG_VListModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ERP_Shelf_VG_VList_ID)
        {

            return dal.Delete(ERP_Shelf_VG_VList_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string ERP_Shelf_VG_VList_IDlist)
        {
            return dal.DeleteList(ERP_Shelf_VG_VList_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Aoyou_BusinessDB.ERP_Shelf_VG_VListModel GetModel(string ERP_Shelf_VG_VList_ID)
        {

            return dal.GetModel(ERP_Shelf_VG_VList_ID);
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
        public List<Aoyou_BusinessDB.ERP_Shelf_VG_VListModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Aoyou_BusinessDB.ERP_Shelf_VG_VListModel> DataTableToList(DataTable dt)
        {
            List<Aoyou_BusinessDB.ERP_Shelf_VG_VListModel> modelList = new List<Aoyou_BusinessDB.ERP_Shelf_VG_VListModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Aoyou_BusinessDB.ERP_Shelf_VG_VListModel model;
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
        public bool UpdateVGList(ERP_Shelf_VG_VListModel shelfVgList)
        {
            if (shelfVgList == null)
            {
                return false;
            }
            ERP_Shelf_VG_VListModel shelfVgModel = GetModelByCode(shelfVgList.ERP_Shelf_VG_VList_Code);
            if (shelfVgModel == null)
            {
                Add(shelfVgList);
            }
            else
            {
                Update(shelfVgList);
            }
            return true;
        }
        public ERP_Shelf_VG_VListModel GetModelByCode(string shelfVgListCode)
        {
            string sqlStr = "ERP_Shelf_VG_VList_Code ='" + shelfVgListCode + "'";
            List<ERP_Shelf_VG_VListModel> shelfList = GetModelList(sqlStr);
            if (shelfList != null && shelfList.Count > 0)
            {
                return shelfList[0];
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

