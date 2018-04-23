using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// 数据访问类:ERP_Shelf_VG_VList
    /// </summary>
    public partial class ERP_Shelf_VG_VListDAL
    {
        public ERP_Shelf_VG_VListDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_Shelf_VG_VList_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERP_Shelf_VG_VList");
            strSql.Append(" where ERP_Shelf_VG_VList_ID='" + ERP_Shelf_VG_VList_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Aoyou_BusinessDB.ERP_Shelf_VG_VListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.ERP_Shelf_VG_VList_ID != null)
            {
                strSql1.Append("ERP_Shelf_VG_VList_ID,");
                strSql2.Append("'" + model.ERP_Shelf_VG_VList_ID + "',");
            }
            if (model.ERP_Shelf_VG_ID != null)
            {
                strSql1.Append("ERP_Shelf_VG_ID,");
                strSql2.Append("'" + model.ERP_Shelf_VG_ID + "',");
            }
            if (model.ERP_Shelf_VG_VList_Code != null)
            {
                strSql1.Append("ERP_Shelf_VG_VList_Code,");
                strSql2.Append("'" + model.ERP_Shelf_VG_VList_Code + "',");
            }
            if (model.ERP_Shelf_VG_VList_Name != null)
            {
                strSql1.Append("ERP_Shelf_VG_VList_Name,");
                strSql2.Append("'" + model.ERP_Shelf_VG_VList_Name + "',");
            }
            strSql.Append("insert into ERP_Shelf_VG_VList(");
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
        public bool Update(Aoyou_BusinessDB.ERP_Shelf_VG_VListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERP_Shelf_VG_VList set ");
            if (model.ERP_Shelf_VG_ID != null)
            {
                strSql.Append("ERP_Shelf_VG_ID='" + model.ERP_Shelf_VG_ID + "',");
            }
            else
            {
                strSql.Append("ERP_Shelf_VG_ID= null ,");
            }
            if (model.ERP_Shelf_VG_VList_Code != null)
            {
                strSql.Append("ERP_Shelf_VG_VList_Code='" + model.ERP_Shelf_VG_VList_Code + "',");
            }
            else
            {
                strSql.Append("ERP_Shelf_VG_VList_Code= null ,");
            }
            if (model.ERP_Shelf_VG_VList_Name != null)
            {
                strSql.Append("ERP_Shelf_VG_VList_Name='" + model.ERP_Shelf_VG_VList_Name + "',");
            }
            else
            {
                strSql.Append("ERP_Shelf_VG_VList_Name= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ERP_Shelf_VG_VList_ID='" + model.ERP_Shelf_VG_VList_ID + "' ");
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
        public bool Delete(string ERP_Shelf_VG_VList_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERP_Shelf_VG_VList ");
            strSql.Append(" where ERP_Shelf_VG_VList_ID='" + ERP_Shelf_VG_VList_ID + "' ");
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
        public bool DeleteList(string ERP_Shelf_VG_VList_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERP_Shelf_VG_VList ");
            strSql.Append(" where ERP_Shelf_VG_VList_ID in (" + ERP_Shelf_VG_VList_IDlist + ")  ");
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
        public Aoyou_BusinessDB.ERP_Shelf_VG_VListModel GetModel(string ERP_Shelf_VG_VList_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ERP_Shelf_VG_VList_ID,ERP_Shelf_VG_ID,ERP_Shelf_VG_VList_Code,ERP_Shelf_VG_VList_Name ");
            strSql.Append(" from ERP_Shelf_VG_VList ");
            strSql.Append(" where ERP_Shelf_VG_VList_ID='" + ERP_Shelf_VG_VList_ID + "' ");
            Aoyou_BusinessDB.ERP_Shelf_VG_VListModel model = new Aoyou_BusinessDB.ERP_Shelf_VG_VListModel();
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
        public Aoyou_BusinessDB.ERP_Shelf_VG_VListModel DataRowToModel(DataRow row)
        {
            Aoyou_BusinessDB.ERP_Shelf_VG_VListModel model = new Aoyou_BusinessDB.ERP_Shelf_VG_VListModel();
            if (row != null)
            {
                if (row["ERP_Shelf_VG_VList_ID"] != null)
                {
                    model.ERP_Shelf_VG_VList_ID = row["ERP_Shelf_VG_VList_ID"].ToString();
                }
                if (row["ERP_Shelf_VG_ID"] != null)
                {
                    model.ERP_Shelf_VG_ID = row["ERP_Shelf_VG_ID"].ToString();
                }
                if (row["ERP_Shelf_VG_VList_Code"] != null)
                {
                    model.ERP_Shelf_VG_VList_Code = row["ERP_Shelf_VG_VList_Code"].ToString();
                }
                if (row["ERP_Shelf_VG_VList_Name"] != null)
                {
                    model.ERP_Shelf_VG_VList_Name = row["ERP_Shelf_VG_VList_Name"].ToString();
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
            strSql.Append("select ERP_Shelf_VG_VList_ID,ERP_Shelf_VG_ID,ERP_Shelf_VG_VList_Code,ERP_Shelf_VG_VList_Name ");
            strSql.Append(" FROM ERP_Shelf_VG_VList ");
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
            strSql.Append(" ERP_Shelf_VG_VList_ID,ERP_Shelf_VG_ID,ERP_Shelf_VG_VList_Code,ERP_Shelf_VG_VList_Name ");
            strSql.Append(" FROM ERP_Shelf_VG_VList ");
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
            strSql.Append("select count(1) FROM ERP_Shelf_VG_VList ");
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
                strSql.Append("order by T.ERP_Shelf_VG_VList_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ERP_Shelf_VG_VList T ");
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

