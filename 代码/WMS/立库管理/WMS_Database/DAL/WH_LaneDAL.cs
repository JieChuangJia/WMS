using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:WH_Lane
    /// </summary>
    public partial class WH_LaneDAL
    {
        public WH_LaneDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WH_Lane_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from WH_Lane");
            strSql.Append(" where WH_Lane_ID='" + WH_Lane_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_LaneModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.WH_Lane_ID != null)
            {
                strSql1.Append("WH_Lane_ID,");
                strSql2.Append("'" + model.WH_Lane_ID + "',");
            }
            if (model.WH_WareHouse_ID != null)
            {
                strSql1.Append("WH_WareHouse_ID,");
                strSql2.Append("'" + model.WH_WareHouse_ID + "',");
            }
            if (model.WH_Lane_Name != null)
            {
                strSql1.Append("WH_Lane_Name,");
                strSql2.Append("'" + model.WH_Lane_Name + "',");
            }
            if (model.WH_Lane_Remark != null)
            {
                strSql1.Append("WH_Lane_Remark,");
                strSql2.Append("'" + model.WH_Lane_Remark + "',");
            }
            if (model.WH_Lane_Reserve1 != null)
            {
                strSql1.Append("WH_Lane_Reserve1,");
                strSql2.Append("'" + model.WH_Lane_Reserve1 + "',");
            }
            if (model.WH_Lane_Reserve2 != null)
            {
                strSql1.Append("WH_Lane_Reserve2,");
                strSql2.Append("'" + model.WH_Lane_Reserve2 + "',");
            }
            if (model.WH_Lane_Reserve3 != null)
            {
                strSql1.Append("WH_Lane_Reserve3,");
                strSql2.Append("'" + model.WH_Lane_Reserve3 + "',");
            }
            if (model.WH_Lane_Reserve4 != null)
            {
                strSql1.Append("WH_Lane_Reserve4,");
                strSql2.Append("'" + model.WH_Lane_Reserve4 + "',");
            }
            if (model.WH_Lane_Reserve5 != null)
            {
                strSql1.Append("WH_Lane_Reserve5,");
                strSql2.Append("'" + model.WH_Lane_Reserve5 + "',");
            }
            strSql.Append("insert into WH_Lane(");
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
        public bool Update(WMS_Database.WH_LaneModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WH_Lane set ");
            if (model.WH_WareHouse_ID != null)
            {
                strSql.Append("WH_WareHouse_ID='" + model.WH_WareHouse_ID + "',");
            }
            else
            {
                strSql.Append("WH_WareHouse_ID= null ,");
            }
            if (model.WH_Lane_Name != null)
            {
                strSql.Append("WH_Lane_Name='" + model.WH_Lane_Name + "',");
            }
            else
            {
                strSql.Append("WH_Lane_Name= null ,");
            }
            if (model.WH_Lane_Remark != null)
            {
                strSql.Append("WH_Lane_Remark='" + model.WH_Lane_Remark + "',");
            }
            else
            {
                strSql.Append("WH_Lane_Remark= null ,");
            }
            if (model.WH_Lane_Reserve1 != null)
            {
                strSql.Append("WH_Lane_Reserve1='" + model.WH_Lane_Reserve1 + "',");
            }
            else
            {
                strSql.Append("WH_Lane_Reserve1= null ,");
            }
            if (model.WH_Lane_Reserve2 != null)
            {
                strSql.Append("WH_Lane_Reserve2='" + model.WH_Lane_Reserve2 + "',");
            }
            else
            {
                strSql.Append("WH_Lane_Reserve2= null ,");
            }
            if (model.WH_Lane_Reserve3 != null)
            {
                strSql.Append("WH_Lane_Reserve3='" + model.WH_Lane_Reserve3 + "',");
            }
            else
            {
                strSql.Append("WH_Lane_Reserve3= null ,");
            }
            if (model.WH_Lane_Reserve4 != null)
            {
                strSql.Append("WH_Lane_Reserve4='" + model.WH_Lane_Reserve4 + "',");
            }
            else
            {
                strSql.Append("WH_Lane_Reserve4= null ,");
            }
            if (model.WH_Lane_Reserve5 != null)
            {
                strSql.Append("WH_Lane_Reserve5='" + model.WH_Lane_Reserve5 + "',");
            }
            else
            {
                strSql.Append("WH_Lane_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where WH_Lane_ID='" + model.WH_Lane_ID + "' ");
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
        public bool Delete(string WH_Lane_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Lane ");
            strSql.Append(" where WH_Lane_ID='" + WH_Lane_ID + "' ");
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
        public bool DeleteList(string WH_Lane_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Lane ");
            strSql.Append(" where WH_Lane_ID in (" + WH_Lane_IDlist + ")  ");
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
        public WMS_Database.WH_LaneModel GetModel(string WH_Lane_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" WH_Lane_ID,WH_WareHouse_ID,WH_Lane_Name,WH_Lane_Remark,WH_Lane_Reserve1,WH_Lane_Reserve2,WH_Lane_Reserve3,WH_Lane_Reserve4,WH_Lane_Reserve5 ");
            strSql.Append(" from WH_Lane ");
            strSql.Append(" where WH_Lane_ID='" + WH_Lane_ID + "' ");
            WMS_Database.WH_LaneModel model = new WMS_Database.WH_LaneModel();
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
        public WMS_Database.WH_LaneModel DataRowToModel(DataRow row)
        {
            WMS_Database.WH_LaneModel model = new WMS_Database.WH_LaneModel();
            if (row != null)
            {
                if (row["WH_Lane_ID"] != null)
                {
                    model.WH_Lane_ID = row["WH_Lane_ID"].ToString();
                }
                if (row["WH_WareHouse_ID"] != null)
                {
                    model.WH_WareHouse_ID = row["WH_WareHouse_ID"].ToString();
                }
                if (row["WH_Lane_Name"] != null)
                {
                    model.WH_Lane_Name = row["WH_Lane_Name"].ToString();
                }
                if (row["WH_Lane_Remark"] != null)
                {
                    model.WH_Lane_Remark = row["WH_Lane_Remark"].ToString();
                }
                if (row["WH_Lane_Reserve1"] != null)
                {
                    model.WH_Lane_Reserve1 = row["WH_Lane_Reserve1"].ToString();
                }
                if (row["WH_Lane_Reserve2"] != null)
                {
                    model.WH_Lane_Reserve2 = row["WH_Lane_Reserve2"].ToString();
                }
                if (row["WH_Lane_Reserve3"] != null)
                {
                    model.WH_Lane_Reserve3 = row["WH_Lane_Reserve3"].ToString();
                }
                if (row["WH_Lane_Reserve4"] != null)
                {
                    model.WH_Lane_Reserve4 = row["WH_Lane_Reserve4"].ToString();
                }
                if (row["WH_Lane_Reserve5"] != null)
                {
                    model.WH_Lane_Reserve5 = row["WH_Lane_Reserve5"].ToString();
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
            strSql.Append("select WH_Lane_ID,WH_WareHouse_ID,WH_Lane_Name,WH_Lane_Remark,WH_Lane_Reserve1,WH_Lane_Reserve2,WH_Lane_Reserve3,WH_Lane_Reserve4,WH_Lane_Reserve5 ");
            strSql.Append(" FROM WH_Lane ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
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
            strSql.Append(" WH_Lane_ID,WH_WareHouse_ID,WH_Lane_Name,WH_Lane_Remark,WH_Lane_Reserve1,WH_Lane_Reserve2,WH_Lane_Reserve3,WH_Lane_Reserve4,WH_Lane_Reserve5 ");
            strSql.Append(" FROM WH_Lane ");
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
            strSql.Append("select count(1) FROM WH_Lane ");
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
                strSql.Append("order by T.WH_Lane_ID desc");
            }
            strSql.Append(")AS Row, T.*  from WH_Lane T ");
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

        #endregion  MethodEx
    }
}

