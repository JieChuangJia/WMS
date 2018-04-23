using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:GoodsDal
	/// </summary>
	public partial class GoodsDal
	{
        public GoodsDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Goods_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Goods");
            strSql.Append(" where Goods_ID='" + Goods_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.GoodsModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Goods_ID != null)
            {
                strSql1.Append("Goods_ID,");
                strSql2.Append("'" + model.Goods_ID + "',");
            }
            if (model.Goods_Class_ID != null)
            {
                strSql1.Append("Goods_Class_ID,");
                strSql2.Append("'" + model.Goods_Class_ID + "',");
            }
            if (model.Goods_Code != null)
            {
                strSql1.Append("Goods_Code,");
                strSql2.Append("'" + model.Goods_Code + "',");
            }
            if (model.Goods_Name != null)
            {
                strSql1.Append("Goods_Name,");
                strSql2.Append("'" + model.Goods_Name + "',");
            }
            if (model.Goods_Type != null)
            {
                strSql1.Append("Goods_Type,");
                strSql2.Append("'" + model.Goods_Type + "',");
            }
            if (model.Goods_Suppier_Code != null)
            {
                strSql1.Append("Goods_Suppier_Code,");
                strSql2.Append("'" + model.Goods_Suppier_Code + "',");
            }
            if (model.Goods_Model != null)
            {
                strSql1.Append("Goods_Model,");
                strSql2.Append("'" + model.Goods_Model + "',");
            }
            if (model.Goods_Desc != null)
            {
                strSql1.Append("Goods_Desc,");
                strSql2.Append("'" + model.Goods_Desc + "',");
            }
            if (model.Goods_Level != null)
            {
                strSql1.Append("Goods_Level,");
                strSql2.Append("'" + model.Goods_Level + "',");
            }
            if (model.Goods_Unit != null)
            {
                strSql1.Append("Goods_Unit,");
                strSql2.Append("'" + model.Goods_Unit + "',");
            }
            if (model.Goods_Limit_Upper_Quantity != null)
            {
                strSql1.Append("Goods_Limit_Upper_Quantity,");
                strSql2.Append("'" + model.Goods_Limit_Upper_Quantity + "',");
            }
            if (model.Goods_Limit_Lower_Quantity != null)
            {
                strSql1.Append("Goods_Limit_Lower_Quantity,");
                strSql2.Append("'" + model.Goods_Limit_Lower_Quantity + "',");
            }
            if (model.Goods_Order != null)
            {
                strSql1.Append("Goods_Order,");
                strSql2.Append("" + model.Goods_Order + ",");
            }
            if (model.Goods_Flag != null)
            {
                strSql1.Append("Goods_Flag,");
                strSql2.Append("'" + model.Goods_Flag + "',");
            }
            if (model.Goods_Danger != null)
            {
                strSql1.Append("Goods_Danger,");
                strSql2.Append("'" + model.Goods_Danger + "',");
            }
            if (model.Goods_Category != null)
            {
                strSql1.Append("Goods_Category,");
                strSql2.Append("'" + model.Goods_Category + "',");
            }
            if (model.Goods_ProduceDate != null)
            {
                strSql1.Append("Goods_ProduceDate,");
                strSql2.Append("'" + model.Goods_ProduceDate + "',");
            }
            if (model.Goods_Asset != null)
            {
                strSql1.Append("Goods_Asset,");
                strSql2.Append("'" + model.Goods_Asset + "',");
            }
            if (model.Goods_Shelf_Life != null)
            {
                strSql1.Append("Goods_Shelf_Life,");
                strSql2.Append("" + model.Goods_Shelf_Life + ",");
            }
            if (model.Goods_Department != null)
            {
                strSql1.Append("Goods_Department,");
                strSql2.Append("'" + model.Goods_Department + "',");
            }
            if (model.Goods_Remark != null)
            {
                strSql1.Append("Goods_Remark,");
                strSql2.Append("'" + model.Goods_Remark + "',");
            }
            if (model.Goods_Reserve1 != null)
            {
                strSql1.Append("Goods_Reserve1,");
                strSql2.Append("'" + model.Goods_Reserve1 + "',");
            }
            if (model.Goods_Reserve2 != null)
            {
                strSql1.Append("Goods_Reserve2,");
                strSql2.Append("'" + model.Goods_Reserve2 + "',");
            }
            if (model.Goods_Reserve3 != null)
            {
                strSql1.Append("Goods_Reserve3,");
                strSql2.Append("'" + model.Goods_Reserve3 + "',");
            }
            if (model.Goods_Reserve4 != null)
            {
                strSql1.Append("Goods_Reserve4,");
                strSql2.Append("'" + model.Goods_Reserve4 + "',");
            }
            if (model.Goods_Reserve5 != null)
            {
                strSql1.Append("Goods_Reserve5,");
                strSql2.Append("'" + model.Goods_Reserve5 + "',");
            }
            strSql.Append("insert into Goods(");
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
        public bool Update(WMS_Database.GoodsModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Goods set ");
            if (model.Goods_Class_ID != null)
            {
                strSql.Append("Goods_Class_ID='" + model.Goods_Class_ID + "',");
            }
            if (model.Goods_Code != null)
            {
                strSql.Append("Goods_Code='" + model.Goods_Code + "',");
            }
            else
            {
                strSql.Append("Goods_Code= null ,");
            }
            if (model.Goods_Name != null)
            {
                strSql.Append("Goods_Name='" + model.Goods_Name + "',");
            }
            else
            {
                strSql.Append("Goods_Name= null ,");
            }
            if (model.Goods_Type != null)
            {
                strSql.Append("Goods_Type='" + model.Goods_Type + "',");
            }
            else
            {
                strSql.Append("Goods_Type= null ,");
            }
            if (model.Goods_Suppier_Code != null)
            {
                strSql.Append("Goods_Suppier_Code='" + model.Goods_Suppier_Code + "',");
            }
            else
            {
                strSql.Append("Goods_Suppier_Code= null ,");
            }
            if (model.Goods_Model != null)
            {
                strSql.Append("Goods_Model='" + model.Goods_Model + "',");
            }
            else
            {
                strSql.Append("Goods_Model= null ,");
            }
            if (model.Goods_Desc != null)
            {
                strSql.Append("Goods_Desc='" + model.Goods_Desc + "',");
            }
            else
            {
                strSql.Append("Goods_Desc= null ,");
            }
            if (model.Goods_Level != null)
            {
                strSql.Append("Goods_Level='" + model.Goods_Level + "',");
            }
            else
            {
                strSql.Append("Goods_Level= null ,");
            }
            if (model.Goods_Unit != null)
            {
                strSql.Append("Goods_Unit='" + model.Goods_Unit + "',");
            }
            else
            {
                strSql.Append("Goods_Unit= null ,");
            }
            if (model.Goods_Limit_Upper_Quantity != null)
            {
                strSql.Append("Goods_Limit_Upper_Quantity='" + model.Goods_Limit_Upper_Quantity + "',");
            }
            else
            {
                strSql.Append("Goods_Limit_Upper_Quantity= null ,");
            }
            if (model.Goods_Limit_Lower_Quantity != null)
            {
                strSql.Append("Goods_Limit_Lower_Quantity='" + model.Goods_Limit_Lower_Quantity + "',");
            }
            else
            {
                strSql.Append("Goods_Limit_Lower_Quantity= null ,");
            }
            if (model.Goods_Order != null)
            {
                strSql.Append("Goods_Order=" + model.Goods_Order + ",");
            }
            else
            {
                strSql.Append("Goods_Order= null ,");
            }
            if (model.Goods_Flag != null)
            {
                strSql.Append("Goods_Flag='" + model.Goods_Flag + "',");
            }
            else
            {
                strSql.Append("Goods_Flag= null ,");
            }
            if (model.Goods_Danger != null)
            {
                strSql.Append("Goods_Danger='" + model.Goods_Danger + "',");
            }
            else
            {
                strSql.Append("Goods_Danger= null ,");
            }
            if (model.Goods_Category != null)
            {
                strSql.Append("Goods_Category='" + model.Goods_Category + "',");
            }
            else
            {
                strSql.Append("Goods_Category= null ,");
            }
            if (model.Goods_ProduceDate != null)
            {
                strSql.Append("Goods_ProduceDate='" + model.Goods_ProduceDate + "',");
            }
            else
            {
                strSql.Append("Goods_ProduceDate= null ,");
            }
            if (model.Goods_Asset != null)
            {
                strSql.Append("Goods_Asset='" + model.Goods_Asset + "',");
            }
            else
            {
                strSql.Append("Goods_Asset= null ,");
            }
            if (model.Goods_Shelf_Life != null)
            {
                strSql.Append("Goods_Shelf_Life=" + model.Goods_Shelf_Life + ",");
            }
            else
            {
                strSql.Append("Goods_Shelf_Life= null ,");
            }
            if (model.Goods_Department != null)
            {
                strSql.Append("Goods_Department='" + model.Goods_Department + "',");
            }
            else
            {
                strSql.Append("Goods_Department= null ,");
            }
            if (model.Goods_Remark != null)
            {
                strSql.Append("Goods_Remark='" + model.Goods_Remark + "',");
            }
            else
            {
                strSql.Append("Goods_Remark= null ,");
            }
            if (model.Goods_Reserve1 != null)
            {
                strSql.Append("Goods_Reserve1='" + model.Goods_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Goods_Reserve1= null ,");
            }
            if (model.Goods_Reserve2 != null)
            {
                strSql.Append("Goods_Reserve2='" + model.Goods_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Goods_Reserve2= null ,");
            }
            if (model.Goods_Reserve3 != null)
            {
                strSql.Append("Goods_Reserve3='" + model.Goods_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Goods_Reserve3= null ,");
            }
            if (model.Goods_Reserve4 != null)
            {
                strSql.Append("Goods_Reserve4='" + model.Goods_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Goods_Reserve4= null ,");
            }
            if (model.Goods_Reserve5 != null)
            {
                strSql.Append("Goods_Reserve5='" + model.Goods_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Goods_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Goods_ID='" + model.Goods_ID + "' ");
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
        public bool Delete(string Goods_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods ");
            strSql.Append(" where Goods_ID='" + Goods_ID + "' ");
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
        public bool DeleteList(string Goods_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods ");
            strSql.Append(" where Goods_ID in (" + Goods_IDlist + ")  ");
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
        public WMS_Database.GoodsModel GetModel(string Goods_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Goods_ID,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_ProduceDate,Goods_Asset,Goods_Shelf_Life,Goods_Department,Goods_Remark,Goods_Reserve1,Goods_Reserve2,Goods_Reserve3,Goods_Reserve4,Goods_Reserve5 ");
            strSql.Append(" from Goods ");
            strSql.Append(" where Goods_ID='" + Goods_ID + "' ");
            WMS_Database.GoodsModel model = new WMS_Database.GoodsModel();
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
        public WMS_Database.GoodsModel DataRowToModel(DataRow row)
        {
            WMS_Database.GoodsModel model = new WMS_Database.GoodsModel();
            if (row != null)
            {
                if (row["Goods_ID"] != null)
                {
                    model.Goods_ID = row["Goods_ID"].ToString();
                }
                if (row["Goods_Class_ID"] != null)
                {
                    model.Goods_Class_ID = row["Goods_Class_ID"].ToString();
                }
                if (row["Goods_Code"] != null)
                {
                    model.Goods_Code = row["Goods_Code"].ToString();
                }
                if (row["Goods_Name"] != null)
                {
                    model.Goods_Name = row["Goods_Name"].ToString();
                }
                if (row["Goods_Type"] != null)
                {
                    model.Goods_Type = row["Goods_Type"].ToString();
                }
                if (row["Goods_Suppier_Code"] != null)
                {
                    model.Goods_Suppier_Code = row["Goods_Suppier_Code"].ToString();
                }
                if (row["Goods_Model"] != null)
                {
                    model.Goods_Model = row["Goods_Model"].ToString();
                }
                if (row["Goods_Desc"] != null)
                {
                    model.Goods_Desc = row["Goods_Desc"].ToString();
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
                if (row["Goods_ProduceDate"] != null && row["Goods_ProduceDate"].ToString() != "")
                {
                    model.Goods_ProduceDate = DateTime.Parse(row["Goods_ProduceDate"].ToString());
                }
                if (row["Goods_Asset"] != null)
                {
                    model.Goods_Asset = row["Goods_Asset"].ToString();
                }
                if (row["Goods_Shelf_Life"] != null && row["Goods_Shelf_Life"].ToString() != "")
                {
                    model.Goods_Shelf_Life = int.Parse(row["Goods_Shelf_Life"].ToString());
                }
                if (row["Goods_Department"] != null)
                {
                    model.Goods_Department = row["Goods_Department"].ToString();
                }
                if (row["Goods_Remark"] != null)
                {
                    model.Goods_Remark = row["Goods_Remark"].ToString();
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Goods_ID,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_ProduceDate,Goods_Asset,Goods_Shelf_Life,Goods_Department,Goods_Remark,Goods_Reserve1,Goods_Reserve2,Goods_Reserve3,Goods_Reserve4,Goods_Reserve5 ");
            strSql.Append(" FROM Goods ");
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
            strSql.Append(" Goods_ID,Goods_Class_ID,Goods_Code,Goods_Name,Goods_Type,Goods_Suppier_Code,Goods_Model,Goods_Desc,Goods_Level,Goods_Unit,Goods_Limit_Upper_Quantity,Goods_Limit_Lower_Quantity,Goods_Order,Goods_Flag,Goods_Danger,Goods_Category,Goods_ProduceDate,Goods_Asset,Goods_Shelf_Life,Goods_Department,Goods_Remark,Goods_Reserve1,Goods_Reserve2,Goods_Reserve3,Goods_Reserve4,Goods_Reserve5 ");
            strSql.Append(" FROM Goods ");
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
            strSql.Append("select count(1) FROM Goods ");
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
                strSql.Append("order by T.Goods_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Goods T ");
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

