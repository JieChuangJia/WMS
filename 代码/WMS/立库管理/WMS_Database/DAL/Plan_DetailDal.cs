using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
//using Maticsoft.DBUtility;//Please add references
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:Plan_DetailDal
	/// </summary>
	public partial class Plan_DetailDal
	{
        public Plan_DetailDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_Detail_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Plan_Detail");
            strSql.Append(" where Plan_Detail_ID='" + Plan_Detail_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Plan_DetailModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Plan_Detail_ID != null)
            {
                strSql1.Append("Plan_Detail_ID,");
                strSql2.Append("'" + model.Plan_Detail_ID + "',");
            }
            if (model.Plan_List_ID != null)
            {
                strSql1.Append("Plan_List_ID,");
                strSql2.Append("'" + model.Plan_List_ID + "',");
            }
            if (model.Plan_Detail_BoxCode != null)
            {
                strSql1.Append("Plan_Detail_BoxCode,");
                strSql2.Append("'" + model.Plan_Detail_BoxCode + "',");
            }
            if (model.Plan_Detail_Goods_Barcode != null)
            {
                strSql1.Append("Plan_Detail_Goods_Barcode,");
                strSql2.Append("'" + model.Plan_Detail_Goods_Barcode + "',");
            }
            if (model.Plan_Detail_Remark != null)
            {
                strSql1.Append("Plan_Detail_Remark,");
                strSql2.Append("'" + model.Plan_Detail_Remark + "',");
            }
            if (model.Plan_Detai_Reserve1 != null)
            {
                strSql1.Append("Plan_Detai_Reserve1,");
                strSql2.Append("'" + model.Plan_Detai_Reserve1 + "',");
            }
            if (model.Plan_Detai_Reserve2 != null)
            {
                strSql1.Append("Plan_Detai_Reserve2,");
                strSql2.Append("'" + model.Plan_Detai_Reserve2 + "',");
            }
            if (model.Plan_Detai_Reserve3 != null)
            {
                strSql1.Append("Plan_Detai_Reserve3,");
                strSql2.Append("'" + model.Plan_Detai_Reserve3 + "',");
            }
            if (model.Plan_Detai_Reserve4 != null)
            {
                strSql1.Append("Plan_Detai_Reserve4,");
                strSql2.Append("'" + model.Plan_Detai_Reserve4 + "',");
            }
            if (model.Plan_Detai_Reserve5 != null)
            {
                strSql1.Append("Plan_Detai_Reserve5,");
                strSql2.Append("'" + model.Plan_Detai_Reserve5 + "',");
            }
            strSql.Append("insert into Plan_Detail(");
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
        public bool Update(WMS_Database.Plan_DetailModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Plan_Detail set ");
            if (model.Plan_List_ID != null)
            {
                strSql.Append("Plan_List_ID='" + model.Plan_List_ID + "',");
            }
            if (model.Plan_Detail_BoxCode != null)
            {
                strSql.Append("Plan_Detail_BoxCode='" + model.Plan_Detail_BoxCode + "',");
            }
            else
            {
                strSql.Append("Plan_Detail_BoxCode= null ,");
            }
            if (model.Plan_Detail_Goods_Barcode != null)
            {
                strSql.Append("Plan_Detail_Goods_Barcode='" + model.Plan_Detail_Goods_Barcode + "',");
            }
            else
            {
                strSql.Append("Plan_Detail_Goods_Barcode= null ,");
            }
            if (model.Plan_Detail_Remark != null)
            {
                strSql.Append("Plan_Detail_Remark='" + model.Plan_Detail_Remark + "',");
            }
            else
            {
                strSql.Append("Plan_Detail_Remark= null ,");
            }
            if (model.Plan_Detai_Reserve1 != null)
            {
                strSql.Append("Plan_Detai_Reserve1='" + model.Plan_Detai_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Plan_Detai_Reserve1= null ,");
            }
            if (model.Plan_Detai_Reserve2 != null)
            {
                strSql.Append("Plan_Detai_Reserve2='" + model.Plan_Detai_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Plan_Detai_Reserve2= null ,");
            }
            if (model.Plan_Detai_Reserve3 != null)
            {
                strSql.Append("Plan_Detai_Reserve3='" + model.Plan_Detai_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Plan_Detai_Reserve3= null ,");
            }
            if (model.Plan_Detai_Reserve4 != null)
            {
                strSql.Append("Plan_Detai_Reserve4='" + model.Plan_Detai_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Plan_Detai_Reserve4= null ,");
            }
            if (model.Plan_Detai_Reserve5 != null)
            {
                strSql.Append("Plan_Detai_Reserve5='" + model.Plan_Detai_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Plan_Detai_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Plan_Detail_ID='" + model.Plan_Detail_ID + "' ");
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
        public bool Delete(string Plan_Detail_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Plan_Detail ");
            strSql.Append(" where Plan_Detail_ID='" + Plan_Detail_ID + "' ");
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
        public bool DeleteList(string Plan_Detail_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Plan_Detail ");
            strSql.Append(" where Plan_Detail_ID in (" + Plan_Detail_IDlist + ")  ");
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
        public WMS_Database.Plan_DetailModel GetModel(string Plan_Detail_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Plan_Detail_ID,Plan_List_ID,Plan_Detail_BoxCode,Plan_Detail_Goods_Barcode,Plan_Detail_Remark,Plan_Detai_Reserve1,Plan_Detai_Reserve2,Plan_Detai_Reserve3,Plan_Detai_Reserve4,Plan_Detai_Reserve5 ");
            strSql.Append(" from Plan_Detail ");
            strSql.Append(" where Plan_Detail_ID='" + Plan_Detail_ID + "' ");
            WMS_Database.Plan_DetailModel model = new WMS_Database.Plan_DetailModel();
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
        public WMS_Database.Plan_DetailModel DataRowToModel(DataRow row)
        {
            WMS_Database.Plan_DetailModel model = new WMS_Database.Plan_DetailModel();
            if (row != null)
            {
                if (row["Plan_Detail_ID"] != null)
                {
                    model.Plan_Detail_ID = row["Plan_Detail_ID"].ToString();
                }
                if (row["Plan_List_ID"] != null)
                {
                    model.Plan_List_ID = row["Plan_List_ID"].ToString();
                }
                if (row["Plan_Detail_BoxCode"] != null)
                {
                    model.Plan_Detail_BoxCode = row["Plan_Detail_BoxCode"].ToString();
                }
                if (row["Plan_Detail_Goods_Barcode"] != null)
                {
                    model.Plan_Detail_Goods_Barcode = row["Plan_Detail_Goods_Barcode"].ToString();
                }
                if (row["Plan_Detail_Remark"] != null)
                {
                    model.Plan_Detail_Remark = row["Plan_Detail_Remark"].ToString();
                }
                if (row["Plan_Detai_Reserve1"] != null)
                {
                    model.Plan_Detai_Reserve1 = row["Plan_Detai_Reserve1"].ToString();
                }
                if (row["Plan_Detai_Reserve2"] != null)
                {
                    model.Plan_Detai_Reserve2 = row["Plan_Detai_Reserve2"].ToString();
                }
                if (row["Plan_Detai_Reserve3"] != null)
                {
                    model.Plan_Detai_Reserve3 = row["Plan_Detai_Reserve3"].ToString();
                }
                if (row["Plan_Detai_Reserve4"] != null)
                {
                    model.Plan_Detai_Reserve4 = row["Plan_Detai_Reserve4"].ToString();
                }
                if (row["Plan_Detai_Reserve5"] != null)
                {
                    model.Plan_Detai_Reserve5 = row["Plan_Detai_Reserve5"].ToString();
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
            strSql.Append("select Plan_Detail_ID,Plan_List_ID,Plan_Detail_BoxCode,Plan_Detail_Goods_Barcode,Plan_Detail_Remark,Plan_Detai_Reserve1,Plan_Detai_Reserve2,Plan_Detai_Reserve3,Plan_Detai_Reserve4,Plan_Detai_Reserve5 ");
            strSql.Append(" FROM Plan_Detail ");
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
            strSql.Append(" Plan_Detail_ID,Plan_List_ID,Plan_Detail_BoxCode,Plan_Detail_Goods_Barcode,Plan_Detail_Remark,Plan_Detai_Reserve1,Plan_Detai_Reserve2,Plan_Detai_Reserve3,Plan_Detai_Reserve4,Plan_Detai_Reserve5 ");
            strSql.Append(" FROM Plan_Detail ");
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
            strSql.Append("select count(1) FROM Plan_Detail ");
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
                strSql.Append("order by T.Plan_Detail_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Plan_Detail T ");
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

