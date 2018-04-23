using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:RecordDal
	/// </summary>
	public partial class RecordDal
	{
        public RecordDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Record_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Record");
            strSql.Append(" where Record_ID='" + Record_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.RecordModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Record_ID != null)
            {
                strSql1.Append("Record_ID,");
                strSql2.Append("'" + model.Record_ID + "',");
            }
            if (model.Plan_ID != null)
            {
                strSql1.Append("Plan_ID,");
                strSql2.Append("'" + model.Plan_ID + "',");
            }
            if (model.Manage_Type_Code != null)
            {
                strSql1.Append("Manage_Type_Code,");
                strSql2.Append("'" + model.Manage_Type_Code + "',");
            }
            if (model.Stock_Tray_Barcode != null)
            {
                strSql1.Append("Stock_Tray_Barcode,");
                strSql2.Append("'" + model.Stock_Tray_Barcode + "',");
            }
            if (model.Start_Cell_ID != null)
            {
                strSql1.Append("Start_Cell_ID,");
                strSql2.Append("'" + model.Start_Cell_ID + "',");
            }
            if (model.End_Cell_ID != null)
            {
                strSql1.Append("End_Cell_ID,");
                strSql2.Append("'" + model.End_Cell_ID + "',");
            }
            if (model.Manage_Operater != null)
            {
                strSql1.Append("Manage_Operater,");
                strSql2.Append("'" + model.Manage_Operater + "',");
            }
            if (model.Manage_Begin_Time != null)
            {
                strSql1.Append("Manage_Begin_Time,");
                strSql2.Append("'" + model.Manage_Begin_Time + "',");
            }
            if (model.Manage_End_Time != null)
            {
                strSql1.Append("Manage_End_Time,");
                strSql2.Append("'" + model.Manage_End_Time + "',");
            }
            if (model.Record_Remark != null)
            {
                strSql1.Append("Record_Remark,");
                strSql2.Append("'" + model.Record_Remark + "',");
            }
            if (model.Record_Reserve1 != null)
            {
                strSql1.Append("Record_Reserve1,");
                strSql2.Append("'" + model.Record_Reserve1 + "',");
            }
            if (model.Record_Reserve2 != null)
            {
                strSql1.Append("Record_Reserve2,");
                strSql2.Append("'" + model.Record_Reserve2 + "',");
            }
            if (model.Record_Reserve3 != null)
            {
                strSql1.Append("Record_Reserve3,");
                strSql2.Append("'" + model.Record_Reserve3 + "',");
            }
            if (model.Record_Reserve4 != null)
            {
                strSql1.Append("Record_Reserve4,");
                strSql2.Append("'" + model.Record_Reserve4 + "',");
            }
            if (model.Record_Reserve5 != null)
            {
                strSql1.Append("Record_Reserve5,");
                strSql2.Append("'" + model.Record_Reserve5 + "',");
            }
            strSql.Append("insert into Record(");
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
        public bool Update(WMS_Database.RecordModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Record set ");
            if (model.Plan_ID != null)
            {
                strSql.Append("Plan_ID='" + model.Plan_ID + "',");
            }
            else
            {
                strSql.Append("Plan_ID= null ,");
            }
            if (model.Manage_Type_Code != null)
            {
                strSql.Append("Manage_Type_Code='" + model.Manage_Type_Code + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Code= null ,");
            }
            if (model.Stock_Tray_Barcode != null)
            {
                strSql.Append("Stock_Tray_Barcode='" + model.Stock_Tray_Barcode + "',");
            }
            else
            {
                strSql.Append("Stock_Tray_Barcode= null ,");
            }
            if (model.Start_Cell_ID != null)
            {
                strSql.Append("Start_Cell_ID='" + model.Start_Cell_ID + "',");
            }
            else
            {
                strSql.Append("Start_Cell_ID= null ,");
            }
            if (model.End_Cell_ID != null)
            {
                strSql.Append("End_Cell_ID='" + model.End_Cell_ID + "',");
            }
            else
            {
                strSql.Append("End_Cell_ID= null ,");
            }
            if (model.Manage_Operater != null)
            {
                strSql.Append("Manage_Operater='" + model.Manage_Operater + "',");
            }
            else
            {
                strSql.Append("Manage_Operater= null ,");
            }
            if (model.Manage_Begin_Time != null)
            {
                strSql.Append("Manage_Begin_Time='" + model.Manage_Begin_Time + "',");
            }
            else
            {
                strSql.Append("Manage_Begin_Time= null ,");
            }
            if (model.Manage_End_Time != null)
            {
                strSql.Append("Manage_End_Time='" + model.Manage_End_Time + "',");
            }
            else
            {
                strSql.Append("Manage_End_Time= null ,");
            }
            if (model.Record_Remark != null)
            {
                strSql.Append("Record_Remark='" + model.Record_Remark + "',");
            }
            else
            {
                strSql.Append("Record_Remark= null ,");
            }
            if (model.Record_Reserve1 != null)
            {
                strSql.Append("Record_Reserve1='" + model.Record_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Record_Reserve1= null ,");
            }
            if (model.Record_Reserve2 != null)
            {
                strSql.Append("Record_Reserve2='" + model.Record_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Record_Reserve2= null ,");
            }
            if (model.Record_Reserve3 != null)
            {
                strSql.Append("Record_Reserve3='" + model.Record_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Record_Reserve3= null ,");
            }
            if (model.Record_Reserve4 != null)
            {
                strSql.Append("Record_Reserve4='" + model.Record_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Record_Reserve4= null ,");
            }
            if (model.Record_Reserve5 != null)
            {
                strSql.Append("Record_Reserve5='" + model.Record_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Record_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Record_ID='" + model.Record_ID + "' ");
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
        public bool Delete(string Record_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Record ");
            strSql.Append(" where Record_ID='" + Record_ID + "' ");
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
        public bool DeleteList(string Record_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Record ");
            strSql.Append(" where Record_ID in (" + Record_IDlist + ")  ");
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
        public WMS_Database.RecordModel GetModel(string Record_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Record_ID,Plan_ID,Manage_Type_Code,Stock_Tray_Barcode,Start_Cell_ID,End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Record_Remark,Record_Reserve1,Record_Reserve2,Record_Reserve3,Record_Reserve4,Record_Reserve5 ");
            strSql.Append(" from Record ");
            strSql.Append(" where Record_ID='" + Record_ID + "' ");
            WMS_Database.RecordModel model = new WMS_Database.RecordModel();
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
        public WMS_Database.RecordModel DataRowToModel(DataRow row)
        {
            WMS_Database.RecordModel model = new WMS_Database.RecordModel();
            if (row != null)
            {
                if (row["Record_ID"] != null)
                {
                    model.Record_ID = row["Record_ID"].ToString();
                }
                if (row["Plan_ID"] != null)
                {
                    model.Plan_ID = row["Plan_ID"].ToString();
                }
                if (row["Manage_Type_Code"] != null)
                {
                    model.Manage_Type_Code = row["Manage_Type_Code"].ToString();
                }
                if (row["Stock_Tray_Barcode"] != null)
                {
                    model.Stock_Tray_Barcode = row["Stock_Tray_Barcode"].ToString();
                }
                if (row["Start_Cell_ID"] != null)
                {
                    model.Start_Cell_ID = row["Start_Cell_ID"].ToString();
                }
                if (row["End_Cell_ID"] != null)
                {
                    model.End_Cell_ID = row["End_Cell_ID"].ToString();
                }
                if (row["Manage_Operater"] != null)
                {
                    model.Manage_Operater = row["Manage_Operater"].ToString();
                }
                if (row["Manage_Begin_Time"] != null && row["Manage_Begin_Time"].ToString() != "")
                {
                    model.Manage_Begin_Time = DateTime.Parse(row["Manage_Begin_Time"].ToString());
                }
                if (row["Manage_End_Time"] != null && row["Manage_End_Time"].ToString() != "")
                {
                    model.Manage_End_Time = DateTime.Parse(row["Manage_End_Time"].ToString());
                }
                if (row["Record_Remark"] != null)
                {
                    model.Record_Remark = row["Record_Remark"].ToString();
                }
                if (row["Record_Reserve1"] != null)
                {
                    model.Record_Reserve1 = row["Record_Reserve1"].ToString();
                }
                if (row["Record_Reserve2"] != null)
                {
                    model.Record_Reserve2 = row["Record_Reserve2"].ToString();
                }
                if (row["Record_Reserve3"] != null)
                {
                    model.Record_Reserve3 = row["Record_Reserve3"].ToString();
                }
                if (row["Record_Reserve4"] != null)
                {
                    model.Record_Reserve4 = row["Record_Reserve4"].ToString();
                }
                if (row["Record_Reserve5"] != null)
                {
                    model.Record_Reserve5 = row["Record_Reserve5"].ToString();
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
            strSql.Append("select Record_ID,Plan_ID,Manage_Type_Code,Stock_Tray_Barcode,Start_Cell_ID,End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Record_Remark,Record_Reserve1,Record_Reserve2,Record_Reserve3,Record_Reserve4,Record_Reserve5 ");
            strSql.Append(" FROM Record ");
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
            strSql.Append(" Record_ID,Plan_ID,Manage_Type_Code,Stock_Tray_Barcode,Start_Cell_ID,End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Record_Remark,Record_Reserve1,Record_Reserve2,Record_Reserve3,Record_Reserve4,Record_Reserve5 ");
            strSql.Append(" FROM Record ");
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
            strSql.Append("select count(1) FROM Record ");
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
                strSql.Append("order by T.Record_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Record T ");
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

