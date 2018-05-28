﻿namespace WMS_Kernel
{
    partial class TodoListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoListView));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gc_PlanGoodsList = new DevExpress.XtraGrid.GridControl();
            this.gv_PlanGoodsList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_PlanList = new DevExpress.XtraGrid.GridControl();
            this.gv_PlanList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sb_TrayQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lc = new DevExpress.XtraEditors.LabelControl();
            this.te_PlanID = new DevExpress.XtraEditors.TextEdit();
            this.ce_PlanType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEdit_EndTime = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_StartTime = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.sb_DeleteTask = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.sb_ExePlan = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PlanGoodsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PlanGoodsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PlanList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PlanList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_PlanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_PlanType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_EndTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_EndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_StartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(118, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(0, 22);
            this.simpleButton2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gc_PlanGoodsList, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gc_PlanList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gc_PlanGoodsList
            // 
            this.gc_PlanGoodsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_PlanGoodsList.Location = new System.Drawing.Point(3, 242);
            this.gc_PlanGoodsList.MainView = this.gv_PlanGoodsList;
            this.gc_PlanGoodsList.Name = "gc_PlanGoodsList";
            this.gc_PlanGoodsList.Size = new System.Drawing.Size(1167, 173);
            this.gc_PlanGoodsList.TabIndex = 7;
            this.gc_PlanGoodsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PlanGoodsList});
            // 
            // gv_PlanGoodsList
            // 
            this.gv_PlanGoodsList.GridControl = this.gc_PlanGoodsList;
            this.gv_PlanGoodsList.GroupPanelText = "单据明细";
            this.gv_PlanGoodsList.IndicatorWidth = 40;
            this.gv_PlanGoodsList.Name = "gv_PlanGoodsList";
            // 
            // gc_PlanList
            // 
            this.gc_PlanList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_PlanList.Location = new System.Drawing.Point(3, 63);
            this.gc_PlanList.MainView = this.gv_PlanList;
            this.gc_PlanList.Name = "gc_PlanList";
            this.gc_PlanList.Size = new System.Drawing.Size(1167, 173);
            this.gc_PlanList.TabIndex = 2;
            this.gc_PlanList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PlanList});
            // 
            // gv_PlanList
            // 
            this.gv_PlanList.GridControl = this.gc_PlanList;
            this.gv_PlanList.GroupPanelText = "单据列表";
            this.gv_PlanList.IndicatorWidth = 40;
            this.gv_PlanList.Name = "gv_PlanList";
            this.gv_PlanList.OptionsView.ColumnAutoWidth = false;
            this.gv_PlanList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_PlanList_FocusedRowChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sb_TrayQuery);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lc);
            this.panelControl1.Controls.Add(this.te_PlanID);
            this.panelControl1.Controls.Add(this.ce_PlanType);
            this.panelControl1.Controls.Add(this.dateEdit_EndTime);
            this.panelControl1.Controls.Add(this.dateEdit_StartTime);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1167, 54);
            this.panelControl1.TabIndex = 0;
            // 
            // sb_TrayQuery
            // 
            this.sb_TrayQuery.Image = ((System.Drawing.Image)(resources.GetObject("sb_TrayQuery.Image")));
            this.sb_TrayQuery.Location = new System.Drawing.Point(760, 22);
            this.sb_TrayQuery.Name = "sb_TrayQuery";
            this.sb_TrayQuery.Size = new System.Drawing.Size(75, 23);
            this.sb_TrayQuery.TabIndex = 14;
            this.sb_TrayQuery.Text = "查询";
            this.sb_TrayQuery.Click += new System.EventHandler(this.sb_TrayQuery_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(556, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "计划单号";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(341, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "计划类型";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(169, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "结束时间";
            // 
            // lc
            // 
            this.lc.Location = new System.Drawing.Point(5, 26);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(48, 14);
            this.lc.TabIndex = 10;
            this.lc.Text = "开始时间";
            // 
            // te_PlanID
            // 
            this.te_PlanID.Location = new System.Drawing.Point(613, 23);
            this.te_PlanID.Name = "te_PlanID";
            this.te_PlanID.Size = new System.Drawing.Size(125, 20);
            this.te_PlanID.TabIndex = 9;
            // 
            // ce_PlanType
            // 
            this.ce_PlanType.Location = new System.Drawing.Point(398, 23);
            this.ce_PlanType.Name = "ce_PlanType";
            this.ce_PlanType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ce_PlanType.Size = new System.Drawing.Size(125, 20);
            this.ce_PlanType.TabIndex = 8;
            // 
            // dateEdit_EndTime
            // 
            this.dateEdit_EndTime.EditValue = new System.DateTime(2018, 4, 5, 13, 6, 25, 693);
            this.dateEdit_EndTime.Location = new System.Drawing.Point(226, 23);
            this.dateEdit_EndTime.Name = "dateEdit_EndTime";
            this.dateEdit_EndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_EndTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_EndTime.Size = new System.Drawing.Size(106, 20);
            this.dateEdit_EndTime.TabIndex = 7;
            // 
            // dateEdit_StartTime
            // 
            this.dateEdit_StartTime.EditValue = new System.DateTime(2018, 4, 5, 13, 6, 25, 693);
            this.dateEdit_StartTime.Location = new System.Drawing.Point(62, 23);
            this.dateEdit_StartTime.Name = "dateEdit_StartTime";
            this.dateEdit_StartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_StartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_StartTime.Size = new System.Drawing.Size(98, 20);
            this.dateEdit_StartTime.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton6);
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Controls.Add(this.sb_DeleteTask);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.sb_ExePlan);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 421);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1167, 65);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "操作区";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Enabled = false;
            this.simpleButton6.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(337, 31);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(68, 23);
            this.simpleButton6.TabIndex = 19;
            this.simpleButton6.Text = "完成";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Enabled = false;
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(255, 31);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(68, 23);
            this.simpleButton5.TabIndex = 18;
            this.simpleButton5.Text = " 编辑";
            // 
            // sb_DeleteTask
            // 
            this.sb_DeleteTask.Image = ((System.Drawing.Image)(resources.GetObject("sb_DeleteTask.Image")));
            this.sb_DeleteTask.Location = new System.Drawing.Point(173, 31);
            this.sb_DeleteTask.Name = "sb_DeleteTask";
            this.sb_DeleteTask.Size = new System.Drawing.Size(68, 23);
            this.sb_DeleteTask.TabIndex = 17;
            this.sb_DeleteTask.Text = "删除";
            this.sb_DeleteTask.Click += new System.EventHandler(this.sb_DeleteTask_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Enabled = false;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(91, 31);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(68, 23);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "停止";
            // 
            // sb_ExePlan
            // 
            this.sb_ExePlan.Image = ((System.Drawing.Image)(resources.GetObject("sb_ExePlan.Image")));
            this.sb_ExePlan.Location = new System.Drawing.Point(9, 31);
            this.sb_ExePlan.Name = "sb_ExePlan";
            this.sb_ExePlan.Size = new System.Drawing.Size(68, 23);
            this.sb_ExePlan.TabIndex = 15;
            this.sb_ExePlan.Text = "执行";
            this.sb_ExePlan.Click += new System.EventHandler(this.sb_ExePlan_Click);
            // 
            // TodoListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TodoListView";
            this.Text = "待办工作";
            this.Load += new System.EventHandler(this.PlanQueryView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_PlanGoodsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PlanGoodsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PlanList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PlanList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_PlanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_PlanType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_EndTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_EndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_StartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_PlanList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PlanList;
        private DevExpress.XtraGrid.GridControl gc_PlanGoodsList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PlanGoodsList;
        private DevExpress.XtraEditors.DateEdit dateEdit_StartTime;
        private DevExpress.XtraEditors.DateEdit dateEdit_EndTime;
        private DevExpress.XtraEditors.ComboBoxEdit ce_PlanType;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lc;
        private DevExpress.XtraEditors.TextEdit te_PlanID;
        private DevExpress.XtraEditors.SimpleButton sb_TrayQuery;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton sb_DeleteTask;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton sb_ExePlan;
    }
}