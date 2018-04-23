using System;
using System.Data;
using System.Collections.Generic;
 
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// ERP_Shelf_VG
    /// </summary>
    public partial class ERP_Shelf_VGBLL
    {
        private readonly Aoyou_BusinessDB.ERP_Shelf_VGDAL dal = new Aoyou_BusinessDB.ERP_Shelf_VGDAL();
        public ERP_Shelf_VGBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_Shelf_VG_ID)
        {
            return dal.Exists(ERP_Shelf_VG_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Aoyou_BusinessDB.ERP_Shelf_VGModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Aoyou_BusinessDB.ERP_Shelf_VGModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ERP_Shelf_VG_ID)
        {

            return dal.Delete(ERP_Shelf_VG_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string ERP_Shelf_VG_IDlist)
        {
            return dal.DeleteList(ERP_Shelf_VG_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Aoyou_BusinessDB.ERP_Shelf_VGModel GetModel(string ERP_Shelf_VG_ID)
        {

            return dal.GetModel(ERP_Shelf_VG_ID);
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
        public List<Aoyou_BusinessDB.ERP_Shelf_VGModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Aoyou_BusinessDB.ERP_Shelf_VGModel> DataTableToList(DataTable dt)
        {
            List<Aoyou_BusinessDB.ERP_Shelf_VGModel> modelList = new List<Aoyou_BusinessDB.ERP_Shelf_VGModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Aoyou_BusinessDB.ERP_Shelf_VGModel model;
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
        public bool UpdateVG(ERP_Shelf_VGModel shelfVg)
        {
            if(shelfVg == null)
            {
                return false;
            }
            //ERP_Shelf_VGModel shelfVgModel = GetModelByCode(shelfVg.ERP_Shelf_VG_Code);
            Delete(shelfVg.ERP_Shelf_VG_ID);
            Add(shelfVg);

            //if (shelfVgModel == null)
            //{
            //    Add(shelfVg);
            //}
            //else
            //{
               
            //    Update(shelfVg);
            //}
            return true;
        }
        public ERP_Shelf_VGModel GetModelByCode(string shelfCode)
        {
            string sqlStr = "ERP_Shelf_VG_Code ='" + shelfCode + "'";
            List<ERP_Shelf_VGModel> shelfList = GetModelList(sqlStr);
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

