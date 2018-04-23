using System;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	[Serializable]
	public partial class Record_ListModel
	{
        public Record_ListModel()
		{}
        #region Model
        private string _record_list_id;
        private string _record_id = "-1";
        private string _plan_list_id = "-1";
        private string _goods_id = "-1";
        private string _record_box_barcode;
        private string _record_list_quantity = "0";
        private string _record_list_remark = "";
        private string _record_list_reserve1;
        private string _record_list_reserve2;
        private string _record_list_reserve3;
        private string _record_list_reserve4;
        private string _record_list_reserve5;
        /// <summary>
        /// 记录列表编号
        /// </summary>
        public string Record_List_ID
        {
            set { _record_list_id = value; }
            get { return _record_list_id; }
        }
        /// <summary>
        /// 记录索引
        /// </summary>
        public string Record_ID
        {
            set { _record_id = value; }
            get { return _record_id; }
        }
        /// <summary>
        /// 入库计划详单索引
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
        public string Record_Box_Barcode
        {
            set { _record_box_barcode = value; }
            get { return _record_box_barcode; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public string Record_List_Quantity
        {
            set { _record_list_quantity = value; }
            get { return _record_list_quantity; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Record_List_Remark
        {
            set { _record_list_remark = value; }
            get { return _record_list_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_List_Reserve1
        {
            set { _record_list_reserve1 = value; }
            get { return _record_list_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_List_Reserve2
        {
            set { _record_list_reserve2 = value; }
            get { return _record_list_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_List_Reserve3
        {
            set { _record_list_reserve3 = value; }
            get { return _record_list_reserve3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_List_Reserve4
        {
            set { _record_list_reserve4 = value; }
            get { return _record_list_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Record_List_Reserve5
        {
            set { _record_list_reserve5 = value; }
            get { return _record_list_reserve5; }
        }
        #endregion Model
	}
}

