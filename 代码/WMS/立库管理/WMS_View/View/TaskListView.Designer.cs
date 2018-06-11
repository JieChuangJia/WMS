namespace WMS_Kernel
{
    partial class TaskListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskListView));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sb_TaskQuery = new DevExpress.XtraEditors.SimpleButton();
            this.cbe_TaskStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbEdit_TaskType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sb_ChooseConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.sb_TaskComplete = new DevExpress.XtraEditors.SimpleButton();
            this.sBtn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_TaskList = new DevExpress.XtraGrid.GridControl();
            this.gv_TaskList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gc_TaskDetail = new DevExpress.XtraGrid.GridControl();
            this.gv_TaskDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_TaskStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEdit_TaskType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TaskDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TaskDetail)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 493);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.sb_TaskQuery);
            this.panelControl1.Controls.Add(this.cbe_TaskStatus);
            this.panelControl1.Controls.Add(this.cbEdit_TaskType);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1175, 54);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(273, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "任务状态";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "任务类型";
            // 
            // sb_TaskQuery
            // 
            this.sb_TaskQuery.Image = ((System.Drawing.Image)(resources.GetObject("sb_TaskQuery.Image")));
            this.sb_TaskQuery.Location = new System.Drawing.Point(492, 16);
            this.sb_TaskQuery.Name = "sb_TaskQuery";
            this.sb_TaskQuery.Size = new System.Drawing.Size(80, 22);
            this.sb_TaskQuery.TabIndex = 15;
            this.sb_TaskQuery.Text = "查询";
            this.sb_TaskQuery.Click += new System.EventHandler(this.sb_TaskQuery_Click);
            // 
            // cbe_TaskStatus
            // 
            this.cbe_TaskStatus.Location = new System.Drawing.Point(341, 17);
            this.cbe_TaskStatus.Name = "cbe_TaskStatus";
            this.cbe_TaskStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_TaskStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbe_TaskStatus.Size = new System.Drawing.Size(125, 20);
            this.cbe_TaskStatus.TabIndex = 12;
            // 
            // cbEdit_TaskType
            // 
            this.cbEdit_TaskType.Location = new System.Drawing.Point(105, 17);
            this.cbEdit_TaskType.Name = "cbEdit_TaskType";
            this.cbEdit_TaskType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEdit_TaskType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbEdit_TaskType.Size = new System.Drawing.Size(125, 20);
            this.cbEdit_TaskType.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sb_ChooseConfirm);
            this.groupControl1.Controls.Add(this.sb_TaskComplete);
            this.groupControl1.Controls.Add(this.sBtn_Cancel);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 435);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1175, 55);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "操作区";
            // 
            // sb_ChooseConfirm
            // 
            this.sb_ChooseConfirm.Location = new System.Drawing.Point(121, 28);
            this.sb_ChooseConfirm.Name = "sb_ChooseConfirm";
            this.sb_ChooseConfirm.Size = new System.Drawing.Size(92, 22);
            this.sb_ChooseConfirm.TabIndex = 8;
            this.sb_ChooseConfirm.Text = "拣选完成确认";
            this.sb_ChooseConfirm.Visible = false;
            // 
            // sb_TaskComplete
            // 
            this.sb_TaskComplete.Image = ((System.Drawing.Image)(resources.GetObject("sb_TaskComplete.Image")));
            this.sb_TaskComplete.Location = new System.Drawing.Point(230, 28);
            this.sb_TaskComplete.Name = "sb_TaskComplete";
            this.sb_TaskComplete.Size = new System.Drawing.Size(78, 22);
            this.sb_TaskComplete.TabIndex = 7;
            this.sb_TaskComplete.Text = "手动完成";
            this.sb_TaskComplete.Visible = false;
            this.sb_TaskComplete.Click += new System.EventHandler(this.sb_TaskComplete_Click);
            // 
            // sBtn_Cancel
            // 
            this.sBtn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("sBtn_Cancel.Image")));
            this.sBtn_Cancel.Location = new System.Drawing.Point(23, 28);
            this.sBtn_Cancel.Name = "sBtn_Cancel";
            this.sBtn_Cancel.Size = new System.Drawing.Size(77, 22);
            this.sBtn_Cancel.TabIndex = 6;
            this.sBtn_Cancel.Text = "取消";
            this.sBtn_Cancel.Click += new System.EventHandler(this.sBtn_Cancel_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_TaskList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 63);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1175, 180);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "任务列表";
            // 
            // gc_TaskList
            // 
            this.gc_TaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TaskList.Location = new System.Drawing.Point(2, 22);
            this.gc_TaskList.MainView = this.gv_TaskList;
            this.gc_TaskList.Margin = new System.Windows.Forms.Padding(0);
            this.gc_TaskList.Name = "gc_TaskList";
            this.gc_TaskList.Size = new System.Drawing.Size(1171, 156);
            this.gc_TaskList.TabIndex = 1;
            this.gc_TaskList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TaskList});
            // 
            // gv_TaskList
            // 
            this.gv_TaskList.GridControl = this.gc_TaskList;
            this.gv_TaskList.GroupPanelText = "任务列表";
            this.gv_TaskList.IndicatorWidth = 40;
            this.gv_TaskList.Name = "gv_TaskList";
            this.gv_TaskList.OptionsSelection.MultiSelect = true;
            this.gv_TaskList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gv_TaskList.OptionsView.ShowGroupPanel = false;
            this.gv_TaskList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_TaskList_FocusedRowChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gc_TaskDetail);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 249);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1175, 180);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "任务详细";
            // 
            // gc_TaskDetail
            // 
            this.gc_TaskDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TaskDetail.Location = new System.Drawing.Point(2, 22);
            this.gc_TaskDetail.MainView = this.gv_TaskDetail;
            this.gc_TaskDetail.Margin = new System.Windows.Forms.Padding(0);
            this.gc_TaskDetail.Name = "gc_TaskDetail";
            this.gc_TaskDetail.Size = new System.Drawing.Size(1171, 156);
            this.gc_TaskDetail.TabIndex = 2;
            this.gc_TaskDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TaskDetail});
            // 
            // gv_TaskDetail
            // 
            this.gv_TaskDetail.GridControl = this.gc_TaskDetail;
            this.gv_TaskDetail.GroupPanelText = "任务详细";
            this.gv_TaskDetail.IndicatorWidth = 40;
            this.gv_TaskDetail.Name = "gv_TaskDetail";
            this.gv_TaskDetail.OptionsSelection.MultiSelect = true;
            this.gv_TaskDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gv_TaskDetail.OptionsView.ShowGroupPanel = false;
            // 
            // TaskListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TaskListView";
            this.Text = "任务列表";
            this.Load += new System.EventHandler(this.TaskListView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_TaskStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEdit_TaskType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TaskDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TaskDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbEdit_TaskType;
        private DevExpress.XtraGrid.GridControl gc_TaskList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TaskList;
        private DevExpress.XtraGrid.GridControl gc_TaskDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TaskDetail;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_TaskStatus;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sb_TaskQuery;
        private DevExpress.XtraEditors.SimpleButton sBtn_Cancel;
        private DevExpress.XtraEditors.SimpleButton sb_TaskComplete;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sb_ChooseConfirm;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}