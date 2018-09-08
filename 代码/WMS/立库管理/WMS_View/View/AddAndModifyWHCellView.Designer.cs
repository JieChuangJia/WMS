namespace WMS_Kernel
{
    partial class AddAndModifyWHCellView
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
            this.sb_Add = new DevExpress.XtraEditors.SimpleButton();
            this.sb_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cb_CellDirection = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_CellType = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_StationID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_CellName = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.cb_AreaID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_StationCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cb_CellDirection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_CellType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_StationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_CellName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_AreaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StationCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sb_Add
            // 
            this.sb_Add.Location = new System.Drawing.Point(214, 122);
            this.sb_Add.Name = "sb_Add";
            this.sb_Add.Size = new System.Drawing.Size(82, 22);
            this.sb_Add.TabIndex = 6;
            this.sb_Add.Text = "添加";
            this.sb_Add.Click += new System.EventHandler(this.sb_Add_Click);
            // 
            // sb_Cancel
            // 
            this.sb_Cancel.Location = new System.Drawing.Point(304, 122);
            this.sb_Cancel.Name = "sb_Cancel";
            this.sb_Cancel.Size = new System.Drawing.Size(82, 22);
            this.sb_Cancel.TabIndex = 5;
            this.sb_Cancel.Text = "取消";
            this.sb_Cancel.Click += new System.EventHandler(this.sb_Cancel_Click);
            // 
            // cb_CellDirection
            // 
            this.cb_CellDirection.Location = new System.Drawing.Point(68, 94);
            this.cb_CellDirection.Name = "cb_CellDirection";
            this.cb_CellDirection.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cb_CellDirection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_CellDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_CellDirection.Size = new System.Drawing.Size(118, 20);
            this.cb_CellDirection.TabIndex = 19;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(207, 97);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "工位类型";
            // 
            // txtEdit_CellType
            // 
            this.txtEdit_CellType.Location = new System.Drawing.Point(268, 94);
            this.txtEdit_CellType.Name = "txtEdit_CellType";
            this.txtEdit_CellType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdit_CellType.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_CellType.TabIndex = 18;
            // 
            // txtEdit_StationID
            // 
            this.txtEdit_StationID.EditValue = "";
            this.txtEdit_StationID.Location = new System.Drawing.Point(68, 40);
            this.txtEdit_StationID.Name = "txtEdit_StationID";
            this.txtEdit_StationID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdit_StationID.Size = new System.Drawing.Size(117, 20);
            this.txtEdit_StationID.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "工位方向";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "工位编号";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(208, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "库区编码";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "工位名称";
            // 
            // txtEdit_CellName
            // 
            this.txtEdit_CellName.Location = new System.Drawing.Point(68, 68);
            this.txtEdit_CellName.Name = "txtEdit_CellName";
            this.txtEdit_CellName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdit_CellName.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_CellName.TabIndex = 22;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowKeyTips = false;
            this.ribbonControl1.AllowMdiChildButtons = false;
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.AllowTrimPageText = false;
            this.ribbonControl1.CausesValidation = false;
            this.ribbonControl1.DrawGroupsBorder = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(402, 33);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // cb_AreaID
            // 
            this.cb_AreaID.Location = new System.Drawing.Point(268, 68);
            this.cb_AreaID.MenuManager = this.ribbonControl1;
            this.cb_AreaID.Name = "cb_AreaID";
            this.cb_AreaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_AreaID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_AreaID.Size = new System.Drawing.Size(118, 20);
            this.cb_AreaID.TabIndex = 24;
            // 
            // te_StationCode
            // 
            this.te_StationCode.EditValue = "";
            this.te_StationCode.Location = new System.Drawing.Point(268, 40);
            this.te_StationCode.Name = "te_StationCode";
            this.te_StationCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.te_StationCode.Size = new System.Drawing.Size(117, 20);
            this.te_StationCode.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(209, 43);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "工位编码";
            // 
            // AddAndModifyWHCellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 155);
            this.Controls.Add(this.te_StationCode);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cb_AreaID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtEdit_CellName);
            this.Controls.Add(this.cb_CellDirection);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtEdit_CellType);
            this.Controls.Add(this.txtEdit_StationID);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.sb_Cancel);
            this.Controls.Add(this.sb_Add);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAndModifyWHCellView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加工位";
            this.Load += new System.EventHandler(this.AddAndModifyCellView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cb_CellDirection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_CellType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_StationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_CellName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_AreaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StationCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sb_Cancel;
        private DevExpress.XtraEditors.SimpleButton sb_Add;
        private DevExpress.XtraEditors.ComboBoxEdit cb_CellDirection;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEdit_CellType;
        private DevExpress.XtraEditors.TextEdit txtEdit_StationID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdit_CellName;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cb_AreaID;
        private DevExpress.XtraEditors.TextEdit te_StationCode;
        private DevExpress.XtraEditors.LabelControl labelControl5;

    }
}