using System;
namespace WMS_Database
{
    /// <summary>
    /// WH_Lane:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class WH_LaneModel
    {
        public WH_LaneModel()
        { }
        #region Model
        private string _wh_lane_id;
        private string _wh_warehouse_id;
        private string _wh_lane_name;
        private string _wh_lane_remark;
        private string _wh_lane_reserve1;
        private string _wh_lane_reserve2;
        private string _wh_lane_reserve3;
        private string _wh_lane_reserve4;
        private string _wh_lane_reserve5;
        /// <summary>
        /// 巷道设备编号
        /// </summary>
        public string WH_Lane_ID
        {
            set { _wh_lane_id = value; }
            get { return _wh_lane_id; }
        }
        /// <summary>
        /// 所属库房ID
        /// </summary>
        public string WH_WareHouse_ID
        {
            set { _wh_warehouse_id = value; }
            get { return _wh_warehouse_id; }
        }
        /// <summary>
        /// 巷道名称
        /// </summary>
        public string WH_Lane_Name
        {
            set { _wh_lane_name = value; }
            get { return _wh_lane_name; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string WH_Lane_Remark
        {
            set { _wh_lane_remark = value; }
            get { return _wh_lane_remark; }
        }
        /// <summary>
        /// 备用1
        /// </summary>
        public string WH_Lane_Reserve1
        {
            set { _wh_lane_reserve1 = value; }
            get { return _wh_lane_reserve1; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Lane_Reserve2
        {
            set { _wh_lane_reserve2 = value; }
            get { return _wh_lane_reserve2; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Lane_Reserve3
        {
            set { _wh_lane_reserve3 = value; }
            get { return _wh_lane_reserve3; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Lane_Reserve4
        {
            set { _wh_lane_reserve4 = value; }
            get { return _wh_lane_reserve4; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string WH_Lane_Reserve5
        {
            set { _wh_lane_reserve5 = value; }
            get { return _wh_lane_reserve5; }
        }
        #endregion Model

    }
}

