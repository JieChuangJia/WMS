using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS_Interface;
using DevExpress.XtraBars;
using System.Reflection;

namespace WMS_Kernel
{
    public partial class ModPasswordView : ChildViewBase
    {
      
        public ModPasswordView()
        {
            InitializeComponent();
          
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);

            string restr = "";

            Bitmap bitmap = ImageResource.ModifyPassWord.ToBitmap();
            this.IWmsFrame.AddTitlePage("系统", ref restr);
            this.IWmsFrame.AddGroup("系统", "系统配置", ref restr);
            this.IWmsFrame.AddButtonItem("系统", "系统配置", "修改密码", bitmap, ShowTabEventHandler, ref restr);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

    }
}