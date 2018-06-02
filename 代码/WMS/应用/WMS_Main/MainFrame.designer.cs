namespace Aoyou_WMS
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon_Title = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnItem_PlanQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_WareQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_PalletMana = new DevExpress.XtraBars.BarButtonItem();
            this.batBtnItem_Stop = new DevExpress.XtraBars.BarButtonItem();
            this.batBtnItem_Modify = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_RoleMana = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_UserMana = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_LimitMana = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_WareLimitMana = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_MaterialMana = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_PlanAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_PrepareWork = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_TaskList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_InWareWithoutPlan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_MaterialUnload = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_OutWareWithoutPlan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_InWareWithPlan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_MaterialLoad = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItem_OutWareWithPlan = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 564);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon_Title;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1072, 25);
            // 
            // ribbon_Title
            // 
            this.ribbon_Title.AllowMdiChildButtons = false;
            this.ribbon_Title.AllowMinimizeRibbon = false;
            this.ribbon_Title.ApplicationCaption = "WMS库存管理系统";
            this.ribbon_Title.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon_Title.ApplicationIcon")));
            this.ribbon_Title.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon_Title.ExpandCollapseItem.Id = 0;
            this.ribbon_Title.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon_Title.ExpandCollapseItem,
            this.barBtnItem_PlanQuery,
            this.barBtnItem_WareQuery,
            this.barBtnItem_PalletMana,
            this.batBtnItem_Stop,
            this.batBtnItem_Modify,
            this.barBtnItem_RoleMana,
            this.barBtnItem_UserMana,
            this.barBtnItem_LimitMana,
            this.barBtnItem_WareLimitMana,
            this.barBtnItem_MaterialMana,
            this.barBtnItem_PlanAdd,
            this.barBtnItem_PrepareWork,
            this.barBtnItem_TaskList,
            this.barBtnItem_InWareWithoutPlan,
            this.barBtnItem_MaterialUnload,
            this.barBtnItem_OutWareWithoutPlan,
            this.barBtnItem_InWareWithPlan,
            this.barBtnItem_MaterialLoad,
            this.barBtnItem_OutWareWithPlan,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barStaticItem4});
            this.ribbon_Title.Location = new System.Drawing.Point(0, 0);
            this.ribbon_Title.MaxItemId = 27;
            this.ribbon_Title.Name = "ribbon_Title";
            this.ribbon_Title.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.ribbon_Title.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon_Title.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon_Title.ShowToolbarCustomizeItem = false;
            this.ribbon_Title.Size = new System.Drawing.Size(1072, 57);
            this.ribbon_Title.StatusBar = this.ribbonStatusBar;
            this.ribbon_Title.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnItem_PlanQuery
            // 
            this.barBtnItem_PlanQuery.Caption = "计划查询";
            this.barBtnItem_PlanQuery.Id = 1;
            this.barBtnItem_PlanQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_PlanQuery.ImageOptions.Image")));
            this.barBtnItem_PlanQuery.Name = "barBtnItem_PlanQuery";
            this.barBtnItem_PlanQuery.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_WareQuery
            // 
            this.barBtnItem_WareQuery.Caption = "库存查询";
            this.barBtnItem_WareQuery.Id = 2;
            this.barBtnItem_WareQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_WareQuery.ImageOptions.Image")));
            this.barBtnItem_WareQuery.Name = "barBtnItem_WareQuery";
            this.barBtnItem_WareQuery.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_PalletMana
            // 
            this.barBtnItem_PalletMana.Caption = "配盘管理";
            this.barBtnItem_PalletMana.Id = 3;
            this.barBtnItem_PalletMana.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_PalletMana.ImageOptions.Image")));
            this.barBtnItem_PalletMana.Name = "barBtnItem_PalletMana";
            this.barBtnItem_PalletMana.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // batBtnItem_Stop
            // 
            this.batBtnItem_Stop.Caption = "系统设置";
            this.batBtnItem_Stop.Id = 5;
            this.batBtnItem_Stop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("batBtnItem_Stop.ImageOptions.Image")));
            this.batBtnItem_Stop.Name = "batBtnItem_Stop";
            this.batBtnItem_Stop.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.batBtnItem_Stop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.batBtnItem_Stop_ItemClick);
            // 
            // batBtnItem_Modify
            // 
            this.batBtnItem_Modify.Caption = "密码修改";
            this.batBtnItem_Modify.Id = 6;
            this.batBtnItem_Modify.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("batBtnItem_Modify.ImageOptions.Image")));
            this.batBtnItem_Modify.Name = "batBtnItem_Modify";
            this.batBtnItem_Modify.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.batBtnItem_Modify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.batBtnItem_Modify_ItemClick);
            // 
            // barBtnItem_RoleMana
            // 
            this.barBtnItem_RoleMana.Caption = "角色维护";
            this.barBtnItem_RoleMana.Id = 7;
            this.barBtnItem_RoleMana.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_RoleMana.ImageOptions.Image")));
            this.barBtnItem_RoleMana.Name = "barBtnItem_RoleMana";
            this.barBtnItem_RoleMana.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnItem_RoleMana.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItem_RoleMana_ItemClick);
            // 
            // barBtnItem_UserMana
            // 
            this.barBtnItem_UserMana.Caption = "用户维护";
            this.barBtnItem_UserMana.Id = 8;
            this.barBtnItem_UserMana.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_UserMana.ImageOptions.Image")));
            this.barBtnItem_UserMana.Name = "barBtnItem_UserMana";
            this.barBtnItem_UserMana.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_LimitMana
            // 
            this.barBtnItem_LimitMana.Caption = "权限维护";
            this.barBtnItem_LimitMana.Id = 9;
            this.barBtnItem_LimitMana.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_LimitMana.ImageOptions.Image")));
            this.barBtnItem_LimitMana.Name = "barBtnItem_LimitMana";
            this.barBtnItem_LimitMana.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_WareLimitMana
            // 
            this.barBtnItem_WareLimitMana.Caption = "仓库权限维护";
            this.barBtnItem_WareLimitMana.Id = 10;
            this.barBtnItem_WareLimitMana.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_WareLimitMana.ImageOptions.Image")));
            this.barBtnItem_WareLimitMana.Name = "barBtnItem_WareLimitMana";
            this.barBtnItem_WareLimitMana.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_MaterialMana
            // 
            this.barBtnItem_MaterialMana.Caption = "物料维护";
            this.barBtnItem_MaterialMana.Id = 11;
            this.barBtnItem_MaterialMana.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_MaterialMana.ImageOptions.Image")));
            this.barBtnItem_MaterialMana.Name = "barBtnItem_MaterialMana";
            this.barBtnItem_MaterialMana.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_PlanAdd
            // 
            this.barBtnItem_PlanAdd.Caption = "计划录入";
            this.barBtnItem_PlanAdd.Id = 12;
            this.barBtnItem_PlanAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_PlanAdd.ImageOptions.Image")));
            this.barBtnItem_PlanAdd.Name = "barBtnItem_PlanAdd";
            this.barBtnItem_PlanAdd.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_PrepareWork
            // 
            this.barBtnItem_PrepareWork.Caption = "待办工作";
            this.barBtnItem_PrepareWork.Id = 13;
            this.barBtnItem_PrepareWork.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_PrepareWork.ImageOptions.Image")));
            this.barBtnItem_PrepareWork.Name = "barBtnItem_PrepareWork";
            this.barBtnItem_PrepareWork.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_TaskList
            // 
            this.barBtnItem_TaskList.Caption = "任务列表";
            this.barBtnItem_TaskList.Id = 14;
            this.barBtnItem_TaskList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_TaskList.ImageOptions.Image")));
            this.barBtnItem_TaskList.Name = "barBtnItem_TaskList";
            this.barBtnItem_TaskList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_InWareWithoutPlan
            // 
            this.barBtnItem_InWareWithoutPlan.Caption = "无计划配盘入库";
            this.barBtnItem_InWareWithoutPlan.Id = 15;
            this.barBtnItem_InWareWithoutPlan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_InWareWithoutPlan.ImageOptions.Image")));
            this.barBtnItem_InWareWithoutPlan.Name = "barBtnItem_InWareWithoutPlan";
            this.barBtnItem_InWareWithoutPlan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_MaterialUnload
            // 
            this.barBtnItem_MaterialUnload.Caption = "上架管理";
            this.barBtnItem_MaterialUnload.Id = 16;
            this.barBtnItem_MaterialUnload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_MaterialUnload.ImageOptions.Image")));
            this.barBtnItem_MaterialUnload.Name = "barBtnItem_MaterialUnload";
            this.barBtnItem_MaterialUnload.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_OutWareWithoutPlan
            // 
            this.barBtnItem_OutWareWithoutPlan.Caption = "无计划出库";
            this.barBtnItem_OutWareWithoutPlan.Id = 17;
            this.barBtnItem_OutWareWithoutPlan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_OutWareWithoutPlan.ImageOptions.Image")));
            this.barBtnItem_OutWareWithoutPlan.Name = "barBtnItem_OutWareWithoutPlan";
            this.barBtnItem_OutWareWithoutPlan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_InWareWithPlan
            // 
            this.barBtnItem_InWareWithPlan.Caption = "按计划配盘入库";
            this.barBtnItem_InWareWithPlan.Id = 18;
            this.barBtnItem_InWareWithPlan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_InWareWithPlan.ImageOptions.Image")));
            this.barBtnItem_InWareWithPlan.Name = "barBtnItem_InWareWithPlan";
            this.barBtnItem_InWareWithPlan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_MaterialLoad
            // 
            this.barBtnItem_MaterialLoad.Caption = "按计划下架";
            this.barBtnItem_MaterialLoad.Id = 19;
            this.barBtnItem_MaterialLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_MaterialLoad.ImageOptions.Image")));
            this.barBtnItem_MaterialLoad.Name = "barBtnItem_MaterialLoad";
            this.barBtnItem_MaterialLoad.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barBtnItem_OutWareWithPlan
            // 
            this.barBtnItem_OutWareWithPlan.Caption = "按计划出库";
            this.barBtnItem_OutWareWithPlan.Id = 20;
            this.barBtnItem_OutWareWithPlan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItem_OutWareWithPlan.ImageOptions.Image")));
            this.barBtnItem_OutWareWithPlan.Name = "barBtnItem_OutWareWithPlan";
            this.barBtnItem_OutWareWithPlan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "用户名:";
            this.barStaticItem1.Id = 21;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem2.Caption = "admin";
            this.barStaticItem2.Id = 22;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem3.Caption = "角色:";
            this.barStaticItem3.Id = 23;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem4.Caption = "系统管理员";
            this.barStaticItem4.Id = 24;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.OnMouseDown;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Stardust";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel1.ID = new System.Guid("8a9febef-4918-483c-8b2e-fee918ef2453");
            this.dockPanel1.Location = new System.Drawing.Point(0, 449);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 115);
            this.dockPanel1.Size = new System.Drawing.Size(1072, 115);
            this.dockPanel1.Text = "日志";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.richTextBoxLog);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 27);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1066, 85);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(1066, 85);
            this.richTextBoxLog.TabIndex = 6;
            this.richTextBoxLog.Text = "";
            // 
            // MainFrame
            // 
            this.ActiveGlowColor = System.Drawing.Color.WhiteSmoke;
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 589);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.WhiteSmoke;
            this.IsMdiContainer = true;
            this.Name = "MainFrame";
            this.Ribbon = this.ribbon_Title;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "WMS库存管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon_Title;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_PlanQuery;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_WareQuery;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_PalletMana;
        private DevExpress.XtraBars.BarButtonItem batBtnItem_Stop;
        private DevExpress.XtraBars.BarButtonItem batBtnItem_Modify;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_RoleMana;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_UserMana;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_LimitMana;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_WareLimitMana;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_MaterialMana;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_PlanAdd;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_PrepareWork;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_TaskList;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_InWareWithoutPlan;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_MaterialUnload;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_OutWareWithoutPlan;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_InWareWithPlan;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_MaterialLoad;
        private DevExpress.XtraBars.BarButtonItem barBtnItem_OutWareWithPlan;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
    }
}