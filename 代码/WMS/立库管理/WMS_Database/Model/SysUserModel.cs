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
namespace WMS_Database
{
    /// <summary>
    /// SysUserModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class SysUserModel
    {
        public SysUserModel()
        { }
        #region Model
        private string _sysuser_name;
        private string _sysuser_password;
        private string _sysrole_name;
        private string _sysuser_reserve;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string SysUser_Name
        {
            set { _sysuser_name = value; }
            get { return _sysuser_name; }
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string SysUser_Password
        {
            set { _sysuser_password = value; }
            get { return _sysuser_password; }
        }
        /// <summary>
        /// 用户角色ID
        /// </summary>
        public string SysRole_Name
        {
            set { _sysrole_name = value; }
            get { return _sysrole_name; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string SysUser_Reserve
        {
            set { _sysuser_reserve = value; }
            get { return _sysuser_reserve; }
        }
        #endregion Model

    }
}

