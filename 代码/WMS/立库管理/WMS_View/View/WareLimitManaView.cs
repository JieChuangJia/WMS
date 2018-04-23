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
    public partial class WareLimitManaView : ChildViewBase
    {
        public DataTable dtUser = null;
        public WareLimitManaView()
        {
            InitializeComponent();
            dtUser = new DataTable();
            dtUser.Columns.Add(new DataColumn("UserName"));
            dtUser.Columns.Add(new DataColumn("UserPassword"));
            dtUser.Columns.Add(new DataColumn("Remark"));
            string[] strArray = new string[1] { "admin,123456," };
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

            //string restr = "";

            //Bitmap bitmap = ImageResource.WareLimitMana.ToBitmap();
            //this.IWmsFrame.AddTitlePage("基础信息", ref restr);
            //this.IWmsFrame.AddGroup("基础信息", "信息操作", ref restr);
            //this.IWmsFrame.AddButtonItem("基础信息", "信息操作", "仓库权限维护", bitmap, ShowTabEventHandler, ref restr);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void WareLimitManaView_Load(object sender, EventArgs e)
        {
            this.gc_User.DataSource = dtUser;
        }


    }
}