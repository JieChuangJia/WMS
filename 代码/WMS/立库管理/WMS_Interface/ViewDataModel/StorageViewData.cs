using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;

namespace WMS_Interface
{
    public class StorageViewData
    {
        private BindingList<CellGoodsDetailModel> cellGoodsDetailData = new BindingList<CellGoodsDetailModel>();
        public BindingList<CellGoodsDetailModel> CellGoodsDetailData { get { return this.cellGoodsDetailData; } set { this.cellGoodsDetailData = value; } }

       
        public StorageViewData()
        { }
    }

   
    
}
