using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:Record_ListDal
	/// </summary>
	public partial class Record_ListDal
	{
        public Record_ListDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Record_List_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Record_List");
            strSql.Append(" where Record_List_ID='" + Record_List_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Record_ListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Record_List_ID != null)
            {
                strSql1.Append("Record_List_ID,");
                strSql2.Append("'" + model.Record_List_ID + "',");
            }
            if (model.Record_ID != null)
            {
                strSql1.Append("Record_ID,");
                strSql2.Append("'" + model.Record_ID + "',");
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
            if (model.Record_Box_Barcode != null)
            {
                strSql1.Append("Record_Box_Barcode,");
                strSql2.Append("'" + model.Record_Box_Barcode + "',");
            }
            if (model.Record_List_Quantity != null)
            {
                strSql1.Append("Record_List_Quantity,");
                strSql2.Append("'" + model.Record_List_Quantity + "',");
            }
            if (model.Record_List_Remark != null)
            {
                strSql1.Append("Record_List_Remark,");
                strSql2.Append("'" + model.Record_List_Remark + "',");
            }
            if (model.Record_List_Reserve1 != null)
            {
                strSql1.Append("Record_List_Reserve1,");
                strSql2.Append("'" + model.Record_List_Reserve1 + "',");
            }
            if (model.Record_List_Reserve2 != null)
            {
                strSql1.Append("Record_List_Reserve2,");
                strSql2.Append("'" + model.Record_List_Reserve2 + "',");
            }
            if (model.Record_List_Reserve3 != null)
            {
                strSql1.Append("Record_List_Reserve3,");
                strSql2.Append("'" + model.Record_List_Reserve3 + "',");
            }
            if (model.Record_List_Reserve4 != null)
            {
                strSql1.Append("Record_List_Reserve4,");
                strSql2.Append("'" + model.Record_List_Reserve4 + "',");
            }
            if (model.Record_List_Reserve5 != null)
            {
                strSql1.Append("Record_List_Reserve5,");
                strSql2.Append("'" + model.Record_List_Reserve5 + "',");
            }
            strSql.Append("insert into Record_List(");
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
        public bool Update(WMS_Database.Record_ListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Record_List set ");
            if (model.Record_ID != null)
            {
                strSql.Append("Record_ID='" + model.Record_ID + "',");
            }
            else
            {
                strSql.Append("Record_ID= null ,");
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
            if (model.Record_Box_Barcode != null)
            {
                strSql.Append("Record_Box_Barcode='" + model.Record_Box_Barcode + "',");
            }
            else
            {
                strSql.Append("Record_Box_Barcode= null ,");
            }
            if (model.Record_List_Quantity != null)
            {
                strSql.Append("Record_List_Quantity='" + model.Record_List_Quantity + "',");
            }
            else
            {
                strSql.Append("Record_List_Quantity= null ,");
            }
            if (model.Record_List_Remark != null)
            {
                strSql.Append("Record_List_Remark='" + model.Record_List_Remark + "',");
            }
            else
            {
                strSql.Append("Record_List_Remark= null ,");
            }
            if (model.Record_List_Reserve1 != null)
            {
                strSql.Append("Record_List_Reserve1='" + model.Record_List_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Record_List_Reserve1= null ,");
            }
            if (model.Record_List_Reserve2 != null)
            {
                strSql.Append("Record_List_Reserve2='" + model.Record_List_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Record_List_Reserve2= null ,");
            }
            if (model.Record_List_Reserve3 != null)
            {
                strSql.Append("Record_List_Reserve3='" + model.Record_List_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Record_List_Reserve3= null ,");
            }
            if (model.Record_List_Reserve4 != null)
            {
                strSql.Append("Record_List_Reserve4='" + model.Record_List_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Record_List_Reserve4= null ,");
            }
            if (model.Record_List_Reserve5 != null)
            {
                strSql.Append("Record_List_Reserve5='" + model.Record_List_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Record_List_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Record_List_ID='" + model.Record_List_ID + "' ");
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
        public bool Delete(string Record_List_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Record_List ");
            strSql.Append(" where Record_List_ID='" + Record_List_ID + "' ");
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
        public bool DeleteList(string Record_List_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Record_List ");
            strSql.Append(" where Record_List_ID in (" + Record_List_IDlist + ")  ");
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
        public WMS_Database.Record_ListModel GetModel(string Record_List_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Record_List_ID,Record_ID,Plan_List_ID,Goods_ID,Record_Box_Barcode,Record_List_Quantity,Record_List_Remark,Record_List_Reserve1,Record_List_Reserve2,Record_List_Reserve3,Record_List_Reserve4,Record_List_Reserve5 ");
            strSql.Append(" from Record_List ");
            strSql.Append(" where Record_List_ID='" + Record_List_ID + "' ");
            WMS_Database.Record_ListModel model = new WMS_Database.Record_ListModel();
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
        public WMS_Database.Record_ListModel DataRowToModel(DataRow row)
        {
            WMS_Database.Record_ListModel model = new WMS_Database.Record_ListModel();
            if (row != null)
            {
                if (row["Record_List_ID"] != null)
                {
                    model.Record_List_ID = row["Record_List_ID"].ToString();
                }
                if (row["Record_ID"] != null)
                {
                    model.Record_ID = row["Record_ID"].ToString();
                }
                if (row["Plan_List_ID"] != null)
                {
                    model.Plan_List_ID = row["Plan_List_ID"].ToString();
                }
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
                }
                if (row["Record_Box_Barcode"] != null)
                {
                    model.Record_Box_Barcode = row["Record_Box_Barcode"].ToString();
                }
                if (row["Record_List_Quantity"] != null)
                {
                    model.Record_List_Quantity = row["Record_List_Quantity"].ToString();
                }
                if (row["Record_List_Remark"] != null)
                {
                    model.Record_List_Remark = row["Record_List_Remark"].ToString();
                }
                if (row["Record_List_Reserve1"] != null)
                {
                    model.Record_List_Reserve1 = row["Record_List_Reserve1"].ToString();
                }
                if (row["Record_List_Reserve2"] != null)
                {
                    model.Record_List_Reserve2 = row["Record_List_Reserve2"].ToString();
                }
                if (row["Record_List_Reserve3"] != null)
                {
                    model.Record_List_Reserve3 = row["Record_List_Reserve3"].ToString();
                }
                if (row["Record_List_Reserve4"] != null)
                {
                    model.Record_List_Reserve4 = row["Record_List_Reserve4"].ToString();
                }
                if (row["Record_List_Reserve5"] != null)
                {
                    model.Record_List_Reserve5 = row["Record_List_Reserve5"].ToString();
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
            strSql.Append("select Record_List_ID,Record_ID,Plan_List_ID,Goods_ID,Record_Box_Barcode,Record_List_Quantity,Record_List_Remark,Record_List_Reserve1,Record_List_Reserve2,Record_List_Reserve3,Record_List_Reserve4,Record_List_Reserve5 ");
            strSql.Append(" FROM Record_List ");
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
            strSql.Append(" Record_List_ID,Record_ID,Plan_List_ID,Goods_ID,Record_Box_Barcode,Record_List_Quantity,Record_List_Remark,Record_List_Reserve1,Record_List_Reserve2,Record_List_Reserve3,Record_List_Reserve4,Record_List_Reserve5 ");
            strSql.Append(" FROM Record_List ");
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
            strSql.Append("select count(1) FROM Record_List ");
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
                strSql.Append("order by T.Record_List_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Record_List T ");
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

