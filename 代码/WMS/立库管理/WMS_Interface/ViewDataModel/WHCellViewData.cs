using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class WHCellViewData
    {
        private BindingList<WHCellDataModel> whCellListData = new BindingList<WHCellDataModel>();
        public BindingList<WHCellDataModel> WHCellListData { get { return this.whCellListData; } set { this.whCellListData = value; } }

        public WHCellViewData()
        { }
    }

    public class WHCellDataModel
    {
        public string 工位编号 { get; set; }
        public string 库区编码 { get; set; }
        public string 工位编码 { get; set; }
        public string 工位名称 { get; set; }
        public string 设备编码 { get; set; }
        public string 工位方向 { get; set; }
        public string 工位类型 { get; set; }

        public WHCellDataModel()
        { }

    }

}
