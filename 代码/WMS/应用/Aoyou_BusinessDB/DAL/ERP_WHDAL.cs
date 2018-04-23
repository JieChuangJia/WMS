using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// 数据访问类:ERP_WH
    /// </summary>
    public partial class ERP_WHDAL
    {
        public ERP_WHDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_WH_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERP_WH");
            strSql.Append(" where ERP_WH_ID='" + ERP_WH_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Aoyou_BusinessDB.ERP_WHModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.ERP_WH_ID != null)
            {
                strSql1.Append("ERP_WH_ID,");
                strSql2.Append("'" + model.ERP_WH_ID + "',");
            }
            if (model.ERP_WH_CreateGroup != null)
            {
                strSql1.Append("ERP_WH_CreateGroup,");
                strSql2.Append("'" + model.ERP_WH_CreateGroup + "',");
            }
            if (model.ERP_WH_UseGroup != null)
            {
                strSql1.Append("ERP_WH_UseGroup,");
                strSql2.Append("'" + model.ERP_WH_UseGroup + "',");
            }
            if (model.ERP_WH_Name != null)
            {
                strSql1.Append("ERP_WH_Name,");
                strSql2.Append("'" + model.ERP_WH_Name + "',");
            }
            if (model.ERP_WH_Code != null)
            {
                strSql1.Append("ERP_WH_Code,");
                strSql2.Append("'" + model.ERP_WH_Code + "',");
            }
            if (model.ERP_WH_Property != null)
            {
                strSql1.Append("ERP_WH_Property,");
                strSql2.Append("'" + model.ERP_WH_Property + "',");
            }
            if (model.ERP_WH_Default_Status != null)
            {
                strSql1.Append("ERP_WH_Default_Status,");
                strSql2.Append("'" + model.ERP_WH_Default_Status + "',");
            }
            if (model.ERP_WH_Enabled != null)
            {
                strSql1.Append("ERP_WH_Enabled,");
                strSql2.Append("'" + model.ERP_WH_Enabled + "',");
            }
            if (model.ERP_WH_Reserve1 != null)
            {
                strSql1.Append("ERP_WH_Reserve1,");
                strSql2.Append("'" + model.ERP_WH_Reserve1 + "',");
            }
            if (model.ERP_WH_Reserve2 != null)
            {
                strSql1.Append("ERP_WH_Reserve2,");
                strSql2.Append("'" + model.ERP_WH_Reserve2 + "',");
            }
            if (model.ERP_WH_Reserve3 != null)
            {
                strSql1.Append("ERP_WH_Reserve3,");
                strSql2.Append("'" + model.ERP_WH_Reserve3 + "',");
            }
            if (model.ERP_WH_Reserve4 != null)
            {
                strSql1.Append("ERP_WH_Reserve4,");
                strSql2.Append("'" + model.ERP_WH_Reserve4 + "',");
            }
            if (model.ERP_WH_Reserve5 != null)
            {
                strSql1.Append("ERP_WH_Reserve5,");
                strSql2.Append("'" + model.ERP_WH_Reserve5 + "',");
            }
            strSql.Append("insert into ERP_WH(");
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
        public bool Update(Aoyou_BusinessDB.ERP_WHModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERP_WH set ");
            if (model.ERP_WH_CreateGroup != null)
            {
                strSql.Append("ERP_WH_CreateGroup='" + model.ERP_WH_CreateGroup + "',");
            }
            else
            {
                strSql.Append("ERP_WH_CreateGroup= null ,");
            }
            if (model.ERP_WH_UseGroup != null)
            {
                strSql.Append("ERP_WH_UseGroup='" + model.ERP_WH_UseGroup + "',");
            }
            else
            {
                strSql.Append("ERP_WH_UseGroup= null ,");
            }
            if (model.ERP_WH_Name != null)
            {
                strSql.Append("ERP_WH_Name='" + model.ERP_WH_Name + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Name= null ,");
            }
            if (model.ERP_WH_Code != null)
            {
                strSql.Append("ERP_WH_Code='" + model.ERP_WH_Code + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Code= null ,");
            }
            if (model.ERP_WH_Property != null)
            {
                strSql.Append("ERP_WH_Property='" + model.ERP_WH_Property + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Property= null ,");
            }
            if (model.ERP_WH_Default_Status != null)
            {
                strSql.Append("ERP_WH_Default_Status='" + model.ERP_WH_Default_Status + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Default_Status= null ,");
            }
            if (model.ERP_WH_Enabled != null)
            {
                strSql.Append("ERP_WH_Enabled='" + model.ERP_WH_Enabled + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Enabled= null ,");
            }
            if (model.ERP_WH_Reserve1 != null)
            {
                strSql.Append("ERP_WH_Reserve1='" + model.ERP_WH_Reserve1 + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Reserve1= null ,");
            }
            if (model.ERP_WH_Reserve2 != null)
            {
                strSql.Append("ERP_WH_Reserve2='" + model.ERP_WH_Reserve2 + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Reserve2= null ,");
            }
            if (model.ERP_WH_Reserve3 != null)
            {
                strSql.Append("ERP_WH_Reserve3='" + model.ERP_WH_Reserve3 + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Reserve3= null ,");
            }
            if (model.ERP_WH_Reserve4 != null)
            {
                strSql.Append("ERP_WH_Reserve4='" + model.ERP_WH_Reserve4 + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Reserve4= null ,");
            }
            if (model.ERP_WH_Reserve5 != null)
            {
                strSql.Append("ERP_WH_Reserve5='" + model.ERP_WH_Reserve5 + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ERP_WH_ID='" + model.ERP_WH_ID + "' ");
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
        public bool Delete(string ERP_WH_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERP_WH ");
            strSql.Append(" where ERP_WH_ID='" + ERP_WH_ID + "' ");
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
        public bool DeleteList(string ERP_WH_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERP_WH ");
            strSql.Append(" where ERP_WH_ID in (" + ERP_WH_IDlist + ")  ");
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
        public Aoyou_BusinessDB.ERP_WHModel GetModel(string ERP_WH_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ERP_WH_ID,ERP_WH_CreateGroup,ERP_WH_UseGroup,ERP_WH_Name,ERP_WH_Code,ERP_WH_Property,ERP_WH_Default_Status,ERP_WH_Enabled,ERP_WH_Reserve1,ERP_WH_Reserve2,ERP_WH_Reserve3,ERP_WH_Reserve4,ERP_WH_Reserve5 ");
            strSql.Append(" from ERP_WH ");
            strSql.Append(" where ERP_WH_ID='" + ERP_WH_ID + "' ");
            Aoyou_BusinessDB.ERP_WHModel model = new Aoyou_BusinessDB.ERP_WHModel();
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
        public Aoyou_BusinessDB.ERP_WHModel DataRowToModel(DataRow row)
        {
            Aoyou_BusinessDB.ERP_WHModel model = new Aoyou_BusinessDB.ERP_WHModel();
            if (row != null)
            {
                if (row["ERP_WH_ID"] != null)
                {
                    model.ERP_WH_ID = row["ERP_WH_ID"].ToString();
                }
                if (row["ERP_WH_CreateGroup"] != null)
                {
                    model.ERP_WH_CreateGroup = row["ERP_WH_CreateGroup"].ToString();
                }
                if (row["ERP_WH_UseGroup"] != null)
                {
                    model.ERP_WH_UseGroup = row["ERP_WH_UseGroup"].ToString();
                }
                if (row["ERP_WH_Name"] != null)
                {
                    model.ERP_WH_Name = row["ERP_WH_Name"].ToString();
                }
                if (row["ERP_WH_Code"] != null)
                {
                    model.ERP_WH_Code = row["ERP_WH_Code"].ToString();
                }
                if (row["ERP_WH_Property"] != null)
                {
                    model.ERP_WH_Property = row["ERP_WH_Property"].ToString();
                }
                if (row["ERP_WH_Default_Status"] != null)
                {
                    model.ERP_WH_Default_Status = row["ERP_WH_Default_Status"].ToString();
                }
                if (row["ERP_WH_Enabled"] != null)
                {
                    model.ERP_WH_Enabled = row["ERP_WH_Enabled"].ToString();
                }
                if (row["ERP_WH_Reserve1"] != null)
                {
                    model.ERP_WH_Reserve1 = row["ERP_WH_Reserve1"].ToString();
                }
                if (row["ERP_WH_Reserve2"] != null)
                {
                    model.ERP_WH_Reserve2 = row["ERP_WH_Reserve2"].ToString();
                }
                if (row["ERP_WH_Reserve3"] != null)
                {
                    model.ERP_WH_Reserve3 = row["ERP_WH_Reserve3"].ToString();
                }
                if (row["ERP_WH_Reserve4"] != null)
                {
                    model.ERP_WH_Reserve4 = row["ERP_WH_Reserve4"].ToString();
                }
                if (row["ERP_WH_Reserve5"] != null)
                {
                    model.ERP_WH_Reserve5 = row["ERP_WH_Reserve5"].ToString();
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
            strSql.Append("select ERP_WH_ID,ERP_WH_CreateGroup,ERP_WH_UseGroup,ERP_WH_Name,ERP_WH_Code,ERP_WH_Property,ERP_WH_Default_Status,ERP_WH_Enabled,ERP_WH_Reserve1,ERP_WH_Reserve2,ERP_WH_Reserve3,ERP_WH_Reserve4,ERP_WH_Reserve5 ");
            strSql.Append(" FROM ERP_WH ");
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
            strSql.Append(" ERP_WH_ID,ERP_WH_CreateGroup,ERP_WH_UseGroup,ERP_WH_Name,ERP_WH_Code,ERP_WH_Property,ERP_WH_Default_Status,ERP_WH_Enabled,ERP_WH_Reserve1,ERP_WH_Reserve2,ERP_WH_Reserve3,ERP_WH_Reserve4,ERP_WH_Reserve5 ");
            strSql.Append(" FROM ERP_WH ");
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
            strSql.Append("select count(1) FROM ERP_WH ");
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
                strSql.Append("order by T.ERP_WH_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ERP_WH T ");
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

