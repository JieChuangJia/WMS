using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// 数据访问类:View_ERP_WH_Shelf
    /// </summary>
    public partial class View_ERP_WH_ShelfDAL
    {
        public View_ERP_WH_ShelfDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ERP_Shelf_VG_Code, string ERP_Shelf_VG_Name, string ERP_Shelf_VG_VList_Code, string ERP_Shelf_VG_VList_Name, string ERP_WH_CreateGroup, string ERP_WH_UseGroup, string ERP_WH_Name, string ERP_WH_Code, string ERP_WH_Property, string ERP_WH_VG_ID, string ERP_Shelf_VG_VList_ID, string ERP_WH_VG_REL_Value, string ERP_WH_ID, string ERP_WH_VG_Name, string ERP_WH_VG_Code, string Expr2, string ERP_Shelf_VG_ID, string ERP_WH_Enabled, string ERP_WH_Default_Status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_ERP_WH_Shelf");
            strSql.Append(" where ERP_Shelf_VG_Code='" + ERP_Shelf_VG_Code + "' and ERP_Shelf_VG_Name='" + ERP_Shelf_VG_Name + "' and ERP_Shelf_VG_VList_Code='" + ERP_Shelf_VG_VList_Code + "' and ERP_Shelf_VG_VList_Name='" + ERP_Shelf_VG_VList_Name + "' and ERP_WH_CreateGroup='" + ERP_WH_CreateGroup + "' and ERP_WH_UseGroup='" + ERP_WH_UseGroup + "' and ERP_WH_Name='" + ERP_WH_Name + "' and ERP_WH_Code='" + ERP_WH_Code + "' and ERP_WH_Property='" + ERP_WH_Property + "' and ERP_WH_VG_ID='" + ERP_WH_VG_ID + "' and ERP_Shelf_VG_VList_ID='" + ERP_Shelf_VG_VList_ID + "' and ERP_WH_VG_REL_Value='" + ERP_WH_VG_REL_Value + "' and ERP_WH_ID='" + ERP_WH_ID + "' and ERP_WH_VG_Name='" + ERP_WH_VG_Name + "' and ERP_WH_VG_Code='" + ERP_WH_VG_Code + "' and Expr2='" + Expr2 + "' and ERP_Shelf_VG_ID='" + ERP_Shelf_VG_ID + "' and ERP_WH_Enabled='" + ERP_WH_Enabled + "' and ERP_WH_Default_Status='" + ERP_WH_Default_Status + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Aoyou_BusinessDB.View_ERP_WH_ShelfModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.ERP_Shelf_VG_Code != null)
            {
                strSql1.Append("ERP_Shelf_VG_Code,");
                strSql2.Append("'" + model.ERP_Shelf_VG_Code + "',");
            }
            if (model.ERP_Shelf_VG_Name != null)
            {
                strSql1.Append("ERP_Shelf_VG_Name,");
                strSql2.Append("'" + model.ERP_Shelf_VG_Name + "',");
            }
            if (model.ERP_Shelf_VG_VList_Code != null)
            {
                strSql1.Append("ERP_Shelf_VG_VList_Code,");
                strSql2.Append("'" + model.ERP_Shelf_VG_VList_Code + "',");
            }
            if (model.ERP_Shelf_VG_VList_Name != null)
            {
                strSql1.Append("ERP_Shelf_VG_VList_Name,");
                strSql2.Append("'" + model.ERP_Shelf_VG_VList_Name + "',");
            }
            if (model.ERP_WH_CreateGroup != null)
            {
                strSql1.Append("ERP_WH_CreateGroup,");
                strSql2.Append("'" + model.ERP_WH_CreateGroup + "',");
            }
            if (model.ERP_WH_UseGroup != null)
            {
                strSql1.Append("ERP_WH_UseGroup,");
                strSql2.Append("'" + model.ERP_WH_UseGroup + "',");
            }
            if (model.ERP_WH_Name != null)
            {
                strSql1.Append("ERP_WH_Name,");
                strSql2.Append("'" + model.ERP_WH_Name + "',");
            }
            if (model.ERP_WH_Code != null)
            {
                strSql1.Append("ERP_WH_Code,");
                strSql2.Append("'" + model.ERP_WH_Code + "',");
            }
            if (model.ERP_WH_Property != null)
            {
                strSql1.Append("ERP_WH_Property,");
                strSql2.Append("'" + model.ERP_WH_Property + "',");
            }
            if (model.ERP_WH_VG_ID != null)
            {
                strSql1.Append("ERP_WH_VG_ID,");
                strSql2.Append("'" + model.ERP_WH_VG_ID + "',");
            }
            if (model.ERP_Shelf_VG_VList_ID != null)
            {
                strSql1.Append("ERP_Shelf_VG_VList_ID,");
                strSql2.Append("'" + model.ERP_Shelf_VG_VList_ID + "',");
            }
            if (model.ERP_WH_VG_REL_Value != null)
            {
                strSql1.Append("ERP_WH_VG_REL_Value,");
                strSql2.Append("'" + model.ERP_WH_VG_REL_Value + "',");
            }
            if (model.ERP_WH_ID != null)
            {
                strSql1.Append("ERP_WH_ID,");
                strSql2.Append("'" + model.ERP_WH_ID + "',");
            }
            if (model.ERP_WH_VG_Name != null)
            {
                strSql1.Append("ERP_WH_VG_Name,");
                strSql2.Append("'" + model.ERP_WH_VG_Name + "',");
            }
            if (model.ERP_WH_VG_Code != null)
            {
                strSql1.Append("ERP_WH_VG_Code,");
                strSql2.Append("'" + model.ERP_WH_VG_Code + "',");
            }
            if (model.Expr2 != null)
            {
                strSql1.Append("Expr2,");
                strSql2.Append("'" + model.Expr2 + "',");
            }
            if (model.ERP_Shelf_VG_ID != null)
            {
                strSql1.Append("ERP_Shelf_VG_ID,");
                strSql2.Append("'" + model.ERP_Shelf_VG_ID + "',");
            }
            if (model.ERP_WH_Enabled != null)
            {
                strSql1.Append("ERP_WH_Enabled,");
                strSql2.Append("'" + model.ERP_WH_Enabled + "',");
            }
            if (model.ERP_WH_Default_Status != null)
            {
                strSql1.Append("ERP_WH_Default_Status,");
                strSql2.Append("'" + model.ERP_WH_Default_Status + "',");
            }
            strSql.Append("insert into View_ERP_WH_Shelf(");
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
        public bool Update(Aoyou_BusinessDB.View_ERP_WH_ShelfModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_ERP_WH_Shelf set ");
            if (model.ERP_Shelf_VG_Code != null)
            {
                strSql.Append("ERP_Shelf_VG_Code='" + model.ERP_Shelf_VG_Code + "',");
            }
            else
            {
                strSql.Append("ERP_Shelf_VG_Code= null ,");
            }
            if (model.ERP_Shelf_VG_Name != null)
            {
                strSql.Append("ERP_Shelf_VG_Name='" + model.ERP_Shelf_VG_Name + "',");
            }
            else
            {
                strSql.Append("ERP_Shelf_VG_Name= null ,");
            }
            if (model.ERP_Shelf_VG_VList_Code != null)
            {
                strSql.Append("ERP_Shelf_VG_VList_Code='" + model.ERP_Shelf_VG_VList_Code + "',");
            }
            else
            {
                strSql.Append("ERP_Shelf_VG_VList_Code= null ,");
            }
            if (model.ERP_Shelf_VG_VList_Name != null)
            {
                strSql.Append("ERP_Shelf_VG_VList_Name='" + model.ERP_Shelf_VG_VList_Name + "',");
            }
            else
            {
                strSql.Append("ERP_Shelf_VG_VList_Name= null ,");
            }
            if (model.ERP_WH_CreateGroup != null)
            {
                strSql.Append("ERP_WH_CreateGroup='" + model.ERP_WH_CreateGroup + "',");
            }
            else
            {
                strSql.Append("ERP_WH_CreateGroup= null ,");
            }
            if (model.ERP_WH_UseGroup != null)
            {
                strSql.Append("ERP_WH_UseGroup='" + model.ERP_WH_UseGroup + "',");
            }
            else
            {
                strSql.Append("ERP_WH_UseGroup= null ,");
            }
            if (model.ERP_WH_Name != null)
            {
                strSql.Append("ERP_WH_Name='" + model.ERP_WH_Name + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Name= null ,");
            }
            if (model.ERP_WH_Code != null)
            {
                strSql.Append("ERP_WH_Code='" + model.ERP_WH_Code + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Code= null ,");
            }
            if (model.ERP_WH_Property != null)
            {
                strSql.Append("ERP_WH_Property='" + model.ERP_WH_Property + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Property= null ,");
            }
            if (model.ERP_WH_VG_ID != null)
            {
                strSql.Append("ERP_WH_VG_ID='" + model.ERP_WH_VG_ID + "',");
            }
            else
            {
                strSql.Append("ERP_WH_VG_ID= null ,");
            }
            if (model.ERP_Shelf_VG_VList_ID != null)
            {
                strSql.Append("ERP_Shelf_VG_VList_ID='" + model.ERP_Shelf_VG_VList_ID + "',");
            }
            else
            {
                strSql.Append("ERP_Shelf_VG_VList_ID= null ,");
            }
            if (model.ERP_WH_VG_REL_Value != null)
            {
                strSql.Append("ERP_WH_VG_REL_Value='" + model.ERP_WH_VG_REL_Value + "',");
            }
            else
            {
                strSql.Append("ERP_WH_VG_REL_Value= null ,");
            }
            if (model.ERP_WH_ID != null)
            {
                strSql.Append("ERP_WH_ID='" + model.ERP_WH_ID + "',");
            }
            else
            {
                strSql.Append("ERP_WH_ID= null ,");
            }
            if (model.ERP_WH_VG_Name != null)
            {
                strSql.Append("ERP_WH_VG_Name='" + model.ERP_WH_VG_Name + "',");
            }
            else
            {
                strSql.Append("ERP_WH_VG_Name= null ,");
            }
            if (model.ERP_WH_VG_Code != null)
            {
                strSql.Append("ERP_WH_VG_Code='" + model.ERP_WH_VG_Code + "',");
            }
            else
            {
                strSql.Append("ERP_WH_VG_Code= null ,");
            }
            if (model.Expr2 != null)
            {
                strSql.Append("Expr2='" + model.Expr2 + "',");
            }
            if (model.ERP_Shelf_VG_ID != null)
            {
                strSql.Append("ERP_Shelf_VG_ID='" + model.ERP_Shelf_VG_ID + "',");
            }
            else
            {
                strSql.Append("ERP_Shelf_VG_ID= null ,");
            }
            if (model.ERP_WH_Enabled != null)
            {
                strSql.Append("ERP_WH_Enabled='" + model.ERP_WH_Enabled + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Enabled= null ,");
            }
            if (model.ERP_WH_Default_Status != null)
            {
                strSql.Append("ERP_WH_Default_Status='" + model.ERP_WH_Default_Status + "',");
            }
            else
            {
                strSql.Append("ERP_WH_Default_Status= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ERP_Shelf_VG_Code='" + model.ERP_Shelf_VG_Code + "' and ERP_Shelf_VG_Name='" + model.ERP_Shelf_VG_Name + "' and ERP_Shelf_VG_VList_Code='" + model.ERP_Shelf_VG_VList_Code + "' and ERP_Shelf_VG_VList_Name='" + model.ERP_Shelf_VG_VList_Name + "' and ERP_WH_CreateGroup='" + model.ERP_WH_CreateGroup + "' and ERP_WH_UseGroup='" + model.ERP_WH_UseGroup + "' and ERP_WH_Name='" + model.ERP_WH_Name + "' and ERP_WH_Code='" + model.ERP_WH_Code + "' and ERP_WH_Property='" + model.ERP_WH_Property + "' and ERP_WH_VG_ID='" + model.ERP_WH_VG_ID + "' and ERP_Shelf_VG_VList_ID='" + model.ERP_Shelf_VG_VList_ID + "' and ERP_WH_VG_REL_Value='" + model.ERP_WH_VG_REL_Value + "' and ERP_WH_ID='" + model.ERP_WH_ID + "' and ERP_WH_VG_Name='" + model.ERP_WH_VG_Name + "' and ERP_WH_VG_Code='" + model.ERP_WH_VG_Code + "' and Expr2='" + model.Expr2 + "' and ERP_Shelf_VG_ID='" + model.ERP_Shelf_VG_ID + "' and ERP_WH_Enabled='" + model.ERP_WH_Enabled + "' and ERP_WH_Default_Status='" + model.ERP_WH_Default_Status + "' ");
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
        public bool Delete(string ERP_Shelf_VG_Code, string ERP_Shelf_VG_Name, string ERP_Shelf_VG_VList_Code, string ERP_Shelf_VG_VList_Name, string ERP_WH_CreateGroup, string ERP_WH_UseGroup, string ERP_WH_Name, string ERP_WH_Code, string ERP_WH_Property, string ERP_WH_VG_ID, string ERP_Shelf_VG_VList_ID, string ERP_WH_VG_REL_Value, string ERP_WH_ID, string ERP_WH_VG_Name, string ERP_WH_VG_Code, string Expr2, string ERP_Shelf_VG_ID, string ERP_WH_Enabled, string ERP_WH_Default_Status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_ERP_WH_Shelf ");
            strSql.Append(" where ERP_Shelf_VG_Code='" + ERP_Shelf_VG_Code + "' and ERP_Shelf_VG_Name='" + ERP_Shelf_VG_Name + "' and ERP_Shelf_VG_VList_Code='" + ERP_Shelf_VG_VList_Code + "' and ERP_Shelf_VG_VList_Name='" + ERP_Shelf_VG_VList_Name + "' and ERP_WH_CreateGroup='" + ERP_WH_CreateGroup + "' and ERP_WH_UseGroup='" + ERP_WH_UseGroup + "' and ERP_WH_Name='" + ERP_WH_Name + "' and ERP_WH_Code='" + ERP_WH_Code + "' and ERP_WH_Property='" + ERP_WH_Property + "' and ERP_WH_VG_ID='" + ERP_WH_VG_ID + "' and ERP_Shelf_VG_VList_ID='" + ERP_Shelf_VG_VList_ID + "' and ERP_WH_VG_REL_Value='" + ERP_WH_VG_REL_Value + "' and ERP_WH_ID='" + ERP_WH_ID + "' and ERP_WH_VG_Name='" + ERP_WH_VG_Name + "' and ERP_WH_VG_Code='" + ERP_WH_VG_Code + "' and Expr2='" + Expr2 + "' and ERP_Shelf_VG_ID='" + ERP_Shelf_VG_ID + "' and ERP_WH_Enabled='" + ERP_WH_Enabled + "' and ERP_WH_Default_Status='" + ERP_WH_Default_Status + "' ");
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
        public Aoyou_BusinessDB.View_ERP_WH_ShelfModel GetModel(string ERP_Shelf_VG_Code, string ERP_Shelf_VG_Name, string ERP_Shelf_VG_VList_Code, string ERP_Shelf_VG_VList_Name, string ERP_WH_CreateGroup, string ERP_WH_UseGroup, string ERP_WH_Name, string ERP_WH_Code, string ERP_WH_Property, string ERP_WH_VG_ID, string ERP_Shelf_VG_VList_ID, string ERP_WH_VG_REL_Value, string ERP_WH_ID, string ERP_WH_VG_Name, string ERP_WH_VG_Code, string Expr2, string ERP_Shelf_VG_ID, string ERP_WH_Enabled, string ERP_WH_Default_Status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ERP_Shelf_VG_Code,ERP_Shelf_VG_Name,ERP_Shelf_VG_VList_Code,ERP_Shelf_VG_VList_Name,ERP_WH_CreateGroup,ERP_WH_UseGroup,ERP_WH_Name,ERP_WH_Code,ERP_WH_Property,ERP_WH_VG_ID,ERP_Shelf_VG_VList_ID,ERP_WH_VG_REL_Value,ERP_WH_ID,ERP_WH_VG_Name,ERP_WH_VG_Code,Expr2,ERP_Shelf_VG_ID,ERP_WH_Enabled,ERP_WH_Default_Status ");
            strSql.Append(" from View_ERP_WH_Shelf ");
            strSql.Append(" where ERP_Shelf_VG_Code='" + ERP_Shelf_VG_Code + "' and ERP_Shelf_VG_Name='" + ERP_Shelf_VG_Name + "' and ERP_Shelf_VG_VList_Code='" + ERP_Shelf_VG_VList_Code + "' and ERP_Shelf_VG_VList_Name='" + ERP_Shelf_VG_VList_Name + "' and ERP_WH_CreateGroup='" + ERP_WH_CreateGroup + "' and ERP_WH_UseGroup='" + ERP_WH_UseGroup + "' and ERP_WH_Name='" + ERP_WH_Name + "' and ERP_WH_Code='" + ERP_WH_Code + "' and ERP_WH_Property='" + ERP_WH_Property + "' and ERP_WH_VG_ID='" + ERP_WH_VG_ID + "' and ERP_Shelf_VG_VList_ID='" + ERP_Shelf_VG_VList_ID + "' and ERP_WH_VG_REL_Value='" + ERP_WH_VG_REL_Value + "' and ERP_WH_ID='" + ERP_WH_ID + "' and ERP_WH_VG_Name='" + ERP_WH_VG_Name + "' and ERP_WH_VG_Code='" + ERP_WH_VG_Code + "' and Expr2='" + Expr2 + "' and ERP_Shelf_VG_ID='" + ERP_Shelf_VG_ID + "' and ERP_WH_Enabled='" + ERP_WH_Enabled + "' and ERP_WH_Default_Status='" + ERP_WH_Default_Status + "' ");
            Aoyou_BusinessDB.View_ERP_WH_ShelfModel model = new Aoyou_BusinessDB.View_ERP_WH_ShelfModel();
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
        public Aoyou_BusinessDB.View_ERP_WH_ShelfModel DataRowToModel(DataRow row)
        {
            Aoyou_BusinessDB.View_ERP_WH_ShelfModel model = new Aoyou_BusinessDB.View_ERP_WH_ShelfModel();
            if (row != null)
            {
                if (row["ERP_Shelf_VG_Code"] != null)
                {
                    model.ERP_Shelf_VG_Code = row["ERP_Shelf_VG_Code"].ToString();
                }
                if (row["ERP_Shelf_VG_Name"] != null)
                {
                    model.ERP_Shelf_VG_Name = row["ERP_Shelf_VG_Name"].ToString();
                }
                if (row["ERP_Shelf_VG_VList_Code"] != null)
                {
                    model.ERP_Shelf_VG_VList_Code = row["ERP_Shelf_VG_VList_Code"].ToString();
                }
                if (row["ERP_Shelf_VG_VList_Name"] != null)
                {
                    model.ERP_Shelf_VG_VList_Name = row["ERP_Shelf_VG_VList_Name"].ToString();
                }
                if (row["ERP_WH_CreateGroup"] != null)
                {
                    model.ERP_WH_CreateGroup = row["ERP_WH_CreateGroup"].ToString();
                }
                if (row["ERP_WH_UseGroup"] != null)
                {
                    model.ERP_WH_UseGroup = row["ERP_WH_UseGroup"].ToString();
                }
                if (row["ERP_WH_Name"] != null)
                {
                    model.ERP_WH_Name = row["ERP_WH_Name"].ToString();
                }
                if (row["ERP_WH_Code"] != null)
                {
                    model.ERP_WH_Code = row["ERP_WH_Code"].ToString();
                }
                if (row["ERP_WH_Property"] != null)
                {
                    model.ERP_WH_Property = row["ERP_WH_Property"].ToString();
                }
                if (row["ERP_WH_VG_ID"] != null)
                {
                    model.ERP_WH_VG_ID = row["ERP_WH_VG_ID"].ToString();
                }
                if (row["ERP_Shelf_VG_VList_ID"] != null)
                {
                    model.ERP_Shelf_VG_VList_ID = row["ERP_Shelf_VG_VList_ID"].ToString();
                }
                if (row["ERP_WH_VG_REL_Value"] != null)
                {
                    model.ERP_WH_VG_REL_Value = row["ERP_WH_VG_REL_Value"].ToString();
                }
                if (row["ERP_WH_ID"] != null)
                {
                    model.ERP_WH_ID = row["ERP_WH_ID"].ToString();
                }
                if (row["ERP_WH_VG_Name"] != null)
                {
                    model.ERP_WH_VG_Name = row["ERP_WH_VG_Name"].ToString();
                }
                if (row["ERP_WH_VG_Code"] != null)
                {
                    model.ERP_WH_VG_Code = row["ERP_WH_VG_Code"].ToString();
                }
                if (row["Expr2"] != null)
                {
                    model.Expr2 = row["Expr2"].ToString();
                }
                if (row["ERP_Shelf_VG_ID"] != null)
                {
                    model.ERP_Shelf_VG_ID = row["ERP_Shelf_VG_ID"].ToString();
                }
                if (row["ERP_WH_Enabled"] != null)
                {
                    model.ERP_WH_Enabled = row["ERP_WH_Enabled"].ToString();
                }
                if (row["ERP_WH_Default_Status"] != null)
                {
                    model.ERP_WH_Default_Status = row["ERP_WH_Default_Status"].ToString();
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
            strSql.Append("select ERP_Shelf_VG_Code,ERP_Shelf_VG_Name,ERP_Shelf_VG_VList_Code,ERP_Shelf_VG_VList_Name,ERP_WH_CreateGroup,ERP_WH_UseGroup,ERP_WH_Name,ERP_WH_Code,ERP_WH_Property,ERP_WH_VG_ID,ERP_Shelf_VG_VList_ID,ERP_WH_VG_REL_Value,ERP_WH_ID,ERP_WH_VG_Name,ERP_WH_VG_Code,Expr2,ERP_Shelf_VG_ID,ERP_WH_Enabled,ERP_WH_Default_Status ");
            strSql.Append(" FROM View_ERP_WH_Shelf ");
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
            strSql.Append(" ERP_Shelf_VG_Code,ERP_Shelf_VG_Name,ERP_Shelf_VG_VList_Code,ERP_Shelf_VG_VList_Name,ERP_WH_CreateGroup,ERP_WH_UseGroup,ERP_WH_Name,ERP_WH_Code,ERP_WH_Property,ERP_WH_VG_ID,ERP_Shelf_VG_VList_ID,ERP_WH_VG_REL_Value,ERP_WH_ID,ERP_WH_VG_Name,ERP_WH_VG_Code,Expr2,ERP_Shelf_VG_ID,ERP_WH_Enabled,ERP_WH_Default_Status ");
            strSql.Append(" FROM View_ERP_WH_Shelf ");
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
            strSql.Append("select count(1) FROM View_ERP_WH_Shelf ");
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
                strSql.Append("order by T.ERP_WH_Default_Status desc");
            }
            strSql.Append(")AS Row, T.*  from View_ERP_WH_Shelf T ");
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

