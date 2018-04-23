using System;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	[Serializable]
	public partial class StockModel
	{
        public StockModel()
		{}
        #region Model
        private string _stock_id;
        private string _cell_child_id = "-1";
        private string _stock_tray_barcode = "";
        private string _stock_full_flag = "1";
        private string _stock_remark = "";
        private string _stock_reserve1;
        private string _stock_reserve2;
        private string _stock_reserve3;
        private string _stock_reserve4;
        private string _stock_reserve5;
        /// <summary>
        /// 库存编号
        /// </summary>
        public string Stock_ID
        {
            set { _stock_id = value; }
            get { return _stock_id; }
        }
        /// <summary>
        /// 位置索引
        /// </summary>
        public string Cell_Child_ID
        {
            set { _cell_child_id = value; }
            get { return _cell_child_id; }
        }
        /// <summary>
        /// 托盘条码
        /// </summary>
        public string Stock_Tray_Barcode
        {
            set { _stock_tray_barcode = value; }
            get { return _stock_tray_barcode; }
        }
        /// <summary>
        /// 是否满货位，1满0部分
        /// </summary>
        public string Stock_Full_Flag
        {
            set { _stock_full_flag = value; }
            get { return _stock_full_flag; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Stock_Remark
        {
            set { _stock_remark = value; }
            get { return _stock_remark; }
        }
        /// <summary>
        /// 库存备用字段
        /// </summary>
        public string Stock_Reserve1
        {
            set { _stock_reserve1 = value; }
            get { return _stock_reserve1; }
        }
        /// <summary>
        /// 库存备用字段
        /// </summary>
        public string Stock_Reserve2
        {
            set { _stock_reserve2 = value; }
            get { return _stock_reserve2; }
        }
        /// <summary>
        /// 库存备用字段
        /// </summary>
        public string Stock_Reserve3
        {
            set { _stock_reserve3 = value; }
            get { return _stock_reserve3; }
        }
        /// <summary>
        /// 库存备用字段
        /// </summary>
        public string Stock_Reserve4
        {
            set { _stock_reserve4 = value; }
            get { return _stock_reserve4; }
        }
        /// <summary>
        /// 库存备用字段
        /// </summary>
        public string Stock_Reserve5
        {
            set { _stock_reserve5 = value; }
            get { return _stock_reserve5; }
        }
        #endregion Model

	}
}

