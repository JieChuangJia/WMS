using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:View_Manage
    /// </summary>
    public partial class View_ManageDAL
    {
        public View_ManageDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Mange_Type_ID, string Mange_Stock_Barcode, string Mange_Status, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_Group, string Manage_Type_Remark, string Manage_Type_InOut, string Mange_ID, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Reserve1, string Manage_Type_Reserve2, string Manage_Remark, string Mange_Reserve1, DateTime Mange_CreateTime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_Manage");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Status='" + Mange_Status + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Type_Code='" + Manage_Type_Code + "' and Manage_Type_Name='" + Manage_Type_Name + "' and Manage_Type_Group='" + Manage_Type_Group + "' and Manage_Type_Remark='" + Manage_Type_Remark + "' and Manage_Type_InOut='" + Manage_Type_InOut + "' and Mange_ID='" + Mange_ID + "' and Manage_Type_Order=" + Manage_Type_Order + " and Manage_Type_Flag='" + Manage_Type_Flag + "' and Manage_Type_Reserve1='" + Manage_Type_Reserve1 + "' and Manage_Type_Reserve2='" + Manage_Type_Reserve2 + "' and Manage_Remark='" + Manage_Remark + "' and Mange_Reserve1='" + Mange_Reserve1 + "' and Mange_CreateTime='" + Mange_CreateTime + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_ManageModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
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
            if (model.Mange_Stock_Barcode != null)
            {
                strSql1.Append("Mange_Stock_Barcode,");
                strSql2.Append("'" + model.Mange_Stock_Barcode + "',");
            }
            if (model.Mange_Status != null)
            {
                strSql1.Append("Mange_Status,");
                strSql2.Append("'" + model.Mange_Status + "',");
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
            if (model.Manage_Type_Code != null)
            {
                strSql1.Append("Manage_Type_Code,");
                strSql2.Append("'" + model.Manage_Type_Code + "',");
            }
            if (model.Manage_Type_Name != null)
            {
                strSql1.Append("Manage_Type_Name,");
                strSql2.Append("'" + model.Manage_Type_Name + "',");
            }
            if (model.Manage_Type_Group != null)
            {
                strSql1.Append("Manage_Type_Group,");
                strSql2.Append("'" + model.Manage_Type_Group + "',");
            }
            if (model.Manage_Type_Remark != null)
            {
                strSql1.Append("Manage_Type_Remark,");
                strSql2.Append("'" + model.Manage_Type_Remark + "',");
            }
            if (model.Manage_Type_InOut != null)
            {
                strSql1.Append("Manage_Type_InOut,");
                strSql2.Append("'" + model.Manage_Type_InOut + "',");
            }
            if (model.Mange_ID != null)
            {
                strSql1.Append("Mange_ID,");
                strSql2.Append("'" + model.Mange_ID + "',");
            }
            if (model.Manage_Type_Order != null)
            {
                strSql1.Append("Manage_Type_Order,");
                strSql2.Append("" + model.Manage_Type_Order + ",");
            }
            if (model.Manage_Type_Flag != null)
            {
                strSql1.Append("Manage_Type_Flag,");
                strSql2.Append("'" + model.Manage_Type_Flag + "',");
            }
            if (model.Manage_Type_Reserve1 != null)
            {
                strSql1.Append("Manage_Type_Reserve1,");
                strSql2.Append("'" + model.Manage_Type_Reserve1 + "',");
            }
            if (model.Manage_Type_Reserve2 != null)
            {
                strSql1.Append("Manage_Type_Reserve2,");
                strSql2.Append("'" + model.Manage_Type_Reserve2 + "',");
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
            if (model.Mange_CreateTime != null)
            {
                strSql1.Append("Mange_CreateTime,");
                strSql2.Append("'" + model.Mange_CreateTime + "',");
            }
            strSql.Append("insert into View_Manage(");
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
        public bool Update(WMS_Database.View_ManageModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_Manage set ");
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
            if (model.Mange_Stock_Barcode != null)
            {
                strSql.Append("Mange_Stock_Barcode='" + model.Mange_Stock_Barcode + "',");
            }
            else
            {
                strSql.Append("Mange_Stock_Barcode= null ,");
            }
            if (model.Mange_Status != null)
            {
                strSql.Append("Mange_Status='" + model.Mange_Status + "',");
            }
            else
            {
                strSql.Append("Mange_Status= null ,");
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
            if (model.Manage_Type_Code != null)
            {
                strSql.Append("Manage_Type_Code='" + model.Manage_Type_Code + "',");
            }
            if (model.Manage_Type_Name != null)
            {
                strSql.Append("Manage_Type_Name='" + model.Manage_Type_Name + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Name= null ,");
            }
            if (model.Manage_Type_Group != null)
            {
                strSql.Append("Manage_Type_Group='" + model.Manage_Type_Group + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Group= null ,");
            }
            if (model.Manage_Type_Remark != null)
            {
                strSql.Append("Manage_Type_Remark='" + model.Manage_Type_Remark + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Remark= null ,");
            }
            if (model.Manage_Type_InOut != null)
            {
                strSql.Append("Manage_Type_InOut='" + model.Manage_Type_InOut + "',");
            }
            else
            {
                strSql.Append("Manage_Type_InOut= null ,");
            }
            if (model.Mange_ID != null)
            {
                strSql.Append("Mange_ID='" + model.Mange_ID + "',");
            }
            if (model.Manage_Type_Order != null)
            {
                strSql.Append("Manage_Type_Order=" + model.Manage_Type_Order + ",");
            }
            else
            {
                strSql.Append("Manage_Type_Order= null ,");
            }
            if (model.Manage_Type_Flag != null)
            {
                strSql.Append("Manage_Type_Flag='" + model.Manage_Type_Flag + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Flag= null ,");
            }
            if (model.Manage_Type_Reserve1 != null)
            {
                strSql.Append("Manage_Type_Reserve1='" + model.Manage_Type_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Reserve1= null ,");
            }
            if (model.Manage_Type_Reserve2 != null)
            {
                strSql.Append("Manage_Type_Reserve2='" + model.Manage_Type_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Reserve2= null ,");
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
            if (model.Mange_CreateTime != null)
            {
                strSql.Append("Mange_CreateTime='" + model.Mange_CreateTime + "',");
            }
            else
            {
                strSql.Append("Mange_CreateTime= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Plan_ID='" + model.Plan_ID + "' and Mange_Type_ID='" + model.Mange_Type_ID + "' and Mange_Stock_Barcode='" + model.Mange_Stock_Barcode + "' and Mange_Status='" + model.Mange_Status + "' and Mange_Full_Flag='" + model.Mange_Full_Flag + "' and Manage_BreakDown_Status='" + model.Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + model.Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + model.Mange_End_Cell_ID + "' and Manage_Operater='" + model.Manage_Operater + "' and Manage_Begin_Time='" + model.Manage_Begin_Time + "' and Manage_End_Time='" + model.Manage_End_Time + "' and Manage_Type_Code='" + model.Manage_Type_Code + "' and Manage_Type_Name='" + model.Manage_Type_Name + "' and Manage_Type_Group='" + model.Manage_Type_Group + "' and Manage_Type_Remark='" + model.Manage_Type_Remark + "' and Manage_Type_InOut='" + model.Manage_Type_InOut + "' and Mange_ID='" + model.Mange_ID + "' and Manage_Type_Order=" + model.Manage_Type_Order + " and Manage_Type_Flag='" + model.Manage_Type_Flag + "' and Manage_Type_Reserve1='" + model.Manage_Type_Reserve1 + "' and Manage_Type_Reserve2='" + model.Manage_Type_Reserve2 + "' and Manage_Remark='" + model.Manage_Remark + "' and Mange_Reserve1='" + model.Mange_Reserve1 + "' and Mange_CreateTime='" + model.Mange_CreateTime + "' ");
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
        public bool Delete(string Plan_ID, string Mange_Type_ID, string Mange_Stock_Barcode, string Mange_Status, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_Group, string Manage_Type_Remark, string Manage_Type_InOut, string Mange_ID, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Reserve1, string Manage_Type_Reserve2, string Manage_Remark, string Mange_Reserve1, DateTime Mange_CreateTime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_Manage ");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Status='" + Mange_Status + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Type_Code='" + Manage_Type_Code + "' and Manage_Type_Name='" + Manage_Type_Name + "' and Manage_Type_Group='" + Manage_Type_Group + "' and Manage_Type_Remark='" + Manage_Type_Remark + "' and Manage_Type_InOut='" + Manage_Type_InOut + "' and Mange_ID='" + Mange_ID + "' and Manage_Type_Order=" + Manage_Type_Order + " and Manage_Type_Flag='" + Manage_Type_Flag + "' and Manage_Type_Reserve1='" + Manage_Type_Reserve1 + "' and Manage_Type_Reserve2='" + Manage_Type_Reserve2 + "' and Manage_Remark='" + Manage_Remark + "' and Mange_Reserve1='" + Mange_Reserve1 + "' and Mange_CreateTime='" + Mange_CreateTime + "' ");
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
        /// 得到一个对象实体
        /// </summary>
        public WMS_Database.View_ManageModel GetModel(string Plan_ID, string Mange_Type_ID, string Mange_Stock_Barcode, string Mange_Status, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_Group, string Manage_Type_Remark, string Manage_Type_InOut, string Mange_ID, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Reserve1, string Manage_Type_Reserve2, string Manage_Remark, string Mange_Reserve1, DateTime Mange_CreateTime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Plan_ID,Mange_Type_ID,Mange_Stock_Barcode,Mange_Status,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Type_Code,Manage_Type_Name,Manage_Type_Group,Manage_Type_Remark,Manage_Type_InOut,Mange_ID,Manage_Type_Order,Manage_Type_Flag,Manage_Type_Reserve1,Manage_Type_Reserve2,Manage_Remark,Mange_Reserve1,Mange_CreateTime ");
            strSql.Append(" from View_Manage ");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Status='" + Mange_Status + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Type_Code='" + Manage_Type_Code + "' and Manage_Type_Name='" + Manage_Type_Name + "' and Manage_Type_Group='" + Manage_Type_Group + "' and Manage_Type_Remark='" + Manage_Type_Remark + "' and Manage_Type_InOut='" + Manage_Type_InOut + "' and Mange_ID='" + Mange_ID + "' and Manage_Type_Order=" + Manage_Type_Order + " and Manage_Type_Flag='" + Manage_Type_Flag + "' and Manage_Type_Reserve1='" + Manage_Type_Reserve1 + "' and Manage_Type_Reserve2='" + Manage_Type_Reserve2 + "' and Manage_Remark='" + Manage_Remark + "' and Mange_Reserve1='" + Mange_Reserve1 + "' and Mange_CreateTime='" + Mange_CreateTime + "' ");
            WMS_Database.View_ManageModel model = new WMS_Database.View_ManageModel();
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
        public WMS_Database.View_ManageModel DataRowToModel(DataRow row)
        {
            WMS_Database.View_ManageModel model = new WMS_Database.View_ManageModel();
            if (row != null)
            {
                if (row["Plan_ID"] != null)
                {
                    model.Plan_ID = row["Plan_ID"].ToString();
                }
                if (row["Mange_Type_ID"] != null)
                {
                    model.Mange_Type_ID = row["Mange_Type_ID"].ToString();
                }
                if (row["Mange_Stock_Barcode"] != null)
                {
                    model.Mange_Stock_Barcode = row["Mange_Stock_Barcode"].ToString();
                }
                if (row["Mange_Status"] != null)
                {
                    model.Mange_Status = row["Mange_Status"].ToString();
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
                if (row["Manage_Type_Code"] != null)
                {
                    model.Manage_Type_Code = row["Manage_Type_Code"].ToString();
                }
                if (row["Manage_Type_Name"] != null)
                {
                    model.Manage_Type_Name = row["Manage_Type_Name"].ToString();
                }
                if (row["Manage_Type_Group"] != null)
                {
                    model.Manage_Type_Group = row["Manage_Type_Group"].ToString();
                }
                if (row["Manage_Type_Remark"] != null)
                {
                    model.Manage_Type_Remark = row["Manage_Type_Remark"].ToString();
                }
                if (row["Manage_Type_InOut"] != null)
                {
                    model.Manage_Type_InOut = row["Manage_Type_InOut"].ToString();
                }
                if (row["Mange_ID"] != null)
                {
                    model.Mange_ID = row["Mange_ID"].ToString();
                }
                if (row["Manage_Type_Order"] != null && row["Manage_Type_Order"].ToString() != "")
                {
                    model.Manage_Type_Order = int.Parse(row["Manage_Type_Order"].ToString());
                }
                if (row["Manage_Type_Flag"] != null)
                {
                    model.Manage_Type_Flag = row["Manage_Type_Flag"].ToString();
                }
                if (row["Manage_Type_Reserve1"] != null)
                {
                    model.Manage_Type_Reserve1 = row["Manage_Type_Reserve1"].ToString();
                }
                if (row["Manage_Type_Reserve2"] != null)
                {
                    model.Manage_Type_Reserve2 = row["Manage_Type_Reserve2"].ToString();
                }
                if (row["Manage_Remark"] != null)
                {
                    model.Manage_Remark = row["Manage_Remark"].ToString();
                }
                if (row["Mange_Reserve1"] != null)
                {
                    model.Mange_Reserve1 = row["Mange_Reserve1"].ToString();
                }
                if (row["Mange_CreateTime"] != null && row["Mange_CreateTime"].ToString() != "")
                {
                    model.Mange_CreateTime = DateTime.Parse(row["Mange_CreateTime"].ToString());
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
            strSql.Append("select Plan_ID,Mange_Type_ID,Mange_Stock_Barcode,Mange_Status,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Type_Code,Manage_Type_Name,Manage_Type_Group,Manage_Type_Remark,Manage_Type_InOut,Mange_ID,Manage_Type_Order,Manage_Type_Flag,Manage_Type_Reserve1,Manage_Type_Reserve2,Manage_Remark,Mange_Reserve1,Mange_CreateTime ");
            strSql.Append(" FROM View_Manage ");
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
            strSql.Append(" Plan_ID,Mange_Type_ID,Mange_Stock_Barcode,Mange_Status,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Type_Code,Manage_Type_Name,Manage_Type_Group,Manage_Type_Remark,Manage_Type_InOut,Mange_ID,Manage_Type_Order,Manage_Type_Flag,Manage_Type_Reserve1,Manage_Type_Reserve2,Manage_Remark,Mange_Reserve1,Mange_CreateTime ");
            strSql.Append(" FROM View_Manage ");
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
            strSql.Append("select count(1) FROM View_Manage ");
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
                strSql.Append("order by T.Mange_CreateTime desc");
            }
            strSql.Append(")AS Row, T.*  from View_Manage T ");
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

