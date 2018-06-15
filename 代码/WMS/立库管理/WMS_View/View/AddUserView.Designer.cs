namespace WMS_Kernel
{
    partial class AddUserView
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
            this.cb_RoleName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_UserRemark = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_UserPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_UserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cb_RoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sb_Add
            // 
            this.sb_Add.Location = new System.Drawing.Point(192, 86);
            this.sb_Add.Name = "sb_Add";
            this.sb_Add.Size = new System.Drawing.Size(82, 22);
            this.sb_Add.TabIndex = 6;
            this.sb_Add.Text = "添加";
            this.sb_Add.Click += new System.EventHandler(this.sb_Add_Click);
            // 
            // sb_Cancel
            // 
            this.sb_Cancel.Location = new System.Drawing.Point(298, 86);
            this.sb_Cancel.Name = "sb_Cancel";
            this.sb_Cancel.Size = new System.Drawing.Size(82, 22);
            this.sb_Cancel.TabIndex = 5;
            this.sb_Cancel.Text = "取消";
            this.sb_Cancel.Click += new System.EventHandler(this.sb_Cancel_Click);
            // 
            // cb_RoleName
            // 
            this.cb_RoleName.Location = new System.Drawing.Point(262, 18);
            this.cb_RoleName.Name = "cb_RoleName";
            this.cb_RoleName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cb_RoleName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_RoleName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_RoleName.Size = new System.Drawing.Size(118, 20);
            this.cb_RoleName.TabIndex = 19;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(208, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "用户备注";
            // 
            // txtEdit_UserRemark
            // 
            this.txtEdit_UserRemark.Location = new System.Drawing.Point(262, 49);
            this.txtEdit_UserRemark.Name = "txtEdit_UserRemark";
            this.txtEdit_UserRemark.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdit_UserRemark.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_UserRemark.TabIndex = 18;
            // 
            // txtEdit_UserPassword
            // 
            this.txtEdit_UserPassword.EditValue = "";
            this.txtEdit_UserPassword.Location = new System.Drawing.Point(72, 51);
            this.txtEdit_UserPassword.Name = "txtEdit_UserPassword";
            this.txtEdit_UserPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdit_UserPassword.Size = new System.Drawing.Size(117, 20);
            this.txtEdit_UserPassword.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(208, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "角色名称";
            // 
            // txtEdit_UserName
            // 
            this.txtEdit_UserName.Location = new System.Drawing.Point(71, 15);
            this.txtEdit_UserName.Name = "txtEdit_UserName";
            this.txtEdit_UserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdit_UserName.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_UserName.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "用户密码";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "用户名称";
            // 
            // AddUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 125);
            this.Controls.Add(this.cb_RoleName);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtEdit_UserRemark);
            this.Controls.Add(this.txtEdit_UserPassword);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtEdit_UserName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.sb_Cancel);
            this.Controls.Add(this.sb_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.AddUserView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cb_RoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sb_Cancel;
        private DevExpress.XtraEditors.SimpleButton sb_Add;
        private DevExpress.XtraEditors.ComboBoxEdit cb_RoleName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEdit_UserRemark;
        private DevExpress.XtraEditors.TextEdit txtEdit_UserPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEdit_UserName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;

    }
}