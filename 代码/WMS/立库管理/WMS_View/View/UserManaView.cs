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
    public partial class UserManaView : ChildViewBase
    {
        public DataTable dtUser = null;
        public UserManaView()
        {
            InitializeComponent();
            dtUser = new DataTable();
            dtUser.Columns.Add(new DataColumn("UserName"));
            dtUser.Columns.Add(new DataColumn("UserPassword"));
            dtUser.Columns.Add(new DataColumn("Remark"));
            string[] strArray = new string[1]{ "admin,123456,"};
            for (int i = 0; i < strArray.Count(); i++)
            {
                DataRow row = dtUser.NewRow();
                row["UserName"] = strArray[i].Split(',')[0];
                row["UserPassword"] = strArray[i].Split(',')[1];
                row["Remark"] = strArray[i].Split(',')[2];
                dtUser.Rows.Add(row);
            }
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);

            string restr = "";

            //Bitmap bitmap = ImageResource.UserMana.ToBitmap();
            //this.IWmsFrame.AddTitlePage("系统", ref restr);
            //this.IWmsFrame.AddGroup("系统", "系统配置", ref restr);
            //this.IWmsFrame.AddButtonItem("系统", "系统配置", "用户维护", bitmap, ShowTabEventHandler, ref restr);
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
            this.gc_User.DataSource = dtUser;
        }



        private void gridView1_Click(object sender, EventArgs e)
        {
            this.txtEdit_CurRow.Text = (this.gridView1.FocusedRowHandle + 1).ToString();
        }
    }
}