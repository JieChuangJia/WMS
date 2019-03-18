using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database.DAL
{
    /// <summary>
    /// 数据访问类:Goods_Supplier
    /// </summary>
    public partial class Goods_SupplierDAL
    {
        public Goods_SupplierDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_Supplier_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Goods_Supplier");
            strSql.Append(" where Goods_Supplier_ID='" + Goods_Supplier_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Goods_SupplierModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Goods_Supplier_ID != null)
            {
                strSql1.Append("Goods_Supplier_ID,");
                strSql2.Append("'" + model.Goods_Supplier_ID + "',");
            }
            if (model.Goods_Supplier_Name != null)
            {
                strSql1.Append("Goods_Supplier_Name,");
                strSql2.Append("'" + model.Goods_Supplier_Name + "',");
            }
            if (model.Goods_Supplier_Code != null)
            {
                strSql1.Append("Goods_Supplier_Code,");
                strSql2.Append("'" + model.Goods_Supplier_Code + "',");
            }
            if (model.Goods_Supplier_Telephone != null)
            {
                strSql1.Append("Goods_Supplier_Telephone,");
                strSql2.Append("'" + model.Goods_Supplier_Telephone + "',");
            }
            if (model.Goods_Supplier_Addr != null)
            {
                strSql1.Append("Goods_Supplier_Addr,");
                strSql2.Append("'" + model.Goods_Supplier_Addr + "',");
            }
            if (model.Goods_Supplier_Remark != null)
            {
                strSql1.Append("Goods_Supplier_Remark,");
                strSql2.Append("'" + model.Goods_Supplier_Remark + "',");
            }
            strSql.Append("insert into Goods_Supplier(");
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
        public bool Update(WMS_Database.Goods_SupplierModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Goods_Supplier set ");
            if (model.Goods_Supplier_Name != null)
            {
                strSql.Append("Goods_Supplier_Name='" + model.Goods_Supplier_Name + "',");
            }
            if (model.Goods_Supplier_Code != null)
            {
                strSql.Append("Goods_Supplier_Code='" + model.Goods_Supplier_Code + "',");
            }
            if (model.Goods_Supplier_Telephone != null)
            {
                strSql.Append("Goods_Supplier_Telephone='" + model.Goods_Supplier_Telephone + "',");
            }
            else
            {
                strSql.Append("Goods_Supplier_Telephone= null ,");
            }
            if (model.Goods_Supplier_Addr != null)
            {
                strSql.Append("Goods_Supplier_Addr='" + model.Goods_Supplier_Addr + "',");
            }
            else
            {
                strSql.Append("Goods_Supplier_Addr= null ,");
            }
            if (model.Goods_Supplier_Remark != null)
            {
                strSql.Append("Goods_Supplier_Remark='" + model.Goods_Supplier_Remark + "',");
            }
            else
            {
                strSql.Append("Goods_Supplier_Remark= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Goods_Supplier_ID='" + model.Goods_Supplier_ID + "' ");
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
        public bool Delete(string Goods_Supplier_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Supplier ");
            strSql.Append(" where Goods_Supplier_ID='" + Goods_Supplier_ID + "' ");
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
        public bool DeleteList(string Goods_Supplier_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Supplier ");
            strSql.Append(" where Goods_Supplier_ID in (" + Goods_Supplier_IDlist + ")  ");
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
        public WMS_Database.Goods_SupplierModel GetModel(string Goods_Supplier_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Goods_Supplier_ID,Goods_Supplier_Name,Goods_Supplier_Code,Goods_Supplier_Telephone,Goods_Supplier_Addr,Goods_Supplier_Remark ");
            strSql.Append(" from Goods_Supplier ");
            strSql.Append(" where Goods_Supplier_ID='" + Goods_Supplier_ID + "' ");
            WMS_Database.Goods_SupplierModel model = new WMS_Database.Goods_SupplierModel();
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
        public WMS_Database.Goods_SupplierModel DataRowToModel(DataRow row)
        {
            WMS_Database.Goods_SupplierModel model = new WMS_Database.Goods_SupplierModel();
            if (row != null)
            {
                if (row["Goods_Supplier_ID"] != null)
                {
                    model.Goods_Supplier_ID = row["Goods_Supplier_ID"].ToString();
                }
                if (row["Goods_Supplier_Name"] != null)
                {
                    model.Goods_Supplier_Name = row["Goods_Supplier_Name"].ToString();
                }
                if (row["Goods_Supplier_Code"] != null)
                {
                    model.Goods_Supplier_Code = row["Goods_Supplier_Code"].ToString();
                }
                if (row["Goods_Supplier_Telephone"] != null)
                {
                    model.Goods_Supplier_Telephone = row["Goods_Supplier_Telephone"].ToString();
                }
                if (row["Goods_Supplier_Addr"] != null)
                {
                    model.Goods_Supplier_Addr = row["Goods_Supplier_Addr"].ToString();
                }
                if (row["Goods_Supplier_Remark"] != null)
                {
                    model.Goods_Supplier_Remark = row["Goods_Supplier_Remark"].ToString();
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
            strSql.Append("select Goods_Supplier_ID,Goods_Supplier_Name,Goods_Supplier_Code,Goods_Supplier_Telephone,Goods_Supplier_Addr,Goods_Supplier_Remark ");
            strSql.Append(" FROM Goods_Supplier ");
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
            strSql.Append(" Goods_Supplier_ID,Goods_Supplier_Name,Goods_Supplier_Code,Goods_Supplier_Telephone,Goods_Supplier_Addr,Goods_Supplier_Remark ");
            strSql.Append(" FROM Goods_Supplier ");
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
            strSql.Append("select count(1) FROM Goods_Supplier ");
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
                strSql.Append("order by T.Goods_Supplier_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Goods_Supplier T ");
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
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByCode(string supplier_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Supplier ");
            strSql.Append(" where [Goods_Supplier_Code]='" + supplier_Code + "' ");
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
        #endregion  MethodEx
    }
}

