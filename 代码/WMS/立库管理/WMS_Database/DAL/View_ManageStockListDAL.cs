using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:View_ManageStockList
    /// </summary>
    public partial class View_ManageStockListDAL
    {
        public View_ManageStockListDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID, string Mange_Type_ID, string Stock_List_ID, string Manage_List_Quantity, string Plan_List_ID, string Stock_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Manage_List_ID, string Manage_List_Remark, string Goods_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Mange_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_ManageStockList");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Stock_List_ID='" + Stock_List_ID + "' and Manage_List_Quantity='" + Manage_List_Quantity + "' and Plan_List_ID='" + Plan_List_ID + "' and Stock_ID='" + Stock_ID + "' and Mange_Status='" + Mange_Status + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Remark='" + Manage_Remark + "' and Manage_List_ID='" + Manage_List_ID + "' and Manage_List_Remark='" + Manage_List_Remark + "' and Goods_ID='" + Goods_ID + "' and Stock_List_Box_Barcode='" + Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + Stock_List_Quantity + "' and Stock_List_Entry_Time='" + Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + Stock_List_Update_Time + "' and Stock_List_Remark='" + Stock_List_Remark + "' and Cell_Child_ID='" + Cell_Child_ID + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Stock_Full_Flag='" + Stock_Full_Flag + "' and Stock_Remark='" + Stock_Remark + "' and Mange_ID='" + Mange_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_ManageStockListModel model)
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
            if (model.Plan_List_ID != null)
            {
                strSql1.Append("Plan_List_ID,");
                strSql2.Append("'" + model.Plan_List_ID + "',");
            }
            if (model.Stock_ID != null)
            {
                strSql1.Append("Stock_ID,");
                strSql2.Append("'" + model.Stock_ID + "',");
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
            if (model.Manage_List_ID != null)
            {
                strSql1.Append("Manage_List_ID,");
                strSql2.Append("'" + model.Manage_List_ID + "',");
            }
            if (model.Manage_List_Remark != null)
            {
                strSql1.Append("Manage_List_Remark,");
                strSql2.Append("'" + model.Manage_List_Remark + "',");
            }
            if (model.Goods_ID != null)
            {
                strSql1.Append("Goods_ID,");
                strSql2.Append("'" + model.Goods_ID + "',");
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
            if (model.Mange_ID != null)
            {
                strSql1.Append("Mange_ID,");
                strSql2.Append("'" + model.Mange_ID + "',");
            }
            strSql.Append("insert into View_ManageStockList(");
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
        public bool Update(WMS_Database.View_ManageStockListModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_ManageStockList set ");
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
            if (model.Plan_List_ID != null)
            {
                strSql.Append("Plan_List_ID='" + model.Plan_List_ID + "',");
            }
            else
            {
                strSql.Append("Plan_List_ID= null ,");
            }
            if (model.Stock_ID != null)
            {
                strSql.Append("Stock_ID='" + model.Stock_ID + "',");
            }
            else
            {
                strSql.Append("Stock_ID= null ,");
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
            if (model.Manage_List_ID != null)
            {
                strSql.Append("Manage_List_ID='" + model.Manage_List_ID + "',");
            }
            if (model.Manage_List_Remark != null)
            {
                strSql.Append("Manage_List_Remark='" + model.Manage_List_Remark + "',");
            }
            else
            {
                strSql.Append("Manage_List_Remark= null ,");
            }
            if (model.Goods_ID != null)
            {
                strSql.Append("Goods_ID='" + model.Goods_ID + "',");
            }
            else
            {
                strSql.Append("Goods_ID= null ,");
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
            if (model.Mange_ID != null)
            {
                strSql.Append("Mange_ID='" + model.Mange_ID + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Plan_ID='" + model.Plan_ID + "' and Mange_Type_ID='" + model.Mange_Type_ID + "' and Stock_List_ID='" + model.Stock_List_ID + "' and Manage_List_Quantity='" + model.Manage_List_Quantity + "' and Plan_List_ID='" + model.Plan_List_ID + "' and Stock_ID='" + model.Stock_ID + "' and Mange_Status='" + model.Mange_Status + "' and Mange_Stock_Barcode='" + model.Mange_Stock_Barcode + "' and Mange_Full_Flag='" + model.Mange_Full_Flag + "' and Manage_BreakDown_Status='" + model.Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + model.Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + model.Mange_End_Cell_ID + "' and Manage_Operater='" + model.Manage_Operater + "' and Manage_Begin_Time='" + model.Manage_Begin_Time + "' and Manage_End_Time='" + model.Manage_End_Time + "' and Manage_Remark='" + model.Manage_Remark + "' and Manage_List_ID='" + model.Manage_List_ID + "' and Manage_List_Remark='" + model.Manage_List_Remark + "' and Goods_ID='" + model.Goods_ID + "' and Stock_List_Box_Barcode='" + model.Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + model.Stock_List_Quantity + "' and Stock_List_Entry_Time='" + model.Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + model.Stock_List_Update_Time + "' and Stock_List_Remark='" + model.Stock_List_Remark + "' and Cell_Child_ID='" + model.Cell_Child_ID + "' and Stock_Tray_Barcode='" + model.Stock_Tray_Barcode + "' and Stock_Full_Flag='" + model.Stock_Full_Flag + "' and Stock_Remark='" + model.Stock_Remark + "' and Mange_ID='" + model.Mange_ID + "' ");
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
        public bool Delete(string Plan_ID, string Mange_Type_ID, string Stock_List_ID, string Manage_List_Quantity, string Plan_List_ID, string Stock_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Manage_List_ID, string Manage_List_Remark, string Goods_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Mange_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_ManageStockList ");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Stock_List_ID='" + Stock_List_ID + "' and Manage_List_Quantity='" + Manage_List_Quantity + "' and Plan_List_ID='" + Plan_List_ID + "' and Stock_ID='" + Stock_ID + "' and Mange_Status='" + Mange_Status + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Remark='" + Manage_Remark + "' and Manage_List_ID='" + Manage_List_ID + "' and Manage_List_Remark='" + Manage_List_Remark + "' and Goods_ID='" + Goods_ID + "' and Stock_List_Box_Barcode='" + Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + Stock_List_Quantity + "' and Stock_List_Entry_Time='" + Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + Stock_List_Update_Time + "' and Stock_List_Remark='" + Stock_List_Remark + "' and Cell_Child_ID='" + Cell_Child_ID + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Stock_Full_Flag='" + Stock_Full_Flag + "' and Stock_Remark='" + Stock_Remark + "' and Mange_ID='" + Mange_ID + "' ");
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
        public WMS_Database.View_ManageStockListModel GetModel(string Plan_ID, string Mange_Type_ID, string Stock_List_ID, string Manage_List_Quantity, string Plan_List_ID, string Stock_ID, string Mange_Status, string Mange_Stock_Barcode, string Mange_Full_Flag, string Manage_BreakDown_Status, string Mange_Start_Cell_ID, string Mange_End_Cell_ID, string Manage_Operater, DateTime Manage_Begin_Time, DateTime Manage_End_Time, string Manage_Remark, string Manage_List_ID, string Manage_List_Remark, string Goods_ID, string Stock_List_Box_Barcode, string Stock_List_Quantity, DateTime Stock_List_Entry_Time, DateTime Stock_List_Update_Time, string Stock_List_Remark, string Cell_Child_ID, string Stock_Tray_Barcode, string Stock_Full_Flag, string Stock_Remark, string Mange_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Plan_ID,Mange_Type_ID,Stock_List_ID,Manage_List_Quantity,Plan_List_ID,Stock_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Manage_List_ID,Manage_List_Remark,Goods_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Cell_Child_ID,Stock_Tray_Barcode,Stock_Full_Flag,Stock_Remark,Mange_ID ");
            strSql.Append(" from View_ManageStockList ");
            strSql.Append(" where Plan_ID='" + Plan_ID + "' and Mange_Type_ID='" + Mange_Type_ID + "' and Stock_List_ID='" + Stock_List_ID + "' and Manage_List_Quantity='" + Manage_List_Quantity + "' and Plan_List_ID='" + Plan_List_ID + "' and Stock_ID='" + Stock_ID + "' and Mange_Status='" + Mange_Status + "' and Mange_Stock_Barcode='" + Mange_Stock_Barcode + "' and Mange_Full_Flag='" + Mange_Full_Flag + "' and Manage_BreakDown_Status='" + Manage_BreakDown_Status + "' and Mange_Start_Cell_ID='" + Mange_Start_Cell_ID + "' and Mange_End_Cell_ID='" + Mange_End_Cell_ID + "' and Manage_Operater='" + Manage_Operater + "' and Manage_Begin_Time='" + Manage_Begin_Time + "' and Manage_End_Time='" + Manage_End_Time + "' and Manage_Remark='" + Manage_Remark + "' and Manage_List_ID='" + Manage_List_ID + "' and Manage_List_Remark='" + Manage_List_Remark + "' and Goods_ID='" + Goods_ID + "' and Stock_List_Box_Barcode='" + Stock_List_Box_Barcode + "' and Stock_List_Quantity='" + Stock_List_Quantity + "' and Stock_List_Entry_Time='" + Stock_List_Entry_Time + "' and Stock_List_Update_Time='" + Stock_List_Update_Time + "' and Stock_List_Remark='" + Stock_List_Remark + "' and Cell_Child_ID='" + Cell_Child_ID + "' and Stock_Tray_Barcode='" + Stock_Tray_Barcode + "' and Stock_Full_Flag='" + Stock_Full_Flag + "' and Stock_Remark='" + Stock_Remark + "' and Mange_ID='" + Mange_ID + "' ");
            WMS_Database.View_ManageStockListModel model = new WMS_Database.View_ManageStockListModel();
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
        public WMS_Database.View_ManageStockListModel DataRowToModel(DataRow row)
        {
            WMS_Database.View_ManageStockListModel model = new WMS_Database.View_ManageStockListModel();
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
                if (row["Stock_List_ID"] != null)
                {
                    model.Stock_List_ID = row["Stock_List_ID"].ToString();
                }
                if (row["Manage_List_Quantity"] != null)
                {
                    model.Manage_List_Quantity = row["Manage_List_Quantity"].ToString();
                }
                if (row["Plan_List_ID"] != null)
                {
                    model.Plan_List_ID = row["Plan_List_ID"].ToString();
                }
                if (row["Stock_ID"] != null)
                {
                    model.Stock_ID = row["Stock_ID"].ToString();
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
                if (row["Manage_List_ID"] != null)
                {
                    model.Manage_List_ID = row["Manage_List_ID"].ToString();
                }
                if (row["Manage_List_Remark"] != null)
                {
                    model.Manage_List_Remark = row["Manage_List_Remark"].ToString();
                }
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
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
                if (row["Mange_ID"] != null)
                {
                    model.Mange_ID = row["Mange_ID"].ToString();
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
            strSql.Append("select Plan_ID,Mange_Type_ID,Stock_List_ID,Manage_List_Quantity,Plan_List_ID,Stock_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Manage_List_ID,Manage_List_Remark,Goods_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Cell_Child_ID,Stock_Tray_Barcode,Stock_Full_Flag,Stock_Remark,Mange_ID ");
            strSql.Append(" FROM View_ManageStockList ");
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
            strSql.Append(" Plan_ID,Mange_Type_ID,Stock_List_ID,Manage_List_Quantity,Plan_List_ID,Stock_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Manage_List_ID,Manage_List_Remark,Goods_ID,Stock_List_Box_Barcode,Stock_List_Quantity,Stock_List_Entry_Time,Stock_List_Update_Time,Stock_List_Remark,Cell_Child_ID,Stock_Tray_Barcode,Stock_Full_Flag,Stock_Remark,Mange_ID ");
            strSql.Append(" FROM View_ManageStockList ");
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
            strSql.Append("select count(1) FROM View_ManageStockList ");
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
            strSql.Append(")AS Row, T.*  from View_ManageStockList T ");
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

