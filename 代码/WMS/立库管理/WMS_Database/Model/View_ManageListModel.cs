using System;
namespace WMS_Database
{
    /// <summary>
    /// View_Manage:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_Manage_ListModel
    {
        public View_Manage_ListModel()
        { }
        #region Model
        private string _plan_id;
        private string _mange_type_id;
        private string _mange_stock_barcode;
        private string _mange_status;
        private string _mange_full_flag;
        private string _manage_breakdown_status;
        private string _mange_start_cell_id;
        private string _mange_end_cell_id;
        private string _manage_operater;
        private DateTime? _manage_begin_time;
        private DateTime? _manage_end_time;
        private string _manage_list_id;
        private string _stock_list_id;
        private string _manage_list_quantity;
        private string _manage_list_remark;
        private string _manage_type_code;
        private string _manage_type_name;
        private string _manage_type_group;
        private string _manage_type_remark;
        private string _manage_type_inout;
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
        public string Mange_Stock_Barcode
        {
            set { _mange_stock_barcode = value; }
            get { return _mange_stock_barcode; }
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
        public string Manage_List_ID
        {
            set { _manage_list_id = value; }
            get { return _manage_list_id; }
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
        public string Manage_List_Remark
        {
            set { _manage_list_remark = value; }
            get { return _manage_list_remark; }
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
        public string Manage_Type_Group
        {
            set { _manage_type_group = value; }
            get { return _manage_type_group; }
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
        public string Manage_Type_InOut
        {
            set { _manage_type_inout = value; }
            get { return _manage_type_inout; }
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

