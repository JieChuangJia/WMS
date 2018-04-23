using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:Control
    /// </summary>
    public partial class ControlDAL
    {
        public ControlDAL()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Contorl_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Control");
            strSql.Append(" where Contorl_ID='" + Contorl_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.ControlModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Contorl_ID != null)
            {
                strSql1.Append("Contorl_ID,");
                strSql2.Append("'" + model.Contorl_ID + "',");
            }
            if (model.Manage_ID != null)
            {
                strSql1.Append("Manage_ID,");
                strSql2.Append("'" + model.Manage_ID + "',");
            }
            if (model.Contorl_Tray_Barcode != null)
            {
                strSql1.Append("Contorl_Tray_Barcode,");
                strSql2.Append("'" + model.Contorl_Tray_Barcode + "',");
            }
            if (model.Control_Task_Type != null)
            {
                strSql1.Append("Control_Task_Type,");
                strSql2.Append("'" + model.Control_Task_Type + "',");
            }
            if (model.Control_Task_Priority != null)
            {
                strSql1.Append("Control_Task_Priority,");
                strSql2.Append("'" + model.Control_Task_Priority + "',");
            }
            if (model.Control_Start_WH_Code != null)
            {
                strSql1.Append("Control_Start_WH_Code,");
                strSql2.Append("'" + model.Control_Start_WH_Code + "',");
            }
            if (model.Control_Start_Device_Code != null)
            {
                strSql1.Append("Control_Start_Device_Code,");
                strSql2.Append("'" + model.Control_Start_Device_Code + "',");
            }
            if (model.Control_End_WH_Code != null)
            {
                strSql1.Append("Control_End_WH_Code,");
                strSql2.Append("'" + model.Control_End_WH_Code + "',");
            }
            if (model.Control_End_Device_Code != null)
            {
                strSql1.Append("Control_End_Device_Code,");
                strSql2.Append("'" + model.Control_End_Device_Code + "',");
            }
            if (model.Control_Params != null)
            {
                strSql1.Append("Control_Params,");
                strSql2.Append("'" + model.Control_Params + "',");
            }
            if (model.Control_Phase != null)
            {
                strSql1.Append("Control_Phase,");
                strSql2.Append("" + model.Control_Phase + ",");
            }
            if (model.Control_Status != null)
            {
                strSql1.Append("Control_Status,");
                strSql2.Append("'" + model.Control_Status + "',");
            }
            if (model.Control_Error_Text != null)
            {
                strSql1.Append("Control_Error_Text,");
                strSql2.Append("'" + model.Control_Error_Text + "',");
            }
            if (model.Control_Begin_Time != null)
            {
                strSql1.Append("Control_Begin_Time,");
                strSql2.Append("'" + model.Control_Begin_Time + "',");
            }
            if (model.Contorl_End_Time != null)
            {
                strSql1.Append("Contorl_End_Time,");
                strSql2.Append("'" + model.Contorl_End_Time + "',");
            }
            if (model.Control_Remark != null)
            {
                strSql1.Append("Control_Remark,");
                strSql2.Append("'" + model.Control_Remark + "',");
            }
            if (model.Control_Reserve1 != null)
            {
                strSql1.Append("Control_Reserve1,");
                strSql2.Append("'" + model.Control_Reserve1 + "',");
            }
            if (model.Control_Reserve2 != null)
            {
                strSql1.Append("Control_Reserve2,");
                strSql2.Append("'" + model.Control_Reserve2 + "',");
            }
            if (model.Control_Reserve3 != null)
            {
                strSql1.Append("Control_Reserve3,");
                strSql2.Append("'" + model.Control_Reserve3 + "',");
            }
            if (model.Control_Reserve4 != null)
            {
                strSql1.Append("Control_Reserve4,");
                strSql2.Append("'" + model.Control_Reserve4 + "',");
            }
            if (model.Control_Reserve5 != null)
            {
                strSql1.Append("Control_Reserve5,");
                strSql2.Append("'" + model.Control_Reserve5 + "',");
            }
            strSql.Append("insert into Control(");
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
        public bool Update(WMS_Database.ControlModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Control set ");
            if (model.Manage_ID != null)
            {
                strSql.Append("Manage_ID='" + model.Manage_ID + "',");
            }
            if (model.Contorl_Tray_Barcode != null)
            {
                strSql.Append("Contorl_Tray_Barcode='" + model.Contorl_Tray_Barcode + "',");
            }
            else
            {
                strSql.Append("Contorl_Tray_Barcode= null ,");
            }
            if (model.Control_Task_Type != null)
            {
                strSql.Append("Control_Task_Type='" + model.Control_Task_Type + "',");
            }
            if (model.Control_Task_Priority != null)
            {
                strSql.Append("Control_Task_Priority='" + model.Control_Task_Priority + "',");
            }
            else
            {
                strSql.Append("Control_Task_Priority= null ,");
            }
            if (model.Control_Start_WH_Code != null)
            {
                strSql.Append("Control_Start_WH_Code='" + model.Control_Start_WH_Code + "',");
            }
            else
            {
                strSql.Append("Control_Start_WH_Code= null ,");
            }
            if (model.Control_Start_Device_Code != null)
            {
                strSql.Append("Control_Start_Device_Code='" + model.Control_Start_Device_Code + "',");
            }
            else
            {
                strSql.Append("Control_Start_Device_Code= null ,");
            }
            if (model.Control_End_WH_Code != null)
            {
                strSql.Append("Control_End_WH_Code='" + model.Control_End_WH_Code + "',");
            }
            else
            {
                strSql.Append("Control_End_WH_Code= null ,");
            }
            if (model.Control_End_Device_Code != null)
            {
                strSql.Append("Control_End_Device_Code='" + model.Control_End_Device_Code + "',");
            }
            else
            {
                strSql.Append("Control_End_Device_Code= null ,");
            }
            if (model.Control_Params != null)
            {
                strSql.Append("Control_Params='" + model.Control_Params + "',");
            }
            else
            {
                strSql.Append("Control_Params= null ,");
            }
            if (model.Control_Phase != null)
            {
                strSql.Append("Control_Phase=" + model.Control_Phase + ",");
            }
            if (model.Control_Status != null)
            {
                strSql.Append("Control_Status='" + model.Control_Status + "',");
            }
            else
            {
                strSql.Append("Control_Status= null ,");
            }
            if (model.Control_Error_Text != null)
            {
                strSql.Append("Control_Error_Text='" + model.Control_Error_Text + "',");
            }
            else
            {
                strSql.Append("Control_Error_Text= null ,");
            }
            if (model.Control_Begin_Time != null)
            {
                strSql.Append("Control_Begin_Time='" + model.Control_Begin_Time + "',");
            }
            else
            {
                strSql.Append("Control_Begin_Time= null ,");
            }
            if (model.Contorl_End_Time != null)
            {
                strSql.Append("Contorl_End_Time='" + model.Contorl_End_Time + "',");
            }
            else
            {
                strSql.Append("Contorl_End_Time= null ,");
            }
            if (model.Control_Remark != null)
            {
                strSql.Append("Control_Remark='" + model.Control_Remark + "',");
            }
            else
            {
                strSql.Append("Control_Remark= null ,");
            }
            if (model.Control_Reserve1 != null)
            {
                strSql.Append("Control_Reserve1='" + model.Control_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Control_Reserve1= null ,");
            }
            if (model.Control_Reserve2 != null)
            {
                strSql.Append("Control_Reserve2='" + model.Control_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Control_Reserve2= null ,");
            }
            if (model.Control_Reserve3 != null)
            {
                strSql.Append("Control_Reserve3='" + model.Control_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Control_Reserve3= null ,");
            }
            if (model.Control_Reserve4 != null)
            {
                strSql.Append("Control_Reserve4='" + model.Control_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Control_Reserve4= null ,");
            }
            if (model.Control_Reserve5 != null)
            {
                strSql.Append("Control_Reserve5='" + model.Control_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Control_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Contorl_ID='" + model.Contorl_ID + "' ");
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
        public bool Delete(string Contorl_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Control ");
            strSql.Append(" where Contorl_ID='" + Contorl_ID + "' ");
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
        public bool DeleteList(string Contorl_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Control ");
            strSql.Append(" where Contorl_ID in (" + Contorl_IDlist + ")  ");
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
        public WMS_Database.ControlModel GetModel(string Contorl_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Contorl_ID,Manage_ID,Contorl_Tray_Barcode,Control_Task_Type,Control_Task_Priority,Control_Start_WH_Code,Control_Start_Device_Code,Control_End_WH_Code,Control_End_Device_Code,Control_Params,Control_Phase,Control_Status,Control_Error_Text,Control_Begin_Time,Contorl_End_Time,Control_Remark,Control_Reserve1,Control_Reserve2,Control_Reserve3,Control_Reserve4,Control_Reserve5 ");
            strSql.Append(" from Control ");
            strSql.Append(" where Contorl_ID='" + Contorl_ID + "' ");
            WMS_Database.ControlModel model = new WMS_Database.ControlModel();
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
        public WMS_Database.ControlModel DataRowToModel(DataRow row)
        {
            WMS_Database.ControlModel model = new WMS_Database.ControlModel();
            if (row != null)
            {
                if (row["Contorl_ID"] != null)
                {
                    model.Contorl_ID = row["Contorl_ID"].ToString();
                }
                if (row["Manage_ID"] != null)
                {
                    model.Manage_ID = row["Manage_ID"].ToString();
                }
                if (row["Contorl_Tray_Barcode"] != null)
                {
                    model.Contorl_Tray_Barcode = row["Contorl_Tray_Barcode"].ToString();
                }
                if (row["Control_Task_Type"] != null)
                {
                    model.Control_Task_Type = row["Control_Task_Type"].ToString();
                }
                if (row["Control_Task_Priority"] != null)
                {
                    model.Control_Task_Priority = row["Control_Task_Priority"].ToString();
                }
                if (row["Control_Start_WH_Code"] != null)
                {
                    model.Control_Start_WH_Code = row["Control_Start_WH_Code"].ToString();
                }
                if (row["Control_Start_Device_Code"] != null)
                {
                    model.Control_Start_Device_Code = row["Control_Start_Device_Code"].ToString();
                }
                if (row["Control_End_WH_Code"] != null)
                {
                    model.Control_End_WH_Code = row["Control_End_WH_Code"].ToString();
                }
                if (row["Control_End_Device_Code"] != null)
                {
                    model.Control_End_Device_Code = row["Control_End_Device_Code"].ToString();
                }
                if (row["Control_Params"] != null)
                {
                    model.Control_Params = row["Control_Params"].ToString();
                }
                if (row["Control_Phase"] != null && row["Control_Phase"].ToString() != "")
                {
                    model.Control_Phase = int.Parse(row["Control_Phase"].ToString());
                }
                if (row["Control_Status"] != null)
                {
                    model.Control_Status = row["Control_Status"].ToString();
                }
                if (row["Control_Error_Text"] != null)
                {
                    model.Control_Error_Text = row["Control_Error_Text"].ToString();
                }
                if (row["Control_Begin_Time"] != null && row["Control_Begin_Time"].ToString() != "")
                {
                    model.Control_Begin_Time = DateTime.Parse(row["Control_Begin_Time"].ToString());
                }
                if (row["Contorl_End_Time"] != null && row["Contorl_End_Time"].ToString() != "")
                {
                    model.Contorl_End_Time = DateTime.Parse(row["Contorl_End_Time"].ToString());
                }
                if (row["Control_Remark"] != null)
                {
                    model.Control_Remark = row["Control_Remark"].ToString();
                }
                if (row["Control_Reserve1"] != null)
                {
                    model.Control_Reserve1 = row["Control_Reserve1"].ToString();
                }
                if (row["Control_Reserve2"] != null)
                {
                    model.Control_Reserve2 = row["Control_Reserve2"].ToString();
                }
                if (row["Control_Reserve3"] != null)
                {
                    model.Control_Reserve3 = row["Control_Reserve3"].ToString();
                }
                if (row["Control_Reserve4"] != null)
                {
                    model.Control_Reserve4 = row["Control_Reserve4"].ToString();
                }
                if (row["Control_Reserve5"] != null)
                {
                    model.Control_Reserve5 = row["Control_Reserve5"].ToString();
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
            strSql.Append("select Contorl_ID,Manage_ID,Contorl_Tray_Barcode,Control_Task_Type,Control_Task_Priority,Control_Start_WH_Code,Control_Start_Device_Code,Control_End_WH_Code,Control_End_Device_Code,Control_Params,Control_Phase,Control_Status,Control_Error_Text,Control_Begin_Time,Contorl_End_Time,Control_Remark,Control_Reserve1,Control_Reserve2,Control_Reserve3,Control_Reserve4,Control_Reserve5 ");
            strSql.Append(" FROM Control ");
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
            strSql.Append(" Contorl_ID,Manage_ID,Contorl_Tray_Barcode,Control_Task_Type,Control_Task_Priority,Control_Start_WH_Code,Control_Start_Device_Code,Control_End_WH_Code,Control_End_Device_Code,Control_Params,Control_Phase,Control_Status,Control_Error_Text,Control_Begin_Time,Contorl_End_Time,Control_Remark,Control_Reserve1,Control_Reserve2,Control_Reserve3,Control_Reserve4,Control_Reserve5 ");
            strSql.Append(" FROM Control ");
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
            strSql.Append("select count(1) FROM Control ");
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
                strSql.Append("order by T.Contorl_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Control T ");
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

