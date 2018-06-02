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
            string sqlStr = "WareHouse_Name = '" + houseName + "' and Cell_Row =" + rowth + " and Cell_Chlid_Position='" + cellPos + "' and Cell_Type ='货位'";
            List<View_CellModel> cellList = GetModelList(sqlStr); 
            return cellList;
        }
        public List<View_CellModel> GetCells(string houseName, int rowth, int colth, string cellPos)
        {
            string sqlStr = "WareHouse_Name = '" + houseName + "' and Cell_Row =" + rowth + " and Cell_Column=" + colth + " and Cell_Chlid_Position='" + cellPos + "' and Cell_Type ='货位' ";
            List<View_CellModel> cellList = GetModelList(sqlStr);
            return cellList;
        }

        public View_CellModel GetModelByWHAndCellName(string houseName, string cellName,string pos)
        {
            string sqlStr = "Cell_Name ='" + cellName + "' and WareHouse_Name = '" + houseName + "'and Cell_Chlid_Position='" + pos+"'";
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
            string sqlStr = "Cell_Name ='" + cellName + "' and WareHouse_Name = '" + houseName + "' and Cell_Child_Order =" + order + " and Cell_Type ='货位' ";
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
            string sqlStr = "WareHouse_ID = '" + houseID + "' and Cell_Name ='" + cellName + "' and Cell_Chlid_Position='" + cellPos + "' and Cell_Type ='货位'"
                + " and Cell_Child_Flag ='1' ";

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
            string sqlStr = "WareHouse_ID = '" + houseID + "' and Cell_Child_Status='空托盘'and Cell_Child_Run_Status ='完成' and Cell_Child_Flag ='1' and Cell_Type ='货位' order by Cell_Column asc,"
                + "Cell_Row asc,Cell_Layer asc ";

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
            string sqlStr = " Cell_Child_Status='空托盘'and Cell_Child_Run_Status ='完成' and Cell_Child_Flag ='1' and Cell_Type ='货位' order by Cell_Column asc,"
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
        public View_CellModel ApplyCell(string houseID)
        {
            string wereStr = "WareHouse_ID='" + houseID + "' and Cell_Child_Status ='空闲' and Cell_Child_Run_Status ='完成' and Cell_Child_Flag ='1' and Cell_Type ='货位' order by Cell_Column asc,"
                + "Cell_Row asc,Cell_Layer asc,Cell_Child_Order desc";

            List<View_CellModel> cellList = GetModelList(wereStr);
            View_CellModel applyCell = null;
            if (cellList != null && cellList.Count > 0)
            {
                foreach(View_CellModel cell in cellList)
                {

                    if (cell.Shelf_Type == "双深")
                    {
                        View_CellModel backCell = GetCell(cell.WareHouse_ID, cell.Cell_Name, "后");
                        if (backCell != null && backCell.Cell_Child_Status == "空闲" && backCell.Cell_Child_Run_Status == "完成")
                        {
                            applyCell = backCell;
                            break;
                        }
                        else  if (backCell != null && backCell.Cell_Child_Run_Status == "锁定")//双深工位后面的工位处于锁定状态，不允许操作前面的工位
                        {
                            continue;
                        }
                        else
                        {
                            applyCell = cell;
                            break;
                        }
                    }
                }

                return applyCell;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="houseID"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="layer"></param>
        /// <param name="cate">0:获取所有不重复行；1：获取当前行下的所有不重复列；2当前行列下获取不重复层；3：当前排列层下不重复位置</param>
        /// <returns></returns>
        public List<string> GetRCL(string houseID,int row,int col,int layer,int cate)
        {
            List<string> data = new List<string>();
            string sqlStr = "select distinct";
            if (0 == cate)// 获取排数量
            {
                sqlStr += " Cell_Row from View_Cell";
            }
            else if (1 == cate)// 获取列数量
            {
                sqlStr += " Cell_Column from View_Cell";
            }
            else if (2 == cate)// 获取层数量
            {
                sqlStr += " Cell_Layer from View_Cell";
            }
            else if (3 == cate)
            {
                sqlStr += " Cell_Chlid_Position from View_Cell";
            }
            else
            {
                return null;
            }
            sqlStr += " where WareHouse_ID = " + houseID + " and Cell_Child_Status='空闲' and Cell_Child_Run_Status ='完成' and Cell_Type ='货位'";
            if (0 == cate)// 获取排数量
            {
                sqlStr += "  order by Cell_Row asc";
            }
            else if (1 == cate)// 获取列数量
            {
                sqlStr += " and Cell_Row=" + row + " order by Cell_Column asc";
            }
            else if (2 == cate)// 获取层数量
            {
                sqlStr += " and Cell_Row=" + row + " and Cell_Column = " + col + " order by Cell_Layer asc";
            }
            else if (3 == cate)
            {
                sqlStr += " and Cell_Row=" + row + " and Cell_Column = " + col + " and Cell_Layer=" + layer + " order by Cell_Chlid_Position asc"; ;
            }
            else
            {
                return null;
            }

            DataSet ds = DbHelperSQL.Query(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string vaStr =ds.Tables[0].Rows[i][0].ToString();
                    data.Add(vaStr);
                }
            }
            else
            {
                return null;
            }
            //data.Sort();
            return data;
        }
       

        #endregion  ExtensionMethod
    }
}

