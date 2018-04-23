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

namespace WMS_Kernel
{
    public partial class InWareWithoutPlanView : ChildViewBase
    {
        public InWareWithoutPlanView()
        {
            InitializeComponent();

        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);

            string restr = "";

            //Bitmap bitmap = ImageResource.InWareWithoutPlan.ToBitmap();
            //this.IWmsFrame.AddTitlePage("任务管理", ref restr);
            //this.IWmsFrame.AddGroup("任务管理", "任务操作", ref restr);
            //this.IWmsFrame.AddButtonItem("任务管理", "任务操作", "无计划配盘入库", bitmap, ShowTabEventHandler, ref restr);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }




     
    }
}