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
    public partial class ModifyUserView: DevExpress.XtraEditors.XtraForm,IAddUserView
    {
        //定义委托
        public delegate void MyDelegate();
        //定义事件
        public event MyDelegate MyEvent;


        public AddUserPresenter presenter = null;
        public User user = null;
        public ModifyUserView()
        {
            InitializeComponent();
            this.presenter = new AddUserPresenter(this);
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


        private void sb_Save_Click(object sender, EventArgs e)
        {
            if (this.txtEdit_UserName.Text == null || this.txtEdit_UserName.Text == "")
            {
                this.ShowMessage("信息提示", "请输入用户名称");
                return;
            }
            if (this.cb_RoleName.SelectedIndex == -1)
            {
                this.ShowMessage("信息提示", "请选择角色名称");
                return;
            }
            string oleUserName = user.UserName;
            user.UserName = this.txtEdit_UserName.Text;
            user.UserPassword = this.txtEdit_UserPassword.Text;
            user.UserRoleName = this.cb_RoleName.Text;
            user.UserReserve = this.txtEdit_UserRemark.Text;
            if (this.presenter.ModifyUserModel(oleUserName, user))
            {
                this.ShowMessage("信息提示", "用户修改成功");
            }
            else
            {
                this.ShowMessage("信息提示", "用户修改失败");
            }
               
            if (MyEvent != null)
            {
                MyEvent();//引发事件
            }
        }

        private void ModifyUserView_Load(object sender, EventArgs e)
        {
            List<string> roleName = this.presenter.LoadRoleName();
            this.cb_RoleName.Properties.Items.Clear();
            if (roleName == null)
            {
                return;
            }
            for (int i = 0; i < roleName.Count; i++)
            {
                this.cb_RoleName.Properties.Items.Add(roleName[i]);
            }
            this.cb_RoleName.Text = user.UserRoleName;
            this.txtEdit_UserName.Text = user.UserName;
            this.txtEdit_UserPassword.Text = user.UserPassword;
            this.txtEdit_UserRemark.Text = user.UserReserve;
        }
    }
}