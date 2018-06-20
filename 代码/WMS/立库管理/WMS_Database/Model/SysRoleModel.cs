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
namespace WMS_Database
{
    /// <summary>
    /// SysRoleModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class SysRoleModel
    {
        public SysRoleModel()
        { }
        #region Model
        private string _sysrole_name;
        private int _sysrole_level;
        private string _sysrole_desc;
        private string _sysrole_remark;
        /// <summary>
        /// 
        /// </summary>
        public string SysRole_Name
        {
            set { _sysrole_name = value; }
            get { return _sysrole_name; }
        }
        /// <summary>
        /// 用户角色权限级别
        /// </summary>
        public int SysRole_Level
        {
            set { _sysrole_level = value; }
            get { return _sysrole_level; }
        }
        /// <summary>
        /// 用户描述
        /// </summary>
        public string SysRole_Desc
        {
            set { _sysrole_desc = value; }
            get { return _sysrole_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SysRole_Remark
        {
            set { _sysrole_remark = value; }
            get { return _sysrole_remark; }
        }
        #endregion Model

    }
}

