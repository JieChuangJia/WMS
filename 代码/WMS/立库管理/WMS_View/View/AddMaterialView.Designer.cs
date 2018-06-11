namespace WMS_Kernel
{
    partial class AddMaterialView
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
            this.cb_Flag = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtEdit_MaterialUnit = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_MaterialCode = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_GoodsName = new DevExpress.XtraEditors.TextEdit();
            this.cb_GoodsType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sb_Add = new DevExpress.XtraEditors.SimpleButton();
            this.sb_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.te_Model = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Flag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_GoodsName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_GoodsType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_Model.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Flag
            // 
            this.cb_Flag.Location = new System.Drawing.Point(72, 98);
            this.cb_Flag.Name = "cb_Flag";
            this.cb_Flag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Flag.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_Flag.Size = new System.Drawing.Size(118, 20);
            this.cb_Flag.TabIndex = 8;
            // 
            // txtEdit_MaterialUnit
            // 
            this.txtEdit_MaterialUnit.Location = new System.Drawing.Point(263, 65);
            this.txtEdit_MaterialUnit.Name = "txtEdit_MaterialUnit";
            this.txtEdit_MaterialUnit.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_MaterialUnit.TabIndex = 7;
            // 
            // txtEdit_MaterialCode
            // 
            this.txtEdit_MaterialCode.EditValue = "";
            this.txtEdit_MaterialCode.Location = new System.Drawing.Point(73, 65);
            this.txtEdit_MaterialCode.Name = "txtEdit_MaterialCode";
            this.txtEdit_MaterialCode.Size = new System.Drawing.Size(117, 20);
            this.txtEdit_MaterialCode.TabIndex = 6;
            // 
            // txtEdit_GoodsName
            // 
            this.txtEdit_GoodsName.Location = new System.Drawing.Point(263, 32);
            this.txtEdit_GoodsName.Name = "txtEdit_GoodsName";
            this.txtEdit_GoodsName.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_GoodsName.TabIndex = 5;
            // 
            // cb_GoodsType
            // 
            this.cb_GoodsType.Location = new System.Drawing.Point(73, 32);
            this.cb_GoodsType.Name = "cb_GoodsType";
            this.cb_GoodsType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_GoodsType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_GoodsType.Size = new System.Drawing.Size(117, 20);
            this.cb_GoodsType.TabIndex = 4;
            // 
            // sb_Add
            // 
            this.sb_Add.Location = new System.Drawing.Point(218, 153);
            this.sb_Add.Name = "sb_Add";
            this.sb_Add.Size = new System.Drawing.Size(82, 22);
            this.sb_Add.TabIndex = 6;
            this.sb_Add.Text = "添加";
            this.sb_Add.Click += new System.EventHandler(this.sb_Add_Click);
            // 
            // sb_Cancel
            // 
            this.sb_Cancel.Location = new System.Drawing.Point(324, 153);
            this.sb_Cancel.Name = "sb_Cancel";
            this.sb_Cancel.Size = new System.Drawing.Size(82, 22);
            this.sb_Cancel.TabIndex = 5;
            this.sb_Cancel.Text = "取消";
            this.sb_Cancel.Click += new System.EventHandler(this.sb_Cancel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "物料类别";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(209, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "物料名称";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "物料编码";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(209, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "物料单位";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "启用状态";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.te_Model);
            this.groupControl1.Controls.Add(this.cb_Flag);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtEdit_MaterialCode);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtEdit_GoodsName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cb_GoodsType);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtEdit_MaterialUnit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(415, 144);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "物料信息";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(209, 100);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "规格型号";
            // 
            // te_Model
            // 
            this.te_Model.Location = new System.Drawing.Point(263, 97);
            this.te_Model.Name = "te_Model";
            this.te_Model.Size = new System.Drawing.Size(118, 20);
            this.te_Model.TabIndex = 10;
            // 
            // AddMaterialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 184);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.sb_Cancel);
            this.Controls.Add(this.sb_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMaterialView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加物料";
            this.Load += new System.EventHandler(this.AddMaterialView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cb_Flag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_GoodsName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_GoodsType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_Model.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sb_Cancel;
        private DevExpress.XtraEditors.TextEdit txtEdit_GoodsName;
        private DevExpress.XtraEditors.ComboBoxEdit cb_GoodsType;
        private DevExpress.XtraEditors.ComboBoxEdit cb_Flag;
        private DevExpress.XtraEditors.TextEdit txtEdit_MaterialUnit;
        private DevExpress.XtraEditors.TextEdit txtEdit_MaterialCode;
        private DevExpress.XtraEditors.SimpleButton sb_Add;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit te_Model;

    }
}