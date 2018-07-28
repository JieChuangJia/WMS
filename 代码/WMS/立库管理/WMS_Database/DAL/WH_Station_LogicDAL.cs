using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:WH_Station_Logic
    /// </summary>
    public partial class WH_Station_LogicDAL
    {
        public WH_Station_LogicDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WH_Station_Logic)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from WH_Station_Logic");
            strSql.Append(" where WH_Station_Logic='" + WH_Station_Logic + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_Station_LogicModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.WH_Station_Logic != null)
            {
                strSql1.Append("WH_Station_Logic,");
                strSql2.Append("'" + model.WH_Station_Logic + "',");
            }
            if (model.Cell_Child_ID != null)
            {
                strSql1.Append("Cell_Child_ID,");
                strSql2.Append("'" + model.Cell_Child_ID + "',");
            }
            if (model.WareHouse_ID != null)
            {
                strSql1.Append("WareHouse_ID,");
                strSql2.Append("'" + model.WareHouse_ID + "',");
            }
            if (model.WH_Station_Logic_Type != null)
            {
                strSql1.Append("WH_Station_Logic_Type,");
                strSql2.Append("'" + model.WH_Station_Logic_Type + "',");
            }
            if (model.WH_Station_Logic_Name != null)
            {
                strSql1.Append("WH_Station_Logic_Name,");
                strSql2.Append("'" + model.WH_Station_Logic_Name + "',");
            }
            if (model.WH_Station_Logic_Desc != null)
            {
                strSql1.Append("WH_Station_Logic_Desc,");
                strSql2.Append("'" + model.WH_Station_Logic_Desc + "',");
            }
            if (model.WH_Station_Logic_Remark != null)
            {
                strSql1.Append("WH_Station_Logic_Remark,");
                strSql2.Append("'" + model.WH_Station_Logic_Remark + "',");
            }
            if (model.WH_Station_Logic_Reserve1 != null)
            {
                strSql1.Append("WH_Station_Logic_Reserve1,");
                strSql2.Append("'" + model.WH_Station_Logic_Reserve1 + "',");
            }
            if (model.WH_Station_Logic_Reserve2 != null)
            {
                strSql1.Append("WH_Station_Logic_Reserve2,");
                strSql2.Append("'" + model.WH_Station_Logic_Reserve2 + "',");
            }
            if (model.WH_Station_Logic_Reserve3 != null)
            {
                strSql1.Append("WH_Station_Logic_Reserve3,");
                strSql2.Append("'" + model.WH_Station_Logic_Reserve3 + "',");
            }
            if (model.WH_Station_Logic_Reserve4 != null)
            {
                strSql1.Append("WH_Station_Logic_Reserve4,");
                strSql2.Append("'" + model.WH_Station_Logic_Reserve4 + "',");
            }
            if (model.WH_Station_Logic_Reserve5 != null)
            {
                strSql1.Append("WH_Station_Logic_Reserve5,");
                strSql2.Append("'" + model.WH_Station_Logic_Reserve5 + "',");
            }
            strSql.Append("insert into WH_Station_Logic(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WMS_Database.WH_Station_LogicModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WH_Station_Logic set ");
            if (model.Cell_Child_ID != null)
            {
                strSql.Append("Cell_Child_ID='" + model.Cell_Child_ID + "',");
            }
            else
            {
                strSql.Append("Cell_Child_ID= null ,");
            }
            if (model.WareHouse_ID != null)
            {
                strSql.Append("WareHouse_ID='" + model.WareHouse_ID + "',");
            }
            else
            {
                strSql.Append("WareHouse_ID= null ,");
            }
            if (model.WH_Station_Logic_Type != null)
            {
                strSql.Append("WH_Station_Logic_Type='" + model.WH_Station_Logic_Type + "',");
            }
            else
            {
                strSql.Append("WH_Station_Logic_Type= null ,");
            }
            if (model.WH_Station_Logic_Name != null)
            {
                strSql.Append("WH_Station_Logic_Name='" + model.WH_Station_Logic_Name + "',");
            }
            else
            {
                strSql.Append("WH_Station_Logic_Name= null ,");
            }
            if (model.WH_Station_Logic_Desc != null)
            {
                strSql.Append("WH_Station_Logic_Desc='" + model.WH_Station_Logic_Desc + "',");
            }
            else
            {
                strSql.Append("WH_Station_Logic_Desc= null ,");
            }
            if (model.WH_Station_Logic_Remark != null)
            {
                strSql.Append("WH_Station_Logic_Remark='" + model.WH_Station_Logic_Remark + "',");
            }
            else
            {
                strSql.Append("WH_Station_Logic_Remark= null ,");
            }
            if (model.WH_Station_Logic_Reserve1 != null)
            {
                strSql.Append("WH_Station_Logic_Reserve1='" + model.WH_Station_Logic_Reserve1 + "',");
            }
            else
            {
                strSql.Append("WH_Station_Logic_Reserve1= null ,");
            }
            if (model.WH_Station_Logic_Reserve2 != null)
            {
                strSql.Append("WH_Station_Logic_Reserve2='" + model.WH_Station_Logic_Reserve2 + "',");
            }
            else
            {
                strSql.Append("WH_Station_Logic_Reserve2= null ,");
            }
            if (model.WH_Station_Logic_Reserve3 != null)
            {
                strSql.Append("WH_Station_Logic_Reserve3='" + model.WH_Station_Logic_Reserve3 + "',");
            }
            else
            {
                strSql.Append("WH_Station_Logic_Reserve3= null ,");
            }
            if (model.WH_Station_Logic_Reserve4 != null)
            {
                strSql.Append("WH_Station_Logic_Reserve4='" + model.WH_Station_Logic_Reserve4 + "',");
            }
            else
            {
                strSql.Append("WH_Station_Logic_Reserve4= null ,");
            }
            if (model.WH_Station_Logic_Reserve5 != null)
            {
                strSql.Append("WH_Station_Logic_Reserve5='" + model.WH_Station_Logic_Reserve5 + "',");
            }
            else
            {
                strSql.Append("WH_Station_Logic_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where WH_Station_Logic='" + model.WH_Station_Logic + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string WH_Station_Logic)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Station_Logic ");
            strSql.Append(" where WH_Station_Logic='" + WH_Station_Logic + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }		/// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string WH_Station_Logiclist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Station_Logic ");
            strSql.Append(" where WH_Station_Logic in (" + WH_Station_Logiclist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.WH_Station_LogicModel GetModel(string WH_Station_Logic)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" WH_Station_Logic,Cell_Child_ID,WareHouse_ID,WH_Station_Logic_Type,WH_Station_Logic_Name,WH_Station_Logic_Desc,WH_Station_Logic_Remark,WH_Station_Logic_Reserve1,WH_Station_Logic_Reserve2,WH_Station_Logic_Reserve3,WH_Station_Logic_Reserve4,WH_Station_Logic_Reserve5 ");
            strSql.Append(" from WH_Station_Logic ");
            strSql.Append(" where WH_Station_Logic='" + WH_Station_Logic + "' ");
            WMS_Database.WH_Station_LogicModel model = new WMS_Database.WH_Station_LogicModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.WH_Station_LogicModel DataRowToModel(DataRow row)
        {
            WMS_Database.WH_Station_LogicModel model = new WMS_Database.WH_Station_LogicModel();
            if (row != null)
            {
                if (row["WH_Station_Logic"] != null)
                {
                    model.WH_Station_Logic = row["WH_Station_Logic"].ToString();
                }
                if (row["Cell_Child_ID"] != null)
                {
                    model.Cell_Child_ID = row["Cell_Child_ID"].ToString();
                }
                if (row["WareHouse_ID"] != null)
                {
                    model.WareHouse_ID = row["WareHouse_ID"].ToString();
                }
                if (row["WH_Station_Logic_Type"] != null)
                {
                    model.WH_Station_Logic_Type = row["WH_Station_Logic_Type"].ToString();
                }
                if (row["WH_Station_Logic_Name"] != null)
                {
                    model.WH_Station_Logic_Name = row["WH_Station_Logic_Name"].ToString();
                }
                if (row["WH_Station_Logic_Desc"] != null)
                {
                    model.WH_Station_Logic_Desc = row["WH_Station_Logic_Desc"].ToString();
                }
                if (row["WH_Station_Logic_Remark"] != null)
                {
                    model.WH_Station_Logic_Remark = row["WH_Station_Logic_Remark"].ToString();
                }
                if (row["WH_Station_Logic_Reserve1"] != null)
                {
                    model.WH_Station_Logic_Reserve1 = row["WH_Station_Logic_Reserve1"].ToString();
                }
                if (row["WH_Station_Logic_Reserve2"] != null)
                {
                    model.WH_Station_Logic_Reserve2 = row["WH_Station_Logic_Reserve2"].ToString();
                }
                if (row["WH_Station_Logic_Reserve3"] != null)
                {
                    model.WH_Station_Logic_Reserve3 = row["WH_Station_Logic_Reserve3"].ToString();
                }
                if (row["WH_Station_Logic_Reserve4"] != null)
                {
                    model.WH_Station_Logic_Reserve4 = row["WH_Station_Logic_Reserve4"].ToString();
                }
                if (row["WH_Station_Logic_Reserve5"] != null)
                {
                    model.WH_Station_Logic_Reserve5 = row["WH_Station_Logic_Reserve5"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select WH_Station_Logic,Cell_Child_ID,WareHouse_ID,WH_Station_Logic_Type,WH_Station_Logic_Name,WH_Station_Logic_Desc,WH_Station_Logic_Remark,WH_Station_Logic_Reserve1,WH_Station_Logic_Reserve2,WH_Station_Logic_Reserve3,WH_Station_Logic_Reserve4,WH_Station_Logic_Reserve5 ");
            strSql.Append(" FROM WH_Station_Logic ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetStationCellName()
        {
            string sqlStr = "SELECT TOP 1000 [Cell_ID],[Cell_Name]FROM [WMSDB2].[dbo].[WH_Cell] where Cell_Type != '货位' and Cell_ID in (SELECT  distinct [Cell_Child_ID]FROM [WMSDB2].[dbo].[WH_Station_Logic] where WH_Station_Logic_Type='配盘工位')";
            return DbHelperSQL.Query(sqlStr);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" WH_Station_Logic,Cell_Child_ID,WareHouse_ID,WH_Station_Logic_Type,WH_Station_Logic_Name,WH_Station_Logic_Desc,WH_Station_Logic_Remark,WH_Station_Logic_Reserve1,WH_Station_Logic_Reserve2,WH_Station_Logic_Reserve3,WH_Station_Logic_Reserve4,WH_Station_Logic_Reserve5 ");
            strSql.Append(" FROM WH_Station_Logic ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM WH_Station_Logic ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.WH_Station_Logic desc");
            }
            strSql.Append(")AS Row, T.*  from WH_Station_Logic T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  Method
        #region  MethodEx
        public DataSet GetDistinctStationCate()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct WH_Station_Logic_Type ");
            strSql.Append(" FROM WH_Station_Logic ");
         
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  MethodEx
    }
}

