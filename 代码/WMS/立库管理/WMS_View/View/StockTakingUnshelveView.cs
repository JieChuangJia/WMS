using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public partial class StockTakingUnshelveView : ChildViewBase,IStockTakingUnshelveView
    {
        StockTakingUnshelvePresenter presenter = null;
        public StockTakingUnshelveView()
        {
            InitializeComponent();
        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new StockTakingUnshelvePresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            //Bitmap bitmap = ImageResource.code_class.ToBitmap();
            //this.IWmsFrame.AddTitlePage("任务管理", ref restr);
            //this.IWmsFrame.AddGroup("任务管理", "任务操作", ref restr);
            //this.IWmsFrame.AddButtonItem("任务管理", "任务操作", "盘点下架", bitmap, ShowTabEventHandler, ref restr);

            
        }

        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        public void InitPosTypeList(List<string> posList)
        {

            if (posList == null)
            {
                return;
            }
            this.cbe_PosTypeList.Properties.Items.Clear();
            foreach (string pos in posList)
            {
                this.cbe_PosTypeList.Properties.Items.Add(pos);
            }
            if (posList.Count > 0)
            {
                this.cbe_PosTypeList.SelectedIndex = 0;
            }

        }
    
        public void RefreshHouseListData(List<WH_WareHouseModel> houseList)
        {
            this.cbe_HouseList.Properties.Items.Clear();
            if (houseList == null)
            {
                return;
            }
            foreach (WH_WareHouseModel house in houseList)
            {
                this.cbe_HouseList.Properties.Items.Add(house.WareHouse_Name);
            }
            if (houseList.Count > 0)
            {
                this.cbe_HouseList.SelectedIndex = 0;
            }

        }

        private void rb_CellStockTaking_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rb_CellStockTaking.Checked == true)
            {
                EnabledControl(true, false);
            }
            else
            {
                EnabledControl(false, true);
            }
         
        }
        private void EnabledControl(bool cellCtrlEnabled,bool gsCtrlEnabled)
        {
            this.lc_gs.Enabled = cellCtrlEnabled;
            this.lc_House.Enabled = cellCtrlEnabled;
            this.lc_pos.Enabled = cellCtrlEnabled;

            this.cbe_HouseList.Enabled = cellCtrlEnabled;
            this.cbe_PosTypeList.Enabled = cellCtrlEnabled;
            this.te_CellName.Enabled = cellCtrlEnabled;


            this.lc_goods.Enabled = gsCtrlEnabled;
            this.te_MaterialInfo.Enabled = gsCtrlEnabled;
        }
        private void rb_goodsStockTaking_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
