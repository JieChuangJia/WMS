using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:WH_Cell_Operate_Record
    /// </summary>
    public partial class WH_Cell_Operate_RecordDAL
    {
        public WH_Cell_Operate_RecordDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WH_Cell_Oper_RecID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from WH_Cell_Operate_Record");
            strSql.Append(" where WH_Cell_Oper_RecID='" + WH_Cell_Oper_RecID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_Cell_Operate_RecordModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.WH_Cell_Oper_RecID != null)
            {
                strSql1.Append("WH_Cell_Oper_RecID,");
                strSql2.Append("'" + model.WH_Cell_Oper_RecID + "',");
            }
            if (model.WareHouse_ID != null)
            {
                strSql1.Append("WareHouse_ID,");
                strSql2.Append("'" + model.WareHouse_ID + "',");
            }
            if (model.WH_Cell_Code != null)
            {
                strSql1.Append("WH_Cell_Code,");
                strSql2.Append("'" + model.WH_Cell_Code + "',");
            }
            if (model.WH_Cell_Oper_Type != null)
            {
                strSql1.Append("WH_Cell_Oper_Type,");
                strSql2.Append("'" + model.WH_Cell_Oper_Type + "',");
            }
            if (model.WH_Cell_Oper_Detail != null)
            {
                strSql1.Append("WH_Cell_Oper_Detail,");
                strSql2.Append("'" + model.WH_Cell_Oper_Detail + "',");
            }
            if (model.WH_Cell_Oper_Datetime != null)
            {
                strSql1.Append("WH_Cell_Oper_Datetime,");
                strSql2.Append("'" + model.WH_Cell_Oper_Datetime + "',");
            }
            if (model.WH_Cell_Oper_Reserve1 != null)
            {
                strSql1.Append("WH_Cell_Oper_Reserve1,");
                strSql2.Append("'" + model.WH_Cell_Oper_Reserve1 + "',");
            }
            if (model.WH_Cell_Oper_Reserve2 != null)
            {
                strSql1.Append("WH_Cell_Oper_Reserve2,");
                strSql2.Append("'" + model.WH_Cell_Oper_Reserve2 + "',");
            }
            if (model.WH_Cell_Oper_Reserve3 != null)
            {
                strSql1.Append("WH_Cell_Oper_Reserve3,");
                strSql2.Append("'" + model.WH_Cell_Oper_Reserve3 + "',");
            }
            strSql.Append("insert into WH_Cell_Operate_Record(");
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
        public bool Update(WMS_Database.WH_Cell_Operate_RecordModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WH_Cell_Operate_Record set ");
            if (model.WareHouse_ID != null)
            {
                strSql.Append("WareHouse_ID='" + model.WareHouse_ID + "',");
            }
            if (model.WH_Cell_Code != null)
            {
                strSql.Append("WH_Cell_Code='" + model.WH_Cell_Code + "',");
            }
            if (model.WH_Cell_Oper_Type != null)
            {
                strSql.Append("WH_Cell_Oper_Type='" + model.WH_Cell_Oper_Type + "',");
            }
            else
            {
                strSql.Append("WH_Cell_Oper_Type= null ,");
            }
            if (model.WH_Cell_Oper_Detail != null)
            {
                strSql.Append("WH_Cell_Oper_Detail='" + model.WH_Cell_Oper_Detail + "',");
            }
            else
            {
                strSql.Append("WH_Cell_Oper_Detail= null ,");
            }
            if (model.WH_Cell_Oper_Datetime != null)
            {
                strSql.Append("WH_Cell_Oper_Datetime='" + model.WH_Cell_Oper_Datetime + "',");
            }
            if (model.WH_Cell_Oper_Reserve1 != null)
            {
                strSql.Append("WH_Cell_Oper_Reserve1='" + model.WH_Cell_Oper_Reserve1 + "',");
            }
            else
            {
                strSql.Append("WH_Cell_Oper_Reserve1= null ,");
            }
            if (model.WH_Cell_Oper_Reserve2 != null)
            {
                strSql.Append("WH_Cell_Oper_Reserve2='" + model.WH_Cell_Oper_Reserve2 + "',");
            }
            else
            {
                strSql.Append("WH_Cell_Oper_Reserve2= null ,");
            }
            if (model.WH_Cell_Oper_Reserve3 != null)
            {
                strSql.Append("WH_Cell_Oper_Reserve3='" + model.WH_Cell_Oper_Reserve3 + "',");
            }
            else
            {
                strSql.Append("WH_Cell_Oper_Reserve3= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where WH_Cell_Oper_RecID='" + model.WH_Cell_Oper_RecID + "' ");
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
        public bool Delete(string WH_Cell_Oper_RecID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Cell_Operate_Record ");
            strSql.Append(" where WH_Cell_Oper_RecID='" + WH_Cell_Oper_RecID + "' ");
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
        public bool DeleteList(string WH_Cell_Oper_RecIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Cell_Operate_Record ");
            strSql.Append(" where WH_Cell_Oper_RecID in (" + WH_Cell_Oper_RecIDlist + ")  ");
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
        public WMS_Database.WH_Cell_Operate_RecordModel GetModel(string WH_Cell_Oper_RecID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" WH_Cell_Oper_RecID,WareHouse_ID,WH_Cell_Code,WH_Cell_Oper_Type,WH_Cell_Oper_Detail,WH_Cell_Oper_Datetime,WH_Cell_Oper_Reserve1,WH_Cell_Oper_Reserve2,WH_Cell_Oper_Reserve3 ");
            strSql.Append(" from WH_Cell_Operate_Record ");
            strSql.Append(" where WH_Cell_Oper_RecID='" + WH_Cell_Oper_RecID + "' ");
            WMS_Database.WH_Cell_Operate_RecordModel model = new WMS_Database.WH_Cell_Operate_RecordModel();
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
        public WMS_Database.WH_Cell_Operate_RecordModel DataRowToModel(DataRow row)
        {
            WMS_Database.WH_Cell_Operate_RecordModel model = new WMS_Database.WH_Cell_Operate_RecordModel();
            if (row != null)
            {
                if (row["WH_Cell_Oper_RecID"] != null)
                {
                    model.WH_Cell_Oper_RecID = row["WH_Cell_Oper_RecID"].ToString();
                }
                if (row["WareHouse_ID"] != null)
                {
                    model.WareHouse_ID = row["WareHouse_ID"].ToString();
                }
                if (row["WH_Cell_Code"] != null)
                {
                    model.WH_Cell_Code = row["WH_Cell_Code"].ToString();
                }
                if (row["WH_Cell_Oper_Type"] != null)
                {
                    model.WH_Cell_Oper_Type = row["WH_Cell_Oper_Type"].ToString();
                }
                if (row["WH_Cell_Oper_Detail"] != null)
                {
                    model.WH_Cell_Oper_Detail = row["WH_Cell_Oper_Detail"].ToString();
                }
                if (row["WH_Cell_Oper_Datetime"] != null && row["WH_Cell_Oper_Datetime"].ToString() != "")
                {
                    model.WH_Cell_Oper_Datetime = DateTime.Parse(row["WH_Cell_Oper_Datetime"].ToString());
                }
                if (row["WH_Cell_Oper_Reserve1"] != null)
                {
                    model.WH_Cell_Oper_Reserve1 = row["WH_Cell_Oper_Reserve1"].ToString();
                }
                if (row["WH_Cell_Oper_Reserve2"] != null)
                {
                    model.WH_Cell_Oper_Reserve2 = row["WH_Cell_Oper_Reserve2"].ToString();
                }
                if (row["WH_Cell_Oper_Reserve3"] != null)
                {
                    model.WH_Cell_Oper_Reserve3 = row["WH_Cell_Oper_Reserve3"].ToString();
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
            strSql.Append("select WH_Cell_Oper_RecID,WareHouse_ID,WH_Cell_Code,WH_Cell_Oper_Type,WH_Cell_Oper_Detail,WH_Cell_Oper_Datetime,WH_Cell_Oper_Reserve1,WH_Cell_Oper_Reserve2,WH_Cell_Oper_Reserve3 ");
            strSql.Append(" FROM WH_Cell_Operate_Record ");
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
            strSql.Append(" WH_Cell_Oper_RecID,WareHouse_ID,WH_Cell_Code,WH_Cell_Oper_Type,WH_Cell_Oper_Detail,WH_Cell_Oper_Datetime,WH_Cell_Oper_Reserve1,WH_Cell_Oper_Reserve2,WH_Cell_Oper_Reserve3 ");
            strSql.Append(" FROM WH_Cell_Operate_Record ");
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
            strSql.Append("select count(1) FROM WH_Cell_Operate_Record ");
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
                strSql.Append("order by T.WH_Cell_Oper_RecID desc");
            }
            strSql.Append(")AS Row, T.*  from WH_Cell_Operate_Record T ");
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
        public bool DeleteOperate(int days)
        {

            StringBuilder strSql = new StringBuilder();
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            strSql.Append("delete from WH_Cell_Operate_Record ");
            strSql.Append(" where datediff(day,WH_Cell_Oper_Datetime,'" + nowTime + "') >= " + days);
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
        #endregion  MethodEx
    }
}

