using System;
namespace WMS_Database
{
	/// <summary>
    /// Manage_TypeModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Manage_TypeModel
	{
        public Manage_TypeModel()
		{}
        #region Model
        private string _manage_type_id;
        private string _manage_type_code;
        private string _manage_type_name;
        private string _manage_type_inout;
        private string _manage_type_group;
        private string _manage_type_remark;
        private int? _manage_type_order;
        private string _manage_type_flag;
        private string _manage_type_reserve1;
        private string _manage_type_reserve2;
        private string _manage_type_reserve3;
        private string _manage_type_reserve4;
        private string _manage_type_reserve5;
        /// <summary>
        /// 任务类型编号
        /// </summary>
        public string Manage_Type_ID
        {
            set { _manage_type_id = value; }
            get { return _manage_type_id; }
        }
        /// <summary>
        /// 编码
        /// </summary>
        public string Manage_Type_Code
        {
            set { _manage_type_code = value; }
            get { return _manage_type_code; }
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string Manage_Type_Name
        {
            set { _manage_type_name = value; }
            get { return _manage_type_name; }
        }
        /// <summary>
        /// 出入库
        /// </summary>
        public string Manage_Type_InOut
        {
            set { _manage_type_inout = value; }
            get { return _manage_type_inout; }
        }
        /// <summary>
        /// 分组
        /// </summary>
        public string Manage_Type_Group
        {
            set { _manage_type_group = value; }
            get { return _manage_type_group; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Manage_Type_Remark
        {
            set { _manage_type_remark = value; }
            get { return _manage_type_remark; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Manage_Type_Order
        {
            set { _manage_type_order = value; }
            get { return _manage_type_order; }
        }
        /// <summary>
        /// 标记
        /// </summary>
        public string Manage_Type_Flag
        {
            set { _manage_type_flag = value; }
            get { return _manage_type_flag; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Type_Reserve1
        {
            set { _manage_type_reserve1 = value; }
            get { return _manage_type_reserve1; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Type_Reserve2
        {
            set { _manage_type_reserve2 = value; }
            get { return _manage_type_reserve2; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Type_Reserve3
        {
            set { _manage_type_reserve3 = value; }
            get { return _manage_type_reserve3; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Type_Reserve4
        {
            set { _manage_type_reserve4 = value; }
            get { return _manage_type_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Manage_Type_Reserve5
        {
            set { _manage_type_reserve5 = value; }
            get { return _manage_type_reserve5; }
        }
        #endregion Model

	}
}

