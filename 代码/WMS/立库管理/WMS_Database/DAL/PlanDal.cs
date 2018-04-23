using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
//using Maticsoft.DBUtility;//Please add references
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:PlanDal
	/// </summary>
	public partial class PlanDal
	{
        public PlanDal()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Plan_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PlanMain");
            strSql.Append(" where Plan_ID=@Plan_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Plan_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.PlanMainModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PlanMain(");
            strSql.Append("Plan_ID,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_Begin_Time,Plan_End_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Plan_Reserve1,Plan_Reserve2,Plan_Reserve3,Plan_Reserve4,Plan_Reserve5)");
            strSql.Append(" values (");
            strSql.Append("@Plan_ID,@Plan_Type_ID,@Plan_Serial_Num,@Plan_Code,@Plan_Create_Time,@Plan_Begin_Time,@Plan_End_Time,@Plan_Bill_Time,@Plan_Status,@Plan_Operater,@Plan_From_Dept,@Plan_To_Dept,@Plan_From_User,@Plan_To_User,@Plan_Import_Flag,@Plan_Remark,@Plan_Reserve1,@Plan_Reserve2,@Plan_Reserve3,@Plan_Reserve4,@Plan_Reserve5)");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50),
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
					new SqlParameter("@Plan_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Reserve5", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Plan_ID;
            parameters[1].Value = model.Plan_Type_ID;
            parameters[2].Value = model.Plan_Serial_Num;
            parameters[3].Value = model.Plan_Code;
            parameters[4].Value = model.Plan_Create_Time;
            parameters[5].Value = model.Plan_Begin_Time;
            parameters[6].Value = model.Plan_End_Time;
            parameters[7].Value = model.Plan_Bill_Time;
            parameters[8].Value = model.Plan_Status;
            parameters[9].Value = model.Plan_Operater;
            parameters[10].Value = model.Plan_From_Dept;
            parameters[11].Value = model.Plan_To_Dept;
            parameters[12].Value = model.Plan_From_User;
            parameters[13].Value = model.Plan_To_User;
            parameters[14].Value = model.Plan_Import_Flag;
            parameters[15].Value = model.Plan_Remark;
            parameters[16].Value = model.Plan_Reserve1;
            parameters[17].Value = model.Plan_Reserve2;
            parameters[18].Value = model.Plan_Reserve3;
            parameters[19].Value = model.Plan_Reserve4;
            parameters[20].Value = model.Plan_Reserve5;

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
        public bool Update(WMS_Database.PlanMainModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PlanMain set ");
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
            strSql.Append("Plan_Reserve1=@Plan_Reserve1,");
            strSql.Append("Plan_Reserve2=@Plan_Reserve2,");
            strSql.Append("Plan_Reserve3=@Plan_Reserve3,");
            strSql.Append("Plan_Reserve4=@Plan_Reserve4,");
            strSql.Append("Plan_Reserve5=@Plan_Reserve5");
            strSql.Append(" where Plan_ID=@Plan_ID ");
            SqlParameter[] parameters = {
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
					new SqlParameter("@Plan_Reserve1", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Reserve2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Reserve3", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Reserve4", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_Reserve5", SqlDbType.NVarChar,50),
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Plan_Type_ID;
            parameters[1].Value = model.Plan_Serial_Num;
            parameters[2].Value = model.Plan_Code;
            parameters[3].Value = model.Plan_Create_Time;
            parameters[4].Value = model.Plan_Begin_Time;
            parameters[5].Value = model.Plan_End_Time;
            parameters[6].Value = model.Plan_Bill_Time;
            parameters[7].Value = model.Plan_Status;
            parameters[8].Value = model.Plan_Operater;
            parameters[9].Value = model.Plan_From_Dept;
            parameters[10].Value = model.Plan_To_Dept;
            parameters[11].Value = model.Plan_From_User;
            parameters[12].Value = model.Plan_To_User;
            parameters[13].Value = model.Plan_Import_Flag;
            parameters[14].Value = model.Plan_Remark;
            parameters[15].Value = model.Plan_Reserve1;
            parameters[16].Value = model.Plan_Reserve2;
            parameters[17].Value = model.Plan_Reserve3;
            parameters[18].Value = model.Plan_Reserve4;
            parameters[19].Value = model.Plan_Reserve5;
            parameters[20].Value = model.Plan_ID;

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
        public bool Delete(string Plan_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PlanMain ");
            strSql.Append(" where Plan_ID=@Plan_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Plan_ID;

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
        public bool DeleteList(string Plan_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PlanMain ");
            strSql.Append(" where Plan_ID in (" + Plan_IDlist + ")  ");
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
        public WMS_Database.PlanMainModel GetModel(string Plan_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Plan_ID,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_Begin_Time,Plan_End_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Plan_Reserve1,Plan_Reserve2,Plan_Reserve3,Plan_Reserve4,Plan_Reserve5 from PlanMain ");
            strSql.Append(" where Plan_ID=@Plan_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Plan_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Plan_ID;

            WMS_Database.PlanMainModel model = new WMS_Database.PlanMainModel();
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
        public WMS_Database.PlanMainModel DataRowToModel(DataRow row)
        {
            WMS_Database.PlanMainModel model = new WMS_Database.PlanMainModel();
            if (row != null)
            {
                if (row["Plan_ID"] != null)
                {
                    model.Plan_ID = row["Plan_ID"].ToString();
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
                if (row["Plan_Reserve1"] != null)
                {
                    model.Plan_Reserve1 = row["Plan_Reserve1"].ToString();
                }
                if (row["Plan_Reserve2"] != null)
                {
                    model.Plan_Reserve2 = row["Plan_Reserve2"].ToString();
                }
                if (row["Plan_Reserve3"] != null)
                {
                    model.Plan_Reserve3 = row["Plan_Reserve3"].ToString();
                }
                if (row["Plan_Reserve4"] != null)
                {
                    model.Plan_Reserve4 = row["Plan_Reserve4"].ToString();
                }
                if (row["Plan_Reserve5"] != null)
                {
                    model.Plan_Reserve5 = row["Plan_Reserve5"].ToString();
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
            strSql.Append("select Plan_ID,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_Begin_Time,Plan_End_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Plan_Reserve1,Plan_Reserve2,Plan_Reserve3,Plan_Reserve4,Plan_Reserve5 ");
            strSql.Append(" FROM PlanMain ");
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
            strSql.Append(" Plan_ID,Plan_Type_ID,Plan_Serial_Num,Plan_Code,Plan_Create_Time,Plan_Begin_Time,Plan_End_Time,Plan_Bill_Time,Plan_Status,Plan_Operater,Plan_From_Dept,Plan_To_Dept,Plan_From_User,Plan_To_User,Plan_Import_Flag,Plan_Remark,Plan_Reserve1,Plan_Reserve2,Plan_Reserve3,Plan_Reserve4,Plan_Reserve5 ");
            strSql.Append(" FROM PlanMain ");
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
            strSql.Append("select count(1) FROM PlanMain ");
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
                strSql.Append("order by T.Plan_ID desc");
            }
            strSql.Append(")AS Row, T.*  from PlanMain T ");
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
            parameters[0].Value = "PlanMain";
            parameters[1].Value = "Plan_ID";
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

