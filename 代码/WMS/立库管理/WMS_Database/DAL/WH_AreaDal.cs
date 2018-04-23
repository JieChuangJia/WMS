using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:WH_AreaDal
	/// </summary>
	public partial class WH_AreaDal
	{
        public WH_AreaDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Area_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from WH_Area");
            strSql.Append(" where Area_ID='" + Area_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_AreaModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Area_ID != null)
            {
                strSql1.Append("Area_ID,");
                strSql2.Append("'" + model.Area_ID + "',");
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
            if (model.Area_Reserve2 != null)
            {
                strSql1.Append("Area_Reserve2,");
                strSql2.Append("'" + model.Area_Reserve2 + "',");
            }
            if (model.Area_Reserve3 != null)
            {
                strSql1.Append("Area_Reserve3,");
                strSql2.Append("'" + model.Area_Reserve3 + "',");
            }
            if (model.Area_Reserve4 != null)
            {
                strSql1.Append("Area_Reserve4,");
                strSql2.Append("'" + model.Area_Reserve4 + "',");
            }
            if (model.Area_Reserve5 != null)
            {
                strSql1.Append("Area_Reserve5,");
                strSql2.Append("'" + model.Area_Reserve5 + "',");
            }
            strSql.Append("insert into WH_Area(");
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
        public bool Update(WMS_Database.WH_AreaModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WH_Area set ");
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
            if (model.Area_Reserve2 != null)
            {
                strSql.Append("Area_Reserve2='" + model.Area_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Area_Reserve2= null ,");
            }
            if (model.Area_Reserve3 != null)
            {
                strSql.Append("Area_Reserve3='" + model.Area_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Area_Reserve3= null ,");
            }
            if (model.Area_Reserve4 != null)
            {
                strSql.Append("Area_Reserve4='" + model.Area_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Area_Reserve4= null ,");
            }
            if (model.Area_Reserve5 != null)
            {
                strSql.Append("Area_Reserve5='" + model.Area_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Area_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Area_ID='" + model.Area_ID + "' ");
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
        public bool Delete(string Area_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Area ");
            strSql.Append(" where Area_ID='" + Area_ID + "' ");
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
        public bool DeleteList(string Area_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Area ");
            strSql.Append(" where Area_ID in (" + Area_IDlist + ")  ");
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
        public WMS_Database.WH_AreaModel GetModel(string Area_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Area_ID,WareHouse_ID,Area_Type,Area_Code,Area_Name,Area_Order,Area_Flag,Area_BackColor,Area_Remark,Area_Reserve1,Area_Reserve2,Area_Reserve3,Area_Reserve4,Area_Reserve5 ");
            strSql.Append(" from WH_Area ");
            strSql.Append(" where Area_ID='" + Area_ID + "' ");
            WMS_Database.WH_AreaModel model = new WMS_Database.WH_AreaModel();
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
        public WMS_Database.WH_AreaModel DataRowToModel(DataRow row)
        {
            WMS_Database.WH_AreaModel model = new WMS_Database.WH_AreaModel();
            if (row != null)
            {
                if (row["Area_ID"] != null)
                {
                    model.Area_ID = row["Area_ID"].ToString();
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
                if (row["Area_Reserve2"] != null)
                {
                    model.Area_Reserve2 = row["Area_Reserve2"].ToString();
                }
                if (row["Area_Reserve3"] != null)
                {
                    model.Area_Reserve3 = row["Area_Reserve3"].ToString();
                }
                if (row["Area_Reserve4"] != null)
                {
                    model.Area_Reserve4 = row["Area_Reserve4"].ToString();
                }
                if (row["Area_Reserve5"] != null)
                {
                    model.Area_Reserve5 = row["Area_Reserve5"].ToString();
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
            strSql.Append("select Area_ID,WareHouse_ID,Area_Type,Area_Code,Area_Name,Area_Order,Area_Flag,Area_BackColor,Area_Remark,Area_Reserve1,Area_Reserve2,Area_Reserve3,Area_Reserve4,Area_Reserve5 ");
            strSql.Append(" FROM WH_Area ");
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
            strSql.Append(" Area_ID,WareHouse_ID,Area_Type,Area_Code,Area_Name,Area_Order,Area_Flag,Area_BackColor,Area_Remark,Area_Reserve1,Area_Reserve2,Area_Reserve3,Area_Reserve4,Area_Reserve5 ");
            strSql.Append(" FROM WH_Area ");
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
            strSql.Append("select count(1) FROM WH_Area ");
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
                strSql.Append("order by T.Area_ID desc");
            }
            strSql.Append(")AS Row, T.*  from WH_Area T ");
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

