using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:Goods_Unit
    /// </summary>
    public partial class Goods_UnitDAL
    {
        public Goods_UnitDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_Unit_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Goods_Unit");
            strSql.Append(" where Goods_Unit_ID=@Goods_Unit_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Unit_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Goods_Unit_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Goods_UnitModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Goods_Unit(");
            strSql.Append("Goods_Unit_ID,Goods_Unit_Name,Goods_Unit_Code,Goods_Unit_Remark)");
            strSql.Append(" values (");
            strSql.Append("@Goods_Unit_ID,@Goods_Unit_Name,@Goods_Unit_Code,@Goods_Unit_Remark)");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Unit_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit_Remark", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Goods_Unit_ID;
            parameters[1].Value = model.Goods_Unit_Name;
            parameters[2].Value = model.Goods_Unit_Code;
            parameters[3].Value = model.Goods_Unit_Remark;

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
        public bool Update(WMS_Database.Goods_UnitModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Goods_Unit set ");
            strSql.Append("Goods_Unit_Name=@Goods_Unit_Name,");
            strSql.Append("Goods_Unit_Code=@Goods_Unit_Code,");
            strSql.Append("Goods_Unit_Remark=@Goods_Unit_Remark");
            strSql.Append(" where Goods_Unit_ID=@Goods_Unit_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Unit_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Goods_Unit_ID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Goods_Unit_Name;
            parameters[1].Value = model.Goods_Unit_Code;
            parameters[2].Value = model.Goods_Unit_Remark;
            parameters[3].Value = model.Goods_Unit_ID;

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
        public bool Delete(string Goods_Unit_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Unit ");
            strSql.Append(" where Goods_Unit_ID=@Goods_Unit_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Unit_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Goods_Unit_ID;

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
        public bool DeleteList(string Goods_Unit_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Unit ");
            strSql.Append(" where Goods_Unit_ID in (" + Goods_Unit_IDlist + ")  ");
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
        public WMS_Database.Goods_UnitModel GetModel(string Goods_Unit_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Goods_Unit_ID,Goods_Unit_Name,Goods_Unit_Code,Goods_Unit_Remark from Goods_Unit ");
            strSql.Append(" where Goods_Unit_ID=@Goods_Unit_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Unit_ID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Goods_Unit_ID;

            WMS_Database.Goods_UnitModel model = new WMS_Database.Goods_UnitModel();
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
        public WMS_Database.Goods_UnitModel DataRowToModel(DataRow row)
        {
            WMS_Database.Goods_UnitModel model = new WMS_Database.Goods_UnitModel();
            if (row != null)
            {
                if (row["Goods_Unit_ID"] != null)
                {
                    model.Goods_Unit_ID = row["Goods_Unit_ID"].ToString();
                }
                if (row["Goods_Unit_Name"] != null)
                {
                    model.Goods_Unit_Name = row["Goods_Unit_Name"].ToString();
                }
                if (row["Goods_Unit_Code"] != null)
                {
                    model.Goods_Unit_Code = row["Goods_Unit_Code"].ToString();
                }
                if (row["Goods_Unit_Remark"] != null)
                {
                    model.Goods_Unit_Remark = row["Goods_Unit_Remark"].ToString();
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
            strSql.Append("select Goods_Unit_ID,Goods_Unit_Name,Goods_Unit_Code,Goods_Unit_Remark ");
            strSql.Append(" FROM Goods_Unit ");
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
            strSql.Append(" Goods_Unit_ID,Goods_Unit_Name,Goods_Unit_Code,Goods_Unit_Remark ");
            strSql.Append(" FROM Goods_Unit ");
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
            strSql.Append("select count(1) FROM Goods_Unit ");
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
                strSql.Append("order by T.Goods_Unit_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Goods_Unit T ");
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
            parameters[0].Value = "Goods_Unit";
            parameters[1].Value = "Goods_Unit_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByCode(string unitCode)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Unit ");
            strSql.Append(" where [Goods_Unit_Code]=@Goods_Unit_Code ");
            SqlParameter[] parameters = {
					new SqlParameter("@Goods_Unit_Code", SqlDbType.NVarChar,50)			};
            parameters[0].Value = unitCode;

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
        #endregion  ExtensionMethod
    }
}

