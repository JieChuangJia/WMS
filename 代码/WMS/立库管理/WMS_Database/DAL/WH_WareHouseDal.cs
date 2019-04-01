using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:WH_WareHouseDal
	/// </summary>
	public partial class WH_WareHouseDal
	{
        public WH_WareHouseDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WareHouse_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from WH_WareHouse");
            strSql.Append(" where WareHouse_ID='" + WareHouse_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_WareHouseModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.WareHouse_ID != null)
            {
                strSql1.Append("WareHouse_ID,");
                strSql2.Append("'" + model.WareHouse_ID + "',");
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
            if (model.WareHouse_Reserve1 != null)
            {
                strSql1.Append("WareHouse_Reserve1,");
                strSql2.Append("'" + model.WareHouse_Reserve1 + "',");
            }
            if (model.WareHouse_Reserve2 != null)
            {
                strSql1.Append("WareHouse_Reserve2,");
                strSql2.Append("'" + model.WareHouse_Reserve2 + "',");
            }
            if (model.WareHouse_Reserve3 != null)
            {
                strSql1.Append("WareHouse_Reserve3,");
                strSql2.Append("'" + model.WareHouse_Reserve3 + "',");
            }
            if (model.WareHouse_Reserve4 != null)
            {
                strSql1.Append("WareHouse_Reserve4,");
                strSql2.Append("'" + model.WareHouse_Reserve4 + "',");
            }
            if (model.WareHouse_Reserve5 != null)
            {
                strSql1.Append("WareHouse_Reserve5,");
                strSql2.Append("'" + model.WareHouse_Reserve5 + "',");
            }
            strSql.Append("insert into WH_WareHouse(");
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
        public bool Update(WMS_Database.WH_WareHouseModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WH_WareHouse set ");
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
            if (model.WareHouse_Reserve1 != null)
            {
                strSql.Append("WareHouse_Reserve1='" + model.WareHouse_Reserve1 + "',");
            }
            else
            {
                strSql.Append("WareHouse_Reserve1= null ,");
            }
            if (model.WareHouse_Reserve2 != null)
            {
                strSql.Append("WareHouse_Reserve2='" + model.WareHouse_Reserve2 + "',");
            }
            else
            {
                strSql.Append("WareHouse_Reserve2= null ,");
            }
            if (model.WareHouse_Reserve3 != null)
            {
                strSql.Append("WareHouse_Reserve3='" + model.WareHouse_Reserve3 + "',");
            }
            else
            {
                strSql.Append("WareHouse_Reserve3= null ,");
            }
            if (model.WareHouse_Reserve4 != null)
            {
                strSql.Append("WareHouse_Reserve4='" + model.WareHouse_Reserve4 + "',");
            }
            else
            {
                strSql.Append("WareHouse_Reserve4= null ,");
            }
            if (model.WareHouse_Reserve5 != null)
            {
                strSql.Append("WareHouse_Reserve5='" + model.WareHouse_Reserve5 + "',");
            }
            else
            {
                strSql.Append("WareHouse_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where WareHouse_ID='" + model.WareHouse_ID + "' ");
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
        public bool Delete(string WareHouse_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_WareHouse ");
            strSql.Append(" where WareHouse_ID='" + WareHouse_ID + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }		/// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string WareHouse_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_WareHouse ");
            strSql.Append(" where WareHouse_ID in (" + WareHouse_IDlist + ")  ");
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
        public WMS_Database.WH_WareHouseModel GetModel(string WareHouse_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" WareHouse_ID,WareHouse_Code,WareHouse_Name,WareHouse_Type,WareHouse_Flag,WareHouse_Remark,WareHouse_Reserve1,WareHouse_Reserve2,WareHouse_Reserve3,WareHouse_Reserve4,WareHouse_Reserve5 ");
            strSql.Append(" from WH_WareHouse ");
            strSql.Append(" where WareHouse_ID='" + WareHouse_ID + "' ");
            WMS_Database.WH_WareHouseModel model = new WMS_Database.WH_WareHouseModel();
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
        public WMS_Database.WH_WareHouseModel DataRowToModel(DataRow row)
        {
            WMS_Database.WH_WareHouseModel model = new WMS_Database.WH_WareHouseModel();
            if (row != null)
            {
                if (row["WareHouse_ID"] != null)
                {
                    model.WareHouse_ID = row["WareHouse_ID"].ToString();
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
                if (row["WareHouse_Reserve1"] != null)
                {
                    model.WareHouse_Reserve1 = row["WareHouse_Reserve1"].ToString();
                }
                if (row["WareHouse_Reserve2"] != null)
                {
                    model.WareHouse_Reserve2 = row["WareHouse_Reserve2"].ToString();
                }
                if (row["WareHouse_Reserve3"] != null)
                {
                    model.WareHouse_Reserve3 = row["WareHouse_Reserve3"].ToString();
                }
                if (row["WareHouse_Reserve4"] != null)
                {
                    model.WareHouse_Reserve4 = row["WareHouse_Reserve4"].ToString();
                }
                if (row["WareHouse_Reserve5"] != null)
                {
                    model.WareHouse_Reserve5 = row["WareHouse_Reserve5"].ToString();
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
            strSql.Append("select WareHouse_ID,WareHouse_Code,WareHouse_Name,WareHouse_Type,WareHouse_Flag,WareHouse_Remark,WareHouse_Reserve1,WareHouse_Reserve2,WareHouse_Reserve3,WareHouse_Reserve4,WareHouse_Reserve5 ");
            strSql.Append(" FROM WH_WareHouse ");
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
            strSql.Append(" WareHouse_ID,WareHouse_Code,WareHouse_Name,WareHouse_Type,WareHouse_Flag,WareHouse_Remark,WareHouse_Reserve1,WareHouse_Reserve2,WareHouse_Reserve3,WareHouse_Reserve4,WareHouse_Reserve5 ");
            strSql.Append(" FROM WH_WareHouse ");
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
            strSql.Append("select count(1) FROM WH_WareHouse ");
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
                strSql.Append("order by T.WareHouse_ID desc");
            }
            strSql.Append(")AS Row, T.*  from WH_WareHouse T ");
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
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByCode(string wareHouse_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_WareHouse ");
            strSql.Append(" where WareHouse_Code='" + wareHouse_Code + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }		/// <summary>
		#endregion  ExtensionMethod
	}
}

