using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:View_Cell
    /// </summary>
    public partial class View_CellDAL
    {
        public View_CellDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WareHouse_Code, string WareHouse_Name, string WareHouse_Flag, string WareHouse_Type, string WareHouse_Remark, string WareHouse_ID, string Area_Type, string Area_Name, string Area_Code, int Area_Order, string Area_Flag, string Area_BackColor, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Chlid_ID, string Cell_Chlid_Position, string Cell_ID, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Flag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_Cell");
            strSql.Append(" where WareHouse_Code=@WareHouse_Code and WareHouse_Name=@WareHouse_Name and WareHouse_Flag=@WareHouse_Flag and WareHouse_Type=@WareHouse_Type and WareHouse_Remark=@WareHouse_Remark and WareHouse_ID=@WareHouse_ID and Area_Type=@Area_Type and Area_Name=@Area_Name and Area_Code=@Area_Code and Area_Order=@Area_Order and Area_Flag=@Area_Flag and Area_BackColor=@Area_BackColor and Area_ID=@Area_ID and Cell_Code=@Cell_Code and Cell_Name=@Cell_Name and Cell_Lane=@Cell_Lane and Device_Code=@Device_Code and Shelf_Type=@Shelf_Type and Cell_InOut=@Cell_InOut and Cell_Type=@Cell_Type and Cell_Storage_Type=@Cell_Storage_Type and Cell_Fork_Type=@Cell_Fork_Type and Cell_Layer=@Cell_Layer and Cell_Column=@Cell_Column and Cell_Row=@Cell_Row and Cell_Chlid_ID=@Cell_Chlid_ID and Cell_Chlid_Position=@Cell_Chlid_Position and Cell_ID=@Cell_ID and Cell_Child_Order=@Cell_Child_Order and Cell_Child_InOut=@Cell_Child_InOut and Cell_Child_Model=@Cell_Child_Model and Cell_Child_Status=@Cell_Child_Status and Cell_Child_Run_Status=@Cell_Child_Run_Status and Cell_Child_Operate_Type=@Cell_Child_Operate_Type and Cell_Child_TaskLock_ID=@Cell_Child_TaskLock_ID and Cell_Child_Flag=@Cell_Child_Flag ");
            SqlParameter[] parameters = {
					new SqlParameter("@WareHouse_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Order", SqlDbType.Int,4),
					new SqlParameter("@Area_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_BackColor", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Lane", SqlDbType.NVarChar,50),
					new SqlParameter("@Device_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Shelf_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Storage_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Fork_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Layer", SqlDbType.Int,4),
					new SqlParameter("@Cell_Column", SqlDbType.Int,4),
					new SqlParameter("@Cell_Row", SqlDbType.Int,4),
					new SqlParameter("@Cell_Chlid_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Chlid_Position", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Order", SqlDbType.Int,4),
					new SqlParameter("@Cell_Child_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Run_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Operate_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_TaskLock_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Flag", SqlDbType.NVarChar,50)			};
            parameters[0].Value = WareHouse_Code;
            parameters[1].Value = WareHouse_Name;
            parameters[2].Value = WareHouse_Flag;
            parameters[3].Value = WareHouse_Type;
            parameters[4].Value = WareHouse_Remark;
            parameters[5].Value = WareHouse_ID;
            parameters[6].Value = Area_Type;
            parameters[7].Value = Area_Name;
            parameters[8].Value = Area_Code;
            parameters[9].Value = Area_Order;
            parameters[10].Value = Area_Flag;
            parameters[11].Value = Area_BackColor;
            parameters[12].Value = Area_ID;
            parameters[13].Value = Cell_Code;
            parameters[14].Value = Cell_Name;
            parameters[15].Value = Cell_Lane;
            parameters[16].Value = Device_Code;
            parameters[17].Value = Shelf_Type;
            parameters[18].Value = Cell_InOut;
            parameters[19].Value = Cell_Type;
            parameters[20].Value = Cell_Storage_Type;
            parameters[21].Value = Cell_Fork_Type;
            parameters[22].Value = Cell_Layer;
            parameters[23].Value = Cell_Column;
            parameters[24].Value = Cell_Row;
            parameters[25].Value = Cell_Chlid_ID;
            parameters[26].Value = Cell_Chlid_Position;
            parameters[27].Value = Cell_ID;
            parameters[28].Value = Cell_Child_Order;
            parameters[29].Value = Cell_Child_InOut;
            parameters[30].Value = Cell_Child_Model;
            parameters[31].Value = Cell_Child_Status;
            parameters[32].Value = Cell_Child_Run_Status;
            parameters[33].Value = Cell_Child_Operate_Type;
            parameters[34].Value = Cell_Child_TaskLock_ID;
            parameters[35].Value = Cell_Child_Flag;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_CellModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into View_Cell(");
            strSql.Append("WareHouse_Code,WareHouse_Name,WareHouse_Flag,WareHouse_Type,WareHouse_Remark,WareHouse_ID,Area_Type,Area_Name,Area_Code,Area_Order,Area_Flag,Area_BackColor,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Chlid_ID,Cell_Chlid_Position,Cell_ID,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Flag)");
            strSql.Append(" values (");
            strSql.Append("@WareHouse_Code,@WareHouse_Name,@WareHouse_Flag,@WareHouse_Type,@WareHouse_Remark,@WareHouse_ID,@Area_Type,@Area_Name,@Area_Code,@Area_Order,@Area_Flag,@Area_BackColor,@Area_ID,@Cell_Code,@Cell_Name,@Cell_Lane,@Device_Code,@Shelf_Type,@Cell_InOut,@Cell_Type,@Cell_Storage_Type,@Cell_Fork_Type,@Cell_Layer,@Cell_Column,@Cell_Row,@Cell_Chlid_ID,@Cell_Chlid_Position,@Cell_ID,@Cell_Child_Order,@Cell_Child_InOut,@Cell_Child_Model,@Cell_Child_Status,@Cell_Child_Run_Status,@Cell_Child_Operate_Type,@Cell_Child_TaskLock_ID,@Cell_Child_Flag)");
            SqlParameter[] parameters = {
					new SqlParameter("@WareHouse_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Order", SqlDbType.Int,4),
					new SqlParameter("@Area_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_BackColor", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Lane", SqlDbType.NVarChar,50),
					new SqlParameter("@Device_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Shelf_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Storage_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Fork_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Layer", SqlDbType.Int,4),
					new SqlParameter("@Cell_Column", SqlDbType.Int,4),
					new SqlParameter("@Cell_Row", SqlDbType.Int,4),
					new SqlParameter("@Cell_Chlid_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Chlid_Position", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Order", SqlDbType.Int,4),
					new SqlParameter("@Cell_Child_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Run_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Operate_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_TaskLock_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Flag", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.WareHouse_Code;
            parameters[1].Value = model.WareHouse_Name;
            parameters[2].Value = model.WareHouse_Flag;
            parameters[3].Value = model.WareHouse_Type;
            parameters[4].Value = model.WareHouse_Remark;
            parameters[5].Value = model.WareHouse_ID;
            parameters[6].Value = model.Area_Type;
            parameters[7].Value = model.Area_Name;
            parameters[8].Value = model.Area_Code;
            parameters[9].Value = model.Area_Order;
            parameters[10].Value = model.Area_Flag;
            parameters[11].Value = model.Area_BackColor;
            parameters[12].Value = model.Area_ID;
            parameters[13].Value = model.Cell_Code;
            parameters[14].Value = model.Cell_Name;
            parameters[15].Value = model.Cell_Lane;
            parameters[16].Value = model.Device_Code;
            parameters[17].Value = model.Shelf_Type;
            parameters[18].Value = model.Cell_InOut;
            parameters[19].Value = model.Cell_Type;
            parameters[20].Value = model.Cell_Storage_Type;
            parameters[21].Value = model.Cell_Fork_Type;
            parameters[22].Value = model.Cell_Layer;
            parameters[23].Value = model.Cell_Column;
            parameters[24].Value = model.Cell_Row;
            parameters[25].Value = model.Cell_Chlid_ID;
            parameters[26].Value = model.Cell_Chlid_Position;
            parameters[27].Value = model.Cell_ID;
            parameters[28].Value = model.Cell_Child_Order;
            parameters[29].Value = model.Cell_Child_InOut;
            parameters[30].Value = model.Cell_Child_Model;
            parameters[31].Value = model.Cell_Child_Status;
            parameters[32].Value = model.Cell_Child_Run_Status;
            parameters[33].Value = model.Cell_Child_Operate_Type;
            parameters[34].Value = model.Cell_Child_TaskLock_ID;
            parameters[35].Value = model.Cell_Child_Flag;

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
        public bool Update(WMS_Database.View_CellModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_Cell set ");
            strSql.Append("WareHouse_Code=@WareHouse_Code,");
            strSql.Append("WareHouse_Name=@WareHouse_Name,");
            strSql.Append("WareHouse_Flag=@WareHouse_Flag,");
            strSql.Append("WareHouse_Type=@WareHouse_Type,");
            strSql.Append("WareHouse_Remark=@WareHouse_Remark,");
            strSql.Append("WareHouse_ID=@WareHouse_ID,");
            strSql.Append("Area_Type=@Area_Type,");
            strSql.Append("Area_Name=@Area_Name,");
            strSql.Append("Area_Code=@Area_Code,");
            strSql.Append("Area_Order=@Area_Order,");
            strSql.Append("Area_Flag=@Area_Flag,");
            strSql.Append("Area_BackColor=@Area_BackColor,");
            strSql.Append("Area_ID=@Area_ID,");
            strSql.Append("Cell_Code=@Cell_Code,");
            strSql.Append("Cell_Name=@Cell_Name,");
            strSql.Append("Cell_Lane=@Cell_Lane,");
            strSql.Append("Device_Code=@Device_Code,");
            strSql.Append("Shelf_Type=@Shelf_Type,");
            strSql.Append("Cell_InOut=@Cell_InOut,");
            strSql.Append("Cell_Type=@Cell_Type,");
            strSql.Append("Cell_Storage_Type=@Cell_Storage_Type,");
            strSql.Append("Cell_Fork_Type=@Cell_Fork_Type,");
            strSql.Append("Cell_Layer=@Cell_Layer,");
            strSql.Append("Cell_Column=@Cell_Column,");
            strSql.Append("Cell_Row=@Cell_Row,");
            strSql.Append("Cell_Chlid_ID=@Cell_Chlid_ID,");
            strSql.Append("Cell_Chlid_Position=@Cell_Chlid_Position,");
            strSql.Append("Cell_ID=@Cell_ID,");
            strSql.Append("Cell_Child_Order=@Cell_Child_Order,");
            strSql.Append("Cell_Child_InOut=@Cell_Child_InOut,");
            strSql.Append("Cell_Child_Model=@Cell_Child_Model,");
            strSql.Append("Cell_Child_Status=@Cell_Child_Status,");
            strSql.Append("Cell_Child_Run_Status=@Cell_Child_Run_Status,");
            strSql.Append("Cell_Child_Operate_Type=@Cell_Child_Operate_Type,");
            strSql.Append("Cell_Child_TaskLock_ID=@Cell_Child_TaskLock_ID,");
            strSql.Append("Cell_Child_Flag=@Cell_Child_Flag");
            strSql.Append(" where WareHouse_Code=@WareHouse_Code and WareHouse_Name=@WareHouse_Name and WareHouse_Flag=@WareHouse_Flag and WareHouse_Type=@WareHouse_Type and WareHouse_Remark=@WareHouse_Remark and WareHouse_ID=@WareHouse_ID and Area_Type=@Area_Type and Area_Name=@Area_Name and Area_Code=@Area_Code and Area_Order=@Area_Order and Area_Flag=@Area_Flag and Area_BackColor=@Area_BackColor and Area_ID=@Area_ID and Cell_Code=@Cell_Code and Cell_Name=@Cell_Name and Cell_Lane=@Cell_Lane and Device_Code=@Device_Code and Shelf_Type=@Shelf_Type and Cell_InOut=@Cell_InOut and Cell_Type=@Cell_Type and Cell_Storage_Type=@Cell_Storage_Type and Cell_Fork_Type=@Cell_Fork_Type and Cell_Layer=@Cell_Layer and Cell_Column=@Cell_Column and Cell_Row=@Cell_Row and Cell_Chlid_ID=@Cell_Chlid_ID and Cell_Chlid_Position=@Cell_Chlid_Position and Cell_ID=@Cell_ID and Cell_Child_Order=@Cell_Child_Order and Cell_Child_InOut=@Cell_Child_InOut and Cell_Child_Model=@Cell_Child_Model and Cell_Child_Status=@Cell_Child_Status and Cell_Child_Run_Status=@Cell_Child_Run_Status and Cell_Child_Operate_Type=@Cell_Child_Operate_Type and Cell_Child_TaskLock_ID=@Cell_Child_TaskLock_ID and Cell_Child_Flag=@Cell_Child_Flag ");
            SqlParameter[] parameters = {
					new SqlParameter("@WareHouse_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Order", SqlDbType.Int,4),
					new SqlParameter("@Area_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_BackColor", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Lane", SqlDbType.NVarChar,50),
					new SqlParameter("@Device_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Shelf_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Storage_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Fork_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Layer", SqlDbType.Int,4),
					new SqlParameter("@Cell_Column", SqlDbType.Int,4),
					new SqlParameter("@Cell_Row", SqlDbType.Int,4),
					new SqlParameter("@Cell_Chlid_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Chlid_Position", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Order", SqlDbType.Int,4),
					new SqlParameter("@Cell_Child_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Run_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Operate_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_TaskLock_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Flag", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.WareHouse_Code;
            parameters[1].Value = model.WareHouse_Name;
            parameters[2].Value = model.WareHouse_Flag;
            parameters[3].Value = model.WareHouse_Type;
            parameters[4].Value = model.WareHouse_Remark;
            parameters[5].Value = model.WareHouse_ID;
            parameters[6].Value = model.Area_Type;
            parameters[7].Value = model.Area_Name;
            parameters[8].Value = model.Area_Code;
            parameters[9].Value = model.Area_Order;
            parameters[10].Value = model.Area_Flag;
            parameters[11].Value = model.Area_BackColor;
            parameters[12].Value = model.Area_ID;
            parameters[13].Value = model.Cell_Code;
            parameters[14].Value = model.Cell_Name;
            parameters[15].Value = model.Cell_Lane;
            parameters[16].Value = model.Device_Code;
            parameters[17].Value = model.Shelf_Type;
            parameters[18].Value = model.Cell_InOut;
            parameters[19].Value = model.Cell_Type;
            parameters[20].Value = model.Cell_Storage_Type;
            parameters[21].Value = model.Cell_Fork_Type;
            parameters[22].Value = model.Cell_Layer;
            parameters[23].Value = model.Cell_Column;
            parameters[24].Value = model.Cell_Row;
            parameters[25].Value = model.Cell_Chlid_ID;
            parameters[26].Value = model.Cell_Chlid_Position;
            parameters[27].Value = model.Cell_ID;
            parameters[28].Value = model.Cell_Child_Order;
            parameters[29].Value = model.Cell_Child_InOut;
            parameters[30].Value = model.Cell_Child_Model;
            parameters[31].Value = model.Cell_Child_Status;
            parameters[32].Value = model.Cell_Child_Run_Status;
            parameters[33].Value = model.Cell_Child_Operate_Type;
            parameters[34].Value = model.Cell_Child_TaskLock_ID;
            parameters[35].Value = model.Cell_Child_Flag;

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
        public bool Delete(string WareHouse_Code, string WareHouse_Name, string WareHouse_Flag, string WareHouse_Type, string WareHouse_Remark, string WareHouse_ID, string Area_Type, string Area_Name, string Area_Code, int Area_Order, string Area_Flag, string Area_BackColor, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Chlid_ID, string Cell_Chlid_Position, string Cell_ID, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Flag)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_Cell ");
            strSql.Append(" where WareHouse_Code=@WareHouse_Code and WareHouse_Name=@WareHouse_Name and WareHouse_Flag=@WareHouse_Flag and WareHouse_Type=@WareHouse_Type and WareHouse_Remark=@WareHouse_Remark and WareHouse_ID=@WareHouse_ID and Area_Type=@Area_Type and Area_Name=@Area_Name and Area_Code=@Area_Code and Area_Order=@Area_Order and Area_Flag=@Area_Flag and Area_BackColor=@Area_BackColor and Area_ID=@Area_ID and Cell_Code=@Cell_Code and Cell_Name=@Cell_Name and Cell_Lane=@Cell_Lane and Device_Code=@Device_Code and Shelf_Type=@Shelf_Type and Cell_InOut=@Cell_InOut and Cell_Type=@Cell_Type and Cell_Storage_Type=@Cell_Storage_Type and Cell_Fork_Type=@Cell_Fork_Type and Cell_Layer=@Cell_Layer and Cell_Column=@Cell_Column and Cell_Row=@Cell_Row and Cell_Chlid_ID=@Cell_Chlid_ID and Cell_Chlid_Position=@Cell_Chlid_Position and Cell_ID=@Cell_ID and Cell_Child_Order=@Cell_Child_Order and Cell_Child_InOut=@Cell_Child_InOut and Cell_Child_Model=@Cell_Child_Model and Cell_Child_Status=@Cell_Child_Status and Cell_Child_Run_Status=@Cell_Child_Run_Status and Cell_Child_Operate_Type=@Cell_Child_Operate_Type and Cell_Child_TaskLock_ID=@Cell_Child_TaskLock_ID and Cell_Child_Flag=@Cell_Child_Flag ");
            SqlParameter[] parameters = {
					new SqlParameter("@WareHouse_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Order", SqlDbType.Int,4),
					new SqlParameter("@Area_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_BackColor", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Lane", SqlDbType.NVarChar,50),
					new SqlParameter("@Device_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Shelf_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Storage_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Fork_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Layer", SqlDbType.Int,4),
					new SqlParameter("@Cell_Column", SqlDbType.Int,4),
					new SqlParameter("@Cell_Row", SqlDbType.Int,4),
					new SqlParameter("@Cell_Chlid_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Chlid_Position", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Order", SqlDbType.Int,4),
					new SqlParameter("@Cell_Child_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Run_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Operate_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_TaskLock_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Flag", SqlDbType.NVarChar,50)			};
            parameters[0].Value = WareHouse_Code;
            parameters[1].Value = WareHouse_Name;
            parameters[2].Value = WareHouse_Flag;
            parameters[3].Value = WareHouse_Type;
            parameters[4].Value = WareHouse_Remark;
            parameters[5].Value = WareHouse_ID;
            parameters[6].Value = Area_Type;
            parameters[7].Value = Area_Name;
            parameters[8].Value = Area_Code;
            parameters[9].Value = Area_Order;
            parameters[10].Value = Area_Flag;
            parameters[11].Value = Area_BackColor;
            parameters[12].Value = Area_ID;
            parameters[13].Value = Cell_Code;
            parameters[14].Value = Cell_Name;
            parameters[15].Value = Cell_Lane;
            parameters[16].Value = Device_Code;
            parameters[17].Value = Shelf_Type;
            parameters[18].Value = Cell_InOut;
            parameters[19].Value = Cell_Type;
            parameters[20].Value = Cell_Storage_Type;
            parameters[21].Value = Cell_Fork_Type;
            parameters[22].Value = Cell_Layer;
            parameters[23].Value = Cell_Column;
            parameters[24].Value = Cell_Row;
            parameters[25].Value = Cell_Chlid_ID;
            parameters[26].Value = Cell_Chlid_Position;
            parameters[27].Value = Cell_ID;
            parameters[28].Value = Cell_Child_Order;
            parameters[29].Value = Cell_Child_InOut;
            parameters[30].Value = Cell_Child_Model;
            parameters[31].Value = Cell_Child_Status;
            parameters[32].Value = Cell_Child_Run_Status;
            parameters[33].Value = Cell_Child_Operate_Type;
            parameters[34].Value = Cell_Child_TaskLock_ID;
            parameters[35].Value = Cell_Child_Flag;

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
        public WMS_Database.View_CellModel GetModel(string WareHouse_Code, string WareHouse_Name, string WareHouse_Flag, string WareHouse_Type, string WareHouse_Remark, string WareHouse_ID, string Area_Type, string Area_Name, string Area_Code, int Area_Order, string Area_Flag, string Area_BackColor, string Area_ID, string Cell_Code, string Cell_Name, string Cell_Lane, string Device_Code, string Shelf_Type, string Cell_InOut, string Cell_Type, string Cell_Storage_Type, string Cell_Fork_Type, int Cell_Layer, int Cell_Column, int Cell_Row, string Cell_Chlid_ID, string Cell_Chlid_Position, string Cell_ID, int Cell_Child_Order, string Cell_Child_InOut, string Cell_Child_Model, string Cell_Child_Status, string Cell_Child_Run_Status, string Cell_Child_Operate_Type, string Cell_Child_TaskLock_ID, string Cell_Child_Flag)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 WareHouse_Code,WareHouse_Name,WareHouse_Flag,WareHouse_Type,WareHouse_Remark,WareHouse_ID,Area_Type,Area_Name,Area_Code,Area_Order,Area_Flag,Area_BackColor,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Chlid_ID,Cell_Chlid_Position,Cell_ID,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Flag from View_Cell ");
            strSql.Append(" where WareHouse_Code=@WareHouse_Code and WareHouse_Name=@WareHouse_Name and WareHouse_Flag=@WareHouse_Flag and WareHouse_Type=@WareHouse_Type and WareHouse_Remark=@WareHouse_Remark and WareHouse_ID=@WareHouse_ID and Area_Type=@Area_Type and Area_Name=@Area_Name and Area_Code=@Area_Code and Area_Order=@Area_Order and Area_Flag=@Area_Flag and Area_BackColor=@Area_BackColor and Area_ID=@Area_ID and Cell_Code=@Cell_Code and Cell_Name=@Cell_Name and Cell_Lane=@Cell_Lane and Device_Code=@Device_Code and Shelf_Type=@Shelf_Type and Cell_InOut=@Cell_InOut and Cell_Type=@Cell_Type and Cell_Storage_Type=@Cell_Storage_Type and Cell_Fork_Type=@Cell_Fork_Type and Cell_Layer=@Cell_Layer and Cell_Column=@Cell_Column and Cell_Row=@Cell_Row and Cell_Chlid_ID=@Cell_Chlid_ID and Cell_Chlid_Position=@Cell_Chlid_Position and Cell_ID=@Cell_ID and Cell_Child_Order=@Cell_Child_Order and Cell_Child_InOut=@Cell_Child_InOut and Cell_Child_Model=@Cell_Child_Model and Cell_Child_Status=@Cell_Child_Status and Cell_Child_Run_Status=@Cell_Child_Run_Status and Cell_Child_Operate_Type=@Cell_Child_Operate_Type and Cell_Child_TaskLock_ID=@Cell_Child_TaskLock_ID and Cell_Child_Flag=@Cell_Child_Flag ");
            SqlParameter[] parameters = {
					new SqlParameter("@WareHouse_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@WareHouse_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_Order", SqlDbType.Int,4),
					new SqlParameter("@Area_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_BackColor", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Lane", SqlDbType.NVarChar,50),
					new SqlParameter("@Device_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Shelf_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Storage_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Fork_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Layer", SqlDbType.Int,4),
					new SqlParameter("@Cell_Column", SqlDbType.Int,4),
					new SqlParameter("@Cell_Row", SqlDbType.Int,4),
					new SqlParameter("@Cell_Chlid_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Chlid_Position", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Order", SqlDbType.Int,4),
					new SqlParameter("@Cell_Child_InOut", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Run_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Operate_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_TaskLock_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cell_Child_Flag", SqlDbType.NVarChar,50)			};
            parameters[0].Value = WareHouse_Code;
            parameters[1].Value = WareHouse_Name;
            parameters[2].Value = WareHouse_Flag;
            parameters[3].Value = WareHouse_Type;
            parameters[4].Value = WareHouse_Remark;
            parameters[5].Value = WareHouse_ID;
            parameters[6].Value = Area_Type;
            parameters[7].Value = Area_Name;
            parameters[8].Value = Area_Code;
            parameters[9].Value = Area_Order;
            parameters[10].Value = Area_Flag;
            parameters[11].Value = Area_BackColor;
            parameters[12].Value = Area_ID;
            parameters[13].Value = Cell_Code;
            parameters[14].Value = Cell_Name;
            parameters[15].Value = Cell_Lane;
            parameters[16].Value = Device_Code;
            parameters[17].Value = Shelf_Type;
            parameters[18].Value = Cell_InOut;
            parameters[19].Value = Cell_Type;
            parameters[20].Value = Cell_Storage_Type;
            parameters[21].Value = Cell_Fork_Type;
            parameters[22].Value = Cell_Layer;
            parameters[23].Value = Cell_Column;
            parameters[24].Value = Cell_Row;
            parameters[25].Value = Cell_Chlid_ID;
            parameters[26].Value = Cell_Chlid_Position;
            parameters[27].Value = Cell_ID;
            parameters[28].Value = Cell_Child_Order;
            parameters[29].Value = Cell_Child_InOut;
            parameters[30].Value = Cell_Child_Model;
            parameters[31].Value = Cell_Child_Status;
            parameters[32].Value = Cell_Child_Run_Status;
            parameters[33].Value = Cell_Child_Operate_Type;
            parameters[34].Value = Cell_Child_TaskLock_ID;
            parameters[35].Value = Cell_Child_Flag;

            WMS_Database.View_CellModel model = new WMS_Database.View_CellModel();
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
        public WMS_Database.View_CellModel DataRowToModel(DataRow row)
        {
            WMS_Database.View_CellModel model = new WMS_Database.View_CellModel();
            if (row != null)
            {
                if (row["WareHouse_Code"] != null)
                {
                    model.WareHouse_Code = row["WareHouse_Code"].ToString();
                }
                if (row["WareHouse_Name"] != null)
                {
                    model.WareHouse_Name = row["WareHouse_Name"].ToString();
                }
                if (row["WareHouse_Flag"] != null)
                {
                    model.WareHouse_Flag = row["WareHouse_Flag"].ToString();
                }
                if (row["WareHouse_Type"] != null)
                {
                    model.WareHouse_Type = row["WareHouse_Type"].ToString();
                }
                if (row["WareHouse_Remark"] != null)
                {
                    model.WareHouse_Remark = row["WareHouse_Remark"].ToString();
                }
                if (row["WareHouse_ID"] != null)
                {
                    model.WareHouse_ID = row["WareHouse_ID"].ToString();
                }
                if (row["Area_Type"] != null)
                {
                    model.Area_Type = row["Area_Type"].ToString();
                }
                if (row["Area_Name"] != null)
                {
                    model.Area_Name = row["Area_Name"].ToString();
                }
                if (row["Area_Code"] != null)
                {
                    model.Area_Code = row["Area_Code"].ToString();
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
                if (row["Cell_Column"] != null && row["Cell_Column"].ToString() != "")
                {
                    model.Cell_Column = int.Parse(row["Cell_Column"].ToString());
                }
                if (row["Cell_Row"] != null && row["Cell_Row"].ToString() != "")
                {
                    model.Cell_Row = int.Parse(row["Cell_Row"].ToString());
                }
                if (row["Cell_Chlid_ID"] != null)
                {
                    model.Cell_Chlid_ID = row["Cell_Chlid_ID"].ToString();
                }
                if (row["Cell_Chlid_Position"] != null)
                {
                    model.Cell_Chlid_Position = row["Cell_Chlid_Position"].ToString();
                }
                if (row["Cell_ID"] != null)
                {
                    model.Cell_ID = row["Cell_ID"].ToString();
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
                if (row["Cell_Child_Flag"] != null)
                {
                    model.Cell_Child_Flag = row["Cell_Child_Flag"].ToString();
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
            strSql.Append("select WareHouse_Code,WareHouse_Name,WareHouse_Flag,WareHouse_Type,WareHouse_Remark,WareHouse_ID,Area_Type,Area_Name,Area_Code,Area_Order,Area_Flag,Area_BackColor,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Chlid_ID,Cell_Chlid_Position,Cell_ID,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Flag ");
            strSql.Append(" FROM View_Cell ");
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
            strSql.Append(" WareHouse_Code,WareHouse_Name,WareHouse_Flag,WareHouse_Type,WareHouse_Remark,WareHouse_ID,Area_Type,Area_Name,Area_Code,Area_Order,Area_Flag,Area_BackColor,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Chlid_ID,Cell_Chlid_Position,Cell_ID,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Flag ");
            strSql.Append(" FROM View_Cell ");
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
            strSql.Append("select count(1) FROM View_Cell ");
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
                strSql.Append("order by T.Cell_Child_Flag desc");
            }
            strSql.Append(")AS Row, T.*  from View_Cell T ");
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
            parameters[0].Value = "View_Cell";
            parameters[1].Value = "Cell_Child_Flag";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
       public List<string> GetCellPositionType (string houseName,int rowth)
        {
            string sqlStr = "select distinct Cell_Chlid_Position, Cell_Child_Order from View_Cell where WareHouse_Name = '" + houseName + "' and Cell_Row =" + rowth
                + " order by Cell_Child_Order asc";

            DataSet ds = DbHelperSQL.Query(sqlStr);
            List<string> posList = new List<string>();
           if(ds!=null&&ds.Tables.Count>0)
           {
               for(int i=0;i<ds.Tables[0].Rows.Count;i++)
               {
                   string pos = ds.Tables[0].Rows[i][0].ToString();
                   posList.Add(pos);

               }
               return posList;
           }
           else
           {
               return null;
           }
        }
       
        #endregion  ExtensionMethod
    }
}

