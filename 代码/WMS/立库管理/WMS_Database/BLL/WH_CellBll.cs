using System;
using System.Data;
using System.Collections.Generic;
namespace WMS_Database
{
	/// <summary>
	/// 1
	/// </summary>
	public partial class WH_CellBll
	{
        private readonly WH_CellDal dal = new WH_CellDal();
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        private WH_AreaBll bllArea = new WH_AreaBll();
        public WH_CellBll()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Cell_ID)
        {
            return dal.Exists(Cell_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_CellModel model)
        {
            //WH_CellModel cellTemp = GetCell(model.Area_ID, (int)model.Cell_Row, (int)model.Cell_Column, (int)model.Cell_Layer);
            WH_CellModel cellTemp = GetModel(model.Cell_ID);
            if(cellTemp==null)
            {  return dal.Add(model);
              
            }
            else
            {
                return dal.Update(model);
            }
          
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.WH_CellModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Cell_ID)
        {

            return dal.Delete(Cell_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Cell_IDlist)
        {
            return dal.DeleteList(Cell_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.WH_CellModel GetModel(string Cell_ID)
        {

            return dal.GetModel(Cell_ID);
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
        public List<WMS_Database.WH_CellModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WMS_Database.WH_CellModel> DataTableToList(DataTable dt)
        {
            List<WMS_Database.WH_CellModel> modelList = new List<WMS_Database.WH_CellModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                WMS_Database.WH_CellModel model;
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
        public List<WH_CellModel> GetStationList()
        {
            string sqlStr = "Cell_Type != '货位'";
            return GetModelList(sqlStr);
        }
        public WH_CellModel GetStationByName(string stationName)
        {
            string sqlStr = "Cell_Name = '" + stationName + "' and  Cell_Type!='货位'";
            List<WH_CellModel> cellList = GetModelList(sqlStr);
            if (cellList != null && cellList.Count > 0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }
        public WH_CellModel GetCell(string areaID,int rowth,int colth,int layer)
        {
            string sqlStr = "Area_ID = '" + areaID + "' and Cell_Row =" + rowth + " and Cell_Column="+colth + " and Cell_Layer=" + layer;
            List<WH_CellModel> cellList = GetModelList(sqlStr);
            if(cellList!=null&&cellList.Count>0)
            {
                return cellList[0];
            }
            else
            {
                return null;
            }
        }
        public bool DeleteCells(string houseName, int rowth, int colth, int layerth)
        {
            WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
            if (wareHouse == null)
            {
                return false;
            }
            List<WH_AreaModel> areas = bllArea.GetModels(wareHouse.WareHouse_ID);
            if (areas == null)
            {
                return false;
            }
            for (int i = 0; i < areas.Count; i++)
            {
                dal.DeleteByAreaAndRCL(areas[i].Area_ID,rowth,colth,layerth);
            }

            return true;
        }
        public bool DeleteAreaCells(string houseName)
        {
            WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
            if (wareHouse == null)
            {
                return false;
            }
            List<WH_AreaModel> areas = bllArea.GetModels(wareHouse.WareHouse_ID);
            if (areas == null)
            {
                return false;
            }
            for (int i = 0; i < areas.Count; i++)
            {
                dal.DeleteByArea(areas[i].Area_ID);
            }
            return true;
        }
        public bool DeleteColCells(string houseName, int rowth, int colth)
        {
            WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
            if (wareHouse == null)
            {
                return false;
            }
            List<WH_AreaModel> areas = bllArea.GetModels(wareHouse.WareHouse_ID);
            if (areas == null)
            {
                return false;
            }
            for (int i = 0; i < areas.Count; i++)
            {
                dal.DeleteByAreaAndRC(areas[i].Area_ID, rowth, colth);
            }

            return true;
        }
        public bool DeleteLayerCells(string houseName, int rowth, int layerth)
        {
            WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
            if (wareHouse == null)
            {
                return false;
            }
            List<WH_AreaModel> areas = bllArea.GetModels(wareHouse.WareHouse_ID);
            if (areas == null)
            {
                return false;
            }
            for (int i = 0; i < areas.Count; i++)
            {
                dal.DeleteByAreaAndRL(areas[i].Area_ID, rowth, layerth);
            }

            return true;
        }
        public bool DeleteUnnecessaryGs(string houseName, int totalRow, int totalCol, int toalLayer)
        {
            WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
            if (wareHouse == null)
            {
                return false;
            }
            List<WH_AreaModel> areas = bllArea.GetModels(wareHouse.WareHouse_ID);
            if (areas == null)
            {
                return false;
            }
            for (int i = 0; i < areas.Count; i++)
            {
                dal.DeleteUnnecessaryGs(areas[i].Area_ID, totalRow, totalCol, toalLayer);
            }

            return true;
        }

        public bool SetMulLayerMulColGsArea(string houseName,string houseAreaID, int rowth, int stCol, int edCol, int stLayer, int edLayer)
        {
            //string strSql = " Cell_Row = " + rowth + " and Cell_Column >=" + stCol + " and Cell_Column<= " + edCol
            //    + " and Cell_Layer>= " + stLayer + " and Cell_Layer<= " + edLayer;
              WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
            if (wareHouse == null)
            {
                return false;
            }
            DataSet ds = dal.GetAreaData(wareHouse.WareHouse_ID, rowth, stCol, edCol, stLayer, edLayer);

            List<WH_CellModel> gsList = DataTableToList(ds.Tables[0]);
            if (gsList == null)
            {
                return false;
            }
            for (int i = 0; i < gsList.Count; i++)
            {
                gsList[i].Area_ID = houseAreaID;
                Update(gsList[i]);
            }
            return true;
        }
        public bool SetSingleLayerArea(string houseID,string logicAreaName, int rowth, int layer)
        {
            WH_AreaModel area = bllArea.GetModelByName(houseID,logicAreaName);
            if(area == null)
            {
                return false;
            }

            string strSql = "Area_ID ='" + area.Area_ID + "'and Cell_Row = " + rowth + " and Cell_Layer =" + layer;
            List<WH_CellModel> gsList = GetModelList(strSql);
            if (gsList == null)
            {
                return false;
            }
            for (int i = 0; i < gsList.Count; i++)
            {
                gsList[i].Area_ID = area.Area_ID;
                Update(gsList[i]);
            }
            return true;
        }

        public bool SetCellEnabledByCol(string houseName, bool enabled,int rowth, int startCol,int endCol)
        {  
            
            WH_WareHouseModel house =  bllWareHouse.GetModelByName(houseName);
            if (house == null)
            {
                return false;
            }
            return dal.SetCellEnabledByCol(house.WareHouse_ID, enabled, rowth, startCol, endCol);
        }
        public bool SetSingleLayerCellEnabled(string houseName, bool enabled,int rowth, int layer,string cellPos)
        {

            WH_WareHouseModel house = bllWareHouse.GetModelByName(houseName);
            if (house == null)
            {
                return false;
            }
            return dal.SetSingleLayerCellEnabled(house.WareHouse_ID, enabled, rowth,layer,cellPos);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cate">0：查询排数量；1：查询列数量；2：查询层数量</param>
        /// <returns></returns>
        public List<int> GetGsRCLData(string houseID, int cate)
        {
            List<int> data = new List<int>();
            string sqlStr = "select distinct ";
            if (0 == cate)// 获取排数量
            {

                sqlStr += " WH_Cell.Cell_Row from WH_Cell";
            }
            else if (1 == cate)// 获取列数量
            {
                sqlStr += " WH_Cell.Cell_Column from WH_Cell";
            }
            else if (2 == cate)// 获取层数量
            {
                sqlStr += " WH_Cell.Cell_Layer from WH_Cell";
            }
            else
            {
                return null;
            }
            sqlStr += " where Device_Code='" + houseID + "'";
            //sqlStr += " where WH_Cell.Area_ID in (select WH_Area.Area_ID from WH_Area where WH_Area.WareHouse_ID='" + houseID + "') and WH_Cell.Cell_Row !=0"
            //    + " and WH_Cell.Cell_Column !=0 and  WH_Cell.Cell_Layer !=0";
            DataSet ds = DbHelperSQL.Query(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int rowth = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                    data.Add(rowth);
                }
            }
            else
            {
                return null;
            }
            data.Sort();
            return data;
        }

        public List<string> GetRowListByDeviceCode(string device_Code)
        {
            List<string> data = new List<string>();
            string sqlStr = "select distinct";

            sqlStr += " Cell_Row from WH_Cell";

            sqlStr += " where Device_Code = '" + device_Code + "' and Cell_Type ='货位'";
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
        public List<string> GetColListByHouseRow(string device_Code,string row)
        {
            List<string> data = new List<string>();
            string sqlStr = "select distinct";

            sqlStr += " Cell_Column from WH_Cell";

            sqlStr += " where Device_Code = '" + device_Code + "' and Cell_Type ='货位'";

            if (row != "所有")
            {
                  sqlStr +=" and Cell_Row =" + row;
            }
            DataSet ds = DbHelperSQL.Query(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string item = ds.Tables[0].Rows[i][0].ToString();
                    if (item == "")
                    {
                        continue;
                    }
                    data.Add(item);
                }
                return data;
            }
            else
            {
                return null;
            }
        }

        public List<string> GetLayerListByHouseRowCol(string device_Code, string row,string col)
        {
            List<string> data = new List<string>();
            string sqlStr = "select distinct";

            sqlStr += " Cell_Layer from WH_Cell";
            sqlStr += " where Device_Code = '" + device_Code + "' and Cell_Type ='货位'";

            if (row != "所有")
            {
                sqlStr += " and Cell_Row =" + row;
            }
            if(col!= "所有")
            {
                sqlStr += " and Cell_Column=" + col;
            }

          
            DataSet ds = DbHelperSQL.Query(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string item = ds.Tables[0].Rows[i][0].ToString();
                    if (item == "")
                    {
                        continue;
                    }
                    data.Add(item);
                }
                return data;
            }
            else
            {
                return null;
            }
        }

        public List<string> GetCellPositionType(string deviceCode, int rowth)
        {
            return dal.GetCellPositionType(deviceCode, rowth);
        }

        public bool UpdateCellArea(string oldAreaID,string newAreaID)
        {
            return dal.UpdateCellArea(oldAreaID, newAreaID);
        }

		#endregion  ExtensionMethod
	}
}

