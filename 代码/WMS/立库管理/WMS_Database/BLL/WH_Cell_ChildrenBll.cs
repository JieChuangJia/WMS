using System;
using System.Data;
using System.Collections.Generic;
namespace WMS_Database
{
	/// <summary>
	/// 1
	/// </summary>
	public partial class WH_Cell_ChildrenBll
    {
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        private WH_AreaBll bllArea = new WH_AreaBll();
        private View_CellBLL bllViewCell = new View_CellBLL();
		private readonly WH_Cell_ChildrenDal dal=new WH_Cell_ChildrenDal();
        public WH_Cell_ChildrenBll()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Cell_Chlid_ID)
        {
            return dal.Exists(Cell_Chlid_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_Cell_ChildrenModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.WH_Cell_ChildrenModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Cell_Chlid_ID)
        {

            return dal.Delete(Cell_Chlid_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Cell_Chlid_IDlist)
        {
            return dal.DeleteList(Cell_Chlid_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.WH_Cell_ChildrenModel GetModel(string Cell_Chlid_ID)
        {

            return dal.GetModel(Cell_Chlid_ID);
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
        public List<WMS_Database.WH_Cell_ChildrenModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.WH_Cell_ChildrenModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.WH_Cell_ChildrenModel> modelList = new List<WMS_Database.WH_Cell_ChildrenModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.WH_Cell_ChildrenModel model;
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
        //public bool SetMultiGsSinleColEnbledStatus(string houseName, int rowth, int colth, string cellPos, bool status)
        //{


        //}
        //public bool SetMultiGsSinleLayerEnbledStatus(string houseName, int rowth, int layerth, bool status)
        //{

        //}
		#endregion  ExtensionMethod
	}
}

