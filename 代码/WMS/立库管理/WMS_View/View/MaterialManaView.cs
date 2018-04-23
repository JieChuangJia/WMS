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
    public partial class MaterialManaView : ChildViewBase, IMaterailManaView
    {
        public DataTable dtRole = null;
        MaterialDetailView materialDetailView = new MaterialDetailView();
        public MaterialManaPresenter presenter = null;
        public MaterialManaView()
        {
            InitializeComponent();
          
        }
        private void MaterialManaView_Load(object sender, EventArgs e)
        {
            
            GoodsListDataBind();
            ShowPropertyView(false);
        }

        private void ShowPropertyView(bool show)
        {
            if (show == true)
            {
                this.splitContainer1.Panel2Collapsed = false;
            }
            else
            {
                this.splitContainer1.Panel2Collapsed = true;
            }
          

        }

        private void GoodsListDataBind()
        {
            this.gc_GoodsList.DataBindings.Clear();
            this.gc_GoodsList.DataBindings.Add("DataSource", ViewDataManager.GOODSVIEWDATA, "GoodsListData", false, DataSourceUpdateMode.OnPropertyChanged);
            this.gc_PropertyDetail.DataBindings.Clear();
            this.gc_PropertyDetail.DataBindings.Add("DataSource", ViewDataManager.GOODSVIEWDATA, "GoodsPropertyList", false, DataSourceUpdateMode.OnPropertyChanged);

        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new MaterialManaPresenter(this, wmsFrame);
            string restr = "";

            Bitmap bitmap = ImageResource.MaterialMana.ToBitmap();
            this.IWmsFrame.AddTitlePage("基础信息", ref restr);
            this.IWmsFrame.AddGroup("基础信息", "信息操作", ref restr);
            this.IWmsFrame.AddButtonItem("基础信息", "信息操作", "物料维护", bitmap, ShowTabEventHandler, ref restr);

            materialDetailView.Init(wmsFrame);
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }



        private void sb_QueryGoods_Click(object sender, EventArgs e)
        {
            this.presenter.QueryGoodsList(this.txtEdit_MaterialInfo.Text.Trim());
        }

        private void gc_GoodsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.gridView1.GetSelectedRows().Count()==0)
            {
                return;
            }

            int currRow = this.gridView1.GetSelectedRows()[0];
            string goodsID = this.gridView1.GetRowCellValue(currRow, "物料内部编码").ToString();
            this.presenter.ShowGoodsDetail(goodsID);
            ShowPropertyView(true);
        }

        private void sb_ClosePro_Click(object sender, EventArgs e)
        {
            ShowPropertyView(false);
        }

       

      
    }
}