using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_JBS_Service
{
    public class InHouseOrder 
    {
        /// <summary>
        /// 订单编码
        /// </summary>
        public string order_code
        { get; set; }
        /// <summary>
        /// 订单日期
        /// </summary>
        public string order_date

        { get; set; }
        /// <summary>
        /// 制单人
        /// </summary>
        public string order_maker

        { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string warehouse_code
        { get; set; }

        /// <summary>
        /// 采购类型
        /// </summary>
        public string order_voucherType
        { get; set; }

        private List<OderMaterialInfo> materilaList = new List<OderMaterialInfo>();
        /// <summary>
        /// 订单物料清单
        /// </summary>
        public  List<OderMaterialInfo> MaterilaList
        {
            get { return this.materilaList; }
            set { this.materilaList = value; }
        }
    }
    public class OderMaterialInfo
    {
        public string material_code { get; set; }
        public string material_name { get; set; }
        /// <summary>
        /// 物料规格型号
        /// </summary>
        public string material_model { get; set; }
        public string material_unit { get; set; }
        public string material_makedate { get; set; }
        public string material_batch { get; set; }

    }
}
