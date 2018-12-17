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
    public partial class StockAdjustView : ChildViewBase, IStockAdjustView
    {
        StockAdjustPresenter presenter = null;
        private string childCellID = "";
        public StockAdjustView(string childCellID)
        {
            InitializeComponent();
            this.childCellID = childCellID;
          
        }
        private void StockAdjustView_Load(object sender, EventArgs e)
        {
            BindGridData();
            this.presenter.Init();
            this.presenter.LoadStock(this.childCellID);
            //de_CreateTime.EditValue = DateTime.Now;
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            //wmsFrame.SetTabChangeEvent(TabChangeEventHandler);
            this.presenter = new StockAdjustPresenter(this, wmsFrame);
            //string restr = "";

            //Bitmap bitmap = ImageResource.PalletWithoutPlan.ToBitmap();
            //this.IWmsFrame.AddTitlePage("任务管理", ref restr);
            //this.IWmsFrame.AddGroup("任务管理", "无计划任务", ref restr);
            //this.IWmsFrame.AddButtonItem("任务管理", "无计划任务", "无计划配盘", bitmap, ShowTabEventHandler, ref restr);

            //this.IWmsFrame.SetTabChangeEvent(TabChangeEventHandler);
        }

        //public void IniHouseName(List<WH_WareHouseModel> houseList)
        //{
        //    this.cbe_HouseName.Properties.Items.Clear();

        //    if (houseList == null)
        //    {
        //        return;
        //    }
        //    foreach (WH_WareHouseModel house in houseList)
        //    {
        //        this.cbe_HouseName.Properties.Items.Add(house.WareHouse_Name);
        //    }
        //    if (this.cbe_HouseName.Properties.Items.Count > 0)
        //    {
        //        this.cbe_HouseName.SelectedIndex = 0;
        //    }
        //}
 

        //public void IniTargetPos(List<string> stationList)
        //{
        //    this.cbe_TargetCell.Properties.Items.Clear();

        //    if (stationList == null)
        //    {
        //        return;
        //    }
        //    foreach (string cell in stationList)
        //    {
        //        this.cbe_TargetCell.Properties.Items.Add(cell);
        //    }
        //    if (this.cbe_TargetCell.Properties.Items.Count > 0)
        //    {
        //        this.cbe_TargetCell.SelectedIndex = 0;
        //    }
        //}
        //private void TabChangeEventHandler(object sender, EventArgs e)
        //{
        //    DevExpress.XtraTabbedMdi.MdiTabPageEventArgs tabEventArgs = e as DevExpress.XtraTabbedMdi.MdiTabPageEventArgs;
        //    if (tabEventArgs.Page == null)
        //    {
        //        return;
        //    }
        //    if (tabEventArgs.Page.Text == "无计划配盘")
        //    {
                 
        //    }
        //}
        //private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        //{
        //    this.IWmsFrame.ShowView(this, true);
        //}

        //public void IniHouseName(List<WH_WareHouseModel> houseList)
        //{
        //    this.cbe_HouseName.Properties.Items.Clear();

        //    if (houseList == null)
        //    {
        //        return;
        //    }
        //    foreach (WH_WareHouseModel house in houseList)
        //    {
        //        this.cbe_HouseName.Properties.Items.Add(house.WareHouse_Name);
        //    }
        //    if (this.cbe_HouseName.Properties.Items.Count > 0)
        //    {
        //        this.cbe_HouseName.SelectedIndex = 0;
        //    }
        //}
        //public void IniPlanList(List<View_PlanMainModel> planList)
        //{
        //    this.cbe_PlanID.Properties.Items.Clear();

        //    if (planList == null)
        //    {
        //        return;
        //    }
        //    foreach (View_PlanMainModel plan in planList)
        //    {
        //        this.cbe_PlanID.Properties.Items.Add(plan.Plan_Code);
        //    }
        //    if (this.cbe_PlanID.Properties.Items.Count > 0)
        //    {
        //        this.cbe_PlanID.SelectedIndex = 0;
        //    }
        //}

        //public void IniTargetPos(List<string> stationList)
        //{
        //    this.cbe_TargetCell.Properties.Items.Clear();

        //    if (stationList == null)
        //    {
        //        return;
        //    }
        //    foreach (string cell in stationList)
        //    {
        //        this.cbe_TargetCell.Properties.Items.Add(cell);
        //    }
        //    if (this.cbe_TargetCell.Properties.Items.Count > 0)
        //    {
        //        this.cbe_TargetCell.SelectedIndex = 0;
        //    }
        //}
    
        private void BindGridData()
        {
            this.gc_MaterialList.DataBindings.Clear();
            this.gc_MaterialList.DataBindings.Add("DataSource", ViewDataManager.STOCKADJUSTVIEWDATA, "PalletGoodsData", false, DataSourceUpdateMode.OnPropertyChanged);

            this.gc_TrayGoodsList.DataBindings.Clear();
            this.gc_TrayGoodsList.DataBindings.Add("DataSource", ViewDataManager.STOCKADJUSTVIEWDATA, "PalletInforData", false, DataSourceUpdateMode.OnPropertyChanged);

        }
       
        
     

        private void sBtn_Query_Click(object sender, EventArgs e)
        {
            
            this.presenter.QueryPlan(this.txtEdit_MaterialInfo.Text);
        }


        private void sb_AddGoods_Click(object sender, EventArgs e)
        {
            if (this.gv_MaterialList.GetSelectedRows() == null || this.gv_MaterialList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择物料编号！");
                return;
            }
            int currRow = this.gv_MaterialList.GetSelectedRows()[0];
            string goodsCode = this.gv_MaterialList.GetRowCellValue(currRow, "物料编码").ToString();
            string planCode = "-1";//无计划
            
            this.presenter.AddTrayGoods(this.te_TrayCode.Text,this.se_GoodsNum.Value.ToString(), goodsCode, planCode);
        }
 
        private void sb_DeleteGoods_Click(object sender, EventArgs e)
        {
            if (this.gv_TrayGoods.GetSelectedRows() == null || this.gv_TrayGoods.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择物料编号！");
                return;
            }
            int currRow = this.gv_TrayGoods.GetSelectedRows()[0];
            string goodsCode = this.gv_TrayGoods.GetRowCellValue(currRow, "物料编码").ToString();
            if(goodsCode == "")
            {
                this.ShowMessage("信息提示","物料编码错误！");

                return ;
            }
            string palletCode = this.gv_TrayGoods.GetRowCellValue(currRow, "托盘条码").ToString();
            if (palletCode == "")
            {
                this.ShowMessage("信息提示", "托盘条码错误！");

                return;
            }
            this.presenter.DeleteTrayGoods(palletCode,goodsCode);
        }

        private void sb_TrayInput_Click(object sender, EventArgs e)
        {
           
        }

        //private void sb_ClearTrayData_Click(object sender, EventArgs e)
        //{
        //    int status = this.AskMessage("信息提示", "您确定要清空配盘数据？");
        //    if(status!= 0)
        //    {
        //        return;
        //    }
        //    ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData.Clear();
        //}

        private void sb_sure_Click(object sender, EventArgs e)
        {
            int status = this.AskMessage("信息提示", "您确定当前物料配盘？");
            if (status != 0)
            {
                return;
            }
         
            //int currRow = this.gv_MaterialList.GetSelectedRows()[0];

            this.presenter.TrayConfirm(this.childCellID);
        }

        private void sb_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
 
      
    }
}