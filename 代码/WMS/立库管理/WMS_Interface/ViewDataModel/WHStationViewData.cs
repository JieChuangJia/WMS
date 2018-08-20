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

 
}
