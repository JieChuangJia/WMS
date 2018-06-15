namespace WMS_Kernel
{
    partial class RoleManaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleManaView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_RoleList = new DevExpress.XtraGrid.GridControl();
            this.gv_RoleList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sb_QueryRoles = new DevExpress.XtraEditors.SimpleButton();
            this.txtEdit_RoleInfo = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sb_ModifyRole = new DevExpress.XtraEditors.SimpleButton();
            this.sb_DeleteRole = new DevExpress.XtraEditors.SimpleButton();
            this.sb_AddRole = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_RoleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_RoleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleInfo.Properties)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_RoleList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 63);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(704, 274);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "角色清单";
            // 
            // gc_RoleList
            // 
            this.gc_RoleList.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gc_RoleList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_RoleList.Location = new System.Drawing.Point(2, 22);
            this.gc_RoleList.MainView = this.gv_RoleList;
            this.gc_RoleList.Margin = new System.Windows.Forms.Padding(0);
            this.gc_RoleList.Name = "gc_RoleList";
            this.gc_RoleList.Size = new System.Drawing.Size(700, 250);
            this.gc_RoleList.TabIndex = 6;
            this.gc_RoleList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_RoleList});
            // 
            // gv_RoleList
            // 
            this.gv_RoleList.GridControl = this.gc_RoleList;
            this.gv_RoleList.GroupPanelText = "角色清单";
            this.gv_RoleList.IndicatorWidth = 40;
            this.gv_RoleList.Name = "gv_RoleList";
            this.gv_RoleList.OptionsSelection.MultiSelect = true;
            this.gv_RoleList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gv_RoleList.OptionsView.ColumnAutoWidth = false;
            this.gv_RoleList.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.sb_QueryRoles);
            this.panelControl1.Controls.Add(this.txtEdit_RoleInfo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(704, 54);
            this.panelControl1.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "角色信息";
            // 
            // sb_QueryRoles
            // 
            this.sb_QueryRoles.Image = ((System.Drawing.Image)(resources.GetObject("sb_QueryRoles.Image")));
            this.sb_QueryRoles.Location = new System.Drawing.Point(251, 18);
            this.sb_QueryRoles.Name = "sb_QueryRoles";
            this.sb_QueryRoles.Size = new System.Drawing.Size(79, 22);
            this.sb_QueryRoles.TabIndex = 10;
            this.sb_QueryRoles.Text = "查询";
            this.sb_QueryRoles.Click += new System.EventHandler(this.sb_QueryRoles_Click);
            // 
            // txtEdit_RoleInfo
            // 
            this.txtEdit_RoleInfo.Location = new System.Drawing.Point(79, 19);
            this.txtEdit_RoleInfo.Name = "txtEdit_RoleInfo";
            this.txtEdit_RoleInfo.Size = new System.Drawing.Size(157, 20);
            this.txtEdit_RoleInfo.TabIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sb_ModifyRole);
            this.groupControl1.Controls.Add(this.sb_DeleteRole);
            this.groupControl1.Controls.Add(this.sb_AddRole);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 343);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(704, 54);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "操作区";
            // 
            // sb_ModifyRole
            // 
            this.sb_ModifyRole.Image = ((System.Drawing.Image)(resources.GetObject("sb_ModifyRole.Image")));
            this.sb_ModifyRole.Location = new System.Drawing.Point(227, 25);
            this.sb_ModifyRole.Name = "sb_ModifyRole";
            this.sb_ModifyRole.Size = new System.Drawing.Size(75, 23);
            this.sb_ModifyRole.TabIndex = 2;
            this.sb_ModifyRole.Text = "修改";
            this.sb_ModifyRole.Click += new System.EventHandler(this.sb_ModifyRole_Click);
            // 
            // sb_DeleteRole
            // 
            this.sb_DeleteRole.Image = ((System.Drawing.Image)(resources.GetObject("sb_DeleteRole.Image")));
            this.sb_DeleteRole.Location = new System.Drawing.Point(130, 25);
            this.sb_DeleteRole.Name = "sb_DeleteRole";
            this.sb_DeleteRole.Size = new System.Drawing.Size(75, 23);
            this.sb_DeleteRole.TabIndex = 1;
            this.sb_DeleteRole.Text = "删除";
            this.sb_DeleteRole.Click += new System.EventHandler(this.sb_DeleteGoods_Click);
            // 
            // sb_AddRole
            // 
            this.sb_AddRole.Image = ((System.Drawing.Image)(resources.GetObject("sb_AddRole.Image")));
            this.sb_AddRole.Location = new System.Drawing.Point(36, 25);
            this.sb_AddRole.Name = "sb_AddRole";
            this.sb_AddRole.Size = new System.Drawing.Size(75, 23);
            this.sb_AddRole.TabIndex = 0;
            this.sb_AddRole.Text = "添加";
            this.sb_AddRole.Click += new System.EventHandler(this.sb_AddRole_Click);
            // 
            // RoleManaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RoleManaView";
            this.Text = "角色维护";
            this.Load += new System.EventHandler(this.RoleManaView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_RoleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_RoleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_RoleInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gc_RoleList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_RoleList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdit_RoleInfo;
        private DevExpress.XtraEditors.SimpleButton sb_QueryRoles;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sb_ModifyRole;
        private DevExpress.XtraEditors.SimpleButton sb_DeleteRole;
        private DevExpress.XtraEditors.SimpleButton sb_AddRole;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;

    }
}