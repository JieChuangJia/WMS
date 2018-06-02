using System;
namespace WMS_Database
{
    /// <summary>
    /// View_Manage_Cell:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_Manage_CellModel
    {
        public View_Manage_CellModel()
        { }
        #region Model
        private string _mange_id;
        private string _plan_id;
        private string _mange_type_id;
        private string _mange_status;
        private string _mange_stock_barcode;
        private string _mange_full_flag;
        private string _mange_start_cell_id;
        private string _manage_breakdown_status;
        private string _manage_operater;
        private string _mange_end_cell_id;
        private DateTime? _manage_begin_time;
        private DateTime? _manage_end_time;
        private string _manage_remark;
        private string _cell_chlid_position;
        private string _cell_child_inout;
        private int? _cell_child_order;
        private string _manage_type_code;
        private string _manage_type_name;
        private string _manage_type_inout;
        private int? _manage_type_order;
        private string _manage_type_flag;
        private string _manage_type_remark;
        private string _manage_type_group;
        private string _cell_code;
        private string _area_id;
        private string _cell_name;
        private string _cell_lane;
        private string _device_code;
        private string _shelf_type;
        private string _cell_inout;
        private string _cell_type;
        private string _cell_storage_type;
        private string _cell_fork_type;
        private int? _cell_layer;
        private int? _cell_column;
        private int? _cell_row;
        private string _cell_reserve1;
        private string _cell_chlid_id;
        private string _cell_child_model;
        private string _cell_child_status;
        private string _cell_child_run_status;
        private string _cell_child_flag;
        private string _cell_child_operate_type;
        private string _cell_child_tasklock_id;
        private string _cell_child_reserve1;
        private DateTime? _mange_createtime;
        /// <summary>
        /// 
        /// </summary>
        public string Mange_ID
        {
            set { _mange_id = value; }
            get { return _mange_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_ID
        {
            set { _plan_id = value; }
            get { return _plan_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_Type_ID
        {
            set { _mange_type_id = value; }
            get { return _mange_type_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_Status
        {
            set { _mange_status = value; }
            get { return _mange_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_Stock_Barcode
        {
            set { _mange_stock_barcode = value; }
            get { return _mange_stock_barcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_Full_Flag
        {
            set { _mange_full_flag = value; }
            get { return _mange_full_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_Start_Cell_ID
        {
            set { _mange_start_cell_id = value; }
            get { return _mange_start_cell_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_BreakDown_Status
        {
            set { _manage_breakdown_status = value; }
            get { return _manage_breakdown_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_Operater
        {
            set { _manage_operater = value; }
            get { return _manage_operater; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mange_End_Cell_ID
        {
            set { _mange_end_cell_id = value; }
            get { return _mange_end_cell_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Manage_Begin_Time
        {
            set { _manage_begin_time = value; }
            get { return _manage_begin_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Manage_End_Time
        {
            set { _manage_end_time = value; }
            get { return _manage_end_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_Remark
        {
            set { _manage_remark = value; }
            get { return _manage_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Chlid_Position
        {
            set { _cell_chlid_position = value; }
            get { return _cell_chlid_position; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Child_InOut
        {
            set { _cell_child_inout = value; }
            get { return _cell_child_inout; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Cell_Child_Order
        {
            set { _cell_child_order = value; }
            get { return _cell_child_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_Type_Code
        {
            set { _manage_type_code = value; }
            get { return _manage_type_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_Type_Name
        {
            set { _manage_type_name = value; }
            get { return _manage_type_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_Type_InOut
        {
            set { _manage_type_inout = value; }
            get { return _manage_type_inout; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Manage_Type_Order
        {
            set { _manage_type_order = value; }
            get { return _manage_type_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_Type_Flag
        {
            set { _manage_type_flag = value; }
            get { return _manage_type_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_Type_Remark
        {
            set { _manage_type_remark = value; }
            get { return _manage_type_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_Type_Group
        {
            set { _manage_type_group = value; }
            get { return _manage_type_group; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Code
        {
            set { _cell_code = value; }
            get { return _cell_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Area_ID
        {
            set { _area_id = value; }
            get { return _area_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Name
        {
            set { _cell_name = value; }
            get { return _cell_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Lane
        {
            set { _cell_lane = value; }
            get { return _cell_lane; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Device_Code
        {
            set { _device_code = value; }
            get { return _device_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Shelf_Type
        {
            set { _shelf_type = value; }
            get { return _shelf_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_InOut
        {
            set { _cell_inout = value; }
            get { return _cell_inout; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Type
        {
            set { _cell_type = value; }
            get { return _cell_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Storage_Type
        {
            set { _cell_storage_type = value; }
            get { return _cell_storage_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Fork_Type
        {
            set { _cell_fork_type = value; }
            get { return _cell_fork_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Cell_Layer
        {
            set { _cell_layer = value; }
            get { return _cell_layer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Cell_Column
        {
            set { _cell_column = value; }
            get { return _cell_column; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Cell_Row
        {
            set { _cell_row = value; }
            get { return _cell_row; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Reserve1
        {
            set { _cell_reserve1 = value; }
            get { return _cell_reserve1; }
        }
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
        public string Cell_Child_Model
        {
            set { _cell_child_model = value; }
            get { return _cell_child_model; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Child_Status
        {
            set { _cell_child_status = value; }
            get { return _cell_child_status; }
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public string Cell_Child_Operate_Type
        {
            set { _cell_child_operate_type = value; }
            get { return _cell_child_operate_type; }
        }
        /// <summary>
        /// 
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
        public DateTime? Mange_CreateTime
        {
            set { _mange_createtime = value; }
            get { return _mange_createtime; }
        }
        #endregion Model

    }
}

