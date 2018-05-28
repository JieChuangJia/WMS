using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface ISysLogView:IBaseView
    {
        void ShowLog(DataTable logdata);
    }
    public class SysLogFilterModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string LogLevel { get; set; }
        public string LikeContent { get; set; }
        public bool LikeQueryEnable { get; set; }
        public SysLogFilterModel()
        {
            StartDate = System.DateTime.Now - (new TimeSpan(30, 0, 0, 0));
            EndDate = System.DateTime.Now + new TimeSpan(1, 0, 0, 0);
            LogLevel = EnumLoglevel.提示.ToString();
            LikeContent = "";
            LikeQueryEnable = false;
        }
    }
}
