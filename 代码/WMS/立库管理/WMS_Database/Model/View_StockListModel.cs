using System;
namespace WMS_Database
{
    /// <summary>
    /// View_StockList:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_StockListModel
    {
        public View_StockListModel()
        { }
        #region Model
        private string _cell_child_id;
        private string _stock_tray_barcode;
        private string _stock_full_flag;
        private string _stock_remark;
        private string _stock_id;
        private string _stock_list_id;
        private string _plan_list_id;
        private string _goods_id;
        private string _stock_list_box_barcode;
        private string _stock_list_quantity;
        private DateTime? _stock_list_entry_time;
        private DateTime? _stock_list_update_time;
        private string _cell_id;
        private string _cell_chlid_id;
        private string _cell_chlid_position;
        private int? _cell_child_order;
        private string _cell_child_inout;
        private string _cell_child_status;
        private string _cell_child_model;
        private string _cell_child_run_status;
        private string _cell_child_flag;
        private string _cell_child_operate_type;
        private string _cell_child_tasklock_id;
        private string _area_id;
        private string _cell_code;
        private string _cell_name;
        private string _cell_lane;
        private string _device_code;
        private string _shelf_type;
        private string _cell_type;
        private string _cell_inout;
        private string _cell_storage_type;
        private string _cell_fork_type;
        private int? _cell_layer;
        private int? _cell_column;
        private int? _cell_row;
        private string _warehouse_id;
        private string _area_code;
        private string _area_type;
        private string _area_name;
        private int? _area_order;
        private string _area_flag;
        private string _area_backcolor;
        private string _goods_class_id;
        private string _goods_code;
        private string _goods_name;
        private string _goods_type;
        private string _goods_suppier_code;
        private string _goods_model;
        private string _goods_desc;
        private string _goods_level;
        private string _goods_unit;
        private string _goods_limit_upper_quantity;
        private string _goods_limit_lower_quantity;
        private int? _goods_order;
        private string _goods_flag;
        private string _goods_danger;
        private string _goods_category;
        private DateTime? _goods_producedate;
        private string _goods_asset;
        private int? _goods_shelf_life;
        private string _goods_department;
        private string _goods_remark;
        private string _goods_class_parent_id;
        private string _goods_class_code;
        private string _goods_class_name;
        private string _goods_class_remark;
        private int? _goods_class_order;
        private string _goods_class_flag;
        private string _warehouse_code;
        private string _warehouse_name;
        private string _warehouse_type;
        private string _warehouse_flag;
        private string _warehouse_remark;
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Child_ID
        {
            set { _cell_child_id = value; }
            get { return _cell_child_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Stock_Tray_Barcode
        {
            set { _stock_tray_barcode = value; }
            get { return _stock_tray_barcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Stock_Full_Flag
        {
            set { _stock_full_flag = value; }
            get { return _stock_full_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Stock_Remark
        {
            set { _stock_remark = value; }
            get { return _stock_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Stock_ID
        {
            set { _stock_id = value; }
            get { return _stock_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Stock_List_ID
        {
            set { _stock_list_id = value; }
            get { return _stock_list_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_List_ID
        {
            set { _plan_list_id = value; }
            get { return _plan_list_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_ID
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Stock_List_Box_Barcode
        {
            set { _stock_list_box_barcode = value; }
            get { return _stock_list_box_barcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Stock_List_Quantity
        {
            set { _stock_list_quantity = value; }
            get { return _stock_list_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Stock_List_Entry_Time
        {
            set { _stock_list_entry_time = value; }
            get { return _stock_list_entry_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Stock_List_Update_Time
        {
            set { _stock_list_update_time = value; }
            get { return _stock_list_update_time; }
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
        public string Cell_Child_Status
        {
            set { _cell_child_status = value; }
            get { return _cell_child_status; }
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
        public string Cell_Type
        {
            set { _cell_type = value; }
            get { return _cell_type; }
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
        public string WareHouse_ID
        {
            set { _warehouse_id = value; }
            get { return _warehouse_id; }
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
        public string Goods_Class_ID
        {
            set { _goods_class_id = value; }
            get { return _goods_class_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Code
        {
            set { _goods_code = value; }
            get { return _goods_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Type
        {
            set { _goods_type = value; }
            get { return _goods_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Suppier_Code
        {
            set { _goods_suppier_code = value; }
            get { return _goods_suppier_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Model
        {
            set { _goods_model = value; }
            get { return _goods_model; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Desc
        {
            set { _goods_desc = value; }
            get { return _goods_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Level
        {
            set { _goods_level = value; }
            get { return _goods_level; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Unit
        {
            set { _goods_unit = value; }
            get { return _goods_unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Limit_Upper_Quantity
        {
            set { _goods_limit_upper_quantity = value; }
            get { return _goods_limit_upper_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Limit_Lower_Quantity
        {
            set { _goods_limit_lower_quantity = value; }
            get { return _goods_limit_lower_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Goods_Order
        {
            set { _goods_order = value; }
            get { return _goods_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Flag
        {
            set { _goods_flag = value; }
            get { return _goods_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Danger
        {
            set { _goods_danger = value; }
            get { return _goods_danger; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Category
        {
            set { _goods_category = value; }
            get { return _goods_category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Goods_ProduceDate
        {
            set { _goods_producedate = value; }
            get { return _goods_producedate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Asset
        {
            set { _goods_asset = value; }
            get { return _goods_asset; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Goods_Shelf_Life
        {
            set { _goods_shelf_life = value; }
            get { return _goods_shelf_life; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Department
        {
            set { _goods_department = value; }
            get { return _goods_department; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Remark
        {
            set { _goods_remark = value; }
            get { return _goods_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Parent_ID
        {
            set { _goods_class_parent_id = value; }
            get { return _goods_class_parent_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Code
        {
            set { _goods_class_code = value; }
            get { return _goods_class_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Name
        {
            set { _goods_class_name = value; }
            get { return _goods_class_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Remark
        {
            set { _goods_class_remark = value; }
            get { return _goods_class_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Goods_Class_Order
        {
            set { _goods_class_order = value; }
            get { return _goods_class_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Flag
        {
            set { _goods_class_flag = value; }
            get { return _goods_class_flag; }
        }
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
        public string WareHouse_Type
        {
            set { _warehouse_type = value; }
            get { return _warehouse_type; }
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
        public string WareHouse_Remark
        {
            set { _warehouse_remark = value; }
            get { return _warehouse_remark; }
        }
        #endregion Model
    }
}

