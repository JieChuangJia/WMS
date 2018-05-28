using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class GSMemTempModel
    {
        /// <summary>
        /// 库房名称
        /// </summary>
        public string StoreHouseName { get; set; }
        /// <summary>
        /// 库房区域名称
        /// </summary>
        public string StoreAreaName { get; set; }
        /// <summary>
        /// 货位位置排列层1-2-3
        /// </summary>
        public string GSPos { get; set; }
        /// <summary>
        /// 货位任务状态
        /// </summary>
        public string GSTaskStatus { get; set; }
        /// <summary>
        /// 货位状态
        /// </summary>
        public string GSStatus { get; set; }
        /// <summary>
        /// 货位启用状态
        /// </summary>
        public bool GSEnabled { get; set; }
        /// <summary>
        /// 货位操作状态
        /// </summary>
        public string GSOperate { get; set; }
        /// <summary>
        /// 货位入库时间,没有库存入库时间为空
        /// </summary>
        public DateTime? InHouseDate { get; set; }
       
    }

    public class MoveHouseProModel
    {
        public string HouseName { get; set; }
        public string CellName { get; set; }
        public EnumCellPos CellPos { get; set; }
        public string CellChildID { get; set; }
    }
}
