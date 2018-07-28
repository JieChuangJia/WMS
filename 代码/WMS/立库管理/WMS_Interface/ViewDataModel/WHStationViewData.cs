using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class WHStationViewData
    {
        private BindingList<WHStationDataModel> whStationListData = new BindingList<WHStationDataModel>();
        public BindingList<WHStationDataModel> WHStationListData { get { return this.whStationListData; } set { this.whStationListData = value; } }


        public WHStationViewData()
        { }
    }

    public class WHStationDataModel
    {
        public string 工位逻辑编码 { get; set; }
        public string 工位编码 { get; set; }
        public string 库房编码 { get; set; }
        public string 工位逻辑类型 { get; set; }
        public string 工位逻辑名称 { get; set; }

        public WHStationDataModel()
        { }

    }
}
