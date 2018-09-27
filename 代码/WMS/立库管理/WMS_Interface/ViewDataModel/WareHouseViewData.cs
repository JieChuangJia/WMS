using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class WareHouseViewData
    {
        private BindingList<WareHouseDataModel> whistData = new BindingList<WareHouseDataModel>();
        public BindingList<WareHouseDataModel> WHListData { get { return this.whistData; } set { this.whistData = value; } }

        public WareHouseViewData()
        { }
    }

    
}
