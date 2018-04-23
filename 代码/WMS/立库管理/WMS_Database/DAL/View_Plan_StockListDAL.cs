using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 

namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:View_Plan_StockList
    /// </summary>
    public partial class View_Plan_StockListDAL
    {
        public View_Plan_StockListDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Stock_List_ID, string Stock_ID, string Plan_List_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, string Goods_ID, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Code, string Goods_Class_ID, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Level, string Goods_Limit_Lower_Quantity, string Goods_Remark, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Stock_Tray_Barcode, string Stock_Full_Flag, string WareHouse_ID, string Area_Type, string Area_Code, string Area_Name, int Area_Order, string Area_Flag, string Area_BackColor, string Area_Remark, string Area_Reserve1, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag, string WareHouse_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, string Plan_ID, string Plan_Remark, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, int Goods_Shelf_Life, DateTime Goods_ProduceDate, int Goods_Order, string Goods_Type, string Area_ID, string Cell_Code, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Status, string Cell_Child_Model, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Goods_Suppier_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_Plan_StockList");
            strSql.Append(" where Stock_List_ID='" + Stock_List_ID + "' and Stock_ID='" + Stock_ID + "' and Plan_List_ID='" + Plan_List_ID + "' and Stock_List_Box_Barcode='" + Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + Stock_List_Quantity + "' and Goods_ID='" + Goods_ID + "' and Stock_List_Entry_Time='" + Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + Stock_List_Update_Time + "' and Stock_List_Remark='" + Stock_List_Remark + "' and Goods_Code='" + Goods_Code + "' and Goods_Class_ID='" + Goods_Class_ID + "' and Goods_Name='" + Goods_Name + "' and Goods_Desc='" + Goods_Desc + "' and Goods_Model='" + Goods_Model + "' and Goods_Unit='" + Goods_Unit + "' and Goods_Limit_Upper_Quantity='" + Goods_Limit_Upper_Quantity + "' and Goods_Level='" + Goods_Level + "' and Goods_Limit_Lower_Quantity='" + Goods_Limit_Lower_Quantity + "' and Goods_Remark='" + Goods_Remark + "' and Goods_Flag='" + Goods_Flag + "' and Goods_Danger='" + Goods_Danger + "' and Goods_Category='" + Goods_Category + "' and Goods_Asset='" + Goods_Asset + "' and Goods_Department='" + Goods_Department + "' and Goods_Reserve1='" + Goods_Reserve1 + "' and Goods_Reserve2='" + Goods_Reserve2 + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Stock_Full_Flag='" + Stock_Full_Flag + "' and WareHouse_ID='" + WareHouse_ID + "' and Area_Type='" + Area_Type + "' and Area_Code='" + Area_Code + "' and Area_Name='" + Area_Name + "' and Area_Order=" + Area_Order + " and Area_Flag='" + Area_Flag + "' and Area_BackColor='" + Area_BackColor + "' and Area_Remark='" + Area_Remark + "' and Area_Reserve1='" + Area_Reserve1 + "' and WareHouse_Code='" + WareHouse_Code + "' and WareHouse_Name='" + WareHouse_Name + "' and WareHouse_Type='" + WareHouse_Type + "' and WareHouse_Flag='" + WareHouse_Flag + "' and WareHouse_Remark='" + WareHouse_Remark + "' and Plan_Type_ID='" + Plan_Type_ID + "' and Plan_Serial_Num='" + Plan_Serial_Num + "' and Plan_Code='" + Plan_Code + "' and Plan_Create_Time='" + Plan_Create_Time + "' and Plan_End_Time='" + Plan_End_Time + "' and Plan_Begin_Time='" + Plan_Begin_Time + "' and Plan_Bill_Time='" + Plan_Bill_Time + "' and Plan_Status='" + Plan_Status + "' and Plan_Operater='" + Plan_Operater + "' and Plan_From_Dept='" + Plan_From_Dept + "' and Plan_To_Dept='" + Plan_To_Dept + "' and Plan_From_User='" + Plan_From_User + "' and Plan_To_User='" + Plan_To_User + "' and Plan_Import_Flag='" + Plan_Import_Flag + "' and Plan_List_Quantity=" + Plan_List_Quantity + " and Plan_List_Ordered_Quantity=" + Plan_List_Ordered_Quantity + " and Plan_ID='" + Plan_ID + "' and Plan_Remark='" + Plan_Remark + "' and Plan_List_Finished_Quantity=" + Plan_List_Finished_Quantity + " and Plan_List_Status='" + Plan_List_Status + "' and Plan_List_Remark='" + Plan_List_Remark + "' and Goods_Shelf_Life=" + Goods_Shelf_Life + " and Goods_ProduceDate='" + Goods_ProduceDate + "' and Goods_Order=" + Goods_Order + " and Goods_Type='" + Goods_Type + "' and Area_ID='" + Area_ID + "' and Cell_Code='" + Cell_Code + "' and Cell_Chlid_ID='" + Cell_Chlid_ID + "' and Cell_Chlid_Position='" + Cell_Chlid_Position + "' and Cell_Child_Order=" + Cell_Child_Order + " and Cell_Child_InOut='" + Cell_Child_InOut + "' and Cell_Child_Status='" + Cell_Child_Status + "' and Cell_Child_Model='" + Cell_Child_Model + "' and Cell_Child_Run_Status='" + Cell_Child_Run_Status + "' and Cell_Child_Flag='" + Cell_Child_Flag + "' and Cell_Child_Operate_Type='" + Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + Cell_Child_TaskLock_ID + "' and Cell_Name='" + Cell_Name + "' and Cell_Lane='" + Cell_Lane + "' and Device_Code='" + Device_Code + "' and Shelf_Type='" + Shelf_Type + "' and Cell_InOut='" + Cell_InOut + "' and Cell_Type='" + Cell_Type + "' and Cell_Storage_Type='" + Cell_Storage_Type + "' and Cell_Fork_Type='" + Cell_Fork_Type + "' and Cell_Layer=" + Cell_Layer + " and Cell_Column=" + Cell_Column + " and Cell_Row=" + Cell_Row + " and Goods_Suppier_Code='" + Goods_Suppier_Code + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_Plan_StockListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Stock_List_ID != null)
            {
                strSql1.Append("Stock_List_ID,");
                strSql2.Append("'" + model.Stock_List_ID + "',");
            }
            if (model.Stock_ID != null)
            {
                strSql1.Append("Stock_ID,");
                strSql2.Append("'" + model.Stock_ID + "',");
            }
            if (model.Plan_List_ID != null)
            {
                strSql1.Append("Plan_List_ID,");
                strSql2.Append("'" + model.Plan_List_ID + "',");
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
            if (model.Goods_ID != null)
            {
                strSql1.Append("Goods_ID,");
                strSql2.Append("'" + model.Goods_ID + "',");
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
            if (model.Goods_Code != null)
            {
                strSql1.Append("Goods_Code,");
                strSql2.Append("'" + model.Goods_Code + "',");
            }
            if (model.Goods_Class_ID != null)
            {
                strSql1.Append("Goods_Class_ID,");
                strSql2.Append("'" + model.Goods_Class_ID + "',");
            }
            if (model.Goods_Name != null)
            {
                strSql1.Append("Goods_Name,");
                strSql2.Append("'" + model.Goods_Name + "',");
            }
            if (model.Goods_Desc != null)
            {
                strSql1.Append("Goods_Desc,");
                strSql2.Append("'" + model.Goods_Desc + "',");
            }
            if (model.Goods_Model != null)
            {
                strSql1.Append("Goods_Model,");
                strSql2.Append("'" + model.Goods_Model + "',");
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
            if (model.Goods_Level != null)
            {
                strSql1.Append("Goods_Level,");
                strSql2.Append("'" + model.Goods_Level + "',");
            }
            if (model.Goods_Limit_Lower_Quantity != null)
            {
                strSql1.Append("Goods_Limit_Lower_Quantity,");
                strSql2.Append("'" + model.Goods_Limit_Lower_Quantity + "',");
            }
            if (model.Goods_Remark != null)
            {
                strSql1.Append("Goods_Remark,");
                strSql2.Append("'" + model.Goods_Remark + "',");
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
            if (model.Goods_Asset != null)
            {
                strSql1.Append("Goods_Asset,");
                strSql2.Append("'" + model.Goods_Asset + "',");
            }
            if (model.Goods_Department != null)
            {
                strSql1.Append("Goods_Department,");
                strSql2.Append("'" + model.Goods_Department + "',");
            }
            if (model.Goods_Reserve1 != null)
            {
                strSql1.Append("Goods_Reserve1,");
                strSql2.Append("'" + model.Goods_Reserve1 + "',");
            }
            if (model.Goods_Reserve2 != null)
            {
                strSql1.Append("Goods_Reserve2,");
                strSql2.Append("'" + model.Goods_Reserve2 + "',");
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
            if (model.WareHouse_ID != null)
            {
                strSql1.Append("WareHouse_ID,");
                strSql2.Append("'" + model.WareHouse_ID + "',");
            }
            if (model.Area_Type != null)
            {
                strSql1.Append("Area_Type,");
                strSql2.Append("'" + model.Area_Type + "',");
            }
            if (model.Area_Code != null)
            {
                strSql1.Append("Area_Code,");
                strSql2.Append("'" + model.Area_Code + "',");
            }
            if (model.Area_Name != null)
            {
                strSql1.Append("Area_Name,");
                strSql2.Append("'" + model.Area_Name + "',");
            }
            if (model.Area_Order != null)
            {
                strSql1.Append("Area_Order,");
                strSql2.Append("" + model.Area_Order + ",");
            }
            if (model.Area_Flag != null)
            {
                strSql1.Append("Area_Flag,");
                strSql2.Append("'" + model.Area_Flag + "',");
            }
            if (model.Area_BackColor != null)
            {
                strSql1.Append("Area_BackColor,");
                strSql2.Append("'" + model.Area_BackColor + "',");
            }
            if (model.Area_Remark != null)
            {
                strSql1.Append("Area_Remark,");
                strSql2.Append("'" + model.Area_Remark + "',");
            }
            if (model.Area_Reserve1 != null)
            {
                strSql1.Append("Area_Reserve1,");
                strSql2.Append("'" + model.Area_Reserve1 + "',");
            }
            if (model.WareHouse_Code != null)
            {
                strSql1.Append("WareHouse_Code,");
                strSql2.Append("'" + model.WareHouse_Code + "',");
            }
            if (model.WareHouse_Name != null)
            {
                strSql1.Append("WareHouse_Name,");
                strSql2.Append("'" + model.WareHouse_Name + "',");
            }
            if (model.WareHouse_Type != null)
            {
                strSql1.Append("WareHouse_Type,");
                strSql2.Append("'" + model.WareHouse_Type + "',");
            }
            if (model.WareHouse_Flag != null)
            {
                strSql1.Append("WareHouse_Flag,");
                strSql2.Append("'" + model.WareHouse_Flag + "',");
            }
            if (model.WareHouse_Remark != null)
            {
                strSql1.Append("WareHouse_Remark,");
                strSql2.Append("'" + model.WareHouse_Remark + "',");
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
            if (model.Plan_ID != null)
            {
                strSql1.Append("Plan_ID,");
                strSql2.Append("'" + model.Plan_ID + "',");
            }
            if (model.Plan_Remark != null)
            {
                strSql1.Append("Plan_Remark,");
                strSql2.Append("'" + model.Plan_Remark + "',");
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
            if (model.Goods_Shelf_Life != null)
            {
                strSql1.Append("Goods_Shelf_Life,");
                strSql2.Append("" + model.Goods_Shelf_Life + ",");
            }
            if (model.Goods_ProduceDate != null)
            {
                strSql1.Append("Goods_ProduceDate,");
                strSql2.Append("'" + model.Goods_ProduceDate + "',");
            }
            if (model.Goods_Order != null)
            {
                strSql1.Append("Goods_Order,");
                strSql2.Append("" + model.Goods_Order + ",");
            }
            if (model.Goods_Type != null)
            {
                strSql1.Append("Goods_Type,");
                strSql2.Append("'" + model.Goods_Type + "',");
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
            if (model.Cell_Child_Status != null)
            {
                strSql1.Append("Cell_Child_Status,");
                strSql2.Append("'" + model.Cell_Child_Status + "',");
            }
            if (model.Cell_Child_Model != null)
            {
                strSql1.Append("Cell_Child_Model,");
                strSql2.Append("'" + model.Cell_Child_Model + "',");
            }
            if (model.Cell_Child_Run_Status != null)
            {
                strSql1.Append("Cell_Child_Run_Status,");
                strSql2.Append("'" + model.Cell_Child_Run_Status + "',");
            }
            if (model.Cell_Child_Flag != null)
            {
                strSql1.Append("Cell_Child_Flag,");
                strSql2.Append("'" + model.Cell_Child_Flag + "',");
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
            if (model.Cell_Column != null)
            {
                strSql1.Append("Cell_Column,");
                strSql2.Append("" + model.Cell_Column + ",");
            }
            if (model.Cell_Row != null)
            {
                strSql1.Append("Cell_Row,");
                strSql2.Append("" + model.Cell_Row + ",");
            }
            if (model.Goods_Suppier_Code != null)
            {
                strSql1.Append("Goods_Suppier_Code,");
                strSql2.Append("'" + model.Goods_Suppier_Code + "',");
            }
            strSql.Append("insert into View_Plan_StockList(");
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
        public bool Update(WMS_Database.View_Plan_StockListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_Plan_StockList set ");
            if (model.Stock_List_ID != null)
            {
                strSql.Append("Stock_List_ID='" + model.Stock_List_ID + "',");
            }
            if (model.Stock_ID != null)
            {
                strSql.Append("Stock_ID='" + model.Stock_ID + "',");
            }
            else
            {
                strSql.Append("Stock_ID= null ,");
            }
            if (model.Plan_List_ID != null)
            {
                strSql.Append("Plan_List_ID='" + model.Plan_List_ID + "',");
            }
            else
            {
                strSql.Append("Plan_List_ID= null ,");
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
            if (model.Goods_ID != null)
            {
                strSql.Append("Goods_ID='" + model.Goods_ID + "',");
            }
            else
            {
                strSql.Append("Goods_ID= null ,");
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
            if (model.Goods_Code != null)
            {
                strSql.Append("Goods_Code='" + model.Goods_Code + "',");
            }
            else
            {
                strSql.Append("Goods_Code= null ,");
            }
            if (model.Goods_Class_ID != null)
            {
                strSql.Append("Goods_Class_ID='" + model.Goods_Class_ID + "',");
            }
            if (model.Goods_Name != null)
            {
                strSql.Append("Goods_Name='" + model.Goods_Name + "',");
            }
            else
            {
                strSql.Append("Goods_Name= null ,");
            }
            if (model.Goods_Desc != null)
            {
                strSql.Append("Goods_Desc='" + model.Goods_Desc + "',");
            }
            else
            {
                strSql.Append("Goods_Desc= null ,");
            }
            if (model.Goods_Model != null)
            {
                strSql.Append("Goods_Model='" + model.Goods_Model + "',");
            }
            else
            {
                strSql.Append("Goods_Model= null ,");
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
            if (model.Goods_Level != null)
            {
                strSql.Append("Goods_Level='" + model.Goods_Level + "',");
            }
            else
            {
                strSql.Append("Goods_Level= null ,");
            }
            if (model.Goods_Limit_Lower_Quantity != null)
            {
                strSql.Append("Goods_Limit_Lower_Quantity='" + model.Goods_Limit_Lower_Quantity + "',");
            }
            else
            {
                strSql.Append("Goods_Limit_Lower_Quantity= null ,");
            }
            if (model.Goods_Remark != null)
            {
                strSql.Append("Goods_Remark='" + model.Goods_Remark + "',");
            }
            else
            {
                strSql.Append("Goods_Remark= null ,");
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
            if (model.Goods_Asset != null)
            {
                strSql.Append("Goods_Asset='" + model.Goods_Asset + "',");
            }
            else
            {
                strSql.Append("Goods_Asset= null ,");
            }
            if (model.Goods_Department != null)
            {
                strSql.Append("Goods_Department='" + model.Goods_Department + "',");
            }
            else
            {
                strSql.Append("Goods_Department= null ,");
            }
            if (model.Goods_Reserve1 != null)
            {
                strSql.Append("Goods_Reserve1='" + model.Goods_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Goods_Reserve1= null ,");
            }
            if (model.Goods_Reserve2 != null)
            {
                strSql.Append("Goods_Reserve2='" + model.Goods_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Goods_Reserve2= null ,");
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
            if (model.WareHouse_ID != null)
            {
                strSql.Append("WareHouse_ID='" + model.WareHouse_ID + "',");
            }
            else
            {
                strSql.Append("WareHouse_ID= null ,");
            }
            if (model.Area_Type != null)
            {
                strSql.Append("Area_Type='" + model.Area_Type + "',");
            }
            else
            {
                strSql.Append("Area_Type= null ,");
            }
            if (model.Area_Code != null)
            {
                strSql.Append("Area_Code='" + model.Area_Code + "',");
            }
            else
            {
                strSql.Append("Area_Code= null ,");
            }
            if (model.Area_Name != null)
            {
                strSql.Append("Area_Name='" + model.Area_Name + "',");
            }
            else
            {
                strSql.Append("Area_Name= null ,");
            }
            if (model.Area_Order != null)
            {
                strSql.Append("Area_Order=" + model.Area_Order + ",");
            }
            else
            {
                strSql.Append("Area_Order= null ,");
            }
            if (model.Area_Flag != null)
            {
                strSql.Append("Area_Flag='" + model.Area_Flag + "',");
            }
            else
            {
                strSql.Append("Area_Flag= null ,");
            }
            if (model.Area_BackColor != null)
            {
                strSql.Append("Area_BackColor='" + model.Area_BackColor + "',");
            }
            else
            {
                strSql.Append("Area_BackColor= null ,");
            }
            if (model.Area_Remark != null)
            {
                strSql.Append("Area_Remark='" + model.Area_Remark + "',");
            }
            else
            {
                strSql.Append("Area_Remark= null ,");
            }
            if (model.Area_Reserve1 != null)
            {
                strSql.Append("Area_Reserve1='" + model.Area_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Area_Reserve1= null ,");
            }
            if (model.WareHouse_Code != null)
            {
                strSql.Append("WareHouse_Code='" + model.WareHouse_Code + "',");
            }
            else
            {
                strSql.Append("WareHouse_Code= null ,");
            }
            if (model.WareHouse_Name != null)
            {
                strSql.Append("WareHouse_Name='" + model.WareHouse_Name + "',");
            }
            else
            {
                strSql.Append("WareHouse_Name= null ,");
            }
            if (model.WareHouse_Type != null)
            {
                strSql.Append("WareHouse_Type='" + model.WareHouse_Type + "',");
            }
            else
            {
                strSql.Append("WareHouse_Type= null ,");
            }
            if (model.WareHouse_Flag != null)
            {
                strSql.Append("WareHouse_Flag='" + model.WareHouse_Flag + "',");
            }
            else
            {
                strSql.Append("WareHouse_Flag= null ,");
            }
            if (model.WareHouse_Remark != null)
            {
                strSql.Append("WareHouse_Remark='" + model.WareHouse_Remark + "',");
            }
            else
            {
                strSql.Append("WareHouse_Remark= null ,");
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
            if (model.Plan_ID != null)
            {
                strSql.Append("Plan_ID='" + model.Plan_ID + "',");
            }
            else
            {
                strSql.Append("Plan_ID= null ,");
            }
            if (model.Plan_Remark != null)
            {
                strSql.Append("Plan_Remark='" + model.Plan_Remark + "',");
            }
            else
            {
                strSql.Append("Plan_Remark= null ,");
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
            if (model.Goods_Shelf_Life != null)
            {
                strSql.Append("Goods_Shelf_Life=" + model.Goods_Shelf_Life + ",");
            }
            else
            {
                strSql.Append("Goods_Shelf_Life= null ,");
            }
            if (model.Goods_ProduceDate != null)
            {
                strSql.Append("Goods_ProduceDate='" + model.Goods_ProduceDate + "',");
            }
            else
            {
                strSql.Append("Goods_ProduceDate= null ,");
            }
            if (model.Goods_Order != null)
            {
                strSql.Append("Goods_Order=" + model.Goods_Order + ",");
            }
            else
            {
                strSql.Append("Goods_Order= null ,");
            }
            if (model.Goods_Type != null)
            {
                strSql.Append("Goods_Type='" + model.Goods_Type + "',");
            }
            else
            {
                strSql.Append("Goods_Type= null ,");
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
            if (model.Cell_Child_Status != null)
            {
                strSql.Append("Cell_Child_Status='" + model.Cell_Child_Status + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Status= null ,");
            }
            if (model.Cell_Child_Model != null)
            {
                strSql.Append("Cell_Child_Model='" + model.Cell_Child_Model + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Model= null ,");
            }
            if (model.Cell_Child_Run_Status != null)
            {
                strSql.Append("Cell_Child_Run_Status='" + model.Cell_Child_Run_Status + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Run_Status= null ,");
            }
            if (model.Cell_Child_Flag != null)
            {
                strSql.Append("Cell_Child_Flag='" + model.Cell_Child_Flag + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Flag= null ,");
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
            if (model.Cell_Column != null)
            {
                strSql.Append("Cell_Column=" + model.Cell_Column + ",");
            }
            else
            {
                strSql.Append("Cell_Column= null ,");
            }
            if (model.Cell_Row != null)
            {
                strSql.Append("Cell_Row=" + model.Cell_Row + ",");
            }
            else
            {
                strSql.Append("Cell_Row= null ,");
            }
            if (model.Goods_Suppier_Code != null)
            {
                strSql.Append("Goods_Suppier_Code='" + model.Goods_Suppier_Code + "',");
            }
            else
            {
                strSql.Append("Goods_Suppier_Code= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Stock_List_ID='" + model.Stock_List_ID + "' and Stock_ID='" + model.Stock_ID + "' and Plan_List_ID='" + model.Plan_List_ID + "' and Stock_List_Box_Barcode='" + model.Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + model.Stock_List_Quantity + "' and Goods_ID='" + model.Goods_ID + "' and Stock_List_Entry_Time='" + model.Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + model.Stock_List_Update_Time + "' and Stock_List_Remark='" + model.Stock_List_Remark + "' and Goods_Code='" + model.Goods_Code + "' and Goods_Class_ID='" + model.Goods_Class_ID + "' and Goods_Name='" + model.Goods_Name + "' and Goods_Desc='" + model.Goods_Desc + "' and Goods_Model='" + model.Goods_Model + "' and Goods_Unit='" + model.Goods_Unit + "' and Goods_Limit_Upper_Quantity='" + model.Goods_Limit_Upper_Quantity + "' and Goods_Level='" + model.Goods_Level + "' and Goods_Limit_Lower_Quantity='" + model.Goods_Limit_Lower_Quantity + "' and Goods_Remark='" + model.Goods_Remark + "' and Goods_Flag='" + model.Goods_Flag + "' and Goods_Danger='" + model.Goods_Danger + "' and Goods_Category='" + model.Goods_Category + "' and Goods_Asset='" + model.Goods_Asset + "' and Goods_Department='" + model.Goods_Department + "' and Goods_Reserve1='" + model.Goods_Reserve1 + "' and Goods_Reserve2='" + model.Goods_Reserve2 + "' and Stock_Tray_Barcode='" + model.Stock_Tray_Barcode + "' and Stock_Full_Flag='" + model.Stock_Full_Flag + "' and WareHouse_ID='" + model.WareHouse_ID + "' and Area_Type='" + model.Area_Type + "' and Area_Code='" + model.Area_Code + "' and Area_Name='" + model.Area_Name + "' and Area_Order=" + model.Area_Order + " and Area_Flag='" + model.Area_Flag + "' and Area_BackColor='" + model.Area_BackColor + "' and Area_Remark='" + model.Area_Remark + "' and Area_Reserve1='" + model.Area_Reserve1 + "' and WareHouse_Code='" + model.WareHouse_Code + "' and WareHouse_Name='" + model.WareHouse_Name + "' and WareHouse_Type='" + model.WareHouse_Type + "' and WareHouse_Flag='" + model.WareHouse_Flag + "' and WareHouse_Remark='" + model.WareHouse_Remark + "' and Plan_Type_ID='" + model.Plan_Type_ID + "' and Plan_Serial_Num='" + model.Plan_Serial_Num + "' and Plan_Code='" + model.Plan_Code + "' and Plan_Create_Time='" + model.Plan_Create_Time + "' and Plan_End_Time='" + model.Plan_End_Time + "' and Plan_Begin_Time='" + model.Plan_Begin_Time + "' and Plan_Bill_Time='" + model.Plan_Bill_Time + "' and Plan_Status='" + model.Plan_Status + "' and Plan_Operater='" + model.Plan_Operater + "' and Plan_From_Dept='" + model.Plan_From_Dept + "' and Plan_To_Dept='" + model.Plan_To_Dept + "' and Plan_From_User='" + model.Plan_From_User + "' and Plan_To_User='" + model.Plan_To_User + "' and Plan_Import_Flag='" + model.Plan_Import_Flag + "' and Plan_List_Quantity=" + model.Plan_List_Quantity + " and Plan_List_Ordered_Quantity=" + model.Plan_List_Ordered_Quantity + " and Plan_ID='" + model.Plan_ID + "' and Plan_Remark='" + model.Plan_Remark + "' and Plan_List_Finished_Quantity=" + model.Plan_List_Finished_Quantity + " and Plan_List_Status='" + model.Plan_List_Status + "' and Plan_List_Remark='" + model.Plan_List_Remark + "' and Goods_Shelf_Life=" + model.Goods_Shelf_Life + " and Goods_ProduceDate='" + model.Goods_ProduceDate + "' and Goods_Order=" + model.Goods_Order + " and Goods_Type='" + model.Goods_Type + "' and Area_ID='" + model.Area_ID + "' and Cell_Code='" + model.Cell_Code + "' and Cell_Chlid_ID='" + model.Cell_Chlid_ID + "' and Cell_Chlid_Position='" + model.Cell_Chlid_Position + "' and Cell_Child_Order=" + model.Cell_Child_Order + " and Cell_Child_InOut='" + model.Cell_Child_InOut + "' and Cell_Child_Status='" + model.Cell_Child_Status + "' and Cell_Child_Model='" + model.Cell_Child_Model + "' and Cell_Child_Run_Status='" + model.Cell_Child_Run_Status + "' and Cell_Child_Flag='" + model.Cell_Child_Flag + "' and Cell_Child_Operate_Type='" + model.Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + model.Cell_Child_TaskLock_ID + "' and Cell_Name='" + model.Cell_Name + "' and Cell_Lane='" + model.Cell_Lane + "' and Device_Code='" + model.Device_Code + "' and Shelf_Type='" + model.Shelf_Type + "' and Cell_InOut='" + model.Cell_InOut + "' and Cell_Type='" + model.Cell_Type + "' and Cell_Storage_Type='" + model.Cell_Storage_Type + "' and Cell_Fork_Type='" + model.Cell_Fork_Type + "' and Cell_Layer=" + model.Cell_Layer + " and Cell_Column=" + model.Cell_Column + " and Cell_Row=" + model.Cell_Row + " and Goods_Suppier_Code='" + model.Goods_Suppier_Code + "' ");
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
        public bool Delete(string Stock_List_ID, string Stock_ID, string Plan_List_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, string Goods_ID, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Code, string Goods_Class_ID, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Level, string Goods_Limit_Lower_Quantity, string Goods_Remark, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Stock_Tray_Barcode, string Stock_Full_Flag, string WareHouse_ID, string Area_Type, string Area_Code, string Area_Name, int Area_Order, string Area_Flag, string Area_BackColor, string Area_Remark, string Area_Reserve1, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag, string WareHouse_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, string Plan_ID, string Plan_Remark, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, int Goods_Shelf_Life, DateTime Goods_ProduceDate, int Goods_Order, string Goods_Type, string Area_ID, string Cell_Code, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Status, string Cell_Child_Model, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Goods_Suppier_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_Plan_StockList ");
            strSql.Append(" where Stock_List_ID='" + Stock_List_ID + "' and Stock_ID='" + Stock_ID + "' and Plan_List_ID='" + Plan_List_ID + "' and Stock_List_Box_Barcode='" + Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + Stock_List_Quantity + "' and Goods_ID='" + Goods_ID + "' and Stock_List_Entry_Time='" + Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + Stock_List_Update_Time + "' and Stock_List_Remark='" + Stock_List_Remark + "' and Goods_Code='" + Goods_Code + "' and Goods_Class_ID='" + Goods_Class_ID + "' and Goods_Name='" + Goods_Name + "' and Goods_Desc='" + Goods_Desc + "' and Goods_Model='" + Goods_Model + "' and Goods_Unit='" + Goods_Unit + "' and Goods_Limit_Upper_Quantity='" + Goods_Limit_Upper_Quantity + "' and Goods_Level='" + Goods_Level + "' and Goods_Limit_Lower_Quantity='" + Goods_Limit_Lower_Quantity + "' and Goods_Remark='" + Goods_Remark + "' and Goods_Flag='" + Goods_Flag + "' and Goods_Danger='" + Goods_Danger + "' and Goods_Category='" + Goods_Category + "' and Goods_Asset='" + Goods_Asset + "' and Goods_Department='" + Goods_Department + "' and Goods_Reserve1='" + Goods_Reserve1 + "' and Goods_Reserve2='" + Goods_Reserve2 + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Stock_Full_Flag='" + Stock_Full_Flag + "' and WareHouse_ID='" + WareHouse_ID + "' and Area_Type='" + Area_Type + "' and Area_Code='" + Area_Code + "' and Area_Name='" + Area_Name + "' and Area_Order=" + Area_Order + " and Area_Flag='" + Area_Flag + "' and Area_BackColor='" + Area_BackColor + "' and Area_Remark='" + Area_Remark + "' and Area_Reserve1='" + Area_Reserve1 + "' and WareHouse_Code='" + WareHouse_Code + "' and WareHouse_Name='" + WareHouse_Name + "' and WareHouse_Type='" + WareHouse_Type + "' and WareHouse_Flag='" + WareHouse_Flag + "' and WareHouse_Remark='" + WareHouse_Remark + "' and Plan_Type_ID='" + Plan_Type_ID + "' and Plan_Serial_Num='" + Plan_Serial_Num + "' and Plan_Code='" + Plan_Code + "' and Plan_Create_Time='" + Plan_Create_Time + "' and Plan_End_Time='" + Plan_End_Time + "' and Plan_Begin_Time='" + Plan_Begin_Time + "' and Plan_Bill_Time='" + Plan_Bill_Time + "' and Plan_Status='" + Plan_Status + "' and Plan_Operater='" + Plan_Operater + "' and Plan_From_Dept='" + Plan_From_Dept + "' and Plan_To_Dept='" + Plan_To_Dept + "' and Plan_From_User='" + Plan_From_User + "' and Plan_To_User='" + Plan_To_User + "' and Plan_Import_Flag='" + Plan_Import_Flag + "' and Plan_List_Quantity=" + Plan_List_Quantity + " and Plan_List_Ordered_Quantity=" + Plan_List_Ordered_Quantity + " and Plan_ID='" + Plan_ID + "' and Plan_Remark='" + Plan_Remark + "' and Plan_List_Finished_Quantity=" + Plan_List_Finished_Quantity + " and Plan_List_Status='" + Plan_List_Status + "' and Plan_List_Remark='" + Plan_List_Remark + "' and Goods_Shelf_Life=" + Goods_Shelf_Life + " and Goods_ProduceDate='" + Goods_ProduceDate + "' and Goods_Order=" + Goods_Order + " and Goods_Type='" + Goods_Type + "' and Area_ID='" + Area_ID + "' and Cell_Code='" + Cell_Code + "' and Cell_Chlid_ID='" + Cell_Chlid_ID + "' and Cell_Chlid_Position='" + Cell_Chlid_Position + "' and Cell_Child_Order=" + Cell_Child_Order + " and Cell_Child_InOut='" + Cell_Child_InOut + "' and Cell_Child_Status='" + Cell_Child_Status + "' and Cell_Child_Model='" + Cell_Child_Model + "' and Cell_Child_Run_Status='" + Cell_Child_Run_Status + "' and Cell_Child_Flag='" + Cell_Child_Flag + "' and Cell_Child_Operate_Type='" + Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + Cell_Child_TaskLock_ID + "' and Cell_Name='" + Cell_Name + "' and Cell_Lane='" + Cell_Lane + "' and Device_Code='" + Device_Code + "' and Shelf_Type='" + Shelf_Type + "' and Cell_InOut='" + Cell_InOut + "' and Cell_Type='" + Cell_Type + "' and Cell_Storage_Type='" + Cell_Storage_Type + "' and Cell_Fork_Type='" + Cell_Fork_Type + "' and Cell_Layer=" + Cell_Layer + " and Cell_Column=" + Cell_Column + " and Cell_Row=" + Cell_Row + " and Goods_Suppier_Code='" + Goods_Suppier_Code + "' ");
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
        public WMS_Database.View_Plan_StockListModel GetModel(string Stock_List_ID, string Stock_ID, string Plan_List_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, string Goods_ID, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Goods_Code, string Goods_Class_ID, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Level, string Goods_Limit_Lower_Quantity, string Goods_Remark, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Stock_Tray_Barcode, string Stock_Full_Flag, string WareHouse_ID, string Area_Type, string Area_Code, string Area_Name, int Area_Order, string Area_Flag, string Area_BackColor, string Area_Remark, string Area_Reserve1, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag, string WareHouse_Remark, string Plan_Type_ID, string Plan_Serial_Num, string Plan_Code, DateTime Plan_Create_Time, DateTime Plan_End_Time, DateTime Plan_Begin_Time, DateTime Plan_Bill_Time, string Plan_Status, string Plan_Operater, string Plan_From_Dept, string Plan_To_Dept, string Plan_From_User, string Plan_To_User, string Plan_Import_Flag, int Plan_List_Quantity, int Plan_List_Ordered_Quantity, string Plan_ID, string Plan_Remark, int Plan_List_Finished_Quantity, string Plan_List_Status, string Plan_List_Remark, int Goods_Shelf_Life, DateTime Goods_ProduceDate, int Goods_Order, string Goods_Type, string Area_ID, string Cell_Code, string Cell_Chlid_ID, string Cell_Chlid_Position, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Status, string Cell_Child_Model, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Goods_Suppier_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Stock_List_ID,Stock_ID,Plan_List_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Goods_ID,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Goods_Code,Goods_Class_ID,Goods_Name,Goods_Desc,Goods_Model,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Level,Goods_Limit_Lower_Quantity,Goods_Remark,Goods_Flag,Goods_Danger,Goods_Category,Goods_Asset,Goods_Department,Goods_Reserve1,Goods_Reserve2,Stock_Tray_Barcode,Stock_Full_Flag,WareHouse_ID,Area_Type,Area_Code,Area_Name,Area_Order,Area_Flag,Area_BackColor,Area_Remark,Area_Reserve1,WareHouse_Code,WareHouse_Name,WareHouse_Type,WareHouse_Flag,WareHouse_Remark,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_End_Time,Plan_Begin_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_ID,Plan_Remark,Plan_List_Finished_Quantity,Plan_List_Status,Plan_List_Remark,Goods_Shelf_Life,Goods_ProduceDate,Goods_Order,Goods_Type,Area_ID,Cell_Code,Cell_Chlid_ID,Cell_Chlid_Position,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Status,Cell_Child_Model,Cell_Child_Run_Status,Cell_Child_Flag,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Goods_Suppier_Code ");
            strSql.Append(" from View_Plan_StockList ");
            strSql.Append(" where Stock_List_ID='" + Stock_List_ID + "' and Stock_ID='" + Stock_ID + "' and Plan_List_ID='" + Plan_List_ID + "' and Stock_List_Box_Barcode='" + Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + Stock_List_Quantity + "' and Goods_ID='" + Goods_ID + "' and Stock_List_Entry_Time='" + Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + Stock_List_Update_Time + "' and Stock_List_Remark='" + Stock_List_Remark + "' and Goods_Code='" + Goods_Code + "' and Goods_Class_ID='" + Goods_Class_ID + "' and Goods_Name='" + Goods_Name + "' and Goods_Desc='" + Goods_Desc + "' and Goods_Model='" + Goods_Model + "' and Goods_Unit='" + Goods_Unit + "' and Goods_Limit_Upper_Quantity='" + Goods_Limit_Upper_Quantity + "' and Goods_Level='" + Goods_Level + "' and Goods_Limit_Lower_Quantity='" + Goods_Limit_Lower_Quantity + "' and Goods_Remark='" + Goods_Remark + "' and Goods_Flag='" + Goods_Flag + "' and Goods_Danger='" + Goods_Danger + "' and Goods_Category='" + Goods_Category + "' and Goods_Asset='" + Goods_Asset + "' and Goods_Department='" + Goods_Department + "' and Goods_Reserve1='" + Goods_Reserve1 + "' and Goods_Reserve2='" + Goods_Reserve2 + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Stock_Full_Flag='" + Stock_Full_Flag + "' and WareHouse_ID='" + WareHouse_ID + "' and Area_Type='" + Area_Type + "' and Area_Code='" + Area_Code + "' and Area_Name='" + Area_Name + "' and Area_Order=" + Area_Order + " and Area_Flag='" + Area_Flag + "' and Area_BackColor='" + Area_BackColor + "' and Area_Remark='" + Area_Remark + "' and Area_Reserve1='" + Area_Reserve1 + "' and WareHouse_Code='" + WareHouse_Code + "' and WareHouse_Name='" + WareHouse_Name + "' and WareHouse_Type='" + WareHouse_Type + "' and WareHouse_Flag='" + WareHouse_Flag + "' and WareHouse_Remark='" + WareHouse_Remark + "' and Plan_Type_ID='" + Plan_Type_ID + "' and Plan_Serial_Num='" + Plan_Serial_Num + "' and Plan_Code='" + Plan_Code + "' and Plan_Create_Time='" + Plan_Create_Time + "' and Plan_End_Time='" + Plan_End_Time + "' and Plan_Begin_Time='" + Plan_Begin_Time + "' and Plan_Bill_Time='" + Plan_Bill_Time + "' and Plan_Status='" + Plan_Status + "' and Plan_Operater='" + Plan_Operater + "' and Plan_From_Dept='" + Plan_From_Dept + "' and Plan_To_Dept='" + Plan_To_Dept + "' and Plan_From_User='" + Plan_From_User + "' and Plan_To_User='" + Plan_To_User + "' and Plan_Import_Flag='" + Plan_Import_Flag + "' and Plan_List_Quantity=" + Plan_List_Quantity + " and Plan_List_Ordered_Quantity=" + Plan_List_Ordered_Quantity + " and Plan_ID='" + Plan_ID + "' and Plan_Remark='" + Plan_Remark + "' and Plan_List_Finished_Quantity=" + Plan_List_Finished_Quantity + " and Plan_List_Status='" + Plan_List_Status + "' and Plan_List_Remark='" + Plan_List_Remark + "' and Goods_Shelf_Life=" + Goods_Shelf_Life + " and Goods_ProduceDate='" + Goods_ProduceDate + "' and Goods_Order=" + Goods_Order + " and Goods_Type='" + Goods_Type + "' and Area_ID='" + Area_ID + "' and Cell_Code='" + Cell_Code + "' and Cell_Chlid_ID='" + Cell_Chlid_ID + "' and Cell_Chlid_Position='" + Cell_Chlid_Position + "' and Cell_Child_Order=" + Cell_Child_Order + " and Cell_Child_InOut='" + Cell_Child_InOut + "' and Cell_Child_Status='" + Cell_Child_Status + "' and Cell_Child_Model='" + Cell_Child_Model + "' and Cell_Child_Run_Status='" + Cell_Child_Run_Status + "' and Cell_Child_Flag='" + Cell_Child_Flag + "' and Cell_Child_Operate_Type='" + Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + Cell_Child_TaskLock_ID + "' and Cell_Name='" + Cell_Name + "' and Cell_Lane='" + Cell_Lane + "' and Device_Code='" + Device_Code + "' and Shelf_Type='" + Shelf_Type + "' and Cell_InOut='" + Cell_InOut + "' and Cell_Type='" + Cell_Type + "' and Cell_Storage_Type='" + Cell_Storage_Type + "' and Cell_Fork_Type='" + Cell_Fork_Type + "' and Cell_Layer=" + Cell_Layer + " and Cell_Column=" + Cell_Column + " and Cell_Row=" + Cell_Row + " and Goods_Suppier_Code='" + Goods_Suppier_Code + "' ");
            WMS_Database.View_Plan_StockListModel model = new WMS_Database.View_Plan_StockListModel();
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
        public WMS_Database.View_Plan_StockListModel DataRowToModel(DataRow row)
        {
            WMS_Database.View_Plan_StockListModel model = new WMS_Database.View_Plan_StockListModel();
            if (row != null)
            {
                if (row["Stock_List_ID"] != null)
                {
                    model.Stock_List_ID = row["Stock_List_ID"].ToString();
                }
                if (row["Stock_ID"] != null)
                {
                    model.Stock_ID = row["Stock_ID"].ToString();
                }
                if (row["Plan_List_ID"] != null)
                {
                    model.Plan_List_ID = row["Plan_List_ID"].ToString();
                }
                if (row["Stock_List_Box_Barcode"] != null)
                {
                    model.Stock_List_Box_Barcode = row["Stock_List_Box_Barcode"].ToString();
                }
                if (row["Stock_List_Quantity"] != null)
                {
                    model.Stock_List_Quantity = row["Stock_List_Quantity"].ToString();
                }
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
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
                if (row["Goods_Code"] != null)
                {
                    model.Goods_Code = row["Goods_Code"].ToString();
                }
                if (row["Goods_Class_ID"] != null)
                {
                    model.Goods_Class_ID = row["Goods_Class_ID"].ToString();
                }
                if (row["Goods_Name"] != null)
                {
                    model.Goods_Name = row["Goods_Name"].ToString();
                }
                if (row["Goods_Desc"] != null)
                {
                    model.Goods_Desc = row["Goods_Desc"].ToString();
                }
                if (row["Goods_Model"] != null)
                {
                    model.Goods_Model = row["Goods_Model"].ToString();
                }
                if (row["Goods_Unit"] != null)
                {
                    model.Goods_Unit = row["Goods_Unit"].ToString();
                }
                if (row["Goods_Limit_Upper_Quantity"] != null)
                {
                    model.Goods_Limit_Upper_Quantity = row["Goods_Limit_Upper_Quantity"].ToString();
                }
                if (row["Goods_Level"] != null)
                {
                    model.Goods_Level = row["Goods_Level"].ToString();
                }
                if (row["Goods_Limit_Lower_Quantity"] != null)
                {
                    model.Goods_Limit_Lower_Quantity = row["Goods_Limit_Lower_Quantity"].ToString();
                }
                if (row["Goods_Remark"] != null)
                {
                    model.Goods_Remark = row["Goods_Remark"].ToString();
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
                if (row["Goods_Asset"] != null)
                {
                    model.Goods_Asset = row["Goods_Asset"].ToString();
                }
                if (row["Goods_Department"] != null)
                {
                    model.Goods_Department = row["Goods_Department"].ToString();
                }
                if (row["Goods_Reserve1"] != null)
                {
                    model.Goods_Reserve1 = row["Goods_Reserve1"].ToString();
                }
                if (row["Goods_Reserve2"] != null)
                {
                    model.Goods_Reserve2 = row["Goods_Reserve2"].ToString();
                }
                if (row["Stock_Tray_Barcode"] != null)
                {
                    model.Stock_Tray_Barcode = row["Stock_Tray_Barcode"].ToString();
                }
                if (row["Stock_Full_Flag"] != null)
                {
                    model.Stock_Full_Flag = row["Stock_Full_Flag"].ToString();
                }
                if (row["WareHouse_ID"] != null)
                {
                    model.WareHouse_ID = row["WareHouse_ID"].ToString();
                }
                if (row["Area_Type"] != null)
                {
                    model.Area_Type = row["Area_Type"].ToString();
                }
                if (row["Area_Code"] != null)
                {
                    model.Area_Code = row["Area_Code"].ToString();
                }
                if (row["Area_Name"] != null)
                {
                    model.Area_Name = row["Area_Name"].ToString();
                }
                if (row["Area_Order"] != null && row["Area_Order"].ToString() != "")
                {
                    model.Area_Order = int.Parse(row["Area_Order"].ToString());
                }
                if (row["Area_Flag"] != null)
                {
                    model.Area_Flag = row["Area_Flag"].ToString();
                }
                if (row["Area_BackColor"] != null)
                {
                    model.Area_BackColor = row["Area_BackColor"].ToString();
                }
                if (row["Area_Remark"] != null)
                {
                    model.Area_Remark = row["Area_Remark"].ToString();
                }
                if (row["Area_Reserve1"] != null)
                {
                    model.Area_Reserve1 = row["Area_Reserve1"].ToString();
                }
                if (row["WareHouse_Code"] != null)
                {
                    model.WareHouse_Code = row["WareHouse_Code"].ToString();
                }
                if (row["WareHouse_Name"] != null)
                {
                    model.WareHouse_Name = row["WareHouse_Name"].ToString();
                }
                if (row["WareHouse_Type"] != null)
                {
                    model.WareHouse_Type = row["WareHouse_Type"].ToString();
                }
                if (row["WareHouse_Flag"] != null)
                {
                    model.WareHouse_Flag = row["WareHouse_Flag"].ToString();
                }
                if (row["WareHouse_Remark"] != null)
                {
                    model.WareHouse_Remark = row["WareHouse_Remark"].ToString();
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
                if (row["Plan_List_Quantity"] != null && row["Plan_List_Quantity"].ToString() != "")
                {
                    model.Plan_List_Quantity = int.Parse(row["Plan_List_Quantity"].ToString());
                }
                if (row["Plan_List_Ordered_Quantity"] != null && row["Plan_List_Ordered_Quantity"].ToString() != "")
                {
                    model.Plan_List_Ordered_Quantity = int.Parse(row["Plan_List_Ordered_Quantity"].ToString());
                }
                if (row["Plan_ID"] != null)
                {
                    model.Plan_ID = row["Plan_ID"].ToString();
                }
                if (row["Plan_Remark"] != null)
                {
                    model.Plan_Remark = row["Plan_Remark"].ToString();
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
                if (row["Goods_Shelf_Life"] != null && row["Goods_Shelf_Life"].ToString() != "")
                {
                    model.Goods_Shelf_Life = int.Parse(row["Goods_Shelf_Life"].ToString());
                }
                if (row["Goods_ProduceDate"] != null && row["Goods_ProduceDate"].ToString() != "")
                {
                    model.Goods_ProduceDate = DateTime.Parse(row["Goods_ProduceDate"].ToString());
                }
                if (row["Goods_Order"] != null && row["Goods_Order"].ToString() != "")
                {
                    model.Goods_Order = int.Parse(row["Goods_Order"].ToString());
                }
                if (row["Goods_Type"] != null)
                {
                    model.Goods_Type = row["Goods_Type"].ToString();
                }
                if (row["Area_ID"] != null)
                {
                    model.Area_ID = row["Area_ID"].ToString();
                }
                if (row["Cell_Code"] != null)
                {
                    model.Cell_Code = row["Cell_Code"].ToString();
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
                if (row["Cell_Child_Status"] != null)
                {
                    model.Cell_Child_Status = row["Cell_Child_Status"].ToString();
                }
                if (row["Cell_Child_Model"] != null)
                {
                    model.Cell_Child_Model = row["Cell_Child_Model"].ToString();
                }
                if (row["Cell_Child_Run_Status"] != null)
                {
                    model.Cell_Child_Run_Status = row["Cell_Child_Run_Status"].ToString();
                }
                if (row["Cell_Child_Flag"] != null)
                {
                    model.Cell_Child_Flag = row["Cell_Child_Flag"].ToString();
                }
                if (row["Cell_Child_Operate_Type"] != null)
                {
                    model.Cell_Child_Operate_Type = row["Cell_Child_Operate_Type"].ToString();
                }
                if (row["Cell_Child_TaskLock_ID"] != null)
                {
                    model.Cell_Child_TaskLock_ID = row["Cell_Child_TaskLock_ID"].ToString();
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
                if (row["Cell_Column"] != null && row["Cell_Column"].ToString() != "")
                {
                    model.Cell_Column = int.Parse(row["Cell_Column"].ToString());
                }
                if (row["Cell_Row"] != null && row["Cell_Row"].ToString() != "")
                {
                    model.Cell_Row = int.Parse(row["Cell_Row"].ToString());
                }
                if (row["Goods_Suppier_Code"] != null)
                {
                    model.Goods_Suppier_Code = row["Goods_Suppier_Code"].ToString();
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
            strSql.Append("select Stock_List_ID,Stock_ID,Plan_List_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Goods_ID,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Goods_Code,Goods_Class_ID,Goods_Name,Goods_Desc,Goods_Model,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Level,Goods_Limit_Lower_Quantity,Goods_Remark,Goods_Flag,Goods_Danger,Goods_Category,Goods_Asset,Goods_Department,Goods_Reserve1,Goods_Reserve2,Stock_Tray_Barcode,Stock_Full_Flag,WareHouse_ID,Area_Type,Area_Code,Area_Name,Area_Order,Area_Flag,Area_BackColor,Area_Remark,Area_Reserve1,WareHouse_Code,WareHouse_Name,WareHouse_Type,WareHouse_Flag,WareHouse_Remark,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_End_Time,Plan_Begin_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_ID,Plan_Remark,Plan_List_Finished_Quantity,Plan_List_Status,Plan_List_Remark,Goods_Shelf_Life,Goods_ProduceDate,Goods_Order,Goods_Type,Area_ID,Cell_Code,Cell_Chlid_ID,Cell_Chlid_Position,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Status,Cell_Child_Model,Cell_Child_Run_Status,Cell_Child_Flag,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Goods_Suppier_Code ");
            strSql.Append(" FROM View_Plan_StockList ");
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
            strSql.Append(" Stock_List_ID,Stock_ID,Plan_List_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Goods_ID,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Goods_Code,Goods_Class_ID,Goods_Name,Goods_Desc,Goods_Model,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Level,Goods_Limit_Lower_Quantity,Goods_Remark,Goods_Flag,Goods_Danger,Goods_Category,Goods_Asset,Goods_Department,Goods_Reserve1,Goods_Reserve2,Stock_Tray_Barcode,Stock_Full_Flag,WareHouse_ID,Area_Type,Area_Code,Area_Name,Area_Order,Area_Flag,Area_BackColor,Area_Remark,Area_Reserve1,WareHouse_Code,WareHouse_Name,WareHouse_Type,WareHouse_Flag,WareHouse_Remark,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_End_Time,Plan_Begin_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_List_Quantity,Plan_List_Ordered_Quantity,Plan_ID,Plan_Remark,Plan_List_Finished_Quantity,Plan_List_Status,Plan_List_Remark,Goods_Shelf_Life,Goods_ProduceDate,Goods_Order,Goods_Type,Area_ID,Cell_Code,Cell_Chlid_ID,Cell_Chlid_Position,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Status,Cell_Child_Model,Cell_Child_Run_Status,Cell_Child_Flag,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Goods_Suppier_Code ");
            strSql.Append(" FROM View_Plan_StockList ");
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
            strSql.Append("select count(1) FROM View_Plan_StockList ");
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
                strSql.Append("order by T.Goods_Suppier_Code desc");
            }
            strSql.Append(")AS Row, T.*  from View_Plan_StockList T ");
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

