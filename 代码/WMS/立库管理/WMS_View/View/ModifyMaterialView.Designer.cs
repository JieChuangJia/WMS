namespace WMS_Kernel
{
    partial class ModifyMaterialView
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
            this.sb_Save = new DevExpress.XtraEditors.SimpleButton();
            this.sb_can = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.te_Model = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_MaterialUnit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_MaterialCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cb_GoodsType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cb_Flag = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_GoodsName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.te_Model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_GoodsType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Flag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_GoodsName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sb_Save
            // 
            this.sb_Save.Location = new System.Drawing.Point(224, 112);
            this.sb_Save.Name = "sb_Save";
            this.sb_Save.Size = new System.Drawing.Size(88, 22);
            this.sb_Save.TabIndex = 4;
            this.sb_Save.Text = "保存";
            this.sb_Save.Click += new System.EventHandler(this.sb_Save_Click);
            // 
            // sb_can
            // 
            this.sb_can.Location = new System.Drawing.Point(330, 112);
            this.sb_can.Name = "sb_can";
            this.sb_can.Size = new System.Drawing.Size(85, 22);
            this.sb_can.TabIndex = 15;
            this.sb_can.Text = "取消";
            this.sb_can.Click += new System.EventHandler(this.sb_can_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(233, 80);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "规格型号";
            // 
            // te_Model
            // 
            this.te_Model.Location = new System.Drawing.Point(287, 77);
            this.te_Model.Name = "te_Model";
            this.te_Model.Size = new System.Drawing.Size(128, 20);
            this.te_Model.TabIndex = 27;
            // 
            // txtEdit_MaterialUnit
            // 
            this.txtEdit_MaterialUnit.Location = new System.Drawing.Point(287, 45);
            this.txtEdit_MaterialUnit.Name = "txtEdit_MaterialUnit";
            this.txtEdit_MaterialUnit.Size = new System.Drawing.Size(128, 20);
            this.txtEdit_MaterialUnit.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(233, 51);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "物料单位";
            // 
            // txtEdit_MaterialCode
            // 
            this.txtEdit_MaterialCode.EditValue = "";
            this.txtEdit_MaterialCode.Location = new System.Drawing.Point(88, 45);
            this.txtEdit_MaterialCode.Name = "txtEdit_MaterialCode";
            this.txtEdit_MaterialCode.Size = new System.Drawing.Size(128, 20);
            this.txtEdit_MaterialCode.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(233, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "物料名称";
            // 
            // cb_GoodsType
            // 
            this.cb_GoodsType.Location = new System.Drawing.Point(88, 12);
            this.cb_GoodsType.Name = "cb_GoodsType";
            this.cb_GoodsType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_GoodsType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_GoodsType.Size = new System.Drawing.Size(128, 20);
            this.cb_GoodsType.TabIndex = 16;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 80);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "启用状态";
            // 
            // cb_Flag
            // 
            this.cb_Flag.Location = new System.Drawing.Point(88, 77);
            this.cb_Flag.Name = "cb_Flag";
            this.cb_Flag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Flag.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_Flag.Size = new System.Drawing.Size(128, 20);
            this.cb_Flag.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "物料编码";
            // 
            // txtEdit_GoodsName
            // 
            this.txtEdit_GoodsName.Location = new System.Drawing.Point(287, 15);
            this.txtEdit_GoodsName.Name = "txtEdit_GoodsName";
            this.txtEdit_GoodsName.Size = new System.Drawing.Size(128, 20);
            this.txtEdit_GoodsName.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "物料类别";
            // 
            // ModifyMaterialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 151);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.te_Model);
            this.Controls.Add(this.txtEdit_MaterialUnit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtEdit_MaterialCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cb_GoodsType);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cb_Flag);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtEdit_GoodsName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.sb_can);
            this.Controls.Add(this.sb_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyMaterialView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料编辑";
            this.Load += new System.EventHandler(this.ModifyMaterialView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.te_Model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_MaterialCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_GoodsType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Flag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_GoodsName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sb_Cancel;
        private DevExpress.XtraEditors.SimpleButton sb_Save;
        private DevExpress.XtraEditors.SimpleButton sb_can;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit te_Model;
        private DevExpress.XtraEditors.TextEdit txtEdit_MaterialUnit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEdit_MaterialCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cb_GoodsType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cb_Flag;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEdit_GoodsName;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}