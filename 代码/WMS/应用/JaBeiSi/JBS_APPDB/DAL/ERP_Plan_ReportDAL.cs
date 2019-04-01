using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

 
namespace JBS_APPDB
{
    /// <summary>
    /// 数据访问类:ERP_Plan_Report
    /// </summary>
    public partial class ERP_Plan_ReportDAL
    {
        public ERP_Plan_ReportDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_Plan_Report_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERP_Plan_Report");
            strSql.Append(" where ERP_Plan_Report_ID='" + ERP_Plan_Report_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(JBS_APPDB.ERP_Plan_ReportModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.ERP_Plan_Report_ID != null)
            {
                strSql1.Append("ERP_Plan_Report_ID,");
                strSql2.Append("'" + model.ERP_Plan_Report_ID + "',");
            }
            if (model.ERP_Plan_Code != null)
            {
                strSql1.Append("ERP_Plan_Code,");
                strSql2.Append("'" + model.ERP_Plan_Code + "',");
            }
            if (model.ERP_Plan_Report_Content != null)
            {
                strSql1.Append("ERP_Plan_Report_Content,");
                strSql2.Append("'" + model.ERP_Plan_Report_Content + "',");
            }
            if (model.ERP_Plan_IsReported != null)
            {
                strSql1.Append("ERP_Plan_IsReported,");
                strSql2.Append("" + (model.ERP_Plan_IsReported ? 1 : 0) + ",");
            }
            if (model.ERP_Plan_Remark != null)
            {
                strSql1.Append("ERP_Plan_Remark,");
                strSql2.Append("'" + model.ERP_Plan_Remark + "',");
            }
            strSql.Append("insert into ERP_Plan_Report(");
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
        public bool Update(JBS_APPDB.ERP_Plan_ReportModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERP_Plan_Report set ");
            if (model.ERP_Plan_Code != null)
            {
                strSql.Append("ERP_Plan_Code='" + model.ERP_Plan_Code + "',");
            }
            else
            {
                strSql.Append("ERP_Plan_Code= null ,");
            }
            if (model.ERP_Plan_Report_Content != null)
            {
                strSql.Append("ERP_Plan_Report_Content='" + model.ERP_Plan_Report_Content + "',");
            }
            else
            {
                strSql.Append("ERP_Plan_Report_Content= null ,");
            }
            if (model.ERP_Plan_IsReported != null)
            {
                strSql.Append("ERP_Plan_IsReported=" + (model.ERP_Plan_IsReported ? 1 : 0) + ",");
            }
            else
            {
                strSql.Append("ERP_Plan_IsReported= null ,");
            }
            if (model.ERP_Plan_Remark != null)
            {
                strSql.Append("ERP_Plan_Remark='" + model.ERP_Plan_Remark + "',");
            }
            else
            {
                strSql.Append("ERP_Plan_Remark= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ERP_Plan_Report_ID='" + model.ERP_Plan_Report_ID + "' ");
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
        public bool Delete(string ERP_Plan_Report_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERP_Plan_Report ");
            strSql.Append(" where ERP_Plan_Report_ID='" + ERP_Plan_Report_ID + "' ");
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
        public bool DeleteList(string ERP_Plan_Report_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERP_Plan_Report ");
            strSql.Append(" where ERP_Plan_Report_ID in (" + ERP_Plan_Report_IDlist + ")  ");
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
        public JBS_APPDB.ERP_Plan_ReportModel GetModel(string ERP_Plan_Report_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ERP_Plan_Report_ID,ERP_Plan_Code,ERP_Plan_Report_Content,ERP_Plan_IsReported,ERP_Plan_Remark ");
            strSql.Append(" from ERP_Plan_Report ");
            strSql.Append(" where ERP_Plan_Report_ID='" + ERP_Plan_Report_ID + "' ");
            JBS_APPDB.ERP_Plan_ReportModel model = new JBS_APPDB.ERP_Plan_ReportModel();
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
        public JBS_APPDB.ERP_Plan_ReportModel DataRowToModel(DataRow row)
        {
            JBS_APPDB.ERP_Plan_ReportModel model = new JBS_APPDB.ERP_Plan_ReportModel();
            if (row != null)
            {
                if (row["ERP_Plan_Report_ID"] != null)
                {
                    model.ERP_Plan_Report_ID = row["ERP_Plan_Report_ID"].ToString();
                }
                if (row["ERP_Plan_Code"] != null)
                {
                    model.ERP_Plan_Code = row["ERP_Plan_Code"].ToString();
                }
                if (row["ERP_Plan_Report_Content"] != null)
                {
                    model.ERP_Plan_Report_Content = row["ERP_Plan_Report_Content"].ToString();
                }
                if (row["ERP_Plan_IsReported"] != null && row["ERP_Plan_IsReported"].ToString() != "")
                {
                    if ((row["ERP_Plan_IsReported"].ToString() == "1") || (row["ERP_Plan_IsReported"].ToString().ToLower() == "true"))
                    {
                        model.ERP_Plan_IsReported = true;
                    }
                    else
                    {
                        model.ERP_Plan_IsReported = false;
                    }
                }
                if (row["ERP_Plan_Remark"] != null)
                {
                    model.ERP_Plan_Remark = row["ERP_Plan_Remark"].ToString();
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
            strSql.Append("select ERP_Plan_Report_ID,ERP_Plan_Code,ERP_Plan_Report_Content,ERP_Plan_IsReported,ERP_Plan_Remark ");
            strSql.Append(" FROM ERP_Plan_Report ");
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
            strSql.Append(" ERP_Plan_Report_ID,ERP_Plan_Code,ERP_Plan_Report_Content,ERP_Plan_IsReported,ERP_Plan_Remark ");
            strSql.Append(" FROM ERP_Plan_Report ");
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
            strSql.Append("select count(1) FROM ERP_Plan_Report ");
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
                strSql.Append("order by T.ERP_Plan_Report_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ERP_Plan_Report T ");
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
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

