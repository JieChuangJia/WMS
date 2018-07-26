namespace WMS_Kernel
{
    partial class WHStationView
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WHStationView));
            this.gc_StationList = new DevExpress.XtraGrid.GridControl();
            this.gv_StationList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sb_ModifyStation = new DevExpress.XtraEditors.SimpleButton();
            this.sb_DeleteStation = new DevExpress.XtraEditors.SimpleButton();
            this.sb_AddStation = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbe_HouseList = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sb_query = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StationList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_HouseList.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_StationList
            // 
            this.gc_StationList.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gc_StationList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_StationList.Location = new System.Drawing.Point(2, 21);
            this.gc_StationList.MainView = this.gv_StationList;
            this.gc_StationList.Margin = new System.Windows.Forms.Padding(0);
            this.gc_StationList.Name = "gc_StationList";
            this.gc_StationList.Size = new System.Drawing.Size(775, 317);
            this.gc_StationList.TabIndex = 6;
            this.gc_StationList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_StationList});
            // 
            // gv_StationList
            // 
            this.gv_StationList.GridControl = this.gc_StationList;
            this.gv_StationList.IndicatorWidth = 40;
            this.gv_StationList.Name = "gv_StationList";
            this.gv_StationList.OptionsBehavior.Editable = false;
            this.gv_StationList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gv_StationList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv_StationList.OptionsView.ColumnAutoWidth = false;
            this.gv_StationList.OptionsView.ShowGroupPanel = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 462);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_StationList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 63);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(779, 340);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "库房工位详细";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sb_query);
            this.panelControl1.Controls.Add(this.cbe_HouseList);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(779, 54);
            this.panelControl1.TabIndex = 10;
            // 
            // sb_ModifyStation
            // 
            this.sb_ModifyStation.Image = ((System.Drawing.Image)(resources.GetObject("sb_ModifyStation.Image")));
            this.sb_ModifyStation.Location = new System.Drawing.Point(212, 18);
            this.sb_ModifyStation.Name = "sb_ModifyStation";
            this.sb_ModifyStation.Size = new System.Drawing.Size(75, 23);
            this.sb_ModifyStation.TabIndex = 2;
            this.sb_ModifyStation.Text = "修改";
            this.sb_ModifyStation.Click += new System.EventHandler(this.sb_ModifyStation_Click);
            // 
            // sb_DeleteStation
            // 
            this.sb_DeleteStation.Image = ((System.Drawing.Image)(resources.GetObject("sb_DeleteStation.Image")));
            this.sb_DeleteStation.Location = new System.Drawing.Point(117, 18);
            this.sb_DeleteStation.Name = "sb_DeleteStation";
            this.sb_DeleteStation.Size = new System.Drawing.Size(75, 23);
            this.sb_DeleteStation.TabIndex = 1;
            this.sb_DeleteStation.Text = "删除";
            this.sb_DeleteStation.Click += new System.EventHandler(this.sb_DeleteStation_Click);
            // 
            // sb_AddStation
            // 
            this.sb_AddStation.Image = ((System.Drawing.Image)(resources.GetObject("sb_AddStation.Image")));
            this.sb_AddStation.Location = new System.Drawing.Point(22, 18);
            this.sb_AddStation.Name = "sb_AddStation";
            this.sb_AddStation.Size = new System.Drawing.Size(75, 23);
            this.sb_AddStation.TabIndex = 0;
            this.sb_AddStation.Text = "添加";
            this.sb_AddStation.Click += new System.EventHandler(this.sb_AddStation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sb_ModifyStation);
            this.groupBox1.Controls.Add(this.sb_DeleteStation);
            this.groupBox1.Controls.Add(this.sb_AddStation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 50);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // cbe_HouseList
            // 
            this.cbe_HouseList.Location = new System.Drawing.Point(22, 9);
            this.cbe_HouseList.Name = "cbe_HouseList";
            this.cbe_HouseList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_HouseList.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbe_HouseList.Size = new System.Drawing.Size(148, 20);
            this.cbe_HouseList.TabIndex = 0;
            // 
            // sb_query
            // 
            this.sb_query.Image = ((System.Drawing.Image)(resources.GetObject("sb_query.Image")));
            this.sb_query.Location = new System.Drawing.Point(191, 8);
            this.sb_query.Name = "sb_query";
            this.sb_query.Size = new System.Drawing.Size(75, 23);
            this.sb_query.TabIndex = 15;
            this.sb_query.Text = "查询";
            this.sb_query.Click += new System.EventHandler(this.sb_query_Click);
            // 
            // WHStationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WHStationView";
            this.Text = "工位逻辑设置";
            this.Load += new System.EventHandler(this.WHStationView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_StationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StationList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbe_HouseList.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_StationList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_StationList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sb_ModifyStation;
        private DevExpress.XtraEditors.SimpleButton sb_DeleteStation;
        private DevExpress.XtraEditors.SimpleButton sb_AddStation;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_HouseList;
        private DevExpress.XtraEditors.SimpleButton sb_query;
    }
}