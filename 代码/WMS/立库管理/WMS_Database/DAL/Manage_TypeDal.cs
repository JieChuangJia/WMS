using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:Manage_TypeDal
	/// </summary>
	public partial class Manage_TypeDal
	{
        public Manage_TypeDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Manage_Type_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Manage_Type");
            strSql.Append(" where Manage_Type_ID='" + Manage_Type_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Manage_TypeModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Manage_Type_ID != null)
            {
                strSql1.Append("Manage_Type_ID,");
                strSql2.Append("'" + model.Manage_Type_ID + "',");
            }
            if (model.Manage_Type_Code != null)
            {
                strSql1.Append("Manage_Type_Code,");
                strSql2.Append("'" + model.Manage_Type_Code + "',");
            }
            if (model.Manage_Type_Name != null)
            {
                strSql1.Append("Manage_Type_Name,");
                strSql2.Append("'" + model.Manage_Type_Name + "',");
            }
            if (model.Manage_Type_InOut != null)
            {
                strSql1.Append("Manage_Type_InOut,");
                strSql2.Append("'" + model.Manage_Type_InOut + "',");
            }
            if (model.Manage_Type_Group != null)
            {
                strSql1.Append("Manage_Type_Group,");
                strSql2.Append("'" + model.Manage_Type_Group + "',");
            }
            if (model.Manage_Type_Remark != null)
            {
                strSql1.Append("Manage_Type_Remark,");
                strSql2.Append("'" + model.Manage_Type_Remark + "',");
            }
            if (model.Manage_Type_Order != null)
            {
                strSql1.Append("Manage_Type_Order,");
                strSql2.Append("" + model.Manage_Type_Order + ",");
            }
            if (model.Manage_Type_Flag != null)
            {
                strSql1.Append("Manage_Type_Flag,");
                strSql2.Append("'" + model.Manage_Type_Flag + "',");
            }
            if (model.Manage_Type_Reserve1 != null)
            {
                strSql1.Append("Manage_Type_Reserve1,");
                strSql2.Append("'" + model.Manage_Type_Reserve1 + "',");
            }
            if (model.Manage_Type_Reserve2 != null)
            {
                strSql1.Append("Manage_Type_Reserve2,");
                strSql2.Append("'" + model.Manage_Type_Reserve2 + "',");
            }
            if (model.Manage_Type_Reserve3 != null)
            {
                strSql1.Append("Manage_Type_Reserve3,");
                strSql2.Append("'" + model.Manage_Type_Reserve3 + "',");
            }
            if (model.Manage_Type_Reserve4 != null)
            {
                strSql1.Append("Manage_Type_Reserve4,");
                strSql2.Append("'" + model.Manage_Type_Reserve4 + "',");
            }
            if (model.Manage_Type_Reserve5 != null)
            {
                strSql1.Append("Manage_Type_Reserve5,");
                strSql2.Append("'" + model.Manage_Type_Reserve5 + "',");
            }
            strSql.Append("insert into Manage_Type(");
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
        public bool Update(WMS_Database.Manage_TypeModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Manage_Type set ");
            if (model.Manage_Type_Code != null)
            {
                strSql.Append("Manage_Type_Code='" + model.Manage_Type_Code + "',");
            }
            if (model.Manage_Type_Name != null)
            {
                strSql.Append("Manage_Type_Name='" + model.Manage_Type_Name + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Name= null ,");
            }
            if (model.Manage_Type_InOut != null)
            {
                strSql.Append("Manage_Type_InOut='" + model.Manage_Type_InOut + "',");
            }
            else
            {
                strSql.Append("Manage_Type_InOut= null ,");
            }
            if (model.Manage_Type_Group != null)
            {
                strSql.Append("Manage_Type_Group='" + model.Manage_Type_Group + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Group= null ,");
            }
            if (model.Manage_Type_Remark != null)
            {
                strSql.Append("Manage_Type_Remark='" + model.Manage_Type_Remark + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Remark= null ,");
            }
            if (model.Manage_Type_Order != null)
            {
                strSql.Append("Manage_Type_Order=" + model.Manage_Type_Order + ",");
            }
            else
            {
                strSql.Append("Manage_Type_Order= null ,");
            }
            if (model.Manage_Type_Flag != null)
            {
                strSql.Append("Manage_Type_Flag='" + model.Manage_Type_Flag + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Flag= null ,");
            }
            if (model.Manage_Type_Reserve1 != null)
            {
                strSql.Append("Manage_Type_Reserve1='" + model.Manage_Type_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Reserve1= null ,");
            }
            if (model.Manage_Type_Reserve2 != null)
            {
                strSql.Append("Manage_Type_Reserve2='" + model.Manage_Type_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Reserve2= null ,");
            }
            if (model.Manage_Type_Reserve3 != null)
            {
                strSql.Append("Manage_Type_Reserve3='" + model.Manage_Type_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Reserve3= null ,");
            }
            if (model.Manage_Type_Reserve4 != null)
            {
                strSql.Append("Manage_Type_Reserve4='" + model.Manage_Type_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Reserve4= null ,");
            }
            if (model.Manage_Type_Reserve5 != null)
            {
                strSql.Append("Manage_Type_Reserve5='" + model.Manage_Type_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Manage_Type_ID='" + model.Manage_Type_ID + "' ");
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
        public bool Delete(string Manage_Type_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Manage_Type ");
            strSql.Append(" where Manage_Type_ID='" + Manage_Type_ID + "' ");
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
        public bool DeleteList(string Manage_Type_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Manage_Type ");
            strSql.Append(" where Manage_Type_ID in (" + Manage_Type_IDlist + ")  ");
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
        public WMS_Database.Manage_TypeModel GetModel(string Manage_Type_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Manage_Type_ID,Manage_Type_Code,Manage_Type_Name,Manage_Type_InOut,Manage_Type_Group,Manage_Type_Remark,Manage_Type_Order,Manage_Type_Flag,Manage_Type_Reserve1,Manage_Type_Reserve2,Manage_Type_Reserve3,Manage_Type_Reserve4,Manage_Type_Reserve5 ");
            strSql.Append(" from Manage_Type ");
            strSql.Append(" where Manage_Type_ID='" + Manage_Type_ID + "' ");
            WMS_Database.Manage_TypeModel model = new WMS_Database.Manage_TypeModel();
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
        public WMS_Database.Manage_TypeModel DataRowToModel(DataRow row)
        {
            WMS_Database.Manage_TypeModel model = new WMS_Database.Manage_TypeModel();
            if (row != null)
            {
                if (row["Manage_Type_ID"] != null)
                {
                    model.Manage_Type_ID = row["Manage_Type_ID"].ToString();
                }
                if (row["Manage_Type_Code"] != null)
                {
                    model.Manage_Type_Code = row["Manage_Type_Code"].ToString();
                }
                if (row["Manage_Type_Name"] != null)
                {
                    model.Manage_Type_Name = row["Manage_Type_Name"].ToString();
                }
                if (row["Manage_Type_InOut"] != null)
                {
                    model.Manage_Type_InOut = row["Manage_Type_InOut"].ToString();
                }
                if (row["Manage_Type_Group"] != null)
                {
                    model.Manage_Type_Group = row["Manage_Type_Group"].ToString();
                }
                if (row["Manage_Type_Remark"] != null)
                {
                    model.Manage_Type_Remark = row["Manage_Type_Remark"].ToString();
                }
                if (row["Manage_Type_Order"] != null && row["Manage_Type_Order"].ToString() != "")
                {
                    model.Manage_Type_Order = int.Parse(row["Manage_Type_Order"].ToString());
                }
                if (row["Manage_Type_Flag"] != null)
                {
                    model.Manage_Type_Flag = row["Manage_Type_Flag"].ToString();
                }
                if (row["Manage_Type_Reserve1"] != null)
                {
                    model.Manage_Type_Reserve1 = row["Manage_Type_Reserve1"].ToString();
                }
                if (row["Manage_Type_Reserve2"] != null)
                {
                    model.Manage_Type_Reserve2 = row["Manage_Type_Reserve2"].ToString();
                }
                if (row["Manage_Type_Reserve3"] != null)
                {
                    model.Manage_Type_Reserve3 = row["Manage_Type_Reserve3"].ToString();
                }
                if (row["Manage_Type_Reserve4"] != null)
                {
                    model.Manage_Type_Reserve4 = row["Manage_Type_Reserve4"].ToString();
                }
                if (row["Manage_Type_Reserve5"] != null)
                {
                    model.Manage_Type_Reserve5 = row["Manage_Type_Reserve5"].ToString();
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
            strSql.Append("select Manage_Type_ID,Manage_Type_Code,Manage_Type_Name,Manage_Type_InOut,Manage_Type_Group,Manage_Type_Remark,Manage_Type_Order,Manage_Type_Flag,Manage_Type_Reserve1,Manage_Type_Reserve2,Manage_Type_Reserve3,Manage_Type_Reserve4,Manage_Type_Reserve5 ");
            strSql.Append(" FROM Manage_Type ");
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
            strSql.Append(" Manage_Type_ID,Manage_Type_Code,Manage_Type_Name,Manage_Type_InOut,Manage_Type_Group,Manage_Type_Remark,Manage_Type_Order,Manage_Type_Flag,Manage_Type_Reserve1,Manage_Type_Reserve2,Manage_Type_Reserve3,Manage_Type_Reserve4,Manage_Type_Reserve5 ");
            strSql.Append(" FROM Manage_Type ");
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
            strSql.Append("select count(1) FROM Manage_Type ");
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
                strSql.Append("order by T.Manage_Type_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Manage_Type T ");
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

