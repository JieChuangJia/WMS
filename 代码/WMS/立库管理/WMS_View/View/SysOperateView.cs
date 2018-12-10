using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public partial class SysOperateView : ChildViewBase, ISysOperateView
    {
        SysOperatePresenter presenter = null;
        public SysOperateView()
        {
            InitializeComponent();

            this.de_StartTime.DateTime = DateTime.Now.AddDays(-1);
            this.de_EndTime.DateTime = DateTime.Now;
        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            wmsFrame.SetTabChangeEvent(TabChangeEventHandler);
            this.presenter = new SysOperatePresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.SysOperate.ToBitmap();
            this.IWmsFrame.AddTitlePage("日志", ref restr);
            this.IWmsFrame.AddGroup("日志", "系统日志", ref restr);
            this.IWmsFrame.AddButtonItem("日志", "系统日志", "系统操作查询", bitmap, ShowTabEventHandler, ref restr);

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
            for (int i = 0; i < Enum.GetNames(typeof(EnumGSOperateType)).Count(); i++)
            {
                string logCate = Enum.GetNames(typeof(EnumGSOperateType))[i];
                this.cbe_LogCate.Properties.Items.Add(logCate);
            }
            if (this.cbe_LogCate.Properties.Items.Count > 0)
            {
                this.cbe_LogCate.SelectedIndex = 0;
            }
        }

        public void ShowOperate(DataTable logdata)
        {
            this.gc_SysLog.DataSource = logdata;
            this.gv_Syslog.Columns["操作时间"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gv_Syslog.RefreshData();
        }

        public void IniHouseName(List<WH_WareHouseModel> houseList)
        {
            this.cbe_HouseName.Properties.Items.Clear();

            if (houseList == null)
            {
                return;
            }
            this.cbe_HouseName.Properties.Items.Add("所有");
            foreach (WH_WareHouseModel house in houseList)
            {
                this.cbe_HouseName.Properties.Items.Add(house.WareHouse_Name);
            }
            if (this.cbe_HouseName.Properties.Items.Count > 0)
            {
                this.cbe_HouseName.SelectedIndex = 0;
            }
        }
        private void sb_LogQuery_Click(object sender, EventArgs e)
        {
            if((this.de_EndTime.DateTime-this.de_StartTime.DateTime).TotalSeconds<0)
            {
                this.ShowMessage("信息提示", "开始时间大于结束时间！");
                return;
            }
            this.presenter.Query(this.de_StartTime.DateTime, this.de_EndTime.DateTime, this.cbe_LogCate.Text.Trim()
                ,this.ce_LikeQuery.Checked, this.te_LikeContent.Text,this.cbe_HouseName.Text,this.ce_gsQuery.Checked,this.te_GsName.Text);
        }
        

        
    }
}
