using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Interface;

namespace WMS_Service_Main
{
    public partial class ServiceManageView : ChildViewBase,ISvrManaView
    {
        SvrManagePresenter presenter = null;
        public ServiceManageView()
        {
            InitializeComponent();
            this.presenter = new SvrManagePresenter(this);
        }
        private void ServiceManageView_Load(object sender, EventArgs e)
        {

         

        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter.Init(wmsFrame);

            string restr = "";

            Bitmap servListBmp = ImageSource.ServList.ToBitmap();
            this.IWmsFrame.AddTitlePage("服务管理", ref restr);
            this.IWmsFrame.AddGroup("服务管理", "服务操作", ref restr);
            this.IWmsFrame.AddButtonItem("服务管理", "服务操作", "服务管理", servListBmp, ShowTabEventHandler, ref restr);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        private void sb_StartSvr_Click(object sender, EventArgs e)
        {
         
            string wms_SvrAddr = ConfigurationManager.AppSettings["WMS_SvrAddr"];
            this.presenter.StartWMSSvr(new Uri(wms_SvrAddr));

            string ERP_SvrAddr = ConfigurationManager.AppSettings["WMS_To_ERP_SvrAddr"];
            this.presenter.StartERPSvr(new Uri(ERP_SvrAddr));

        }

        private void sb_StopSvr_Click(object sender, EventArgs e)
        {   
            //string ERP_SvrAddr = ConfigurationManager.AppSettings["ERP_SvrAddr"];
            //this.presenter.StopERPSvr(new Uri(ERP_SvrAddr));
            string wms_SvrAddr = ConfigurationManager.AppSettings["WMS_SvrAddr"];
            this.presenter.StopWMSSvr(new Uri(wms_SvrAddr));
        }

      

    
    }
}
