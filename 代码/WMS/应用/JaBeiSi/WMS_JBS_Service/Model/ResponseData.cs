using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_JBS_Service
{
    public class ResponseData
    {  /// <summary>
        /// 执行状态，true、false
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 执行描述
        /// </summary>
        public string Describe { get; set; }
        public ResponseData()
        { }
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
