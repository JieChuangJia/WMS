using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS_Interface
{
    public interface IWMSFrame
    {
        void WriteLog(string logSrc, string category,string level, string content);
        void ShowView(Form tabForm, bool isTab);
        bool AddTitlePage(string pageName, ref string restr);
        bool AddGroup(string pageName, string groupName, ref string restr);
        bool AddButtonItem(string pageName, string groupName, string itemName, Image itemImage, ItemClickEventHandler callBack, ref string restr);

        void SetTabChangeEvent(EventHandler tabChangeEventHandler);

        void SetVersion(string version);

        string CurrentUser { get; set; }
        int RoleID { get; set; }
    }
}
