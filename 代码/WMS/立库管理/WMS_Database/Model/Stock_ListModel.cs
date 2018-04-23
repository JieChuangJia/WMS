using System;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	[Serializable]
	public partial class Stock_ListModel
	{
        public Stock_ListModel()
		{}
        #region Model
        private string _stock_list_id;
        private string _stock_id = "-1";
        private string _plan_list_id = "-1";
        private string _goods_id = "-1";
        private string _stock_list_box_barcode = "";
        private string _stock_list_quantity = "0";
        private DateTime? _stock_list_entry_time;
        private DateTime? _stock_list_update_time ;
        private string _stock_list_remark = "";
        private string _stock_list_reserve1;
        private string _stock_list_reserve2;
        private string _stock_list_reserve3;
        private string _stock_list_reserve4;
        private string _stock_list_reserve5;
        /// <summary>
        /// 库存列表编号
        /// </summary>
        public string Stock_List_ID
        {
            set { _stock_list_id = value; }
            get { return _stock_list_id; }
        }
        /// <summary>
        /// 库存索引
        /// </summary>
        public string Stock_ID
        {
            set { _stock_id = value; }
            get { return _stock_id; }
        }
        /// <summary>
        /// 计划详单索引
        /// </summary>
        public string Plan_List_ID
        {
            set { _plan_list_id = value; }
            get { return _plan_list_id; }
        }
        /// <summary>
        /// 物料索引
        /// </summary>
        public string Goods_ID
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 料箱条码
        /// </summary>
        public string Stock_List_Box_Barcode
        {
            set { _stock_list_box_barcode = value; }
            get { return _stock_list_box_barcode; }
        }
        /// <summary>
        /// 库存数量
        /// </summary>
        public string Stock_List_Quantity
        {
            set { _stock_list_quantity = value; }
            get { return _stock_list_quantity; }
        }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime? Stock_List_Entry_Time
        {
            set { _stock_list_entry_time = value; }
            get { return _stock_list_entry_time; }
        }
        /// <summary>
        /// 更改时间
        /// </summary>
        public DateTime? Stock_List_Update_Time
        {
            set { _stock_list_update_time = value; }
            get { return _stock_list_update_time; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Stock_List_Remark
        {
            set { _stock_list_remark = value; }
            get { return _stock_list_remark; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_List_Reserve1
        {
            set { _stock_list_reserve1 = value; }
            get { return _stock_list_reserve1; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_List_Reserve2
        {
            set { _stock_list_reserve2 = value; }
            get { return _stock_list_reserve2; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_List_Reserve3
        {
            set { _stock_list_reserve3 = value; }
            get { return _stock_list_reserve3; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_List_Reserve4
        {
            set { _stock_list_reserve4 = value; }
            get { return _stock_list_reserve4; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_List_Reserve5
        {
            set { _stock_list_reserve5 = value; }
            get { return _stock_list_reserve5; }
        }
        #endregion Model

	}
}

