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
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Mange_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Manage");
            strSql.Append(" where Mange_ID=@Mange_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Mange_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Mange_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.ManageModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Manage(");
            strSql.Append("Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Mange_CreateTime,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_Reserve1,Mange_Reserve2,Mange_Reserve3,Mange_Reserve4,Mange_Reserve5)");
            strSql.Append(" values (");
            strSql.Append("@Mange_ID,@Plan_ID,@Mange_Type_ID,@Mange_Status,@Mange_Stock_Barcode,@Mange_Full_Flag,@Manage_BreakDown_Status,@Mange_Start_Cell_ID,@Mange_End_Cell_ID,@Manage_Operater,@Mange_CreateTime,@Manage_Begin_Time,@Manage_End_Time,@Manage_Remark,@Mange_Reserve1,@Mange_Reserve2,@Mange_Reserve3,@Mange_Reserve4,@Mange_Reserve5)");
            SqlParameter[] parameters = {
					new SqlParameter("@Mange_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Type_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Stock_Barcode", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Full_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Manage_BreakDown_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Start_Cell_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_End_Cell_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Manage_Operater", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Manage_Begin_Time", SqlDbType.DateTime),
					new SqlParameter("@Manage_End_Time", SqlDbType.DateTime),
					new SqlParameter("@Manage_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Reserve1", SqlDbType.NVarChar,100),
					new SqlParameter("@Mange_Reserve2", SqlDbType.NVarChar,100),
					new SqlParameter("@Mange_Reserve3", SqlDbType.NVarChar,100),
					new SqlParameter("@Mange_Reserve4", SqlDbType.NVarChar,100),
					new SqlParameter("@Mange_Reserve5", SqlDbType.NVarChar,100)};
            parameters[0].Value = model.Mange_ID;
            parameters[1].Value = model.Plan_ID;
            parameters[2].Value = model.Mange_Type_ID;
            parameters[3].Value = model.Mange_Status;
            parameters[4].Value = model.Mange_Stock_Barcode;
            parameters[5].Value = model.Mange_Full_Flag;
            parameters[6].Value = model.Manage_BreakDown_Status;
            parameters[7].Value = model.Mange_Start_Cell_ID;
            parameters[8].Value = model.Mange_End_Cell_ID;
            parameters[9].Value = model.Manage_Operater;
            parameters[10].Value = model.Mange_CreateTime;
            parameters[11].Value = model.Manage_Begin_Time;
            parameters[12].Value = model.Manage_End_Time;
            parameters[13].Value = model.Manage_Remark;
            parameters[14].Value = model.Mange_Reserve1;
            parameters[15].Value = model.Mange_Reserve2;
            parameters[16].Value = model.Mange_Reserve3;
            parameters[17].Value = model.Mange_Reserve4;
            parameters[18].Value = model.Mange_Reserve5;

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
        public bool Update(WMS_Database.ManageModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Manage set ");
            strSql.Append("Plan_ID=@Plan_ID,");
            strSql.Append("Mange_Type_ID=@Mange_Type_ID,");
            strSql.Append("Mange_Status=@Mange_Status,");
            strSql.Append("Mange_Stock_Barcode=@Mange_Stock_Barcode,");
            strSql.Append("Mange_Full_Flag=@Mange_Full_Flag,");
            strSql.Append("Manage_BreakDown_Status=@Manage_BreakDown_Status,");
            strSql.Append("Mange_Start_Cell_ID=@Mange_Start_Cell_ID,");
            strSql.Append("Mange_End_Cell_ID=@Mange_End_Cell_ID,");
            strSql.Append("Manage_Operater=@Manage_Operater,");
            strSql.Append("Mange_CreateTime=@Mange_CreateTime,");
            strSql.Append("Manage_Begin_Time=@Manage_Begin_Time,");
            strSql.Append("Manage_End_Time=@Manage_End_Time,");
            strSql.Append("Manage_Remark=@Manage_Remark,");
            strSql.Append("Mange_Reserve1=@Mange_Reserve1,");
            strSql.Append("Mange_Reserve2=@Mange_Reserve2,");
            strSql.Append("Mange_Reserve3=@Mange_Reserve3,");
            strSql.Append("Mange_Reserve4=@Mange_Reserve4,");
            strSql.Append("Mange_Reserve5=@Mange_Reserve5");
            strSql.Append(" where Mange_ID=@Mange_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Type_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Stock_Barcode", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Full_Flag", SqlDbType.NVarChar,50),
					new SqlParameter("@Manage_BreakDown_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Start_Cell_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_End_Cell_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Manage_Operater", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Manage_Begin_Time", SqlDbType.DateTime),
					new SqlParameter("@Manage_End_Time", SqlDbType.DateTime),
					new SqlParameter("@Manage_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Mange_Reserve1", SqlDbType.NVarChar,100),
					new SqlParameter("@Mange_Reserve2", SqlDbType.NVarChar,100),
					new SqlParameter("@Mange_Reserve3", SqlDbType.NVarChar,100),
					new SqlParameter("@Mange_Reserve4", SqlDbType.NVarChar,100),
					new SqlParameter("@Mange_Reserve5", SqlDbType.NVarChar,100),
					new SqlParameter("@Mange_ID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Plan_ID;
            parameters[1].Value = model.Mange_Type_ID;
            parameters[2].Value = model.Mange_Status;
            parameters[3].Value = model.Mange_Stock_Barcode;
            parameters[4].Value = model.Mange_Full_Flag;
            parameters[5].Value = model.Manage_BreakDown_Status;
            parameters[6].Value = model.Mange_Start_Cell_ID;
            parameters[7].Value = model.Mange_End_Cell_ID;
            parameters[8].Value = model.Manage_Operater;
            parameters[9].Value = model.Mange_CreateTime;
            parameters[10].Value = model.Manage_Begin_Time;
            parameters[11].Value = model.Manage_End_Time;
            parameters[12].Value = model.Manage_Remark;
            parameters[13].Value = model.Mange_Reserve1;
            parameters[14].Value = model.Mange_Reserve2;
            parameters[15].Value = model.Mange_Reserve3;
            parameters[16].Value = model.Mange_Reserve4;
            parameters[17].Value = model.Mange_Reserve5;
            parameters[18].Value = model.Mange_ID;

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
        public bool Delete(string Mange_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Manage ");
            strSql.Append(" where Mange_ID=@Mange_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Mange_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Mange_ID;

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
            strSql.Append("select  top 1 Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Mange_CreateTime,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_Reserve1,Mange_Reserve2,Mange_Reserve3,Mange_Reserve4,Mange_Reserve5 from Manage ");
            strSql.Append(" where Mange_ID=@Mange_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Mange_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Mange_ID;

            WMS_Database.ManageModel model = new WMS_Database.ManageModel();
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
                if (row["Mange_CreateTime"] != null && row["Mange_CreateTime"].ToString() != "")
                {
                    model.Mange_CreateTime = DateTime.Parse(row["Mange_CreateTime"].ToString());
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
            strSql.Append("select Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Mange_CreateTime,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_Reserve1,Mange_Reserve2,Mange_Reserve3,Mange_Reserve4,Mange_Reserve5 ");
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
            strSql.Append(" Mange_ID,Plan_ID,Mange_Type_ID,Mange_Status,Mange_Stock_Barcode,Mange_Full_Flag,Manage_BreakDown_Status,Mange_Start_Cell_ID,Mange_End_Cell_ID,Manage_Operater,Mange_CreateTime,Manage_Begin_Time,Manage_End_Time,Manage_Remark,Mange_Reserve1,Mange_Reserve2,Mange_Reserve3,Mange_Reserve4,Mange_Reserve5 ");
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
            parameters[0].Value = "Manage";
            parameters[1].Value = "Mange_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
		#region  ExtensionMethod

          
        public bool DeleteManage(int days)
        {
           
            StringBuilder strSql = new StringBuilder();
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            strSql.Append("delete from Manage ");
            strSql.Append(" where datediff(day,Mange_CreateTime,'" + nowTime + "') >= " + days);

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

