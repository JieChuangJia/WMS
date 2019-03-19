using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_JBS_Service
{
    public class MaterialInfo 
    {
        public string material_code { get; set; }
        public string material_category
        { get; set; }
        public string material_class
        { get; set; }
        public string material_name
        { get; set; }
        public string material_model
        { get; set; }
        public string material_supplier_code
        { get; set; }
        public string material_unit
        { get; set; }
        public bool material_enabled
        { get; set; }
        public int material_shelflife
        { get; set; }
        public int op_flag

        { get; set; }
    }
}
