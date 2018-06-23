using DevExpress.XtraBars;
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
    public partial class SysLogView : ChildViewBase,ISysLogView
    {
        SysLogPresenter presenter = null;
        public SysLogView()
        {
            InitializeComponent();

            this.de_StartTime.DateTime = DateTime.Now.AddDays(-1);
            this.de_EndTime.DateTime = DateTime.Now;
        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            wmsFrame.SetTabChangeEvent(TabChangeEventHandler);
            this.presenter = new SysLogPresenter(this, wmsFrame);
            string restr = "";

            Bitmap bitmap = ImageResource.system_search_3.ToBitmap();
            this.IWmsFrame.AddTitlePage("日志", ref restr);
            this.IWmsFrame.AddGroup("日志", "系统日志", ref restr);
            this.IWmsFrame.AddButtonItem("日志", "系统日志", "系统日志查询", bitmap, ShowTabEventHandler, ref restr);

            this.IWmsFrame.SetTabChangeEvent(TabChangeEventHandler);

            IniSysLog();
           
        }
        private void TabChangeEventHandler(object sender, EventArgs e)
        {
            DevExpress.XtraTabbedMdi.MdiTabPageEventArgs tabEventArgs = e as DevExpress.XtraTabbedMdi.MdiTabPageEventArgs;
            if (tabEventArgs.Page == null)
            {
                return;
            }
          
        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        public void IniSysLog()
        {
            this.cbe_LogCate.Properties.Items.Clear();


            this.cbe_LogCate.Properties.Items.Add("所有");
            for (int i = 0; i < Enum.GetNames(typeof(EnumLoglevel)).Count(); i++)
            {
                string logCate = Enum.GetNames(typeof(EnumLoglevel))[i];
                this.cbe_LogCate.Properties.Items.Add(logCate);
            }
            if (this.cbe_LogCate.Properties.Items.Count > 0)
            {
                this.cbe_LogCate.SelectedIndex = 0;
            }
        }

        public void ShowLog(DataTable logdata)
        {
            this.gc_SysLog.DataSource = logdata;
            this.gv_Syslog.Columns["日志时间"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gv_Syslog.RefreshData();
        }
     

        private void sb_LogQuery_Click(object sender, EventArgs e)
        {
            if((this.de_EndTime.DateTime-this.de_StartTime.DateTime).TotalSeconds<0)
            {
                this.ShowMessage("信息提示", "开始时间大于结束时间！");
                return;
            }
            this.presenter.Query(this.de_StartTime.DateTime, this.de_EndTime.DateTime, this.cbe_LogCate.Text.Trim(), this.ce_LikeQuery.Checked, this.te_LikeContent.Text);
        }
        

        
    }
}
