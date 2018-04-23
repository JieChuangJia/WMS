using System;
namespace WMS_Database
{
	/// <summary>
	/// 计划列表明细
	/// </summary>
	[Serializable]
	public partial class Plan_TypeModel
	{
        public Plan_TypeModel()
		{}
        #region Model
        private string _plan_type_id;
        private string _plan_type_code = "";
        private string _plan_type_name = "";
        private string _plan_type_group = "";
        private string _plan_type_inout = "";
        private string _plan_type_remark = "";
        private int? _plan_type_order = 0;
        private string _plan_type_flag = "1";
        private string _plan_type_resever1;
        private string _plan_type_resever2;
        private string _plan_type_resever3;
        private string _plan_type_resever4;
        private string _plan_type_resever5;
        /// <summary>
        /// 计划类型编号
        /// </summary>
        public string Plan_Type_ID
        {
            set { _plan_type_id = value; }
            get { return _plan_type_id; }
        }
        /// <summary>
        /// 计划类型编码
        /// </summary>
        public string Plan_Type_Code
        {
            set { _plan_type_code = value; }
            get { return _plan_type_code; }
        }
        /// <summary>
        /// 计划类型名称
        /// </summary>
        public string Plan_Type_Name
        {
            set { _plan_type_name = value; }
            get { return _plan_type_name; }
        }
        /// <summary>
        /// 计划类型分组
        /// </summary>
        public string Plan_Type_Group
        {
            set { _plan_type_group = value; }
            get { return _plan_type_group; }
        }
        /// <summary>
        /// 出入库类型
        /// </summary>
        public string Plan_Type_InOut
        {
            set { _plan_type_inout = value; }
            get { return _plan_type_inout; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Plan_Type_Remark
        {
            set { _plan_type_remark = value; }
            get { return _plan_type_remark; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Plan_Type_Order
        {
            set { _plan_type_order = value; }
            get { return _plan_type_order; }
        }
        /// <summary>
        /// 标志位
        /// </summary>
        public string Plan_Type_Flag
        {
            set { _plan_type_flag = value; }
            get { return _plan_type_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Resever1
        {
            set { _plan_type_resever1 = value; }
            get { return _plan_type_resever1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Resever2
        {
            set { _plan_type_resever2 = value; }
            get { return _plan_type_resever2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Resever3
        {
            set { _plan_type_resever3 = value; }
            get { return _plan_type_resever3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Resever4
        {
            set { _plan_type_resever4 = value; }
            get { return _plan_type_resever4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Resever5
        {
            set { _plan_type_resever5 = value; }
            get { return _plan_type_resever5; }
        }
        #endregion Model

	}
}

