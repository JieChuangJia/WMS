using System;
namespace JBS_APPDB
{
    /// <summary>
    /// ERP_Plan_Report:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ERP_Plan_ReportModel
    {
        public ERP_Plan_ReportModel()
        { }
        #region Model
        private string _erp_plan_report_id;
        private string _erp_plan_code;
        private string _erp_plan_report_content;
        private bool _erp_plan_isreported;
        private string _erp_plan_remark;
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Plan_Report_ID
        {
            set { _erp_plan_report_id = value; }
            get { return _erp_plan_report_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Plan_Code
        {
            set { _erp_plan_code = value; }
            get { return _erp_plan_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Plan_Report_Content
        {
            set { _erp_plan_report_content = value; }
            get { return _erp_plan_report_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool ERP_Plan_IsReported
        {
            set { _erp_plan_isreported = value; }
            get { return _erp_plan_isreported; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Plan_Remark
        {
            set { _erp_plan_remark = value; }
            get { return _erp_plan_remark; }
        }
        #endregion Model

    }
}

