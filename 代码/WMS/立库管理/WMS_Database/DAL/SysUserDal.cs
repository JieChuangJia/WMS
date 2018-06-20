/**  版本信息模板在安装目录下，可自行修改。
* User.cs
*
* 功 能： N/A
* 类 名： User
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
    /// 数据访问类:SysUser
    /// </summary>
    public partial class SysUserDal
    {
        public SysUserDal()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string SysUser_Name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SysUser");
            strSql.Append(" where SysUser_Name=@lSysUser_Name ");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysUser_Name", SqlDbType.NVarChar,50)			};
            parameters[0].Value = SysUser_Name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(SysUserModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SysUser(");
            strSql.Append("SysUser_Name,SysUser_Password,SysRole_Name,SysUser_Reserve)");
            strSql.Append(" values (");
            strSql.Append("@lSysUser_Name,@lSysUser_Password,@lSysRole_Name,@lSysUser_Reserve)");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysUser_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@lSysUser_Password", SqlDbType.NVarChar,50),
					new SqlParameter("@lSysRole_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@lSysUser_Reserve", SqlDbType.NVarChar,100)};
            parameters[0].Value = model.SysUser_Name;
            parameters[1].Value = model.SysUser_Password;
            parameters[2].Value = model.SysRole_Name;
            parameters[3].Value = model.SysUser_Reserve;

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
        public bool Update(SysUserModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SysUser set ");
            strSql.Append("SysUser_Password=@lSysUser_Password,");
            strSql.Append("SysRole_Name=@lSysRole_Name,");
            strSql.Append("SysUser_Reserve=@lSysUser_Reserve");
            strSql.Append(" where SysUser_Name=@lSysUser_Name ");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysUser_Password", SqlDbType.NVarChar,50),
					new SqlParameter("@lSysRole_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@lSysUser_Reserve", SqlDbType.NVarChar,100),
					new SqlParameter("@lSysUser_Name", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SysUser_Password;
            parameters[1].Value = model.SysRole_Name;
            parameters[2].Value = model.SysUser_Reserve;
            parameters[3].Value = model.SysUser_Name;

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
        public bool Delete(string SysUser_Name)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SysUser ");
            strSql.Append(" where SysUser_Name=@lSysUser_Name ");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysUser_Name", SqlDbType.NVarChar,50)			};
            parameters[0].Value = SysUser_Name;

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
        public bool DeleteList(string SysUser_Namelist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SysUser ");
            strSql.Append(" where SysUser_Name in (" + SysUser_Namelist + ")  ");
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
        public SysUserModel GetModel(string SysUser_Name)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 SysUser_Name,SysUser_Password,SysRole_Name,SysUser_Reserve from SysUser ");
            strSql.Append(" where SysUser_Name=@lSysUser_Name ");
            SqlParameter[] parameters = {
					new SqlParameter("@lSysUser_Name", SqlDbType.NVarChar,50)			};
            parameters[0].Value = SysUser_Name;

            SysUserModel model = new SysUserModel();
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
        public SysUserModel DataRowToModel(DataRow row)
        {
            SysUserModel model = new SysUserModel();
            if (row != null)
            {
                if (row["SysUser_Name"] != null)
                {
                    model.SysUser_Name = row["SysUser_Name"].ToString();
                }
                if (row["SysUser_Password"] != null)
                {
                    model.SysUser_Password = row["SysUser_Password"].ToString();
                }
                if (row["SysRole_Name"] != null)
                {
                    model.SysRole_Name = row["SysRole_Name"].ToString();
                }
                if (row["SysUser_Reserve"] != null)
                {
                    model.SysUser_Reserve = row["SysUser_Reserve"].ToString();
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
            strSql.Append("select SysUser_Name,SysUser_Password,SysRole_Name,SysUser_Reserve ");
            strSql.Append(" FROM SysUser ");
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
            strSql.Append(" SysUser_Name,SysUser_Password,SysRole_Name,SysUser_Reserve ");
            strSql.Append(" FROM SysUser ");
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
            strSql.Append("select count(1) FROM SysUser ");
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
                strSql.Append("order by T.SysUser_Name desc");
            }
            strSql.Append(")AS Row, T.*  from SysUser T ");
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
            parameters[0].Value = "SysUser";
            parameters[1].Value = "SysUser_Name";
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

