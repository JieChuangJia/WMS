using System;
namespace WMS_Database
{
	/// <summary>
    /// Manage_DetailModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Manage_DetailModel
	{
        public Manage_DetailModel()
		{}
        #region Model
        private string _manage_detail_id;
        private string _manage_list_id = "0";
        private string _manage_detail_box_barcode;
        private string _manage_detail_goods_barcode;
        private string _manage_detail_remark;
        private string _manage_detail_reserve1;
        private string _manage_detail_reserve2;
        private string _manage_detail_reserve3;
        private string _manage_detail_reserve4;
        private string _manage_detail_reserve5;
        /// <summary>
        /// 任务明细编号
        /// </summary>
        public string Manage_Detail_ID
        {
            set { _manage_detail_id = value; }
            get { return _manage_detail_id; }
        }
        /// <summary>
        /// 任务列表编号
        /// </summary>
        public string Manage_List_ID
        {
            set { _manage_list_id = value; }
            get { return _manage_list_id; }
        }
        /// <summary>
        /// 箱条码
        /// </summary>
        public string Manage_Detail_Box_Barcode
        {
            set { _manage_detail_box_barcode = value; }
            get { return _manage_detail_box_barcode; }
        }
        /// <summary>
        /// 物料条码
        /// </summary>
        public string Manage_Detail_Goods_Barcode
        {
            set { _manage_detail_goods_barcode = value; }
            get { return _manage_detail_goods_barcode; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Manage_Detail_Remark
        {
            set { _manage_detail_remark = value; }
            get { return _manage_detail_remark; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Detail_Reserve1
        {
            set { _manage_detail_reserve1 = value; }
            get { return _manage_detail_reserve1; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Detail_Reserve2
        {
            set { _manage_detail_reserve2 = value; }
            get { return _manage_detail_reserve2; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Detail_Reserve3
        {
            set { _manage_detail_reserve3 = value; }
            get { return _manage_detail_reserve3; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Detail_Reserve4
        {
            set { _manage_detail_reserve4 = value; }
            get { return _manage_detail_reserve4; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Detail_Reserve5
        {
            set { _manage_detail_reserve5 = value; }
            get { return _manage_detail_reserve5; }
        }
        #endregion Model

	}
}

