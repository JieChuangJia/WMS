
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_JBS_Service
{
    public class OutHouseOrderResponse 
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
        /// 销售类型
        /// </summary>
        public string order_voucherType
        { get; set; }

        private List<InventoryInfo> inventoryList = new List<InventoryInfo>();
        /// <summary>
        /// 订单物料清单
        /// </summary>
        public List<InventoryInfo> MaterilaList
        {
            get { return this.inventoryList; }
            set { this.inventoryList = value; }
        }
    }
 
}
