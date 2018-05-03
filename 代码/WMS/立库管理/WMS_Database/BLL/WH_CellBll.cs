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
            WH_CellModel cellTemp = GetCell(model.Area_ID, (int)model.Cell_Row, (int)model.Cell_Column, (int)model.Cell_Layer);
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
        public List<WH_CellModel> GetModelListByCellType(string cellType)
        {
            string sqlStr = "Cell_Type = '" + cellType + "'";
            return GetModelList(sqlStr);
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

        public bool SetMulLayerMulColGsArea(string houseAreaID, int rowth, int stCol, int edCol, int stLayer, int edLayer)
        {
            string strSql = " Cell_Row = " + rowth + " and Cell_Column >=" + stCol + " and Cell_Column<= " + edCol
                + " and Cell_Layer>= " + stLayer + " and Cell_Layer<= " + edLayer;
            List<WH_CellModel> gsList = GetModelList(strSql);
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
        public bool SetSingleLayerArea(string logicAreaName, int rowth, int layer)
        {
            WH_AreaModel area = bllArea.GetModelByName(logicAreaName);
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

      
		#endregion  ExtensionMethod
	}
}

