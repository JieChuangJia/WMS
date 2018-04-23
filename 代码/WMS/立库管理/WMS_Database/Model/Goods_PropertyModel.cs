using System;
namespace WMS_Database
{
	/// <summary>
    /// Goods_PropertyModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Goods_PropertyModel
	{
        public Goods_PropertyModel()
		{}
        #region Model
        private string _goods_property_id;
        private string _goods_id = "-1";
        private string _goods_property_code;
        private string _goods_property_name;
        private string _goods_property_data;
        private string _goods_property_fielddatatype;
        private int? _goods_property_order = 0;
        private string _goods_property_flag;
        private string _goods_property_valid;
        private string _goods_property_remark;
        private string _goods_property_reserve1;
        private string _goods_property_reserve2;
        private string _goods_property_reserve3;
        private string _goods_property_reserve4;
        private string _goods_property_reserve5;
        /// <summary>
        /// 物料属性编号
        /// </summary>
        public string Goods_Property_ID
        {
            set { _goods_property_id = value; }
            get { return _goods_property_id; }
        }
        /// <summary>
        /// 物料类型编号
        /// </summary>
        public string Goods_ID
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 编码
        /// </summary>
        public string Goods_Property_Code
        {
            set { _goods_property_code = value; }
            get { return _goods_property_code; }
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string Goods_Property_Name
        {
            set { _goods_property_name = value; }
            get { return _goods_property_name; }
        }
        /// <summary>
        /// 数据源
        /// </summary>
        public string Goods_Property_Data
        {
            set { _goods_property_data = value; }
            get { return _goods_property_data; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Property_FieldDataType
        {
            set { _goods_property_fielddatatype = value; }
            get { return _goods_property_fielddatatype; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Goods_Property_Order
        {
            set { _goods_property_order = value; }
            get { return _goods_property_order; }
        }
        /// <summary>
        /// 标记
        /// </summary>
        public string Goods_Property_Flag
        {
            set { _goods_property_flag = value; }
            get { return _goods_property_flag; }
        }
        /// <summary>
        /// 是否必填
        /// </summary>
        public string Goods_Property_Valid
        {
            set { _goods_property_valid = value; }
            get { return _goods_property_valid; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Goods_Property_Remark
        {
            set { _goods_property_remark = value; }
            get { return _goods_property_remark; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Goods_Property_Reserve1
        {
            set { _goods_property_reserve1 = value; }
            get { return _goods_property_reserve1; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Goods_Property_Reserve2
        {
            set { _goods_property_reserve2 = value; }
            get { return _goods_property_reserve2; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Goods_Property_Reserve3
        {
            set { _goods_property_reserve3 = value; }
            get { return _goods_property_reserve3; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Goods_Property_Reserve4
        {
            set { _goods_property_reserve4 = value; }
            get { return _goods_property_reserve4; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Goods_Property_Reserve5
        {
            set { _goods_property_reserve5 = value; }
            get { return _goods_property_reserve5; }
        }
        #endregion Model

	}
}

