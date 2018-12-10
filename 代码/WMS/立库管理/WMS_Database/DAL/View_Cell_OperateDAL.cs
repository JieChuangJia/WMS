using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WMS_Database;
 
namespace AsrsStorDBAcc.DAL
{
    /// <summary>
    /// 数据访问类:View_Cell_Operate
    /// </summary>
    public partial class View_Cell_OperateDAL
    {
        public View_Cell_OperateDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WH_Cell_Oper_RecID, string WareHouse_ID, string WH_Cell_Code, string WH_Cell_Oper_Type, string WH_Cell_Oper_Detail, DateTime WH_Cell_Oper_Datetime, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_Cell_Operate");
            strSql.Append(" where WH_Cell_Oper_RecID='" + WH_Cell_Oper_RecID + "' and WareHouse_ID='" + WareHouse_ID + "' and WH_Cell_Code='" + WH_Cell_Code + "' and WH_Cell_Oper_Type='" + WH_Cell_Oper_Type + "' and WH_Cell_Oper_Detail='" + WH_Cell_Oper_Detail + "' and WH_Cell_Oper_Datetime='" + WH_Cell_Oper_Datetime + "' and WareHouse_Code='" + WareHouse_Code + "' and WareHouse_Name='" + WareHouse_Name + "' and WareHouse_Type='" + WareHouse_Type + "' and WareHouse_Flag='" + WareHouse_Flag + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(AsrsStorDBAcc.Model.View_Cell_OperateModel model)
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
            if (model.WareHouse_Code != null)
            {
                strSql1.Append("WareHouse_Code,");
                strSql2.Append("'" + model.WareHouse_Code + "',");
            }
            if (model.WareHouse_Name != null)
            {
                strSql1.Append("WareHouse_Name,");
                strSql2.Append("'" + model.WareHouse_Name + "',");
            }
            if (model.WareHouse_Type != null)
            {
                strSql1.Append("WareHouse_Type,");
                strSql2.Append("'" + model.WareHouse_Type + "',");
            }
            if (model.WareHouse_Flag != null)
            {
                strSql1.Append("WareHouse_Flag,");
                strSql2.Append("'" + model.WareHouse_Flag + "',");
            }
            strSql.Append("insert into View_Cell_Operate(");
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
        public bool Update(AsrsStorDBAcc.Model.View_Cell_OperateModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_Cell_Operate set ");
            if (model.WH_Cell_Oper_RecID != null)
            {
                strSql.Append("WH_Cell_Oper_RecID='" + model.WH_Cell_Oper_RecID + "',");
            }
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
            if (model.WareHouse_Code != null)
            {
                strSql.Append("WareHouse_Code='" + model.WareHouse_Code + "',");
            }
            else
            {
                strSql.Append("WareHouse_Code= null ,");
            }
            if (model.WareHouse_Name != null)
            {
                strSql.Append("WareHouse_Name='" + model.WareHouse_Name + "',");
            }
            else
            {
                strSql.Append("WareHouse_Name= null ,");
            }
            if (model.WareHouse_Type != null)
            {
                strSql.Append("WareHouse_Type='" + model.WareHouse_Type + "',");
            }
            else
            {
                strSql.Append("WareHouse_Type= null ,");
            }
            if (model.WareHouse_Flag != null)
            {
                strSql.Append("WareHouse_Flag='" + model.WareHouse_Flag + "',");
            }
            else
            {
                strSql.Append("WareHouse_Flag= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where WH_Cell_Oper_RecID='" + model.WH_Cell_Oper_RecID + "' and WareHouse_ID='" + model.WareHouse_ID + "' and WH_Cell_Code='" + model.WH_Cell_Code + "' and WH_Cell_Oper_Type='" + model.WH_Cell_Oper_Type + "' and WH_Cell_Oper_Detail='" + model.WH_Cell_Oper_Detail + "' and WH_Cell_Oper_Datetime='" + model.WH_Cell_Oper_Datetime + "' and WareHouse_Code='" + model.WareHouse_Code + "' and WareHouse_Name='" + model.WareHouse_Name + "' and WareHouse_Type='" + model.WareHouse_Type + "' and WareHouse_Flag='" + model.WareHouse_Flag + "' ");
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
        public bool Delete(string WH_Cell_Oper_RecID, string WareHouse_ID, string WH_Cell_Code, string WH_Cell_Oper_Type, string WH_Cell_Oper_Detail, DateTime WH_Cell_Oper_Datetime, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_Cell_Operate ");
            strSql.Append(" where WH_Cell_Oper_RecID='" + WH_Cell_Oper_RecID + "' and WareHouse_ID='" + WareHouse_ID + "' and WH_Cell_Code='" + WH_Cell_Code + "' and WH_Cell_Oper_Type='" + WH_Cell_Oper_Type + "' and WH_Cell_Oper_Detail='" + WH_Cell_Oper_Detail + "' and WH_Cell_Oper_Datetime='" + WH_Cell_Oper_Datetime + "' and WareHouse_Code='" + WareHouse_Code + "' and WareHouse_Name='" + WareHouse_Name + "' and WareHouse_Type='" + WareHouse_Type + "' and WareHouse_Flag='" + WareHouse_Flag + "' ");
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
        /// 得到一个对象实体
        /// </summary>
        public AsrsStorDBAcc.Model.View_Cell_OperateModel GetModel(string WH_Cell_Oper_RecID, string WareHouse_ID, string WH_Cell_Code, string WH_Cell_Oper_Type, string WH_Cell_Oper_Detail, DateTime WH_Cell_Oper_Datetime, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" WH_Cell_Oper_RecID,WareHouse_ID,WH_Cell_Code,WH_Cell_Oper_Type,WH_Cell_Oper_Detail,WH_Cell_Oper_Datetime,WareHouse_Code,WareHouse_Name,WareHouse_Type,WareHouse_Flag ");
            strSql.Append(" from View_Cell_Operate ");
            strSql.Append(" where WH_Cell_Oper_RecID='" + WH_Cell_Oper_RecID + "' and WareHouse_ID='" + WareHouse_ID + "' and WH_Cell_Code='" + WH_Cell_Code + "' and WH_Cell_Oper_Type='" + WH_Cell_Oper_Type + "' and WH_Cell_Oper_Detail='" + WH_Cell_Oper_Detail + "' and WH_Cell_Oper_Datetime='" + WH_Cell_Oper_Datetime + "' and WareHouse_Code='" + WareHouse_Code + "' and WareHouse_Name='" + WareHouse_Name + "' and WareHouse_Type='" + WareHouse_Type + "' and WareHouse_Flag='" + WareHouse_Flag + "' ");
            AsrsStorDBAcc.Model.View_Cell_OperateModel model = new AsrsStorDBAcc.Model.View_Cell_OperateModel();
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
        public AsrsStorDBAcc.Model.View_Cell_OperateModel DataRowToModel(DataRow row)
        {
            AsrsStorDBAcc.Model.View_Cell_OperateModel model = new AsrsStorDBAcc.Model.View_Cell_OperateModel();
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
                if (row["WareHouse_Code"] != null)
                {
                    model.WareHouse_Code = row["WareHouse_Code"].ToString();
                }
                if (row["WareHouse_Name"] != null)
                {
                    model.WareHouse_Name = row["WareHouse_Name"].ToString();
                }
                if (row["WareHouse_Type"] != null)
                {
                    model.WareHouse_Type = row["WareHouse_Type"].ToString();
                }
                if (row["WareHouse_Flag"] != null)
                {
                    model.WareHouse_Flag = row["WareHouse_Flag"].ToString();
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
            strSql.Append("select WH_Cell_Oper_RecID,WareHouse_ID,WH_Cell_Code,WH_Cell_Oper_Type,WH_Cell_Oper_Detail,WH_Cell_Oper_Datetime,WareHouse_Code,WareHouse_Name,WareHouse_Type,WareHouse_Flag ");
            strSql.Append(" FROM View_Cell_Operate ");
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
            strSql.Append(" WH_Cell_Oper_RecID,WareHouse_ID,WH_Cell_Code,WH_Cell_Oper_Type,WH_Cell_Oper_Detail,WH_Cell_Oper_Datetime,WareHouse_Code,WareHouse_Name,WareHouse_Type,WareHouse_Flag ");
            strSql.Append(" FROM View_Cell_Operate ");
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
            strSql.Append("select count(1) FROM View_Cell_Operate ");
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
                strSql.Append("order by T.WareHouse_Flag desc");
            }
            strSql.Append(")AS Row, T.*  from View_Cell_Operate T ");
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
        public DataTable GetOperate(DateTime stDt, DateTime edDt, string operateType, bool likeQueryChecked, string likeQueryValue)
        {
            string startTime = stDt.ToString("yyyy-MM-dd 0:00:00");
            string endTime = edDt.ToString("yyyy-MM-dd 23:59:59");
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select WH_Cell_Oper_RecID as 操作记录ID,WareHouse_ID as 库房编号,WH_Cell_Code as 货位编号,[WH_Cell_Oper_Type] as 操作类型,[WH_Cell_Oper_Detail] as 操作详细,[WH_Cell_Oper_Datetime] as 操作时间 from WH_Cell_Operate_Record ");

            strSql.Append(" where WH_Cell_Oper_Datetime>='" + startTime + "' and WH_Cell_Oper_Datetime<='" + endTime + "'");
            if (operateType != "所有")
            {
                strSql.Append(" and WH_Cell_Oper_Type='" + operateType + "'");
            }
            if (likeQueryChecked == true)
            {
                strSql.Append(" and WH_Cell_Oper_Detail like '%" + likeQueryValue + "%'");
            }
            strSql.Append(" order by WH_Cell_Oper_Datetime desc");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        #endregion  MethodEx
    }
}

