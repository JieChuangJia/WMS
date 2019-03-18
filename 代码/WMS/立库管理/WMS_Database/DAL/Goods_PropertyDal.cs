using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:Goods_PropertyDal
	/// </summary>
	public partial class Goods_PropertyDal
	{
        public Goods_PropertyDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_Property_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Goods_Property");
            strSql.Append(" where Goods_Property_ID='" + Goods_Property_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Goods_PropertyModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Goods_Property_ID != null)
            {
                strSql1.Append("Goods_Property_ID,");
                strSql2.Append("'" + model.Goods_Property_ID + "',");
            }
            if (model.Goods_ID != null)
            {
                strSql1.Append("Goods_ID,");
                strSql2.Append("'" + model.Goods_ID + "',");
            }
            if (model.Goods_Property_Code != null)
            {
                strSql1.Append("Goods_Property_Code,");
                strSql2.Append("'" + model.Goods_Property_Code + "',");
            }
            if (model.Goods_Property_Name != null)
            {
                strSql1.Append("Goods_Property_Name,");
                strSql2.Append("'" + model.Goods_Property_Name + "',");
            }
            if (model.Goods_Property_Data != null)
            {
                strSql1.Append("Goods_Property_Data,");
                strSql2.Append("'" + model.Goods_Property_Data + "',");
            }
            if (model.Goods_Property_FieldDataType != null)
            {
                strSql1.Append("Goods_Property_FieldDataType,");
                strSql2.Append("'" + model.Goods_Property_FieldDataType + "',");
            }
            if (model.Goods_Property_Order != null)
            {
                strSql1.Append("Goods_Property_Order,");
                strSql2.Append("" + model.Goods_Property_Order + ",");
            }
            if (model.Goods_Property_Flag != null)
            {
                strSql1.Append("Goods_Property_Flag,");
                strSql2.Append("'" + model.Goods_Property_Flag + "',");
            }
            if (model.Goods_Property_Valid != null)
            {
                strSql1.Append("Goods_Property_Valid,");
                strSql2.Append("'" + model.Goods_Property_Valid + "',");
            }
            if (model.Goods_Property_Remark != null)
            {
                strSql1.Append("Goods_Property_Remark,");
                strSql2.Append("'" + model.Goods_Property_Remark + "',");
            }
            if (model.Goods_Property_Reserve1 != null)
            {
                strSql1.Append("Goods_Property_Reserve1,");
                strSql2.Append("'" + model.Goods_Property_Reserve1 + "',");
            }
            if (model.Goods_Property_Reserve2 != null)
            {
                strSql1.Append("Goods_Property_Reserve2,");
                strSql2.Append("'" + model.Goods_Property_Reserve2 + "',");
            }
            if (model.Goods_Property_Reserve3 != null)
            {
                strSql1.Append("Goods_Property_Reserve3,");
                strSql2.Append("'" + model.Goods_Property_Reserve3 + "',");
            }
            if (model.Goods_Property_Reserve4 != null)
            {
                strSql1.Append("Goods_Property_Reserve4,");
                strSql2.Append("'" + model.Goods_Property_Reserve4 + "',");
            }
            if (model.Goods_Property_Reserve5 != null)
            {
                strSql1.Append("Goods_Property_Reserve5,");
                strSql2.Append("'" + model.Goods_Property_Reserve5 + "',");
            }
            strSql.Append("insert into Goods_Property(");
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
        public bool Update(WMS_Database.Goods_PropertyModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Goods_Property set ");
            if (model.Goods_ID != null)
            {
                strSql.Append("Goods_ID='" + model.Goods_ID + "',");
            }
            if (model.Goods_Property_Code != null)
            {
                strSql.Append("Goods_Property_Code='" + model.Goods_Property_Code + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Code= null ,");
            }
            if (model.Goods_Property_Name != null)
            {
                strSql.Append("Goods_Property_Name='" + model.Goods_Property_Name + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Name= null ,");
            }
            if (model.Goods_Property_Data != null)
            {
                strSql.Append("Goods_Property_Data='" + model.Goods_Property_Data + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Data= null ,");
            }
            if (model.Goods_Property_FieldDataType != null)
            {
                strSql.Append("Goods_Property_FieldDataType='" + model.Goods_Property_FieldDataType + "',");
            }
            else
            {
                strSql.Append("Goods_Property_FieldDataType= null ,");
            }
            if (model.Goods_Property_Order != null)
            {
                strSql.Append("Goods_Property_Order=" + model.Goods_Property_Order + ",");
            }
            else
            {
                strSql.Append("Goods_Property_Order= null ,");
            }
            if (model.Goods_Property_Flag != null)
            {
                strSql.Append("Goods_Property_Flag='" + model.Goods_Property_Flag + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Flag= null ,");
            }
            if (model.Goods_Property_Valid != null)
            {
                strSql.Append("Goods_Property_Valid='" + model.Goods_Property_Valid + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Valid= null ,");
            }
            if (model.Goods_Property_Remark != null)
            {
                strSql.Append("Goods_Property_Remark='" + model.Goods_Property_Remark + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Remark= null ,");
            }
            if (model.Goods_Property_Reserve1 != null)
            {
                strSql.Append("Goods_Property_Reserve1='" + model.Goods_Property_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Reserve1= null ,");
            }
            if (model.Goods_Property_Reserve2 != null)
            {
                strSql.Append("Goods_Property_Reserve2='" + model.Goods_Property_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Reserve2= null ,");
            }
            if (model.Goods_Property_Reserve3 != null)
            {
                strSql.Append("Goods_Property_Reserve3='" + model.Goods_Property_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Reserve3= null ,");
            }
            if (model.Goods_Property_Reserve4 != null)
            {
                strSql.Append("Goods_Property_Reserve4='" + model.Goods_Property_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Reserve4= null ,");
            }
            if (model.Goods_Property_Reserve5 != null)
            {
                strSql.Append("Goods_Property_Reserve5='" + model.Goods_Property_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Goods_Property_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Goods_Property_ID='" + model.Goods_Property_ID + "' ");
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
        public bool Delete(string Goods_Property_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Property ");
            strSql.Append(" where Goods_Property_ID='" + Goods_Property_ID + "' ");
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
        public bool DeleteList(string Goods_Property_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Property ");
            strSql.Append(" where Goods_Property_ID in (" + Goods_Property_IDlist + ")  ");
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
        public WMS_Database.Goods_PropertyModel GetModel(string Goods_Property_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Goods_Property_ID,Goods_ID,Goods_Property_Code,Goods_Property_Name,Goods_Property_Data,Goods_Property_FieldDataType,Goods_Property_Order,Goods_Property_Flag,Goods_Property_Valid,Goods_Property_Remark,Goods_Property_Reserve1,Goods_Property_Reserve2,Goods_Property_Reserve3,Goods_Property_Reserve4,Goods_Property_Reserve5 ");
            strSql.Append(" from Goods_Property ");
            strSql.Append(" where Goods_Property_ID='" + Goods_Property_ID + "' ");
            WMS_Database.Goods_PropertyModel model = new WMS_Database.Goods_PropertyModel();
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
        public WMS_Database.Goods_PropertyModel DataRowToModel(DataRow row)
        {
            WMS_Database.Goods_PropertyModel model = new WMS_Database.Goods_PropertyModel();
            if (row != null)
            {
                if (row["Goods_Property_ID"] != null)
                {
                    model.Goods_Property_ID = row["Goods_Property_ID"].ToString();
                }
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
                }
                if (row["Goods_Property_Code"] != null)
                {
                    model.Goods_Property_Code = row["Goods_Property_Code"].ToString();
                }
                if (row["Goods_Property_Name"] != null)
                {
                    model.Goods_Property_Name = row["Goods_Property_Name"].ToString();
                }
                if (row["Goods_Property_Data"] != null)
                {
                    model.Goods_Property_Data = row["Goods_Property_Data"].ToString();
                }
                if (row["Goods_Property_FieldDataType"] != null)
                {
                    model.Goods_Property_FieldDataType = row["Goods_Property_FieldDataType"].ToString();
                }
                if (row["Goods_Property_Order"] != null && row["Goods_Property_Order"].ToString() != "")
                {
                    model.Goods_Property_Order = int.Parse(row["Goods_Property_Order"].ToString());
                }
                if (row["Goods_Property_Flag"] != null)
                {
                    model.Goods_Property_Flag = row["Goods_Property_Flag"].ToString();
                }
                if (row["Goods_Property_Valid"] != null)
                {
                    model.Goods_Property_Valid = row["Goods_Property_Valid"].ToString();
                }
                if (row["Goods_Property_Remark"] != null)
                {
                    model.Goods_Property_Remark = row["Goods_Property_Remark"].ToString();
                }
                if (row["Goods_Property_Reserve1"] != null)
                {
                    model.Goods_Property_Reserve1 = row["Goods_Property_Reserve1"].ToString();
                }
                if (row["Goods_Property_Reserve2"] != null)
                {
                    model.Goods_Property_Reserve2 = row["Goods_Property_Reserve2"].ToString();
                }
                if (row["Goods_Property_Reserve3"] != null)
                {
                    model.Goods_Property_Reserve3 = row["Goods_Property_Reserve3"].ToString();
                }
                if (row["Goods_Property_Reserve4"] != null)
                {
                    model.Goods_Property_Reserve4 = row["Goods_Property_Reserve4"].ToString();
                }
                if (row["Goods_Property_Reserve5"] != null)
                {
                    model.Goods_Property_Reserve5 = row["Goods_Property_Reserve5"].ToString();
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
            strSql.Append("select Goods_Property_ID,Goods_ID,Goods_Property_Code,Goods_Property_Name,Goods_Property_Data,Goods_Property_FieldDataType,Goods_Property_Order,Goods_Property_Flag,Goods_Property_Valid,Goods_Property_Remark,Goods_Property_Reserve1,Goods_Property_Reserve2,Goods_Property_Reserve3,Goods_Property_Reserve4,Goods_Property_Reserve5 ");
            strSql.Append(" FROM Goods_Property ");
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
            strSql.Append(" Goods_Property_ID,Goods_ID,Goods_Property_Code,Goods_Property_Name,Goods_Property_Data,Goods_Property_FieldDataType,Goods_Property_Order,Goods_Property_Flag,Goods_Property_Valid,Goods_Property_Remark,Goods_Property_Reserve1,Goods_Property_Reserve2,Goods_Property_Reserve3,Goods_Property_Reserve4,Goods_Property_Reserve5 ");
            strSql.Append(" FROM Goods_Property ");
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
            strSql.Append("select count(1) FROM Goods_Property ");
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
                strSql.Append("order by T.Goods_Property_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Goods_Property T ");
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

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByGoodsCode(string goods_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Property ");
            strSql.Append(" where [Goods_ID]='" + goods_Code + "' ");
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
		#endregion  ExtensionMethod
	}
}

