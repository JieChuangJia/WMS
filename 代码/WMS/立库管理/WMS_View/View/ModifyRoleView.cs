using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS_Database;
using DevExpress.XtraEditors.Controls;
using WMS_Interface;

namespace WMS_Kernel
{
    public partial class ModifyRoleView: DevExpress.XtraEditors.XtraForm,IAddRoleView
    {
        //定义委托
        public delegate void MyDelegate();
        //定义事件
        public event MyDelegate MyEvent;


        public AddRolePresenter presenter = null;
        public UserRole role = null;
        public ModifyRoleView()
        {
            InitializeComponent();
            this.presenter = new AddRolePresenter(this);
        }
        
        #region 实现方法
       
        #endregion

        #region 私有方法

        public void ShowMessage(string title, string content)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion



        private void sb_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ModifyRoleView_Load(object sender, EventArgs e)
        {
            this.txtEdit_RoleName.Text = role.RoleName;
            this.txtEdit_RoleLevel.Text = role.RoleLevel.ToString();
            this.txtEdit_RoleDes.Text = role.RoleDesc;
            this.txtEdit_RoleRemark.Text = role.RoleRemark;
        }

        private void sb_Save_Click(object sender, EventArgs e)
        {
            // if (this.cb_Flag.SelectedText == "" || this.cb_Flag.SelectedText == null)
            if (this.txtEdit_RoleName.Text== null || this.txtEdit_RoleName.Text == "")
            {
                this.ShowMessage("信息提示", "请输入角色名称");
                return;
            }
            string oldRoleName = role.RoleName;
            role.RoleName = this.txtEdit_RoleName.Text;
            role.RoleLevel = Convert.ToInt32(this.txtEdit_RoleLevel.Text);
            role.RoleDesc = this.txtEdit_RoleDes.Text;
            role.RoleRemark = this.txtEdit_RoleRemark.Text;
            if (this.presenter.ModifyRoleModel(oldRoleName,role))
            {
                this.ShowMessage("信息提示", "角色修改成功");
            }
            else
            {
                this.ShowMessage("信息提示", "角色修改失败");
            }
            if (MyEvent != null)
            {
                MyEvent();//引发事件
            }
        }
    }
}