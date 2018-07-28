using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:Goods_ClassDal
	/// </summary>
	public partial class Goods_ClassDal
	{
        public Goods_ClassDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_Class_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Goods_Class");
            strSql.Append(" where Goods_Class_ID='" + Goods_Class_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.Goods_ClassModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Goods_Class_ID != null)
            {
                strSql1.Append("Goods_Class_ID,");
                strSql2.Append("'" + model.Goods_Class_ID + "',");
            }
            if (model.Goods_Class_Parent_ID != null)
            {
                strSql1.Append("Goods_Class_Parent_ID,");
                strSql2.Append("'" + model.Goods_Class_Parent_ID + "',");
            }
            if (model.Goods_Class_Code != null)
            {
                strSql1.Append("Goods_Class_Code,");
                strSql2.Append("'" + model.Goods_Class_Code + "',");
            }
            if (model.Goods_Class_Name != null)
            {
                strSql1.Append("Goods_Class_Name,");
                strSql2.Append("'" + model.Goods_Class_Name + "',");
            }
            if (model.Goods_Class_Remark != null)
            {
                strSql1.Append("Goods_Class_Remark,");
                strSql2.Append("'" + model.Goods_Class_Remark + "',");
            }
            if (model.Goods_Class_Order != null)
            {
                strSql1.Append("Goods_Class_Order,");
                strSql2.Append("" + model.Goods_Class_Order + ",");
            }
            if (model.Goods_Class_Flag != null)
            {
                strSql1.Append("Goods_Class_Flag,");
                strSql2.Append("'" + model.Goods_Class_Flag + "',");
            }
            if (model.Goods_Class_Reserve1 != null)
            {
                strSql1.Append("Goods_Class_Reserve1,");
                strSql2.Append("'" + model.Goods_Class_Reserve1 + "',");
            }
            if (model.Goods_Class_Reserve2 != null)
            {
                strSql1.Append("Goods_Class_Reserve2,");
                strSql2.Append("'" + model.Goods_Class_Reserve2 + "',");
            }
            if (model.Goods_Class_Reserve3 != null)
            {
                strSql1.Append("Goods_Class_Reserve3,");
                strSql2.Append("'" + model.Goods_Class_Reserve3 + "',");
            }
            if (model.Goods_Class_Reserve4 != null)
            {
                strSql1.Append("Goods_Class_Reserve4,");
                strSql2.Append("'" + model.Goods_Class_Reserve4 + "',");
            }
            if (model.Goods_Class_Reserve5 != null)
            {
                strSql1.Append("Goods_Class_Reserve5,");
                strSql2.Append("'" + model.Goods_Class_Reserve5 + "',");
            }
            strSql.Append("insert into Goods_Class(");
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
        public bool Update(WMS_Database.Goods_ClassModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Goods_Class set ");
            if (model.Goods_Class_Parent_ID != null)
            {
                strSql.Append("Goods_Class_Parent_ID='" + model.Goods_Class_Parent_ID + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Parent_ID= null ,");
            }
            if (model.Goods_Class_Code != null)
            {
                strSql.Append("Goods_Class_Code='" + model.Goods_Class_Code + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Code= null ,");
            }
            if (model.Goods_Class_Name != null)
            {
                strSql.Append("Goods_Class_Name='" + model.Goods_Class_Name + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Name= null ,");
            }
            if (model.Goods_Class_Remark != null)
            {
                strSql.Append("Goods_Class_Remark='" + model.Goods_Class_Remark + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Remark= null ,");
            }
            if (model.Goods_Class_Order != null)
            {
                strSql.Append("Goods_Class_Order=" + model.Goods_Class_Order + ",");
            }
            else
            {
                strSql.Append("Goods_Class_Order= null ,");
            }
            if (model.Goods_Class_Flag != null)
            {
                strSql.Append("Goods_Class_Flag='" + model.Goods_Class_Flag + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Flag= null ,");
            }
            if (model.Goods_Class_Reserve1 != null)
            {
                strSql.Append("Goods_Class_Reserve1='" + model.Goods_Class_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Reserve1= null ,");
            }
            if (model.Goods_Class_Reserve2 != null)
            {
                strSql.Append("Goods_Class_Reserve2='" + model.Goods_Class_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Reserve2= null ,");
            }
            if (model.Goods_Class_Reserve3 != null)
            {
                strSql.Append("Goods_Class_Reserve3='" + model.Goods_Class_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Reserve3= null ,");
            }
            if (model.Goods_Class_Reserve4 != null)
            {
                strSql.Append("Goods_Class_Reserve4='" + model.Goods_Class_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Reserve4= null ,");
            }
            if (model.Goods_Class_Reserve5 != null)
            {
                strSql.Append("Goods_Class_Reserve5='" + model.Goods_Class_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Goods_Class_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Goods_Class_ID='" + model.Goods_Class_ID + "' ");
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
        public bool Delete(string Goods_Class_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Class ");
            strSql.Append(" where Goods_Class_ID='" + Goods_Class_ID + "' ");
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
        public bool DeleteList(string Goods_Class_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods_Class ");
            strSql.Append(" where Goods_Class_ID in (" + Goods_Class_IDlist + ")  ");
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
        public WMS_Database.Goods_ClassModel GetModel(string Goods_Class_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Goods_Class_ID,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Flag,Goods_Class_Reserve1,Goods_Class_Reserve2,Goods_Class_Reserve3,Goods_Class_Reserve4,Goods_Class_Reserve5 ");
            strSql.Append(" from Goods_Class ");
            strSql.Append(" where Goods_Class_ID='" + Goods_Class_ID + "' ");
            WMS_Database.Goods_ClassModel model = new WMS_Database.Goods_ClassModel();
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
        public WMS_Database.Goods_ClassModel DataRowToModel(DataRow row)
        {
            WMS_Database.Goods_ClassModel model = new WMS_Database.Goods_ClassModel();
            if (row != null)
            {
                if (row["Goods_Class_ID"] != null)
                {
                    model.Goods_Class_ID = row["Goods_Class_ID"].ToString();
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
                if (row["Goods_Class_Flag"] != null)
                {
                    model.Goods_Class_Flag = row["Goods_Class_Flag"].ToString();
                }
                if (row["Goods_Class_Reserve1"] != null)
                {
                    model.Goods_Class_Reserve1 = row["Goods_Class_Reserve1"].ToString();
                }
                if (row["Goods_Class_Reserve2"] != null)
                {
                    model.Goods_Class_Reserve2 = row["Goods_Class_Reserve2"].ToString();
                }
                if (row["Goods_Class_Reserve3"] != null)
                {
                    model.Goods_Class_Reserve3 = row["Goods_Class_Reserve3"].ToString();
                }
                if (row["Goods_Class_Reserve4"] != null)
                {
                    model.Goods_Class_Reserve4 = row["Goods_Class_Reserve4"].ToString();
                }
                if (row["Goods_Class_Reserve5"] != null)
                {
                    model.Goods_Class_Reserve5 = row["Goods_Class_Reserve5"].ToString();
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
            strSql.Append("select Goods_Class_ID,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Flag,Goods_Class_Reserve1,Goods_Class_Reserve2,Goods_Class_Reserve3,Goods_Class_Reserve4,Goods_Class_Reserve5 ");
            strSql.Append(" FROM Goods_Class ");
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
            strSql.Append(" Goods_Class_ID,Goods_Class_Parent_ID,Goods_Class_Code,Goods_Class_Name,Goods_Class_Remark,Goods_Class_Order,Goods_Class_Flag,Goods_Class_Reserve1,Goods_Class_Reserve2,Goods_Class_Reserve3,Goods_Class_Reserve4,Goods_Class_Reserve5 ");
            strSql.Append(" FROM Goods_Class ");
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
            strSql.Append("select count(1) FROM Goods_Class ");
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
                strSql.Append("order by T.Goods_Class_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Goods_Class T ");
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
        /// 得到一个对象实体
        /// </summary>
        public List<string> GetDistinctGoods()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  distinct  Goods_Class_Name  ");
            
            strSql.Append(" from Goods_Class ");
            List<string> items= new List<string>();
           
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if(ds!= null&&ds.Tables.Count>0)
            {
                for(int i=0;i<ds.Tables[0].Rows.Count;i++)
                {
                    items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            return items;
        }

		#endregion  ExtensionMethod
	}
}

