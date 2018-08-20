using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class TrayGoodsManageViewData
    {
        private BindingList<TrayGoodsViewModel> trayGoodsData = new BindingList<TrayGoodsViewModel>();
        public BindingList<TrayGoodsViewModel> TrayGoodsData
        {
            get { return this.trayGoodsData; }
            set { this.trayGoodsData = value; }
        }
        public TrayGoodsManageViewData()
        { }
    }
   
    
}
