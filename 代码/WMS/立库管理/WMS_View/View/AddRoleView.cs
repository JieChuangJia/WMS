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
    public partial class AddRoleView: DevExpress.XtraEditors.XtraForm,IAddRoleView
    {
        //定义委托
        public delegate void MyDelegate();
        //定义事件
        public event MyDelegate MyEvent;


        public AddRolePresenter presenter = null;
        public AddRoleView()
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

        private void sb_Add_Click(object sender, EventArgs e)
        {
            UserRole role = new UserRole();
            if (this.txtEdit_RoleName.Text == null || this.txtEdit_RoleName.Text == "")
            {
                this.ShowMessage("信息提示", "请输入角色名称");
                return;
            }
            role.RoleName = this.txtEdit_RoleName.Text;
            role.RoleLevel = Convert.ToInt32(this.txtEdit_RoleLevel.Text);
            role.RoleDesc = this.txtEdit_RoleDes.Text;
            role.RoleRemark = this.txtEdit_RoleRemark.Text;
            if (this.presenter.AddRoleModel(role))
            {
                this.ShowMessage("信息提示", "角色添加成功");
            }
            else
            {
                this.ShowMessage("信息提示", "角色添加失败");
            }
            if (MyEvent != null)
            {
                MyEvent();//引发事件
            }
        }

        private void AddRoleView_Load(object sender, EventArgs e)
        {

        }
    }
}