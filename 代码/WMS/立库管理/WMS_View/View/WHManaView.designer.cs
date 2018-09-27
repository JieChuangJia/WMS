namespace WMS_Kernel
{
    partial class WHManaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WHManaView));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sb_ModifyWH = new DevExpress.XtraEditors.SimpleButton();
            this.sb_DeleteWH = new DevExpress.XtraEditors.SimpleButton();
            this.sb_AddWH = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_WHList = new DevExpress.XtraGrid.GridControl();
            this.gv_WHList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WHList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WHList)).BeginInit();
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
            this.panelControl1.Controls.Add(this.sb_ModifyWH);
            this.panelControl1.Controls.Add(this.sb_DeleteWH);
            this.panelControl1.Controls.Add(this.sb_AddWH);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 360);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(779, 54);
            this.panelControl1.TabIndex = 10;
            // 
            // sb_ModifyWH
            // 
            this.sb_ModifyWH.Image = ((System.Drawing.Image)(resources.GetObject("sb_ModifyWH.Image")));
            this.sb_ModifyWH.Location = new System.Drawing.Point(200, 15);
            this.sb_ModifyWH.Name = "sb_ModifyWH";
            this.sb_ModifyWH.Size = new System.Drawing.Size(75, 23);
            this.sb_ModifyWH.TabIndex = 2;
            this.sb_ModifyWH.Text = "修改";
            this.sb_ModifyWH.Click += new System.EventHandler(this.sb_ModifyWH_Click);
            // 
            // sb_DeleteWH
            // 
            this.sb_DeleteWH.Image = ((System.Drawing.Image)(resources.GetObject("sb_DeleteWH.Image")));
            this.sb_DeleteWH.Location = new System.Drawing.Point(103, 15);
            this.sb_DeleteWH.Name = "sb_DeleteWH";
            this.sb_DeleteWH.Size = new System.Drawing.Size(75, 23);
            this.sb_DeleteWH.TabIndex = 1;
            this.sb_DeleteWH.Text = "删除";
            this.sb_DeleteWH.Click += new System.EventHandler(this.sb_DeleteWH_Click);
            // 
            // sb_AddWH
            // 
            this.sb_AddWH.Image = ((System.Drawing.Image)(resources.GetObject("sb_AddWH.Image")));
            this.sb_AddWH.Location = new System.Drawing.Point(9, 15);
            this.sb_AddWH.Name = "sb_AddWH";
            this.sb_AddWH.Size = new System.Drawing.Size(75, 23);
            this.sb_AddWH.TabIndex = 0;
            this.sb_AddWH.Text = "添加";
            this.sb_AddWH.Click += new System.EventHandler(this.sb_AddWH_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_WHList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(779, 351);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "库房详细";
            // 
            // gc_WHList
            // 
            this.gc_WHList.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gc_WHList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_WHList.Location = new System.Drawing.Point(2, 21);
            this.gc_WHList.MainView = this.gv_WHList;
            this.gc_WHList.Margin = new System.Windows.Forms.Padding(0);
            this.gc_WHList.Name = "gc_WHList";
            this.gc_WHList.Size = new System.Drawing.Size(775, 328);
            this.gc_WHList.TabIndex = 6;
            this.gc_WHList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WHList});
            // 
            // gv_WHList
            // 
            this.gv_WHList.GridControl = this.gc_WHList;
            this.gv_WHList.IndicatorWidth = 40;
            this.gv_WHList.Name = "gv_WHList";
            this.gv_WHList.OptionsBehavior.Editable = false;
            this.gv_WHList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gv_WHList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv_WHList.OptionsView.ColumnAutoWidth = false;
            this.gv_WHList.OptionsView.ShowGroupPanel = false;
            // 
            // WHManaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 417);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WHManaView";
            this.Text = "库房设置";
            this.Load += new System.EventHandler(this.WHManaView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WHList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WHList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sb_ModifyWH;
        private DevExpress.XtraEditors.SimpleButton sb_DeleteWH;
        private DevExpress.XtraEditors.SimpleButton sb_AddWH;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_WHList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WHList;
    }
}