using System;
namespace WMS_Database
{
	/// <summary>
    /// Goods_ClassModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Goods_ClassModel
	{
        public Goods_ClassModel()
		{}
        #region Model
        private string _goods_class_id;
        private string _goods_class_parent_id = "0";
        private string _goods_class_code = "";
        private string _goods_class_name = "";
        private string _goods_class_remark = "";
        private int? _goods_class_order = 0;
        private string _goods_class_flag = "";
        private string _goods_class_reserve1;
        private string _goods_class_reserve2;
        private string _goods_class_reserve3;
        private string _goods_class_reserve4;
        private string _goods_class_reserve5;
        /// <summary>
        /// 物料种类索引
        /// </summary>
        public string Goods_Class_ID
        {
            set { _goods_class_id = value; }
            get { return _goods_class_id; }
        }
        /// <summary>
        /// 物料种类父索引
        /// </summary>
        public string Goods_Class_Parent_ID
        {
            set { _goods_class_parent_id = value; }
            get { return _goods_class_parent_id; }
        }
        /// <summary>
        /// 物料种类编码
        /// </summary>
        public string Goods_Class_Code
        {
            set { _goods_class_code = value; }
            get { return _goods_class_code; }
        }
        /// <summary>
        /// 物料种类名称
        /// </summary>
        public string Goods_Class_Name
        {
            set { _goods_class_name = value; }
            get { return _goods_class_name; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Goods_Class_Remark
        {
            set { _goods_class_remark = value; }
            get { return _goods_class_remark; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Goods_Class_Order
        {
            set { _goods_class_order = value; }
            get { return _goods_class_order; }
        }
        /// <summary>
        /// 标志位
        /// </summary>
        public string Goods_Class_Flag
        {
            set { _goods_class_flag = value; }
            get { return _goods_class_flag; }
        }
        /// <summary>
        /// 物料类备用字段1
        /// </summary>
        public string Goods_Class_Reserve1
        {
            set { _goods_class_reserve1 = value; }
            get { return _goods_class_reserve1; }
        }
        /// <summary>
        /// 物料类备用字段2
        /// </summary>
        public string Goods_Class_Reserve2
        {
            set { _goods_class_reserve2 = value; }
            get { return _goods_class_reserve2; }
        }
        /// <summary>
        /// 物料类备用字段3
        /// </summary>
        public string Goods_Class_Reserve3
        {
            set { _goods_class_reserve3 = value; }
            get { return _goods_class_reserve3; }
        }
        /// <summary>
        /// 物料类备用字段4
        /// </summary>
        public string Goods_Class_Reserve4
        {
            set { _goods_class_reserve4 = value; }
            get { return _goods_class_reserve4; }
        }
        /// <summary>
        /// 物料类备用字段5
        /// </summary>
        public string Goods_Class_Reserve5
        {
            set { _goods_class_reserve5 = value; }
            get { return _goods_class_reserve5; }
        }
        #endregion Model

	}
}

