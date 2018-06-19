using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS_Interface;
using DevExpress.XtraBars;
using System.Reflection;

namespace WMS_Kernel
{
    public partial class ModPasswordView : ChildViewBase,IAddUserView
    {
        private AddUserPresenter presenter = null;
        public ModPasswordView()
        {
            InitializeComponent();
            this.presenter = new AddUserPresenter(this);
          
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            string restr = "";
            Bitmap bitmap = ImageResource.ModifyPassWord.ToBitmap();
            this.IWmsFrame.AddTitlePage("基础信息", ref restr);
            this.IWmsFrame.AddGroup("基础信息", "信息操作", ref restr);
            this.IWmsFrame.AddButtonItem("基础信息", "信息操作", "修改密码", bitmap, ShowTabEventHandler, ref restr);
        }
        #region 私有方法

        public void ShowMessage(string title, string content)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            if (this.IWmsFrame.RoleLevel > 2)
            {
                this.ShowMessage("信息提示", "当前用户没有此操作权限！");
                return;
            }
            this.IWmsFrame.ShowView(this, true);
        }


        private void sbtn_Sure_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = this.txtEdit_UserName.Text;
            if(string.Compare(this.txtEdit_NewPassword.Text,this.txtEdit_CheckPassword.Text) != 0)
            {
                this.ShowMessage("信息提示", "输入的新密码与确认的新密码不同，请重新输入！");
                return;
            }
            user.UserPassword = this.txtEdit_NewPassword.Text;
            if(this.presenter.ModUserPassword(user))
            {
                this.ShowMessage("信息提示", "用户新密码修改成功");
                return;
            }
            else
            {
                this.ShowMessage("信息提示", "用户新密码修改失败");
                return;
            }


        }

        private void sb_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}