using System;
namespace WMS_Database
{
    /// <summary>
    /// View_ManageStockList:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_ManageStockListModel
    {
        public View_ManageStockListModel()
        { }
        #region Model
        private string _plan_id;
        private string _mange_type_id;
        private string _stock_list_id;
        private string _manage_list_quantity;
        private string _plan_list_id;
        private string _stock_id;
        private string _mange_status;
        private string _mange_stock_barcode;
        private string _mange_full_flag;
        private string _manage_breakdown_status;
        private string _mange_start_cell_id;
        private string _mange_end_cell_id;
        private string _manage_operater;
        private DateTime? _manage_begin_time;
        private DateTime? _manage_end_time;
        private string _manage_remark;
        private string _manage_list_id;
        private string _manage_list_remark;
        private string _goods_id;
        private string _stock_list_box_barcode;
        private string _stock_list_quantity;
        private DateTime? _stock_list_entry_time;
        private DateTime? _stock_list_update_time;
        private string _stock_list_remark;
        private string _cell_child_id;
        private string _stock_tray_barcode;
        private string _stock_full_flag;
        private string _stock_remark;
        private string _mange_id;
        private DateTime? _mange_createtime;
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
        public string Stock_List_ID
        {
            set { _stock_list_id = value; }
            get { return _stock_list_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_List_Quantity
        {
            set { _manage_list_quantity = value; }
            get { return _manage_list_quantity; }
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
        public string Stock_ID
        {
            set { _stock_id = value; }
            get { return _stock_id; }
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
        public string Manage_BreakDown_Status
        {
            set { _manage_breakdown_status = value; }
            get { return _manage_breakdown_status; }
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
        public string Mange_End_Cell_ID
        {
            set { _mange_end_cell_id = value; }
            get { return _mange_end_cell_id; }
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
        public string Manage_Remark
        {
            set { _manage_remark = value; }
            get { return _manage_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_List_ID
        {
            set { _manage_list_id = value; }
            get { return _manage_list_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_List_Remark
        {
            set { _manage_list_remark = value; }
            get { return _manage_list_remark; }
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
        public string Stock_List_Remark
        {
            set { _stock_list_remark = value; }
            get { return _stock_list_remark; }
        }
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
        public string Mange_ID
        {
            set { _mange_id = value; }
            get { return _mange_id; }
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

