using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:View_Record
    /// </summary>
    public partial class View_RecordDAL
    {
        public View_RecordDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Manage_Type_Code, string Stock_Tray_Barcode, string Start_Cell_ID, string End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Record_Remark, string Record_ID, string Plan_List_ID, string Goods_ID, string Record_Box_Barcode, string Record_List_Quantity, string Record_List_Remark, string Record_List_Reserve1, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Batch, string Goods_Model, string Goods_Suppier_Code, string Goods_Desc, string Goods_Level, string Record_List_ID, string Record_OperateType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_Record");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Manage_Type_Code='" + Manage_Type_Code + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Start_Cell_ID='" + Start_Cell_ID + "' and End_Cell_ID='" + End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Record_Remark='" + Record_Remark + "' and Record_ID='" + Record_ID + "' and Plan_List_ID='" + Plan_List_ID + "' and Goods_ID='" + Goods_ID + "' and Record_Box_Barcode='" + Record_Box_Barcode + "' and Record_List_Quantity='" + Record_List_Quantity + "' and Record_List_Remark='" + Record_List_Remark + "' and Record_List_Reserve1='" + Record_List_Reserve1 + "' and Goods_Class_ID='" + Goods_Class_ID + "' and Goods_Code='" + Goods_Code + "' and Goods_Name='" + Goods_Name + "' and Goods_Type='" + Goods_Type + "' and Goods_Batch='" + Goods_Batch + "' and Goods_Model='" + Goods_Model + "' and Goods_Suppier_Code='" + Goods_Suppier_Code + "' and Goods_Desc='" + Goods_Desc + "' and Goods_Level='" + Goods_Level + "' and Record_List_ID='" + Record_List_ID + "' and Record_OperateType='" + Record_OperateType + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_RecordModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
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
            if (model.Goods_Class_ID != null)
            {
                strSql1.Append("Goods_Class_ID,");
                strSql2.Append("'" + model.Goods_Class_ID + "',");
            }
            if (model.Goods_Code != null)
            {
                strSql1.Append("Goods_Code,");
                strSql2.Append("'" + model.Goods_Code + "',");
            }
            if (model.Goods_Name != null)
            {
                strSql1.Append("Goods_Name,");
                strSql2.Append("'" + model.Goods_Name + "',");
            }
            if (model.Goods_Type != null)
            {
                strSql1.Append("Goods_Type,");
                strSql2.Append("'" + model.Goods_Type + "',");
            }
            if (model.Goods_Batch != null)
            {
                strSql1.Append("Goods_Batch,");
                strSql2.Append("'" + model.Goods_Batch + "',");
            }
            if (model.Goods_Model != null)
            {
                strSql1.Append("Goods_Model,");
                strSql2.Append("'" + model.Goods_Model + "',");
            }
            if (model.Goods_Suppier_Code != null)
            {
                strSql1.Append("Goods_Suppier_Code,");
                strSql2.Append("'" + model.Goods_Suppier_Code + "',");
            }
            if (model.Goods_Desc != null)
            {
                strSql1.Append("Goods_Desc,");
                strSql2.Append("'" + model.Goods_Desc + "',");
            }
            if (model.Goods_Level != null)
            {
                strSql1.Append("Goods_Level,");
                strSql2.Append("'" + model.Goods_Level + "',");
            }
            if (model.Record_List_ID != null)
            {
                strSql1.Append("Record_List_ID,");
                strSql2.Append("'" + model.Record_List_ID + "',");
            }
            if (model.Record_OperateType != null)
            {
                strSql1.Append("Record_OperateType,");
                strSql2.Append("'" + model.Record_OperateType + "',");
            }
            strSql.Append("insert into View_Record(");
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
        public bool Update(WMS_Database.View_RecordModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_Record set ");
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
            if (model.Goods_Class_ID != null)
            {
                strSql.Append("Goods_Class_ID='" + model.Goods_Class_ID + "',");
            }
            if (model.Goods_Code != null)
            {
                strSql.Append("Goods_Code='" + model.Goods_Code + "',");
            }
            else
            {
                strSql.Append("Goods_Code= null ,");
            }
            if (model.Goods_Name != null)
            {
                strSql.Append("Goods_Name='" + model.Goods_Name + "',");
            }
            else
            {
                strSql.Append("Goods_Name= null ,");
            }
            if (model.Goods_Type != null)
            {
                strSql.Append("Goods_Type='" + model.Goods_Type + "',");
            }
            else
            {
                strSql.Append("Goods_Type= null ,");
            }
            if (model.Goods_Batch != null)
            {
                strSql.Append("Goods_Batch='" + model.Goods_Batch + "',");
            }
            else
            {
                strSql.Append("Goods_Batch= null ,");
            }
            if (model.Goods_Model != null)
            {
                strSql.Append("Goods_Model='" + model.Goods_Model + "',");
            }
            else
            {
                strSql.Append("Goods_Model= null ,");
            }
            if (model.Goods_Suppier_Code != null)
            {
                strSql.Append("Goods_Suppier_Code='" + model.Goods_Suppier_Code + "',");
            }
            else
            {
                strSql.Append("Goods_Suppier_Code= null ,");
            }
            if (model.Goods_Desc != null)
            {
                strSql.Append("Goods_Desc='" + model.Goods_Desc + "',");
            }
            else
            {
                strSql.Append("Goods_Desc= null ,");
            }
            if (model.Goods_Level != null)
            {
                strSql.Append("Goods_Level='" + model.Goods_Level + "',");
            }
            else
            {
                strSql.Append("Goods_Level= null ,");
            }
            if (model.Record_List_ID != null)
            {
                strSql.Append("Record_List_ID='" + model.Record_List_ID + "',");
            }
            if (model.Record_OperateType != null)
            {
                strSql.Append("Record_OperateType='" + model.Record_OperateType + "',");
            }
            else
            {
                strSql.Append("Record_OperateType= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Plan_ID='" + model.Plan_ID + "' and Manage_Type_Code='" + model.Manage_Type_Code + "' and Stock_Tray_Barcode='" + model.Stock_Tray_Barcode + "' and Start_Cell_ID='" + model.Start_Cell_ID + "' and End_Cell_ID='" + model.End_Cell_ID + "' and Manage_Operater='" + model.Manage_Operater + "' and Manage_Begin_Time='" + model.Manage_Begin_Time + "' and Manage_End_Time='" + model.Manage_End_Time + "' and Record_Remark='" + model.Record_Remark + "' and Record_ID='" + model.Record_ID + "' and Plan_List_ID='" + model.Plan_List_ID + "' and Goods_ID='" + model.Goods_ID + "' and Record_Box_Barcode='" + model.Record_Box_Barcode + "' and Record_List_Quantity='" + model.Record_List_Quantity + "' and Record_List_Remark='" + model.Record_List_Remark + "' and Record_List_Reserve1='" + model.Record_List_Reserve1 + "' and Goods_Class_ID='" + model.Goods_Class_ID + "' and Goods_Code='" + model.Goods_Code + "' and Goods_Name='" + model.Goods_Name + "' and Goods_Type='" + model.Goods_Type + "' and Goods_Batch='" + model.Goods_Batch + "' and Goods_Model='" + model.Goods_Model + "' and Goods_Suppier_Code='" + model.Goods_Suppier_Code + "' and Goods_Desc='" + model.Goods_Desc + "' and Goods_Level='" + model.Goods_Level + "' and Record_List_ID='" + model.Record_List_ID + "' and Record_OperateType='" + model.Record_OperateType + "' ");
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
        public bool Delete(string Plan_ID, string Manage_Type_Code, string Stock_Tray_Barcode, string Start_Cell_ID, string End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Record_Remark, string Record_ID, string Plan_List_ID, string Goods_ID, string Record_Box_Barcode, string Record_List_Quantity, string Record_List_Remark, string Record_List_Reserve1, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Batch, string Goods_Model, string Goods_Suppier_Code, string Goods_Desc, string Goods_Level, string Record_List_ID, string Record_OperateType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_Record ");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Manage_Type_Code='" + Manage_Type_Code + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Start_Cell_ID='" + Start_Cell_ID + "' and End_Cell_ID='" + End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Record_Remark='" + Record_Remark + "' and Record_ID='" + Record_ID + "' and Plan_List_ID='" + Plan_List_ID + "' and Goods_ID='" + Goods_ID + "' and Record_Box_Barcode='" + Record_Box_Barcode + "' and Record_List_Quantity='" + Record_List_Quantity + "' and Record_List_Remark='" + Record_List_Remark + "' and Record_List_Reserve1='" + Record_List_Reserve1 + "' and Goods_Class_ID='" + Goods_Class_ID + "' and Goods_Code='" + Goods_Code + "' and Goods_Name='" + Goods_Name + "' and Goods_Type='" + Goods_Type + "' and Goods_Batch='" + Goods_Batch + "' and Goods_Model='" + Goods_Model + "' and Goods_Suppier_Code='" + Goods_Suppier_Code + "' and Goods_Desc='" + Goods_Desc + "' and Goods_Level='" + Goods_Level + "' and Record_List_ID='" + Record_List_ID + "' and Record_OperateType='" + Record_OperateType + "' ");
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
        public WMS_Database.View_RecordModel GetModel(string Plan_ID, string Manage_Type_Code, string Stock_Tray_Barcode, string Start_Cell_ID, string End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Record_Remark, string Record_ID, string Plan_List_ID, string Goods_ID, string Record_Box_Barcode, string Record_List_Quantity, string Record_List_Remark, string Record_List_Reserve1, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Batch, string Goods_Model, string Goods_Suppier_Code, string Goods_Desc, string Goods_Level, string Record_List_ID, string Record_OperateType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Plan_ID,Manage_Type_Code,Stock_Tray_Barcode,Start_Cell_ID,End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Record_Remark,Record_ID,Plan_List_ID,Goods_ID,Record_Box_Barcode,Record_List_Quantity,Record_List_Remark,Record_List_Reserve1,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Batch,Goods_Model,Goods_Suppier_Code,Goods_Desc,Goods_Level,Record_List_ID,Record_OperateType ");
            strSql.Append(" from View_Record ");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Manage_Type_Code='" + Manage_Type_Code + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Start_Cell_ID='" + Start_Cell_ID + "' and End_Cell_ID='" + End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Record_Remark='" + Record_Remark + "' and Record_ID='" + Record_ID + "' and Plan_List_ID='" + Plan_List_ID + "' and Goods_ID='" + Goods_ID + "' and Record_Box_Barcode='" + Record_Box_Barcode + "' and Record_List_Quantity='" + Record_List_Quantity + "' and Record_List_Remark='" + Record_List_Remark + "' and Record_List_Reserve1='" + Record_List_Reserve1 + "' and Goods_Class_ID='" + Goods_Class_ID + "' and Goods_Code='" + Goods_Code + "' and Goods_Name='" + Goods_Name + "' and Goods_Type='" + Goods_Type + "' and Goods_Batch='" + Goods_Batch + "' and Goods_Model='" + Goods_Model + "' and Goods_Suppier_Code='" + Goods_Suppier_Code + "' and Goods_Desc='" + Goods_Desc + "' and Goods_Level='" + Goods_Level + "' and Record_List_ID='" + Record_List_ID + "' and Record_OperateType='" + Record_OperateType + "' ");
            WMS_Database.View_RecordModel model = new WMS_Database.View_RecordModel();
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
        public WMS_Database.View_RecordModel DataRowToModel(DataRow row)
        {
            WMS_Database.View_RecordModel model = new WMS_Database.View_RecordModel();
            if (row != null)
            {
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
                if (row["Goods_Class_ID"] != null)
                {
                    model.Goods_Class_ID = row["Goods_Class_ID"].ToString();
                }
                if (row["Goods_Code"] != null)
                {
                    model.Goods_Code = row["Goods_Code"].ToString();
                }
                if (row["Goods_Name"] != null)
                {
                    model.Goods_Name = row["Goods_Name"].ToString();
                }
                if (row["Goods_Type"] != null)
                {
                    model.Goods_Type = row["Goods_Type"].ToString();
                }
                if (row["Goods_Batch"] != null)
                {
                    model.Goods_Batch = row["Goods_Batch"].ToString();
                }
                if (row["Goods_Model"] != null)
                {
                    model.Goods_Model = row["Goods_Model"].ToString();
                }
                if (row["Goods_Suppier_Code"] != null)
                {
                    model.Goods_Suppier_Code = row["Goods_Suppier_Code"].ToString();
                }
                if (row["Goods_Desc"] != null)
                {
                    model.Goods_Desc = row["Goods_Desc"].ToString();
                }
                if (row["Goods_Level"] != null)
                {
                    model.Goods_Level = row["Goods_Level"].ToString();
                }
                if (row["Record_List_ID"] != null)
                {
                    model.Record_List_ID = row["Record_List_ID"].ToString();
                }
                if (row["Record_OperateType"] != null)
                {
                    model.Record_OperateType = row["Record_OperateType"].ToString();
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
            strSql.Append("select Plan_ID,Manage_Type_Code,Stock_Tray_Barcode,Start_Cell_ID,End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Record_Remark,Record_ID,Plan_List_ID,Goods_ID,Record_Box_Barcode,Record_List_Quantity,Record_List_Remark,Record_List_Reserve1,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Batch,Goods_Model,Goods_Suppier_Code,Goods_Desc,Goods_Level,Record_List_ID,Record_OperateType ");
            strSql.Append(" FROM View_Record ");
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
            strSql.Append(" Plan_ID,Manage_Type_Code,Stock_Tray_Barcode,Start_Cell_ID,End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Record_Remark,Record_ID,Plan_List_ID,Goods_ID,Record_Box_Barcode,Record_List_Quantity,Record_List_Remark,Record_List_Reserve1,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Batch,Goods_Model,Goods_Suppier_Code,Goods_Desc,Goods_Level,Record_List_ID,Record_OperateType ");
            strSql.Append(" FROM View_Record ");
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
            strSql.Append("select count(1) FROM View_Record ");
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
                strSql.Append("order by T.Record_OperateType desc");
            }
            strSql.Append(")AS Row, T.*  from View_Record T ");
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

