using System;
namespace WMS_Database
{
    /// <summary>
    /// WH_Cell_Operate_Record:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class WH_Cell_Operate_RecordModel
    {
        public WH_Cell_Operate_RecordModel()
        { }
        #region Model
        private string _wh_cell_oper_recid;
        private string _warehouse_id;
        private string _wh_cell_code;
        private string _wh_cell_oper_type;
        private string _wh_cell_oper_detail;
        private DateTime _wh_cell_oper_datetime;
        private string _wh_cell_oper_reserve1;
        private string _wh_cell_oper_reserve2;
        private string _wh_cell_oper_reserve3;
        /// <summary>
        /// 库存操作记录ID
        /// </summary>
        public string WH_Cell_Oper_RecID
        {
            set { _wh_cell_oper_recid = value; }
            get { return _wh_cell_oper_recid; }
        }
        /// <summary>
        /// 库房ID
        /// </summary>
        public string WareHouse_ID
        {
            set { _warehouse_id = value; }
            get { return _warehouse_id; }
        }
        /// <summary>
        /// 货位位置排、列、层（12-2-2）
        /// </summary>
        public string WH_Cell_Code
        {
            set { _wh_cell_code = value; }
            get { return _wh_cell_code; }
        }
        /// <summary>
        /// 操作类型（申请入库，实际入库，申请出库，实际出库，人工出库等等）
        /// </summary>
        public string WH_Cell_Oper_Type
        {
            set { _wh_cell_oper_type = value; }
            get { return _wh_cell_oper_type; }
        }
        /// <summary>
        /// 操作详细
        /// </summary>
        public string WH_Cell_Oper_Detail
        {
            set { _wh_cell_oper_detail = value; }
            get { return _wh_cell_oper_detail; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime WH_Cell_Oper_Datetime
        {
            set { _wh_cell_oper_datetime = value; }
            get { return _wh_cell_oper_datetime; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Cell_Oper_Reserve1
        {
            set { _wh_cell_oper_reserve1 = value; }
            get { return _wh_cell_oper_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WH_Cell_Oper_Reserve2
        {
            set { _wh_cell_oper_reserve2 = value; }
            get { return _wh_cell_oper_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WH_Cell_Oper_Reserve3
        {
            set { _wh_cell_oper_reserve3 = value; }
            get { return _wh_cell_oper_reserve3; }
        }
        #endregion Model

    }
}

