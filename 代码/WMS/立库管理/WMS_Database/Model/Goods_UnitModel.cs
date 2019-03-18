using System;
namespace WMS_Database
{
    /// <summary>
    /// Goods_Unit:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Goods_UnitModel
    {
        public Goods_UnitModel()
        { }
        #region Model
        private string _goods_unit_id;
        private string _goods_unit_name;
        private string _goods_unit_code;
        private string _goods_unit_remark;
        /// <summary>
        /// 单位编码
        /// </summary>
        public string Goods_Unit_ID
        {
            set { _goods_unit_id = value; }
            get { return _goods_unit_id; }
        }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string Goods_Unit_Name
        {
            set { _goods_unit_name = value; }
            get { return _goods_unit_name; }
        }
        /// <summary>
        /// 单位编码
        /// </summary>
        public string Goods_Unit_Code
        {
            set { _goods_unit_code = value; }
            get { return _goods_unit_code; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Goods_Unit_Remark
        {
            set { _goods_unit_remark = value; }
            get { return _goods_unit_remark; }
        }
        #endregion Model

    }
}

