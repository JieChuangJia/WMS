using System;
namespace WMS_Database
{
	/// <summary>
    /// GoodsModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GoodsModel
	{
        public GoodsModel()
		{}
        #region Model
        private string _goods_id;
        private string _goods_class_id = "-1";
        private string _goods_code = "";
        private string _goods_name = "";
        private string _goods_type;
        private string _goods_suppier_code;
        private string _goods_model;
        private string _goods_desc = "";
        private string _goods_level;
        private string _goods_unit = "";
        private string _goods_limit_upper_quantity = "0";
        private string _goods_limit_lower_quantity = "0";
        private int? _goods_order = 0;
        private string _goods_flag = "0";
        private string _goods_danger;
        private string _goods_category;
        private DateTime? _goods_producedate;
        private string _goods_asset;
        private int? _goods_shelf_life;
        private string _goods_department;
        private string _goods_remark = "";
        private string _goods_reserve1;
        private string _goods_reserve2;
        private string _goods_reserve3;
        private string _goods_reserve4;
        private string _goods_reserve5;
        /// <summary>
        /// 物料索引
        /// </summary>
        public string Goods_ID
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 物料种类索引
        /// </summary>
        public string Goods_Class_ID
        {
            set { _goods_class_id = value; }
            get { return _goods_class_id; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string Goods_Code
        {
            set { _goods_code = value; }
            get { return _goods_code; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string Goods_Name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 物料类型
        /// </summary>
        public string Goods_Type
        {
            set { _goods_type = value; }
            get { return _goods_type; }
        }
        /// <summary>
        /// 供应商代码
        /// </summary>
        public string Goods_Suppier_Code
        {
            set { _goods_suppier_code = value; }
            get { return _goods_suppier_code; }
        }
        /// <summary>
        /// 物料规格型号
        /// </summary>
        public string Goods_Model
        {
            set { _goods_model = value; }
            get { return _goods_model; }
        }
        /// <summary>
        /// 物料描述
        /// </summary>
        public string Goods_Desc
        {
            set { _goods_desc = value; }
            get { return _goods_desc; }
        }
        /// <summary>
        /// 物资等级
        /// </summary>
        public string Goods_Level
        {
            set { _goods_level = value; }
            get { return _goods_level; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string Goods_Unit
        {
            set { _goods_unit = value; }
            get { return _goods_unit; }
        }
        /// <summary>
        /// 物料存储上限
        /// </summary>
        public string Goods_Limit_Upper_Quantity
        {
            set { _goods_limit_upper_quantity = value; }
            get { return _goods_limit_upper_quantity; }
        }
        /// <summary>
        /// 物料存储下限
        /// </summary>
        public string Goods_Limit_Lower_Quantity
        {
            set { _goods_limit_lower_quantity = value; }
            get { return _goods_limit_lower_quantity; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Goods_Order
        {
            set { _goods_order = value; }
            get { return _goods_order; }
        }
        /// <summary>
        /// 是否有效(1,有效,0无效)
        /// </summary>
        public string Goods_Flag
        {
            set { _goods_flag = value; }
            get { return _goods_flag; }
        }
        /// <summary>
        /// 是否危险品
        /// </summary>
        public string Goods_Danger
        {
            set { _goods_danger = value; }
            get { return _goods_danger; }
        }
        /// <summary>
        /// 一级分类
        /// </summary>
        public string Goods_Category
        {
            set { _goods_category = value; }
            get { return _goods_category; }
        }
        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime? Goods_ProduceDate
        {
            set { _goods_producedate = value; }
            get { return _goods_producedate; }
        }
        /// <summary>
        /// 是否固定资产
        /// </summary>
        public string Goods_Asset
        {
            set { _goods_asset = value; }
            get { return _goods_asset; }
        }
        /// <summary>
        /// 保质期
        /// </summary>
        public int? Goods_Shelf_Life
        {
            set { _goods_shelf_life = value; }
            get { return _goods_shelf_life; }
        }
        /// <summary>
        /// 归口部门
        /// </summary>
        public string Goods_Department
        {
            set { _goods_department = value; }
            get { return _goods_department; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Goods_Remark
        {
            set { _goods_remark = value; }
            get { return _goods_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Reserve1
        {
            set { _goods_reserve1 = value; }
            get { return _goods_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Reserve2
        {
            set { _goods_reserve2 = value; }
            get { return _goods_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Reserve3
        {
            set { _goods_reserve3 = value; }
            get { return _goods_reserve3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Reserve4
        {
            set { _goods_reserve4 = value; }
            get { return _goods_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Reserve5
        {
            set { _goods_reserve5 = value; }
            get { return _goods_reserve5; }
        }
        #endregion Model
	}
}

