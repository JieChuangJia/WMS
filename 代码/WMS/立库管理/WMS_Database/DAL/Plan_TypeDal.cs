using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
//using Maticsoft.DBUtility;//Please add references
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:Plan_TypeDal
	/// </summary>
	public partial class Plan_TypeDal
	{
        public Plan_TypeDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_Type_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Plan_Type");
            strSql.Append(" where Plan_Type_ID='" + Plan_Type_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Plan_TypeModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Plan_Type_ID != null)
            {
                strSql1.Append("Plan_Type_ID,");
                strSql2.Append("'" + model.Plan_Type_ID + "',");
            }
            if (model.Plan_Type_Code != null)
            {
                strSql1.Append("Plan_Type_Code,");
                strSql2.Append("'" + model.Plan_Type_Code + "',");
            }
            if (model.Plan_Type_Name != null)
            {
                strSql1.Append("Plan_Type_Name,");
                strSql2.Append("'" + model.Plan_Type_Name + "',");
            }
            if (model.Plan_Type_Group != null)
            {
                strSql1.Append("Plan_Type_Group,");
                strSql2.Append("'" + model.Plan_Type_Group + "',");
            }
            if (model.Plan_Type_InOut != null)
            {
                strSql1.Append("Plan_Type_InOut,");
                strSql2.Append("'" + model.Plan_Type_InOut + "',");
            }
            if (model.Plan_Type_Remark != null)
            {
                strSql1.Append("Plan_Type_Remark,");
                strSql2.Append("'" + model.Plan_Type_Remark + "',");
            }
            if (model.Plan_Type_Order != null)
            {
                strSql1.Append("Plan_Type_Order,");
                strSql2.Append("" + model.Plan_Type_Order + ",");
            }
            if (model.Plan_Type_Flag != null)
            {
                strSql1.Append("Plan_Type_Flag,");
                strSql2.Append("'" + model.Plan_Type_Flag + "',");
            }
            if (model.Plan_Type_Resever1 != null)
            {
                strSql1.Append("Plan_Type_Resever1,");
                strSql2.Append("'" + model.Plan_Type_Resever1 + "',");
            }
            if (model.Plan_Type_Resever2 != null)
            {
                strSql1.Append("Plan_Type_Resever2,");
                strSql2.Append("'" + model.Plan_Type_Resever2 + "',");
            }
            if (model.Plan_Type_Resever3 != null)
            {
                strSql1.Append("Plan_Type_Resever3,");
                strSql2.Append("'" + model.Plan_Type_Resever3 + "',");
            }
            if (model.Plan_Type_Resever4 != null)
            {
                strSql1.Append("Plan_Type_Resever4,");
                strSql2.Append("'" + model.Plan_Type_Resever4 + "',");
            }
            if (model.Plan_Type_Resever5 != null)
            {
                strSql1.Append("Plan_Type_Resever5,");
                strSql2.Append("'" + model.Plan_Type_Resever5 + "',");
            }
            strSql.Append("insert into Plan_Type(");
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
        public bool Update(WMS_Database.Plan_TypeModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Plan_Type set ");
            if (model.Plan_Type_Code != null)
            {
                strSql.Append("Plan_Type_Code='" + model.Plan_Type_Code + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Code= null ,");
            }
            if (model.Plan_Type_Name != null)
            {
                strSql.Append("Plan_Type_Name='" + model.Plan_Type_Name + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Name= null ,");
            }
            if (model.Plan_Type_Group != null)
            {
                strSql.Append("Plan_Type_Group='" + model.Plan_Type_Group + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Group= null ,");
            }
            if (model.Plan_Type_InOut != null)
            {
                strSql.Append("Plan_Type_InOut='" + model.Plan_Type_InOut + "',");
            }
            else
            {
                strSql.Append("Plan_Type_InOut= null ,");
            }
            if (model.Plan_Type_Remark != null)
            {
                strSql.Append("Plan_Type_Remark='" + model.Plan_Type_Remark + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Remark= null ,");
            }
            if (model.Plan_Type_Order != null)
            {
                strSql.Append("Plan_Type_Order=" + model.Plan_Type_Order + ",");
            }
            else
            {
                strSql.Append("Plan_Type_Order= null ,");
            }
            if (model.Plan_Type_Flag != null)
            {
                strSql.Append("Plan_Type_Flag='" + model.Plan_Type_Flag + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Flag= null ,");
            }
            if (model.Plan_Type_Resever1 != null)
            {
                strSql.Append("Plan_Type_Resever1='" + model.Plan_Type_Resever1 + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Resever1= null ,");
            }
            if (model.Plan_Type_Resever2 != null)
            {
                strSql.Append("Plan_Type_Resever2='" + model.Plan_Type_Resever2 + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Resever2= null ,");
            }
            if (model.Plan_Type_Resever3 != null)
            {
                strSql.Append("Plan_Type_Resever3='" + model.Plan_Type_Resever3 + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Resever3= null ,");
            }
            if (model.Plan_Type_Resever4 != null)
            {
                strSql.Append("Plan_Type_Resever4='" + model.Plan_Type_Resever4 + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Resever4= null ,");
            }
            if (model.Plan_Type_Resever5 != null)
            {
                strSql.Append("Plan_Type_Resever5='" + model.Plan_Type_Resever5 + "',");
            }
            else
            {
                strSql.Append("Plan_Type_Resever5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Plan_Type_ID='" + model.Plan_Type_ID + "' ");
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
        public bool Delete(string Plan_Type_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Plan_Type ");
            strSql.Append(" where Plan_Type_ID='" + Plan_Type_ID + "' ");
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
        public bool DeleteList(string Plan_Type_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Plan_Type ");
            strSql.Append(" where Plan_Type_ID in (" + Plan_Type_IDlist + ")  ");
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
        public WMS_Database.Plan_TypeModel GetModel(string Plan_Type_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Plan_Type_ID,Plan_Type_Code,Plan_Type_Name,Plan_Type_Group,Plan_Type_InOut,Plan_Type_Remark,Plan_Type_Order,Plan_Type_Flag,Plan_Type_Resever1,Plan_Type_Resever2,Plan_Type_Resever3,Plan_Type_Resever4,Plan_Type_Resever5 ");
            strSql.Append(" from Plan_Type ");
            strSql.Append(" where Plan_Type_ID='" + Plan_Type_ID + "' ");
            WMS_Database.Plan_TypeModel model = new WMS_Database.Plan_TypeModel();
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
        public WMS_Database.Plan_TypeModel DataRowToModel(DataRow row)
        {
            WMS_Database.Plan_TypeModel model = new WMS_Database.Plan_TypeModel();
            if (row != null)
            {
                if (row["Plan_Type_ID"] != null)
                {
                    model.Plan_Type_ID = row["Plan_Type_ID"].ToString();
                }
                if (row["Plan_Type_Code"] != null)
                {
                    model.Plan_Type_Code = row["Plan_Type_Code"].ToString();
                }
                if (row["Plan_Type_Name"] != null)
                {
                    model.Plan_Type_Name = row["Plan_Type_Name"].ToString();
                }
                if (row["Plan_Type_Group"] != null)
                {
                    model.Plan_Type_Group = row["Plan_Type_Group"].ToString();
                }
                if (row["Plan_Type_InOut"] != null)
                {
                    model.Plan_Type_InOut = row["Plan_Type_InOut"].ToString();
                }
                if (row["Plan_Type_Remark"] != null)
                {
                    model.Plan_Type_Remark = row["Plan_Type_Remark"].ToString();
                }
                if (row["Plan_Type_Order"] != null && row["Plan_Type_Order"].ToString() != "")
                {
                    model.Plan_Type_Order = int.Parse(row["Plan_Type_Order"].ToString());
                }
                if (row["Plan_Type_Flag"] != null)
                {
                    model.Plan_Type_Flag = row["Plan_Type_Flag"].ToString();
                }
                if (row["Plan_Type_Resever1"] != null)
                {
                    model.Plan_Type_Resever1 = row["Plan_Type_Resever1"].ToString();
                }
                if (row["Plan_Type_Resever2"] != null)
                {
                    model.Plan_Type_Resever2 = row["Plan_Type_Resever2"].ToString();
                }
                if (row["Plan_Type_Resever3"] != null)
                {
                    model.Plan_Type_Resever3 = row["Plan_Type_Resever3"].ToString();
                }
                if (row["Plan_Type_Resever4"] != null)
                {
                    model.Plan_Type_Resever4 = row["Plan_Type_Resever4"].ToString();
                }
                if (row["Plan_Type_Resever5"] != null)
                {
                    model.Plan_Type_Resever5 = row["Plan_Type_Resever5"].ToString();
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
            strSql.Append("select Plan_Type_ID,Plan_Type_Code,Plan_Type_Name,Plan_Type_Group,Plan_Type_InOut,Plan_Type_Remark,Plan_Type_Order,Plan_Type_Flag,Plan_Type_Resever1,Plan_Type_Resever2,Plan_Type_Resever3,Plan_Type_Resever4,Plan_Type_Resever5 ");
            strSql.Append(" FROM Plan_Type ");
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
            strSql.Append(" Plan_Type_ID,Plan_Type_Code,Plan_Type_Name,Plan_Type_Group,Plan_Type_InOut,Plan_Type_Remark,Plan_Type_Order,Plan_Type_Flag,Plan_Type_Resever1,Plan_Type_Resever2,Plan_Type_Resever3,Plan_Type_Resever4,Plan_Type_Resever5 ");
            strSql.Append(" FROM Plan_Type ");
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
            strSql.Append("select count(1) FROM Plan_Type ");
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
                strSql.Append("order by T.Plan_Type_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Plan_Type T ");
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

