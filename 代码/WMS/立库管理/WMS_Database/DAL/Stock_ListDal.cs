using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:Stock_ListDal
	/// </summary>
	public partial class Stock_ListDal
	{
        public Stock_ListDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Stock_List_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Stock_List");
            strSql.Append(" where Stock_List_ID='" + Stock_List_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Stock_ListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Stock_List_ID != null)
            {
                strSql1.Append("Stock_List_ID,");
                strSql2.Append("'" + model.Stock_List_ID + "',");
            }
            if (model.Stock_ID != null)
            {
                strSql1.Append("Stock_ID,");
                strSql2.Append("'" + model.Stock_ID + "',");
            }
            if (model.Plan_List_ID != null)
            {
                strSql1.Append("Plan_List_ID,");
                strSql2.Append("'" + model.Plan_List_ID + "',");
            }
            if (model.Goods_ID != null)
            {
                strSql1.Append("Goods_ID,");
                strSql2.Append("'" + model.Goods_ID + "',");
            }
            if (model.Stock_List_Box_Barcode != null)
            {
                strSql1.Append("Stock_List_Box_Barcode,");
                strSql2.Append("'" + model.Stock_List_Box_Barcode + "',");
            }
            if (model.Stock_List_Quantity != null)
            {
                strSql1.Append("Stock_List_Quantity,");
                strSql2.Append("'" + model.Stock_List_Quantity + "',");
            }
            if (model.Stock_List_Entry_Time != null)
            {
                strSql1.Append("Stock_List_Entry_Time,");
                strSql2.Append("'" + model.Stock_List_Entry_Time + "',");
            }
            if (model.Stock_List_Update_Time != null)
            {
                strSql1.Append("Stock_List_Update_Time,");
                strSql2.Append("'" + model.Stock_List_Update_Time + "',");
            }
            if (model.Stock_List_Remark != null)
            {
                strSql1.Append("Stock_List_Remark,");
                strSql2.Append("'" + model.Stock_List_Remark + "',");
            }
            if (model.Stock_List_Reserve1 != null)
            {
                strSql1.Append("Stock_List_Reserve1,");
                strSql2.Append("'" + model.Stock_List_Reserve1 + "',");
            }
            if (model.Stock_List_Reserve2 != null)
            {
                strSql1.Append("Stock_List_Reserve2,");
                strSql2.Append("'" + model.Stock_List_Reserve2 + "',");
            }
            if (model.Stock_List_Reserve3 != null)
            {
                strSql1.Append("Stock_List_Reserve3,");
                strSql2.Append("'" + model.Stock_List_Reserve3 + "',");
            }
            if (model.Stock_List_Reserve4 != null)
            {
                strSql1.Append("Stock_List_Reserve4,");
                strSql2.Append("'" + model.Stock_List_Reserve4 + "',");
            }
            if (model.Stock_List_Reserve5 != null)
            {
                strSql1.Append("Stock_List_Reserve5,");
                strSql2.Append("'" + model.Stock_List_Reserve5 + "',");
            }
            strSql.Append("insert into Stock_List(");
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
        public bool Update(WMS_Database.Stock_ListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stock_List set ");
            if (model.Stock_ID != null)
            {
                strSql.Append("Stock_ID='" + model.Stock_ID + "',");
            }
            else
            {
                strSql.Append("Stock_ID= null ,");
            }
            if (model.Plan_List_ID != null)
            {
                strSql.Append("Plan_List_ID='" + model.Plan_List_ID + "',");
            }
            else
            {
                strSql.Append("Plan_List_ID= null ,");
            }
            if (model.Goods_ID != null)
            {
                strSql.Append("Goods_ID='" + model.Goods_ID + "',");
            }
            else
            {
                strSql.Append("Goods_ID= null ,");
            }
            if (model.Stock_List_Box_Barcode != null)
            {
                strSql.Append("Stock_List_Box_Barcode='" + model.Stock_List_Box_Barcode + "',");
            }
            else
            {
                strSql.Append("Stock_List_Box_Barcode= null ,");
            }
            if (model.Stock_List_Quantity != null)
            {
                strSql.Append("Stock_List_Quantity='" + model.Stock_List_Quantity + "',");
            }
            else
            {
                strSql.Append("Stock_List_Quantity= null ,");
            }
            if (model.Stock_List_Entry_Time != null)
            {
                strSql.Append("Stock_List_Entry_Time='" + model.Stock_List_Entry_Time + "',");
            }
            else
            {
                strSql.Append("Stock_List_Entry_Time= null ,");
            }
            if (model.Stock_List_Update_Time != null)
            {
                strSql.Append("Stock_List_Update_Time='" + model.Stock_List_Update_Time + "',");
            }
            else
            {
                strSql.Append("Stock_List_Update_Time= null ,");
            }
            if (model.Stock_List_Remark != null)
            {
                strSql.Append("Stock_List_Remark='" + model.Stock_List_Remark + "',");
            }
            else
            {
                strSql.Append("Stock_List_Remark= null ,");
            }
            if (model.Stock_List_Reserve1 != null)
            {
                strSql.Append("Stock_List_Reserve1='" + model.Stock_List_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Stock_List_Reserve1= null ,");
            }
            if (model.Stock_List_Reserve2 != null)
            {
                strSql.Append("Stock_List_Reserve2='" + model.Stock_List_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Stock_List_Reserve2= null ,");
            }
            if (model.Stock_List_Reserve3 != null)
            {
                strSql.Append("Stock_List_Reserve3='" + model.Stock_List_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Stock_List_Reserve3= null ,");
            }
            if (model.Stock_List_Reserve4 != null)
            {
                strSql.Append("Stock_List_Reserve4='" + model.Stock_List_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Stock_List_Reserve4= null ,");
            }
            if (model.Stock_List_Reserve5 != null)
            {
                strSql.Append("Stock_List_Reserve5='" + model.Stock_List_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Stock_List_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Stock_List_ID='" + model.Stock_List_ID + "' ");
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
        public bool Delete(string Stock_List_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Stock_List ");
            strSql.Append(" where Stock_List_ID='" + Stock_List_ID + "' ");
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
        public bool DeleteList(string Stock_List_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Stock_List ");
            strSql.Append(" where Stock_List_ID in (" + Stock_List_IDlist + ")  ");
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
        public WMS_Database.Stock_ListModel GetModel(string Stock_List_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Stock_List_ID,Stock_ID,Plan_List_ID,Goods_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Stock_List_Reserve1,Stock_List_Reserve2,Stock_List_Reserve3,Stock_List_Reserve4,Stock_List_Reserve5 ");
            strSql.Append(" from Stock_List ");
            strSql.Append(" where Stock_List_ID='" + Stock_List_ID + "' ");
            WMS_Database.Stock_ListModel model = new WMS_Database.Stock_ListModel();
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
        public WMS_Database.Stock_ListModel DataRowToModel(DataRow row)
        {
            WMS_Database.Stock_ListModel model = new WMS_Database.Stock_ListModel();
            if (row != null)
            {
                if (row["Stock_List_ID"] != null)
                {
                    model.Stock_List_ID = row["Stock_List_ID"].ToString();
                }
                if (row["Stock_ID"] != null)
                {
                    model.Stock_ID = row["Stock_ID"].ToString();
                }
                if (row["Plan_List_ID"] != null)
                {
                    model.Plan_List_ID = row["Plan_List_ID"].ToString();
                }
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
                }
                if (row["Stock_List_Box_Barcode"] != null)
                {
                    model.Stock_List_Box_Barcode = row["Stock_List_Box_Barcode"].ToString();
                }
                if (row["Stock_List_Quantity"] != null)
                {
                    model.Stock_List_Quantity = row["Stock_List_Quantity"].ToString();
                }
                if (row["Stock_List_Entry_Time"] != null && row["Stock_List_Entry_Time"].ToString() != "")
                {
                    model.Stock_List_Entry_Time = DateTime.Parse(row["Stock_List_Entry_Time"].ToString());
                }
                if (row["Stock_List_Update_Time"] != null && row["Stock_List_Update_Time"].ToString() != "")
                {
                    model.Stock_List_Update_Time = DateTime.Parse(row["Stock_List_Update_Time"].ToString());
                }
                if (row["Stock_List_Remark"] != null)
                {
                    model.Stock_List_Remark = row["Stock_List_Remark"].ToString();
                }
                if (row["Stock_List_Reserve1"] != null)
                {
                    model.Stock_List_Reserve1 = row["Stock_List_Reserve1"].ToString();
                }
                if (row["Stock_List_Reserve2"] != null)
                {
                    model.Stock_List_Reserve2 = row["Stock_List_Reserve2"].ToString();
                }
                if (row["Stock_List_Reserve3"] != null)
                {
                    model.Stock_List_Reserve3 = row["Stock_List_Reserve3"].ToString();
                }
                if (row["Stock_List_Reserve4"] != null)
                {
                    model.Stock_List_Reserve4 = row["Stock_List_Reserve4"].ToString();
                }
                if (row["Stock_List_Reserve5"] != null)
                {
                    model.Stock_List_Reserve5 = row["Stock_List_Reserve5"].ToString();
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
            strSql.Append("select Stock_List_ID,Stock_ID,Plan_List_ID,Goods_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Stock_List_Reserve1,Stock_List_Reserve2,Stock_List_Reserve3,Stock_List_Reserve4,Stock_List_Reserve5 ");
            strSql.Append(" FROM Stock_List ");
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
            strSql.Append(" Stock_List_ID,Stock_ID,Plan_List_ID,Goods_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Stock_List_Reserve1,Stock_List_Reserve2,Stock_List_Reserve3,Stock_List_Reserve4,Stock_List_Reserve5 ");
            strSql.Append(" FROM Stock_List ");
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
            strSql.Append("select count(1) FROM Stock_List ");
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
                strSql.Append("order by T.Stock_List_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Stock_List T ");
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
        public bool DeleteByStockID(string stockID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Stock_List ");
            strSql.Append(" where Stock_ID='" + stockID + "' ");
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
		#endregion  ExtensionMethod
	}
}

