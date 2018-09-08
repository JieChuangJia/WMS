namespace WMS_Kernel
{
    partial class WHCellView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WHCellView));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sb_ModifyCell = new DevExpress.XtraEditors.SimpleButton();
            this.sb_DeleteCell = new DevExpress.XtraEditors.SimpleButton();
            this.sb_AddCell = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_CellList = new DevExpress.XtraGrid.GridControl();
            this.gv_CellList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CellList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CellList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 417);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sb_ModifyCell);
            this.panelControl1.Controls.Add(this.sb_DeleteCell);
            this.panelControl1.Controls.Add(this.sb_AddCell);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 360);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(779, 54);
            this.panelControl1.TabIndex = 10;
            // 
            // sb_ModifyCell
            // 
            this.sb_ModifyCell.Image = ((System.Drawing.Image)(resources.GetObject("sb_ModifyCell.Image")));
            this.sb_ModifyCell.Location = new System.Drawing.Point(200, 15);
            this.sb_ModifyCell.Name = "sb_ModifyCell";
            this.sb_ModifyCell.Size = new System.Drawing.Size(75, 23);
            this.sb_ModifyCell.TabIndex = 2;
            this.sb_ModifyCell.Text = "修改";
            this.sb_ModifyCell.Click += new System.EventHandler(this.sb_ModifyCell_Click);
            // 
            // sb_DeleteCell
            // 
            this.sb_DeleteCell.Image = ((System.Drawing.Image)(resources.GetObject("sb_DeleteCell.Image")));
            this.sb_DeleteCell.Location = new System.Drawing.Point(103, 15);
            this.sb_DeleteCell.Name = "sb_DeleteCell";
            this.sb_DeleteCell.Size = new System.Drawing.Size(75, 23);
            this.sb_DeleteCell.TabIndex = 1;
            this.sb_DeleteCell.Text = "删除";
            this.sb_DeleteCell.Click += new System.EventHandler(this.sb_DeleteCell_Click);
            // 
            // sb_AddCell
            // 
            this.sb_AddCell.Image = ((System.Drawing.Image)(resources.GetObject("sb_AddCell.Image")));
            this.sb_AddCell.Location = new System.Drawing.Point(9, 15);
            this.sb_AddCell.Name = "sb_AddCell";
            this.sb_AddCell.Size = new System.Drawing.Size(75, 23);
            this.sb_AddCell.TabIndex = 0;
            this.sb_AddCell.Text = "添加";
            this.sb_AddCell.Click += new System.EventHandler(this.sb_AddCell_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_CellList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(779, 351);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "工位详细";
            // 
            // gc_CellList
            // 
            this.gc_CellList.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gc_CellList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_CellList.Location = new System.Drawing.Point(2, 22);
            this.gc_CellList.MainView = this.gv_CellList;
            this.gc_CellList.Margin = new System.Windows.Forms.Padding(0);
            this.gc_CellList.Name = "gc_CellList";
            this.gc_CellList.Size = new System.Drawing.Size(775, 327);
            this.gc_CellList.TabIndex = 6;
            this.gc_CellList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CellList});
            // 
            // gv_CellList
            // 
            this.gv_CellList.GridControl = this.gc_CellList;
            this.gv_CellList.IndicatorWidth = 40;
            this.gv_CellList.Name = "gv_CellList";
            this.gv_CellList.OptionsBehavior.Editable = false;
            this.gv_CellList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gv_CellList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv_CellList.OptionsView.ColumnAutoWidth = false;
            this.gv_CellList.OptionsView.ShowGroupPanel = false;
            // 
            // WHCellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 417);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WHCellView";
            this.Text = "工位设置";
            this.Load += new System.EventHandler(this.WHCellView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_CellList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CellList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sb_ModifyCell;
        private DevExpress.XtraEditors.SimpleButton sb_DeleteCell;
        private DevExpress.XtraEditors.SimpleButton sb_AddCell;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_CellList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CellList;
    }
}