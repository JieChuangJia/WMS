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
using System.Collections.Generic;


namespace WMS_Database
{

    /// <summary>
    /// SysRoleBll
    /// </summary>
    public partial class SysRoleBll
    {
        private readonly SysRoleDal dal = new SysRoleDal();
        public SysRoleBll()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string SysRole_Name)
        {
            return dal.Exists(SysRole_Name);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(SysRoleModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(SysRoleModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string SysRole_Name)
        {

            return dal.Delete(SysRole_Name);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string SysRole_Namelist)
        {
            return dal.DeleteList(SysRole_Namelist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public SysRoleModel GetModel(string SysRole_Name)
        {

            return dal.GetModel(SysRole_Name);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<SysRoleModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<SysRoleModel> DataTableToList(DataTable dt)
        {
            List<SysRoleModel> modelList = new List<SysRoleModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                SysRoleModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        public List<SysRoleModel> GetModelByRoleInfo(string roleInfor)
        {
            if (roleInfor.Trim() == "")
            {
                return GetModelList("");
            }
            string sqlStr = "SysRole_Name like '%" + roleInfor + "%' or SysRole_Desc like '%" + roleInfor + "%'";
            List<SysRoleModel> roleList = GetModelList(sqlStr);
            if (roleList != null && roleList.Count != 0)
            {
                return roleList;
            }
            else
            {
                return null;
            }

        }
        #endregion  ExtensionMethod
    }
}

