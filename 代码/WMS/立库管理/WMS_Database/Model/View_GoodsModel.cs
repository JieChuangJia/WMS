using System;
namespace WMS_Database
{
    /// <summary>
    /// View_Goods:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_GoodsModel
    {
        public View_GoodsModel()
        { }
        #region Model
        private string _goods_class_id;
        private string _goods_id;
        private string _goods_code;
        private string _goods_name;
        private string _goods_desc;
        private string _goods_model;
        private string _goods_level;
        private string _goods_unit;
        private string _goods_limit_upper_quantity;
        private string _goods_limit_lower_quantity;
        private string _goods_remark;
        private int? _goods_order;
        private string _goods_flag;
        private string _goods_danger;
        private string _goods_category;
        private string _goods_asset;
        private string _goods_department;
        private string _goods_reserve1;
        private string _goods_reserve2;
        private string _goods_reserve3;
        private string _goods_reserve4;
        private string _goods_reserve5;
        private string _goods_class_parent_id;
        private string _goods_class_code;
        private string _goods_class_name;
        private string _goods_class_remark;
        private int? _goods_class_order;
        private string _goods_class_reserve1;
        private string _goods_class_flag;
        private string _goods_class_reserve2;
        private string _goods_class_reserve4;
        private string _goods_class_reserve3;
        private string _goods_class_reserve5;
        private string _goods_type;
        private string _goods_suppier_code;
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_ID
        {
            set { _goods_class_id = value; }
            get { return _goods_class_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_ID
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Code
        {
            set { _goods_code = value; }
            get { return _goods_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Desc
        {
            set { _goods_desc = value; }
            get { return _goods_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Model
        {
            set { _goods_model = value; }
            get { return _goods_model; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Level
        {
            set { _goods_level = value; }
            get { return _goods_level; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Unit
        {
            set { _goods_unit = value; }
            get { return _goods_unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Limit_Upper_Quantity
        {
            set { _goods_limit_upper_quantity = value; }
            get { return _goods_limit_upper_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Limit_Lower_Quantity
        {
            set { _goods_limit_lower_quantity = value; }
            get { return _goods_limit_lower_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Remark
        {
            set { _goods_remark = value; }
            get { return _goods_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Goods_Order
        {
            set { _goods_order = value; }
            get { return _goods_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Flag
        {
            set { _goods_flag = value; }
            get { return _goods_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Danger
        {
            set { _goods_danger = value; }
            get { return _goods_danger; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Category
        {
            set { _goods_category = value; }
            get { return _goods_category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Asset
        {
            set { _goods_asset = value; }
            get { return _goods_asset; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Department
        {
            set { _goods_department = value; }
            get { return _goods_department; }
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
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Parent_ID
        {
            set { _goods_class_parent_id = value; }
            get { return _goods_class_parent_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Code
        {
            set { _goods_class_code = value; }
            get { return _goods_class_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Name
        {
            set { _goods_class_name = value; }
            get { return _goods_class_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Remark
        {
            set { _goods_class_remark = value; }
            get { return _goods_class_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Goods_Class_Order
        {
            set { _goods_class_order = value; }
            get { return _goods_class_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Reserve1
        {
            set { _goods_class_reserve1 = value; }
            get { return _goods_class_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Flag
        {
            set { _goods_class_flag = value; }
            get { return _goods_class_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Reserve2
        {
            set { _goods_class_reserve2 = value; }
            get { return _goods_class_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Reserve4
        {
            set { _goods_class_reserve4 = value; }
            get { return _goods_class_reserve4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Reserve3
        {
            set { _goods_class_reserve3 = value; }
            get { return _goods_class_reserve3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Reserve5
        {
            set { _goods_class_reserve5 = value; }
            get { return _goods_class_reserve5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Type
        {
            set { _goods_type = value; }
            get { return _goods_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Suppier_Code
        {
            set { _goods_suppier_code = value; }
            get { return _goods_suppier_code; }
        }
        #endregion Model
    }
}

