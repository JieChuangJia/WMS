using System;
namespace WMS_Database
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class WH_Cell_ChildrenModel
	{
        public WH_Cell_ChildrenModel()
		{}
        #region Model
        private string _cell_chlid_id;
        private string _cell_id;
        private string _cell_chlid_position;
        private int? _cell_child_order;
        private string _cell_child_inout;
        private string _cell_child_model;
        private string _cell_child_status;
        private string _cell_child_run_status;
        private string _cell_child_flag;
        private string _cell_child_operate_type;
        private string _cell_child_tasklock_id;
        private string _cell_child_reserve1;
        private string _cell_child_reserve2;
        private string _cell_child_reserve3;
        private string _cell_child_reserve4;
        private string _cell_child_reserve5;
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Chlid_ID
        {
            set { _cell_chlid_id = value; }
            get { return _cell_chlid_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_ID
        {
            set { _cell_id = value; }
            get { return _cell_id; }
        }
        /// <summary>
        /// 双深工位的子工位位置
        /// </summary>
        public string Cell_Chlid_Position
        {
            set { _cell_chlid_position = value; }
            get { return _cell_chlid_position; }
        }
        /// <summary>
        /// 取放顺序
        /// </summary>
        public int? Cell_Child_Order
        {
            set { _cell_child_order = value; }
            get { return _cell_child_order; }
        }
        /// <summary>
        /// 出入库类型
        /// </summary>
        public string Cell_Child_InOut
        {
            set { _cell_child_inout = value; }
            get { return _cell_child_inout; }
        }
        /// <summary>
        /// cell的规格，高、低等
        /// </summary>
        public string Cell_Child_Model
        {
            set { _cell_child_model = value; }
            get { return _cell_child_model; }
        }
        /// <summary>
        /// 货位状态
        /// </summary>
        public string Cell_Child_Status
        {
            set { _cell_child_status = value; }
            get { return _cell_child_status; }
        }
        /// <summary>
        /// 货位任务运行状态
        /// </summary>
        public string Cell_Child_Run_Status
        {
            set { _cell_child_run_status = value; }
            get { return _cell_child_run_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Child_Flag
        {
            set { _cell_child_flag = value; }
            get { return _cell_child_flag; }
        }
        /// <summary>
        /// 操作类型
        /// </summary>
        public string Cell_Child_Operate_Type
        {
            set { _cell_child_operate_type = value; }
            get { return _cell_child_operate_type; }
        }
        /// <summary>
        /// 针对堆垛机多抓的多个任务索引
        /// </summary>
        public string Cell_Child_TaskLock_ID
        {
            set { _cell_child_tasklock_id = value; }
            get { return _cell_child_tasklock_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Child_Reserve1
        {
            set { _cell_child_reserve1 = value; }
            get { return _cell_child_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Child_Reserve2
        {
            set { _cell_child_reserve2 = value; }
            get { return _cell_child_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Child_Reserve3
        {
            set { _cell_child_reserve3 = value; }
            get { return _cell_child_reserve3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Child_Reserve4
        {
            set { _cell_child_reserve4 = value; }
            get { return _cell_child_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Child_Reserve5
        {
            set { _cell_child_reserve5 = value; }
            get { return _cell_child_reserve5; }
        }
        #endregion Model


	}
}

