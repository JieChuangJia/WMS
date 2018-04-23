using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WMS_Database;

namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:View_PlanList
    /// </summary>
    public partial class View_PlanListDAL
    {
        public View_PlanListDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Remark, string Goods_Department, int Goods_Shelf_Life, string Goods_Asset, DateTime Goods_ProduceDate, string Goods_Danger, string Goods_Category, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Flag, string Goods_Class_Reserve1, string Goods_Class_Reserve2, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Goods_ID, string Plan_List_Status, string Plan_List_Remark, string Plan_List_Resever1, string Plan_List_Resever2, string Plan_List_ID, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_Begin_Time, DateTime Plan_End_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Plan_Type_Code, string Plan_Type_Name, string Plan_Type_Group, string Plan_Type_InOut, int Plan_Type_Order, string Plan_Type_Remark, string Plan_Type_Flag, string Goods_Batch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_PlanList");
            strSql.Append(" where Plan_ID=@Plan_ID and Goods_Class_ID=@Goods_Class_ID and Goods_Code=@Goods_Code and Goods_Name=@Goods_Name and Goods_Type=@Goods_Type and Goods_Suppier_Code=@Goods_Suppier_Code and Goods_Model=@Goods_Model and Goods_Desc=@Goods_Desc and Goods_Level=@Goods_Level and Goods_Unit=@Goods_Unit and Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity and Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity and Goods_Order=@Goods_Order and Goods_Flag=@Goods_Flag and Goods_Remark=@Goods_Remark and Goods_Department=@Goods_Department and Goods_Shelf_Life=@Goods_Shelf_Life and Goods_Asset=@Goods_Asset and Goods_ProduceDate=@Goods_ProduceDate and Goods_Danger=@Goods_Danger and Goods_Category=@Goods_Category and Goods_Class_Parent_ID=@Goods_Class_Parent_ID and Goods_Class_Code=@Goods_Class_Code and Goods_Class_Name=@Goods_Class_Name and Goods_Class_Remark=@Goods_Class_Remark and Goods_Class_Order=@Goods_Class_Order and Goods_Class_Flag=@Goods_Class_Flag and Goods_Class_Reserve1=@Goods_Class_Reserve1 and Goods_Class_Reserve2=@Goods_Class_Reserve2 and Plan_List_Quantity=@Plan_List_Quantity and Plan_List_Ordered_Quantity=@Plan_List_Ordered_Quantity and Plan_List_Finished_Quantity=@Plan_List_Finished_Quantity and Goods_ID=@Goods_ID and Plan_List_Status=@Plan_List_Status and Plan_List_Remark=@Plan_List_Remark and Plan_List_Resever1=@Plan_List_Resever1 and Plan_List_Resever2=@Plan_List_Resever2 and Plan_List_ID=@Plan_List_ID and Plan_Type_ID=@Plan_Type_ID and Plan_Serial_Num=@Plan_Serial_Num and Plan_Code=@Plan_Code and Plan_Create_Time=@Plan_Create_Time and Plan_Begin_Time=@Plan_Begin_Time and Plan_End_Time=@Plan_End_Time and Plan_Bill_Time=@Plan_Bill_Time and Plan_Status=@Plan_Status and Plan_Operater=@Plan_Operater and Plan_From_Dept=@Plan_From_Dept and Plan_To_Dept=@Plan_To_Dept and Plan_From_User=@Plan_From_User and Plan_To_User=@Plan_To_User and Plan_Import_Flag=@Plan_Import_Flag and Plan_Remark=@Plan_Remark and Plan_Type_Code=@Plan_Type_Code and Plan_Type_Name=@Plan_Type_Name and Plan_Type_Group=@Plan_Type_Group and Plan_Type_InOut=@Plan_Type_InOut and Plan_Type_Order=@Plan_Type_Order and Plan_Type_Remark=@Plan_Type_Remark and Plan_Type_Flag=@Plan_Type_Flag and Goods_Batch=@Goods_Batch ");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Shelf_Life", SqlDbType.Int,4),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ProduceDate", SqlDbType.DateTime),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Ordered_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Finished_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@Plan_List_Resever1", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Resever2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Serial_Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Create_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Begin_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_End_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Bill_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Operater", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Import_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Group", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Order", SqlDbType.Int,4),
					new SqlParameter("@Plan_Type_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Batch", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Plan_ID;
            parameters[1].Value = Goods_Class_ID;
            parameters[2].Value = Goods_Code;
            parameters[3].Value = Goods_Name;
            parameters[4].Value = Goods_Type;
            parameters[5].Value = Goods_Suppier_Code;
            parameters[6].Value = Goods_Model;
            parameters[7].Value = Goods_Desc;
            parameters[8].Value = Goods_Level;
            parameters[9].Value = Goods_Unit;
            parameters[10].Value = Goods_Limit_Upper_Quantity;
            parameters[11].Value = Goods_Limit_Lower_Quantity;
            parameters[12].Value = Goods_Order;
            parameters[13].Value = Goods_Flag;
            parameters[14].Value = Goods_Remark;
            parameters[15].Value = Goods_Department;
            parameters[16].Value = Goods_Shelf_Life;
            parameters[17].Value = Goods_Asset;
            parameters[18].Value = Goods_ProduceDate;
            parameters[19].Value = Goods_Danger;
            parameters[20].Value = Goods_Category;
            parameters[21].Value = Goods_Class_Parent_ID;
            parameters[22].Value = Goods_Class_Code;
            parameters[23].Value = Goods_Class_Name;
            parameters[24].Value = Goods_Class_Remark;
            parameters[25].Value = Goods_Class_Order;
            parameters[26].Value = Goods_Class_Flag;
            parameters[27].Value = Goods_Class_Reserve1;
            parameters[28].Value = Goods_Class_Reserve2;
            parameters[29].Value = Plan_List_Quantity;
            parameters[30].Value = Plan_List_Ordered_Quantity;
            parameters[31].Value = Plan_List_Finished_Quantity;
            parameters[32].Value = Goods_ID;
            parameters[33].Value = Plan_List_Status;
            parameters[34].Value = Plan_List_Remark;
            parameters[35].Value = Plan_List_Resever1;
            parameters[36].Value = Plan_List_Resever2;
            parameters[37].Value = Plan_List_ID;
            parameters[38].Value = Plan_Type_ID;
            parameters[39].Value = Plan_Serial_Num;
            parameters[40].Value = Plan_Code;
            parameters[41].Value = Plan_Create_Time;
            parameters[42].Value = Plan_Begin_Time;
            parameters[43].Value = Plan_End_Time;
            parameters[44].Value = Plan_Bill_Time;
            parameters[45].Value = Plan_Status;
            parameters[46].Value = Plan_Operater;
            parameters[47].Value = Plan_From_Dept;
            parameters[48].Value = Plan_To_Dept;
            parameters[49].Value = Plan_From_User;
            parameters[50].Value = Plan_To_User;
            parameters[51].Value = Plan_Import_Flag;
            parameters[52].Value = Plan_Remark;
            parameters[53].Value = Plan_Type_Code;
            parameters[54].Value = Plan_Type_Name;
            parameters[55].Value = Plan_Type_Group;
            parameters[56].Value = Plan_Type_InOut;
            parameters[57].Value = Plan_Type_Order;
            parameters[58].Value = Plan_Type_Remark;
            parameters[59].Value = Plan_Type_Flag;
            parameters[60].Value = Goods_Batch;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_PlanListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into View_PlanList(");
            strSql.Append("Plan_ID,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Remark,Goods_Department,Goods_Shelf_Life,Goods_Asset,Goods_ProduceDate,Goods_Danger,Goods_Category,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Flag,Goods_Class_Reserve1,Goods_Class_Reserve2,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Goods_ID,Plan_List_Status,Plan_List_Remark,Plan_List_Resever1,Plan_List_Resever2,Plan_List_ID,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_Begin_Time,Plan_End_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Plan_Type_Code,Plan_Type_Name,Plan_Type_Group,Plan_Type_InOut,Plan_Type_Order,Plan_Type_Remark,Plan_Type_Flag,Goods_Batch)");
            strSql.Append(" values (");
            strSql.Append("@Plan_ID,@Goods_Class_ID,@Goods_Code,@Goods_Name,@Goods_Type,@Goods_Suppier_Code,@Goods_Model,@Goods_Desc,@Goods_Level,@Goods_Unit,@Goods_Limit_Upper_Quantity,@Goods_Limit_Lower_Quantity,@Goods_Order,@Goods_Flag,@Goods_Remark,@Goods_Department,@Goods_Shelf_Life,@Goods_Asset,@Goods_ProduceDate,@Goods_Danger,@Goods_Category,@Goods_Class_Parent_ID,@Goods_Class_Code,@Goods_Class_Name,@Goods_Class_Remark,@Goods_Class_Order,@Goods_Class_Flag,@Goods_Class_Reserve1,@Goods_Class_Reserve2,@Plan_List_Quantity,@Plan_List_Ordered_Quantity,@Plan_List_Finished_Quantity,@Goods_ID,@Plan_List_Status,@Plan_List_Remark,@Plan_List_Resever1,@Plan_List_Resever2,@Plan_List_ID,@Plan_Type_ID,@Plan_Serial_Num,@Plan_Code,@Plan_Create_Time,@Plan_Begin_Time,@Plan_End_Time,@Plan_Bill_Time,@Plan_Status,@Plan_Operater,@Plan_From_Dept,@Plan_To_Dept,@Plan_From_User,@Plan_To_User,@Plan_Import_Flag,@Plan_Remark,@Plan_Type_Code,@Plan_Type_Name,@Plan_Type_Group,@Plan_Type_InOut,@Plan_Type_Order,@Plan_Type_Remark,@Plan_Type_Flag,@Goods_Batch)");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Shelf_Life", SqlDbType.Int,4),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ProduceDate", SqlDbType.DateTime),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Ordered_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Finished_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@Plan_List_Resever1", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Resever2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Serial_Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Create_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Begin_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_End_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Bill_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Operater", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Import_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Group", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Order", SqlDbType.Int,4),
					new SqlParameter("@Plan_Type_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Batch", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Plan_ID;
            parameters[1].Value = model.Goods_Class_ID;
            parameters[2].Value = model.Goods_Code;
            parameters[3].Value = model.Goods_Name;
            parameters[4].Value = model.Goods_Type;
            parameters[5].Value = model.Goods_Suppier_Code;
            parameters[6].Value = model.Goods_Model;
            parameters[7].Value = model.Goods_Desc;
            parameters[8].Value = model.Goods_Level;
            parameters[9].Value = model.Goods_Unit;
            parameters[10].Value = model.Goods_Limit_Upper_Quantity;
            parameters[11].Value = model.Goods_Limit_Lower_Quantity;
            parameters[12].Value = model.Goods_Order;
            parameters[13].Value = model.Goods_Flag;
            parameters[14].Value = model.Goods_Remark;
            parameters[15].Value = model.Goods_Department;
            parameters[16].Value = model.Goods_Shelf_Life;
            parameters[17].Value = model.Goods_Asset;
            parameters[18].Value = model.Goods_ProduceDate;
            parameters[19].Value = model.Goods_Danger;
            parameters[20].Value = model.Goods_Category;
            parameters[21].Value = model.Goods_Class_Parent_ID;
            parameters[22].Value = model.Goods_Class_Code;
            parameters[23].Value = model.Goods_Class_Name;
            parameters[24].Value = model.Goods_Class_Remark;
            parameters[25].Value = model.Goods_Class_Order;
            parameters[26].Value = model.Goods_Class_Flag;
            parameters[27].Value = model.Goods_Class_Reserve1;
            parameters[28].Value = model.Goods_Class_Reserve2;
            parameters[29].Value = model.Plan_List_Quantity;
            parameters[30].Value = model.Plan_List_Ordered_Quantity;
            parameters[31].Value = model.Plan_List_Finished_Quantity;
            parameters[32].Value = model.Goods_ID;
            parameters[33].Value = model.Plan_List_Status;
            parameters[34].Value = model.Plan_List_Remark;
            parameters[35].Value = model.Plan_List_Resever1;
            parameters[36].Value = model.Plan_List_Resever2;
            parameters[37].Value = model.Plan_List_ID;
            parameters[38].Value = model.Plan_Type_ID;
            parameters[39].Value = model.Plan_Serial_Num;
            parameters[40].Value = model.Plan_Code;
            parameters[41].Value = model.Plan_Create_Time;
            parameters[42].Value = model.Plan_Begin_Time;
            parameters[43].Value = model.Plan_End_Time;
            parameters[44].Value = model.Plan_Bill_Time;
            parameters[45].Value = model.Plan_Status;
            parameters[46].Value = model.Plan_Operater;
            parameters[47].Value = model.Plan_From_Dept;
            parameters[48].Value = model.Plan_To_Dept;
            parameters[49].Value = model.Plan_From_User;
            parameters[50].Value = model.Plan_To_User;
            parameters[51].Value = model.Plan_Import_Flag;
            parameters[52].Value = model.Plan_Remark;
            parameters[53].Value = model.Plan_Type_Code;
            parameters[54].Value = model.Plan_Type_Name;
            parameters[55].Value = model.Plan_Type_Group;
            parameters[56].Value = model.Plan_Type_InOut;
            parameters[57].Value = model.Plan_Type_Order;
            parameters[58].Value = model.Plan_Type_Remark;
            parameters[59].Value = model.Plan_Type_Flag;
            parameters[60].Value = model.Goods_Batch;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(WMS_Database.View_PlanListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_PlanList set ");
            strSql.Append("Plan_ID=@Plan_ID,");
            strSql.Append("Goods_Class_ID=@Goods_Class_ID,");
            strSql.Append("Goods_Code=@Goods_Code,");
            strSql.Append("Goods_Name=@Goods_Name,");
            strSql.Append("Goods_Type=@Goods_Type,");
            strSql.Append("Goods_Suppier_Code=@Goods_Suppier_Code,");
            strSql.Append("Goods_Model=@Goods_Model,");
            strSql.Append("Goods_Desc=@Goods_Desc,");
            strSql.Append("Goods_Level=@Goods_Level,");
            strSql.Append("Goods_Unit=@Goods_Unit,");
            strSql.Append("Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity,");
            strSql.Append("Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity,");
            strSql.Append("Goods_Order=@Goods_Order,");
            strSql.Append("Goods_Flag=@Goods_Flag,");
            strSql.Append("Goods_Remark=@Goods_Remark,");
            strSql.Append("Goods_Department=@Goods_Department,");
            strSql.Append("Goods_Shelf_Life=@Goods_Shelf_Life,");
            strSql.Append("Goods_Asset=@Goods_Asset,");
            strSql.Append("Goods_ProduceDate=@Goods_ProduceDate,");
            strSql.Append("Goods_Danger=@Goods_Danger,");
            strSql.Append("Goods_Category=@Goods_Category,");
            strSql.Append("Goods_Class_Parent_ID=@Goods_Class_Parent_ID,");
            strSql.Append("Goods_Class_Code=@Goods_Class_Code,");
            strSql.Append("Goods_Class_Name=@Goods_Class_Name,");
            strSql.Append("Goods_Class_Remark=@Goods_Class_Remark,");
            strSql.Append("Goods_Class_Order=@Goods_Class_Order,");
            strSql.Append("Goods_Class_Flag=@Goods_Class_Flag,");
            strSql.Append("Goods_Class_Reserve1=@Goods_Class_Reserve1,");
            strSql.Append("Goods_Class_Reserve2=@Goods_Class_Reserve2,");
            strSql.Append("Plan_List_Quantity=@Plan_List_Quantity,");
            strSql.Append("Plan_List_Ordered_Quantity=@Plan_List_Ordered_Quantity,");
            strSql.Append("Plan_List_Finished_Quantity=@Plan_List_Finished_Quantity,");
            strSql.Append("Goods_ID=@Goods_ID,");
            strSql.Append("Plan_List_Status=@Plan_List_Status,");
            strSql.Append("Plan_List_Remark=@Plan_List_Remark,");
            strSql.Append("Plan_List_Resever1=@Plan_List_Resever1,");
            strSql.Append("Plan_List_Resever2=@Plan_List_Resever2,");
            strSql.Append("Plan_List_ID=@Plan_List_ID,");
            strSql.Append("Plan_Type_ID=@Plan_Type_ID,");
            strSql.Append("Plan_Serial_Num=@Plan_Serial_Num,");
            strSql.Append("Plan_Code=@Plan_Code,");
            strSql.Append("Plan_Create_Time=@Plan_Create_Time,");
            strSql.Append("Plan_Begin_Time=@Plan_Begin_Time,");
            strSql.Append("Plan_End_Time=@Plan_End_Time,");
            strSql.Append("Plan_Bill_Time=@Plan_Bill_Time,");
            strSql.Append("Plan_Status=@Plan_Status,");
            strSql.Append("Plan_Operater=@Plan_Operater,");
            strSql.Append("Plan_From_Dept=@Plan_From_Dept,");
            strSql.Append("Plan_To_Dept=@Plan_To_Dept,");
            strSql.Append("Plan_From_User=@Plan_From_User,");
            strSql.Append("Plan_To_User=@Plan_To_User,");
            strSql.Append("Plan_Import_Flag=@Plan_Import_Flag,");
            strSql.Append("Plan_Remark=@Plan_Remark,");
            strSql.Append("Plan_Type_Code=@Plan_Type_Code,");
            strSql.Append("Plan_Type_Name=@Plan_Type_Name,");
            strSql.Append("Plan_Type_Group=@Plan_Type_Group,");
            strSql.Append("Plan_Type_InOut=@Plan_Type_InOut,");
            strSql.Append("Plan_Type_Order=@Plan_Type_Order,");
            strSql.Append("Plan_Type_Remark=@Plan_Type_Remark,");
            strSql.Append("Plan_Type_Flag=@Plan_Type_Flag,");
            strSql.Append("Goods_Batch=@Goods_Batch");
            strSql.Append(" where Plan_ID=@Plan_ID and Goods_Class_ID=@Goods_Class_ID and Goods_Code=@Goods_Code and Goods_Name=@Goods_Name and Goods_Type=@Goods_Type and Goods_Suppier_Code=@Goods_Suppier_Code and Goods_Model=@Goods_Model and Goods_Desc=@Goods_Desc and Goods_Level=@Goods_Level and Goods_Unit=@Goods_Unit and Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity and Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity and Goods_Order=@Goods_Order and Goods_Flag=@Goods_Flag and Goods_Remark=@Goods_Remark and Goods_Department=@Goods_Department and Goods_Shelf_Life=@Goods_Shelf_Life and Goods_Asset=@Goods_Asset and Goods_ProduceDate=@Goods_ProduceDate and Goods_Danger=@Goods_Danger and Goods_Category=@Goods_Category and Goods_Class_Parent_ID=@Goods_Class_Parent_ID and Goods_Class_Code=@Goods_Class_Code and Goods_Class_Name=@Goods_Class_Name and Goods_Class_Remark=@Goods_Class_Remark and Goods_Class_Order=@Goods_Class_Order and Goods_Class_Flag=@Goods_Class_Flag and Goods_Class_Reserve1=@Goods_Class_Reserve1 and Goods_Class_Reserve2=@Goods_Class_Reserve2 and Plan_List_Quantity=@Plan_List_Quantity and Plan_List_Ordered_Quantity=@Plan_List_Ordered_Quantity and Plan_List_Finished_Quantity=@Plan_List_Finished_Quantity and Goods_ID=@Goods_ID and Plan_List_Status=@Plan_List_Status and Plan_List_Remark=@Plan_List_Remark and Plan_List_Resever1=@Plan_List_Resever1 and Plan_List_Resever2=@Plan_List_Resever2 and Plan_List_ID=@Plan_List_ID and Plan_Type_ID=@Plan_Type_ID and Plan_Serial_Num=@Plan_Serial_Num and Plan_Code=@Plan_Code and Plan_Create_Time=@Plan_Create_Time and Plan_Begin_Time=@Plan_Begin_Time and Plan_End_Time=@Plan_End_Time and Plan_Bill_Time=@Plan_Bill_Time and Plan_Status=@Plan_Status and Plan_Operater=@Plan_Operater and Plan_From_Dept=@Plan_From_Dept and Plan_To_Dept=@Plan_To_Dept and Plan_From_User=@Plan_From_User and Plan_To_User=@Plan_To_User and Plan_Import_Flag=@Plan_Import_Flag and Plan_Remark=@Plan_Remark and Plan_Type_Code=@Plan_Type_Code and Plan_Type_Name=@Plan_Type_Name and Plan_Type_Group=@Plan_Type_Group and Plan_Type_InOut=@Plan_Type_InOut and Plan_Type_Order=@Plan_Type_Order and Plan_Type_Remark=@Plan_Type_Remark and Plan_Type_Flag=@Plan_Type_Flag and Goods_Batch=@Goods_Batch ");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Shelf_Life", SqlDbType.Int,4),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ProduceDate", SqlDbType.DateTime),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Ordered_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Finished_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@Plan_List_Resever1", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Resever2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Serial_Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Create_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Begin_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_End_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Bill_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Operater", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Import_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Group", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Order", SqlDbType.Int,4),
					new SqlParameter("@Plan_Type_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Batch", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Plan_ID;
            parameters[1].Value = model.Goods_Class_ID;
            parameters[2].Value = model.Goods_Code;
            parameters[3].Value = model.Goods_Name;
            parameters[4].Value = model.Goods_Type;
            parameters[5].Value = model.Goods_Suppier_Code;
            parameters[6].Value = model.Goods_Model;
            parameters[7].Value = model.Goods_Desc;
            parameters[8].Value = model.Goods_Level;
            parameters[9].Value = model.Goods_Unit;
            parameters[10].Value = model.Goods_Limit_Upper_Quantity;
            parameters[11].Value = model.Goods_Limit_Lower_Quantity;
            parameters[12].Value = model.Goods_Order;
            parameters[13].Value = model.Goods_Flag;
            parameters[14].Value = model.Goods_Remark;
            parameters[15].Value = model.Goods_Department;
            parameters[16].Value = model.Goods_Shelf_Life;
            parameters[17].Value = model.Goods_Asset;
            parameters[18].Value = model.Goods_ProduceDate;
            parameters[19].Value = model.Goods_Danger;
            parameters[20].Value = model.Goods_Category;
            parameters[21].Value = model.Goods_Class_Parent_ID;
            parameters[22].Value = model.Goods_Class_Code;
            parameters[23].Value = model.Goods_Class_Name;
            parameters[24].Value = model.Goods_Class_Remark;
            parameters[25].Value = model.Goods_Class_Order;
            parameters[26].Value = model.Goods_Class_Flag;
            parameters[27].Value = model.Goods_Class_Reserve1;
            parameters[28].Value = model.Goods_Class_Reserve2;
            parameters[29].Value = model.Plan_List_Quantity;
            parameters[30].Value = model.Plan_List_Ordered_Quantity;
            parameters[31].Value = model.Plan_List_Finished_Quantity;
            parameters[32].Value = model.Goods_ID;
            parameters[33].Value = model.Plan_List_Status;
            parameters[34].Value = model.Plan_List_Remark;
            parameters[35].Value = model.Plan_List_Resever1;
            parameters[36].Value = model.Plan_List_Resever2;
            parameters[37].Value = model.Plan_List_ID;
            parameters[38].Value = model.Plan_Type_ID;
            parameters[39].Value = model.Plan_Serial_Num;
            parameters[40].Value = model.Plan_Code;
            parameters[41].Value = model.Plan_Create_Time;
            parameters[42].Value = model.Plan_Begin_Time;
            parameters[43].Value = model.Plan_End_Time;
            parameters[44].Value = model.Plan_Bill_Time;
            parameters[45].Value = model.Plan_Status;
            parameters[46].Value = model.Plan_Operater;
            parameters[47].Value = model.Plan_From_Dept;
            parameters[48].Value = model.Plan_To_Dept;
            parameters[49].Value = model.Plan_From_User;
            parameters[50].Value = model.Plan_To_User;
            parameters[51].Value = model.Plan_Import_Flag;
            parameters[52].Value = model.Plan_Remark;
            parameters[53].Value = model.Plan_Type_Code;
            parameters[54].Value = model.Plan_Type_Name;
            parameters[55].Value = model.Plan_Type_Group;
            parameters[56].Value = model.Plan_Type_InOut;
            parameters[57].Value = model.Plan_Type_Order;
            parameters[58].Value = model.Plan_Type_Remark;
            parameters[59].Value = model.Plan_Type_Flag;
            parameters[60].Value = model.Goods_Batch;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Plan_ID, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Remark, string Goods_Department, int Goods_Shelf_Life, string Goods_Asset, DateTime Goods_ProduceDate, string Goods_Danger, string Goods_Category, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Flag, string Goods_Class_Reserve1, string Goods_Class_Reserve2, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Goods_ID, string Plan_List_Status, string Plan_List_Remark, string Plan_List_Resever1, string Plan_List_Resever2, string Plan_List_ID, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_Begin_Time, DateTime Plan_End_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Plan_Type_Code, string Plan_Type_Name, string Plan_Type_Group, string Plan_Type_InOut, int Plan_Type_Order, string Plan_Type_Remark, string Plan_Type_Flag, string Goods_Batch)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_PlanList ");
            strSql.Append(" where Plan_ID=@Plan_ID and Goods_Class_ID=@Goods_Class_ID and Goods_Code=@Goods_Code and Goods_Name=@Goods_Name and Goods_Type=@Goods_Type and Goods_Suppier_Code=@Goods_Suppier_Code and Goods_Model=@Goods_Model and Goods_Desc=@Goods_Desc and Goods_Level=@Goods_Level and Goods_Unit=@Goods_Unit and Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity and Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity and Goods_Order=@Goods_Order and Goods_Flag=@Goods_Flag and Goods_Remark=@Goods_Remark and Goods_Department=@Goods_Department and Goods_Shelf_Life=@Goods_Shelf_Life and Goods_Asset=@Goods_Asset and Goods_ProduceDate=@Goods_ProduceDate and Goods_Danger=@Goods_Danger and Goods_Category=@Goods_Category and Goods_Class_Parent_ID=@Goods_Class_Parent_ID and Goods_Class_Code=@Goods_Class_Code and Goods_Class_Name=@Goods_Class_Name and Goods_Class_Remark=@Goods_Class_Remark and Goods_Class_Order=@Goods_Class_Order and Goods_Class_Flag=@Goods_Class_Flag and Goods_Class_Reserve1=@Goods_Class_Reserve1 and Goods_Class_Reserve2=@Goods_Class_Reserve2 and Plan_List_Quantity=@Plan_List_Quantity and Plan_List_Ordered_Quantity=@Plan_List_Ordered_Quantity and Plan_List_Finished_Quantity=@Plan_List_Finished_Quantity and Goods_ID=@Goods_ID and Plan_List_Status=@Plan_List_Status and Plan_List_Remark=@Plan_List_Remark and Plan_List_Resever1=@Plan_List_Resever1 and Plan_List_Resever2=@Plan_List_Resever2 and Plan_List_ID=@Plan_List_ID and Plan_Type_ID=@Plan_Type_ID and Plan_Serial_Num=@Plan_Serial_Num and Plan_Code=@Plan_Code and Plan_Create_Time=@Plan_Create_Time and Plan_Begin_Time=@Plan_Begin_Time and Plan_End_Time=@Plan_End_Time and Plan_Bill_Time=@Plan_Bill_Time and Plan_Status=@Plan_Status and Plan_Operater=@Plan_Operater and Plan_From_Dept=@Plan_From_Dept and Plan_To_Dept=@Plan_To_Dept and Plan_From_User=@Plan_From_User and Plan_To_User=@Plan_To_User and Plan_Import_Flag=@Plan_Import_Flag and Plan_Remark=@Plan_Remark and Plan_Type_Code=@Plan_Type_Code and Plan_Type_Name=@Plan_Type_Name and Plan_Type_Group=@Plan_Type_Group and Plan_Type_InOut=@Plan_Type_InOut and Plan_Type_Order=@Plan_Type_Order and Plan_Type_Remark=@Plan_Type_Remark and Plan_Type_Flag=@Plan_Type_Flag and Goods_Batch=@Goods_Batch ");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Shelf_Life", SqlDbType.Int,4),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ProduceDate", SqlDbType.DateTime),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Ordered_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Finished_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@Plan_List_Resever1", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Resever2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Serial_Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Create_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Begin_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_End_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Bill_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Operater", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Import_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Group", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Order", SqlDbType.Int,4),
					new SqlParameter("@Plan_Type_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Batch", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Plan_ID;
            parameters[1].Value = Goods_Class_ID;
            parameters[2].Value = Goods_Code;
            parameters[3].Value = Goods_Name;
            parameters[4].Value = Goods_Type;
            parameters[5].Value = Goods_Suppier_Code;
            parameters[6].Value = Goods_Model;
            parameters[7].Value = Goods_Desc;
            parameters[8].Value = Goods_Level;
            parameters[9].Value = Goods_Unit;
            parameters[10].Value = Goods_Limit_Upper_Quantity;
            parameters[11].Value = Goods_Limit_Lower_Quantity;
            parameters[12].Value = Goods_Order;
            parameters[13].Value = Goods_Flag;
            parameters[14].Value = Goods_Remark;
            parameters[15].Value = Goods_Department;
            parameters[16].Value = Goods_Shelf_Life;
            parameters[17].Value = Goods_Asset;
            parameters[18].Value = Goods_ProduceDate;
            parameters[19].Value = Goods_Danger;
            parameters[20].Value = Goods_Category;
            parameters[21].Value = Goods_Class_Parent_ID;
            parameters[22].Value = Goods_Class_Code;
            parameters[23].Value = Goods_Class_Name;
            parameters[24].Value = Goods_Class_Remark;
            parameters[25].Value = Goods_Class_Order;
            parameters[26].Value = Goods_Class_Flag;
            parameters[27].Value = Goods_Class_Reserve1;
            parameters[28].Value = Goods_Class_Reserve2;
            parameters[29].Value = Plan_List_Quantity;
            parameters[30].Value = Plan_List_Ordered_Quantity;
            parameters[31].Value = Plan_List_Finished_Quantity;
            parameters[32].Value = Goods_ID;
            parameters[33].Value = Plan_List_Status;
            parameters[34].Value = Plan_List_Remark;
            parameters[35].Value = Plan_List_Resever1;
            parameters[36].Value = Plan_List_Resever2;
            parameters[37].Value = Plan_List_ID;
            parameters[38].Value = Plan_Type_ID;
            parameters[39].Value = Plan_Serial_Num;
            parameters[40].Value = Plan_Code;
            parameters[41].Value = Plan_Create_Time;
            parameters[42].Value = Plan_Begin_Time;
            parameters[43].Value = Plan_End_Time;
            parameters[44].Value = Plan_Bill_Time;
            parameters[45].Value = Plan_Status;
            parameters[46].Value = Plan_Operater;
            parameters[47].Value = Plan_From_Dept;
            parameters[48].Value = Plan_To_Dept;
            parameters[49].Value = Plan_From_User;
            parameters[50].Value = Plan_To_User;
            parameters[51].Value = Plan_Import_Flag;
            parameters[52].Value = Plan_Remark;
            parameters[53].Value = Plan_Type_Code;
            parameters[54].Value = Plan_Type_Name;
            parameters[55].Value = Plan_Type_Group;
            parameters[56].Value = Plan_Type_InOut;
            parameters[57].Value = Plan_Type_Order;
            parameters[58].Value = Plan_Type_Remark;
            parameters[59].Value = Plan_Type_Flag;
            parameters[60].Value = Goods_Batch;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public WMS_Database.View_PlanListModel GetModel(string Plan_ID, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Remark, string Goods_Department, int Goods_Shelf_Life, string Goods_Asset, DateTime Goods_ProduceDate, string Goods_Danger, string Goods_Category, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Flag, string Goods_Class_Reserve1, string Goods_Class_Reserve2, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Goods_ID, string Plan_List_Status, string Plan_List_Remark, string Plan_List_Resever1, string Plan_List_Resever2, string Plan_List_ID, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_Begin_Time, DateTime Plan_End_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Plan_Type_Code, string Plan_Type_Name, string Plan_Type_Group, string Plan_Type_InOut, int Plan_Type_Order, string Plan_Type_Remark, string Plan_Type_Flag, string Goods_Batch)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Plan_ID,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Remark,Goods_Department,Goods_Shelf_Life,Goods_Asset,Goods_ProduceDate,Goods_Danger,Goods_Category,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Flag,Goods_Class_Reserve1,Goods_Class_Reserve2,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Goods_ID,Plan_List_Status,Plan_List_Remark,Plan_List_Resever1,Plan_List_Resever2,Plan_List_ID,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_Begin_Time,Plan_End_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Plan_Type_Code,Plan_Type_Name,Plan_Type_Group,Plan_Type_InOut,Plan_Type_Order,Plan_Type_Remark,Plan_Type_Flag,Goods_Batch from View_PlanList ");
            strSql.Append(" where Plan_ID=@Plan_ID and Goods_Class_ID=@Goods_Class_ID and Goods_Code=@Goods_Code and Goods_Name=@Goods_Name and Goods_Type=@Goods_Type and Goods_Suppier_Code=@Goods_Suppier_Code and Goods_Model=@Goods_Model and Goods_Desc=@Goods_Desc and Goods_Level=@Goods_Level and Goods_Unit=@Goods_Unit and Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity and Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity and Goods_Order=@Goods_Order and Goods_Flag=@Goods_Flag and Goods_Remark=@Goods_Remark and Goods_Department=@Goods_Department and Goods_Shelf_Life=@Goods_Shelf_Life and Goods_Asset=@Goods_Asset and Goods_ProduceDate=@Goods_ProduceDate and Goods_Danger=@Goods_Danger and Goods_Category=@Goods_Category and Goods_Class_Parent_ID=@Goods_Class_Parent_ID and Goods_Class_Code=@Goods_Class_Code and Goods_Class_Name=@Goods_Class_Name and Goods_Class_Remark=@Goods_Class_Remark and Goods_Class_Order=@Goods_Class_Order and Goods_Class_Flag=@Goods_Class_Flag and Goods_Class_Reserve1=@Goods_Class_Reserve1 and Goods_Class_Reserve2=@Goods_Class_Reserve2 and Plan_List_Quantity=@Plan_List_Quantity and Plan_List_Ordered_Quantity=@Plan_List_Ordered_Quantity and Plan_List_Finished_Quantity=@Plan_List_Finished_Quantity and Goods_ID=@Goods_ID and Plan_List_Status=@Plan_List_Status and Plan_List_Remark=@Plan_List_Remark and Plan_List_Resever1=@Plan_List_Resever1 and Plan_List_Resever2=@Plan_List_Resever2 and Plan_List_ID=@Plan_List_ID and Plan_Type_ID=@Plan_Type_ID and Plan_Serial_Num=@Plan_Serial_Num and Plan_Code=@Plan_Code and Plan_Create_Time=@Plan_Create_Time and Plan_Begin_Time=@Plan_Begin_Time and Plan_End_Time=@Plan_End_Time and Plan_Bill_Time=@Plan_Bill_Time and Plan_Status=@Plan_Status and Plan_Operater=@Plan_Operater and Plan_From_Dept=@Plan_From_Dept and Plan_To_Dept=@Plan_To_Dept and Plan_From_User=@Plan_From_User and Plan_To_User=@Plan_To_User and Plan_Import_Flag=@Plan_Import_Flag and Plan_Remark=@Plan_Remark and Plan_Type_Code=@Plan_Type_Code and Plan_Type_Name=@Plan_Type_Name and Plan_Type_Group=@Plan_Type_Group and Plan_Type_InOut=@Plan_Type_InOut and Plan_Type_Order=@Plan_Type_Order and Plan_Type_Remark=@Plan_Type_Remark and Plan_Type_Flag=@Plan_Type_Flag and Goods_Batch=@Goods_Batch ");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Shelf_Life", SqlDbType.Int,4),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ProduceDate", SqlDbType.DateTime),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Ordered_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Finished_Quantity",  SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@Plan_List_Resever1", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_Resever2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_List_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Serial_Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Create_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Begin_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_End_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Bill_Time", SqlDbType.DateTime),
					new SqlParameter("@Plan_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Operater", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_Dept", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_From_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_To_User", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Import_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Group", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Order", SqlDbType.Int,4),
					new SqlParameter("@Plan_Type_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Type_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Batch", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Plan_ID;
            parameters[1].Value = Goods_Class_ID;
            parameters[2].Value = Goods_Code;
            parameters[3].Value = Goods_Name;
            parameters[4].Value = Goods_Type;
            parameters[5].Value = Goods_Suppier_Code;
            parameters[6].Value = Goods_Model;
            parameters[7].Value = Goods_Desc;
            parameters[8].Value = Goods_Level;
            parameters[9].Value = Goods_Unit;
            parameters[10].Value = Goods_Limit_Upper_Quantity;
            parameters[11].Value = Goods_Limit_Lower_Quantity;
            parameters[12].Value = Goods_Order;
            parameters[13].Value = Goods_Flag;
            parameters[14].Value = Goods_Remark;
            parameters[15].Value = Goods_Department;
            parameters[16].Value = Goods_Shelf_Life;
            parameters[17].Value = Goods_Asset;
            parameters[18].Value = Goods_ProduceDate;
            parameters[19].Value = Goods_Danger;
            parameters[20].Value = Goods_Category;
            parameters[21].Value = Goods_Class_Parent_ID;
            parameters[22].Value = Goods_Class_Code;
            parameters[23].Value = Goods_Class_Name;
            parameters[24].Value = Goods_Class_Remark;
            parameters[25].Value = Goods_Class_Order;
            parameters[26].Value = Goods_Class_Flag;
            parameters[27].Value = Goods_Class_Reserve1;
            parameters[28].Value = Goods_Class_Reserve2;
            parameters[29].Value = Plan_List_Quantity;
            parameters[30].Value = Plan_List_Ordered_Quantity;
            parameters[31].Value = Plan_List_Finished_Quantity;
            parameters[32].Value = Goods_ID;
            parameters[33].Value = Plan_List_Status;
            parameters[34].Value = Plan_List_Remark;
            parameters[35].Value = Plan_List_Resever1;
            parameters[36].Value = Plan_List_Resever2;
            parameters[37].Value = Plan_List_ID;
            parameters[38].Value = Plan_Type_ID;
            parameters[39].Value = Plan_Serial_Num;
            parameters[40].Value = Plan_Code;
            parameters[41].Value = Plan_Create_Time;
            parameters[42].Value = Plan_Begin_Time;
            parameters[43].Value = Plan_End_Time;
            parameters[44].Value = Plan_Bill_Time;
            parameters[45].Value = Plan_Status;
            parameters[46].Value = Plan_Operater;
            parameters[47].Value = Plan_From_Dept;
            parameters[48].Value = Plan_To_Dept;
            parameters[49].Value = Plan_From_User;
            parameters[50].Value = Plan_To_User;
            parameters[51].Value = Plan_Import_Flag;
            parameters[52].Value = Plan_Remark;
            parameters[53].Value = Plan_Type_Code;
            parameters[54].Value = Plan_Type_Name;
            parameters[55].Value = Plan_Type_Group;
            parameters[56].Value = Plan_Type_InOut;
            parameters[57].Value = Plan_Type_Order;
            parameters[58].Value = Plan_Type_Remark;
            parameters[59].Value = Plan_Type_Flag;
            parameters[60].Value = Goods_Batch;

            WMS_Database.View_PlanListModel model = new WMS_Database.View_PlanListModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
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
        public WMS_Database.View_PlanListModel DataRowToModel(DataRow row)
        {
            WMS_Database.View_PlanListModel model = new WMS_Database.View_PlanListModel();
            if (row != null)
            {
                if (row["Plan_ID"] != null)
                {
                    model.Plan_ID = row["Plan_ID"].ToString();
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
                if (row["Goods_Suppier_Code"] != null)
                {
                    model.Goods_Suppier_Code = row["Goods_Suppier_Code"].ToString();
                }
                if (row["Goods_Model"] != null)
                {
                    model.Goods_Model = row["Goods_Model"].ToString();
                }
                if (row["Goods_Desc"] != null)
                {
                    model.Goods_Desc = row["Goods_Desc"].ToString();
                }
                if (row["Goods_Level"] != null)
                {
                    model.Goods_Level = row["Goods_Level"].ToString();
                }
                if (row["Goods_Unit"] != null)
                {
                    model.Goods_Unit = row["Goods_Unit"].ToString();
                }
                if (row["Goods_Limit_Upper_Quantity"] != null)
                {
                    model.Goods_Limit_Upper_Quantity = row["Goods_Limit_Upper_Quantity"].ToString();
                }
                if (row["Goods_Limit_Lower_Quantity"] != null)
                {
                    model.Goods_Limit_Lower_Quantity = row["Goods_Limit_Lower_Quantity"].ToString();
                }
                if (row["Goods_Order"] != null && row["Goods_Order"].ToString() != "")
                {
                    model.Goods_Order = int.Parse(row["Goods_Order"].ToString());
                }
                if (row["Goods_Flag"] != null)
                {
                    model.Goods_Flag = row["Goods_Flag"].ToString();
                }
                if (row["Goods_Remark"] != null)
                {
                    model.Goods_Remark = row["Goods_Remark"].ToString();
                }
                if (row["Goods_Department"] != null)
                {
                    model.Goods_Department = row["Goods_Department"].ToString();
                }
                if (row["Goods_Shelf_Life"] != null && row["Goods_Shelf_Life"].ToString() != "")
                {
                    model.Goods_Shelf_Life = int.Parse(row["Goods_Shelf_Life"].ToString());
                }
                if (row["Goods_Asset"] != null)
                {
                    model.Goods_Asset = row["Goods_Asset"].ToString();
                }
                if (row["Goods_ProduceDate"] != null && row["Goods_ProduceDate"].ToString() != "")
                {
                    model.Goods_ProduceDate = DateTime.Parse(row["Goods_ProduceDate"].ToString());
                }
                if (row["Goods_Danger"] != null)
                {
                    model.Goods_Danger = row["Goods_Danger"].ToString();
                }
                if (row["Goods_Category"] != null)
                {
                    model.Goods_Category = row["Goods_Category"].ToString();
                }
                if (row["Goods_Class_Parent_ID"] != null)
                {
                    model.Goods_Class_Parent_ID = row["Goods_Class_Parent_ID"].ToString();
                }
                if (row["Goods_Class_Code"] != null)
                {
                    model.Goods_Class_Code = row["Goods_Class_Code"].ToString();
                }
                if (row["Goods_Class_Name"] != null)
                {
                    model.Goods_Class_Name = row["Goods_Class_Name"].ToString();
                }
                if (row["Goods_Class_Remark"] != null)
                {
                    model.Goods_Class_Remark = row["Goods_Class_Remark"].ToString();
                }
                if (row["Goods_Class_Order"] != null && row["Goods_Class_Order"].ToString() != "")
                {
                    model.Goods_Class_Order = int.Parse(row["Goods_Class_Order"].ToString());
                }
                if (row["Goods_Class_Flag"] != null)
                {
                    model.Goods_Class_Flag = row["Goods_Class_Flag"].ToString();
                }
                if (row["Goods_Class_Reserve1"] != null)
                {
                    model.Goods_Class_Reserve1 = row["Goods_Class_Reserve1"].ToString();
                }
                if (row["Goods_Class_Reserve2"] != null)
                {
                    model.Goods_Class_Reserve2 = row["Goods_Class_Reserve2"].ToString();
                }
                if (row["Plan_List_Quantity"] != null && row["Plan_List_Quantity"].ToString() != "")
                {
                    model.Plan_List_Quantity = row["Plan_List_Quantity"].ToString();
                }
                if (row["Plan_List_Ordered_Quantity"] != null && row["Plan_List_Ordered_Quantity"].ToString() != "")
                {
                    model.Plan_List_Ordered_Quantity = row["Plan_List_Ordered_Quantity"].ToString();
                }
                if (row["Plan_List_Finished_Quantity"] != null && row["Plan_List_Finished_Quantity"].ToString() != "")
                {
                    model.Plan_List_Finished_Quantity = row["Plan_List_Finished_Quantity"].ToString();
                }
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
                }
                if (row["Plan_List_Status"] != null)
                {
                    model.Plan_List_Status = row["Plan_List_Status"].ToString();
                }
                if (row["Plan_List_Remark"] != null)
                {
                    model.Plan_List_Remark = row["Plan_List_Remark"].ToString();
                }
                if (row["Plan_List_Resever1"] != null)
                {
                    model.Plan_List_Resever1 = row["Plan_List_Resever1"].ToString();
                }
                if (row["Plan_List_Resever2"] != null)
                {
                    model.Plan_List_Resever2 = row["Plan_List_Resever2"].ToString();
                }
                if (row["Plan_List_ID"] != null)
                {
                    model.Plan_List_ID = row["Plan_List_ID"].ToString();
                }
                if (row["Plan_Type_ID"] != null)
                {
                    model.Plan_Type_ID = row["Plan_Type_ID"].ToString();
                }
                if (row["Plan_Serial_Num"] != null)
                {
                    model.Plan_Serial_Num = row["Plan_Serial_Num"].ToString();
                }
                if (row["Plan_Code"] != null)
                {
                    model.Plan_Code = row["Plan_Code"].ToString();
                }
                if (row["Plan_Create_Time"] != null && row["Plan_Create_Time"].ToString() != "")
                {
                    model.Plan_Create_Time = DateTime.Parse(row["Plan_Create_Time"].ToString());
                }
                if (row["Plan_Begin_Time"] != null && row["Plan_Begin_Time"].ToString() != "")
                {
                    model.Plan_Begin_Time = DateTime.Parse(row["Plan_Begin_Time"].ToString());
                }
                if (row["Plan_End_Time"] != null && row["Plan_End_Time"].ToString() != "")
                {
                    model.Plan_End_Time = DateTime.Parse(row["Plan_End_Time"].ToString());
                }
                if (row["Plan_Bill_Time"] != null && row["Plan_Bill_Time"].ToString() != "")
                {
                    model.Plan_Bill_Time = DateTime.Parse(row["Plan_Bill_Time"].ToString());
                }
                if (row["Plan_Status"] != null)
                {
                    model.Plan_Status = row["Plan_Status"].ToString();
                }
                if (row["Plan_Operater"] != null)
                {
                    model.Plan_Operater = row["Plan_Operater"].ToString();
                }
                if (row["Plan_From_Dept"] != null)
                {
                    model.Plan_From_Dept = row["Plan_From_Dept"].ToString();
                }
                if (row["Plan_To_Dept"] != null)
                {
                    model.Plan_To_Dept = row["Plan_To_Dept"].ToString();
                }
                if (row["Plan_From_User"] != null)
                {
                    model.Plan_From_User = row["Plan_From_User"].ToString();
                }
                if (row["Plan_To_User"] != null)
                {
                    model.Plan_To_User = row["Plan_To_User"].ToString();
                }
                if (row["Plan_Import_Flag"] != null)
                {
                    model.Plan_Import_Flag = row["Plan_Import_Flag"].ToString();
                }
                if (row["Plan_Remark"] != null)
                {
                    model.Plan_Remark = row["Plan_Remark"].ToString();
                }
                if (row["Plan_Type_Code"] != null)
                {
                    model.Plan_Type_Code = row["Plan_Type_Code"].ToString();
                }
                if (row["Plan_Type_Name"] != null)
                {
                    model.Plan_Type_Name = row["Plan_Type_Name"].ToString();
                }
                if (row["Plan_Type_Group"] != null)
                {
                    model.Plan_Type_Group = row["Plan_Type_Group"].ToString();
                }
                if (row["Plan_Type_InOut"] != null)
                {
                    model.Plan_Type_InOut = row["Plan_Type_InOut"].ToString();
                }
                if (row["Plan_Type_Order"] != null && row["Plan_Type_Order"].ToString() != "")
                {
                    model.Plan_Type_Order = int.Parse(row["Plan_Type_Order"].ToString());
                }
                if (row["Plan_Type_Remark"] != null)
                {
                    model.Plan_Type_Remark = row["Plan_Type_Remark"].ToString();
                }
                if (row["Plan_Type_Flag"] != null)
                {
                    model.Plan_Type_Flag = row["Plan_Type_Flag"].ToString();
                }
                if (row["Goods_Batch"] != null)
                {
                    model.Goods_Batch = row["Goods_Batch"].ToString();
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
            strSql.Append("select Plan_ID,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Remark,Goods_Department,Goods_Shelf_Life,Goods_Asset,Goods_ProduceDate,Goods_Danger,Goods_Category,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Flag,Goods_Class_Reserve1,Goods_Class_Reserve2,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Goods_ID,Plan_List_Status,Plan_List_Remark,Plan_List_Resever1,Plan_List_Resever2,Plan_List_ID,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_Begin_Time,Plan_End_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Plan_Type_Code,Plan_Type_Name,Plan_Type_Group,Plan_Type_InOut,Plan_Type_Order,Plan_Type_Remark,Plan_Type_Flag,Goods_Batch ");
            strSql.Append(" FROM View_PlanList ");
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
            strSql.Append(" Plan_ID,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Remark,Goods_Department,Goods_Shelf_Life,Goods_Asset,Goods_ProduceDate,Goods_Danger,Goods_Category,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Flag,Goods_Class_Reserve1,Goods_Class_Reserve2,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Goods_ID,Plan_List_Status,Plan_List_Remark,Plan_List_Resever1,Plan_List_Resever2,Plan_List_ID,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_Begin_Time,Plan_End_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Plan_Type_Code,Plan_Type_Name,Plan_Type_Group,Plan_Type_InOut,Plan_Type_Order,Plan_Type_Remark,Plan_Type_Flag,Goods_Batch ");
            strSql.Append(" FROM View_PlanList ");
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
            strSql.Append("select count(1) FROM View_PlanList ");
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
                strSql.Append("order by T.Goods_Batch desc");
            }
            strSql.Append(")AS Row, T.*  from View_PlanList T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "View_PlanList";
            parameters[1].Value = "Goods_Batch";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  MethodEx

        #endregion  MethodEx
    }
}

