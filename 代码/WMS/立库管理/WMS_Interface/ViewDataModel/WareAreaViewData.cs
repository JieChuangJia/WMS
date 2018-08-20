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

  
}
