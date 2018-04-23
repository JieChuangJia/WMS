using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS_Interface
{
    public interface IBaseView
    {
       
        void ShowMessage(string title, string content);

        int AskMessage(string title, string content);
     
    }
}
