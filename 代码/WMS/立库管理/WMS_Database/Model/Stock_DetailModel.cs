using System;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	[Serializable]
	public partial class Stock_DetailModel
	{
        public Stock_DetailModel()
		{}
        #region Model
        private string _stock_detail_id;
        private string _stock_list_id = "-1";
        private string _stock_detail_goods_barcode;
        private string _stock_detail_remark;
        private string _stock_detail_reserve1;
        private string _stock_detail_reserve2;
        private string _stock_detail_reserve3;
        private string _stock_detail_reserve4;
        private string _stock_detail_reserve5;
        /// <summary>
        /// 库存明细编号
        /// </summary>
        public string Stock_Detail_ID
        {
            set { _stock_detail_id = value; }
            get { return _stock_detail_id; }
        }
        /// <summary>
        /// 库存列表编号
        /// </summary>
        public string Stock_List_ID
        {
            set { _stock_list_id = value; }
            get { return _stock_list_id; }
        }
        /// <summary>
        /// 物料条码
        /// </summary>
        public string Stock_Detail_Goods_Barcode
        {
            set { _stock_detail_goods_barcode = value; }
            get { return _stock_detail_goods_barcode; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Stock_Detail_Remark
        {
            set { _stock_detail_remark = value; }
            get { return _stock_detail_remark; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_Detail_Reserve1
        {
            set { _stock_detail_reserve1 = value; }
            get { return _stock_detail_reserve1; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_Detail_Reserve2
        {
            set { _stock_detail_reserve2 = value; }
            get { return _stock_detail_reserve2; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_Detail_Reserve3
        {
            set { _stock_detail_reserve3 = value; }
            get { return _stock_detail_reserve3; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_Detail_Reserve4
        {
            set { _stock_detail_reserve4 = value; }
            get { return _stock_detail_reserve4; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Stock_Detail_Reserve5
        {
            set { _stock_detail_reserve5 = value; }
            get { return _stock_detail_reserve5; }
        }
        #endregion Model

	}
}

