using System;
namespace WMS_Database
{
    /// <summary>
    /// WH_Station_Logic:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class WH_Station_LogicModel
    {
        public WH_Station_LogicModel()
        { }
        #region Model
        private string _wh_station_logic;
        private string _cell_child_id;
        private string _warehouse_id;
        private string _wh_station_logic_type;
        private string _wh_station_logic_name;
        private string _wh_station_logic_desc;
        private string _wh_station_logic_remark;
        private string _wh_station_logic_reserve1;
        private string _wh_station_logic_reserve2;
        private string _wh_station_logic_reserve3;
        private string _wh_station_logic_reserve4;
        private string _wh_station_logic_reserve5;
        /// <summary>
        /// 
        /// </summary>
        public string WH_Station_Logic
        {
            set { _wh_station_logic = value; }
            get { return _wh_station_logic; }
        }
        /// <summary>
        /// 下架站台
        /// </summary>
        public string Cell_Child_ID
        {
            set { _cell_child_id = value; }
            get { return _cell_child_id; }
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
        /// 上架站台
        /// </summary>
        public string WH_Station_Logic_Type
        {
            set { _wh_station_logic_type = value; }
            get { return _wh_station_logic_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WH_Station_Logic_Name
        {
            set { _wh_station_logic_name = value; }
            get { return _wh_station_logic_name; }
        }
        /// <summary>
        /// 工位描述
        /// </summary>
        public string WH_Station_Logic_Desc
        {
            set { _wh_station_logic_desc = value; }
            get { return _wh_station_logic_desc; }
        }
        /// <summary>
        /// 工位描述
        /// </summary>
        public string WH_Station_Logic_Remark
        {
            set { _wh_station_logic_remark = value; }
            get { return _wh_station_logic_remark; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Station_Logic_Reserve1
        {
            set { _wh_station_logic_reserve1 = value; }
            get { return _wh_station_logic_reserve1; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Station_Logic_Reserve2
        {
            set { _wh_station_logic_reserve2 = value; }
            get { return _wh_station_logic_reserve2; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Station_Logic_Reserve3
        {
            set { _wh_station_logic_reserve3 = value; }
            get { return _wh_station_logic_reserve3; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Station_Logic_Reserve4
        {
            set { _wh_station_logic_reserve4 = value; }
            get { return _wh_station_logic_reserve4; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Station_Logic_Reserve5
        {
            set { _wh_station_logic_reserve5 = value; }
            get { return _wh_station_logic_reserve5; }
        }
        #endregion Model

    }
}

