namespace WMS_Kernel
{
    partial class AddAndModifyAreaView
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
            this.cb_AreaEnable = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_AreaType = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_AreaColor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_AreaName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sb_SetColor = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_AreaCode = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.cb_AreaEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_AreaType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_AreaColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_AreaName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_AreaCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // sb_Add
            // 
            this.sb_Add.Location = new System.Drawing.Point(190, 153);
            this.sb_Add.Name = "sb_Add";
            this.sb_Add.Size = new System.Drawing.Size(82, 22);
            this.sb_Add.TabIndex = 6;
            this.sb_Add.Text = "添加";
            this.sb_Add.Click += new System.EventHandler(this.sb_Add_Click);
            // 
            // sb_Cancel
            // 
            this.sb_Cancel.Location = new System.Drawing.Point(287, 153);
            this.sb_Cancel.Name = "sb_Cancel";
            this.sb_Cancel.Size = new System.Drawing.Size(82, 22);
            this.sb_Cancel.TabIndex = 5;
            this.sb_Cancel.Text = "取消";
            this.sb_Cancel.Click += new System.EventHandler(this.sb_Cancel_Click);
            // 
            // cb_AreaEnable
            // 
            this.cb_AreaEnable.Location = new System.Drawing.Point(66, 150);
            this.cb_AreaEnable.Name = "cb_AreaEnable";
            this.cb_AreaEnable.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cb_AreaEnable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_AreaEnable.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_AreaEnable.Size = new System.Drawing.Size(118, 20);
            this.cb_AreaEnable.TabIndex = 19;
            this.cb_AreaEnable.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(197, 109);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "区域类型";
            // 
            // txtEdit_AreaType
            // 
            this.txtEdit_AreaType.Location = new System.Drawing.Point(254, 106);
            this.txtEdit_AreaType.Name = "txtEdit_AreaType";
            this.txtEdit_AreaType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdit_AreaType.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_AreaType.TabIndex = 18;
            // 
            // txtEdit_AreaColor
            // 
            this.txtEdit_AreaColor.EditValue = "";
            this.txtEdit_AreaColor.Location = new System.Drawing.Point(72, 76);
            this.txtEdit_AreaColor.Name = "txtEdit_AreaColor";
            this.txtEdit_AreaColor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdit_AreaColor.Size = new System.Drawing.Size(117, 20);
            this.txtEdit_AreaColor.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 153);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 14);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "启用/停用";
            this.labelControl4.Visible = false;
            // 
            // txtEdit_AreaName
            // 
            this.txtEdit_AreaName.Location = new System.Drawing.Point(72, 44);
            this.txtEdit_AreaName.Name = "txtEdit_AreaName";
            this.txtEdit_AreaName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdit_AreaName.Size = new System.Drawing.Size(300, 20);
            this.txtEdit_AreaName.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "区域颜色";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "区域名称";
            // 
            // sb_SetColor
            // 
            this.sb_SetColor.Location = new System.Drawing.Point(199, 75);
            this.sb_SetColor.Name = "sb_SetColor";
            this.sb_SetColor.Size = new System.Drawing.Size(173, 23);
            this.sb_SetColor.TabIndex = 20;
            this.sb_SetColor.Text = "设置";
            this.sb_SetColor.Click += new System.EventHandler(this.sb_SetColor_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "区域编码";
            // 
            // textEdit_AreaCode
            // 
            this.textEdit_AreaCode.Location = new System.Drawing.Point(72, 106);
            this.textEdit_AreaCode.Name = "textEdit_AreaCode";
            this.textEdit_AreaCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEdit_AreaCode.Size = new System.Drawing.Size(118, 20);
            this.textEdit_AreaCode.TabIndex = 22;
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
            this.ribbonControl1.Size = new System.Drawing.Size(384, 33);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // AddAndModifyAreaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 186);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit_AreaCode);
            this.Controls.Add(this.sb_SetColor);
            this.Controls.Add(this.cb_AreaEnable);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtEdit_AreaType);
            this.Controls.Add(this.txtEdit_AreaColor);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtEdit_AreaName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.sb_Cancel);
            this.Controls.Add(this.sb_Add);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAndModifyAreaView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加区域";
            this.Load += new System.EventHandler(this.AddAndModifyAreaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cb_AreaEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_AreaType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_AreaColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_AreaName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_AreaCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sb_Cancel;
        private DevExpress.XtraEditors.SimpleButton sb_Add;
        private DevExpress.XtraEditors.ComboBoxEdit cb_AreaEnable;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEdit_AreaType;
        private DevExpress.XtraEditors.TextEdit txtEdit_AreaColor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEdit_AreaName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sb_SetColor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_AreaCode;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;

    }
}