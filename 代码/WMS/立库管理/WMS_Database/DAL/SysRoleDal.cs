/**  版本信息模板在安装目录下，可自行修改。
* UserRole.cs
*
* 功 能： N/A
* 类 名： UserRole
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018-06-10 6:28:13 PM   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace WMS_Database
{
    /// <summary>
    /// 数据访问类:SysRoleDal
    /// </summary>
    public partial class SysRoleDal
    {
        public SysRoleDal()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string SysRole_Name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SysRole");
            strSql.Append(" where SysRole_Name=@lSysRole_Name ");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysRole_Name", SqlDbType.NVarChar,50)			};
            parameters[0].Value = SysRole_Name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(SysRoleModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SysRole(");
            strSql.Append("SysRole_Name,SysRole_Level,SysRole_Desc,SysRole_Remark)");
            strSql.Append(" values (");
            strSql.Append("@lSysRole_Name,@lSysRole_Level,@lSysRole_Desc,@lSysRole_Remark)");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysRole_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@lSysRole_Level", SqlDbType.Int,4),
					new SqlParameter("@lSysRole_Desc", SqlDbType.NVarChar,100),
					new SqlParameter("@lSysRole_Remark", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SysRole_Name;
            parameters[1].Value = model.SysRole_Level;
            parameters[2].Value = model.SysRole_Desc;
            parameters[3].Value = model.SysRole_Remark;

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
        public bool Update(SysRoleModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SysRole set ");
            strSql.Append("SysRole_Level=@lSysRole_Level,");
            strSql.Append("SysRole_Desc=@lSysRole_Desc,");
            strSql.Append("SysRole_Remark=@lSysRole_Remark");
            strSql.Append(" where SysRole_Name=@lSysRole_Name ");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysRole_Level", SqlDbType.Int,4),
					new SqlParameter("@lSysRole_Desc", SqlDbType.NVarChar,100),
					new SqlParameter("@lSysRole_Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@lSysRole_Name", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SysRole_Level;
            parameters[1].Value = model.SysRole_Desc;
            parameters[2].Value = model.SysRole_Remark;
            parameters[3].Value = model.SysRole_Name;

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
        public bool Delete(string SysRole_Name)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SysRole ");
            strSql.Append(" where SysRole_Name=@lSysRole_Name ");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysRole_Name", SqlDbType.NVarChar,50)			};
            parameters[0].Value = SysRole_Name;

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
        public bool DeleteList(string SysRole_Namelist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SysRole ");
            strSql.Append(" where SysRole_Name in (" + SysRole_Namelist + ")  ");
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
        public SysRoleModel GetModel(string SysRole_Name)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 SysRole_Name,SysRole_Level,SysRole_Desc,SysRole_Remark from SysRole ");
            strSql.Append(" where SysRole_Name=@lSysRole_Name ");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysRole_Name", SqlDbType.NVarChar,50)			};
            parameters[0].Value = SysRole_Name;

            SysRoleModel model = new SysRoleModel();
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
        public SysRoleModel DataRowToModel(DataRow row)
        {
            SysRoleModel model = new SysRoleModel();
            if (row != null)
            {
                if (row["SysRole_Name"] != null)
                {
                    model.SysRole_Name = row["SysRole_Name"].ToString();
                }
                if (row["SysRole_Level"] != null && row["SysRole_Level"].ToString() != "")
                {
                    model.SysRole_Level = int.Parse(row["SysRole_Level"].ToString());
                }
                if (row["SysRole_Desc"] != null)
                {
                    model.SysRole_Desc = row["SysRole_Desc"].ToString();
                }
                if (row["SysRole_Remark"] != null)
                {
                    model.SysRole_Remark = row["SysRole_Remark"].ToString();
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
            strSql.Append("select SysRole_Name,SysRole_Level,SysRole_Desc,SysRole_Remark ");
            strSql.Append(" FROM SysRole ");
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
            strSql.Append(" SysRole_Name,SysRole_Level,SysRole_Desc,SysRole_Remark ");
            strSql.Append(" FROM SysRole ");
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
            strSql.Append("select count(1) FROM SysRole ");
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
                strSql.Append("order by T.SysRole_Name desc");
            }
            strSql.Append(")AS Row, T.*  from SysRole T ");
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
                    new SqlParameter("@ltblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@lfldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@lPageSize", SqlDbType.Int),
                    new SqlParameter("@lPageIndex", SqlDbType.Int),
                    new SqlParameter("@lIsReCount", SqlDbType.Bit),
                    new SqlParameter("@lOrderType", SqlDbType.Bit),
                    new SqlParameter("@lstrWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "SysRole";
            parameters[1].Value = "SysRole_Name";
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

