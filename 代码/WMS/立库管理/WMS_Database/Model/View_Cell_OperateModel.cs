using System;
namespace AsrsStorDBAcc.Model
{
    /// <summary>
    /// View_Cell_Operate:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_Cell_OperateModel
    {
        public View_Cell_OperateModel()
        { }
        #region Model
        private string _wh_cell_oper_recid;
        private string _warehouse_id;
        private string _wh_cell_code;
        private string _wh_cell_oper_type;
        private string _wh_cell_oper_detail;
        private DateTime _wh_cell_oper_datetime;
        private string _warehouse_code;
        private string _warehouse_name;
        private string _warehouse_type;
        private string _warehouse_flag;
        /// <summary>
        /// 
        /// </summary>
        public string WH_Cell_Oper_RecID
        {
            set { _wh_cell_oper_recid = value; }
            get { return _wh_cell_oper_recid; }
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
        public string WH_Cell_Code
        {
            set { _wh_cell_code = value; }
            get { return _wh_cell_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WH_Cell_Oper_Type
        {
            set { _wh_cell_oper_type = value; }
            get { return _wh_cell_oper_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WH_Cell_Oper_Detail
        {
            set { _wh_cell_oper_detail = value; }
            get { return _wh_cell_oper_detail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime WH_Cell_Oper_Datetime
        {
            set { _wh_cell_oper_datetime = value; }
            get { return _wh_cell_oper_datetime; }
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
        #endregion Model

    }
}

