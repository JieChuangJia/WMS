using System;
namespace WMS_Database
{
	/// <summary>
    /// PlanModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PlanMainModel
	{
        public PlanMainModel()
		{}
        #region Model
        private string _plan_id;
        private string _plan_type_id = "-1";
        private string _plan_serial_num;
        private string _plan_code = "";
        private DateTime? _plan_create_time;
        private DateTime? _plan_begin_time ;
        private DateTime? _plan_end_time ;
        private DateTime? _plan_bill_time;
        private string _plan_status = "0";
        private string _plan_operater = "";
        private string _plan_from_dept;
        private string _plan_to_dept;
        private string _plan_from_user;
        private string _plan_to_user;
        private string _plan_import_flag = "0";
        private string _plan_remark = "";
        private string _plan_reserve1;
        private string _plan_reserve2;
        private string _plan_reserve3;
        private string _plan_reserve4;
        private string _plan_reserve5;
        /// <summary>
        /// 流水号
        /// </summary>
        public string Plan_ID
        {
            set { _plan_id = value; }
            get { return _plan_id; }
        }
        /// <summary>
        /// 计划类型ID
        /// </summary>
        public string Plan_Type_ID
        {
            set { _plan_type_id = value; }
            get { return _plan_type_id; }
        }
        /// <summary>
        /// 计划流水号
        /// </summary>
        public string Plan_Serial_Num
        {
            set { _plan_serial_num = value; }
            get { return _plan_serial_num; }
        }
        /// <summary>
        /// 计划单号
        /// </summary>
        public string Plan_Code
        {
            set { _plan_code = value; }
            get { return _plan_code; }
        }
        /// <summary>
        /// 制单时间
        /// </summary>
        public DateTime? Plan_Create_Time
        {
            set { _plan_create_time = value; }
            get { return _plan_create_time; }
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? Plan_Begin_Time
        {
            set { _plan_begin_time = value; }
            get { return _plan_begin_time; }
        }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime? Plan_End_Time
        {
            set { _plan_end_time = value; }
            get { return _plan_end_time; }
        }
        /// <summary>
        /// 业务时间，生成业务数据
        /// </summary>
        public DateTime? Plan_Bill_Time
        {
            set { _plan_bill_time = value; }
            get { return _plan_bill_time; }
        }
        /// <summary>
        /// 计划状态
        /// </summary>
        public string Plan_Status
        {
            set { _plan_status = value; }
            get { return _plan_status; }
        }
        /// <summary>
        /// 操作员
        /// </summary>
        public string Plan_Operater
        {
            set { _plan_operater = value; }
            get { return _plan_operater; }
        }
        /// <summary>
        /// 发送单位
        /// </summary>
        public string Plan_From_Dept
        {
            set { _plan_from_dept = value; }
            get { return _plan_from_dept; }
        }
        /// <summary>
        /// 接收单位
        /// </summary>
        public string Plan_To_Dept
        {
            set { _plan_to_dept = value; }
            get { return _plan_to_dept; }
        }
        /// <summary>
        /// 发送人
        /// </summary>
        public string Plan_From_User
        {
            set { _plan_from_user = value; }
            get { return _plan_from_user; }
        }
        /// <summary>
        /// 接收人
        /// </summary>
        public string Plan_To_User
        {
            set { _plan_to_user = value; }
            get { return _plan_to_user; }
        }
        /// <summary>
        /// 导入标志
        /// </summary>
        public string Plan_Import_Flag
        {
            set { _plan_import_flag = value; }
            get { return _plan_import_flag; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Plan_Remark
        {
            set { _plan_remark = value; }
            get { return _plan_remark; }
        }
        /// <summary>
        /// 备用1
        /// </summary>
        public string Plan_Reserve1
        {
            set { _plan_reserve1 = value; }
            get { return _plan_reserve1; }
        }
        /// <summary>
        /// 备用2
        /// </summary>
        public string Plan_Reserve2
        {
            set { _plan_reserve2 = value; }
            get { return _plan_reserve2; }
        }
        /// <summary>
        /// 备用3
        /// </summary>
        public string Plan_Reserve3
        {
            set { _plan_reserve3 = value; }
            get { return _plan_reserve3; }
        }
        /// <summary>
        /// 备用4
        /// </summary>
        public string Plan_Reserve4
        {
            set { _plan_reserve4 = value; }
            get { return _plan_reserve4; }
        }
        /// <summary>
        /// 备用5
        /// </summary>
        public string Plan_Reserve5
        {
            set { _plan_reserve5 = value; }
            get { return _plan_reserve5; }
        }
        #endregion Model
	}
}

