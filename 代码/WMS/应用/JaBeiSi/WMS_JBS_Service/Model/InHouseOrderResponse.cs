using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_JBS_Service
{
    public class InHouseOrderResponse 
    {
        
        
        /// <summary>
        ///WMS采购入库单号
        /// </summary>
        public string mes_receipt_no
        { get; set; }
        /// <summary>
        /// 采购订单 单据编号
        /// </summary>
        public string erp_receipt_no
        { get; set; }
        /// <summary>
        /// 订单日期
        /// </summary>
        public string mes_into_date

        { get; set; }
        /// <summary>
        /// 制单人名称
        /// </summary>
        public string mes_creator
        { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public string mes_receipt_type
        { get; set; }

        
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string mes_warehouse_code
        { get; set; }
      


        private List<InventoryInfo> inventoryList = new List<InventoryInfo>();
        public List<InventoryInfo> backIntoDetails
        {
            get { return this.inventoryList; }
            set { this.inventoryList = value; }
        }
    }

    public class InventoryInfo
    {
        /// <summary>
        /// 物料编码
        /// </summary>
        public string mes_materiel_code { get; set; }
        public string mes_unit { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string mes_total_qty { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string mes_lot_no { get; set; }
    }
}
