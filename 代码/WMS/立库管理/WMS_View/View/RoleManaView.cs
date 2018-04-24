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
namespace WMS_Kernel
{
    public partial class RoleManaView : ChildViewBase
    {
        public DataTable dtRole = null;
        public RoleManaView()
        {
            InitializeComponent();
            dtRole = new DataTable();
            dtRole.Columns.Add(new DataColumn("RoleCode"));
            dtRole.Columns.Add(new DataColumn("RoleName"));
            dtRole.Columns.Add(new DataColumn("Remark"));
            string[] strArray = new string[2]{ "Adminiatrator,管理员,", "User,普通用户," };
            for (int i = 0; i < strArray.Count(); i++)
            {
                DataRow row = dtRole.NewRow();
                row["RoleCode"] = strArray[i].Split(',')[0];
                row["RoleName"] = strArray[i].Split(',')[1];
                row["Remark"] = strArray[i].Split(',')[2];
                dtRole.Rows.Add(row);
            }
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);

            string restr = "";

            //Bitmap bitmap = ImageResource.RoleMana.ToBitmap();
            //this.IWmsFrame.AddTitlePage("系统", ref restr);
            //this.IWmsFrame.AddGroup("系统", "系统配置", ref restr);
            //this.IWmsFrame.AddButtonItem("系统", "系统配置", "角色维护", bitmap, ShowTabEventHandler, ref restr);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        private void gv_Role_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void RoleManaView_Load(object sender, EventArgs e)
        {
            this.gc_Role.DataSource = dtRole;
        }



        private void gridView1_Click(object sender, EventArgs e)
        {
            this.txtEdit_CurRow.Text = (this.gridView1.FocusedRowHandle + 1).ToString();
        }
    }
}