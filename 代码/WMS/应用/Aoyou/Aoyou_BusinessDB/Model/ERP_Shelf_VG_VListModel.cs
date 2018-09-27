using System;
namespace Aoyou_BusinessDB
{
    /// <summary>
    /// ERP_Shelf_VG_VList:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ERP_Shelf_VG_VListModel
    {
        public ERP_Shelf_VG_VListModel()
        { }
        #region Model
        private string _erp_shelf_vg_vlist_id;
        private string _erp_shelf_vg_id;
        private string _erp_shelf_vg_vlist_code;
        private string _erp_shelf_vg_vlist_name;
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
        public string ERP_Shelf_VG_ID
        {
            set { _erp_shelf_vg_id = value; }
            get { return _erp_shelf_vg_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Shelf_VG_VList_Code
        {
            set { _erp_shelf_vg_vlist_code = value; }
            get { return _erp_shelf_vg_vlist_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ERP_Shelf_VG_VList_Name
        {
            set { _erp_shelf_vg_vlist_name = value; }
            get { return _erp_shelf_vg_vlist_name; }
        }
        #endregion Model

    }
}

