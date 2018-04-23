using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// 数据访问类:ERP_WH_VG
    /// </summary>
    public partial class ERP_WH_VGDAL
    {
        public ERP_WH_VGDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_WH_VG_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERP_WH_VG");
            strSql.Append(" where ERP_WH_VG_ID='" + ERP_WH_VG_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Aoyou_BusinessDB.ERP_WH_VGModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.ERP_WH_VG_ID != null)
            {
                strSql1.Append("ERP_WH_VG_ID,");
                strSql2.Append("'" + model.ERP_WH_VG_ID + "',");
            }
            if (model.ERP_WH_ID != null)
            {
                strSql1.Append("ERP_WH_ID,");
                strSql2.Append("'" + model.ERP_WH_ID + "',");
            }
            if (model.ERP_WH_VG_Name != null)
            {
                strSql1.Append("ERP_WH_VG_Name,");
                strSql2.Append("'" + model.ERP_WH_VG_Name + "',");
            }
            if (model.ERP_WH_VG_Code != null)
            {
                strSql1.Append("ERP_WH_VG_Code,");
                strSql2.Append("'" + model.ERP_WH_VG_Code + "',");
            }
            if (model.ERP_WH_VG_Reserve1 != null)
            {
                strSql1.Append("ERP_WH_VG_Reserve1,");
                strSql2.Append("'" + model.ERP_WH_VG_Reserve1 + "',");
            }
            if (model.ERP_WH_VG_Reserve2 != null)
            {
                strSql1.Append("ERP_WH_VG_Reserve2,");
                strSql2.Append("'" + model.ERP_WH_VG_Reserve2 + "',");
            }
            strSql.Append("insert into ERP_WH_VG(");
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
        public bool Update(Aoyou_BusinessDB.ERP_WH_VGModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERP_WH_VG set ");
            if (model.ERP_WH_ID != null)
            {
                strSql.Append("ERP_WH_ID='" + model.ERP_WH_ID + "',");
            }
            else
            {
                strSql.Append("ERP_WH_ID= null ,");
            }
            if (model.ERP_WH_VG_Name != null)
            {
                strSql.Append("ERP_WH_VG_Name='" + model.ERP_WH_VG_Name + "',");
            }
            else
            {
                strSql.Append("ERP_WH_VG_Name= null ,");
            }
            if (model.ERP_WH_VG_Code != null)
            {
                strSql.Append("ERP_WH_VG_Code='" + model.ERP_WH_VG_Code + "',");
            }
            else
            {
                strSql.Append("ERP_WH_VG_Code= null ,");
            }
            if (model.ERP_WH_VG_Reserve1 != null)
            {
                strSql.Append("ERP_WH_VG_Reserve1='" + model.ERP_WH_VG_Reserve1 + "',");
            }
            else
            {
                strSql.Append("ERP_WH_VG_Reserve1= null ,");
            }
            if (model.ERP_WH_VG_Reserve2 != null)
            {
                strSql.Append("ERP_WH_VG_Reserve2='" + model.ERP_WH_VG_Reserve2 + "',");
            }
            else
            {
                strSql.Append("ERP_WH_VG_Reserve2= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ERP_WH_VG_ID='" + model.ERP_WH_VG_ID + "' ");
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
        public bool Delete(string ERP_WH_VG_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERP_WH_VG ");
            strSql.Append(" where ERP_WH_VG_ID='" + ERP_WH_VG_ID + "' ");
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
        public bool DeleteList(string ERP_WH_VG_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERP_WH_VG ");
            strSql.Append(" where ERP_WH_VG_ID in (" + ERP_WH_VG_IDlist + ")  ");
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
        public Aoyou_BusinessDB.ERP_WH_VGModel GetModel(string ERP_WH_VG_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ERP_WH_VG_ID,ERP_WH_ID,ERP_WH_VG_Name,ERP_WH_VG_Code,ERP_WH_VG_Reserve1,ERP_WH_VG_Reserve2 ");
            strSql.Append(" from ERP_WH_VG ");
            strSql.Append(" where ERP_WH_VG_ID='" + ERP_WH_VG_ID + "' ");
            Aoyou_BusinessDB.ERP_WH_VGModel model = new Aoyou_BusinessDB.ERP_WH_VGModel();
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
        public Aoyou_BusinessDB.ERP_WH_VGModel DataRowToModel(DataRow row)
        {
            Aoyou_BusinessDB.ERP_WH_VGModel model = new Aoyou_BusinessDB.ERP_WH_VGModel();
            if (row != null)
            {
                if (row["ERP_WH_VG_ID"] != null)
                {
                    model.ERP_WH_VG_ID = row["ERP_WH_VG_ID"].ToString();
                }
                if (row["ERP_WH_ID"] != null)
                {
                    model.ERP_WH_ID = row["ERP_WH_ID"].ToString();
                }
                if (row["ERP_WH_VG_Name"] != null)
                {
                    model.ERP_WH_VG_Name = row["ERP_WH_VG_Name"].ToString();
                }
                if (row["ERP_WH_VG_Code"] != null)
                {
                    model.ERP_WH_VG_Code = row["ERP_WH_VG_Code"].ToString();
                }
                if (row["ERP_WH_VG_Reserve1"] != null)
                {
                    model.ERP_WH_VG_Reserve1 = row["ERP_WH_VG_Reserve1"].ToString();
                }
                if (row["ERP_WH_VG_Reserve2"] != null)
                {
                    model.ERP_WH_VG_Reserve2 = row["ERP_WH_VG_Reserve2"].ToString();
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
            strSql.Append("select ERP_WH_VG_ID,ERP_WH_ID,ERP_WH_VG_Name,ERP_WH_VG_Code,ERP_WH_VG_Reserve1,ERP_WH_VG_Reserve2 ");
            strSql.Append(" FROM ERP_WH_VG ");
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
            strSql.Append(" ERP_WH_VG_ID,ERP_WH_ID,ERP_WH_VG_Name,ERP_WH_VG_Code,ERP_WH_VG_Reserve1,ERP_WH_VG_Reserve2 ");
            strSql.Append(" FROM ERP_WH_VG ");
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
            strSql.Append("select count(1) FROM ERP_WH_VG ");
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
                strSql.Append("order by T.ERP_WH_VG_ID desc");
            }
            strSql.Append(")AS Row, T.*  from ERP_WH_VG T ");
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

