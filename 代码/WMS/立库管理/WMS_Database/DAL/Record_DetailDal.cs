using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
//using Maticsoft.DBUtility;//Please add references
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:Record_DetailDal
	/// </summary>
	public partial class Record_DetailDal
	{
        public Record_DetailDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Record_Detail_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Record_Detail");
            strSql.Append(" where Record_Detail_ID='" + Record_Detail_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Record_DetailModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Record_Detail_ID != null)
            {
                strSql1.Append("Record_Detail_ID,");
                strSql2.Append("'" + model.Record_Detail_ID + "',");
            }
            if (model.Record_List_ID != null)
            {
                strSql1.Append("Record_List_ID,");
                strSql2.Append("'" + model.Record_List_ID + "',");
            }
            if (model.Record_Detail_Box_Barcode != null)
            {
                strSql1.Append("Record_Detail_Box_Barcode,");
                strSql2.Append("'" + model.Record_Detail_Box_Barcode + "',");
            }
            if (model.Goods_Barcode != null)
            {
                strSql1.Append("Goods_Barcode,");
                strSql2.Append("'" + model.Goods_Barcode + "',");
            }
            if (model.Record_Detail_Remark != null)
            {
                strSql1.Append("Record_Detail_Remark,");
                strSql2.Append("'" + model.Record_Detail_Remark + "',");
            }
            if (model.Record_Detail_Reserve1 != null)
            {
                strSql1.Append("Record_Detail_Reserve1,");
                strSql2.Append("'" + model.Record_Detail_Reserve1 + "',");
            }
            if (model.Record_Detail_Reserve2 != null)
            {
                strSql1.Append("Record_Detail_Reserve2,");
                strSql2.Append("'" + model.Record_Detail_Reserve2 + "',");
            }
            if (model.Record_Detail_Reserve3 != null)
            {
                strSql1.Append("Record_Detail_Reserve3,");
                strSql2.Append("'" + model.Record_Detail_Reserve3 + "',");
            }
            if (model.Record_Detail_Reserve4 != null)
            {
                strSql1.Append("Record_Detail_Reserve4,");
                strSql2.Append("'" + model.Record_Detail_Reserve4 + "',");
            }
            if (model.Record_Detail_Reserve5 != null)
            {
                strSql1.Append("Record_Detail_Reserve5,");
                strSql2.Append("'" + model.Record_Detail_Reserve5 + "',");
            }
            strSql.Append("insert into Record_Detail(");
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
        public bool Update(WMS_Database.Record_DetailModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Record_Detail set ");
            if (model.Record_List_ID != null)
            {
                strSql.Append("Record_List_ID='" + model.Record_List_ID + "',");
            }
            else
            {
                strSql.Append("Record_List_ID= null ,");
            }
            if (model.Record_Detail_Box_Barcode != null)
            {
                strSql.Append("Record_Detail_Box_Barcode='" + model.Record_Detail_Box_Barcode + "',");
            }
            else
            {
                strSql.Append("Record_Detail_Box_Barcode= null ,");
            }
            if (model.Goods_Barcode != null)
            {
                strSql.Append("Goods_Barcode='" + model.Goods_Barcode + "',");
            }
            else
            {
                strSql.Append("Goods_Barcode= null ,");
            }
            if (model.Record_Detail_Remark != null)
            {
                strSql.Append("Record_Detail_Remark='" + model.Record_Detail_Remark + "',");
            }
            else
            {
                strSql.Append("Record_Detail_Remark= null ,");
            }
            if (model.Record_Detail_Reserve1 != null)
            {
                strSql.Append("Record_Detail_Reserve1='" + model.Record_Detail_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Record_Detail_Reserve1= null ,");
            }
            if (model.Record_Detail_Reserve2 != null)
            {
                strSql.Append("Record_Detail_Reserve2='" + model.Record_Detail_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Record_Detail_Reserve2= null ,");
            }
            if (model.Record_Detail_Reserve3 != null)
            {
                strSql.Append("Record_Detail_Reserve3='" + model.Record_Detail_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Record_Detail_Reserve3= null ,");
            }
            if (model.Record_Detail_Reserve4 != null)
            {
                strSql.Append("Record_Detail_Reserve4='" + model.Record_Detail_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Record_Detail_Reserve4= null ,");
            }
            if (model.Record_Detail_Reserve5 != null)
            {
                strSql.Append("Record_Detail_Reserve5='" + model.Record_Detail_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Record_Detail_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Record_Detail_ID='" + model.Record_Detail_ID + "' ");
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
        public bool Delete(string Record_Detail_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Record_Detail ");
            strSql.Append(" where Record_Detail_ID='" + Record_Detail_ID + "' ");
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
        public bool DeleteList(string Record_Detail_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Record_Detail ");
            strSql.Append(" where Record_Detail_ID in (" + Record_Detail_IDlist + ")  ");
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
        public WMS_Database.Record_DetailModel GetModel(string Record_Detail_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Record_Detail_ID,Record_List_ID,Record_Detail_Box_Barcode,Goods_Barcode,Record_Detail_Remark,Record_Detail_Reserve1,Record_Detail_Reserve2,Record_Detail_Reserve3,Record_Detail_Reserve4,Record_Detail_Reserve5 ");
            strSql.Append(" from Record_Detail ");
            strSql.Append(" where Record_Detail_ID='" + Record_Detail_ID + "' ");
            WMS_Database.Record_DetailModel model = new WMS_Database.Record_DetailModel();
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
        public WMS_Database.Record_DetailModel DataRowToModel(DataRow row)
        {
            WMS_Database.Record_DetailModel model = new WMS_Database.Record_DetailModel();
            if (row != null)
            {
                if (row["Record_Detail_ID"] != null)
                {
                    model.Record_Detail_ID = row["Record_Detail_ID"].ToString();
                }
                if (row["Record_List_ID"] != null)
                {
                    model.Record_List_ID = row["Record_List_ID"].ToString();
                }
                if (row["Record_Detail_Box_Barcode"] != null)
                {
                    model.Record_Detail_Box_Barcode = row["Record_Detail_Box_Barcode"].ToString();
                }
                if (row["Goods_Barcode"] != null)
                {
                    model.Goods_Barcode = row["Goods_Barcode"].ToString();
                }
                if (row["Record_Detail_Remark"] != null)
                {
                    model.Record_Detail_Remark = row["Record_Detail_Remark"].ToString();
                }
                if (row["Record_Detail_Reserve1"] != null)
                {
                    model.Record_Detail_Reserve1 = row["Record_Detail_Reserve1"].ToString();
                }
                if (row["Record_Detail_Reserve2"] != null)
                {
                    model.Record_Detail_Reserve2 = row["Record_Detail_Reserve2"].ToString();
                }
                if (row["Record_Detail_Reserve3"] != null)
                {
                    model.Record_Detail_Reserve3 = row["Record_Detail_Reserve3"].ToString();
                }
                if (row["Record_Detail_Reserve4"] != null)
                {
                    model.Record_Detail_Reserve4 = row["Record_Detail_Reserve4"].ToString();
                }
                if (row["Record_Detail_Reserve5"] != null)
                {
                    model.Record_Detail_Reserve5 = row["Record_Detail_Reserve5"].ToString();
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
            strSql.Append("select Record_Detail_ID,Record_List_ID,Record_Detail_Box_Barcode,Goods_Barcode,Record_Detail_Remark,Record_Detail_Reserve1,Record_Detail_Reserve2,Record_Detail_Reserve3,Record_Detail_Reserve4,Record_Detail_Reserve5 ");
            strSql.Append(" FROM Record_Detail ");
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
            strSql.Append(" Record_Detail_ID,Record_List_ID,Record_Detail_Box_Barcode,Goods_Barcode,Record_Detail_Remark,Record_Detail_Reserve1,Record_Detail_Reserve2,Record_Detail_Reserve3,Record_Detail_Reserve4,Record_Detail_Reserve5 ");
            strSql.Append(" FROM Record_Detail ");
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
            strSql.Append("select count(1) FROM Record_Detail ");
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
                strSql.Append("order by T.Record_Detail_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Record_Detail T ");
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

