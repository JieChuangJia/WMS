using System;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	[Serializable]
	public partial class RecordModel
	{
        public RecordModel()
		{}
        #region Model
        private string _record_id;
        private string _plan_id = "-1";
        private string _manage_type_code = "";
        private string _stock_tray_barcode = "";
        private string _start_cell_id = "-1";
        private string _end_cell_id = "-1";
        private string _manage_operater = "-1";
        private DateTime? _manage_begin_time = Convert.ToDateTime("");
        private DateTime? _manage_end_time = Convert.ToDateTime("");
        private string _record_remark = "";
        private string _record_reserve1;
        private string _record_reserve2;
        private string _record_reserve3;
        private string _record_reserve4;
        private string _record_reserve5;
        /// <summary>
        /// 记录编号
        /// </summary>
        public string Record_ID
        {
            set { _record_id = value; }
            get { return _record_id; }
        }
        /// <summary>
        /// 入库计划详单索引
        /// </summary>
        public string Plan_ID
        {
            set { _plan_id = value; }
            get { return _plan_id; }
        }
        /// <summary>
        /// 任务类型
        /// </summary>
        public string Manage_Type_Code
        {
            set { _manage_type_code = value; }
            get { return _manage_type_code; }
        }
        /// <summary>
        /// 托盘条码
        /// </summary>
        public string Stock_Tray_Barcode
        {
            set { _stock_tray_barcode = value; }
            get { return _stock_tray_barcode; }
        }
        /// <summary>
        /// 开始位置
        /// </summary>
        public string Start_Cell_ID
        {
            set { _start_cell_id = value; }
            get { return _start_cell_id; }
        }
        /// <summary>
        /// 终止位置
        /// </summary>
        public string End_Cell_ID
        {
            set { _end_cell_id = value; }
            get { return _end_cell_id; }
        }
        /// <summary>
        /// 操作者
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
        /// 完成时间
        /// </summary>
        public DateTime? Manage_End_Time
        {
            set { _manage_end_time = value; }
            get { return _manage_end_time; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Record_Remark
        {
            set { _record_remark = value; }
            get { return _record_remark; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Record_Reserve1
        {
            set { _record_reserve1 = value; }
            get { return _record_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_Reserve2
        {
            set { _record_reserve2 = value; }
            get { return _record_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_Reserve3
        {
            set { _record_reserve3 = value; }
            get { return _record_reserve3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_Reserve4
        {
            set { _record_reserve4 = value; }
            get { return _record_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_Reserve5
        {
            set { _record_reserve5 = value; }
            get { return _record_reserve5; }
        }
        #endregion Model

	}
}

