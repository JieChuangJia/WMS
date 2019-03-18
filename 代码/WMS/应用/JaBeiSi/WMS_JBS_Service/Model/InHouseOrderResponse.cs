using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_JBS_Service
{
    public class InHouseOrderResponse 
    {
        /// <summary>
        /// 订单编码
        /// </summary>
        public string order_code
        { get; set; }
        /// <summary>
        /// 入库单号
        /// </summary>
        public string wms_order_code
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
        /// 仓库编码
        /// </summary>
        public string warehouse_name

        { get; set; }

        /// <summary>
        /// 采购类型
        /// </summary>
        public string order_voucherType
        { get; set; }

        private List<InventoryInfo> inventoryList = new List<InventoryInfo>();
        public List<InventoryInfo> InventoryList
        {
            get { return this.inventoryList; }
            set { this.inventoryList = value; }
        }
    }

    public class InventoryInfo
    {
        /// <summary>
        /// 库存编码
        /// </summary>
        public string inventory_code { get; set; }
        public string inventory_name { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string quantity { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string serial { get; set; }
    }
}
