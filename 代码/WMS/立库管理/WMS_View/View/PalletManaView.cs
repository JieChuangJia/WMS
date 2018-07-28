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
using WMS_Database;
namespace WMS_Kernel
{
    public partial class PalletManaView : ChildViewBase,IPalletManageView
    {
        PalletManagePresenter presenter = null;
  
        public PalletManaView()
        {
            InitializeComponent();

        }
        private void PalletManaView_Load(object sender, EventArgs e)
        {
            BindPalletData();
            //de_CreateTime.EditValue = DateTime.Now;
        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new PalletManagePresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.Pallet.ToBitmap();
            this.IWmsFrame.AddTitlePage("库存管理", ref restr);
            this.IWmsFrame.AddGroup("库存管理", "库存操作", ref restr);
            this.IWmsFrame.AddButtonItem("库存管理", "库存操作", "配盘管理", bitmap, ShowTabEventHandler, ref restr);
        }
        public void IniHouseName(List<WH_WareHouseModel> houseList)
        {
            this.cbe_HouseList.Properties.Items.Clear();
            //this.cbe_HouseList.Properties.Items.Add("所有");
            if (houseList == null)
            {
                return;
            }
            foreach (WH_WareHouseModel house in houseList)
            {
                this.cbe_HouseList.Properties.Items.Add(house.WareHouse_Name);
            }
            if (this.cbe_HouseList.Properties.Items.Count > 0)
            {
                this.cbe_HouseList.SelectedIndex = 0;
            }
        }

        public void IniPlanList(List<string> planList)
        {
            this.cbe_PlanList.Properties.Items.Clear();
            this.cbe_PlanList.Properties.Items.Add("所有");
            if (planList == null)
            {
                return;
            }
            foreach (string plan in planList)
            {
                this.cbe_PlanList.Properties.Items.Add(plan);
            }
            if (this.cbe_PlanList.Properties.Items.Count > 0)
            {
                this.cbe_PlanList.SelectedIndex = 0;
            }
        }
        public void IniPalletPos(List<string> stationList)
        {
            this.cbe_PalletPos.Properties.Items.Clear();

            if (stationList == null)
            {
                return;
            }
            foreach (string item in stationList)
            {
                this.cbe_PalletPos.Properties.Items.Add(item);
            }
            if (this.cbe_PalletPos.Properties.Items.Count > 0)
            {
                this.cbe_PalletPos.SelectedIndex = 0;
            }
        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        private void BindPalletData()
        {
            this.gc_PalletGoodsInfor.DataBindings.Clear();
            this.gc_PalletGoodsInfor.DataBindings.Add("DataSource", ViewDataManager.PALLETMANAGEDATA, "PalletInforData", false, DataSourceUpdateMode.OnPropertyChanged);
           
            this.gc_PalletList.DataBindings.Clear();
            this.gc_PalletList.DataBindings.Add("DataSource", ViewDataManager.PALLETMANAGEDATA, "PalletList", false, DataSourceUpdateMode.OnPropertyChanged);
           
            this.gc_GoodsList.DataBindings.Clear();
            this.gc_GoodsList.DataBindings.Add("DataSource", ViewDataManager.PALLETMANAGEDATA, "PalletGoodsData", false, DataSourceUpdateMode.OnPropertyChanged);
            
        }
     

        private void sb_QueryPallet_Click(object sender, EventArgs e)
        {
            this.presenter.QueryPallet( this.cbe_PalletPos.Text.Trim(),this.cbe_PlanList.Text.Trim());
        }

        private void sb_QueryGoodsInfor_Click(object sender, EventArgs e)
        {
            this.presenter.ShowGoods(this.te_GoodsInfo.Text.Trim());
        }

        private void gc_PalletList_Click(object sender, EventArgs e)
        {
            if (this.gv_PalletList == null || this.gv_PalletList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_PalletList.GetSelectedRows()[0];
            string palletCode = this.gv_PalletList.GetRowCellValue(currRow, "托盘条码").ToString();
            string cellName = this.gv_PalletList.GetRowCellValue(currRow, "配盘工位名称").ToString();

            this.presenter.QueryPalletInfo(palletCode, cellName);
        }

        private void sb_AddGoods_Click(object sender, EventArgs e)
        {
            if (this.gv_PalletList.GetSelectedRows() == null || this.gv_PalletList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择配盘托盘！");
                return;
            }
            int currRow = this.gv_PalletList.GetSelectedRows()[0];
            string palletCode = this.gv_PalletList.GetRowCellValue(currRow, "托盘条码").ToString();

            if (this.gv_GoodsList.GetSelectedRows() == null || this.gv_GoodsList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择物料！");
                return;
            }
            int currGsRow = this.gv_GoodsList.GetSelectedRows()[0];
            string goodsCode = this.gv_GoodsList.GetRowCellValue(currGsRow, "物料编码").ToString();

            this.presenter.AddTrayGoods(palletCode, (int)this.se_GoodsNum.Value,  goodsCode);
        }

        private void sb_DeleteGoods_Click(object sender, EventArgs e)
        {
            if (this.gv_PalletInfor.GetSelectedRows() == null || this.gv_PalletInfor.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "没有物料信息可以移除！");
                return;
            }
            int status = this.AskMessage("信息提示", "您确定要移除右侧【配盘物料信息】选中物料么？");
            if (status != 0)
            {
                return;
            }
            int currRow = this.gv_PalletInfor.GetSelectedRows()[0];
            string goodsCode = this.gv_PalletInfor.GetRowCellValue(currRow, "物料编码").ToString();
            if (goodsCode == "")
            {
                this.ShowMessage("信息提示", "物料编码错误！");

                return;
            }
            this.presenter.DeleteTrayGoods(goodsCode);
        }

        private void sb_PalletSure_Click(object sender, EventArgs e)
        {
            int status = this.AskMessage("信息提示", "您确定当前物料配盘？");
            if (status != 0)
            {
                return;
            }
            if (this.gv_PalletList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选中要配置的托盘！");
                return;
            }
            int currRow = this.gv_PalletList.GetSelectedRows()[0];
            string palletCode = this.gv_PalletList.GetRowCellValue(currRow, "托盘条码").ToString();
            string houseName = this.cbe_HouseList.Text.Trim();
            this.presenter.TrayConfirm(this.ce_IsFull.Checked, palletCode, this.cbe_PalletPos.Text);

        }

        private void sb_CancelPallet_Click(object sender, EventArgs e)
        {
            if (this.IWmsFrame.RoleLevel > 2)
            {
                this.ShowMessage("信息提示", "当前用户没有此操作权限！");
                return;
            }
            if (this.gv_PalletList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选中要取消的托盘！");
                return;
            }
            if (this.gv_PalletList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选中要取消的托盘！");
                return;
            }
            int status = this.AskMessage("信息提示", "您确定要取消当前选中配盘么？取消后将清空库存结束物料与托盘的绑定！！");
            if (status != 0)
            {
                return;
            }
            int currRow = this.gv_PalletList.GetSelectedRows()[0];
            string palletCode = this.gv_PalletList.GetRowCellValue(currRow, "托盘条码").ToString();
            
            this.presenter.CancelPallet(palletCode);
        }

        private void cbe_HouseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.presenter.IniTargetPos(this.cbe_HouseList.Text.Trim());
        }     
    }
}