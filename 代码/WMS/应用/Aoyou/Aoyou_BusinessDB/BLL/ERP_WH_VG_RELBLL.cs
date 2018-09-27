using System;
using System.Data;
using System.Collections.Generic;
 
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// ERP_WH_VG_REL
    /// </summary>
    public partial class ERP_WH_VG_RELBLL
    {
        private readonly Aoyou_BusinessDB.ERP_WH_VG_RELDAL dal = new Aoyou_BusinessDB.ERP_WH_VG_RELDAL();
        public ERP_WH_VG_RELBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_WH_VG_REL_ID)
        {
            return dal.Exists(ERP_WH_VG_REL_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Aoyou_BusinessDB.ERP_WH_VG_RELModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Aoyou_BusinessDB.ERP_WH_VG_RELModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ERP_WH_VG_REL_ID)
        {

            return dal.Delete(ERP_WH_VG_REL_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string ERP_WH_VG_REL_IDlist)
        {
            return dal.DeleteList(ERP_WH_VG_REL_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Aoyou_BusinessDB.ERP_WH_VG_RELModel GetModel(string ERP_WH_VG_REL_ID)
        {

            return dal.GetModel(ERP_WH_VG_REL_ID);
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
        public List<Aoyou_BusinessDB.ERP_WH_VG_RELModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Aoyou_BusinessDB.ERP_WH_VG_RELModel> DataTableToList(DataTable dt)
        {
            List<Aoyou_BusinessDB.ERP_WH_VG_RELModel> modelList = new List<Aoyou_BusinessDB.ERP_WH_VG_RELModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Aoyou_BusinessDB.ERP_WH_VG_RELModel model;
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
        private bool DeteteByWhVgCode(string whVgCode)
        {
            return dal.DeteteByWhVgCode(whVgCode);
        }
        public bool UpdateVGRELList(ERP_WH_VG_RELModel shelfVgRELList)
        {
            if (shelfVgRELList == null)
            {
                return false;
            }
            DeteteByWhVgCode(shelfVgRELList.ERP_WH_VG_ID);

            //ERP_WH_VG_RELModel shelfVgModel = GetModelByCode(shelfVgRELList.ERP_WH_VG_ID, shelfVgRELList.ERP_Shelf_VG_VList_ID);
            //if (shelfVgModel == null)
            //{
                Add(shelfVgRELList);
            //}
            //else
            //{
            //    Update(shelfVgRELList);
            //}
            return true;
        }

        public ERP_WH_VG_RELModel GetModelByCode(string whVGID,string whVgListID)
        {
            string sqlStr = "ERP_WH_VG_ID ='" + whVGID + "' and ERP_Shelf_VG_VList_ID ='" + whVgListID+"'";
            List<ERP_WH_VG_RELModel> shelfList = GetModelList(sqlStr);
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

