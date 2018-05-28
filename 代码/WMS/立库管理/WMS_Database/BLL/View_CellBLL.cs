using System;
using System.Data;
using System.Collections.Generic;
 
using WMS_Database;
namespace WMS_Database
{
    /// <summary>
    /// View_Cell
    /// </summary>
    public partial class View_CellBLL
    {
        private readonly WMS_Database.View_CellDAL dal = new WMS_Database.View_CellDAL();
        WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        public View_CellBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WareHouse_Code, string WareHouse_Name, string WareHouse_Flag, string WareHouse_Type, string WareHouse_Remark, string WareHouse_ID, string Area_Type, string Area_Name, string Area_Code, int Area_Order, string Area_Flag, string Area_BackColor, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Chlid_ID, string Cell_Chlid_Position, string Cell_ID, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Flag)
        {
            return dal.Exists(WareHouse_Code, WareHouse_Name, WareHouse_Flag, WareHouse_Type, WareHouse_Remark, WareHouse_ID, Area_Type, Area_Name, Area_Code, Area_Order, Area_Flag, Area_BackColor, Area_ID, Cell_Code, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, Cell_Chlid_ID, Cell_Chlid_Position, Cell_ID, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Model, Cell_Child_Status, Cell_Child_Run_Status, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Cell_Child_Flag);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_CellModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.View_CellModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string WareHouse_Code, string WareHouse_Name, string WareHouse_Flag, string WareHouse_Type, string WareHouse_Remark, string WareHouse_ID, string Area_Type, string Area_Name, string Area_Code, int Area_Order, string Area_Flag, string Area_BackColor, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Chlid_ID, string Cell_Chlid_Position, string Cell_ID, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Flag)
        {

            return dal.Delete(WareHouse_Code, WareHouse_Name, WareHouse_Flag, WareHouse_Type, WareHouse_Remark, WareHouse_ID, Area_Type, Area_Name, Area_Code, Area_Order, Area_Flag, Area_BackColor, Area_ID, Cell_Code, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, Cell_Chlid_ID, Cell_Chlid_Position, Cell_ID, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Model, Cell_Child_Status, Cell_Child_Run_Status, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Cell_Child_Flag);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_CellModel GetModel(string WareHouse_Code, string WareHouse_Name, string WareHouse_Flag, string WareHouse_Type, string WareHouse_Remark, string WareHouse_ID, string Area_Type, string Area_Name, string Area_Code, int Area_Order, string Area_Flag, string Area_BackColor, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Chlid_ID, string Cell_Chlid_Position, string Cell_ID, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Flag)
        {

            return dal.GetModel(WareHouse_Code, WareHouse_Name, WareHouse_Flag, WareHouse_Type, WareHouse_Remark, WareHouse_ID, Area_Type, Area_Name, Area_Code, Area_Order, Area_Flag, Area_BackColor, Area_ID, Cell_Code, Cell_Name, Cell_Lane, Device_Code, Shelf_Type, Cell_InOut, Cell_Type, Cell_Storage_Type, Cell_Fork_Type, Cell_Layer, Cell_Column, Cell_Row, Cell_Chlid_ID, Cell_Chlid_Position, Cell_ID, Cell_Child_Order, Cell_Child_InOut, Cell_Child_Model, Cell_Child_Status, Cell_Child_Run_Status, Cell_Child_Operate_Type, Cell_Child_TaskLock_ID, Cell_Child_Flag);
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
        public List<WMS_Database.View_CellModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.View_CellModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.View_CellModel> modelList = new List<WMS_Database.View_CellModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.View_CellModel model;
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
        public List<string> GetRowListByHouseName(string houseName)
        {
            List<string> data = new List<string>();
            string sqlStr = "select distinct";

            sqlStr += " Cell_Row from View_Cell";

            sqlStr += " where WareHouse_Name = '" + houseName + "' and Cell_Type ='货位'";
            DataSet ds = DbHelperSQL.Query(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string row = ds.Tables[0].Rows[i][0].ToString();
                    if (row == "")
                    {
                        continue;
                    }
                    data.Add(row);
                }
                return data;
            }
            else
            {
                return null;
            }
        }

        public List<View_CellModel> GetHouseRowCells(string houseName, string rowth,string cellPos)
        {
            string sqlStr = "WareHouse_Name = '" + houseName + "' and Cell_Row =" + rowth + " and Cell_Chlid_Position='" + cellPos + "' ";
            List<View_CellModel> cellList = GetModelList(sqlStr); 
            return cellList;
        }
        public List<View_CellModel> GetCells(string houseName, int rowth, int colth, string cellPos)
        {
            string sqlStr = "WareHouse_Name = '" + houseName + "' and Cell_Row =" + rowth + " and Cell_Column="+colth+" and Cell_Chlid_Position='" + cellPos + "' ";
            List<View_CellModel> cellList = GetModelList(sqlStr);
            return cellList;
        }

        public View_CellModel GetModelByWHAndCellName(string houseName, string cellName)
        {
            string sqlStr = "Cell_Name ='" + cellName + "' and WareHouse_Name = '" + houseName + "'";
            List<View_CellModel> cellList = GetModelList(sqlStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }
        public View_CellModel GetModelByWHAndCellName(string houseName, string cellName,int order)
        {
            string sqlStr = "Cell_Name ='" + cellName + "' and WareHouse_Name = '" + houseName + "' and Cell_Child_Order =" + order;
            List<View_CellModel> cellList = GetModelList(sqlStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }

        public List<View_CellModel> GetPutawayCellList(string houseName)
        {
            WH_WareHouseModel cell = bllWareHouse.GetModelByName(houseName);
            if (cell == null)
            {
                return null;
            }
            string cellListStr = "WareHouse_ID = '" + cell.WareHouse_ID + "' and Cell_Type = '货位'";
            return GetModelList(cellListStr);
        }

        public List<View_CellModel> GetPalletStation()
        {

            string cellListStr = " Cell_Type = '配盘工位'";
            return GetModelList(cellListStr);
        }
        public View_CellModel GetStationCell(string putawayStationName)
        {
            string sqlTypeStr = "Cell_Name = '" + putawayStationName + "'";
            List<View_CellModel> cellList = GetModelList(sqlTypeStr);
            if (cellList == null || cellList.Count == 0)
            {
                return null;
            }
            return cellList[0];
        }

        public View_CellModel GetCell(string houseID, string cellName, string cellPos)
        {
            string sqlStr = "WareHouse_ID = '" + houseID + "' and Cell_Name ='" + cellName + "' and Cell_Chlid_Position='" + cellPos + "'";

            List<View_CellModel> cellList = GetModelList(sqlStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }
        public View_CellModel GetEmptyPalletCell(string houseID)
        {
            string sqlStr = "WareHouse_ID = '" + houseID + "' and Cell_Child_Status='空托盘'and Cell_Child_Run_Status ='完成' and Cell_Child_Flag ='1' order by Cell_Column asc,"
                + "Cell_Row asc,Cell_Layer asc";

            List<View_CellModel> cellList = GetModelList(sqlStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }

        public View_CellModel GetEmptyPalletCell()
        {
            string sqlStr = " Cell_Child_Status='空托盘'and Cell_Child_Run_Status ='完成' and Cell_Child_Flag ='1' order by Cell_Column asc,"
                + "Cell_Row asc,Cell_Layer asc";

            List<View_CellModel> cellList = GetModelList(sqlStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }
        public List<string> GetCellPositionType(string houseName, int rowth)
        {
            return dal.GetCellPositionType(houseName, rowth);
        }
        public View_CellModel GetCell(string houseID)
        {
            string wereStr = "WareHouse_ID='" + houseID + "' and Cell_Child_Status ='空闲' and Cell_Child_Run_Status ='完成' and Cell_Child_Flag ='1' order by Cell_Column asc,"
                + "Cell_Row asc,Cell_Layer asc,Cell_Child_Order desc";

            List<View_CellModel> cellList = GetModelList(wereStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }
        public View_CellModel GetModelByChildCellID(string cellChildID)
        {
            string wereStr = "Cell_Chlid_ID='" + cellChildID + "'";

            List<View_CellModel> cellList = GetModelList(wereStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }

    
       

        #endregion  ExtensionMethod
    }
}

