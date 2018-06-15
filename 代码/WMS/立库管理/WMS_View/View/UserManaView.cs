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
 
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns; 
namespace WMS_Kernel
{
    public partial class UserManaView : ChildViewBase, IUserManaView
    {
        public DataTable dtUser = null;
        public UserManaPresenter presenter = null;

        private delegate void ShowUserHandler();
        private AddUserView addView = null;

        private ModifyUserView modView = null;

        public UserManaView()
        {
            InitializeComponent();
            addView = new AddUserView();
            addView.MyEvent += new AddUserView.MyDelegate(RefreshUser);
            modView = new ModifyUserView();
            modView.MyEvent += new ModifyUserView.MyDelegate(RefreshUser);
            
          
        }

        private void UserListDataBind()
        {
            this.gc_UserList.DataBindings.Clear();
            this.gc_UserList.DataBindings.Add("DataSource", ViewDataManager.USERVIEWDATA, "UserListData", false, DataSourceUpdateMode.OnPropertyChanged);
           
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new UserManaPresenter(this, wmsFrame);
            string restr = "";

            Bitmap bitmap = ImageResource.UserMana.ToBitmap();
            this.IWmsFrame.AddTitlePage("基础信息", ref restr);
            this.IWmsFrame.AddGroup("基础信息", "信息操作", ref restr);
            this.IWmsFrame.AddButtonItem("基础信息", "信息操作", "用户维护", bitmap, ShowTabEventHandler, ref restr);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }



        private void sb_QueryGoods_Click(object sender, EventArgs e)
        {
            this.presenter.QueryUserList(this.txtEdit_UserInfo.Text.Trim());
        }

        private void RefreshUser()
        {
            this.presenter.QueryUserList(this.txtEdit_UserInfo.Text.Trim());
        }


        private void sb_AddUser_Click(object sender, EventArgs e)
        {
            addView.ShowDialog();
        }

        private void sb_DeleteUser_Click(object sender, EventArgs e)
        {
            if (this.AskMessage("信息提示", "您确定要删除选中用户么？") != 0)
            {
                return;

            }
            if (this.gv_UserList.GetSelectedRows() == null || this.gv_UserList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要删除的用户！");
                return;
            }
            int currRow = this.gv_UserList.GetSelectedRows()[0];
            string userName = this.gv_UserList.GetRowCellValue(currRow, "用户名称").ToString();
            if (this.presenter.DeleteUser(userName))
            {
                this.ShowMessage("信息提示", "用户删除成功！");
            }
            else
            {
                this.ShowMessage("信息提示", "用户删除失败！");
            }
            RefreshUser();
        }

        private void sb_ModifyUser_Click(object sender, EventArgs e)
        {
            if (this.gv_UserList.GetSelectedRows() == null || this.gv_UserList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要修改的用户！");
                return;
            }
            int currRow = this.gv_UserList.GetSelectedRows()[0];
            User user = new User();
            user.UserName = this.gv_UserList.GetRowCellValue(currRow, "用户名称").ToString();
            user.UserPassword = this.gv_UserList.GetRowCellValue(currRow, "用户密码").ToString();
            user.UserRoleName= this.gv_UserList.GetRowCellValue(currRow, "角色名称").ToString();
            user.UserReserve = this.gv_UserList.GetRowCellValue(currRow, "用户预留").ToString();
            modView.user = user;
            modView.ShowDialog();
        }

        private void sb_QueryUser_Click(object sender, EventArgs e)
        {
            this.presenter.QueryUserList(this.txtEdit_UserInfo.Text);
        }

        private void UserManaView_Load(object sender, EventArgs e)
        {
            UserListDataBind();
        }


       

      
    }
}