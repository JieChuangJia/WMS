using System;
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// ERP_Shelf_VG:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ERP_Shelf_VGModel
    {
        public ERP_Shelf_VGModel()
        { }
        #region Model
        private string _erp_shelf_vg_id;
        private string _erp_shelf_vg_code;
        private string _erp_shelf_vg_name;
        private string _erp_shelf_vg_reserve1;
        private string _erp_shelf_vg_reserve2;
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Shelf_VG_ID
        {
            set { _erp_shelf_vg_id = value; }
            get { return _erp_shelf_vg_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Shelf_VG_Code
        {
            set { _erp_shelf_vg_code = value; }
            get { return _erp_shelf_vg_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Shelf_VG_Name
        {
            set { _erp_shelf_vg_name = value; }
            get { return _erp_shelf_vg_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Shelf_VG_Reserve1
        {
            set { _erp_shelf_vg_reserve1 = value; }
            get { return _erp_shelf_vg_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Shelf_VG_Reserve2
        {
            set { _erp_shelf_vg_reserve2 = value; }
            get { return _erp_shelf_vg_reserve2; }
        }
        #endregion Model

    }
}

