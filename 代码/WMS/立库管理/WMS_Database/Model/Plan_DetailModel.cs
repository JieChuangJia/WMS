using System;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	[Serializable]
	public partial class Plan_DetailModel
	{
        public Plan_DetailModel()
		{}
        #region Model
        private string _plan_detail_id;
        private string _plan_list_id = "0";
        private string _plan_detail_boxcode;
        private string _plan_detail_goods_barcode;
        private string _plan_detail_remark;
        private string _plan_detai_reserve1;
        private string _plan_detai_reserve2;
        private string _plan_detai_reserve3;
        private string _plan_detai_reserve4;
        private string _plan_detai_reserve5;
        /// <summary>
        /// 计划明细编号
        /// </summary>
        public string Plan_Detail_ID
        {
            set { _plan_detail_id = value; }
            get { return _plan_detail_id; }
        }
        /// <summary>
        /// 计划列表编号
        /// </summary>
        public string Plan_List_ID
        {
            set { _plan_list_id = value; }
            get { return _plan_list_id; }
        }
        /// <summary>
        /// 箱条码
        /// </summary>
        public string Plan_Detail_BoxCode
        {
            set { _plan_detail_boxcode = value; }
            get { return _plan_detail_boxcode; }
        }
        /// <summary>
        /// 物料条码
        /// </summary>
        public string Plan_Detail_Goods_Barcode
        {
            set { _plan_detail_goods_barcode = value; }
            get { return _plan_detail_goods_barcode; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Plan_Detail_Remark
        {
            set { _plan_detail_remark = value; }
            get { return _plan_detail_remark; }
        }
        /// <summary>
        /// 计划详细备用1
        /// </summary>
        public string Plan_Detai_Reserve1
        {
            set { _plan_detai_reserve1 = value; }
            get { return _plan_detai_reserve1; }
        }
        /// <summary>
        /// 计划详细备用2
        /// </summary>
        public string Plan_Detai_Reserve2
        {
            set { _plan_detai_reserve2 = value; }
            get { return _plan_detai_reserve2; }
        }
        /// <summary>
        /// 计划详细备用3
        /// </summary>
        public string Plan_Detai_Reserve3
        {
            set { _plan_detai_reserve3 = value; }
            get { return _plan_detai_reserve3; }
        }
        /// <summary>
        /// 计划详细备用4
        /// </summary>
        public string Plan_Detai_Reserve4
        {
            set { _plan_detai_reserve4 = value; }
            get { return _plan_detai_reserve4; }
        }
        /// <summary>
        /// 计划详细备用5
        /// </summary>
        public string Plan_Detai_Reserve5
        {
            set { _plan_detai_reserve5 = value; }
            get { return _plan_detai_reserve5; }
        }
        #endregion Model

	}
}

