using System;
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// ERP_WH_VG_REL:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ERP_WH_VG_RELModel
    {
        public ERP_WH_VG_RELModel()
        { }
        #region Model
        private string _erp_wh_vg_rel_id;
        private string _erp_wh_vg_id;
        private string _erp_shelf_vg_vlist_id;
        private string _erp_wh_vg_rel_value;
        /// <summary>
        /// 
        /// </summary>
        public string ERP_WH_VG_REL_ID
        {
            set { _erp_wh_vg_rel_id = value; }
            get { return _erp_wh_vg_rel_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_WH_VG_ID
        {
            set { _erp_wh_vg_id = value; }
            get { return _erp_wh_vg_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Shelf_VG_VList_ID
        {
            set { _erp_shelf_vg_vlist_id = value; }
            get { return _erp_shelf_vg_vlist_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_WH_VG_REL_Value
        {
            set { _erp_wh_vg_rel_value = value; }
            get { return _erp_wh_vg_rel_value; }
        }
        #endregion Model

    }
}

