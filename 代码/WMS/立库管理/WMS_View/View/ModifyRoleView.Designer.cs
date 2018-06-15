namespace WMS_Kernel
{
    partial class ModifyRoleView
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
            this.sb_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_RoleRemark = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_RoleDes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_RoleName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_RoleLevel = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleLevel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sb_Save
            // 
            this.sb_Save.Location = new System.Drawing.Point(186, 77);
            this.sb_Save.Name = "sb_Save";
            this.sb_Save.Size = new System.Drawing.Size(82, 22);
            this.sb_Save.TabIndex = 6;
            this.sb_Save.Text = "保存";
            this.sb_Save.Click += new System.EventHandler(this.sb_Save_Click);
            // 
            // sb_Cancel
            // 
            this.sb_Cancel.Location = new System.Drawing.Point(292, 77);
            this.sb_Cancel.Name = "sb_Cancel";
            this.sb_Cancel.Size = new System.Drawing.Size(82, 22);
            this.sb_Cancel.TabIndex = 5;
            this.sb_Cancel.Text = "取消";
            this.sb_Cancel.Click += new System.EventHandler(this.sb_Cancel_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(202, 44);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "角色备注";
            // 
            // txtEdit_RoleRemark
            // 
            this.txtEdit_RoleRemark.Location = new System.Drawing.Point(256, 41);
            this.txtEdit_RoleRemark.Name = "txtEdit_RoleRemark";
            this.txtEdit_RoleRemark.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_RoleRemark.TabIndex = 18;
            // 
            // txtEdit_RoleDes
            // 
            this.txtEdit_RoleDes.EditValue = "";
            this.txtEdit_RoleDes.Location = new System.Drawing.Point(66, 43);
            this.txtEdit_RoleDes.Name = "txtEdit_RoleDes";
            this.txtEdit_RoleDes.Size = new System.Drawing.Size(117, 20);
            this.txtEdit_RoleDes.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(202, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "角色等级";
            // 
            // txtEdit_RoleName
            // 
            this.txtEdit_RoleName.Location = new System.Drawing.Point(65, 7);
            this.txtEdit_RoleName.Name = "txtEdit_RoleName";
            this.txtEdit_RoleName.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_RoleName.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "角色描述";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "角色名称";
            // 
            // txtEdit_RoleLevel
            // 
            this.txtEdit_RoleLevel.Location = new System.Drawing.Point(256, 9);
            this.txtEdit_RoleLevel.Name = "txtEdit_RoleLevel";
            this.txtEdit_RoleLevel.Size = new System.Drawing.Size(118, 20);
            this.txtEdit_RoleLevel.TabIndex = 16;
            // 
            // ModifyRoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 110);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtEdit_RoleRemark);
            this.Controls.Add(this.txtEdit_RoleDes);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtEdit_RoleName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtEdit_RoleLevel);
            this.Controls.Add(this.sb_Cancel);
            this.Controls.Add(this.sb_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyRoleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改角色";
            this.Load += new System.EventHandler(this.ModifyRoleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleLevel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sb_Cancel;
        private DevExpress.XtraEditors.SimpleButton sb_Save;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEdit_RoleRemark;
        private DevExpress.XtraEditors.TextEdit txtEdit_RoleDes;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEdit_RoleName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEdit_RoleLevel;

    }
}