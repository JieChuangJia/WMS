using System;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	[Serializable]
	public partial class Record_DetailModel
	{
        public Record_DetailModel()
		{}
        #region Model
        private string _record_detail_id;
        private string _record_list_id = "0";
        private string _record_detail_box_barcode;
        private string _goods_barcode;
        private string _record_detail_remark;
        private string _record_detail_reserve1;
        private string _record_detail_reserve2;
        private string _record_detail_reserve3;
        private string _record_detail_reserve4;
        private string _record_detail_reserve5;
        /// <summary>
        /// 记录明细编号
        /// </summary>
        public string Record_Detail_ID
        {
            set { _record_detail_id = value; }
            get { return _record_detail_id; }
        }
        /// <summary>
        /// 记录列表编号
        /// </summary>
        public string Record_List_ID
        {
            set { _record_list_id = value; }
            get { return _record_list_id; }
        }
        /// <summary>
        /// 箱条码
        /// </summary>
        public string Record_Detail_Box_Barcode
        {
            set { _record_detail_box_barcode = value; }
            get { return _record_detail_box_barcode; }
        }
        /// <summary>
        /// 设备条码
        /// </summary>
        public string Goods_Barcode
        {
            set { _goods_barcode = value; }
            get { return _goods_barcode; }
        }
        /// <summary>
        /// 记录明细备注
        /// </summary>
        public string Record_Detail_Remark
        {
            set { _record_detail_remark = value; }
            get { return _record_detail_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_Detail_Reserve1
        {
            set { _record_detail_reserve1 = value; }
            get { return _record_detail_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_Detail_Reserve2
        {
            set { _record_detail_reserve2 = value; }
            get { return _record_detail_reserve2; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Record_Detail_Reserve3
        {
            set { _record_detail_reserve3 = value; }
            get { return _record_detail_reserve3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_Detail_Reserve4
        {
            set { _record_detail_reserve4 = value; }
            get { return _record_detail_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_Detail_Reserve5
        {
            set { _record_detail_reserve5 = value; }
            get { return _record_detail_reserve5; }
        }
        #endregion Model


	}
}

