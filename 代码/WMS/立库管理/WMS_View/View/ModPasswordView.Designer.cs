namespace WMS_Kernel
{
    partial class ModPasswordView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdit_UserName = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_NewPassword = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdit_CheckPassword = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.sbtn_Sure = new DevExpress.XtraEditors.SimpleButton();
            this.sb_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_NewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_CheckPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = " 用户名称";
            // 
            // txtEdit_UserName
            // 
            this.txtEdit_UserName.Location = new System.Drawing.Point(101, 16);
            this.txtEdit_UserName.Name = "txtEdit_UserName";
            this.txtEdit_UserName.Size = new System.Drawing.Size(135, 20);
            this.txtEdit_UserName.TabIndex = 1;
            // 
            // txtEdit_NewPassword
            // 
            this.txtEdit_NewPassword.Location = new System.Drawing.Point(102, 47);
            this.txtEdit_NewPassword.Name = "txtEdit_NewPassword";
            this.txtEdit_NewPassword.Size = new System.Drawing.Size(134, 20);
            this.txtEdit_NewPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "输入新密码";
            // 
            // txtEdit_CheckPassword
            // 
            this.txtEdit_CheckPassword.Location = new System.Drawing.Point(102, 80);
            this.txtEdit_CheckPassword.Name = "txtEdit_CheckPassword";
            this.txtEdit_CheckPassword.Size = new System.Drawing.Size(134, 20);
            this.txtEdit_CheckPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "确认新密码";
            // 
            // sbtn_Sure
            // 
            this.sbtn_Sure.Location = new System.Drawing.Point(81, 124);
            this.sbtn_Sure.Name = "sbtn_Sure";
            this.sbtn_Sure.Size = new System.Drawing.Size(75, 23);
            this.sbtn_Sure.TabIndex = 8;
            this.sbtn_Sure.Text = "确认";
            this.sbtn_Sure.Click += new System.EventHandler(this.sbtn_Sure_Click_1);
            // 
            // sb_Cancel
            // 
            this.sb_Cancel.Location = new System.Drawing.Point(162, 124);
            this.sb_Cancel.Name = "sb_Cancel";
            this.sb_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sb_Cancel.TabIndex = 9;
            this.sb_Cancel.Text = "取消";
            this.sb_Cancel.Click += new System.EventHandler(this.sb_Cancel_Click);
            // 
            // ModPasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 174);
            this.Controls.Add(this.sb_Cancel);
            this.Controls.Add(this.sbtn_Sure);
            this.Controls.Add(this.txtEdit_CheckPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdit_NewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdit_UserName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModPasswordView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码修改";
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_NewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_CheckPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtEdit_UserName;
        private DevExpress.XtraEditors.TextEdit txtEdit_NewPassword;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtEdit_CheckPassword;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton sbtn_Sure;
        private DevExpress.XtraEditors.SimpleButton sb_Cancel;

    }
}