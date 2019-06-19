using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCFClient
{
    public class AParam
    {
        public string KK { get; set; }
        public string MM { get; set; }
    }
    public class TestClass
    {
        public string materialPlanOrderJson { get; set; }

        public TestClass()
        { }
    }
    public class MaterialJson
    {
        public string materialInfoJson { get; set; }
        public string operateType { get; set; }
    }
}
