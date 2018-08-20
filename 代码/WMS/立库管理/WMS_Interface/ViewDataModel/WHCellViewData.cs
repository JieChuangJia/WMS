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

    
}
