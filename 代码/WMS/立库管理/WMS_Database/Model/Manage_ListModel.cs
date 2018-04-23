using System;
namespace WMS_Database
{
	/// <summary>
    /// Manage_ListModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Manage_ListModel
	{
        public Manage_ListModel()
		{}
        #region Model
        private string _manage_list_id;
        private string _mange_id = "-1";
        private string _stock_list_id = "-1";
        private string _manage_list_quantity = "0";
        private string _manage_list_remark = "";
        private string _manage_reserve1;
        private string _manage_reserve2;
        private string _manage_reserve3;
        private string _manage_reserve4;
        private string _manage_reserve5;
        /// <summary>
        /// 任务列表编号
        /// </summary>
        public string Manage_List_ID
        {
            set { _manage_list_id = value; }
            get { return _manage_list_id; }
        }
        /// <summary>
        /// 管理任务索引
        /// </summary>
        public string Mange_ID
        {
            set { _mange_id = value; }
            get { return _mange_id; }
        }
        /// <summary>
        /// 库存详单索引
        /// </summary>
        public string Stock_List_ID
        {
            set { _stock_list_id = value; }
            get { return _stock_list_id; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public string Manage_List_Quantity
        {
            set { _manage_list_quantity = value; }
            get { return _manage_list_quantity; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Manage_List_Remark
        {
            set { _manage_list_remark = value; }
            get { return _manage_list_remark; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Reserve1
        {
            set { _manage_reserve1 = value; }
            get { return _manage_reserve1; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Reserve2
        {
            set { _manage_reserve2 = value; }
            get { return _manage_reserve2; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Reserve3
        {
            set { _manage_reserve3 = value; }
            get { return _manage_reserve3; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Reserve4
        {
            set { _manage_reserve4 = value; }
            get { return _manage_reserve4; }
        }
        /// <summary>
        /// 备用字段
        /// </summary>
        public string Manage_Reserve5
        {
            set { _manage_reserve5 = value; }
            get { return _manage_reserve5; }
        }
        #endregion Model
	}
}

