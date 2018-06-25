namespace WMS_Kernel
{
    partial class WareAreaManaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareAreaManaView));
            this.gc_AreaList = new DevExpress.XtraGrid.GridControl();
            this.gv_AreaList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbe_HouseList = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sb_QueryWare = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sb_ModifyArea = new DevExpress.XtraEditors.SimpleButton();
            this.sb_DeleteArea = new DevExpress.XtraEditors.SimpleButton();
            this.sb_AddArea = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AreaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AreaList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_HouseList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_AreaList
            // 
            this.gc_AreaList.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gc_AreaList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_AreaList.Location = new System.Drawing.Point(2, 21);
            this.gc_AreaList.MainView = this.gv_AreaList;
            this.gc_AreaList.Margin = new System.Windows.Forms.Padding(0);
            this.gc_AreaList.Name = "gc_AreaList";
            this.gc_AreaList.Size = new System.Drawing.Size(775, 268);
            this.gc_AreaList.TabIndex = 6;
            this.gc_AreaList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_AreaList});
            // 
            // gv_AreaList
            // 
            this.gv_AreaList.GridControl = this.gc_AreaList;
            this.gv_AreaList.IndicatorWidth = 40;
            this.gv_AreaList.Name = "gv_AreaList";
            this.gv_AreaList.OptionsBehavior.Editable = false;
            this.gv_AreaList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gv_AreaList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv_AreaList.OptionsView.ColumnAutoWidth = false;
            this.gv_AreaList.OptionsView.ShowGroupPanel = false;
            this.gv_AreaList.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gv_AreaList_RowCellStyle);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 417);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_AreaList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 63);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(779, 291);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "库区详细";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbe_HouseList);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.sb_QueryWare);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(779, 54);
            this.panelControl1.TabIndex = 10;
            // 
            // cbe_HouseList
            // 
            this.cbe_HouseList.Location = new System.Drawing.Point(85, 20);
            this.cbe_HouseList.Name = "cbe_HouseList";
            this.cbe_HouseList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_HouseList.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbe_HouseList.Size = new System.Drawing.Size(149, 20);
            this.cbe_HouseList.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "库房名称";
            // 
            // sb_QueryWare
            // 
            this.sb_QueryWare.Image = ((System.Drawing.Image)(resources.GetObject("sb_QueryWare.Image")));
            this.sb_QueryWare.Location = new System.Drawing.Point(251, 18);
            this.sb_QueryWare.Name = "sb_QueryWare";
            this.sb_QueryWare.Size = new System.Drawing.Size(79, 22);
            this.sb_QueryWare.TabIndex = 10;
            this.sb_QueryWare.Text = "查询";
            this.sb_QueryWare.Click += new System.EventHandler(this.sb_QueryWare_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sb_ModifyArea);
            this.groupControl1.Controls.Add(this.sb_DeleteArea);
            this.groupControl1.Controls.Add(this.sb_AddArea);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 360);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(779, 54);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "操作区";
            // 
            // sb_ModifyArea
            // 
            this.sb_ModifyArea.Image = ((System.Drawing.Image)(resources.GetObject("sb_ModifyArea.Image")));
            this.sb_ModifyArea.Location = new System.Drawing.Point(227, 25);
            this.sb_ModifyArea.Name = "sb_ModifyArea";
            this.sb_ModifyArea.Size = new System.Drawing.Size(75, 23);
            this.sb_ModifyArea.TabIndex = 2;
            this.sb_ModifyArea.Text = "修改";
            this.sb_ModifyArea.Click += new System.EventHandler(this.sb_ModifyArea_Click);
            // 
            // sb_DeleteArea
            // 
            this.sb_DeleteArea.Image = ((System.Drawing.Image)(resources.GetObject("sb_DeleteArea.Image")));
            this.sb_DeleteArea.Location = new System.Drawing.Point(130, 25);
            this.sb_DeleteArea.Name = "sb_DeleteArea";
            this.sb_DeleteArea.Size = new System.Drawing.Size(75, 23);
            this.sb_DeleteArea.TabIndex = 1;
            this.sb_DeleteArea.Text = "删除";
            this.sb_DeleteArea.Click += new System.EventHandler(this.sb_DeleteArea_Click);
            // 
            // sb_AddArea
            // 
            this.sb_AddArea.Image = ((System.Drawing.Image)(resources.GetObject("sb_AddArea.Image")));
            this.sb_AddArea.Location = new System.Drawing.Point(36, 25);
            this.sb_AddArea.Name = "sb_AddArea";
            this.sb_AddArea.Size = new System.Drawing.Size(75, 23);
            this.sb_AddArea.TabIndex = 0;
            this.sb_AddArea.Text = "添加";
            this.sb_AddArea.Click += new System.EventHandler(this.sb_AddArea_Click);
            // 
            // WareAreaManaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 417);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WareAreaManaView";
            this.Text = "库存区域设置";
            this.Load += new System.EventHandler(this.WareAreaManaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_AreaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AreaList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_HouseList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_AreaList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_AreaList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sb_QueryWare;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sb_ModifyArea;
        private DevExpress.XtraEditors.SimpleButton sb_DeleteArea;
        private DevExpress.XtraEditors.SimpleButton sb_AddArea;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_HouseList;
    }
}