using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:View_Goods
    /// </summary>
    public partial class View_GoodsDAL
    {
        public View_GoodsDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_Class_ID, string Goods_ID, string Goods_Code, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, string Goods_Remark, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Goods_Reserve3, string Goods_Reserve4, string Goods_Reserve5, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Reserve1, string Goods_Class_Flag, string Goods_Class_Reserve2, string Goods_Class_Reserve4, string Goods_Class_Reserve3, string Goods_Class_Reserve5, string Goods_Type, string Goods_Suppier_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_Goods");
            strSql.Append(" where Goods_Class_ID=@Goods_Class_ID and Goods_ID=@Goods_ID and Goods_Code=@Goods_Code and Goods_Name=@Goods_Name and Goods_Desc=@Goods_Desc and Goods_Model=@Goods_Model and Goods_Level=@Goods_Level and Goods_Unit=@Goods_Unit and Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity and Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity and Goods_Remark=@Goods_Remark and Goods_Order=@Goods_Order and Goods_Flag=@Goods_Flag and Goods_Danger=@Goods_Danger and Goods_Category=@Goods_Category and Goods_Asset=@Goods_Asset and Goods_Department=@Goods_Department and Goods_Reserve1=@Goods_Reserve1 and Goods_Reserve2=@Goods_Reserve2 and Goods_Reserve3=@Goods_Reserve3 and Goods_Reserve4=@Goods_Reserve4 and Goods_Reserve5=@Goods_Reserve5 and Goods_Class_Parent_ID=@Goods_Class_Parent_ID and Goods_Class_Code=@Goods_Class_Code and Goods_Class_Name=@Goods_Class_Name and Goods_Class_Remark=@Goods_Class_Remark and Goods_Class_Order=@Goods_Class_Order and Goods_Class_Reserve1=@Goods_Class_Reserve1 and Goods_Class_Flag=@Goods_Class_Flag and Goods_Class_Reserve2=@Goods_Class_Reserve2 and Goods_Class_Reserve4=@Goods_Class_Reserve4 and Goods_Class_Reserve3=@Goods_Class_Reserve3 and Goods_Class_Reserve5=@Goods_Class_Reserve5 and Goods_Type=@Goods_Type and Goods_Suppier_Code=@Goods_Suppier_Code ");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Goods_Class_ID;
            parameters[1].Value = Goods_ID;
            parameters[2].Value = Goods_Code;
            parameters[3].Value = Goods_Name;
            parameters[4].Value = Goods_Desc;
            parameters[5].Value = Goods_Model;
            parameters[6].Value = Goods_Level;
            parameters[7].Value = Goods_Unit;
            parameters[8].Value = Goods_Limit_Upper_Quantity;
            parameters[9].Value = Goods_Limit_Lower_Quantity;
            parameters[10].Value = Goods_Remark;
            parameters[11].Value = Goods_Order;
            parameters[12].Value = Goods_Flag;
            parameters[13].Value = Goods_Danger;
            parameters[14].Value = Goods_Category;
            parameters[15].Value = Goods_Asset;
            parameters[16].Value = Goods_Department;
            parameters[17].Value = Goods_Reserve1;
            parameters[18].Value = Goods_Reserve2;
            parameters[19].Value = Goods_Reserve3;
            parameters[20].Value = Goods_Reserve4;
            parameters[21].Value = Goods_Reserve5;
            parameters[22].Value = Goods_Class_Parent_ID;
            parameters[23].Value = Goods_Class_Code;
            parameters[24].Value = Goods_Class_Name;
            parameters[25].Value = Goods_Class_Remark;
            parameters[26].Value = Goods_Class_Order;
            parameters[27].Value = Goods_Class_Reserve1;
            parameters[28].Value = Goods_Class_Flag;
            parameters[29].Value = Goods_Class_Reserve2;
            parameters[30].Value = Goods_Class_Reserve4;
            parameters[31].Value = Goods_Class_Reserve3;
            parameters[32].Value = Goods_Class_Reserve5;
            parameters[33].Value = Goods_Type;
            parameters[34].Value = Goods_Suppier_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.View_GoodsModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into View_Goods(");
            strSql.Append("Goods_Class_ID,Goods_ID,Goods_Code,Goods_Name,Goods_Desc,Goods_Model,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Remark,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_Asset,Goods_Department,Goods_Reserve1,Goods_Reserve2,Goods_Reserve3,Goods_Reserve4,Goods_Reserve5,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Reserve1,Goods_Class_Flag,Goods_Class_Reserve2,Goods_Class_Reserve4,Goods_Class_Reserve3,Goods_Class_Reserve5,Goods_Type,Goods_Suppier_Code)");
            strSql.Append(" values (");
            strSql.Append("@Goods_Class_ID,@Goods_ID,@Goods_Code,@Goods_Name,@Goods_Desc,@Goods_Model,@Goods_Level,@Goods_Unit,@Goods_Limit_Upper_Quantity,@Goods_Limit_Lower_Quantity,@Goods_Remark,@Goods_Order,@Goods_Flag,@Goods_Danger,@Goods_Category,@Goods_Asset,@Goods_Department,@Goods_Reserve1,@Goods_Reserve2,@Goods_Reserve3,@Goods_Reserve4,@Goods_Reserve5,@Goods_Class_Parent_ID,@Goods_Class_Code,@Goods_Class_Name,@Goods_Class_Remark,@Goods_Class_Order,@Goods_Class_Reserve1,@Goods_Class_Flag,@Goods_Class_Reserve2,@Goods_Class_Reserve4,@Goods_Class_Reserve3,@Goods_Class_Reserve5,@Goods_Type,@Goods_Suppier_Code)");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Goods_Class_ID;
            parameters[1].Value = model.Goods_ID;
            parameters[2].Value = model.Goods_Code;
            parameters[3].Value = model.Goods_Name;
            parameters[4].Value = model.Goods_Desc;
            parameters[5].Value = model.Goods_Model;
            parameters[6].Value = model.Goods_Level;
            parameters[7].Value = model.Goods_Unit;
            parameters[8].Value = model.Goods_Limit_Upper_Quantity;
            parameters[9].Value = model.Goods_Limit_Lower_Quantity;
            parameters[10].Value = model.Goods_Remark;
            parameters[11].Value = model.Goods_Order;
            parameters[12].Value = model.Goods_Flag;
            parameters[13].Value = model.Goods_Danger;
            parameters[14].Value = model.Goods_Category;
            parameters[15].Value = model.Goods_Asset;
            parameters[16].Value = model.Goods_Department;
            parameters[17].Value = model.Goods_Reserve1;
            parameters[18].Value = model.Goods_Reserve2;
            parameters[19].Value = model.Goods_Reserve3;
            parameters[20].Value = model.Goods_Reserve4;
            parameters[21].Value = model.Goods_Reserve5;
            parameters[22].Value = model.Goods_Class_Parent_ID;
            parameters[23].Value = model.Goods_Class_Code;
            parameters[24].Value = model.Goods_Class_Name;
            parameters[25].Value = model.Goods_Class_Remark;
            parameters[26].Value = model.Goods_Class_Order;
            parameters[27].Value = model.Goods_Class_Reserve1;
            parameters[28].Value = model.Goods_Class_Flag;
            parameters[29].Value = model.Goods_Class_Reserve2;
            parameters[30].Value = model.Goods_Class_Reserve4;
            parameters[31].Value = model.Goods_Class_Reserve3;
            parameters[32].Value = model.Goods_Class_Reserve5;
            parameters[33].Value = model.Goods_Type;
            parameters[34].Value = model.Goods_Suppier_Code;

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
        public bool Update(WMS_Database.View_GoodsModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_Goods set ");
            strSql.Append("Goods_Class_ID=@Goods_Class_ID,");
            strSql.Append("Goods_ID=@Goods_ID,");
            strSql.Append("Goods_Code=@Goods_Code,");
            strSql.Append("Goods_Name=@Goods_Name,");
            strSql.Append("Goods_Desc=@Goods_Desc,");
            strSql.Append("Goods_Model=@Goods_Model,");
            strSql.Append("Goods_Level=@Goods_Level,");
            strSql.Append("Goods_Unit=@Goods_Unit,");
            strSql.Append("Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity,");
            strSql.Append("Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity,");
            strSql.Append("Goods_Remark=@Goods_Remark,");
            strSql.Append("Goods_Order=@Goods_Order,");
            strSql.Append("Goods_Flag=@Goods_Flag,");
            strSql.Append("Goods_Danger=@Goods_Danger,");
            strSql.Append("Goods_Category=@Goods_Category,");
            strSql.Append("Goods_Asset=@Goods_Asset,");
            strSql.Append("Goods_Department=@Goods_Department,");
            strSql.Append("Goods_Reserve1=@Goods_Reserve1,");
            strSql.Append("Goods_Reserve2=@Goods_Reserve2,");
            strSql.Append("Goods_Reserve3=@Goods_Reserve3,");
            strSql.Append("Goods_Reserve4=@Goods_Reserve4,");
            strSql.Append("Goods_Reserve5=@Goods_Reserve5,");
            strSql.Append("Goods_Class_Parent_ID=@Goods_Class_Parent_ID,");
            strSql.Append("Goods_Class_Code=@Goods_Class_Code,");
            strSql.Append("Goods_Class_Name=@Goods_Class_Name,");
            strSql.Append("Goods_Class_Remark=@Goods_Class_Remark,");
            strSql.Append("Goods_Class_Order=@Goods_Class_Order,");
            strSql.Append("Goods_Class_Reserve1=@Goods_Class_Reserve1,");
            strSql.Append("Goods_Class_Flag=@Goods_Class_Flag,");
            strSql.Append("Goods_Class_Reserve2=@Goods_Class_Reserve2,");
            strSql.Append("Goods_Class_Reserve4=@Goods_Class_Reserve4,");
            strSql.Append("Goods_Class_Reserve3=@Goods_Class_Reserve3,");
            strSql.Append("Goods_Class_Reserve5=@Goods_Class_Reserve5,");
            strSql.Append("Goods_Type=@Goods_Type,");
            strSql.Append("Goods_Suppier_Code=@Goods_Suppier_Code");
            strSql.Append(" where Goods_Class_ID=@Goods_Class_ID and Goods_ID=@Goods_ID and Goods_Code=@Goods_Code and Goods_Name=@Goods_Name and Goods_Desc=@Goods_Desc and Goods_Model=@Goods_Model and Goods_Level=@Goods_Level and Goods_Unit=@Goods_Unit and Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity and Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity and Goods_Remark=@Goods_Remark and Goods_Order=@Goods_Order and Goods_Flag=@Goods_Flag and Goods_Danger=@Goods_Danger and Goods_Category=@Goods_Category and Goods_Asset=@Goods_Asset and Goods_Department=@Goods_Department and Goods_Reserve1=@Goods_Reserve1 and Goods_Reserve2=@Goods_Reserve2 and Goods_Reserve3=@Goods_Reserve3 and Goods_Reserve4=@Goods_Reserve4 and Goods_Reserve5=@Goods_Reserve5 and Goods_Class_Parent_ID=@Goods_Class_Parent_ID and Goods_Class_Code=@Goods_Class_Code and Goods_Class_Name=@Goods_Class_Name and Goods_Class_Remark=@Goods_Class_Remark and Goods_Class_Order=@Goods_Class_Order and Goods_Class_Reserve1=@Goods_Class_Reserve1 and Goods_Class_Flag=@Goods_Class_Flag and Goods_Class_Reserve2=@Goods_Class_Reserve2 and Goods_Class_Reserve4=@Goods_Class_Reserve4 and Goods_Class_Reserve3=@Goods_Class_Reserve3 and Goods_Class_Reserve5=@Goods_Class_Reserve5 and Goods_Type=@Goods_Type and Goods_Suppier_Code=@Goods_Suppier_Code ");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Goods_Class_ID;
            parameters[1].Value = model.Goods_ID;
            parameters[2].Value = model.Goods_Code;
            parameters[3].Value = model.Goods_Name;
            parameters[4].Value = model.Goods_Desc;
            parameters[5].Value = model.Goods_Model;
            parameters[6].Value = model.Goods_Level;
            parameters[7].Value = model.Goods_Unit;
            parameters[8].Value = model.Goods_Limit_Upper_Quantity;
            parameters[9].Value = model.Goods_Limit_Lower_Quantity;
            parameters[10].Value = model.Goods_Remark;
            parameters[11].Value = model.Goods_Order;
            parameters[12].Value = model.Goods_Flag;
            parameters[13].Value = model.Goods_Danger;
            parameters[14].Value = model.Goods_Category;
            parameters[15].Value = model.Goods_Asset;
            parameters[16].Value = model.Goods_Department;
            parameters[17].Value = model.Goods_Reserve1;
            parameters[18].Value = model.Goods_Reserve2;
            parameters[19].Value = model.Goods_Reserve3;
            parameters[20].Value = model.Goods_Reserve4;
            parameters[21].Value = model.Goods_Reserve5;
            parameters[22].Value = model.Goods_Class_Parent_ID;
            parameters[23].Value = model.Goods_Class_Code;
            parameters[24].Value = model.Goods_Class_Name;
            parameters[25].Value = model.Goods_Class_Remark;
            parameters[26].Value = model.Goods_Class_Order;
            parameters[27].Value = model.Goods_Class_Reserve1;
            parameters[28].Value = model.Goods_Class_Flag;
            parameters[29].Value = model.Goods_Class_Reserve2;
            parameters[30].Value = model.Goods_Class_Reserve4;
            parameters[31].Value = model.Goods_Class_Reserve3;
            parameters[32].Value = model.Goods_Class_Reserve5;
            parameters[33].Value = model.Goods_Type;
            parameters[34].Value = model.Goods_Suppier_Code;

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
        public bool Delete(string Goods_Class_ID, string Goods_ID, string Goods_Code, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, string Goods_Remark, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Goods_Reserve3, string Goods_Reserve4, string Goods_Reserve5, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Reserve1, string Goods_Class_Flag, string Goods_Class_Reserve2, string Goods_Class_Reserve4, string Goods_Class_Reserve3, string Goods_Class_Reserve5, string Goods_Type, string Goods_Suppier_Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_Goods ");
            strSql.Append(" where Goods_Class_ID=@Goods_Class_ID and Goods_ID=@Goods_ID and Goods_Code=@Goods_Code and Goods_Name=@Goods_Name and Goods_Desc=@Goods_Desc and Goods_Model=@Goods_Model and Goods_Level=@Goods_Level and Goods_Unit=@Goods_Unit and Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity and Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity and Goods_Remark=@Goods_Remark and Goods_Order=@Goods_Order and Goods_Flag=@Goods_Flag and Goods_Danger=@Goods_Danger and Goods_Category=@Goods_Category and Goods_Asset=@Goods_Asset and Goods_Department=@Goods_Department and Goods_Reserve1=@Goods_Reserve1 and Goods_Reserve2=@Goods_Reserve2 and Goods_Reserve3=@Goods_Reserve3 and Goods_Reserve4=@Goods_Reserve4 and Goods_Reserve5=@Goods_Reserve5 and Goods_Class_Parent_ID=@Goods_Class_Parent_ID and Goods_Class_Code=@Goods_Class_Code and Goods_Class_Name=@Goods_Class_Name and Goods_Class_Remark=@Goods_Class_Remark and Goods_Class_Order=@Goods_Class_Order and Goods_Class_Reserve1=@Goods_Class_Reserve1 and Goods_Class_Flag=@Goods_Class_Flag and Goods_Class_Reserve2=@Goods_Class_Reserve2 and Goods_Class_Reserve4=@Goods_Class_Reserve4 and Goods_Class_Reserve3=@Goods_Class_Reserve3 and Goods_Class_Reserve5=@Goods_Class_Reserve5 and Goods_Type=@Goods_Type and Goods_Suppier_Code=@Goods_Suppier_Code ");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Goods_Class_ID;
            parameters[1].Value = Goods_ID;
            parameters[2].Value = Goods_Code;
            parameters[3].Value = Goods_Name;
            parameters[4].Value = Goods_Desc;
            parameters[5].Value = Goods_Model;
            parameters[6].Value = Goods_Level;
            parameters[7].Value = Goods_Unit;
            parameters[8].Value = Goods_Limit_Upper_Quantity;
            parameters[9].Value = Goods_Limit_Lower_Quantity;
            parameters[10].Value = Goods_Remark;
            parameters[11].Value = Goods_Order;
            parameters[12].Value = Goods_Flag;
            parameters[13].Value = Goods_Danger;
            parameters[14].Value = Goods_Category;
            parameters[15].Value = Goods_Asset;
            parameters[16].Value = Goods_Department;
            parameters[17].Value = Goods_Reserve1;
            parameters[18].Value = Goods_Reserve2;
            parameters[19].Value = Goods_Reserve3;
            parameters[20].Value = Goods_Reserve4;
            parameters[21].Value = Goods_Reserve5;
            parameters[22].Value = Goods_Class_Parent_ID;
            parameters[23].Value = Goods_Class_Code;
            parameters[24].Value = Goods_Class_Name;
            parameters[25].Value = Goods_Class_Remark;
            parameters[26].Value = Goods_Class_Order;
            parameters[27].Value = Goods_Class_Reserve1;
            parameters[28].Value = Goods_Class_Flag;
            parameters[29].Value = Goods_Class_Reserve2;
            parameters[30].Value = Goods_Class_Reserve4;
            parameters[31].Value = Goods_Class_Reserve3;
            parameters[32].Value = Goods_Class_Reserve5;
            parameters[33].Value = Goods_Type;
            parameters[34].Value = Goods_Suppier_Code;

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
        public WMS_Database.View_GoodsModel GetModel(string Goods_Class_ID, string Goods_ID, string Goods_Code, string Goods_Name, string Goods_Desc, string Goods_Model, string Goods_Level, string Goods_Unit, string Goods_Limit_Upper_Quantity, string Goods_Limit_Lower_Quantity, string Goods_Remark, int Goods_Order, string Goods_Flag, string Goods_Danger, string Goods_Category, string Goods_Asset, string Goods_Department, string Goods_Reserve1, string Goods_Reserve2, string Goods_Reserve3, string Goods_Reserve4, string Goods_Reserve5, string Goods_Class_Parent_ID, string Goods_Class_Code, string Goods_Class_Name, string Goods_Class_Remark, int Goods_Class_Order, string Goods_Class_Reserve1, string Goods_Class_Flag, string Goods_Class_Reserve2, string Goods_Class_Reserve4, string Goods_Class_Reserve3, string Goods_Class_Reserve5, string Goods_Type, string Goods_Suppier_Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Goods_Class_ID,Goods_ID,Goods_Code,Goods_Name,Goods_Desc,Goods_Model,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Remark,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_Asset,Goods_Department,Goods_Reserve1,Goods_Reserve2,Goods_Reserve3,Goods_Reserve4,Goods_Reserve5,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Reserve1,Goods_Class_Flag,Goods_Class_Reserve2,Goods_Class_Reserve4,Goods_Class_Reserve3,Goods_Class_Reserve5,Goods_Type,Goods_Suppier_Code from View_Goods ");
            strSql.Append(" where Goods_Class_ID=@Goods_Class_ID and Goods_ID=@Goods_ID and Goods_Code=@Goods_Code and Goods_Name=@Goods_Name and Goods_Desc=@Goods_Desc and Goods_Model=@Goods_Model and Goods_Level=@Goods_Level and Goods_Unit=@Goods_Unit and Goods_Limit_Upper_Quantity=@Goods_Limit_Upper_Quantity and Goods_Limit_Lower_Quantity=@Goods_Limit_Lower_Quantity and Goods_Remark=@Goods_Remark and Goods_Order=@Goods_Order and Goods_Flag=@Goods_Flag and Goods_Danger=@Goods_Danger and Goods_Category=@Goods_Category and Goods_Asset=@Goods_Asset and Goods_Department=@Goods_Department and Goods_Reserve1=@Goods_Reserve1 and Goods_Reserve2=@Goods_Reserve2 and Goods_Reserve3=@Goods_Reserve3 and Goods_Reserve4=@Goods_Reserve4 and Goods_Reserve5=@Goods_Reserve5 and Goods_Class_Parent_ID=@Goods_Class_Parent_ID and Goods_Class_Code=@Goods_Class_Code and Goods_Class_Name=@Goods_Class_Name and Goods_Class_Remark=@Goods_Class_Remark and Goods_Class_Order=@Goods_Class_Order and Goods_Class_Reserve1=@Goods_Class_Reserve1 and Goods_Class_Flag=@Goods_Class_Flag and Goods_Class_Reserve2=@Goods_Class_Reserve2 and Goods_Class_Reserve4=@Goods_Class_Reserve4 and Goods_Class_Reserve3=@Goods_Class_Reserve3 and Goods_Class_Reserve5=@Goods_Class_Reserve5 and Goods_Type=@Goods_Type and Goods_Suppier_Code=@Goods_Suppier_Code ");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Class_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Desc", SqlDbType.NVarChar,500),
					new SqlParameter("@Goods_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Level", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Upper_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Limit_Lower_Quantity", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@Goods_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Danger", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Category", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Asset", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Department", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Parent_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Order", SqlDbType.Int,4),
					new SqlParameter("@Goods_Class_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Class_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Suppier_Code", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Goods_Class_ID;
            parameters[1].Value = Goods_ID;
            parameters[2].Value = Goods_Code;
            parameters[3].Value = Goods_Name;
            parameters[4].Value = Goods_Desc;
            parameters[5].Value = Goods_Model;
            parameters[6].Value = Goods_Level;
            parameters[7].Value = Goods_Unit;
            parameters[8].Value = Goods_Limit_Upper_Quantity;
            parameters[9].Value = Goods_Limit_Lower_Quantity;
            parameters[10].Value = Goods_Remark;
            parameters[11].Value = Goods_Order;
            parameters[12].Value = Goods_Flag;
            parameters[13].Value = Goods_Danger;
            parameters[14].Value = Goods_Category;
            parameters[15].Value = Goods_Asset;
            parameters[16].Value = Goods_Department;
            parameters[17].Value = Goods_Reserve1;
            parameters[18].Value = Goods_Reserve2;
            parameters[19].Value = Goods_Reserve3;
            parameters[20].Value = Goods_Reserve4;
            parameters[21].Value = Goods_Reserve5;
            parameters[22].Value = Goods_Class_Parent_ID;
            parameters[23].Value = Goods_Class_Code;
            parameters[24].Value = Goods_Class_Name;
            parameters[25].Value = Goods_Class_Remark;
            parameters[26].Value = Goods_Class_Order;
            parameters[27].Value = Goods_Class_Reserve1;
            parameters[28].Value = Goods_Class_Flag;
            parameters[29].Value = Goods_Class_Reserve2;
            parameters[30].Value = Goods_Class_Reserve4;
            parameters[31].Value = Goods_Class_Reserve3;
            parameters[32].Value = Goods_Class_Reserve5;
            parameters[33].Value = Goods_Type;
            parameters[34].Value = Goods_Suppier_Code;

            WMS_Database.View_GoodsModel model = new WMS_Database.View_GoodsModel();
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
        public WMS_Database.View_GoodsModel DataRowToModel(DataRow row)
        {
            WMS_Database.View_GoodsModel model = new WMS_Database.View_GoodsModel();
            if (row != null)
            {
                if (row["Goods_Class_ID"] != null)
                {
                    model.Goods_Class_ID = row["Goods_Class_ID"].ToString();
                }
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
                }
                if (row["Goods_Code"] != null)
                {
                    model.Goods_Code = row["Goods_Code"].ToString();
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
                if (row["Goods_Remark"] != null)
                {
                    model.Goods_Remark = row["Goods_Remark"].ToString();
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
                if (row["Goods_Reserve3"] != null)
                {
                    model.Goods_Reserve3 = row["Goods_Reserve3"].ToString();
                }
                if (row["Goods_Reserve4"] != null)
                {
                    model.Goods_Reserve4 = row["Goods_Reserve4"].ToString();
                }
                if (row["Goods_Reserve5"] != null)
                {
                    model.Goods_Reserve5 = row["Goods_Reserve5"].ToString();
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
                if (row["Goods_Class_Reserve1"] != null)
                {
                    model.Goods_Class_Reserve1 = row["Goods_Class_Reserve1"].ToString();
                }
                if (row["Goods_Class_Flag"] != null)
                {
                    model.Goods_Class_Flag = row["Goods_Class_Flag"].ToString();
                }
                if (row["Goods_Class_Reserve2"] != null)
                {
                    model.Goods_Class_Reserve2 = row["Goods_Class_Reserve2"].ToString();
                }
                if (row["Goods_Class_Reserve4"] != null)
                {
                    model.Goods_Class_Reserve4 = row["Goods_Class_Reserve4"].ToString();
                }
                if (row["Goods_Class_Reserve3"] != null)
                {
                    model.Goods_Class_Reserve3 = row["Goods_Class_Reserve3"].ToString();
                }
                if (row["Goods_Class_Reserve5"] != null)
                {
                    model.Goods_Class_Reserve5 = row["Goods_Class_Reserve5"].ToString();
                }
                if (row["Goods_Type"] != null)
                {
                    model.Goods_Type = row["Goods_Type"].ToString();
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
            strSql.Append("select Goods_Class_ID,Goods_ID,Goods_Code,Goods_Name,Goods_Desc,Goods_Model,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Remark,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_Asset,Goods_Department,Goods_Reserve1,Goods_Reserve2,Goods_Reserve3,Goods_Reserve4,Goods_Reserve5,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Reserve1,Goods_Class_Flag,Goods_Class_Reserve2,Goods_Class_Reserve4,Goods_Class_Reserve3,Goods_Class_Reserve5,Goods_Type,Goods_Suppier_Code ");
            strSql.Append(" FROM View_Goods ");
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
            strSql.Append(" Goods_Class_ID,Goods_ID,Goods_Code,Goods_Name,Goods_Desc,Goods_Model,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Remark,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_Asset,Goods_Department,Goods_Reserve1,Goods_Reserve2,Goods_Reserve3,Goods_Reserve4,Goods_Reserve5,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Reserve1,Goods_Class_Flag,Goods_Class_Reserve2,Goods_Class_Reserve4,Goods_Class_Reserve3,Goods_Class_Reserve5,Goods_Type,Goods_Suppier_Code ");
            strSql.Append(" FROM View_Goods ");
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
            strSql.Append("select count(1) FROM View_Goods ");
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
            strSql.Append(")AS Row, T.*  from View_Goods T ");
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
            parameters[0].Value = "View_Goods";
            parameters[1].Value = "Goods_Suppier_Code";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

