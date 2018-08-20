using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PalletManageViewData
    {
        private BindingList<PalletGoodsListModel> palletInforData = new BindingList<PalletGoodsListModel>();
        public BindingList<PalletGoodsListModel> PalletInforData
        {
            get { return this.palletInforData; }
            set { this.palletInforData = value; }
        }

        private BindingList<PalletListData> palletList = new BindingList<PalletListData>();
        public BindingList<PalletListData> PalletList
        {
            get { return this.palletList; }
            set { this.palletList = value; }
        }
        private BindingList<GoodsDataModel> palletGoodsData = new BindingList<GoodsDataModel>();
        public BindingList<GoodsDataModel> PalletGoodsData
        {
            get { return this.palletGoodsData; }
            set { this.palletGoodsData = value; }
        }
        public PalletManageViewData()
        { }
    }
   
}
