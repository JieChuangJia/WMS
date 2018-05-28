using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;

namespace WMS_Kernel
{
    public class Goods
    {
        public string MaterialID { get; set; }
        public string MaterialType { get; set; }
        public string MaterialName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialUnit { get; set; }
        public string MaterialFlag { get; set; }
        public string MaterialModel { get; set; }


    }
    public interface IAddMaterialView
    {
        void ShowMaterialType(List<string> typeList);
    }
}
