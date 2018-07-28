namespace WMS_Kernel
{
    partial class SysLogView
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.de_StartTime = new DevExpress.XtraEditors.DateEdit();
            this.de_EndTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sb_LogQuery = new DevExpress.XtraEditors.SimpleButton();
            this.te_LikeContent = new DevExpress.XtraEditors.TextEdit();
            this.ce_LikeQuery = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbe_LogCate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gc_SysLog = new DevExpress.XtraGrid.GridControl();
            this.gv_Syslog = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.de_StartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_EndTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_EndTime.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_LikeContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_LikeQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogCate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SysLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Syslog)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "开始时间：";
            // 
            // de_StartTime
            // 
            this.de_StartTime.EditValue = new System.DateTime(2018, 3, 28, 20, 35, 53, 359);
            this.de_StartTime.Location = new System.Drawing.Point(95, 19);
            this.de_StartTime.Name = "de_StartTime";
            this.de_StartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_StartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_StartTime.Size = new System.Drawing.Size(100, 20);
            this.de_StartTime.TabIndex = 54;
            // 
            // de_EndTime
            // 
            this.de_EndTime.EditValue = new System.DateTime(2018, 3, 28, 20, 35, 53, 359);
            this.de_EndTime.Location = new System.Drawing.Point(279, 19);
            this.de_EndTime.Name = "de_EndTime";
            this.de_EndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_EndTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_EndTime.Size = new System.Drawing.Size(100, 20);
            this.de_EndTime.TabIndex = 55;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(211, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 56;
            this.labelControl2.Text = "结束时间:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1111, 547);
            this.tableLayoutPanel1.TabIndex = 57;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sb_LogQuery);
            this.panelControl1.Controls.Add(this.te_LikeContent);
            this.panelControl1.Controls.Add(this.ce_LikeQuery);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cbe_LogCate);
            this.panelControl1.Controls.Add(this.de_EndTime);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.de_StartTime);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1105, 74);
            this.panelControl1.TabIndex = 0;
            // 
            // sb_LogQuery
            // 
            this.sb_LogQuery.Location = new System.Drawing.Point(886, 18);
            this.sb_LogQuery.Name = "sb_LogQuery";
            this.sb_LogQuery.Size = new System.Drawing.Size(90, 23);
            this.sb_LogQuery.TabIndex = 62;
            this.sb_LogQuery.Text = "查询";
            this.sb_LogQuery.Click += new System.EventHandler(this.sb_LogQuery_Click);
            // 
            // te_LikeContent
            // 
            this.te_LikeContent.Location = new System.Drawing.Point(689, 19);
            this.te_LikeContent.Name = "te_LikeContent";
            this.te_LikeContent.Size = new System.Drawing.Size(181, 20);
            this.te_LikeContent.TabIndex = 60;
            // 
            // ce_LikeQuery
            // 
            this.ce_LikeQuery.Location = new System.Drawing.Point(598, 20);
            this.ce_LikeQuery.Name = "ce_LikeQuery";
            this.ce_LikeQuery.Properties.Caption = "模糊查询";
            this.ce_LikeQuery.Size = new System.Drawing.Size(75, 19);
            this.ce_LikeQuery.TabIndex = 59;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(395, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "类型：";
            // 
            // cbe_LogCate
            // 
            this.cbe_LogCate.Location = new System.Drawing.Point(447, 19);
            this.cbe_LogCate.Name = "cbe_LogCate";
            this.cbe_LogCate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_LogCate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbe_LogCate.Size = new System.Drawing.Size(135, 20);
            this.cbe_LogCate.TabIndex = 57;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gc_SysLog);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 83);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1105, 461);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "日志列表";
            // 
            // gc_SysLog
            // 
            this.gc_SysLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SysLog.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gc_SysLog.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gc_SysLog.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gc_SysLog.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gc_SysLog.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gc_SysLog.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gc_SysLog.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gc_SysLog.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gc_SysLog.EmbeddedNavigator.TextStringFormat = " 第{0}条 总条数{1}条";
            this.gc_SysLog.Location = new System.Drawing.Point(2, 21);
            this.gc_SysLog.MainView = this.gv_Syslog;
            this.gc_SysLog.Margin = new System.Windows.Forms.Padding(0);
            this.gc_SysLog.Name = "gc_SysLog";
            this.gc_SysLog.Size = new System.Drawing.Size(1101, 438);
            this.gc_SysLog.TabIndex = 7;
            this.gc_SysLog.UseEmbeddedNavigator = true;
            this.gc_SysLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Syslog});
            // 
            // gv_Syslog
            // 
            this.gv_Syslog.GridControl = this.gc_SysLog;
            this.gv_Syslog.GroupPanelText = "日志列表";
            this.gv_Syslog.IndicatorWidth = 40;
            this.gv_Syslog.Name = "gv_Syslog";
            this.gv_Syslog.OptionsBehavior.Editable = false;
            this.gv_Syslog.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gv_Syslog.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv_Syslog.OptionsView.ShowGroupPanel = false;
            // 
            // SysLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SysLogView";
            this.Text = "系统日志查询";
            ((System.ComponentModel.ISupportInitialize)(this.de_StartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_EndTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_EndTime.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_LikeContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_LikeQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogCate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SysLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Syslog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit de_StartTime;
        private DevExpress.XtraEditors.DateEdit de_EndTime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_LogCate;
        private DevExpress.XtraEditors.TextEdit te_LikeContent;
        private DevExpress.XtraEditors.CheckEdit ce_LikeQuery;
        private DevExpress.XtraEditors.SimpleButton sb_LogQuery;
        private DevExpress.XtraGrid.GridControl gc_SysLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Syslog;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}