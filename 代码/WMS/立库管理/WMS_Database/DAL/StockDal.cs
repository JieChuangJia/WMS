using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:StockDal
	/// </summary>
	public partial class StockDal
	{
        public StockDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Stock_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Stock");
            strSql.Append(" where Stock_ID='" + Stock_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.StockModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Stock_ID != null)
            {
                strSql1.Append("Stock_ID,");
                strSql2.Append("'" + model.Stock_ID + "',");
            }
            if (model.Cell_Child_ID != null)
            {
                strSql1.Append("Cell_Child_ID,");
                strSql2.Append("'" + model.Cell_Child_ID + "',");
            }
            if (model.Stock_Tray_Barcode != null)
            {
                strSql1.Append("Stock_Tray_Barcode,");
                strSql2.Append("'" + model.Stock_Tray_Barcode + "',");
            }
            if (model.Stock_Full_Flag != null)
            {
                strSql1.Append("Stock_Full_Flag,");
                strSql2.Append("'" + model.Stock_Full_Flag + "',");
            }
            if (model.Stock_Remark != null)
            {
                strSql1.Append("Stock_Remark,");
                strSql2.Append("'" + model.Stock_Remark + "',");
            }
            if (model.Stock_Reserve1 != null)
            {
                strSql1.Append("Stock_Reserve1,");
                strSql2.Append("'" + model.Stock_Reserve1 + "',");
            }
            if (model.Stock_Reserve2 != null)
            {
                strSql1.Append("Stock_Reserve2,");
                strSql2.Append("'" + model.Stock_Reserve2 + "',");
            }
            if (model.Stock_Reserve3 != null)
            {
                strSql1.Append("Stock_Reserve3,");
                strSql2.Append("'" + model.Stock_Reserve3 + "',");
            }
            if (model.Stock_Reserve4 != null)
            {
                strSql1.Append("Stock_Reserve4,");
                strSql2.Append("'" + model.Stock_Reserve4 + "',");
            }
            if (model.Stock_Reserve5 != null)
            {
                strSql1.Append("Stock_Reserve5,");
                strSql2.Append("'" + model.Stock_Reserve5 + "',");
            }
            strSql.Append("insert into Stock(");
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
        public bool Update(WMS_Database.StockModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stock set ");
            if (model.Cell_Child_ID != null)
            {
                strSql.Append("Cell_Child_ID='" + model.Cell_Child_ID + "',");
            }
            else
            {
                strSql.Append("Cell_Child_ID= null ,");
            }
            if (model.Stock_Tray_Barcode != null)
            {
                strSql.Append("Stock_Tray_Barcode='" + model.Stock_Tray_Barcode + "',");
            }
            else
            {
                strSql.Append("Stock_Tray_Barcode= null ,");
            }
            if (model.Stock_Full_Flag != null)
            {
                strSql.Append("Stock_Full_Flag='" + model.Stock_Full_Flag + "',");
            }
            else
            {
                strSql.Append("Stock_Full_Flag= null ,");
            }
            if (model.Stock_Remark != null)
            {
                strSql.Append("Stock_Remark='" + model.Stock_Remark + "',");
            }
            else
            {
                strSql.Append("Stock_Remark= null ,");
            }
            if (model.Stock_Reserve1 != null)
            {
                strSql.Append("Stock_Reserve1='" + model.Stock_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Stock_Reserve1= null ,");
            }
            if (model.Stock_Reserve2 != null)
            {
                strSql.Append("Stock_Reserve2='" + model.Stock_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Stock_Reserve2= null ,");
            }
            if (model.Stock_Reserve3 != null)
            {
                strSql.Append("Stock_Reserve3='" + model.Stock_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Stock_Reserve3= null ,");
            }
            if (model.Stock_Reserve4 != null)
            {
                strSql.Append("Stock_Reserve4='" + model.Stock_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Stock_Reserve4= null ,");
            }
            if (model.Stock_Reserve5 != null)
            {
                strSql.Append("Stock_Reserve5='" + model.Stock_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Stock_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Stock_ID='" + model.Stock_ID + "' ");
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
        public bool Delete(string Stock_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Stock ");
            strSql.Append(" where Stock_ID='" + Stock_ID + "' ");
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
        public bool DeleteList(string Stock_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Stock ");
            strSql.Append(" where Stock_ID in (" + Stock_IDlist + ")  ");
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
        public WMS_Database.StockModel GetModel(string Stock_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Stock_ID,Cell_Child_ID,Stock_Tray_Barcode,Stock_Full_Flag,Stock_Remark,Stock_Reserve1,Stock_Reserve2,Stock_Reserve3,Stock_Reserve4,Stock_Reserve5 ");
            strSql.Append(" from Stock ");
            strSql.Append(" where Stock_ID='" + Stock_ID + "' ");
            WMS_Database.StockModel model = new WMS_Database.StockModel();
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
        public WMS_Database.StockModel DataRowToModel(DataRow row)
        {
            WMS_Database.StockModel model = new WMS_Database.StockModel();
            if (row != null)
            {
                if (row["Stock_ID"] != null)
                {
                    model.Stock_ID = row["Stock_ID"].ToString();
                }
                if (row["Cell_Child_ID"] != null)
                {
                    model.Cell_Child_ID = row["Cell_Child_ID"].ToString();
                }
                if (row["Stock_Tray_Barcode"] != null)
                {
                    model.Stock_Tray_Barcode = row["Stock_Tray_Barcode"].ToString();
                }
                if (row["Stock_Full_Flag"] != null)
                {
                    model.Stock_Full_Flag = row["Stock_Full_Flag"].ToString();
                }
                if (row["Stock_Remark"] != null)
                {
                    model.Stock_Remark = row["Stock_Remark"].ToString();
                }
                if (row["Stock_Reserve1"] != null)
                {
                    model.Stock_Reserve1 = row["Stock_Reserve1"].ToString();
                }
                if (row["Stock_Reserve2"] != null)
                {
                    model.Stock_Reserve2 = row["Stock_Reserve2"].ToString();
                }
                if (row["Stock_Reserve3"] != null)
                {
                    model.Stock_Reserve3 = row["Stock_Reserve3"].ToString();
                }
                if (row["Stock_Reserve4"] != null)
                {
                    model.Stock_Reserve4 = row["Stock_Reserve4"].ToString();
                }
                if (row["Stock_Reserve5"] != null)
                {
                    model.Stock_Reserve5 = row["Stock_Reserve5"].ToString();
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
            strSql.Append("select Stock_ID,Cell_Child_ID,Stock_Tray_Barcode,Stock_Full_Flag,Stock_Remark,Stock_Reserve1,Stock_Reserve2,Stock_Reserve3,Stock_Reserve4,Stock_Reserve5 ");
            strSql.Append(" FROM Stock ");
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
            strSql.Append(" Stock_ID,Cell_Child_ID,Stock_Tray_Barcode,Stock_Full_Flag,Stock_Remark,Stock_Reserve1,Stock_Reserve2,Stock_Reserve3,Stock_Reserve4,Stock_Reserve5 ");
            strSql.Append(" FROM Stock ");
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
            strSql.Append("select count(1) FROM Stock ");
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
                strSql.Append("order by T.Stock_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Stock T ");
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

