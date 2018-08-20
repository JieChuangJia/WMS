using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class UnShelveWithoutPlanViewData
    {
        private BindingList<PalletInfor> palletInforData = new BindingList<PalletInfor>();
        public BindingList<PalletInfor> PalletInforData
        {
            get { return this.palletInforData; }
            set { this.palletInforData = value; }
        }
        private BindingList<PalletData> palletData = new BindingList<PalletData>();
        public BindingList<PalletData> PalletData
        {
            get { return this.palletData; }
            set { this.palletData = value; }
        }
        
        public UnShelveWithoutPlanViewData()
        { }


    }
    
}
