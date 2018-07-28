using System;
namespace WMS_Database
{
    /// <summary>
    /// View_Record:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_RecordModel
    {
        public View_RecordModel()
        { }
        #region Model
        private string _plan_id;
        private string _manage_type_code;
        private string _stock_tray_barcode;
        private string _start_cell_id;
        private string _end_cell_id;
        private string _manage_operater;
        private DateTime? _manage_begin_time;
        private DateTime? _manage_end_time;
        private string _record_remark;
        private string _record_id;
        private string _plan_list_id;
        private string _goods_id;
        private string _record_box_barcode;
        private string _record_list_quantity;
        private string _record_list_remark;
        private string _record_list_reserve1;
        private string _goods_class_id;
        private string _goods_code;
        private string _goods_name;
        private string _goods_type;
        private string _goods_batch;
        private string _goods_model;
        private string _goods_suppier_code;
        private string _goods_desc;
        private string _goods_level;
        private string _record_list_id;
        private string _record_operatetype;
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
        public string Manage_Type_Code
        {
            set { _manage_type_code = value; }
            get { return _manage_type_code; }
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
        public string Start_Cell_ID
        {
            set { _start_cell_id = value; }
            get { return _start_cell_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string End_Cell_ID
        {
            set { _end_cell_id = value; }
            get { return _end_cell_id; }
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
        public string Record_Remark
        {
            set { _record_remark = value; }
            get { return _record_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_ID
        {
            set { _record_id = value; }
            get { return _record_id; }
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
        public string Record_Box_Barcode
        {
            set { _record_box_barcode = value; }
            get { return _record_box_barcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_List_Quantity
        {
            set { _record_list_quantity = value; }
            get { return _record_list_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_List_Remark
        {
            set { _record_list_remark = value; }
            get { return _record_list_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_List_Reserve1
        {
            set { _record_list_reserve1 = value; }
            get { return _record_list_reserve1; }
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
        public string Goods_Batch
        {
            set { _goods_batch = value; }
            get { return _goods_batch; }
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
        public string Goods_Suppier_Code
        {
            set { _goods_suppier_code = value; }
            get { return _goods_suppier_code; }
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
        public string Record_List_ID
        {
            set { _record_list_id = value; }
            get { return _record_list_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_OperateType
        {
            set { _record_operatetype = value; }
            get { return _record_operatetype; }
        }
        #endregion Model

    }
}

