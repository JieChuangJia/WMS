using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using WMS_Interface;
 
using System.Configuration;
using CommonMoudle;
using WMS_Database;
 

namespace WMS_Service_Main
{
    public partial class MainFrame : ChildViewBase, IWMSFrame
    {
        private delegate void DelegateDispLog(string logSrc, string category,string level, string content);//委托，显示日志
        ServiceManageView serviceManageVieww = new ServiceManageView();
        MainPresenter mainPresenter = new MainPresenter();
        public MainFrame()
        {
            InitializeComponent();
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            MainFrameHandler.SetMainFrame(this);
            //this.splitContainerControl1.SplitterPosition = (int)(this.splitContainerControl1.Height * 0.8);
            DatabaseCfg();
            Console.SetOut(new TextBoxWriter(this.richTextBoxLog));
            InitTabbedMDI();
            this.LoadChildForms();
            LoadForms();
            //this.mainPresenter.Init(this, FormCloseEventHandler);

            //string licenseFile = AppDomain.CurrentDomain.BaseDirectory + @"NBSSLicense.lic";
            //this.licenseMonitor = new LicenseMonitor(this, 60000, licenseFile, "zzkeyFT1");
            //if (!this.licenseMonitor.StartMonitor())
            //{
            //    throw new Exception("license 监控失败");
            //}
            //string reStr = "";
            //if (!this.licenseMonitor.IslicenseValid(ref reStr))
            //{
            //    MessageBox.Show(reStr);
            //    return;
            //}
        }
        #region 实现IWMS
        public int RoleLevel { get; set; }
        public void SetTabChangeEvent(EventHandler tabChangeEventHandler)
        {
            this.xtraTabbedMdiManager1.SelectedPageChanged += tabChangeEventHandler;
        }

        public void SetVersion(string version)
        { 
        
        }
        public void WriteLog(string logSrc, string category, string level, string content)
        {
            if (this.richTextBoxLog.InvokeRequired)
            {
                DelegateDispLog delegateLog = new DelegateDispLog(WriteLog);
                this.Invoke(delegateLog, new object[4] { logSrc,category, level, content });
            }
            else
            {

                richTextBoxLog.AppendText(string.Format("[{0:yyyy-MM-dd HH:mm:ss.fff}]{1},{2},{3}", DateTime.Now.ToString(), logSrc,category, content) + Environment.NewLine);
                if (richTextBoxLog.Text.Length > 6000)
                {
                    string[] newlines = new string[600];
                    Array.Copy(richTextBoxLog.Lines, richTextBoxLog.Lines.Length - 600, newlines, 0, 600);
                    richTextBoxLog.Lines = newlines;
                    richTextBoxLog.Select(richTextBoxLog.Text.Length, 0);
                    richTextBoxLog.ScrollToCaret();
                }
                SysLogModel logModel = new SysLogModel();
                logModel.SysLog_ID = Guid.NewGuid().ToString();
                logModel.SysLog_Level = level;
                logModel.SysLog_Content = content;
                logModel.SysLog_Source = logSrc;
                logModel.SysLog_Time = DateTime.Now;
                this.mainPresenter.AddDBLog(logModel);

            }
        }

        public void ShowView(Form tabForm, bool isTab)
        {
            if (isTab == true)
            {
                tabForm.MdiParent = this;

                tabForm.Show();
            }
            else
            {
                tabForm.ShowDialog();
            }

            this.xtraTabbedMdiManager1.SelectedPage = this.xtraTabbedMdiManager1.Pages[tabForm];
     
        }
        public bool AddTitlePage(string pageName,ref string restr)
        {
          
            if (this.ribbon_Title.Pages.GetPageByName(pageName) != null)
            {
                restr = "存在同名标题页！";
                return false;
            }
            DevExpress.XtraBars.Ribbon.RibbonPage addPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            addPage.Name = pageName;
            addPage.Text = pageName;
            this.ribbon_Title.Pages.Add(addPage);
            restr = "标题页添加成功！";
            return true;
        }
        public bool AddGroup(string pageName, string groupName, ref string restr)
        {
            DevExpress.XtraBars.Ribbon.RibbonPage page = this.ribbon_Title.Pages.GetPageByName(pageName);
            if (page == null)
            {
                restr = "不存在[" + page + "]标题页！";
                return false;
            }

            if (page.Groups.GetGroupByName(groupName) != null)
            {
                restr = "存在同名组！";
                return false;
            }
            DevExpress.XtraBars.Ribbon.RibbonPageGroup group = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            group.Name = groupName;
            group.Text = groupName;
           
            page.Groups.Add(group);
            restr = "添加组成功！";
            return true;
        }

        public bool AddButtonItem(string pageName, string groupName, string itemName, Image itemImage, ItemClickEventHandler callBack, ref string restr)
        {
            DevExpress.XtraBars.Ribbon.RibbonPage page = this.ribbon_Title.Pages.GetPageByName(pageName);
            if (page == null)
            {
                restr = "不存在[" + page + "]标题页！";
                return false;
            }
            DevExpress.XtraBars.Ribbon.RibbonPageGroup group = page.Groups.GetGroupByName(groupName);
            if (group == null)
            {
                restr = "不存在[" + groupName + "]组！";
                return false;
            }
            DevExpress.XtraBars.BarButtonItem buttonItem = new BarButtonItem();

            buttonItem.Name = itemName;
            buttonItem.Caption = itemName;
            buttonItem.ImageOptions.LargeImage = itemImage;
            buttonItem.ItemClick += callBack;
            group.ItemLinks.Add(buttonItem);
            restr = "添加菜单项成功！";
            return true;
        }

        public  string CurrentUser { get; set; }
        public int RoleID { get; set; }
        #endregion
        #region 私有方法
      
        private void LoadForms()
        {
            serviceManageVieww.Init(this);
            serviceManageVieww.FormClosing += FormCloseEventHandler;
        }
        private void DatabaseCfg()
        {
            string dbSrc = ConfigurationManager.AppSettings["WMS_Database_Path"];
            //string dbAoyou = ConfigurationManager.AppSettings["WMS_AoyouDatabase_Path"];
            //CtlDBAccess.DBUtility.PubConstant.ConnectionString = string.Format(@"{0}Initial Catalog=ACEcams;User ID=sa;Password=123456;", dbSrc);
            string dbConn1 = string.Format(@"{0}Initial Catalog=JBSWmsDB;User ID=sa;Password=Aa123456;", dbSrc);
            //string dbAoyouConn = string.Format(@"{0}Initial Catalog=Aoyou_BusinessDB;User ID=sa;Password=Aa123456;", dbAoyou);
             WMS_Database.PubConstant.SetConnectStr(dbConn1);
             //Aoyou_BusinessDB.PubConstant.ConnectionString = dbAoyouConn;
        }
        private void InitTabbedMDI()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //Dark Side,Visual Studio 2013 Blue,Office 2007 Black,Office 2010 Silver,Office 2007 Blue,DevExpress Dark Style,DevExpress Style,Office 2016 Black
            this.defaultLookAndFeel1.LookAndFeel.SetSkinStyle("Stardust");
            this.xtraTabbedMdiManager1.MdiParent = this;

        }

        private void FormCloseEventHandler(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Form f = (Form)sender;
                f.Visible = false;
            }

        }
        private void LoadApp()
        {
            //AYUI.BatteryView battery = new AYUI.BatteryView(this);
            //battery.FormClosing += OnFormCloseEventHandler;

            //AYUI.PalletView pallet = new AYUI.PalletView(this);
            //pallet.FormClosing += OnFormCloseEventHandler;

        }


        #endregion

      
        /// <summary>
        /// 初始化所有窗体,后期可改为数据库配置
        /// </summary>
        public  void LoadChildForms( )
        {
            //wmsViewManager.InitView(this);
            //ModPasswordView modPV = new ModPasswordView();
            //modPV.FormClosing += FormCloseEventHandler;
            //modPV.Init(this);
            //RoleManaView roleView = new RoleManaView();
            //roleView.FormClosing += FormCloseEventHandler;
            //roleView.Init(this);
            //UserManaView userView = new UserManaView();
            //userView.FormClosing += FormCloseEventHandler;
            //userView.Init(this);
            //LimitManaView limitView = new LimitManaView();
            //limitView.FormClosing += FormCloseEventHandler;
            //limitView.Init(this);
            //WareLimitManaView wareLimitView = new WareLimitManaView();
            //wareLimitView.FormClosing += FormCloseEventHandler;
            //wareLimitView.Init(this);
            //MaterialManaView materialView = new MaterialManaView();
            //materialView.FormClosing += FormCloseEventHandler;
            //materialView.Init(this);
            //TaskListView taskView = new TaskListView();
            //taskView.FormClosing += FormCloseEventHandler;
            //taskView.Init(this);
            //PlanManaView planManaView = new PlanManaView();
            //planManaView.FormClosing += FormCloseEventHandler;
            //planManaView.Init(this);
            //PrepareWorkManaView prepareView = new PrepareWorkManaView();
            //prepareView.FormClosing += FormCloseEventHandler;
            //prepareView.Init(this);
            //InWareWithoutPlanView inWareWithoutPlanView = new InWareWithoutPlanView();
            //inWareWithoutPlanView.FormClosing += FormCloseEventHandler;
            //inWareWithoutPlanView.Init(this);
            //MaterialUnloadView materialUnloadView = new MaterialUnloadView();
            //materialUnloadView.FormClosing += FormCloseEventHandler;
            //materialUnloadView.Init(this);
            //OutWareWithoutPlanView outWareWithoutPlanView = new OutWareWithoutPlanView();
            //outWareWithoutPlanView.FormClosing += FormCloseEventHandler;
            //outWareWithoutPlanView.Init(this);
            //InWareWithPlanView inWareWithPlanView = new InWareWithPlanView();
            //inWareWithPlanView.FormClosing += FormCloseEventHandler;
            //inWareWithPlanView.Init(this);
            //MaterialLoadWithPlanView materialLoadWithPlanView = new MaterialLoadWithPlanView();
            //materialLoadWithPlanView.FormClosing += FormCloseEventHandler;
            //materialLoadWithPlanView.Init(this);
            //OutWareWithPlanView outWarePlanView = new OutWareWithPlanView();
            //outWarePlanView.FormClosing += FormCloseEventHandler;
            //outWarePlanView.Init(this);
            //PalletManaView pallerManaView = new PalletManaView();
            //pallerManaView.FormClosing += FormCloseEventHandler;
            //pallerManaView.Init(this);
            //StationShowView stationView = new StationShowView();
            //stationView.FormClosing += FormCloseEventHandler;
            //stationView.Init(this);
            //PlanQueryView planQueryView = new PlanQueryView();
            //planQueryView.FormClosing += FormCloseEventHandler;
            //planQueryView.Init(this);
            //WareQueryView wareQueryView = new WareQueryView();
            //wareQueryView.FormClosing += FormCloseEventHandler;
            //wareQueryView.Init(this);
             
        }
       
       
        private void barBtnItem_RoleMana_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (roleView == null)
            //{
            //    roleView = new RoleManaView();
            //}
             
            //this.ShowTab(roleView);
        }
       
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show("您确定要退出系统么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //System.Environment.Exit(0);
                this.xtraTabbedMdiManager1.Pages.Clear();
                //Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

  
        private void batBtnItem_Stop_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string restr = "";
            //AddTitlePage("系统",ref restr);
            //AddGroup("系统", "系统配置", ref restr);
            //AddButtonItem("系统", "系统配置", "修改密码", this.imageCollection1.Images[0], null, ref restr);
        }

        private void batBtnItem_Modify_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}