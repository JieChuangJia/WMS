using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class WareAreaViewData
    {
        private BindingList<AreaDataModel> areaListData = new BindingList<AreaDataModel>();
        public BindingList<AreaDataModel> AreaListData { get { return this.areaListData; } set { this.areaListData = value; } }

        private BindingList<AreaColorModel> areaColorListData = new BindingList<AreaColorModel>();
        public BindingList<AreaColorModel> AreaColorListData { get { return this.areaColorListData; } set { this.areaColorListData = value; } }

        public WareAreaViewData()
        { }
    }

    public class AreaDataModel
    {
        public string 区域编号 { get; set; }
        public string 库房名称 { get; set; }
        public string 区域名称 { get; set; }
        public string 区域编码 { get; set; }
        public string 区域类型 { get; set; }
        //public string 区域启用状态 { get; set; }
        public string 区域颜色 { get; set; }

        public AreaDataModel()
        { }

    }

    public class AreaColorModel
    {
        public string 区域名称 { get; set; }
        public string 区域颜色 { get; set; }

        public AreaColorModel()
        { }

    }
}
