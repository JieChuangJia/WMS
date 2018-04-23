using System;
namespace WMS_Database
{
	/// <summary>
	/// ManageModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ManageModel
	{
		public ManageModel()
		{}
        #region Model
        private string _mange_id;
        private string _plan_id = "-1";
        private string _mange_type_id = "";
        private string _mange_status = "0";
        private string _mange_stock_barcode = "";
        private string _mange_full_flag = "1";
        private string _manage_breakdown_status;
        private string _mange_start_cell_id = "-1";
        private string _mange_end_cell_id = "-1";
        private string _manage_operater = "-1";
        private DateTime? _manage_begin_time =null;
        private DateTime? _manage_end_time = null;
        private string _manage_remark = "";
        private string _mange_reserve1;
        private string _mange_reserve2;
        private string _mange_reserve3;
        private string _mange_reserve4;
        private string _mange_reserve5;
        /// <summary>
        /// 任务编号
        /// </summary>
        public string Mange_ID
        {
            set { _mange_id = value; }
            get { return _mange_id; }
        }
        /// <summary>
        /// 计划索引
        /// </summary>
        public string Plan_ID
        {
            set { _plan_id = value; }
            get { return _plan_id; }
        }
        /// <summary>
        /// 管理任务类型
        /// </summary>
        public string Mange_Type_ID
        {
            set { _mange_type_id = value; }
            get { return _mange_type_id; }
        }
        /// <summary>
        /// 任务状态
        /// </summary>
        public string Mange_Status
        {
            set { _mange_status = value; }
            get { return _mange_status; }
        }
        /// <summary>
        /// 托盘条码
        /// </summary>
        public string Mange_Stock_Barcode
        {
            set { _mange_stock_barcode = value; }
            get { return _mange_stock_barcode; }
        }
        /// <summary>
        /// 是否满货位，1满0部分
        /// </summary>
        public string Mange_Full_Flag
        {
            set { _mange_full_flag = value; }
            get { return _mange_full_flag; }
        }
        /// <summary>
        /// 管理任务处理状态，是否分解为成控制任务
        /// </summary>
        public string Manage_BreakDown_Status
        {
            set { _manage_breakdown_status = value; }
            get { return _manage_breakdown_status; }
        }
        /// <summary>
        /// 起始位置
        /// </summary>
        public string Mange_Start_Cell_ID
        {
            set { _mange_start_cell_id = value; }
            get { return _mange_start_cell_id; }
        }
        /// <summary>
        /// 终止位置
        /// </summary>
        public string Mange_End_Cell_ID
        {
            set { _mange_end_cell_id = value; }
            get { return _mange_end_cell_id; }
        }
        /// <summary>
        /// 操作者索引
        /// </summary>
        public string Manage_Operater
        {
            set { _manage_operater = value; }
            get { return _manage_operater; }
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? Manage_Begin_Time
        {
            set { _manage_begin_time = value; }
            get { return _manage_begin_time; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? Manage_End_Time
        {
            set { _manage_end_time = value; }
            get { return _manage_end_time; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Manage_Remark
        {
            set { _manage_remark = value; }
            get { return _manage_remark; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Mange_Reserve1
        {
            set { _mange_reserve1 = value; }
            get { return _mange_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_Reserve2
        {
            set { _mange_reserve2 = value; }
            get { return _mange_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_Reserve3
        {
            set { _mange_reserve3 = value; }
            get { return _mange_reserve3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_Reserve4
        {
            set { _mange_reserve4 = value; }
            get { return _mange_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_Reserve5
        {
            set { _mange_reserve5 = value; }
            get { return _mange_reserve5; }
        }
        #endregion Model
	}
}

