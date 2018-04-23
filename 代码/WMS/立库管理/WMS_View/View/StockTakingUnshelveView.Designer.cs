namespace WMS_Kernel
{
    partial class StockTakingUnshelveView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockTakingUnshelveView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ce_TargetStation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sb_StockTakingUnshelve = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Stock = new DevExpress.XtraGrid.GridControl();
            this.gv_Stock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gc_StockList = new DevExpress.XtraGrid.GridControl();
            this.gv_stockList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sb_QueryByPalletCode = new DevExpress.XtraEditors.SimpleButton();
            this.lc_pos = new DevExpress.XtraEditors.LabelControl();
            this.cbe_PosTypeList = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lc_gs = new DevExpress.XtraEditors.LabelControl();
            this.te_CellName = new DevExpress.XtraEditors.TextEdit();
            this.lc_House = new DevExpress.XtraEditors.LabelControl();
            this.cbe_HouseList = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_MaterialInfo = new DevExpress.XtraEditors.TextEdit();
            this.lc_goods = new DevExpress.XtraEditors.LabelControl();
            this.rb_CellStockTaking = new System.Windows.Forms.RadioButton();
            this.rb_goodsStockTaking = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ce_TargetStation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_PosTypeList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_CellName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_HouseList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_MaterialInfo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gc_Stock, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 477);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ce_TargetStation);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.sb_StockTakingUnshelve);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 399);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(860, 75);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "操作区";
            // 
            // ce_TargetStation
            // 
            this.ce_TargetStation.EditValue = "请选择";
            this.ce_TargetStation.Location = new System.Drawing.Point(69, 43);
            this.ce_TargetStation.Name = "ce_TargetStation";
            this.ce_TargetStation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ce_TargetStation.Size = new System.Drawing.Size(123, 20);
            this.ce_TargetStation.TabIndex = 35;
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(15, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "盘点工位";
            // 
            // sb_StockTakingUnshelve
            // 
            this.sb_StockTakingUnshelve.Image = ((System.Drawing.Image)(resources.GetObject("sb_StockTakingUnshelve.Image")));
            this.sb_StockTakingUnshelve.Location = new System.Drawing.Point(216, 40);
            this.sb_StockTakingUnshelve.Name = "sb_StockTakingUnshelve";
            this.sb_StockTakingUnshelve.Size = new System.Drawing.Size(92, 26);
            this.sb_StockTakingUnshelve.TabIndex = 34;
            this.sb_StockTakingUnshelve.Text = "盘点下架";
            // 
            // gc_Stock
            // 
            this.gc_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_Stock.Location = new System.Drawing.Point(3, 83);
            this.gc_Stock.MainView = this.gv_Stock;
            this.gc_Stock.Name = "gc_Stock";
            this.gc_Stock.Size = new System.Drawing.Size(860, 152);
            this.gc_Stock.TabIndex = 1;
            this.gc_Stock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Stock});
            // 
            // gv_Stock
            // 
            this.gv_Stock.GridControl = this.gc_Stock;
            this.gv_Stock.GroupPanelText = "库存";
            this.gv_Stock.Name = "gv_Stock";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gc_StockList);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(3, 241);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(860, 152);
            this.panelControl3.TabIndex = 2;
            // 
            // gc_StockList
            // 
            this.gc_StockList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_StockList.Location = new System.Drawing.Point(2, 2);
            this.gc_StockList.MainView = this.gv_stockList;
            this.gc_StockList.Name = "gc_StockList";
            this.gc_StockList.Size = new System.Drawing.Size(856, 148);
            this.gc_StockList.TabIndex = 2;
            this.gc_StockList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_stockList});
            // 
            // gv_stockList
            // 
            this.gv_stockList.GridControl = this.gc_StockList;
            this.gv_stockList.GroupPanelText = "库存详细";
            this.gv_stockList.Name = "gv_stockList";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sb_QueryByPalletCode);
            this.panelControl1.Controls.Add(this.lc_pos);
            this.panelControl1.Controls.Add(this.cbe_PosTypeList);
            this.panelControl1.Controls.Add(this.lc_gs);
            this.panelControl1.Controls.Add(this.te_CellName);
            this.panelControl1.Controls.Add(this.lc_House);
            this.panelControl1.Controls.Add(this.cbe_HouseList);
            this.panelControl1.Controls.Add(this.te_MaterialInfo);
            this.panelControl1.Controls.Add(this.lc_goods);
            this.panelControl1.Controls.Add(this.rb_CellStockTaking);
            this.panelControl1.Controls.Add(this.rb_goodsStockTaking);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(860, 74);
            this.panelControl1.TabIndex = 0;
            // 
            // sb_QueryByPalletCode
            // 
            this.sb_QueryByPalletCode.Image = ((System.Drawing.Image)(resources.GetObject("sb_QueryByPalletCode.Image")));
            this.sb_QueryByPalletCode.Location = new System.Drawing.Point(673, 21);
            this.sb_QueryByPalletCode.Name = "sb_QueryByPalletCode";
            this.sb_QueryByPalletCode.Size = new System.Drawing.Size(92, 26);
            this.sb_QueryByPalletCode.TabIndex = 33;
            this.sb_QueryByPalletCode.Text = "查询";
            // 
            // lc_pos
            // 
            this.lc_pos.Location = new System.Drawing.Point(546, 26);
            this.lc_pos.Name = "lc_pos";
            this.lc_pos.Size = new System.Drawing.Size(24, 14);
            this.lc_pos.TabIndex = 32;
            this.lc_pos.Text = "位置";
            // 
            // cbe_PosTypeList
            // 
            this.cbe_PosTypeList.Location = new System.Drawing.Point(581, 23);
            this.cbe_PosTypeList.Name = "cbe_PosTypeList";
            this.cbe_PosTypeList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_PosTypeList.Size = new System.Drawing.Size(69, 20);
            this.cbe_PosTypeList.TabIndex = 31;
            // 
            // lc_gs
            // 
            this.lc_gs.Location = new System.Drawing.Point(356, 27);
            this.lc_gs.Name = "lc_gs";
            this.lc_gs.Size = new System.Drawing.Size(24, 14);
            this.lc_gs.TabIndex = 30;
            this.lc_gs.Text = "货位";
            // 
            // te_CellName
            // 
            this.te_CellName.Location = new System.Drawing.Point(391, 24);
            this.te_CellName.Name = "te_CellName";
            this.te_CellName.Size = new System.Drawing.Size(147, 20);
            this.te_CellName.TabIndex = 29;
            // 
            // lc_House
            // 
            this.lc_House.Location = new System.Drawing.Point(149, 27);
            this.lc_House.Name = "lc_House";
            this.lc_House.Size = new System.Drawing.Size(24, 14);
            this.lc_House.TabIndex = 26;
            this.lc_House.Text = "库房";
            // 
            // cbe_HouseList
            // 
            this.cbe_HouseList.Location = new System.Drawing.Point(184, 24);
            this.cbe_HouseList.Name = "cbe_HouseList";
            this.cbe_HouseList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_HouseList.Size = new System.Drawing.Size(157, 20);
            this.cbe_HouseList.TabIndex = 25;
            // 
            // te_MaterialInfo
            // 
            this.te_MaterialInfo.Enabled = false;
            this.te_MaterialInfo.Location = new System.Drawing.Point(184, 48);
            this.te_MaterialInfo.Name = "te_MaterialInfo";
            this.te_MaterialInfo.Size = new System.Drawing.Size(157, 20);
            this.te_MaterialInfo.TabIndex = 12;
            // 
            // lc_goods
            // 
            this.lc_goods.Enabled = false;
            this.lc_goods.Location = new System.Drawing.Point(127, 51);
            this.lc_goods.Name = "lc_goods";
            this.lc_goods.Size = new System.Drawing.Size(48, 14);
            this.lc_goods.TabIndex = 13;
            this.lc_goods.Text = "物料信息";
            // 
            // rb_CellStockTaking
            // 
            this.rb_CellStockTaking.AutoSize = true;
            this.rb_CellStockTaking.BackColor = System.Drawing.Color.Transparent;
            this.rb_CellStockTaking.Checked = true;
            this.rb_CellStockTaking.Location = new System.Drawing.Point(21, 25);
            this.rb_CellStockTaking.Name = "rb_CellStockTaking";
            this.rb_CellStockTaking.Size = new System.Drawing.Size(85, 18);
            this.rb_CellStockTaking.TabIndex = 1;
            this.rb_CellStockTaking.TabStop = true;
            this.rb_CellStockTaking.Text = "按货位盘点";
            this.rb_CellStockTaking.UseVisualStyleBackColor = false;
            this.rb_CellStockTaking.CheckedChanged += new System.EventHandler(this.rb_CellStockTaking_CheckedChanged);
            // 
            // rb_goodsStockTaking
            // 
            this.rb_goodsStockTaking.AutoSize = true;
            this.rb_goodsStockTaking.BackColor = System.Drawing.Color.Transparent;
            this.rb_goodsStockTaking.Location = new System.Drawing.Point(21, 49);
            this.rb_goodsStockTaking.Name = "rb_goodsStockTaking";
            this.rb_goodsStockTaking.Size = new System.Drawing.Size(85, 18);
            this.rb_goodsStockTaking.TabIndex = 0;
            this.rb_goodsStockTaking.Text = "按物料盘点";
            this.rb_goodsStockTaking.UseVisualStyleBackColor = false;
            this.rb_goodsStockTaking.CheckedChanged += new System.EventHandler(this.rb_goodsStockTaking_CheckedChanged);
            // 
            // StockTakingUnshelveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 477);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockTakingUnshelveView";
            this.Text = "盘点下架";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ce_TargetStation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_StockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_PosTypeList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_CellName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_HouseList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_MaterialInfo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RadioButton rb_goodsStockTaking;
        private System.Windows.Forms.RadioButton rb_CellStockTaking;
        private DevExpress.XtraEditors.TextEdit te_MaterialInfo;
        private DevExpress.XtraEditors.LabelControl lc_goods;
        private DevExpress.XtraEditors.LabelControl lc_pos;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_PosTypeList;
        private DevExpress.XtraEditors.LabelControl lc_gs;
        private DevExpress.XtraEditors.TextEdit te_CellName;
        private DevExpress.XtraEditors.LabelControl lc_House;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_HouseList;
        private DevExpress.XtraGrid.GridControl gc_Stock;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Stock;
        private DevExpress.XtraEditors.SimpleButton sb_QueryByPalletCode;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gc_StockList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_stockList;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sb_StockTakingUnshelve;
        private DevExpress.XtraEditors.ComboBoxEdit ce_TargetStation;
    }
}