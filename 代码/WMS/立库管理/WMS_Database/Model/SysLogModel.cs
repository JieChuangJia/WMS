using System;
namespace WMS_Database
{
    /// <summary>
    /// SysLog:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class SysLogModel
    {
        public SysLogModel()
        { }
        #region Model
        private string _syslog_id;
        private string _syslog_source;
        private string _syslog_level;
        private DateTime _syslog_time;
        private string _syslog_content;
        private string _syslog_reserve1;
        private string _syslog_reserve2;
        /// <summary>
        /// 
        /// </summary>
        public string SysLog_ID
        {
            set { _syslog_id = value; }
            get { return _syslog_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SysLog_Source
        {
            set { _syslog_source = value; }
            get { return _syslog_source; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SysLog_Level
        {
            set { _syslog_level = value; }
            get { return _syslog_level; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SysLog_Time
        {
            set { _syslog_time = value; }
            get { return _syslog_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SysLog_Content
        {
            set { _syslog_content = value; }
            get { return _syslog_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SysLog_Reserve1
        {
            set { _syslog_reserve1 = value; }
            get { return _syslog_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SysLog_Reserve2
        {
            set { _syslog_reserve2 = value; }
            get { return _syslog_reserve2; }
        }
        #endregion Model

    }
}

