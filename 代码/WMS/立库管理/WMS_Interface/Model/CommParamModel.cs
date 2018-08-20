using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
   public class UnshelveWithoutPlanQueryParamModel
   {
       private CheckParamModel row = new CheckParamModel();
       public CheckParamModel Row { get { return this.row; } set { this.row = value; } }

       private CheckParamModel position = new CheckParamModel();
       public CheckParamModel Position { get { return this.position; } set { this.position = value; } }

       private CheckParamModel cell = new CheckParamModel();
       public CheckParamModel Cell { get { return this.cell; } set { this.cell = value; } }

       private CheckParamModel palletCode = new CheckParamModel();
       public CheckParamModel PalletCode { get { return this.palletCode; } set { this.palletCode = value; } }


   }
   public class CheckParamModel
   {
       public string ParamValue{get;set;}
       public bool Checked{get;set;}
   }
}
