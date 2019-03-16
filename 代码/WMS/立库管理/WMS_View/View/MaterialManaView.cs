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

        private delegate void ShowMaterialHandler();
        private AddMaterialView addView = null;//物料编辑窗体

        private ModifyMaterialView modView = null;

        public MaterialManaView()
        {
            InitializeComponent();
            addView = new AddMaterialView();
            addView.MyEvent += new AddMaterialView.MyDelegate(RefreshMaterial);
            modView = new ModifyMaterialView();
            modView.MyEvent += new ModifyMaterialView.MyDelegate(RefreshMaterial);
            
          
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
            if (this.IWmsFrame.RoleLevel > 2)
            {
                this.ShowMessage("信息提示", "当前用户没有此操作权限！");
                return;
            }
            this.IWmsFrame.ShowView(this, true);
        }



        private void sb_QueryGoods_Click(object sender, EventArgs e)
        {
            this.presenter.QueryGoodsList(this.txtEdit_MaterialInfo.Text.Trim());
        }

        private void RefreshMaterial()
        {
            this.presenter.QueryGoodsList(this.txtEdit_MaterialInfo.Text.Trim());
        }

        private void gc_GoodsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.gv_MaterialList.GetSelectedRows().Count()==0)
            {
                return;
            }

            int currRow = this.gv_MaterialList.GetSelectedRows()[0];
            string goodsID = this.gv_MaterialList.GetRowCellValue(currRow, "物料内部编码").ToString();
            this.presenter.ShowGoodsDetail(goodsID);
            ShowPropertyView(true);
        }

        private void sb_ClosePro_Click(object sender, EventArgs e)
        {
            ShowPropertyView(false);
        }

        private void sb_AddGoods_Click(object sender, EventArgs e)
        {
            if(this.IWmsFrame.RoleLevel>2)
            {
                this.ShowMessage("信息提示", "当前用户没有此操作权限！");
                return;
            }
            addView.ShowDialog();
        }

        private void sb_ModifyGoods_Click(object sender, EventArgs e)
        {
            if (this.IWmsFrame.RoleLevel > 2)
            {
                this.ShowMessage("信息提示", "当前用户没有此操作权限！");
                return;
            }
            if (this.gv_MaterialList.GetSelectedRows() == null || this.gv_MaterialList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要修改的物料！");
                return;
            }
            int currRow = this.gv_MaterialList.GetSelectedRows()[0];
            Goods goods = new Goods();
            goods.MaterialID = this.gv_MaterialList.GetRowCellValue(currRow, "物料内部编码").ToString();
            goods.MaterialName = this.gv_MaterialList.GetRowCellValue(currRow, "物料名称").ToString();
            goods.MaterialType = this.gv_MaterialList.GetRowCellValue(currRow, "物料类别").ToString();
            goods.MaterialCode = this.gv_MaterialList.GetRowCellValue(currRow, "物料编码").ToString();
            goods.MaterialFlag = this.gv_MaterialList.GetRowCellValue(currRow, "启用").ToString();
            goods.MaterialUnit = this.gv_MaterialList.GetRowCellValue(currRow, "单位").ToString();
            goods.MaterialModel = this.gv_MaterialList.GetRowCellValue(currRow, "规格型号").ToString();
            modView.modGoods = goods;
            modView.ShowDialog();
        }

        private void sb_DeleteGoods_Click(object sender, EventArgs e)
        {
            if (this.IWmsFrame.RoleLevel > 2)
            {
                this.ShowMessage("信息提示", "当前用户没有此操作权限！");
                return;
            }

            if(this.AskMessage("信息提示","您确定要删除选中物料么？")!=0)
            {
                return;
                    
            }
            if (this.gv_MaterialList.GetSelectedRows() == null || this.gv_MaterialList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要删除的物料！");
                return;
            }
            int currRow = this.gv_MaterialList.GetSelectedRows()[0];
            string materialID = this.gv_MaterialList.GetRowCellValue(currRow, "物料内部编码").ToString();
            if(this.presenter.DeleteMaterial(materialID))
            {
                this.ShowMessage("信息提示", "物料删除成功！");
            }
            else
            {
                this.ShowMessage("信息提示", "物料删除失败！");
            }
            RefreshMaterial();
        }

        private void sb_CloseProper_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2Collapsed = true;
        }


       

      
    }
}