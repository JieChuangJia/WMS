namespace WMS_Service_Main
{
    partial class ServiceManageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManageView));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gc_SvrList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sb_StopSvr = new DevExpress.XtraEditors.SimpleButton();
            this.sb_StartSvr = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SvrList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gc_SvrList);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 69);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(760, 323);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "服务列表";
            // 
            // gc_SvrList
            // 
            this.gc_SvrList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SvrList.Location = new System.Drawing.Point(2, 22);
            this.gc_SvrList.MainView = this.gridView1;
            this.gc_SvrList.Name = "gc_SvrList";
            this.gc_SvrList.Size = new System.Drawing.Size(756, 299);
            this.gc_SvrList.TabIndex = 0;
            this.gc_SvrList.UseEmbeddedNavigator = true;
            this.gc_SvrList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_SvrList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 395);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sb_StopSvr);
            this.panelControl1.Controls.Add(this.sb_StartSvr);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(760, 60);
            this.panelControl1.TabIndex = 2;
            // 
            // sb_StopSvr
            // 
            this.sb_StopSvr.Image = ((System.Drawing.Image)(resources.GetObject("sb_StopSvr.Image")));
            this.sb_StopSvr.Location = new System.Drawing.Point(112, 18);
            this.sb_StopSvr.Name = "sb_StopSvr";
            this.sb_StopSvr.Size = new System.Drawing.Size(94, 30);
            this.sb_StopSvr.TabIndex = 3;
            this.sb_StopSvr.Text = "停止服务";
            this.sb_StopSvr.Click += new System.EventHandler(this.sb_StopSvr_Click);
            // 
            // sb_StartSvr
            // 
            this.sb_StartSvr.Image = ((System.Drawing.Image)(resources.GetObject("sb_StartSvr.Image")));
            this.sb_StartSvr.Location = new System.Drawing.Point(12, 18);
            this.sb_StartSvr.Name = "sb_StartSvr";
            this.sb_StartSvr.Size = new System.Drawing.Size(94, 30);
            this.sb_StartSvr.TabIndex = 2;
            this.sb_StartSvr.Text = "启动服务";
            this.sb_StartSvr.Click += new System.EventHandler(this.sb_StartSvr_Click);
            // 
            // ServiceManageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ServiceManageView";
            this.Text = "服务列表";
            this.Load += new System.EventHandler(this.ServiceManageView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SvrList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gc_SvrList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sb_StopSvr;
        private DevExpress.XtraEditors.SimpleButton sb_StartSvr;



    }
}