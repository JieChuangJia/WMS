using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:View_Plan_Manage
    /// </summary>
    public partial class View_Plan_ManageDAL
    {
        public View_Plan_ManageDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Mange_ID, string Manage_List_ID, string Stock_List_ID, string Manage_List_Quantity, string Manage_List_Remark, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Goods_ID, string Plan_List_ID, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Stock_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, DateTime Goods_ProduceDate, string Goods_Asset, int Goods_Shelf_Life, string Goods_Department, string Cell_ID, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Row, int Cell_Column, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Flag, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_Plan_Manage");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Mange_Status='" + Mange_Status + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Remark='" + Manage_Remark + "' and Mange_ID='" + Mange_ID + "' and Manage_List_ID='" + Manage_List_ID + "' and Stock_List_ID='" + Stock_List_ID + "' and Manage_List_Quantity='" + Manage_List_Quantity + "' and Manage_List_Remark='" + Manage_List_Remark + "' and Plan_List_Quantity=" + Plan_List_Quantity + " and Plan_List_Ordered_Quantity=" + Plan_List_Ordered_Quantity + " and Plan_List_Finished_Quantity=" + Plan_List_Finished_Quantity + " and Plan_List_Status='" + Plan_List_Status + "' and Plan_List_Remark='" + Plan_List_Remark + "' and Plan_Type_ID='" + Plan_Type_ID + "' and Plan_Serial_Num='" + Plan_Serial_Num + "' and Plan_Code='" + Plan_Code + "' and Plan_Create_Time='" + Plan_Create_Time + "' and Plan_End_Time='" + Plan_End_Time + "' and Plan_Begin_Time='" + Plan_Begin_Time + "' and Plan_Bill_Time='" + Plan_Bill_Time + "' and Plan_Status='" + Plan_Status + "' and Plan_Operater='" + Plan_Operater + "' and Plan_From_Dept='" + Plan_From_Dept + "' and Plan_To_Dept='" + Plan_To_Dept + "' and Plan_From_User='" + Plan_From_User + "' and Plan_To_User='" + Plan_To_User + "' and Plan_Import_Flag='" + Plan_Import_Flag + "' and Plan_Remark='" + Plan_Remark + "' and Goods_ID='" + Goods_ID + "' and Plan_List_ID='" + Plan_List_ID + "' and Cell_Child_ID='" + Cell_Child_ID + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Stock_Full_Flag='" + Stock_Full_Flag + "' and Stock_Remark='" + Stock_Remark + "' and Stock_ID='" + Stock_ID + "' and Stock_List_Box_Barcode='" + Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + Stock_List_Quantity + "' and Stock_List_Entry_Time='" + Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + Stock_List_Update_Time + "' and Stock_List_Remark='" + Stock_List_Remark + "' and Goods_Class_ID='" + Goods_Class_ID + "' and Goods_Code='" + Goods_Code + "' and Goods_Name='" + Goods_Name + "' and Goods_Type='" + Goods_Type + "' and Goods_Suppier_Code='" + Goods_Suppier_Code + "' and Goods_Model='" + Goods_Model + "' and Goods_Desc='" + Goods_Desc + "' and Goods_Level='" + Goods_Level + "' and Goods_Unit='" + Goods_Unit + "' and Goods_Limit_Upper_Quantity='" + Goods_Limit_Upper_Quantity + "' and Goods_Limit_Lower_Quantity='" + Goods_Limit_Lower_Quantity + "' and Goods_Order=" + Goods_Order + " and Goods_Flag='" + Goods_Flag + "' and Goods_Danger='" + Goods_Danger + "' and Goods_Category='" + Goods_Category + "' and Goods_ProduceDate='" + Goods_ProduceDate + "' and Goods_Asset='" + Goods_Asset + "' and Goods_Shelf_Life=" + Goods_Shelf_Life + " and Goods_Department='" + Goods_Department + "' and Cell_ID='" + Cell_ID + "' and Area_ID='" + Area_ID + "' and Cell_Code='" + Cell_Code + "' and Cell_Name='" + Cell_Name + "' and Cell_Lane='" + Cell_Lane + "' and Device_Code='" + Device_Code + "' and Shelf_Type='" + Shelf_Type + "' and Cell_InOut='" + Cell_InOut + "' and Cell_Type='" + Cell_Type + "' and Cell_Storage_Type='" + Cell_Storage_Type + "' and Cell_Fork_Type='" + Cell_Fork_Type + "' and Cell_Layer=" + Cell_Layer + " and Cell_Row=" + Cell_Row + " and Cell_Column=" + Cell_Column + " and Cell_Chlid_ID='" + Cell_Chlid_ID + "' and Cell_Chlid_Position='" + Cell_Chlid_Position + "' and Cell_Child_Order=" + Cell_Child_Order + " and Cell_Child_InOut='" + Cell_Child_InOut + "' and Cell_Child_Model='" + Cell_Child_Model + "' and Cell_Child_Status='" + Cell_Child_Status + "' and Cell_Child_Flag='" + Cell_Child_Flag + "' and Cell_Child_Run_Status='" + Cell_Child_Run_Status + "' and Cell_Child_Operate_Type='" + Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + Cell_Child_TaskLock_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_Plan_ManageModel model)
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
            if (model.Mange_ID != null)
            {
                strSql1.Append("Mange_ID,");
                strSql2.Append("'" + model.Mange_ID + "',");
            }
            if (model.Manage_List_ID != null)
            {
                strSql1.Append("Manage_List_ID,");
                strSql2.Append("'" + model.Manage_List_ID + "',");
            }
            if (model.Stock_List_ID != null)
            {
                strSql1.Append("Stock_List_ID,");
                strSql2.Append("'" + model.Stock_List_ID + "',");
            }
            if (model.Manage_List_Quantity != null)
            {
                strSql1.Append("Manage_List_Quantity,");
                strSql2.Append("'" + model.Manage_List_Quantity + "',");
            }
            if (model.Manage_List_Remark != null)
            {
                strSql1.Append("Manage_List_Remark,");
                strSql2.Append("'" + model.Manage_List_Remark + "',");
            }
            if (model.Plan_List_Quantity != null)
            {
                strSql1.Append("Plan_List_Quantity,");
                strSql2.Append("" + model.Plan_List_Quantity + ",");
            }
            if (model.Plan_List_Ordered_Quantity != null)
            {
                strSql1.Append("Plan_List_Ordered_Quantity,");
                strSql2.Append("" + model.Plan_List_Ordered_Quantity + ",");
            }
            if (model.Plan_List_Finished_Quantity != null)
            {
                strSql1.Append("Plan_List_Finished_Quantity,");
                strSql2.Append("" + model.Plan_List_Finished_Quantity + ",");
            }
            if (model.Plan_List_Status != null)
            {
                strSql1.Append("Plan_List_Status,");
                strSql2.Append("'" + model.Plan_List_Status + "',");
            }
            if (model.Plan_List_Remark != null)
            {
                strSql1.Append("Plan_List_Remark,");
                strSql2.Append("'" + model.Plan_List_Remark + "',");
            }
            if (model.Plan_Type_ID != null)
            {
                strSql1.Append("Plan_Type_ID,");
                strSql2.Append("'" + model.Plan_Type_ID + "',");
            }
            if (model.Plan_Serial_Num != null)
            {
                strSql1.Append("Plan_Serial_Num,");
                strSql2.Append("'" + model.Plan_Serial_Num + "',");
            }
            if (model.Plan_Code != null)
            {
                strSql1.Append("Plan_Code,");
                strSql2.Append("'" + model.Plan_Code + "',");
            }
            if (model.Plan_Create_Time != null)
            {
                strSql1.Append("Plan_Create_Time,");
                strSql2.Append("'" + model.Plan_Create_Time + "',");
            }
            if (model.Plan_End_Time != null)
            {
                strSql1.Append("Plan_End_Time,");
                strSql2.Append("'" + model.Plan_End_Time + "',");
            }
            if (model.Plan_Begin_Time != null)
            {
                strSql1.Append("Plan_Begin_Time,");
                strSql2.Append("'" + model.Plan_Begin_Time + "',");
            }
            if (model.Plan_Bill_Time != null)
            {
                strSql1.Append("Plan_Bill_Time,");
                strSql2.Append("'" + model.Plan_Bill_Time + "',");
            }
            if (model.Plan_Status != null)
            {
                strSql1.Append("Plan_Status,");
                strSql2.Append("'" + model.Plan_Status + "',");
            }
            if (model.Plan_Operater != null)
            {
                strSql1.Append("Plan_Operater,");
                strSql2.Append("'" + model.Plan_Operater + "',");
            }
            if (model.Plan_From_Dept != null)
            {
                strSql1.Append("Plan_From_Dept,");
                strSql2.Append("'" + model.Plan_From_Dept + "',");
            }
            if (model.Plan_To_Dept != null)
            {
                strSql1.Append("Plan_To_Dept,");
                strSql2.Append("'" + model.Plan_To_Dept + "',");
            }
            if (model.Plan_From_User != null)
            {
                strSql1.Append("Plan_From_User,");
                strSql2.Append("'" + model.Plan_From_User + "',");
            }
            if (model.Plan_To_User != null)
            {
                strSql1.Append("Plan_To_User,");
                strSql2.Append("'" + model.Plan_To_User + "',");
            }
            if (model.Plan_Import_Flag != null)
            {
                strSql1.Append("Plan_Import_Flag,");
                strSql2.Append("'" + model.Plan_Import_Flag + "',");
            }
            if (model.Plan_Remark != null)
            {
                strSql1.Append("Plan_Remark,");
                strSql2.Append("'" + model.Plan_Remark + "',");
            }
            if (model.Goods_ID != null)
            {
                strSql1.Append("Goods_ID,");
                strSql2.Append("'" + model.Goods_ID + "',");
            }
            if (model.Plan_List_ID != null)
            {
                strSql1.Append("Plan_List_ID,");
                strSql2.Append("'" + model.Plan_List_ID + "',");
            }
            if (model.Cell_Child_ID != null)
            {
                strSql1.Append("Cell_Child_ID,");
                strSql2.Append("'" + model.Cell_Child_ID + "',");
            }
            if (model.Stock_Tray_Barcode != null)
            {
                strSql1.Append("Stock_Tray_Barcode,");
                strSql2.Append("'" + model.Stock_Tray_Barcode + "',");
            }
            if (model.Stock_Full_Flag != null)
            {
                strSql1.Append("Stock_Full_Flag,");
                strSql2.Append("'" + model.Stock_Full_Flag + "',");
            }
            if (model.Stock_Remark != null)
            {
                strSql1.Append("Stock_Remark,");
                strSql2.Append("'" + model.Stock_Remark + "',");
            }
            if (model.Stock_ID != null)
            {
                strSql1.Append("Stock_ID,");
                strSql2.Append("'" + model.Stock_ID + "',");
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
            if (model.Goods_Suppier_Code != null)
            {
                strSql1.Append("Goods_Suppier_Code,");
                strSql2.Append("'" + model.Goods_Suppier_Code + "',");
            }
            if (model.Goods_Model != null)
            {
                strSql1.Append("Goods_Model,");
                strSql2.Append("'" + model.Goods_Model + "',");
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
            if (model.Goods_Unit != null)
            {
                strSql1.Append("Goods_Unit,");
                strSql2.Append("'" + model.Goods_Unit + "',");
            }
            if (model.Goods_Limit_Upper_Quantity != null)
            {
                strSql1.Append("Goods_Limit_Upper_Quantity,");
                strSql2.Append("'" + model.Goods_Limit_Upper_Quantity + "',");
            }
            if (model.Goods_Limit_Lower_Quantity != null)
            {
                strSql1.Append("Goods_Limit_Lower_Quantity,");
                strSql2.Append("'" + model.Goods_Limit_Lower_Quantity + "',");
            }
            if (model.Goods_Order != null)
            {
                strSql1.Append("Goods_Order,");
                strSql2.Append("" + model.Goods_Order + ",");
            }
            if (model.Goods_Flag != null)
            {
                strSql1.Append("Goods_Flag,");
                strSql2.Append("'" + model.Goods_Flag + "',");
            }
            if (model.Goods_Danger != null)
            {
                strSql1.Append("Goods_Danger,");
                strSql2.Append("'" + model.Goods_Danger + "',");
            }
            if (model.Goods_Category != null)
            {
                strSql1.Append("Goods_Category,");
                strSql2.Append("'" + model.Goods_Category + "',");
            }
            if (model.Goods_ProduceDate != null)
            {
                strSql1.Append("Goods_ProduceDate,");
                strSql2.Append("'" + model.Goods_ProduceDate + "',");
            }
            if (model.Goods_Asset != null)
            {
                strSql1.Append("Goods_Asset,");
                strSql2.Append("'" + model.Goods_Asset + "',");
            }
            if (model.Goods_Shelf_Life != null)
            {
                strSql1.Append("Goods_Shelf_Life,");
                strSql2.Append("" + model.Goods_Shelf_Life + ",");
            }
            if (model.Goods_Department != null)
            {
                strSql1.Append("Goods_Department,");
                strSql2.Append("'" + model.Goods_Department + "',");
            }
            if (model.Cell_ID != null)
            {
                strSql1.Append("Cell_ID,");
                strSql2.Append("'" + model.Cell_ID + "',");
            }
            if (model.Area_ID != null)
            {
                strSql1.Append("Area_ID,");
                strSql2.Append("'" + model.Area_ID + "',");
            }
            if (model.Cell_Code != null)
            {
                strSql1.Append("Cell_Code,");
                strSql2.Append("'" + model.Cell_Code + "',");
            }
            if (model.Cell_Name != null)
            {
                strSql1.Append("Cell_Name,");
                strSql2.Append("'" + model.Cell_Name + "',");
            }
            if (model.Cell_Lane != null)
            {
                strSql1.Append("Cell_Lane,");
                strSql2.Append("'" + model.Cell_Lane + "',");
            }
            if (model.Device_Code != null)
            {
                strSql1.Append("Device_Code,");
                strSql2.Append("'" + model.Device_Code + "',");
            }
            if (model.Shelf_Type != null)
            {
                strSql1.Append("Shelf_Type,");
                strSql2.Append("'" + model.Shelf_Type + "',");
            }
            if (model.Cell_InOut != null)
            {
                strSql1.Append("Cell_InOut,");
                strSql2.Append("'" + model.Cell_InOut + "',");
            }
            if (model.Cell_Type != null)
            {
                strSql1.Append("Cell_Type,");
                strSql2.Append("'" + model.Cell_Type + "',");
            }
            if (model.Cell_Storage_Type != null)
            {
                strSql1.Append("Cell_Storage_Type,");
                strSql2.Append("'" + model.Cell_Storage_Type + "',");
            }
            if (model.Cell_Fork_Type != null)
            {
                strSql1.Append("Cell_Fork_Type,");
                strSql2.Append("'" + model.Cell_Fork_Type + "',");
            }
            if (model.Cell_Layer != null)
            {
                strSql1.Append("Cell_Layer,");
                strSql2.Append("" + model.Cell_Layer + ",");
            }
            if (model.Cell_Row != null)
            {
                strSql1.Append("Cell_Row,");
                strSql2.Append("" + model.Cell_Row + ",");
            }
            if (model.Cell_Column != null)
            {
                strSql1.Append("Cell_Column,");
                strSql2.Append("" + model.Cell_Column + ",");
            }
            if (model.Cell_Chlid_ID != null)
            {
                strSql1.Append("Cell_Chlid_ID,");
                strSql2.Append("'" + model.Cell_Chlid_ID + "',");
            }
            if (model.Cell_Chlid_Position != null)
            {
                strSql1.Append("Cell_Chlid_Position,");
                strSql2.Append("'" + model.Cell_Chlid_Position + "',");
            }
            if (model.Cell_Child_Order != null)
            {
                strSql1.Append("Cell_Child_Order,");
                strSql2.Append("" + model.Cell_Child_Order + ",");
            }
            if (model.Cell_Child_InOut != null)
            {
                strSql1.Append("Cell_Child_InOut,");
                strSql2.Append("'" + model.Cell_Child_InOut + "',");
            }
            if (model.Cell_Child_Model != null)
            {
                strSql1.Append("Cell_Child_Model,");
                strSql2.Append("'" + model.Cell_Child_Model + "',");
            }
            if (model.Cell_Child_Status != null)
            {
                strSql1.Append("Cell_Child_Status,");
                strSql2.Append("'" + model.Cell_Child_Status + "',");
            }
            if (model.Cell_Child_Flag != null)
            {
                strSql1.Append("Cell_Child_Flag,");
                strSql2.Append("'" + model.Cell_Child_Flag + "',");
            }
            if (model.Cell_Child_Run_Status != null)
            {
                strSql1.Append("Cell_Child_Run_Status,");
                strSql2.Append("'" + model.Cell_Child_Run_Status + "',");
            }
            if (model.Cell_Child_Operate_Type != null)
            {
                strSql1.Append("Cell_Child_Operate_Type,");
                strSql2.Append("'" + model.Cell_Child_Operate_Type + "',");
            }
            if (model.Cell_Child_TaskLock_ID != null)
            {
                strSql1.Append("Cell_Child_TaskLock_ID,");
                strSql2.Append("'" + model.Cell_Child_TaskLock_ID + "',");
            }
            strSql.Append("insert into View_Plan_Manage(");
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
        public bool Update(WMS_Database.View_Plan_ManageModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_Plan_Manage set ");
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
            if (model.Mange_ID != null)
            {
                strSql.Append("Mange_ID='" + model.Mange_ID + "',");
            }
            if (model.Manage_List_ID != null)
            {
                strSql.Append("Manage_List_ID='" + model.Manage_List_ID + "',");
            }
            if (model.Stock_List_ID != null)
            {
                strSql.Append("Stock_List_ID='" + model.Stock_List_ID + "',");
            }
            else
            {
                strSql.Append("Stock_List_ID= null ,");
            }
            if (model.Manage_List_Quantity != null)
            {
                strSql.Append("Manage_List_Quantity='" + model.Manage_List_Quantity + "',");
            }
            else
            {
                strSql.Append("Manage_List_Quantity= null ,");
            }
            if (model.Manage_List_Remark != null)
            {
                strSql.Append("Manage_List_Remark='" + model.Manage_List_Remark + "',");
            }
            else
            {
                strSql.Append("Manage_List_Remark= null ,");
            }
            if (model.Plan_List_Quantity != null)
            {
                strSql.Append("Plan_List_Quantity=" + model.Plan_List_Quantity + ",");
            }
            else
            {
                strSql.Append("Plan_List_Quantity= null ,");
            }
            if (model.Plan_List_Ordered_Quantity != null)
            {
                strSql.Append("Plan_List_Ordered_Quantity=" + model.Plan_List_Ordered_Quantity + ",");
            }
            else
            {
                strSql.Append("Plan_List_Ordered_Quantity= null ,");
            }
            if (model.Plan_List_Finished_Quantity != null)
            {
                strSql.Append("Plan_List_Finished_Quantity=" + model.Plan_List_Finished_Quantity + ",");
            }
            else
            {
                strSql.Append("Plan_List_Finished_Quantity= null ,");
            }
            if (model.Plan_List_Status != null)
            {
                strSql.Append("Plan_List_Status='" + model.Plan_List_Status + "',");
            }
            else
            {
                strSql.Append("Plan_List_Status= null ,");
            }
            if (model.Plan_List_Remark != null)
            {
                strSql.Append("Plan_List_Remark='" + model.Plan_List_Remark + "',");
            }
            else
            {
                strSql.Append("Plan_List_Remark= null ,");
            }
            if (model.Plan_Type_ID != null)
            {
                strSql.Append("Plan_Type_ID='" + model.Plan_Type_ID + "',");
            }
            else
            {
                strSql.Append("Plan_Type_ID= null ,");
            }
            if (model.Plan_Serial_Num != null)
            {
                strSql.Append("Plan_Serial_Num='" + model.Plan_Serial_Num + "',");
            }
            else
            {
                strSql.Append("Plan_Serial_Num= null ,");
            }
            if (model.Plan_Code != null)
            {
                strSql.Append("Plan_Code='" + model.Plan_Code + "',");
            }
            else
            {
                strSql.Append("Plan_Code= null ,");
            }
            if (model.Plan_Create_Time != null)
            {
                strSql.Append("Plan_Create_Time='" + model.Plan_Create_Time + "',");
            }
            else
            {
                strSql.Append("Plan_Create_Time= null ,");
            }
            if (model.Plan_End_Time != null)
            {
                strSql.Append("Plan_End_Time='" + model.Plan_End_Time + "',");
            }
            else
            {
                strSql.Append("Plan_End_Time= null ,");
            }
            if (model.Plan_Begin_Time != null)
            {
                strSql.Append("Plan_Begin_Time='" + model.Plan_Begin_Time + "',");
            }
            else
            {
                strSql.Append("Plan_Begin_Time= null ,");
            }
            if (model.Plan_Bill_Time != null)
            {
                strSql.Append("Plan_Bill_Time='" + model.Plan_Bill_Time + "',");
            }
            else
            {
                strSql.Append("Plan_Bill_Time= null ,");
            }
            if (model.Plan_Status != null)
            {
                strSql.Append("Plan_Status='" + model.Plan_Status + "',");
            }
            else
            {
                strSql.Append("Plan_Status= null ,");
            }
            if (model.Plan_Operater != null)
            {
                strSql.Append("Plan_Operater='" + model.Plan_Operater + "',");
            }
            else
            {
                strSql.Append("Plan_Operater= null ,");
            }
            if (model.Plan_From_Dept != null)
            {
                strSql.Append("Plan_From_Dept='" + model.Plan_From_Dept + "',");
            }
            else
            {
                strSql.Append("Plan_From_Dept= null ,");
            }
            if (model.Plan_To_Dept != null)
            {
                strSql.Append("Plan_To_Dept='" + model.Plan_To_Dept + "',");
            }
            else
            {
                strSql.Append("Plan_To_Dept= null ,");
            }
            if (model.Plan_From_User != null)
            {
                strSql.Append("Plan_From_User='" + model.Plan_From_User + "',");
            }
            else
            {
                strSql.Append("Plan_From_User= null ,");
            }
            if (model.Plan_To_User != null)
            {
                strSql.Append("Plan_To_User='" + model.Plan_To_User + "',");
            }
            else
            {
                strSql.Append("Plan_To_User= null ,");
            }
            if (model.Plan_Import_Flag != null)
            {
                strSql.Append("Plan_Import_Flag='" + model.Plan_Import_Flag + "',");
            }
            else
            {
                strSql.Append("Plan_Import_Flag= null ,");
            }
            if (model.Plan_Remark != null)
            {
                strSql.Append("Plan_Remark='" + model.Plan_Remark + "',");
            }
            else
            {
                strSql.Append("Plan_Remark= null ,");
            }
            if (model.Goods_ID != null)
            {
                strSql.Append("Goods_ID='" + model.Goods_ID + "',");
            }
            else
            {
                strSql.Append("Goods_ID= null ,");
            }
            if (model.Plan_List_ID != null)
            {
                strSql.Append("Plan_List_ID='" + model.Plan_List_ID + "',");
            }
            if (model.Cell_Child_ID != null)
            {
                strSql.Append("Cell_Child_ID='" + model.Cell_Child_ID + "',");
            }
            else
            {
                strSql.Append("Cell_Child_ID= null ,");
            }
            if (model.Stock_Tray_Barcode != null)
            {
                strSql.Append("Stock_Tray_Barcode='" + model.Stock_Tray_Barcode + "',");
            }
            else
            {
                strSql.Append("Stock_Tray_Barcode= null ,");
            }
            if (model.Stock_Full_Flag != null)
            {
                strSql.Append("Stock_Full_Flag='" + model.Stock_Full_Flag + "',");
            }
            else
            {
                strSql.Append("Stock_Full_Flag= null ,");
            }
            if (model.Stock_Remark != null)
            {
                strSql.Append("Stock_Remark='" + model.Stock_Remark + "',");
            }
            else
            {
                strSql.Append("Stock_Remark= null ,");
            }
            if (model.Stock_ID != null)
            {
                strSql.Append("Stock_ID='" + model.Stock_ID + "',");
            }
            else
            {
                strSql.Append("Stock_ID= null ,");
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
            if (model.Goods_Suppier_Code != null)
            {
                strSql.Append("Goods_Suppier_Code='" + model.Goods_Suppier_Code + "',");
            }
            else
            {
                strSql.Append("Goods_Suppier_Code= null ,");
            }
            if (model.Goods_Model != null)
            {
                strSql.Append("Goods_Model='" + model.Goods_Model + "',");
            }
            else
            {
                strSql.Append("Goods_Model= null ,");
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
            if (model.Goods_Unit != null)
            {
                strSql.Append("Goods_Unit='" + model.Goods_Unit + "',");
            }
            else
            {
                strSql.Append("Goods_Unit= null ,");
            }
            if (model.Goods_Limit_Upper_Quantity != null)
            {
                strSql.Append("Goods_Limit_Upper_Quantity='" + model.Goods_Limit_Upper_Quantity + "',");
            }
            else
            {
                strSql.Append("Goods_Limit_Upper_Quantity= null ,");
            }
            if (model.Goods_Limit_Lower_Quantity != null)
            {
                strSql.Append("Goods_Limit_Lower_Quantity='" + model.Goods_Limit_Lower_Quantity + "',");
            }
            else
            {
                strSql.Append("Goods_Limit_Lower_Quantity= null ,");
            }
            if (model.Goods_Order != null)
            {
                strSql.Append("Goods_Order=" + model.Goods_Order + ",");
            }
            else
            {
                strSql.Append("Goods_Order= null ,");
            }
            if (model.Goods_Flag != null)
            {
                strSql.Append("Goods_Flag='" + model.Goods_Flag + "',");
            }
            else
            {
                strSql.Append("Goods_Flag= null ,");
            }
            if (model.Goods_Danger != null)
            {
                strSql.Append("Goods_Danger='" + model.Goods_Danger + "',");
            }
            else
            {
                strSql.Append("Goods_Danger= null ,");
            }
            if (model.Goods_Category != null)
            {
                strSql.Append("Goods_Category='" + model.Goods_Category + "',");
            }
            else
            {
                strSql.Append("Goods_Category= null ,");
            }
            if (model.Goods_ProduceDate != null)
            {
                strSql.Append("Goods_ProduceDate='" + model.Goods_ProduceDate + "',");
            }
            else
            {
                strSql.Append("Goods_ProduceDate= null ,");
            }
            if (model.Goods_Asset != null)
            {
                strSql.Append("Goods_Asset='" + model.Goods_Asset + "',");
            }
            else
            {
                strSql.Append("Goods_Asset= null ,");
            }
            if (model.Goods_Shelf_Life != null)
            {
                strSql.Append("Goods_Shelf_Life=" + model.Goods_Shelf_Life + ",");
            }
            else
            {
                strSql.Append("Goods_Shelf_Life= null ,");
            }
            if (model.Goods_Department != null)
            {
                strSql.Append("Goods_Department='" + model.Goods_Department + "',");
            }
            else
            {
                strSql.Append("Goods_Department= null ,");
            }
            if (model.Cell_ID != null)
            {
                strSql.Append("Cell_ID='" + model.Cell_ID + "',");
            }
            if (model.Area_ID != null)
            {
                strSql.Append("Area_ID='" + model.Area_ID + "',");
            }
            else
            {
                strSql.Append("Area_ID= null ,");
            }
            if (model.Cell_Code != null)
            {
                strSql.Append("Cell_Code='" + model.Cell_Code + "',");
            }
            else
            {
                strSql.Append("Cell_Code= null ,");
            }
            if (model.Cell_Name != null)
            {
                strSql.Append("Cell_Name='" + model.Cell_Name + "',");
            }
            else
            {
                strSql.Append("Cell_Name= null ,");
            }
            if (model.Cell_Lane != null)
            {
                strSql.Append("Cell_Lane='" + model.Cell_Lane + "',");
            }
            else
            {
                strSql.Append("Cell_Lane= null ,");
            }
            if (model.Device_Code != null)
            {
                strSql.Append("Device_Code='" + model.Device_Code + "',");
            }
            else
            {
                strSql.Append("Device_Code= null ,");
            }
            if (model.Shelf_Type != null)
            {
                strSql.Append("Shelf_Type='" + model.Shelf_Type + "',");
            }
            else
            {
                strSql.Append("Shelf_Type= null ,");
            }
            if (model.Cell_InOut != null)
            {
                strSql.Append("Cell_InOut='" + model.Cell_InOut + "',");
            }
            else
            {
                strSql.Append("Cell_InOut= null ,");
            }
            if (model.Cell_Type != null)
            {
                strSql.Append("Cell_Type='" + model.Cell_Type + "',");
            }
            else
            {
                strSql.Append("Cell_Type= null ,");
            }
            if (model.Cell_Storage_Type != null)
            {
                strSql.Append("Cell_Storage_Type='" + model.Cell_Storage_Type + "',");
            }
            else
            {
                strSql.Append("Cell_Storage_Type= null ,");
            }
            if (model.Cell_Fork_Type != null)
            {
                strSql.Append("Cell_Fork_Type='" + model.Cell_Fork_Type + "',");
            }
            else
            {
                strSql.Append("Cell_Fork_Type= null ,");
            }
            if (model.Cell_Layer != null)
            {
                strSql.Append("Cell_Layer=" + model.Cell_Layer + ",");
            }
            else
            {
                strSql.Append("Cell_Layer= null ,");
            }
            if (model.Cell_Row != null)
            {
                strSql.Append("Cell_Row=" + model.Cell_Row + ",");
            }
            else
            {
                strSql.Append("Cell_Row= null ,");
            }
            if (model.Cell_Column != null)
            {
                strSql.Append("Cell_Column=" + model.Cell_Column + ",");
            }
            else
            {
                strSql.Append("Cell_Column= null ,");
            }
            if (model.Cell_Chlid_ID != null)
            {
                strSql.Append("Cell_Chlid_ID='" + model.Cell_Chlid_ID + "',");
            }
            if (model.Cell_Chlid_Position != null)
            {
                strSql.Append("Cell_Chlid_Position='" + model.Cell_Chlid_Position + "',");
            }
            else
            {
                strSql.Append("Cell_Chlid_Position= null ,");
            }
            if (model.Cell_Child_Order != null)
            {
                strSql.Append("Cell_Child_Order=" + model.Cell_Child_Order + ",");
            }
            else
            {
                strSql.Append("Cell_Child_Order= null ,");
            }
            if (model.Cell_Child_InOut != null)
            {
                strSql.Append("Cell_Child_InOut='" + model.Cell_Child_InOut + "',");
            }
            else
            {
                strSql.Append("Cell_Child_InOut= null ,");
            }
            if (model.Cell_Child_Model != null)
            {
                strSql.Append("Cell_Child_Model='" + model.Cell_Child_Model + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Model= null ,");
            }
            if (model.Cell_Child_Status != null)
            {
                strSql.Append("Cell_Child_Status='" + model.Cell_Child_Status + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Status= null ,");
            }
            if (model.Cell_Child_Flag != null)
            {
                strSql.Append("Cell_Child_Flag='" + model.Cell_Child_Flag + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Flag= null ,");
            }
            if (model.Cell_Child_Run_Status != null)
            {
                strSql.Append("Cell_Child_Run_Status='" + model.Cell_Child_Run_Status + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Run_Status= null ,");
            }
            if (model.Cell_Child_Operate_Type != null)
            {
                strSql.Append("Cell_Child_Operate_Type='" + model.Cell_Child_Operate_Type + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Operate_Type= null ,");
            }
            if (model.Cell_Child_TaskLock_ID != null)
            {
                strSql.Append("Cell_Child_TaskLock_ID='" + model.Cell_Child_TaskLock_ID + "',");
            }
            else
            {
                strSql.Append("Cell_Child_TaskLock_ID= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Plan_ID='" + model.Plan_ID + "' and Mange_Type_ID='" + model.Mange_Type_ID + "' and Mange_Status='" + model.Mange_Status + "' and Mange_Stock_Barcode='" + model.Mange_Stock_Barcode + "' and Mange_Full_Flag='" + model.Mange_Full_Flag + "' and Manage_BreakDown_Status='" + model.Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + model.Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + model.Mange_End_Cell_ID + "' and Manage_Operater='" + model.Manage_Operater + "' and Manage_Begin_Time='" + model.Manage_Begin_Time + "' and Manage_End_Time='" + model.Manage_End_Time + "' and Manage_Remark='" + model.Manage_Remark + "' and Mange_ID='" + model.Mange_ID + "' and Manage_List_ID='" + model.Manage_List_ID + "' and Stock_List_ID='" + model.Stock_List_ID + "' and Manage_List_Quantity='" + model.Manage_List_Quantity + "' and Manage_List_Remark='" + model.Manage_List_Remark + "' and Plan_List_Quantity=" + model.Plan_List_Quantity + " and Plan_List_Ordered_Quantity=" + model.Plan_List_Ordered_Quantity + " and Plan_List_Finished_Quantity=" + model.Plan_List_Finished_Quantity + " and Plan_List_Status='" + model.Plan_List_Status + "' and Plan_List_Remark='" + model.Plan_List_Remark + "' and Plan_Type_ID='" + model.Plan_Type_ID + "' and Plan_Serial_Num='" + model.Plan_Serial_Num + "' and Plan_Code='" + model.Plan_Code + "' and Plan_Create_Time='" + model.Plan_Create_Time + "' and Plan_End_Time='" + model.Plan_End_Time + "' and Plan_Begin_Time='" + model.Plan_Begin_Time + "' and Plan_Bill_Time='" + model.Plan_Bill_Time + "' and Plan_Status='" + model.Plan_Status + "' and Plan_Operater='" + model.Plan_Operater + "' and Plan_From_Dept='" + model.Plan_From_Dept + "' and Plan_To_Dept='" + model.Plan_To_Dept + "' and Plan_From_User='" + model.Plan_From_User + "' and Plan_To_User='" + model.Plan_To_User + "' and Plan_Import_Flag='" + model.Plan_Import_Flag + "' and Plan_Remark='" + model.Plan_Remark + "' and Goods_ID='" + model.Goods_ID + "' and Plan_List_ID='" + model.Plan_List_ID + "' and Cell_Child_ID='" + model.Cell_Child_ID + "' and Stock_Tray_Barcode='" + model.Stock_Tray_Barcode + "' and Stock_Full_Flag='" + model.Stock_Full_Flag + "' and Stock_Remark='" + model.Stock_Remark + "' and Stock_ID='" + model.Stock_ID + "' and Stock_List_Box_Barcode='" + model.Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + model.Stock_List_Quantity + "' and Stock_List_Entry_Time='" + model.Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + model.Stock_List_Update_Time + "' and Stock_List_Remark='" + model.Stock_List_Remark + "' and Goods_Class_ID='" + model.Goods_Class_ID + "' and Goods_Code='" + model.Goods_Code + "' and Goods_Name='" + model.Goods_Name + "' and Goods_Type='" + model.Goods_Type + "' and Goods_Suppier_Code='" + model.Goods_Suppier_Code + "' and Goods_Model='" + model.Goods_Model + "' and Goods_Desc='" + model.Goods_Desc + "' and Goods_Level='" + model.Goods_Level + "' and Goods_Unit='" + model.Goods_Unit + "' and Goods_Limit_Upper_Quantity='" + model.Goods_Limit_Upper_Quantity + "' and Goods_Limit_Lower_Quantity='" + model.Goods_Limit_Lower_Quantity + "' and Goods_Order=" + model.Goods_Order + " and Goods_Flag='" + model.Goods_Flag + "' and Goods_Danger='" + model.Goods_Danger + "' and Goods_Category='" + model.Goods_Category + "' and Goods_ProduceDate='" + model.Goods_ProduceDate + "' and Goods_Asset='" + model.Goods_Asset + "' and Goods_Shelf_Life=" + model.Goods_Shelf_Life + " and Goods_Department='" + model.Goods_Department + "' and Cell_ID='" + model.Cell_ID + "' and Area_ID='" + model.Area_ID + "' and Cell_Code='" + model.Cell_Code + "' and Cell_Name='" + model.Cell_Name + "' and Cell_Lane='" + model.Cell_Lane + "' and Device_Code='" + model.Device_Code + "' and Shelf_Type='" + model.Shelf_Type + "' and Cell_InOut='" + model.Cell_InOut + "' and Cell_Type='" + model.Cell_Type + "' and Cell_Storage_Type='" + model.Cell_Storage_Type + "' and Cell_Fork_Type='" + model.Cell_Fork_Type + "' and Cell_Layer=" + model.Cell_Layer + " and Cell_Row=" + model.Cell_Row + " and Cell_Column=" + model.Cell_Column + " and Cell_Chlid_ID='" + model.Cell_Chlid_ID + "' and Cell_Chlid_Position='" + model.Cell_Chlid_Position + "' and Cell_Child_Order=" + model.Cell_Child_Order + " and Cell_Child_InOut='" + model.Cell_Child_InOut + "' and Cell_Child_Model='" + model.Cell_Child_Model + "' and Cell_Child_Status='" + model.Cell_Child_Status + "' and Cell_Child_Flag='" + model.Cell_Child_Flag + "' and Cell_Child_Run_Status='" + model.Cell_Child_Run_Status + "' and Cell_Child_Operate_Type='" + model.Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + model.Cell_Child_TaskLock_ID + "' ");
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
        public bool Delete(string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Mange_ID, string Manage_List_ID, string Stock_List_ID, string Manage_List_Quantity, string Manage_List_Remark, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Goods_ID, string Plan_List_ID, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Stock_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, DateTime Goods_ProduceDate, string Goods_Asset, int Goods_Shelf_Life, string Goods_Department, string Cell_ID, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Row, int Cell_Column, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Flag, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_Plan_Manage ");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Mange_Status='" + Mange_Status + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Remark='" + Manage_Remark + "' and Mange_ID='" + Mange_ID + "' and Manage_List_ID='" + Manage_List_ID + "' and Stock_List_ID='" + Stock_List_ID + "' and Manage_List_Quantity='" + Manage_List_Quantity + "' and Manage_List_Remark='" + Manage_List_Remark + "' and Plan_List_Quantity=" + Plan_List_Quantity + " and Plan_List_Ordered_Quantity=" + Plan_List_Ordered_Quantity + " and Plan_List_Finished_Quantity=" + Plan_List_Finished_Quantity + " and Plan_List_Status='" + Plan_List_Status + "' and Plan_List_Remark='" + Plan_List_Remark + "' and Plan_Type_ID='" + Plan_Type_ID + "' and Plan_Serial_Num='" + Plan_Serial_Num + "' and Plan_Code='" + Plan_Code + "' and Plan_Create_Time='" + Plan_Create_Time + "' and Plan_End_Time='" + Plan_End_Time + "' and Plan_Begin_Time='" + Plan_Begin_Time + "' and Plan_Bill_Time='" + Plan_Bill_Time + "' and Plan_Status='" + Plan_Status + "' and Plan_Operater='" + Plan_Operater + "' and Plan_From_Dept='" + Plan_From_Dept + "' and Plan_To_Dept='" + Plan_To_Dept + "' and Plan_From_User='" + Plan_From_User + "' and Plan_To_User='" + Plan_To_User + "' and Plan_Import_Flag='" + Plan_Import_Flag + "' and Plan_Remark='" + Plan_Remark + "' and Goods_ID='" + Goods_ID + "' and Plan_List_ID='" + Plan_List_ID + "' and Cell_Child_ID='" + Cell_Child_ID + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Stock_Full_Flag='" + Stock_Full_Flag + "' and Stock_Remark='" + Stock_Remark + "' and Stock_ID='" + Stock_ID + "' and Stock_List_Box_Barcode='" + Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + Stock_List_Quantity + "' and Stock_List_Entry_Time='" + Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + Stock_List_Update_Time + "' and Stock_List_Remark='" + Stock_List_Remark + "' and Goods_Class_ID='" + Goods_Class_ID + "' and Goods_Code='" + Goods_Code + "' and Goods_Name='" + Goods_Name + "' and Goods_Type='" + Goods_Type + "' and Goods_Suppier_Code='" + Goods_Suppier_Code + "' and Goods_Model='" + Goods_Model + "' and Goods_Desc='" + Goods_Desc + "' and Goods_Level='" + Goods_Level + "' and Goods_Unit='" + Goods_Unit + "' and Goods_Limit_Upper_Quantity='" + Goods_Limit_Upper_Quantity + "' and Goods_Limit_Lower_Quantity='" + Goods_Limit_Lower_Quantity + "' and Goods_Order=" + Goods_Order + " and Goods_Flag='" + Goods_Flag + "' and Goods_Danger='" + Goods_Danger + "' and Goods_Category='" + Goods_Category + "' and Goods_ProduceDate='" + Goods_ProduceDate + "' and Goods_Asset='" + Goods_Asset + "' and Goods_Shelf_Life=" + Goods_Shelf_Life + " and Goods_Department='" + Goods_Department + "' and Cell_ID='" + Cell_ID + "' and Area_ID='" + Area_ID + "' and Cell_Code='" + Cell_Code + "' and Cell_Name='" + Cell_Name + "' and Cell_Lane='" + Cell_Lane + "' and Device_Code='" + Device_Code + "' and Shelf_Type='" + Shelf_Type + "' and Cell_InOut='" + Cell_InOut + "' and Cell_Type='" + Cell_Type + "' and Cell_Storage_Type='" + Cell_Storage_Type + "' and Cell_Fork_Type='" + Cell_Fork_Type + "' and Cell_Layer=" + Cell_Layer + " and Cell_Row=" + Cell_Row + " and Cell_Column=" + Cell_Column + " and Cell_Chlid_ID='" + Cell_Chlid_ID + "' and Cell_Chlid_Position='" + Cell_Chlid_Position + "' and Cell_Child_Order=" + Cell_Child_Order + " and Cell_Child_InOut='" + Cell_Child_InOut + "' and Cell_Child_Model='" + Cell_Child_Model + "' and Cell_Child_Status='" + Cell_Child_Status + "' and Cell_Child_Flag='" + Cell_Child_Flag + "' and Cell_Child_Run_Status='" + Cell_Child_Run_Status + "' and Cell_Child_Operate_Type='" + Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + Cell_Child_TaskLock_ID + "' ");
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
        public WMS_Database.View_Plan_ManageModel GetModel(string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Mange_ID, string Manage_List_ID, string Stock_List_ID, string Manage_List_Quantity, string Manage_List_Remark, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, string Plan_Remark, string Goods_ID, string Plan_List_ID, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Stock_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Class_ID, string Goods_Code, string Goods_Name, string Goods_Type, string Goods_Suppier_Code, string Goods_Model, string Goods_Desc, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, DateTime Goods_ProduceDate, string Goods_Asset, int Goods_Shelf_Life, string Goods_Department, string Cell_ID, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Row, int Cell_Column, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Flag, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_ID,Manage_List_ID,Stock_List_ID,Manage_List_Quantity,Manage_List_Remark,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Plan_List_Status,Plan_List_Remark,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_End_Time,Plan_Begin_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Goods_ID,Plan_List_ID,Cell_Child_ID,Stock_Tray_Barcode,Stock_Full_Flag,Stock_Remark,Stock_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_ProduceDate,Goods_Asset,Goods_Shelf_Life,Goods_Department,Cell_ID,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Row,Cell_Column,Cell_Chlid_ID,Cell_Chlid_Position,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Flag,Cell_Child_Run_Status,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID ");
            strSql.Append(" from View_Plan_Manage ");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Mange_Status='" + Mange_Status + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Remark='" + Manage_Remark + "' and Mange_ID='" + Mange_ID + "' and Manage_List_ID='" + Manage_List_ID + "' and Stock_List_ID='" + Stock_List_ID + "' and Manage_List_Quantity='" + Manage_List_Quantity + "' and Manage_List_Remark='" + Manage_List_Remark + "' and Plan_List_Quantity=" + Plan_List_Quantity + " and Plan_List_Ordered_Quantity=" + Plan_List_Ordered_Quantity + " and Plan_List_Finished_Quantity=" + Plan_List_Finished_Quantity + " and Plan_List_Status='" + Plan_List_Status + "' and Plan_List_Remark='" + Plan_List_Remark + "' and Plan_Type_ID='" + Plan_Type_ID + "' and Plan_Serial_Num='" + Plan_Serial_Num + "' and Plan_Code='" + Plan_Code + "' and Plan_Create_Time='" + Plan_Create_Time + "' and Plan_End_Time='" + Plan_End_Time + "' and Plan_Begin_Time='" + Plan_Begin_Time + "' and Plan_Bill_Time='" + Plan_Bill_Time + "' and Plan_Status='" + Plan_Status + "' and Plan_Operater='" + Plan_Operater + "' and Plan_From_Dept='" + Plan_From_Dept + "' and Plan_To_Dept='" + Plan_To_Dept + "' and Plan_From_User='" + Plan_From_User + "' and Plan_To_User='" + Plan_To_User + "' and Plan_Import_Flag='" + Plan_Import_Flag + "' and Plan_Remark='" + Plan_Remark + "' and Goods_ID='" + Goods_ID + "' and Plan_List_ID='" + Plan_List_ID + "' and Cell_Child_ID='" + Cell_Child_ID + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Stock_Full_Flag='" + Stock_Full_Flag + "' and Stock_Remark='" + Stock_Remark + "' and Stock_ID='" + Stock_ID + "' and Stock_List_Box_Barcode='" + Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + Stock_List_Quantity + "' and Stock_List_Entry_Time='" + Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + Stock_List_Update_Time + "' and Stock_List_Remark='" + Stock_List_Remark + "' and Goods_Class_ID='" + Goods_Class_ID + "' and Goods_Code='" + Goods_Code + "' and Goods_Name='" + Goods_Name + "' and Goods_Type='" + Goods_Type + "' and Goods_Suppier_Code='" + Goods_Suppier_Code + "' and Goods_Model='" + Goods_Model + "' and Goods_Desc='" + Goods_Desc + "' and Goods_Level='" + Goods_Level + "' and Goods_Unit='" + Goods_Unit + "' and Goods_Limit_Upper_Quantity='" + Goods_Limit_Upper_Quantity + "' and Goods_Limit_Lower_Quantity='" + Goods_Limit_Lower_Quantity + "' and Goods_Order=" + Goods_Order + " and Goods_Flag='" + Goods_Flag + "' and Goods_Danger='" + Goods_Danger + "' and Goods_Category='" + Goods_Category + "' and Goods_ProduceDate='" + Goods_ProduceDate + "' and Goods_Asset='" + Goods_Asset + "' and Goods_Shelf_Life=" + Goods_Shelf_Life + " and Goods_Department='" + Goods_Department + "' and Cell_ID='" + Cell_ID + "' and Area_ID='" + Area_ID + "' and Cell_Code='" + Cell_Code + "' and Cell_Name='" + Cell_Name + "' and Cell_Lane='" + Cell_Lane + "' and Device_Code='" + Device_Code + "' and Shelf_Type='" + Shelf_Type + "' and Cell_InOut='" + Cell_InOut + "' and Cell_Type='" + Cell_Type + "' and Cell_Storage_Type='" + Cell_Storage_Type + "' and Cell_Fork_Type='" + Cell_Fork_Type + "' and Cell_Layer=" + Cell_Layer + " and Cell_Row=" + Cell_Row + " and Cell_Column=" + Cell_Column + " and Cell_Chlid_ID='" + Cell_Chlid_ID + "' and Cell_Chlid_Position='" + Cell_Chlid_Position + "' and Cell_Child_Order=" + Cell_Child_Order + " and Cell_Child_InOut='" + Cell_Child_InOut + "' and Cell_Child_Model='" + Cell_Child_Model + "' and Cell_Child_Status='" + Cell_Child_Status + "' and Cell_Child_Flag='" + Cell_Child_Flag + "' and Cell_Child_Run_Status='" + Cell_Child_Run_Status + "' and Cell_Child_Operate_Type='" + Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + Cell_Child_TaskLock_ID + "' ");
            WMS_Database.View_Plan_ManageModel model = new WMS_Database.View_Plan_ManageModel();
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
        public WMS_Database.View_Plan_ManageModel DataRowToModel(DataRow row)
        {
            WMS_Database.View_Plan_ManageModel model = new WMS_Database.View_Plan_ManageModel();
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
                if (row["Mange_ID"] != null)
                {
                    model.Mange_ID = row["Mange_ID"].ToString();
                }
                if (row["Manage_List_ID"] != null)
                {
                    model.Manage_List_ID = row["Manage_List_ID"].ToString();
                }
                if (row["Stock_List_ID"] != null)
                {
                    model.Stock_List_ID = row["Stock_List_ID"].ToString();
                }
                if (row["Manage_List_Quantity"] != null)
                {
                    model.Manage_List_Quantity = row["Manage_List_Quantity"].ToString();
                }
                if (row["Manage_List_Remark"] != null)
                {
                    model.Manage_List_Remark = row["Manage_List_Remark"].ToString();
                }
                if (row["Plan_List_Quantity"] != null && row["Plan_List_Quantity"].ToString() != "")
                {
                    model.Plan_List_Quantity = int.Parse(row["Plan_List_Quantity"].ToString());
                }
                if (row["Plan_List_Ordered_Quantity"] != null && row["Plan_List_Ordered_Quantity"].ToString() != "")
                {
                    model.Plan_List_Ordered_Quantity = int.Parse(row["Plan_List_Ordered_Quantity"].ToString());
                }
                if (row["Plan_List_Finished_Quantity"] != null && row["Plan_List_Finished_Quantity"].ToString() != "")
                {
                    model.Plan_List_Finished_Quantity = int.Parse(row["Plan_List_Finished_Quantity"].ToString());
                }
                if (row["Plan_List_Status"] != null)
                {
                    model.Plan_List_Status = row["Plan_List_Status"].ToString();
                }
                if (row["Plan_List_Remark"] != null)
                {
                    model.Plan_List_Remark = row["Plan_List_Remark"].ToString();
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
                if (row["Plan_End_Time"] != null && row["Plan_End_Time"].ToString() != "")
                {
                    model.Plan_End_Time = DateTime.Parse(row["Plan_End_Time"].ToString());
                }
                if (row["Plan_Begin_Time"] != null && row["Plan_Begin_Time"].ToString() != "")
                {
                    model.Plan_Begin_Time = DateTime.Parse(row["Plan_Begin_Time"].ToString());
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
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
                }
                if (row["Plan_List_ID"] != null)
                {
                    model.Plan_List_ID = row["Plan_List_ID"].ToString();
                }
                if (row["Cell_Child_ID"] != null)
                {
                    model.Cell_Child_ID = row["Cell_Child_ID"].ToString();
                }
                if (row["Stock_Tray_Barcode"] != null)
                {
                    model.Stock_Tray_Barcode = row["Stock_Tray_Barcode"].ToString();
                }
                if (row["Stock_Full_Flag"] != null)
                {
                    model.Stock_Full_Flag = row["Stock_Full_Flag"].ToString();
                }
                if (row["Stock_Remark"] != null)
                {
                    model.Stock_Remark = row["Stock_Remark"].ToString();
                }
                if (row["Stock_ID"] != null)
                {
                    model.Stock_ID = row["Stock_ID"].ToString();
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
                if (row["Goods_Danger"] != null)
                {
                    model.Goods_Danger = row["Goods_Danger"].ToString();
                }
                if (row["Goods_Category"] != null)
                {
                    model.Goods_Category = row["Goods_Category"].ToString();
                }
                if (row["Goods_ProduceDate"] != null && row["Goods_ProduceDate"].ToString() != "")
                {
                    model.Goods_ProduceDate = DateTime.Parse(row["Goods_ProduceDate"].ToString());
                }
                if (row["Goods_Asset"] != null)
                {
                    model.Goods_Asset = row["Goods_Asset"].ToString();
                }
                if (row["Goods_Shelf_Life"] != null && row["Goods_Shelf_Life"].ToString() != "")
                {
                    model.Goods_Shelf_Life = int.Parse(row["Goods_Shelf_Life"].ToString());
                }
                if (row["Goods_Department"] != null)
                {
                    model.Goods_Department = row["Goods_Department"].ToString();
                }
                if (row["Cell_ID"] != null)
                {
                    model.Cell_ID = row["Cell_ID"].ToString();
                }
                if (row["Area_ID"] != null)
                {
                    model.Area_ID = row["Area_ID"].ToString();
                }
                if (row["Cell_Code"] != null)
                {
                    model.Cell_Code = row["Cell_Code"].ToString();
                }
                if (row["Cell_Name"] != null)
                {
                    model.Cell_Name = row["Cell_Name"].ToString();
                }
                if (row["Cell_Lane"] != null)
                {
                    model.Cell_Lane = row["Cell_Lane"].ToString();
                }
                if (row["Device_Code"] != null)
                {
                    model.Device_Code = row["Device_Code"].ToString();
                }
                if (row["Shelf_Type"] != null)
                {
                    model.Shelf_Type = row["Shelf_Type"].ToString();
                }
                if (row["Cell_InOut"] != null)
                {
                    model.Cell_InOut = row["Cell_InOut"].ToString();
                }
                if (row["Cell_Type"] != null)
                {
                    model.Cell_Type = row["Cell_Type"].ToString();
                }
                if (row["Cell_Storage_Type"] != null)
                {
                    model.Cell_Storage_Type = row["Cell_Storage_Type"].ToString();
                }
                if (row["Cell_Fork_Type"] != null)
                {
                    model.Cell_Fork_Type = row["Cell_Fork_Type"].ToString();
                }
                if (row["Cell_Layer"] != null && row["Cell_Layer"].ToString() != "")
                {
                    model.Cell_Layer = int.Parse(row["Cell_Layer"].ToString());
                }
                if (row["Cell_Row"] != null && row["Cell_Row"].ToString() != "")
                {
                    model.Cell_Row = int.Parse(row["Cell_Row"].ToString());
                }
                if (row["Cell_Column"] != null && row["Cell_Column"].ToString() != "")
                {
                    model.Cell_Column = int.Parse(row["Cell_Column"].ToString());
                }
                if (row["Cell_Chlid_ID"] != null)
                {
                    model.Cell_Chlid_ID = row["Cell_Chlid_ID"].ToString();
                }
                if (row["Cell_Chlid_Position"] != null)
                {
                    model.Cell_Chlid_Position = row["Cell_Chlid_Position"].ToString();
                }
                if (row["Cell_Child_Order"] != null && row["Cell_Child_Order"].ToString() != "")
                {
                    model.Cell_Child_Order = int.Parse(row["Cell_Child_Order"].ToString());
                }
                if (row["Cell_Child_InOut"] != null)
                {
                    model.Cell_Child_InOut = row["Cell_Child_InOut"].ToString();
                }
                if (row["Cell_Child_Model"] != null)
                {
                    model.Cell_Child_Model = row["Cell_Child_Model"].ToString();
                }
                if (row["Cell_Child_Status"] != null)
                {
                    model.Cell_Child_Status = row["Cell_Child_Status"].ToString();
                }
                if (row["Cell_Child_Flag"] != null)
                {
                    model.Cell_Child_Flag = row["Cell_Child_Flag"].ToString();
                }
                if (row["Cell_Child_Run_Status"] != null)
                {
                    model.Cell_Child_Run_Status = row["Cell_Child_Run_Status"].ToString();
                }
                if (row["Cell_Child_Operate_Type"] != null)
                {
                    model.Cell_Child_Operate_Type = row["Cell_Child_Operate_Type"].ToString();
                }
                if (row["Cell_Child_TaskLock_ID"] != null)
                {
                    model.Cell_Child_TaskLock_ID = row["Cell_Child_TaskLock_ID"].ToString();
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
            strSql.Append("select Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_ID,Manage_List_ID,Stock_List_ID,Manage_List_Quantity,Manage_List_Remark,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Plan_List_Status,Plan_List_Remark,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_End_Time,Plan_Begin_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Goods_ID,Plan_List_ID,Cell_Child_ID,Stock_Tray_Barcode,Stock_Full_Flag,Stock_Remark,Stock_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_ProduceDate,Goods_Asset,Goods_Shelf_Life,Goods_Department,Cell_ID,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Row,Cell_Column,Cell_Chlid_ID,Cell_Chlid_Position,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Flag,Cell_Child_Run_Status,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID ");
            strSql.Append(" FROM View_Plan_Manage ");
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
            strSql.Append(" Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_ID,Manage_List_ID,Stock_List_ID,Manage_List_Quantity,Manage_List_Remark,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_List_Finished_Quantity,Plan_List_Status,Plan_List_Remark,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_End_Time,Plan_Begin_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Goods_ID,Plan_List_ID,Cell_Child_ID,Stock_Tray_Barcode,Stock_Full_Flag,Stock_Remark,Stock_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_ProduceDate,Goods_Asset,Goods_Shelf_Life,Goods_Department,Cell_ID,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Row,Cell_Column,Cell_Chlid_ID,Cell_Chlid_Position,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Flag,Cell_Child_Run_Status,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID ");
            strSql.Append(" FROM View_Plan_Manage ");
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
            strSql.Append("select count(1) FROM View_Plan_Manage ");
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
                strSql.Append("order by T.Cell_Child_TaskLock_ID desc");
            }
            strSql.Append(")AS Row, T.*  from View_Plan_Manage T ");
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

