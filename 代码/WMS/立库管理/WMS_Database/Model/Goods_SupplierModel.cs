using System;
namespace WMS_Database
{
    /// <summary>
    /// Goods_Supplier:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Goods_SupplierModel
    {
        public Goods_SupplierModel()
        { }
        #region Model
        private string _goods_supplier_id;
        private string _goods_supplier_name;
        private string _goods_supplier_code;
        private string _goods_supplier_telephone;
        private string _goods_supplier_addr;
        private string _goods_supplier_remark;
        /// <summary>
        /// 供应商ID
        /// </summary>
        public string Goods_Supplier_ID
        {
            set { _goods_supplier_id = value; }
            get { return _goods_supplier_id; }
        }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string Goods_Supplier_Name
        {
            set { _goods_supplier_name = value; }
            get { return _goods_supplier_name; }
        }
        /// <summary>
        /// 供应商编码
        /// </summary>
        public string Goods_Supplier_Code
        {
            set { _goods_supplier_code = value; }
            get { return _goods_supplier_code; }
        }
        /// <summary>
        /// 供应商电话
        /// </summary>
        public string Goods_Supplier_Telephone
        {
            set { _goods_supplier_telephone = value; }
            get { return _goods_supplier_telephone; }
        }
        /// <summary>
        /// 供应商地址
        /// </summary>
        public string Goods_Supplier_Addr
        {
            set { _goods_supplier_addr = value; }
            get { return _goods_supplier_addr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Supplier_Remark
        {
            set { _goods_supplier_remark = value; }
            get { return _goods_supplier_remark; }
        }
        #endregion Model

    }
}

