using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:ManageDal
	/// </summary>
	public partial class ManageDal
	{
        public ManageDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Mange_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Manage");
            strSql.Append(" where Mange_ID='" + Mange_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.ManageModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Mange_ID != null)
            {
                strSql1.Append("Mange_ID,");
                strSql2.Append("'" + model.Mange_ID + "',");
            }
            if (model.Plan_ID != null)
            {
                strSql1.Append("Plan_ID,");
                strSql2.Append("'" + model.Plan_ID + "',");
            }
            if (model.Mange_Type_ID != null)
            {
                strSql1.Append("Mange_Type_ID,");
                strSql2.Append("'" + model.Mange_Type_ID + "',");
            }
            if (model.Mange_Status != null)
            {
                strSql1.Append("Mange_Status,");
                strSql2.Append("'" + model.Mange_Status + "',");
            }
            if (model.Mange_Stock_Barcode != null)
            {
                strSql1.Append("Mange_Stock_Barcode,");
                strSql2.Append("'" + model.Mange_Stock_Barcode + "',");
            }
            if (model.Mange_Full_Flag != null)
            {
                strSql1.Append("Mange_Full_Flag,");
                strSql2.Append("'" + model.Mange_Full_Flag + "',");
            }
            if (model.Manage_BreakDown_Status != null)
            {
                strSql1.Append("Manage_BreakDown_Status,");
                strSql2.Append("'" + model.Manage_BreakDown_Status + "',");
            }
            if (model.Mange_Start_Cell_ID != null)
            {
                strSql1.Append("Mange_Start_Cell_ID,");
                strSql2.Append("'" + model.Mange_Start_Cell_ID + "',");
            }
            if (model.Mange_End_Cell_ID != null)
            {
                strSql1.Append("Mange_End_Cell_ID,");
                strSql2.Append("'" + model.Mange_End_Cell_ID + "',");
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
            if (model.Manage_Remark != null)
            {
                strSql1.Append("Manage_Remark,");
                strSql2.Append("'" + model.Manage_Remark + "',");
            }
            if (model.Mange_Reserve1 != null)
            {
                strSql1.Append("Mange_Reserve1,");
                strSql2.Append("'" + model.Mange_Reserve1 + "',");
            }
            if (model.Mange_Reserve2 != null)
            {
                strSql1.Append("Mange_Reserve2,");
                strSql2.Append("'" + model.Mange_Reserve2 + "',");
            }
            if (model.Mange_Reserve3 != null)
            {
                strSql1.Append("Mange_Reserve3,");
                strSql2.Append("'" + model.Mange_Reserve3 + "',");
            }
            if (model.Mange_Reserve4 != null)
            {
                strSql1.Append("Mange_Reserve4,");
                strSql2.Append("'" + model.Mange_Reserve4 + "',");
            }
            if (model.Mange_Reserve5 != null)
            {
                strSql1.Append("Mange_Reserve5,");
                strSql2.Append("'" + model.Mange_Reserve5 + "',");
            }
            strSql.Append("insert into Manage(");
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
        public bool Update(WMS_Database.ManageModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Manage set ");
            if (model.Plan_ID != null)
            {
                strSql.Append("Plan_ID='" + model.Plan_ID + "',");
            }
            else
            {
                strSql.Append("Plan_ID= null ,");
            }
            if (model.Mange_Type_ID != null)
            {
                strSql.Append("Mange_Type_ID='" + model.Mange_Type_ID + "',");
            }
            else
            {
                strSql.Append("Mange_Type_ID= null ,");
            }
            if (model.Mange_Status != null)
            {
                strSql.Append("Mange_Status='" + model.Mange_Status + "',");
            }
            else
            {
                strSql.Append("Mange_Status= null ,");
            }
            if (model.Mange_Stock_Barcode != null)
            {
                strSql.Append("Mange_Stock_Barcode='" + model.Mange_Stock_Barcode + "',");
            }
            else
            {
                strSql.Append("Mange_Stock_Barcode= null ,");
            }
            if (model.Mange_Full_Flag != null)
            {
                strSql.Append("Mange_Full_Flag='" + model.Mange_Full_Flag + "',");
            }
            else
            {
                strSql.Append("Mange_Full_Flag= null ,");
            }
            if (model.Manage_BreakDown_Status != null)
            {
                strSql.Append("Manage_BreakDown_Status='" + model.Manage_BreakDown_Status + "',");
            }
            else
            {
                strSql.Append("Manage_BreakDown_Status= null ,");
            }
            if (model.Mange_Start_Cell_ID != null)
            {
                strSql.Append("Mange_Start_Cell_ID='" + model.Mange_Start_Cell_ID + "',");
            }
            else
            {
                strSql.Append("Mange_Start_Cell_ID= null ,");
            }
            if (model.Mange_End_Cell_ID != null)
            {
                strSql.Append("Mange_End_Cell_ID='" + model.Mange_End_Cell_ID + "',");
            }
            else
            {
                strSql.Append("Mange_End_Cell_ID= null ,");
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
            if (model.Manage_Remark != null)
            {
                strSql.Append("Manage_Remark='" + model.Manage_Remark + "',");
            }
            else
            {
                strSql.Append("Manage_Remark= null ,");
            }
            if (model.Mange_Reserve1 != null)
            {
                strSql.Append("Mange_Reserve1='" + model.Mange_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Mange_Reserve1= null ,");
            }
            if (model.Mange_Reserve2 != null)
            {
                strSql.Append("Mange_Reserve2='" + model.Mange_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Mange_Reserve2= null ,");
            }
            if (model.Mange_Reserve3 != null)
            {
                strSql.Append("Mange_Reserve3='" + model.Mange_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Mange_Reserve3= null ,");
            }
            if (model.Mange_Reserve4 != null)
            {
                strSql.Append("Mange_Reserve4='" + model.Mange_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Mange_Reserve4= null ,");
            }
            if (model.Mange_Reserve5 != null)
            {
                strSql.Append("Mange_Reserve5='" + model.Mange_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Mange_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Mange_ID='" + model.Mange_ID + "' ");
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
        public bool Delete(string Mange_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Manage ");
            strSql.Append(" where Mange_ID='" + Mange_ID + "' ");
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
        public bool DeleteList(string Mange_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Manage ");
            strSql.Append(" where Mange_ID in (" + Mange_IDlist + ")  ");
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
        public WMS_Database.ManageModel GetModel(string Mange_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_Reserve1,Mange_Reserve2,Mange_Reserve3,Mange_Reserve4,Mange_Reserve5 ");
            strSql.Append(" from Manage ");
            strSql.Append(" where Mange_ID='" + Mange_ID + "' ");
            WMS_Database.ManageModel model = new WMS_Database.ManageModel();
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
        public WMS_Database.ManageModel DataRowToModel(DataRow row)
        {
            WMS_Database.ManageModel model = new WMS_Database.ManageModel();
            if (row != null)
            {
                if (row["Mange_ID"] != null)
                {
                    model.Mange_ID = row["Mange_ID"].ToString();
                }
                if (row["Plan_ID"] != null)
                {
                    model.Plan_ID = row["Plan_ID"].ToString();
                }
                if (row["Mange_Type_ID"] != null)
                {
                    model.Mange_Type_ID = row["Mange_Type_ID"].ToString();
                }
                if (row["Mange_Status"] != null)
                {
                    model.Mange_Status = row["Mange_Status"].ToString();
                }
                if (row["Mange_Stock_Barcode"] != null)
                {
                    model.Mange_Stock_Barcode = row["Mange_Stock_Barcode"].ToString();
                }
                if (row["Mange_Full_Flag"] != null)
                {
                    model.Mange_Full_Flag = row["Mange_Full_Flag"].ToString();
                }
                if (row["Manage_BreakDown_Status"] != null)
                {
                    model.Manage_BreakDown_Status = row["Manage_BreakDown_Status"].ToString();
                }
                if (row["Mange_Start_Cell_ID"] != null)
                {
                    model.Mange_Start_Cell_ID = row["Mange_Start_Cell_ID"].ToString();
                }
                if (row["Mange_End_Cell_ID"] != null)
                {
                    model.Mange_End_Cell_ID = row["Mange_End_Cell_ID"].ToString();
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
                if (row["Manage_Remark"] != null)
                {
                    model.Manage_Remark = row["Manage_Remark"].ToString();
                }
                if (row["Mange_Reserve1"] != null)
                {
                    model.Mange_Reserve1 = row["Mange_Reserve1"].ToString();
                }
                if (row["Mange_Reserve2"] != null)
                {
                    model.Mange_Reserve2 = row["Mange_Reserve2"].ToString();
                }
                if (row["Mange_Reserve3"] != null)
                {
                    model.Mange_Reserve3 = row["Mange_Reserve3"].ToString();
                }
                if (row["Mange_Reserve4"] != null)
                {
                    model.Mange_Reserve4 = row["Mange_Reserve4"].ToString();
                }
                if (row["Mange_Reserve5"] != null)
                {
                    model.Mange_Reserve5 = row["Mange_Reserve5"].ToString();
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
            strSql.Append("select Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_Reserve1,Mange_Reserve2,Mange_Reserve3,Mange_Reserve4,Mange_Reserve5 ");
            strSql.Append(" FROM Manage ");
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
            strSql.Append(" Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_Reserve1,Mange_Reserve2,Mange_Reserve3,Mange_Reserve4,Mange_Reserve5 ");
            strSql.Append(" FROM Manage ");
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
            strSql.Append("select count(1) FROM Manage ");
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
                strSql.Append("order by T.Mange_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Manage T ");
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

          
        public bool DeleteManage(int days)
        {
           
            StringBuilder strSql = new StringBuilder();
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            strSql.Append("delete from Manage ");
            strSql.Append(" where datediff(day,Manage_End_Time,'" + nowTime + "') >= " + days);
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
		#endregion  ExtensionMethod
	}
}

