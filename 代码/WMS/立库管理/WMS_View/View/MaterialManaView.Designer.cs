namespace WMS_Kernel
{
    partial class MaterialManaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialManaView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gc_GoodsList = new DevExpress.XtraGrid.GridControl();
            this.gv_MaterialList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sb_ClosePro = new DevExpress.XtraEditors.SimpleButton();
            this.gc_PropertyDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sb_QueryGoods = new DevExpress.XtraEditors.SimpleButton();
            this.txtEdit_MaterialInfo = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sb_ModifyGoods = new DevExpress.XtraEditors.SimpleButton();
            this.sb_DeleteGoods = new DevExpress.XtraEditors.SimpleButton();
            this.sb_AddGoods = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GoodsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PropertyDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1204, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gc_GoodsList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sb_ClosePro);
            this.splitContainer1.Panel2.Controls.Add(this.gc_PropertyDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1198, 443);
            this.splitContainer1.SplitterDistance = 944;
            this.splitContainer1.TabIndex = 8;
            // 
            // gc_GoodsList
            // 
            this.gc_GoodsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GoodsList.Location = new System.Drawing.Point(0, 0);
            this.gc_GoodsList.MainView = this.gv_MaterialList;
            this.gc_GoodsList.Name = "gc_GoodsList";
            this.gc_GoodsList.Size = new System.Drawing.Size(944, 443);
            this.gc_GoodsList.TabIndex = 6;
            this.gc_GoodsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_MaterialList});
            this.gc_GoodsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gc_GoodsList_MouseDoubleClick);
            // 
            // gridView1
            // 
            this.gv_MaterialList.GridControl = this.gc_GoodsList;
            this.gv_MaterialList.GroupPanelText = "物料清单";
            this.gv_MaterialList.IndicatorWidth = 40;
            this.gv_MaterialList.Name = "gv_MaterialList";
            // 
            // sb_ClosePro
            // 
            this.sb_ClosePro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sb_ClosePro.Location = new System.Drawing.Point(167, 412);
            this.sb_ClosePro.Name = "sb_ClosePro";
            this.sb_ClosePro.Size = new System.Drawing.Size(75, 23);
            this.sb_ClosePro.TabIndex = 1;
            this.sb_ClosePro.Text = "关闭属性";
            this.sb_ClosePro.Click += new System.EventHandler(this.sb_ClosePro_Click);
            // 
            // gc_PropertyDetail
            // 
            this.gc_PropertyDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_PropertyDetail.Location = new System.Drawing.Point(3, 3);
            this.gc_PropertyDetail.MainView = this.gridView2;
            this.gc_PropertyDetail.Name = "gc_PropertyDetail";
            this.gc_PropertyDetail.Size = new System.Drawing.Size(239, 403);
            this.gc_PropertyDetail.TabIndex = 0;
            this.gc_PropertyDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gc_PropertyDetail;
            this.gridView2.GroupPanelText = "物料属性";
            this.gridView2.Name = "gridView2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.sb_QueryGoods);
            this.panelControl1.Controls.Add(this.txtEdit_MaterialInfo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1198, 54);
            this.panelControl1.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "物料信息";
            // 
            // sb_QueryGoods
            // 
            this.sb_QueryGoods.Image = ((System.Drawing.Image)(resources.GetObject("sb_QueryGoods.Image")));
            this.sb_QueryGoods.Location = new System.Drawing.Point(251, 18);
            this.sb_QueryGoods.Name = "sb_QueryGoods";
            this.sb_QueryGoods.Size = new System.Drawing.Size(79, 22);
            this.sb_QueryGoods.TabIndex = 10;
            this.sb_QueryGoods.Text = "查询";
            this.sb_QueryGoods.Click += new System.EventHandler(this.sb_QueryGoods_Click);
            // 
            // txtEdit_MaterialInfo
            // 
            this.txtEdit_MaterialInfo.Location = new System.Drawing.Point(79, 19);
            this.txtEdit_MaterialInfo.Name = "txtEdit_MaterialInfo";
            this.txtEdit_MaterialInfo.Size = new System.Drawing.Size(157, 20);
            this.txtEdit_MaterialInfo.TabIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sb_ModifyGoods);
            this.groupControl1.Controls.Add(this.sb_DeleteGoods);
            this.groupControl1.Controls.Add(this.sb_AddGoods);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 512);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1198, 54);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "操作区";
            // 
            // sb_ModifyGoods
            // 
            this.sb_ModifyGoods.Image = ((System.Drawing.Image)(resources.GetObject("sb_ModifyGoods.Image")));
            this.sb_ModifyGoods.Location = new System.Drawing.Point(227, 25);
            this.sb_ModifyGoods.Name = "sb_ModifyGoods";
            this.sb_ModifyGoods.Size = new System.Drawing.Size(75, 23);
            this.sb_ModifyGoods.TabIndex = 2;
            this.sb_ModifyGoods.Text = "修改";
            this.sb_ModifyGoods.Click += new System.EventHandler(this.sb_ModifyGoods_Click);
            // 
            // sb_DeleteGoods
            // 
            this.sb_DeleteGoods.Image = ((System.Drawing.Image)(resources.GetObject("sb_DeleteGoods.Image")));
            this.sb_DeleteGoods.Location = new System.Drawing.Point(130, 25);
            this.sb_DeleteGoods.Name = "sb_DeleteGoods";
            this.sb_DeleteGoods.Size = new System.Drawing.Size(75, 23);
            this.sb_DeleteGoods.TabIndex = 1;
            this.sb_DeleteGoods.Text = "删除";
            this.sb_DeleteGoods.Click += new System.EventHandler(this.sb_DeleteGoods_Click);
            // 
            // sb_AddGoods
            // 
            this.sb_AddGoods.Image = ((System.Drawing.Image)(resources.GetObject("sb_AddGoods.Image")));
            this.sb_AddGoods.Location = new System.Drawing.Point(36, 25);
            this.sb_AddGoods.Name = "sb_AddGoods";
            this.sb_AddGoods.Size = new System.Drawing.Size(75, 23);
            this.sb_AddGoods.TabIndex = 0;
            this.sb_AddGoods.Text = "添加";
            this.sb_AddGoods.Click += new System.EventHandler(this.sb_AddGoods_Click);
            // 
            // MaterialManaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MaterialManaView";
            this.Text = "物料维护";
            this.Load += new System.EventHandler(this.MaterialManaView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GoodsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PropertyDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton sb_ClosePro;
        private DevExpress.XtraGrid.GridControl gc_PropertyDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gc_GoodsList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_MaterialList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdit_MaterialInfo;
        private DevExpress.XtraEditors.SimpleButton sb_QueryGoods;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sb_ModifyGoods;
        private DevExpress.XtraEditors.SimpleButton sb_DeleteGoods;
        private DevExpress.XtraEditors.SimpleButton sb_AddGoods;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}