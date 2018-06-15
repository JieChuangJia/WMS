namespace WMS_Kernel
{
    partial class UserManaView
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManaView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_UserList = new DevExpress.XtraGrid.GridControl();
            this.gv_UserList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sb_QueryUser = new DevExpress.XtraEditors.SimpleButton();
            this.txtEdit_UserInfo = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sb_ModifyUser = new DevExpress.XtraEditors.SimpleButton();
            this.sb_DeleteUser = new DevExpress.XtraEditors.SimpleButton();
            this.sb_AddUser = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_UserList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 63);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(700, 272);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "用户清单";
            // 
            // gc_UserList
            // 
            this.gc_UserList.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gc_UserList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_UserList.Location = new System.Drawing.Point(2, 22);
            this.gc_UserList.MainView = this.gv_UserList;
            this.gc_UserList.Margin = new System.Windows.Forms.Padding(0);
            this.gc_UserList.Name = "gc_UserList";
            this.gc_UserList.Size = new System.Drawing.Size(696, 248);
            this.gc_UserList.TabIndex = 6;
            this.gc_UserList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_UserList});
            // 
            // gv_UserList
            // 
            this.gv_UserList.GridControl = this.gc_UserList;
            this.gv_UserList.GroupPanelText = "角色清单";
            this.gv_UserList.IndicatorWidth = 40;
            this.gv_UserList.Name = "gv_UserList";
            this.gv_UserList.OptionsSelection.MultiSelect = true;
            this.gv_UserList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gv_UserList.OptionsView.ColumnAutoWidth = false;
            this.gv_UserList.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.sb_QueryUser);
            this.panelControl1.Controls.Add(this.txtEdit_UserInfo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(700, 54);
            this.panelControl1.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "用户信息";
            // 
            // sb_QueryUser
            // 
            this.sb_QueryUser.Image = ((System.Drawing.Image)(resources.GetObject("sb_QueryUser.Image")));
            this.sb_QueryUser.Location = new System.Drawing.Point(251, 18);
            this.sb_QueryUser.Name = "sb_QueryUser";
            this.sb_QueryUser.Size = new System.Drawing.Size(79, 22);
            this.sb_QueryUser.TabIndex = 10;
            this.sb_QueryUser.Text = "查询";
            this.sb_QueryUser.Click += new System.EventHandler(this.sb_QueryUser_Click);
            // 
            // txtEdit_UserInfo
            // 
            this.txtEdit_UserInfo.Location = new System.Drawing.Point(79, 19);
            this.txtEdit_UserInfo.Name = "txtEdit_UserInfo";
            this.txtEdit_UserInfo.Size = new System.Drawing.Size(157, 20);
            this.txtEdit_UserInfo.TabIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sb_ModifyUser);
            this.groupControl1.Controls.Add(this.sb_DeleteUser);
            this.groupControl1.Controls.Add(this.sb_AddUser);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 341);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(700, 54);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "操作区";
            // 
            // sb_ModifyUser
            // 
            this.sb_ModifyUser.Image = ((System.Drawing.Image)(resources.GetObject("sb_ModifyUser.Image")));
            this.sb_ModifyUser.Location = new System.Drawing.Point(227, 25);
            this.sb_ModifyUser.Name = "sb_ModifyUser";
            this.sb_ModifyUser.Size = new System.Drawing.Size(75, 23);
            this.sb_ModifyUser.TabIndex = 2;
            this.sb_ModifyUser.Text = "修改";
            this.sb_ModifyUser.Click += new System.EventHandler(this.sb_ModifyUser_Click);
            // 
            // sb_DeleteUser
            // 
            this.sb_DeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("sb_DeleteUser.Image")));
            this.sb_DeleteUser.Location = new System.Drawing.Point(130, 25);
            this.sb_DeleteUser.Name = "sb_DeleteUser";
            this.sb_DeleteUser.Size = new System.Drawing.Size(75, 23);
            this.sb_DeleteUser.TabIndex = 1;
            this.sb_DeleteUser.Text = "删除";
            this.sb_DeleteUser.Click += new System.EventHandler(this.sb_DeleteUser_Click);
            // 
            // sb_AddUser
            // 
            this.sb_AddUser.Image = ((System.Drawing.Image)(resources.GetObject("sb_AddUser.Image")));
            this.sb_AddUser.Location = new System.Drawing.Point(36, 25);
            this.sb_AddUser.Name = "sb_AddUser";
            this.sb_AddUser.Size = new System.Drawing.Size(75, 23);
            this.sb_AddUser.TabIndex = 0;
            this.sb_AddUser.Text = "添加";
            this.sb_AddUser.Click += new System.EventHandler(this.sb_AddUser_Click);
            // 
            // UserManaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 398);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserManaView";
            this.Text = "用户维护";
            this.Load += new System.EventHandler(this.UserManaView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_UserInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gc_UserList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_UserList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdit_UserInfo;
        private DevExpress.XtraEditors.SimpleButton sb_QueryUser;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sb_ModifyUser;
        private DevExpress.XtraEditors.SimpleButton sb_DeleteUser;
        private DevExpress.XtraEditors.SimpleButton sb_AddUser;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;

    }
}