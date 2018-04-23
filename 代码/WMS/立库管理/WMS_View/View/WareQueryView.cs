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
    public partial class WareQueryView : ChildViewBase
    {
        public WareQueryView()
        {
            InitializeComponent();

        }


        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);

            //string restr = "";

            //Bitmap bitmap = ImageResource.WareQuery.ToBitmap();
            //this.IWmsFrame.AddTitlePage("库存管理", ref restr);
            //this.IWmsFrame.AddGroup("库存管理", "库存管理", ref restr);
            //this.IWmsFrame.AddButtonItem("库存管理", "库存管理", "库存查询", bitmap, ShowTabEventHandler, ref restr);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }



        private void gridView1_Click(object sender, EventArgs e)
        {
            //this.txtEdit_CurRow.Text = (this.gridView1.FocusedRowHandle + 1).ToString();
        }



        private void gridView1_CustomDrawRowIndicator_1(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
    }
}