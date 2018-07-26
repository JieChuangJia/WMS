using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class StockQueryParm
    {
        public string HouseName { get; set; }
        public string Rowth { get; set; }
        public string Colth { get; set; }
        public string Layer { get; set; }
        public string MaterialCate { get; set; }
        public string PalletCode { get; set; }
        public StockQueryParm()
        { }


    }
}
