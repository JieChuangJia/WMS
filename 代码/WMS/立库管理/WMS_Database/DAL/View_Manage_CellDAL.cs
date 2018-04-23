using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:View_Manage_Cell
    /// </summary>
    public partial class View_Manage_CellDAL
    {
        public View_Manage_CellDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Mange_ID, string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Mange_Start_Cell_ID, string Manage_BreakDown_Status, string Manage_Operater, string Mange_End_Cell_ID, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Cell_Chlid_Position, string Cell_Child_InOut, int Cell_Child_Order, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_InOut, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Remark, string Manage_Type_Group, string Cell_Code, string Area_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Reserve1, string Cell_Chlid_ID, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Reserve1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_Manage_Cell");
            strSql.Append(" where Mange_ID='" + Mange_ID + "' and Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Mange_Status='" + Mange_Status + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Manage_Operater='" + Manage_Operater + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Remark='" + Manage_Remark + "' and Cell_Chlid_Position='" + Cell_Chlid_Position + "' and Cell_Child_InOut='" + Cell_Child_InOut + "' and Cell_Child_Order=" + Cell_Child_Order + " and Manage_Type_Code='" + Manage_Type_Code + "' and Manage_Type_Name='" + Manage_Type_Name + "' and Manage_Type_InOut='" + Manage_Type_InOut + "' and Manage_Type_Order=" + Manage_Type_Order + " and Manage_Type_Flag='" + Manage_Type_Flag + "' and Manage_Type_Remark='" + Manage_Type_Remark + "' and Manage_Type_Group='" + Manage_Type_Group + "' and Cell_Code='" + Cell_Code + "' and Area_ID='" + Area_ID + "' and Cell_Name='" + Cell_Name + "' and Cell_Lane='" + Cell_Lane + "' and Device_Code='" + Device_Code + "' and Shelf_Type='" + Shelf_Type + "' and Cell_InOut='" + Cell_InOut + "' and Cell_Type='" + Cell_Type + "' and Cell_Storage_Type='" + Cell_Storage_Type + "' and Cell_Fork_Type='" + Cell_Fork_Type + "' and Cell_Layer=" + Cell_Layer + " and Cell_Column=" + Cell_Column + " and Cell_Row=" + Cell_Row + " and Cell_Reserve1='" + Cell_Reserve1 + "' and Cell_Chlid_ID='" + Cell_Chlid_ID + "' and Cell_Child_Model='" + Cell_Child_Model + "' and Cell_Child_Status='" + Cell_Child_Status + "' and Cell_Child_Run_Status='" + Cell_Child_Run_Status + "' and Cell_Child_Flag='" + Cell_Child_Flag + "' and Cell_Child_Operate_Type='" + Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + Cell_Child_TaskLock_ID + "' and Cell_Child_Reserve1='" + Cell_Child_Reserve1 + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_Manage_CellModel model)
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
            if (model.Mange_Start_Cell_ID != null)
            {
                strSql1.Append("Mange_Start_Cell_ID,");
                strSql2.Append("'" + model.Mange_Start_Cell_ID + "',");
            }
            if (model.Manage_BreakDown_Status != null)
            {
                strSql1.Append("Manage_BreakDown_Status,");
                strSql2.Append("'" + model.Manage_BreakDown_Status + "',");
            }
            if (model.Manage_Operater != null)
            {
                strSql1.Append("Manage_Operater,");
                strSql2.Append("'" + model.Manage_Operater + "',");
            }
            if (model.Mange_End_Cell_ID != null)
            {
                strSql1.Append("Mange_End_Cell_ID,");
                strSql2.Append("'" + model.Mange_End_Cell_ID + "',");
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
            if (model.Cell_Chlid_Position != null)
            {
                strSql1.Append("Cell_Chlid_Position,");
                strSql2.Append("'" + model.Cell_Chlid_Position + "',");
            }
            if (model.Cell_Child_InOut != null)
            {
                strSql1.Append("Cell_Child_InOut,");
                strSql2.Append("'" + model.Cell_Child_InOut + "',");
            }
            if (model.Cell_Child_Order != null)
            {
                strSql1.Append("Cell_Child_Order,");
                strSql2.Append("" + model.Cell_Child_Order + ",");
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
            if (model.Manage_Type_InOut != null)
            {
                strSql1.Append("Manage_Type_InOut,");
                strSql2.Append("'" + model.Manage_Type_InOut + "',");
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
            if (model.Manage_Type_Remark != null)
            {
                strSql1.Append("Manage_Type_Remark,");
                strSql2.Append("'" + model.Manage_Type_Remark + "',");
            }
            if (model.Manage_Type_Group != null)
            {
                strSql1.Append("Manage_Type_Group,");
                strSql2.Append("'" + model.Manage_Type_Group + "',");
            }
            if (model.Cell_Code != null)
            {
                strSql1.Append("Cell_Code,");
                strSql2.Append("'" + model.Cell_Code + "',");
            }
            if (model.Area_ID != null)
            {
                strSql1.Append("Area_ID,");
                strSql2.Append("'" + model.Area_ID + "',");
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
            if (model.Cell_Reserve1 != null)
            {
                strSql1.Append("Cell_Reserve1,");
                strSql2.Append("'" + model.Cell_Reserve1 + "',");
            }
            if (model.Cell_Chlid_ID != null)
            {
                strSql1.Append("Cell_Chlid_ID,");
                strSql2.Append("'" + model.Cell_Chlid_ID + "',");
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
            if (model.Cell_Child_Reserve1 != null)
            {
                strSql1.Append("Cell_Child_Reserve1,");
                strSql2.Append("'" + model.Cell_Child_Reserve1 + "',");
            }
            strSql.Append("insert into View_Manage_Cell(");
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
        public bool Update(WMS_Database.View_Manage_CellModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_Manage_Cell set ");
            if (model.Mange_ID != null)
            {
                strSql.Append("Mange_ID='" + model.Mange_ID + "',");
            }
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
            if (model.Mange_Start_Cell_ID != null)
            {
                strSql.Append("Mange_Start_Cell_ID='" + model.Mange_Start_Cell_ID + "',");
            }
            else
            {
                strSql.Append("Mange_Start_Cell_ID= null ,");
            }
            if (model.Manage_BreakDown_Status != null)
            {
                strSql.Append("Manage_BreakDown_Status='" + model.Manage_BreakDown_Status + "',");
            }
            else
            {
                strSql.Append("Manage_BreakDown_Status= null ,");
            }
            if (model.Manage_Operater != null)
            {
                strSql.Append("Manage_Operater='" + model.Manage_Operater + "',");
            }
            else
            {
                strSql.Append("Manage_Operater= null ,");
            }
            if (model.Mange_End_Cell_ID != null)
            {
                strSql.Append("Mange_End_Cell_ID='" + model.Mange_End_Cell_ID + "',");
            }
            else
            {
                strSql.Append("Mange_End_Cell_ID= null ,");
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
            if (model.Cell_Chlid_Position != null)
            {
                strSql.Append("Cell_Chlid_Position='" + model.Cell_Chlid_Position + "',");
            }
            else
            {
                strSql.Append("Cell_Chlid_Position= null ,");
            }
            if (model.Cell_Child_InOut != null)
            {
                strSql.Append("Cell_Child_InOut='" + model.Cell_Child_InOut + "',");
            }
            else
            {
                strSql.Append("Cell_Child_InOut= null ,");
            }
            if (model.Cell_Child_Order != null)
            {
                strSql.Append("Cell_Child_Order=" + model.Cell_Child_Order + ",");
            }
            else
            {
                strSql.Append("Cell_Child_Order= null ,");
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
            if (model.Manage_Type_InOut != null)
            {
                strSql.Append("Manage_Type_InOut='" + model.Manage_Type_InOut + "',");
            }
            else
            {
                strSql.Append("Manage_Type_InOut= null ,");
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
            if (model.Manage_Type_Remark != null)
            {
                strSql.Append("Manage_Type_Remark='" + model.Manage_Type_Remark + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Remark= null ,");
            }
            if (model.Manage_Type_Group != null)
            {
                strSql.Append("Manage_Type_Group='" + model.Manage_Type_Group + "',");
            }
            else
            {
                strSql.Append("Manage_Type_Group= null ,");
            }
            if (model.Cell_Code != null)
            {
                strSql.Append("Cell_Code='" + model.Cell_Code + "',");
            }
            else
            {
                strSql.Append("Cell_Code= null ,");
            }
            if (model.Area_ID != null)
            {
                strSql.Append("Area_ID='" + model.Area_ID + "',");
            }
            else
            {
                strSql.Append("Area_ID= null ,");
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
            if (model.Cell_Reserve1 != null)
            {
                strSql.Append("Cell_Reserve1='" + model.Cell_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Cell_Reserve1= null ,");
            }
            if (model.Cell_Chlid_ID != null)
            {
                strSql.Append("Cell_Chlid_ID='" + model.Cell_Chlid_ID + "',");
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
            if (model.Cell_Child_Reserve1 != null)
            {
                strSql.Append("Cell_Child_Reserve1='" + model.Cell_Child_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Reserve1= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Mange_ID='" + model.Mange_ID + "' and Plan_ID='" + model.Plan_ID + "' and Mange_Type_ID='" + model.Mange_Type_ID + "' and Mange_Status='" + model.Mange_Status + "' and Mange_Stock_Barcode='" + model.Mange_Stock_Barcode + "' and Mange_Full_Flag='" + model.Mange_Full_Flag + "' and Mange_Start_Cell_ID='" + model.Mange_Start_Cell_ID + "' and Manage_BreakDown_Status='" + model.Manage_BreakDown_Status + "' and Manage_Operater='" + model.Manage_Operater + "' and Mange_End_Cell_ID='" + model.Mange_End_Cell_ID + "' and Manage_Begin_Time='" + model.Manage_Begin_Time + "' and Manage_End_Time='" + model.Manage_End_Time + "' and Manage_Remark='" + model.Manage_Remark + "' and Cell_Chlid_Position='" + model.Cell_Chlid_Position + "' and Cell_Child_InOut='" + model.Cell_Child_InOut + "' and Cell_Child_Order=" + model.Cell_Child_Order + " and Manage_Type_Code='" + model.Manage_Type_Code + "' and Manage_Type_Name='" + model.Manage_Type_Name + "' and Manage_Type_InOut='" + model.Manage_Type_InOut + "' and Manage_Type_Order=" + model.Manage_Type_Order + " and Manage_Type_Flag='" + model.Manage_Type_Flag + "' and Manage_Type_Remark='" + model.Manage_Type_Remark + "' and Manage_Type_Group='" + model.Manage_Type_Group + "' and Cell_Code='" + model.Cell_Code + "' and Area_ID='" + model.Area_ID + "' and Cell_Name='" + model.Cell_Name + "' and Cell_Lane='" + model.Cell_Lane + "' and Device_Code='" + model.Device_Code + "' and Shelf_Type='" + model.Shelf_Type + "' and Cell_InOut='" + model.Cell_InOut + "' and Cell_Type='" + model.Cell_Type + "' and Cell_Storage_Type='" + model.Cell_Storage_Type + "' and Cell_Fork_Type='" + model.Cell_Fork_Type + "' and Cell_Layer=" + model.Cell_Layer + " and Cell_Column=" + model.Cell_Column + " and Cell_Row=" + model.Cell_Row + " and Cell_Reserve1='" + model.Cell_Reserve1 + "' and Cell_Chlid_ID='" + model.Cell_Chlid_ID + "' and Cell_Child_Model='" + model.Cell_Child_Model + "' and Cell_Child_Status='" + model.Cell_Child_Status + "' and Cell_Child_Run_Status='" + model.Cell_Child_Run_Status + "' and Cell_Child_Flag='" + model.Cell_Child_Flag + "' and Cell_Child_Operate_Type='" + model.Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + model.Cell_Child_TaskLock_ID + "' and Cell_Child_Reserve1='" + model.Cell_Child_Reserve1 + "' ");
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
        public bool Delete(string Mange_ID, string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Mange_Start_Cell_ID, string Manage_BreakDown_Status, string Manage_Operater, string Mange_End_Cell_ID, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Cell_Chlid_Position, string Cell_Child_InOut, int Cell_Child_Order, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_InOut, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Remark, string Manage_Type_Group, string Cell_Code, string Area_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Reserve1, string Cell_Chlid_ID, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Reserve1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_Manage_Cell ");
            strSql.Append(" where Mange_ID='" + Mange_ID + "' and Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Mange_Status='" + Mange_Status + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Manage_Operater='" + Manage_Operater + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Remark='" + Manage_Remark + "' and Cell_Chlid_Position='" + Cell_Chlid_Position + "' and Cell_Child_InOut='" + Cell_Child_InOut + "' and Cell_Child_Order=" + Cell_Child_Order + " and Manage_Type_Code='" + Manage_Type_Code + "' and Manage_Type_Name='" + Manage_Type_Name + "' and Manage_Type_InOut='" + Manage_Type_InOut + "' and Manage_Type_Order=" + Manage_Type_Order + " and Manage_Type_Flag='" + Manage_Type_Flag + "' and Manage_Type_Remark='" + Manage_Type_Remark + "' and Manage_Type_Group='" + Manage_Type_Group + "' and Cell_Code='" + Cell_Code + "' and Area_ID='" + Area_ID + "' and Cell_Name='" + Cell_Name + "' and Cell_Lane='" + Cell_Lane + "' and Device_Code='" + Device_Code + "' and Shelf_Type='" + Shelf_Type + "' and Cell_InOut='" + Cell_InOut + "' and Cell_Type='" + Cell_Type + "' and Cell_Storage_Type='" + Cell_Storage_Type + "' and Cell_Fork_Type='" + Cell_Fork_Type + "' and Cell_Layer=" + Cell_Layer + " and Cell_Column=" + Cell_Column + " and Cell_Row=" + Cell_Row + " and Cell_Reserve1='" + Cell_Reserve1 + "' and Cell_Chlid_ID='" + Cell_Chlid_ID + "' and Cell_Child_Model='" + Cell_Child_Model + "' and Cell_Child_Status='" + Cell_Child_Status + "' and Cell_Child_Run_Status='" + Cell_Child_Run_Status + "' and Cell_Child_Flag='" + Cell_Child_Flag + "' and Cell_Child_Operate_Type='" + Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + Cell_Child_TaskLock_ID + "' and Cell_Child_Reserve1='" + Cell_Child_Reserve1 + "' ");
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
        public WMS_Database.View_Manage_CellModel GetModel(string Mange_ID, string Plan_ID, string Mange_Type_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Mange_Start_Cell_ID, string Manage_BreakDown_Status, string Manage_Operater, string Mange_End_Cell_ID, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Cell_Chlid_Position, string Cell_Child_InOut, int Cell_Child_Order, string Manage_Type_Code, string Manage_Type_Name, string Manage_Type_InOut, int Manage_Type_Order, string Manage_Type_Flag, string Manage_Type_Remark, string Manage_Type_Group, string Cell_Code, string Area_ID, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Reserve1, string Cell_Chlid_ID, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Flag, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Reserve1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Mange_Start_Cell_ID,Manage_BreakDown_Status,Manage_Operater,Mange_End_Cell_ID,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Cell_Chlid_Position,Cell_Child_InOut,Cell_Child_Order,Manage_Type_Code,Manage_Type_Name,Manage_Type_InOut,Manage_Type_Order,Manage_Type_Flag,Manage_Type_Remark,Manage_Type_Group,Cell_Code,Area_ID,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Reserve1,Cell_Chlid_ID,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Flag,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Reserve1 ");
            strSql.Append(" from View_Manage_Cell ");
            strSql.Append(" where Mange_ID='" + Mange_ID + "' and Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Mange_Status='" + Mange_Status + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Manage_Operater='" + Manage_Operater + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Remark='" + Manage_Remark + "' and Cell_Chlid_Position='" + Cell_Chlid_Position + "' and Cell_Child_InOut='" + Cell_Child_InOut + "' and Cell_Child_Order=" + Cell_Child_Order + " and Manage_Type_Code='" + Manage_Type_Code + "' and Manage_Type_Name='" + Manage_Type_Name + "' and Manage_Type_InOut='" + Manage_Type_InOut + "' and Manage_Type_Order=" + Manage_Type_Order + " and Manage_Type_Flag='" + Manage_Type_Flag + "' and Manage_Type_Remark='" + Manage_Type_Remark + "' and Manage_Type_Group='" + Manage_Type_Group + "' and Cell_Code='" + Cell_Code + "' and Area_ID='" + Area_ID + "' and Cell_Name='" + Cell_Name + "' and Cell_Lane='" + Cell_Lane + "' and Device_Code='" + Device_Code + "' and Shelf_Type='" + Shelf_Type + "' and Cell_InOut='" + Cell_InOut + "' and Cell_Type='" + Cell_Type + "' and Cell_Storage_Type='" + Cell_Storage_Type + "' and Cell_Fork_Type='" + Cell_Fork_Type + "' and Cell_Layer=" + Cell_Layer + " and Cell_Column=" + Cell_Column + " and Cell_Row=" + Cell_Row + " and Cell_Reserve1='" + Cell_Reserve1 + "' and Cell_Chlid_ID='" + Cell_Chlid_ID + "' and Cell_Child_Model='" + Cell_Child_Model + "' and Cell_Child_Status='" + Cell_Child_Status + "' and Cell_Child_Run_Status='" + Cell_Child_Run_Status + "' and Cell_Child_Flag='" + Cell_Child_Flag + "' and Cell_Child_Operate_Type='" + Cell_Child_Operate_Type + "' and Cell_Child_TaskLock_ID='" + Cell_Child_TaskLock_ID + "' and Cell_Child_Reserve1='" + Cell_Child_Reserve1 + "' ");
            WMS_Database.View_Manage_CellModel model = new WMS_Database.View_Manage_CellModel();
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
        public WMS_Database.View_Manage_CellModel DataRowToModel(DataRow row)
        {
            WMS_Database.View_Manage_CellModel model = new WMS_Database.View_Manage_CellModel();
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
                if (row["Mange_Start_Cell_ID"] != null)
                {
                    model.Mange_Start_Cell_ID = row["Mange_Start_Cell_ID"].ToString();
                }
                if (row["Manage_BreakDown_Status"] != null)
                {
                    model.Manage_BreakDown_Status = row["Manage_BreakDown_Status"].ToString();
                }
                if (row["Manage_Operater"] != null)
                {
                    model.Manage_Operater = row["Manage_Operater"].ToString();
                }
                if (row["Mange_End_Cell_ID"] != null)
                {
                    model.Mange_End_Cell_ID = row["Mange_End_Cell_ID"].ToString();
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
                if (row["Cell_Chlid_Position"] != null)
                {
                    model.Cell_Chlid_Position = row["Cell_Chlid_Position"].ToString();
                }
                if (row["Cell_Child_InOut"] != null)
                {
                    model.Cell_Child_InOut = row["Cell_Child_InOut"].ToString();
                }
                if (row["Cell_Child_Order"] != null && row["Cell_Child_Order"].ToString() != "")
                {
                    model.Cell_Child_Order = int.Parse(row["Cell_Child_Order"].ToString());
                }
                if (row["Manage_Type_Code"] != null)
                {
                    model.Manage_Type_Code = row["Manage_Type_Code"].ToString();
                }
                if (row["Manage_Type_Name"] != null)
                {
                    model.Manage_Type_Name = row["Manage_Type_Name"].ToString();
                }
                if (row["Manage_Type_InOut"] != null)
                {
                    model.Manage_Type_InOut = row["Manage_Type_InOut"].ToString();
                }
                if (row["Manage_Type_Order"] != null && row["Manage_Type_Order"].ToString() != "")
                {
                    model.Manage_Type_Order = int.Parse(row["Manage_Type_Order"].ToString());
                }
                if (row["Manage_Type_Flag"] != null)
                {
                    model.Manage_Type_Flag = row["Manage_Type_Flag"].ToString();
                }
                if (row["Manage_Type_Remark"] != null)
                {
                    model.Manage_Type_Remark = row["Manage_Type_Remark"].ToString();
                }
                if (row["Manage_Type_Group"] != null)
                {
                    model.Manage_Type_Group = row["Manage_Type_Group"].ToString();
                }
                if (row["Cell_Code"] != null)
                {
                    model.Cell_Code = row["Cell_Code"].ToString();
                }
                if (row["Area_ID"] != null)
                {
                    model.Area_ID = row["Area_ID"].ToString();
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
                if (row["Cell_Reserve1"] != null)
                {
                    model.Cell_Reserve1 = row["Cell_Reserve1"].ToString();
                }
                if (row["Cell_Chlid_ID"] != null)
                {
                    model.Cell_Chlid_ID = row["Cell_Chlid_ID"].ToString();
                }
                if (row["Cell_Child_Model"] != null)
                {
                    model.Cell_Child_Model = row["Cell_Child_Model"].ToString();
                }
                if (row["Cell_Child_Status"] != null)
                {
                    model.Cell_Child_Status = row["Cell_Child_Status"].ToString();
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
                if (row["Cell_Child_Reserve1"] != null)
                {
                    model.Cell_Child_Reserve1 = row["Cell_Child_Reserve1"].ToString();
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
            strSql.Append("select Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Mange_Start_Cell_ID,Manage_BreakDown_Status,Manage_Operater,Mange_End_Cell_ID,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Cell_Chlid_Position,Cell_Child_InOut,Cell_Child_Order,Manage_Type_Code,Manage_Type_Name,Manage_Type_InOut,Manage_Type_Order,Manage_Type_Flag,Manage_Type_Remark,Manage_Type_Group,Cell_Code,Area_ID,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Reserve1,Cell_Chlid_ID,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Flag,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Reserve1 ");
            strSql.Append(" FROM View_Manage_Cell ");
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
            strSql.Append(" Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Mange_Start_Cell_ID,Manage_BreakDown_Status,Manage_Operater,Mange_End_Cell_ID,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Cell_Chlid_Position,Cell_Child_InOut,Cell_Child_Order,Manage_Type_Code,Manage_Type_Name,Manage_Type_InOut,Manage_Type_Order,Manage_Type_Flag,Manage_Type_Remark,Manage_Type_Group,Cell_Code,Area_ID,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Reserve1,Cell_Chlid_ID,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Flag,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Reserve1 ");
            strSql.Append(" FROM View_Manage_Cell ");
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
            strSql.Append("select count(1) FROM View_Manage_Cell ");
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
                strSql.Append("order by T.Cell_Child_Reserve1 desc");
            }
            strSql.Append(")AS Row, T.*  from View_Manage_Cell T ");
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

