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
    public partial class InWareWithPlanView : ChildViewBase,IInWareWithPlanView
    {
        InWareWithPlanPresenter presenter = null;
        public InWareWithPlanView()
        {
            InitializeComponent();
          
        }
        private void InWareWithPlanView_Load(object sender, EventArgs e)
        {
            BindGridData();
            this.presenter.Init();
            de_CreateTime.EditValue = DateTime.Now;
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            wmsFrame.SetTabChangeEvent(TabChangeEventHandler);
            this.presenter = new InWareWithPlanPresenter(this, wmsFrame);
            string restr = "";

            Bitmap bitmap = ImageResource.InWareWithPlan.ToBitmap();
            this.IWmsFrame.AddTitlePage("任务管理", ref restr);
            this.IWmsFrame.AddGroup("任务管理", "任务操作", ref restr);
            this.IWmsFrame.AddButtonItem("任务管理", "任务操作", "按计划配盘", bitmap, ShowTabEventHandler, ref restr);

            this.IWmsFrame.SetTabChangeEvent(TabChangeEventHandler);
        }
        private void TabChangeEventHandler(object sender, EventArgs e)
        {
            DevExpress.XtraTabbedMdi.MdiTabPageEventArgs tabEventArgs = e as DevExpress.XtraTabbedMdi.MdiTabPageEventArgs;
            if (tabEventArgs.Page == null)
            {
                return;
            }
            if (tabEventArgs.Page.Text == "按计划配盘")
            {
                this.presenter.IniPlanList();
            }
        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        //public void IniHouseName(List<WH_WareHouseModel> houseList)
        //{
        //    this.cbe_HouseName.Properties.Items.Clear();

        //    if(houseList == null)
        //    {
        //        return;
        //    }
        //   foreach(WH_WareHouseModel house in houseList)
        //   {
        //       this.cbe_HouseName.Properties.Items.Add(house.WareHouse_Name);
        //   }
        //    if(this.cbe_HouseName.Properties.Items.Count>0)
        //    {
        //        this.cbe_HouseName.SelectedIndex = 0;
        //    }
        //}
        public void IniPlanList(List<View_PlanMainModel> planList)
        {
            this.cbe_PlanID.Properties.Items.Clear();

            if (planList == null)
            {
                return;
            }
            foreach (View_PlanMainModel plan in planList)
            {
                this.cbe_PlanID.Properties.Items.Add(plan.Plan_Code);
            }
            if (this.cbe_PlanID.Properties.Items.Count > 0)
            {
                this.cbe_PlanID.SelectedIndex = 0;
            }
        }

        public void IniTargetPos(List<string> stationList)
        {
            this.cbe_TargetCell.Properties.Items.Clear();

            if (stationList == null)
            {
                return;
            }
            foreach (string cell in stationList)
            {
                this.cbe_TargetCell.Properties.Items.Add(cell);
            }
            if (this.cbe_TargetCell.Properties.Items.Count > 0)
            {
                this.cbe_TargetCell.SelectedIndex = 0;
            }
        }
    
        private void BindGridData()
        {
            this.gc_PlanList.DataBindings.Clear();
            this.gc_PlanList.DataBindings.Add("DataSource", ViewDataManager.PALLETWITHPLANDATA, "PlanListData", false, DataSourceUpdateMode.OnPropertyChanged);

            this.gc_TrayGoodsList.DataBindings.Clear();
            this.gc_TrayGoodsList.DataBindings.Add("DataSource", ViewDataManager.PALLETWITHPLANDATA, "TrayGoodsListData", false, DataSourceUpdateMode.OnPropertyChanged);

        }
       
        
     

        private void sBtn_Query_Click(object sender, EventArgs e)
        {
            if(this.cbe_PlanID.Text.Trim() == "")
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            this.presenter.QueryPlan(this.cbe_PlanID.Text.Trim());
        }
 

        private void sb_AddGoods_Click(object sender, EventArgs e)
        {
            if(this.gv_PlanList.GetSelectedRows() == null ||this.gv_PlanList.GetSelectedRows().Count()==0)
            {
                this.ShowMessage("信息提示", "请选择计划编号！");
                return;
            }
            int currRow = this.gv_PlanList.GetSelectedRows()[0];
            string goodsCode = this.gv_PlanList.GetRowCellValue(currRow, "物料编码").ToString();
            this.presenter.AddTrayGoods(this.te_TrayCode.Text, (int)this.se_GoodsNum.Value, this.de_CreateTime.DateTime, goodsCode);
        }
 
        private void sb_DeleteGoods_Click(object sender, EventArgs e)
        {   
            int currRow = this.gv_PlanList.GetSelectedRows()[0];
            string goodsCode = this.gv_PlanList.GetRowCellValue(currRow, "物料编码").ToString();
            if(goodsCode == "")
            {
                this.ShowMessage("信息提示","物料编码错误！");

                return ;
            }
            this.presenter.DeleteTrayGoods(goodsCode);
        }

        private void sb_TrayInput_Click(object sender, EventArgs e)
        {
            int status = this.AskMessage("信息提示", "您确定当前物料配盘？");
            if (status != 0)
            {
                return;
            }
            if (this.gv_PlanList.GetSelectedRows().Count() == 0)
            {
                return;
            }
            int currRow = this.gv_PlanList.GetSelectedRows()[0];
            string planListID = this.gv_PlanList.GetRowCellValue(currRow, "计划列表编码").ToString();

            this.presenter.TrayConfirm(planListID, this.ce_IsFull.Checked, this.te_TrayCode.Text, this.cbe_TargetCell.Text);
        }

        private void sb_ClearTrayData_Click(object sender, EventArgs e)
        {
            int status = this.AskMessage("信息提示", "您确定要清空配盘数据？");
            if(status!= 0)
            {
                return;
            }
            ViewDataManager.PALLETWITHPLANDATA.TrayGoodsListData.Clear();
        }

        //private void cbe_HouseName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.presenter.IniTargetPos(this.cbe_HouseName.Text.Trim());
        //}
  
 
      
    }
}