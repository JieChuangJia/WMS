using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:WH_Cell_ChildrenDal
	/// </summary>
	public partial class WH_Cell_ChildrenDal
	{
        public WH_Cell_ChildrenDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Cell_Chlid_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from WH_Cell_Children");
            strSql.Append(" where Cell_Chlid_ID='" + Cell_Chlid_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_Cell_ChildrenModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Cell_Chlid_ID != null)
            {
                strSql1.Append("Cell_Chlid_ID,");
                strSql2.Append("'" + model.Cell_Chlid_ID + "',");
            }
            if (model.Cell_ID != null)
            {
                strSql1.Append("Cell_ID,");
                strSql2.Append("'" + model.Cell_ID + "',");
            }
            if (model.Cell_Chlid_Position != null)
            {
                strSql1.Append("Cell_Chlid_Position,");
                strSql2.Append("'" + model.Cell_Chlid_Position + "',");
            }
            if (model.Cell_Child_Order != null)
            {
                strSql1.Append("Cell_Child_Order,");
                strSql2.Append("" + model.Cell_Child_Order + ",");
            }
            if (model.Cell_Child_InOut != null)
            {
                strSql1.Append("Cell_Child_InOut,");
                strSql2.Append("'" + model.Cell_Child_InOut + "',");
            }
            if (model.Cell_Child_Model != null)
            {
                strSql1.Append("Cell_Child_Model,");
                strSql2.Append("'" + model.Cell_Child_Model + "',");
            }
            if (model.Cell_Child_Status != null)
            {
                strSql1.Append("Cell_Child_Status,");
                strSql2.Append("'" + model.Cell_Child_Status + "',");
            }
            if (model.Cell_Child_Run_Status != null)
            {
                strSql1.Append("Cell_Child_Run_Status,");
                strSql2.Append("'" + model.Cell_Child_Run_Status + "',");
            }
            if (model.Cell_Child_Flag != null)
            {
                strSql1.Append("Cell_Child_Flag,");
                strSql2.Append("'" + model.Cell_Child_Flag + "',");
            }
            if (model.Cell_Child_Operate_Type != null)
            {
                strSql1.Append("Cell_Child_Operate_Type,");
                strSql2.Append("'" + model.Cell_Child_Operate_Type + "',");
            }
            if (model.Cell_Child_TaskLock_ID != null)
            {
                strSql1.Append("Cell_Child_TaskLock_ID,");
                strSql2.Append("'" + model.Cell_Child_TaskLock_ID + "',");
            }
            if (model.Cell_Child_Reserve1 != null)
            {
                strSql1.Append("Cell_Child_Reserve1,");
                strSql2.Append("'" + model.Cell_Child_Reserve1 + "',");
            }
            if (model.Cell_Child_Reserve2 != null)
            {
                strSql1.Append("Cell_Child_Reserve2,");
                strSql2.Append("'" + model.Cell_Child_Reserve2 + "',");
            }
            if (model.Cell_Child_Reserve3 != null)
            {
                strSql1.Append("Cell_Child_Reserve3,");
                strSql2.Append("'" + model.Cell_Child_Reserve3 + "',");
            }
            if (model.Cell_Child_Reserve4 != null)
            {
                strSql1.Append("Cell_Child_Reserve4,");
                strSql2.Append("'" + model.Cell_Child_Reserve4 + "',");
            }
            if (model.Cell_Child_Reserve5 != null)
            {
                strSql1.Append("Cell_Child_Reserve5,");
                strSql2.Append("'" + model.Cell_Child_Reserve5 + "',");
            }
            strSql.Append("insert into WH_Cell_Children(");
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
        public bool Update(WMS_Database.WH_Cell_ChildrenModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WH_Cell_Children set ");
            if (model.Cell_ID != null)
            {
                strSql.Append("Cell_ID='" + model.Cell_ID + "',");
            }
            else
            {
                strSql.Append("Cell_ID= null ,");
            }
            if (model.Cell_Chlid_Position != null)
            {
                strSql.Append("Cell_Chlid_Position='" + model.Cell_Chlid_Position + "',");
            }
            else
            {
                strSql.Append("Cell_Chlid_Position= null ,");
            }
            if (model.Cell_Child_Order != null)
            {
                strSql.Append("Cell_Child_Order=" + model.Cell_Child_Order + ",");
            }
            else
            {
                strSql.Append("Cell_Child_Order= null ,");
            }
            if (model.Cell_Child_InOut != null)
            {
                strSql.Append("Cell_Child_InOut='" + model.Cell_Child_InOut + "',");
            }
            else
            {
                strSql.Append("Cell_Child_InOut= null ,");
            }
            if (model.Cell_Child_Model != null)
            {
                strSql.Append("Cell_Child_Model='" + model.Cell_Child_Model + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Model= null ,");
            }
            if (model.Cell_Child_Status != null)
            {
                strSql.Append("Cell_Child_Status='" + model.Cell_Child_Status + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Status= null ,");
            }
            if (model.Cell_Child_Run_Status != null)
            {
                strSql.Append("Cell_Child_Run_Status='" + model.Cell_Child_Run_Status + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Run_Status= null ,");
            }
            if (model.Cell_Child_Flag != null)
            {
                strSql.Append("Cell_Child_Flag='" + model.Cell_Child_Flag + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Flag= null ,");
            }
            if (model.Cell_Child_Operate_Type != null)
            {
                strSql.Append("Cell_Child_Operate_Type='" + model.Cell_Child_Operate_Type + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Operate_Type= null ,");
            }
            if (model.Cell_Child_TaskLock_ID != null)
            {
                strSql.Append("Cell_Child_TaskLock_ID='" + model.Cell_Child_TaskLock_ID + "',");
            }
            else
            {
                strSql.Append("Cell_Child_TaskLock_ID= null ,");
            }
            if (model.Cell_Child_Reserve1 != null)
            {
                strSql.Append("Cell_Child_Reserve1='" + model.Cell_Child_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Reserve1= null ,");
            }
            if (model.Cell_Child_Reserve2 != null)
            {
                strSql.Append("Cell_Child_Reserve2='" + model.Cell_Child_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Reserve2= null ,");
            }
            if (model.Cell_Child_Reserve3 != null)
            {
                strSql.Append("Cell_Child_Reserve3='" + model.Cell_Child_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Reserve3= null ,");
            }
            if (model.Cell_Child_Reserve4 != null)
            {
                strSql.Append("Cell_Child_Reserve4='" + model.Cell_Child_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Reserve4= null ,");
            }
            if (model.Cell_Child_Reserve5 != null)
            {
                strSql.Append("Cell_Child_Reserve5='" + model.Cell_Child_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Cell_Child_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Cell_Chlid_ID='" + model.Cell_Chlid_ID + "' ");
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
        public bool Delete(string Cell_Chlid_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Cell_Children ");
            strSql.Append(" where Cell_Chlid_ID='" + Cell_Chlid_ID + "' ");
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
        public bool DeleteList(string Cell_Chlid_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Cell_Children ");
            strSql.Append(" where Cell_Chlid_ID in (" + Cell_Chlid_IDlist + ")  ");
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
        public WMS_Database.WH_Cell_ChildrenModel GetModel(string Cell_Chlid_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Cell_Chlid_ID,Cell_ID,Cell_Chlid_Position,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Flag,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Reserve1,Cell_Child_Reserve2,Cell_Child_Reserve3,Cell_Child_Reserve4,Cell_Child_Reserve5 ");
            strSql.Append(" from WH_Cell_Children ");
            strSql.Append(" where Cell_Chlid_ID='" + Cell_Chlid_ID + "' ");
            WMS_Database.WH_Cell_ChildrenModel model = new WMS_Database.WH_Cell_ChildrenModel();
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
        public WMS_Database.WH_Cell_ChildrenModel DataRowToModel(DataRow row)
        {
            WMS_Database.WH_Cell_ChildrenModel model = new WMS_Database.WH_Cell_ChildrenModel();
            if (row != null)
            {
                if (row["Cell_Chlid_ID"] != null)
                {
                    model.Cell_Chlid_ID = row["Cell_Chlid_ID"].ToString();
                }
                if (row["Cell_ID"] != null)
                {
                    model.Cell_ID = row["Cell_ID"].ToString();
                }
                if (row["Cell_Chlid_Position"] != null)
                {
                    model.Cell_Chlid_Position = row["Cell_Chlid_Position"].ToString();
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
                if (row["Cell_Child_Flag"] != null)
                {
                    model.Cell_Child_Flag = row["Cell_Child_Flag"].ToString();
                }
                if (row["Cell_Child_Operate_Type"] != null)
                {
                    model.Cell_Child_Operate_Type = row["Cell_Child_Operate_Type"].ToString();
                }
                if (row["Cell_Child_TaskLock_ID"] != null)
                {
                    model.Cell_Child_TaskLock_ID = row["Cell_Child_TaskLock_ID"].ToString();
                }
                if (row["Cell_Child_Reserve1"] != null)
                {
                    model.Cell_Child_Reserve1 = row["Cell_Child_Reserve1"].ToString();
                }
                if (row["Cell_Child_Reserve2"] != null)
                {
                    model.Cell_Child_Reserve2 = row["Cell_Child_Reserve2"].ToString();
                }
                if (row["Cell_Child_Reserve3"] != null)
                {
                    model.Cell_Child_Reserve3 = row["Cell_Child_Reserve3"].ToString();
                }
                if (row["Cell_Child_Reserve4"] != null)
                {
                    model.Cell_Child_Reserve4 = row["Cell_Child_Reserve4"].ToString();
                }
                if (row["Cell_Child_Reserve5"] != null)
                {
                    model.Cell_Child_Reserve5 = row["Cell_Child_Reserve5"].ToString();
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
            strSql.Append("select Cell_Chlid_ID,Cell_ID,Cell_Chlid_Position,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Flag,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Reserve1,Cell_Child_Reserve2,Cell_Child_Reserve3,Cell_Child_Reserve4,Cell_Child_Reserve5 ");
            strSql.Append(" FROM WH_Cell_Children ");
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
            strSql.Append(" Cell_Chlid_ID,Cell_ID,Cell_Chlid_Position,Cell_Child_Order,Cell_Child_InOut,Cell_Child_Model,Cell_Child_Status,Cell_Child_Run_Status,Cell_Child_Flag,Cell_Child_Operate_Type,Cell_Child_TaskLock_ID,Cell_Child_Reserve1,Cell_Child_Reserve2,Cell_Child_Reserve3,Cell_Child_Reserve4,Cell_Child_Reserve5 ");
            strSql.Append(" FROM WH_Cell_Children ");
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
            strSql.Append("select count(1) FROM WH_Cell_Children ");
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
                strSql.Append("order by T.Cell_Chlid_ID desc");
            }
            strSql.Append(")AS Row, T.*  from WH_Cell_Children T ");
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
        //public bool SetMultiGsSinleColEnbledStatus(string hosueAreaID, int rowth, int colth, string cellPos, bool status)
        //{
        //    string flag = "1";
        //    if(status == true)
        //    {
        //        flag = "1";
        //    }
        //    else
        //    {
        //        flag = "0";
        //    }
        //    string sqlStr = "update WH_Cell_Children set Cell_Child_Flag='" + flag + "' where Cell_ID in ( select WH_Cell.Cell_ID from WH_Cell where WH_Cell.Area_ID ='" + hosueAreaID + "'"
        //        + " and WH_Cell.Cell_Row=" + rowth + " and WH_Cell.Cell_Column ="+ colth +" and ";

        //}
		#endregion  ExtensionMethod
	}
}

