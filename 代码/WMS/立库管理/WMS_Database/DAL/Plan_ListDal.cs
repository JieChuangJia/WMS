using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
//using Maticsoft.DBUtility;//Please add references
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:Plan_ListDal
	/// </summary>
	public partial class Plan_ListDal
	{
        public Plan_ListDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_List_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Plan_List");
            strSql.Append(" where Plan_List_ID='" + Plan_List_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Plan_ListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Plan_List_ID != null)
            {
                strSql1.Append("Plan_List_ID,");
                strSql2.Append("'" + model.Plan_List_ID + "',");
            }
            if (model.Plan_ID != null)
            {
                strSql1.Append("Plan_ID,");
                strSql2.Append("'" + model.Plan_ID + "',");
            }
            if (model.Plan_List_Quantity != null)
            {
                strSql1.Append("Plan_List_Quantity,");
                strSql2.Append("" + model.Plan_List_Quantity + ",");
            }
            if (model.Plan_List_Ordered_Quantity != null)
            {
                strSql1.Append("Plan_List_Ordered_Quantity,");
                strSql2.Append("" + model.Plan_List_Ordered_Quantity + ",");
            }
            if (model.Plan_List_Finished_Quantity != null)
            {
                strSql1.Append("Plan_List_Finished_Quantity,");
                strSql2.Append("" + model.Plan_List_Finished_Quantity + ",");
            }
            if (model.Goods_ID != null)
            {
                strSql1.Append("Goods_ID,");
                strSql2.Append("'" + model.Goods_ID + "',");
            }
            if (model.Plan_List_Status != null)
            {
                strSql1.Append("Plan_List_Status,");
                strSql2.Append("'" + model.Plan_List_Status + "',");
            }
            if (model.Plan_List_Remark != null)
            {
                strSql1.Append("Plan_List_Remark,");
                strSql2.Append("'" + model.Plan_List_Remark + "',");
            }
            if (model.Plan_List_Resever1 != null)
            {
                strSql1.Append("Plan_List_Resever1,");
                strSql2.Append("'" + model.Plan_List_Resever1 + "',");
            }
            if (model.Plan_List_Resever2 != null)
            {
                strSql1.Append("Plan_List_Resever2,");
                strSql2.Append("'" + model.Plan_List_Resever2 + "',");
            }
            if (model.Plan_List_Resever3 != null)
            {
                strSql1.Append("Plan_List_Resever3,");
                strSql2.Append("'" + model.Plan_List_Resever3 + "',");
            }
            if (model.Plan_List_Resever4 != null)
            {
                strSql1.Append("Plan_List_Resever4,");
                strSql2.Append("'" + model.Plan_List_Resever4 + "',");
            }
            if (model.Plan_List_Resever5 != null)
            {
                strSql1.Append("Plan_List_Resever5,");
                strSql2.Append("'" + model.Plan_List_Resever5 + "',");
            }
            strSql.Append("insert into Plan_List(");
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
        public bool Update(WMS_Database.Plan_ListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Plan_List set ");
            if (model.Plan_ID != null)
            {
                strSql.Append("Plan_ID='" + model.Plan_ID + "',");
            }
            else
            {
                strSql.Append("Plan_ID= null ,");
            }
            if (model.Plan_List_Quantity != null)
            {
                strSql.Append("Plan_List_Quantity=" + model.Plan_List_Quantity + ",");
            }
            else
            {
                strSql.Append("Plan_List_Quantity= null ,");
            }
            if (model.Plan_List_Ordered_Quantity != null)
            {
                strSql.Append("Plan_List_Ordered_Quantity=" + model.Plan_List_Ordered_Quantity + ",");
            }
            else
            {
                strSql.Append("Plan_List_Ordered_Quantity= null ,");
            }
            if (model.Plan_List_Finished_Quantity != null)
            {
                strSql.Append("Plan_List_Finished_Quantity=" + model.Plan_List_Finished_Quantity + ",");
            }
            else
            {
                strSql.Append("Plan_List_Finished_Quantity= null ,");
            }
            if (model.Goods_ID != null)
            {
                strSql.Append("Goods_ID='" + model.Goods_ID + "',");
            }
            else
            {
                strSql.Append("Goods_ID= null ,");
            }
            if (model.Plan_List_Status != null)
            {
                strSql.Append("Plan_List_Status='" + model.Plan_List_Status + "',");
            }
            else
            {
                strSql.Append("Plan_List_Status= null ,");
            }
            if (model.Plan_List_Remark != null)
            {
                strSql.Append("Plan_List_Remark='" + model.Plan_List_Remark + "',");
            }
            else
            {
                strSql.Append("Plan_List_Remark= null ,");
            }
            if (model.Plan_List_Resever1 != null)
            {
                strSql.Append("Plan_List_Resever1='" + model.Plan_List_Resever1 + "',");
            }
            else
            {
                strSql.Append("Plan_List_Resever1= null ,");
            }
            if (model.Plan_List_Resever2 != null)
            {
                strSql.Append("Plan_List_Resever2='" + model.Plan_List_Resever2 + "',");
            }
            else
            {
                strSql.Append("Plan_List_Resever2= null ,");
            }
            if (model.Plan_List_Resever3 != null)
            {
                strSql.Append("Plan_List_Resever3='" + model.Plan_List_Resever3 + "',");
            }
            else
            {
                strSql.Append("Plan_List_Resever3= null ,");
            }
            if (model.Plan_List_Resever4 != null)
            {
                strSql.Append("Plan_List_Resever4='" + model.Plan_List_Resever4 + "',");
            }
            else
            {
                strSql.Append("Plan_List_Resever4= null ,");
            }
            if (model.Plan_List_Resever5 != null)
            {
                strSql.Append("Plan_List_Resever5='" + model.Plan_List_Resever5 + "',");
            }
            else
            {
                strSql.Append("Plan_List_Resever5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Plan_List_ID='" + model.Plan_List_ID + "' ");
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
        public bool Delete(string Plan_List_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Plan_List ");
            strSql.Append(" where Plan_List_ID='" + Plan_List_ID + "' ");
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
        public bool DeleteList(string Plan_List_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Plan_List ");
            strSql.Append(" where Plan_List_ID in (" + Plan_List_IDlist + ")  ");
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
        public WMS_Database.Plan_ListModel GetModel(string Plan_List_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Plan_List_ID,Plan_ID,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Goods_ID,Plan_List_Status,Plan_List_Remark,Plan_List_Resever1,Plan_List_Resever2,Plan_List_Resever3,Plan_List_Resever4,Plan_List_Resever5 ");
            strSql.Append(" from Plan_List ");
            strSql.Append(" where Plan_List_ID='" + Plan_List_ID + "' ");
            WMS_Database.Plan_ListModel model = new WMS_Database.Plan_ListModel();
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
        public WMS_Database.Plan_ListModel DataRowToModel(DataRow row)
        {
            WMS_Database.Plan_ListModel model = new WMS_Database.Plan_ListModel();
            if (row != null)
            {
                if (row["Plan_List_ID"] != null)
                {
                    model.Plan_List_ID = row["Plan_List_ID"].ToString();
                }
                if (row["Plan_ID"] != null)
                {
                    model.Plan_ID = row["Plan_ID"].ToString();
                }
                if (row["Plan_List_Quantity"] != null && row["Plan_List_Quantity"].ToString() != "")
                {
                    model.Plan_List_Quantity = row["Plan_List_Quantity"].ToString();
                }
                if (row["Plan_List_Ordered_Quantity"] != null && row["Plan_List_Ordered_Quantity"].ToString() != "")
                {
                    model.Plan_List_Ordered_Quantity =row["Plan_List_Ordered_Quantity"].ToString();
                }
                if (row["Plan_List_Finished_Quantity"] != null && row["Plan_List_Finished_Quantity"].ToString() != "")
                {
                    model.Plan_List_Finished_Quantity = row["Plan_List_Finished_Quantity"].ToString();
                }
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
                }
                if (row["Plan_List_Status"] != null)
                {
                    model.Plan_List_Status = row["Plan_List_Status"].ToString();
                }
                if (row["Plan_List_Remark"] != null)
                {
                    model.Plan_List_Remark = row["Plan_List_Remark"].ToString();
                }
                if (row["Plan_List_Resever1"] != null)
                {
                    model.Plan_List_Resever1 = row["Plan_List_Resever1"].ToString();
                }
                if (row["Plan_List_Resever2"] != null)
                {
                    model.Plan_List_Resever2 = row["Plan_List_Resever2"].ToString();
                }
                if (row["Plan_List_Resever3"] != null)
                {
                    model.Plan_List_Resever3 = row["Plan_List_Resever3"].ToString();
                }
                if (row["Plan_List_Resever4"] != null)
                {
                    model.Plan_List_Resever4 = row["Plan_List_Resever4"].ToString();
                }
                if (row["Plan_List_Resever5"] != null)
                {
                    model.Plan_List_Resever5 = row["Plan_List_Resever5"].ToString();
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
            strSql.Append("select Plan_List_ID,Plan_ID,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Goods_ID,Plan_List_Status,Plan_List_Remark,Plan_List_Resever1,Plan_List_Resever2,Plan_List_Resever3,Plan_List_Resever4,Plan_List_Resever5 ");
            strSql.Append(" FROM Plan_List ");
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
            strSql.Append(" Plan_List_ID,Plan_ID,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Goods_ID,Plan_List_Status,Plan_List_Remark,Plan_List_Resever1,Plan_List_Resever2,Plan_List_Resever3,Plan_List_Resever4,Plan_List_Resever5 ");
            strSql.Append(" FROM Plan_List ");
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
            strSql.Append("select count(1) FROM Plan_List ");
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
                strSql.Append("order by T.Plan_List_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Plan_List T ");
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

