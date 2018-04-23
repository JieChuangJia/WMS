using System;
namespace WMS_Database
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class WH_CellModel
	{
        public WH_CellModel()
		{}
        #region Model
        private string _cell_id;
        private string _area_id;
        private string _cell_code = "";
        private string _cell_name;
        private string _cell_lane = "";
        private string _device_code;
        private string _shelf_type;
        private string _cell_inout;
        private string _cell_type = "";
        private string _cell_storage_type;
        private string _cell_fork_type;
        private int? _cell_layer;
        private int? _cell_column;
        private int? _cell_row;
        private string _cell_reserve1;
        private string _cell_reserve2;
        private string _cell_reserve3;
        private string _cell_reserve4;
        private string _cell_reserve5;
        /// <summary>
        /// 货位编号
        /// </summary>
        public string Cell_ID
        {
            set { _cell_id = value; }
            get { return _cell_id; }
        }
        /// <summary>
        /// 库区编号
        /// </summary>
        public string Area_ID
        {
            set { _area_id = value; }
            get { return _area_id; }
        }
        /// <summary>
        /// 位置编码
        /// </summary>
        public string Cell_Code
        {
            set { _cell_code = value; }
            get { return _cell_code; }
        }
        /// <summary>
        /// 位置名称
        /// </summary>
        public string Cell_Name
        {
            set { _cell_name = value; }
            get { return _cell_name; }
        }
        /// <summary>
        /// 巷道编码
        /// </summary>
        public string Cell_Lane
        {
            set { _cell_lane = value; }
            get { return _cell_lane; }
        }
        /// <summary>
        /// 设备编码，一般指的是堆垛机编号
        /// </summary>
        public string Device_Code
        {
            set { _device_code = value; }
            get { return _device_code; }
        }
        /// <summary>
        /// 双深内部货架,或是单货位货架
        /// </summary>
        public string Shelf_Type
        {
            set { _shelf_type = value; }
            get { return _shelf_type; }
        }
        /// <summary>
        /// 出入库标志
        /// </summary>
        public string Cell_InOut
        {
            set { _cell_inout = value; }
            get { return _cell_inout; }
        }
        /// <summary>
        /// cell类型，是货架里的货位还是站台等其他工位
        /// </summary>
        public string Cell_Type
        {
            set { _cell_type = value; }
            get { return _cell_type; }
        }
        /// <summary>
        /// cell存储类型
        /// </summary>
        public string Cell_Storage_Type
        {
            set { _cell_storage_type = value; }
            get { return _cell_storage_type; }
        }
        /// <summary>
        /// 卡夹类型，双叉，多叉
        /// </summary>
        public string Cell_Fork_Type
        {
            set { _cell_fork_type = value; }
            get { return _cell_fork_type; }
        }
        /// <summary>
        /// cell层
        /// </summary>
        public int? Cell_Layer
        {
            set { _cell_layer = value; }
            get { return _cell_layer; }
        }
        /// <summary>
        /// cell列
        /// </summary>
        public int? Cell_Column
        {
            set { _cell_column = value; }
            get { return _cell_column; }
        }
        /// <summary>
        /// cell排
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
        public string Cell_Reserve2
        {
            set { _cell_reserve2 = value; }
            get { return _cell_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Reserve3
        {
            set { _cell_reserve3 = value; }
            get { return _cell_reserve3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Reserve4
        {
            set { _cell_reserve4 = value; }
            get { return _cell_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cell_Reserve5
        {
            set { _cell_reserve5 = value; }
            get { return _cell_reserve5; }
        }
        #endregion Model

	}
}

