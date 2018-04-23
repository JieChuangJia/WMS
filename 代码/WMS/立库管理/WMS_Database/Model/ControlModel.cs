using System;
namespace WMS_Database
{
    /// <summary>
    /// Control:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ControlModel
    {
        public ControlModel()
        { }
        #region Model
        private string _contorl_id;
        private string _manage_id = "-1";
        private string _contorl_tray_barcode = "";
        private string _control_task_type = "-1";
        private string _control_task_priority = "0";
        private string _control_start_wh_code = "";
        private string _control_start_device_code = "";
        private string _control_end_wh_code = "";
        private string _control_end_device_code = "";
        private string _control_params;
        private int _control_phase;
        private string _control_status = "0";
        private string _control_error_text = "";
        private DateTime? _control_begin_time = Convert.ToDateTime("");
        private DateTime? _contorl_end_time = Convert.ToDateTime("");
        private string _control_remark = "";
        private string _control_reserve1;
        private string _control_reserve2;
        private string _control_reserve3;
        private string _control_reserve4;
        private string _control_reserve5;
        /// <summary>
        /// 控制编号
        /// </summary>
        public string Contorl_ID
        {
            set { _contorl_id = value; }
            get { return _contorl_id; }
        }
        /// <summary>
        /// 管理任务索引
        /// </summary>
        public string Manage_ID
        {
            set { _manage_id = value; }
            get { return _manage_id; }
        }
        /// <summary>
        /// 托盘条码
        /// </summary>
        public string Contorl_Tray_Barcode
        {
            set { _contorl_tray_barcode = value; }
            get { return _contorl_tray_barcode; }
        }
        /// <summary>
        /// 监控任务类型
        /// </summary>
        public string Control_Task_Type
        {
            set { _control_task_type = value; }
            get { return _control_task_type; }
        }
        /// <summary>
        /// 监控任务优先级
        /// </summary>
        public string Control_Task_Priority
        {
            set { _control_task_priority = value; }
            get { return _control_task_priority; }
        }
        /// <summary>
        /// 起始仓库编码
        /// </summary>
        public string Control_Start_WH_Code
        {
            set { _control_start_wh_code = value; }
            get { return _control_start_wh_code; }
        }
        /// <summary>
        /// 起始位置
        /// </summary>
        public string Control_Start_Device_Code
        {
            set { _control_start_device_code = value; }
            get { return _control_start_device_code; }
        }
        /// <summary>
        /// 终止仓库编码
        /// </summary>
        public string Control_End_WH_Code
        {
            set { _control_end_wh_code = value; }
            get { return _control_end_wh_code; }
        }
        /// <summary>
        /// 终止位置
        /// </summary>
        public string Control_End_Device_Code
        {
            set { _control_end_device_code = value; }
            get { return _control_end_device_code; }
        }
        /// <summary>
        /// 任务参数
        /// </summary>
        public string Control_Params
        {
            set { _control_params = value; }
            get { return _control_params; }
        }
        /// <summary>
        /// 任务阶段
        /// </summary>
        public int Control_Phase
        {
            set { _control_phase = value; }
            get { return _control_phase; }
        }
        /// <summary>
        /// 状态
        /// </summary>
        public string Control_Status
        {
            set { _control_status = value; }
            get { return _control_status; }
        }
        /// <summary>
        /// 出错信息
        /// </summary>
        public string Control_Error_Text
        {
            set { _control_error_text = value; }
            get { return _control_error_text; }
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? Control_Begin_Time
        {
            set { _control_begin_time = value; }
            get { return _control_begin_time; }
        }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime? Contorl_End_Time
        {
            set { _contorl_end_time = value; }
            get { return _contorl_end_time; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Control_Remark
        {
            set { _control_remark = value; }
            get { return _control_remark; }
        }
        /// <summary>
        /// 备用1
        /// </summary>
        public string Control_Reserve1
        {
            set { _control_reserve1 = value; }
            get { return _control_reserve1; }
        }
        /// <summary>
        /// 备用2
        /// </summary>
        public string Control_Reserve2
        {
            set { _control_reserve2 = value; }
            get { return _control_reserve2; }
        }
        /// <summary>
        /// 备用3
        /// </summary>
        public string Control_Reserve3
        {
            set { _control_reserve3 = value; }
            get { return _control_reserve3; }
        }
        /// <summary>
        /// 备用4
        /// </summary>
        public string Control_Reserve4
        {
            set { _control_reserve4 = value; }
            get { return _control_reserve4; }
        }
        /// <summary>
        /// 备用5
        /// </summary>
        public string Control_Reserve5
        {
            set { _control_reserve5 = value; }
            get { return _control_reserve5; }
        }
        #endregion Model

    }
}

