using System;
namespace WMS_Database
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class WH_WareHouseModel
	{
        public WH_WareHouseModel()
		{}
        #region Model
        private string _warehouse_id;
        private string _warehouse_code = "";
        private string _warehouse_name;
        private string _warehouse_type;
        private string _warehouse_flag = "0";
        private string _warehouse_remark = "";
        private string _warehouse_reserve1;
        private string _warehouse_reserve2;
        private string _warehouse_reserve3;
        private string _warehouse_reserve4;
        private string _warehouse_reserve5;
        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WareHouse_ID
        {
            set { _warehouse_id = value; }
            get { return _warehouse_id; }
        }
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WareHouse_Code
        {
            set { _warehouse_code = value; }
            get { return _warehouse_code; }
        }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WareHouse_Name
        {
            set { _warehouse_name = value; }
            get { return _warehouse_name; }
        }
        /// <summary>
        /// 仓库类型
        /// </summary>
        public string WareHouse_Type
        {
            set { _warehouse_type = value; }
            get { return _warehouse_type; }
        }
        /// <summary>
        /// 标志位,启用禁用
        /// </summary>
        public string WareHouse_Flag
        {
            set { _warehouse_flag = value; }
            get { return _warehouse_flag; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string WareHouse_Remark
        {
            set { _warehouse_remark = value; }
            get { return _warehouse_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Reserve1
        {
            set { _warehouse_reserve1 = value; }
            get { return _warehouse_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Reserve2
        {
            set { _warehouse_reserve2 = value; }
            get { return _warehouse_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Reserve3
        {
            set { _warehouse_reserve3 = value; }
            get { return _warehouse_reserve3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Reserve4
        {
            set { _warehouse_reserve4 = value; }
            get { return _warehouse_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WareHouse_Reserve5
        {
            set { _warehouse_reserve5 = value; }
            get { return _warehouse_reserve5; }
        }
        #endregion Model

	}
}

