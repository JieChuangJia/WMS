using System;
namespace WMS_Database
{
    /// <summary>
    /// View_Cell:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_CellModel
    {
        public View_CellModel()
        { }
        #region Model
        private string _warehouse_code;
        private string _warehouse_name;
        private string _warehouse_flag;
        private string _warehouse_type;
        private string _warehouse_remark;
        private string _warehouse_id;
        private string _area_type;
        private string _area_name;
        private string _area_code;
        private int? _area_order;
        private string _area_flag;
        private string _area_backcolor;
        private string _area_id;
        private string _cell_code;
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
        private string _cell_chlid_id;
        private string _cell_chlid_position;
        private string _cell_id;
        private int? _cell_child_order;
        private string _cell_child_inout;
        private string _cell_child_model;
        private string _cell_child_status;
        private string _cell_child_run_status;
        private string _cell_child_operate_type;
        private string _cell_child_tasklock_id;
        private string _cell_child_flag;
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Code
        {
            set { _warehouse_code = value; }
            get { return _warehouse_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Name
        {
            set { _warehouse_name = value; }
            get { return _warehouse_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Flag
        {
            set { _warehouse_flag = value; }
            get { return _warehouse_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Type
        {
            set { _warehouse_type = value; }
            get { return _warehouse_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Remark
        {
            set { _warehouse_remark = value; }
            get { return _warehouse_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_ID
        {
            set { _warehouse_id = value; }
            get { return _warehouse_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Area_Type
        {
            set { _area_type = value; }
            get { return _area_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Area_Name
        {
            set { _area_name = value; }
            get { return _area_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Area_Code
        {
            set { _area_code = value; }
            get { return _area_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Area_Order
        {
            set { _area_order = value; }
            get { return _area_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Area_Flag
        {
            set { _area_flag = value; }
            get { return _area_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Area_BackColor
        {
            set { _area_backcolor = value; }
            get { return _area_backcolor; }
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
        public string Cell_Code
        {
            set { _cell_code = value; }
            get { return _cell_code; }
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
        public string Cell_Chlid_ID
        {
            set { _cell_chlid_id = value; }
            get { return _cell_chlid_id; }
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
        public string Cell_ID
        {
            set { _cell_id = value; }
            get { return _cell_id; }
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
        public string Cell_Child_InOut
        {
            set { _cell_child_inout = value; }
            get { return _cell_child_inout; }
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
        public string Cell_Child_Flag
        {
            set { _cell_child_flag = value; }
            get { return _cell_child_flag; }
        }
        #endregion Model

    }
}

