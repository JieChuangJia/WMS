using System;
namespace WMS_Database
{
    /// <summary>
    /// Control_Apply:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Control_ApplyModel
    {
        public Control_ApplyModel()
        { }
        #region Model
        private string _control_apply_id;
        private string _control_apply_type = "";
        private string _control_apply_wh_code = "";
        private string _control_apply_device_code = "";
        private string _control_apply_tray_barcode = "";
        private string _control_apply_status = "-1";
        private DateTime _control_apply_time;
        private string _control_apply_remark = "";
        private string _control_apply_reserve1;
        private string _control_apply_reserve2;
        private string _control_apply_reserve3;
        private string _control_apply_reserve4;
        private string _control_apply_reserve5;
        /// <summary>
        /// 申请任务编号
        /// </summary>
        public string Control_Apply_ID
        {
            set { _control_apply_id = value; }
            get { return _control_apply_id; }
        }
        /// <summary>
        /// 申请任务类型
        /// </summary>
        public string Control_Apply_Type
        {
            set { _control_apply_type = value; }
            get { return _control_apply_type; }
        }
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string Control_Apply_WH_CODE
        {
            set { _control_apply_wh_code = value; }
            get { return _control_apply_wh_code; }
        }
        /// <summary>
        /// 位置编码
        /// </summary>
        public string Control_Apply_Device_Code
        {
            set { _control_apply_device_code = value; }
            get { return _control_apply_device_code; }
        }
        /// <summary>
        /// 托盘条码
        /// </summary>
        public string Control_Apply_Tray_BarCode
        {
            set { _control_apply_tray_barcode = value; }
            get { return _control_apply_tray_barcode; }
        }
        /// <summary>
        /// 申请任务的处理状态，已处理，错误
        /// </summary>
        public string Control_Apply_Status
        {
            set { _control_apply_status = value; }
            get { return _control_apply_status; }
        }
        /// <summary>
        /// 任务申请时间
        /// </summary>
        public DateTime Control_Apply_Time
        {
            set { _control_apply_time = value; }
            get { return _control_apply_time; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Control_Apply_Remark
        {
            set { _control_apply_remark = value; }
            get { return _control_apply_remark; }
        }
        /// <summary>
        /// 备用1
        /// </summary>
        public string Control_Apply_Reserve1
        {
            set { _control_apply_reserve1 = value; }
            get { return _control_apply_reserve1; }
        }
        /// <summary>
        /// 备用2
        /// </summary>
        public string Control_Apply_Reserve2
        {
            set { _control_apply_reserve2 = value; }
            get { return _control_apply_reserve2; }
        }
        /// <summary>
        /// 备用3
        /// </summary>
        public string Control_Apply_Reserve3
        {
            set { _control_apply_reserve3 = value; }
            get { return _control_apply_reserve3; }
        }
        /// <summary>
        /// 备用4
        /// </summary>
        public string Control_Apply_Reserve4
        {
            set { _control_apply_reserve4 = value; }
            get { return _control_apply_reserve4; }
        }
        /// <summary>
        /// 备用5
        /// </summary>
        public string Control_Apply_Reserve5
        {
            set { _control_apply_reserve5 = value; }
            get { return _control_apply_reserve5; }
        }
        #endregion Model

    }
}

