using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:SysLog
    /// </summary>
    public partial class SysLogDAL
    {
        public SysLogDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string SysLog_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SysLog");
            strSql.Append(" where SysLog_ID=@SysLog_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@SysLog_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = SysLog_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.SysLogModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SysLog(");
            strSql.Append("SysLog_ID,SysLog_Source,SysLog_Level,SysLog_Time,SysLog_Content,SysLog_Reserve1,SysLog_Reserve2)");
            strSql.Append(" values (");
            strSql.Append("@SysLog_ID,@SysLog_Source,@SysLog_Level,@SysLog_Time,@SysLog_Content,@SysLog_Reserve1,@SysLog_Reserve2)");
            SqlParameter[] parameters = {
					new SqlParameter("@SysLog_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@SysLog_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@SysLog_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@SysLog_Time", SqlDbType.DateTime),
					new SqlParameter("@SysLog_Content", SqlDbType.NVarChar),
					new SqlParameter("@SysLog_Reserve1", SqlDbType.NVarChar,100),
					new SqlParameter("@SysLog_Reserve2", SqlDbType.NVarChar,100)};
            parameters[0].Value = model.SysLog_ID;
            parameters[1].Value = model.SysLog_Source;
            parameters[2].Value = model.SysLog_Level;
            parameters[3].Value = model.SysLog_Time;
            parameters[4].Value = model.SysLog_Content;
            parameters[5].Value = model.SysLog_Reserve1;
            parameters[6].Value = model.SysLog_Reserve2;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(WMS_Database.SysLogModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SysLog set ");
            strSql.Append("SysLog_Source=@SysLog_Source,");
            strSql.Append("SysLog_Level=@SysLog_Level,");
            strSql.Append("SysLog_Time=@SysLog_Time,");
            strSql.Append("SysLog_Content=@SysLog_Content,");
            strSql.Append("SysLog_Reserve1=@SysLog_Reserve1,");
            strSql.Append("SysLog_Reserve2=@SysLog_Reserve2");
            strSql.Append(" where SysLog_ID=@SysLog_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@SysLog_Source", SqlDbType.NVarChar,50),
					new SqlParameter("@SysLog_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@SysLog_Time", SqlDbType.DateTime),
					new SqlParameter("@SysLog_Content", SqlDbType.NVarChar),
					new SqlParameter("@SysLog_Reserve1", SqlDbType.NVarChar,100),
					new SqlParameter("@SysLog_Reserve2", SqlDbType.NVarChar,100),
					new SqlParameter("@SysLog_ID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SysLog_Source;
            parameters[1].Value = model.SysLog_Level;
            parameters[2].Value = model.SysLog_Time;
            parameters[3].Value = model.SysLog_Content;
            parameters[4].Value = model.SysLog_Reserve1;
            parameters[5].Value = model.SysLog_Reserve2;
            parameters[6].Value = model.SysLog_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string SysLog_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SysLog ");
            strSql.Append(" where SysLog_ID=@SysLog_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@SysLog_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = SysLog_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string SysLog_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SysLog ");
            strSql.Append(" where SysLog_ID in (" + SysLog_IDlist + ")  ");
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
        public WMS_Database.SysLogModel GetModel(string SysLog_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 SysLog_ID,SysLog_Source,SysLog_Level,SysLog_Time,SysLog_Content,SysLog_Reserve1,SysLog_Reserve2 from SysLog ");
            strSql.Append(" where SysLog_ID=@SysLog_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@SysLog_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = SysLog_ID;

            WMS_Database.SysLogModel model = new WMS_Database.SysLogModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
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
        public WMS_Database.SysLogModel DataRowToModel(DataRow row)
        {
            WMS_Database.SysLogModel model = new WMS_Database.SysLogModel();
            if (row != null)
            {
                if (row["SysLog_ID"] != null)
                {
                    model.SysLog_ID = row["SysLog_ID"].ToString();
                }
                if (row["SysLog_Source"] != null)
                {
                    model.SysLog_Source = row["SysLog_Source"].ToString();
                }
                if (row["SysLog_Level"] != null)
                {
                    model.SysLog_Level = row["SysLog_Level"].ToString();
                }
                if (row["SysLog_Time"] != null && row["SysLog_Time"].ToString() != "")
                {
                    model.SysLog_Time = DateTime.Parse(row["SysLog_Time"].ToString());
                }
                if (row["SysLog_Content"] != null)
                {
                    model.SysLog_Content = row["SysLog_Content"].ToString();
                }
                if (row["SysLog_Reserve1"] != null)
                {
                    model.SysLog_Reserve1 = row["SysLog_Reserve1"].ToString();
                }
                if (row["SysLog_Reserve2"] != null)
                {
                    model.SysLog_Reserve2 = row["SysLog_Reserve2"].ToString();
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
            strSql.Append("select SysLog_ID,SysLog_Source,SysLog_Level,SysLog_Time,SysLog_Content,SysLog_Reserve1,SysLog_Reserve2 ");
            strSql.Append(" FROM SysLog ");
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
            strSql.Append(" SysLog_ID,SysLog_Source,SysLog_Level,SysLog_Time,SysLog_Content,SysLog_Reserve1,SysLog_Reserve2 ");
            strSql.Append(" FROM SysLog ");
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
            strSql.Append("select count(1) FROM SysLog ");
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
                strSql.Append("order by T.SysLog_ID desc");
            }
            strSql.Append(")AS Row, T.*  from SysLog T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "SysLog";
            parameters[1].Value = "SysLog_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        public DataTable GetLog(DateTime stDt, DateTime edDt, string level, bool likeQueryChecked, string likeQueryValue)
        {
            string startTime = stDt.ToString("yyyy-MM-dd 0:00:00");
            string endTime = edDt.ToString("yyyy-MM-dd 23:59:59");
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SysLog_ID as 日志ID,SysLog_Source as 日志源,SysLog_Level as 日志级别,SysLog_Time as 日志时间,SysLog_Content as 日志内容 from SysLog ");

            strSql.Append(" where SysLog_Time>='" + startTime + "' and SysLog_Time<='" + endTime + "'");
            if (level != "所有")
            {
                strSql.Append(" and SysLog_Level='" + level + "'");
            }
            if (likeQueryChecked == true)
            {
                strSql.Append(" and SysLog_Content like '%" + likeQueryValue + "%'");
            }
            strSql.Append(" order by SysLog_Time desc");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if(ds!= null&&ds.Tables.Count>0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

