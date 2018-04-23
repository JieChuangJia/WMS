using System;
namespace WMS_Database
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class WH_AreaModel
	{
        public WH_AreaModel()
		{}
        #region Model
        private string _area_id;
        private string _warehouse_id;
        private string _area_type;
        private string _area_code;
        private string _area_name;
        private int? _area_order;
        private string _area_flag;
        private string _area_backcolor;
        private string _area_remark;
        private string _area_reserve1;
        private string _area_reserve2;
        private string _area_reserve3;
        private string _area_reserve4;
        private string _area_reserve5;
        /// <summary>
        /// 库区编号
        /// </summary>
        public string Area_ID
        {
            set { _area_id = value; }
            get { return _area_id; }
        }
        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WareHouse_ID
        {
            set { _warehouse_id = value; }
            get { return _warehouse_id; }
        }
        /// <summary>
        /// 库区类型
        /// </summary>
        public string Area_Type
        {
            set { _area_type = value; }
            get { return _area_type; }
        }
        /// <summary>
        /// 库区编码
        /// </summary>
        public string Area_Code
        {
            set { _area_code = value; }
            get { return _area_code; }
        }
        /// <summary>
        /// 库区名称
        /// </summary>
        public string Area_Name
        {
            set { _area_name = value; }
            get { return _area_name; }
        }
        /// <summary>
        /// 库区排序
        /// </summary>
        public int? Area_Order
        {
            set { _area_order = value; }
            get { return _area_order; }
        }
        /// <summary>
        /// 库区标志
        /// </summary>
        public string Area_Flag
        {
            set { _area_flag = value; }
            get { return _area_flag; }
        }
        /// <summary>
        /// 区域背景色（R,G,B）
        /// </summary>
        public string Area_BackColor
        {
            set { _area_backcolor = value; }
            get { return _area_backcolor; }
        }
        /// <summary>
        /// 库区备注
        /// </summary>
        public string Area_Remark
        {
            set { _area_remark = value; }
            get { return _area_remark; }
        }
        /// <summary>
        /// 备用1
        /// </summary>
        public string Area_Reserve1
        {
            set { _area_reserve1 = value; }
            get { return _area_reserve1; }
        }
        /// <summary>
        /// 备用2
        /// </summary>
        public string Area_Reserve2
        {
            set { _area_reserve2 = value; }
            get { return _area_reserve2; }
        }
        /// <summary>
        /// 备用3
        /// </summary>
        public string Area_Reserve3
        {
            set { _area_reserve3 = value; }
            get { return _area_reserve3; }
        }
        /// <summary>
        /// 备用4
        /// </summary>
        public string Area_Reserve4
        {
            set { _area_reserve4 = value; }
            get { return _area_reserve4; }
        }
        /// <summary>
        /// 备用5
        /// </summary>
        public string Area_Reserve5
        {
            set { _area_reserve5 = value; }
            get { return _area_reserve5; }
        }
        #endregion Model

	}
}

