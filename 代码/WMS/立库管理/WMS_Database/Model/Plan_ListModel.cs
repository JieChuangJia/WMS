using System;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	[Serializable]
	public partial class Plan_ListModel
	{
        public Plan_ListModel()
		{}
        #region Model
        private string _plan_list_id;
        private string _plan_id = "-1";
        private string _plan_list_quantity = "0";
        private string _plan_list_ordered_quantity = "0";
        private string _plan_list_finished_quantity = "0";
        private string _goods_id = "-1";
        private string _plan_list_status = "0";
        private string _plan_list_remark = "";
        private string _plan_list_resever1;
        private string _plan_list_resever2;
        private string _plan_list_resever3;
        private string _plan_list_resever4;
        private string _plan_list_resever5;
        /// <summary>
        /// 计划列表编号
        /// </summary>
        public string Plan_List_ID
        {
            set { _plan_list_id = value; }
            get { return _plan_list_id; }
        }
        /// <summary>
        /// 计划索引
        /// </summary>
        public string Plan_ID
        {
            set { _plan_id = value; }
            get { return _plan_id; }
        }
        /// <summary>
        /// 计划数量
        /// </summary>
        public string Plan_List_Quantity
        {
            set { _plan_list_quantity = value; }
            get { return _plan_list_quantity; }
        }
        /// <summary>
        /// 下达数量
        /// </summary>
        public string Plan_List_Ordered_Quantity
        {
            set { _plan_list_ordered_quantity = value; }
            get { return _plan_list_ordered_quantity; }
        }
        /// <summary>
        /// 完成数量
        /// </summary>
        public string Plan_List_Finished_Quantity
        {
            set { _plan_list_finished_quantity = value; }
            get { return _plan_list_finished_quantity; }
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
        /// 状态
        /// </summary>
        public string Plan_List_Status
        {
            set { _plan_list_status = value; }
            get { return _plan_list_status; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Plan_List_Remark
        {
            set { _plan_list_remark = value; }
            get { return _plan_list_remark; }
        }
        /// <summary>
        /// 备用1
        /// </summary>
        public string Plan_List_Resever1
        {
            set { _plan_list_resever1 = value; }
            get { return _plan_list_resever1; }
        }
        /// <summary>
        /// 备用2
        /// </summary>
        public string Plan_List_Resever2
        {
            set { _plan_list_resever2 = value; }
            get { return _plan_list_resever2; }
        }
        /// <summary>
        /// 备用3
        /// </summary>
        public string Plan_List_Resever3
        {
            set { _plan_list_resever3 = value; }
            get { return _plan_list_resever3; }
        }
        /// <summary>
        /// 备用4
        /// </summary>
        public string Plan_List_Resever4
        {
            set { _plan_list_resever4 = value; }
            get { return _plan_list_resever4; }
        }
        /// <summary>
        /// 备用5
        /// </summary>
        public string Plan_List_Resever5
        {
            set { _plan_list_resever5 = value; }
            get { return _plan_list_resever5; }
        }
        #endregion Model

	}
}

