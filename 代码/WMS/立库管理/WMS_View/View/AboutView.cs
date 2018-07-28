using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Interface;

namespace WMS_Kernel
{
    public partial class AboutView : ChildViewBase
    {
        public AboutView()
        {
            InitializeComponent();
        }
        public void SetVersion(string version)
        {
            this.lc_SysVersion.Text = version;
        }
    }
}
