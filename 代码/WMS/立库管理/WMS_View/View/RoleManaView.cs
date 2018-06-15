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
    public partial class RoleManaView : ChildViewBase, IRoleManaView
    {
        public DataTable dtRole = null;
        public RoleManaPresenter presenter = null;

        private delegate void ShowRoleHandler();
        private AddRoleView addView = null;

        private ModifyRoleView modView = null;

        public RoleManaView()
        {
            InitializeComponent();
            addView = new AddRoleView();
            addView.MyEvent += new AddRoleView.MyDelegate(RefreshRole);
            modView = new ModifyRoleView();
            modView.MyEvent += new ModifyRoleView.MyDelegate(RefreshRole);
            
          
        }

        private void RoleListDataBind()
        {
            this.gc_RoleList.DataBindings.Clear();
            this.gc_RoleList.DataBindings.Add("DataSource", ViewDataManager.ROLEVIEWDATA, "RoleListData", false, DataSourceUpdateMode.OnPropertyChanged);
          
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new RoleManaPresenter(this, wmsFrame);
            string restr = "";

            Bitmap bitmap = ImageResource.RoleMana.ToBitmap();
            this.IWmsFrame.AddTitlePage("基础信息", ref restr);
            this.IWmsFrame.AddGroup("基础信息", "信息操作", ref restr);
            this.IWmsFrame.AddButtonItem("基础信息", "信息操作", "角色维护", bitmap, ShowTabEventHandler, ref restr);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }




        private void RefreshRole()
        {
            this.presenter.QueryRoleList(this.txtEdit_RoleInfo.Text.Trim());
        }



        private void sb_DeleteGoods_Click(object sender, EventArgs e)
        {
            if(this.AskMessage("信息提示","您确定要删除选中角色么？")!=0)
            {
                return;
                    
            }
            if (this.gv_RoleList.GetSelectedRows() == null || this.gv_RoleList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要删除的角色！");
                return;
            }
            int currRow = this.gv_RoleList.GetSelectedRows()[0];
            string roleName= this.gv_RoleList.GetRowCellValue(currRow, "角色名称").ToString();
            if (this.presenter.DeleteRole(roleName))
            {
                this.ShowMessage("信息提示", "角色删除成功！");
            }
            else
            {
                this.ShowMessage("信息提示", "角色删除失败！");
            }
            RefreshRole();
        }

        private void RoleManaView_Load(object sender, EventArgs e)
        {
            RoleListDataBind();
        }

        private void sb_AddRole_Click(object sender, EventArgs e)
        {
            addView.ShowDialog();
        }

        private void sb_ModifyRole_Click(object sender, EventArgs e)
        {
            if (this.gv_RoleList.GetSelectedRows() == null || this.gv_RoleList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要修改的角色！");
                return;
            }
            int currRow = this.gv_RoleList.GetSelectedRows()[0];
            UserRole role = new UserRole();
            role.RoleName = this.gv_RoleList.GetRowCellValue(currRow, "角色名称").ToString();
            role.RoleLevel = Convert.ToInt32(this.gv_RoleList.GetRowCellValue(currRow, "角色等级").ToString());
            role.RoleDesc = this.gv_RoleList.GetRowCellValue(currRow, "角色描述").ToString();
            role.RoleRemark = this.gv_RoleList.GetRowCellValue(currRow, "角色备注").ToString();
            modView.role = role;
            modView.ShowDialog();
        }

        private void sb_QueryRoles_Click(object sender, EventArgs e)
        {
            this.presenter.QueryRoleList(this.txtEdit_RoleInfo.Text.Trim());
        }


       

      
    }
}