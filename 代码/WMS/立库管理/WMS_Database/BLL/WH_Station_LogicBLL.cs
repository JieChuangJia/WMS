using System;
using System.Data;
using System.Collections.Generic;

namespace WMS_Database
{
    /// <summary>
    /// WH_Station_Logic
    /// </summary>
    public partial class WH_Station_LogicBLL
    {
        private readonly WMS_Database.WH_Station_LogicDAL dal = new WMS_Database.WH_Station_LogicDAL();
        public WH_Station_LogicBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WH_Station_Logic)
        {
            return dal.Exists(WH_Station_Logic);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_Station_LogicModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.WH_Station_LogicModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string WH_Station_Logic)
        {

            return dal.Delete(WH_Station_Logic);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string WH_Station_Logiclist)
        {
            return dal.DeleteList(WH_Station_Logiclist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.WH_Station_LogicModel GetModel(string WH_Station_Logic)
        {

            return dal.GetModel(WH_Station_Logic);
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
        public List<WMS_Database.WH_Station_LogicModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.WH_Station_LogicModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.WH_Station_LogicModel> modelList = new List<WMS_Database.WH_Station_LogicModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.WH_Station_LogicModel model;
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
        public List<WH_Station_LogicModel> GetModelListByHouseIDAndCellType(string houseID,string stationType)
        {
            string sqlStr = "WareHouse_ID ='" + houseID + "' and WH_Station_Logic_Type='" + stationType +"'";
            List<WH_Station_LogicModel> cellList= GetModelList(sqlStr);
            return cellList;
        }
        public List<WH_Station_LogicModel> GetStationListByType(string stationType)
        {
            string sqlStr =  " WH_Station_Logic_Type='" + stationType + "'";
            List<WH_Station_LogicModel> cellList = GetModelList(sqlStr);
            return cellList;
        }
        public WH_Station_LogicModel GetStationByName(string stationName)
        {
            string sqlStr = " WH_Station_Logic_Name='" + stationName + "'";
            List<WH_Station_LogicModel> cellList = GetModelList(sqlStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }
        public WH_Station_LogicModel GetModelByHouseIDAndCellName(string houseID, string stationName)
        {
            string sqlStr = "WareHouse_ID ='" + houseID + "' and WH_Station_Logic_Name='" + stationName + "'";
            List<WH_Station_LogicModel> cellList = GetModelList(sqlStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }
        public WH_Station_LogicModel GetModelByCellID(string cellChildID)
        {
            string sqlStr = "Cell_Chlid_ID ='" + cellChildID+"'";
            List<WH_Station_LogicModel> stationList = GetModelList(sqlStr);
            if(stationList!=null&&stationList.Count>0)
            {
                return stationList[0];
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

