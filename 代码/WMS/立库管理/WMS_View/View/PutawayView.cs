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
    public partial class PutawayView : ChildViewBase,IPutawayView
    {
        PutawayPresenter presenter = null;
        public PutawayView()
        {
            InitializeComponent();
           

        }
        private void PutawayView_Load(object sender, EventArgs e)
        {
            DataBingding();
            this.presenter.Init();
        }
        
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            wmsFrame.SetTabChangeEvent(TabChangeEventHandler);
            this.presenter = new PutawayPresenter(this,wmsFrame);
            string restr = "";

            Bitmap bitmap = ImageResource.MaterialUnload.ToBitmap();
            this.IWmsFrame.AddTitlePage("任务管理", ref restr);
            this.IWmsFrame.AddGroup("任务管理", "任务操作", ref restr);
            this.IWmsFrame.AddButtonItem("任务管理", "任务操作", "上架管理", bitmap, ShowTabEventHandler, ref restr);
        }
        private void TabChangeEventHandler(object sender, EventArgs e)
        {
            DevExpress.XtraTabbedMdi.MdiTabPageEventArgs tabEventArgs = e as DevExpress.XtraTabbedMdi.MdiTabPageEventArgs;
            if(tabEventArgs.Page == null)
            {
                return;
            }
            if (tabEventArgs.Page.Text == "上架管理")
            {
                
            }
        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }



        private void DataBingding()
        {

            this.gc_PalletInfor.DataBindings.Clear();
            this.gc_PalletInfor.DataBindings.Add("DataSource", ViewDataManager.PUTAWAYVIEWDATA, "PalletInforData", false, DataSourceUpdateMode.OnPropertyChanged);

        }
        public void IniHouseName(List<WH_WareHouseModel> houseList)
        {
            this.cbe_HouseName.Properties.Items.Clear();

            if (houseList == null)
            {
                return;
            }
            foreach (WH_WareHouseModel house in houseList)
            {
                this.cbe_HouseName.Properties.Items.Add(house.WareHouse_Name);
            }
            if (this.cbe_HouseName.Properties.Items.Count > 0)
            {
                this.cbe_HouseName.SelectedIndex = 0;
            }
        }
        public void IniPutawayList(List<string>  cellList)
        {
            this.cbe_StartStation.Properties.Items.Clear();

            if (cellList == null)
            {
                return;
            }
            foreach (string cell in cellList)
            {
                this.cbe_StartStation.Properties.Items.Add(cell);
            }
            if (this.cbe_StartStation.Properties.Items.Count > 0)
            {
                this.cbe_StartStation.SelectedIndex = 0;
            }
        }

        public void IniCellList(List<View_CellModel> cellList)
        {
            this.cbe_TargetStation.Properties.Items.Clear();
            this.cbe_TargetStation.Text = "";
            if (cellList == null)
            {
                return;
            }
            foreach (View_CellModel cell in cellList)
            {
                //if (cell.Shelf_Type == EnumShelfType.双深.ToString())
                //{
                    this.cbe_TargetStation.Properties.Items.Add(cell.Cell_Name +"-"+cell.Cell_Chlid_Position);
                //}
                //else
                //{
                //    this.cbe_TargetStation.Properties.Items.Add(cell.Cell_Name);
                //}
               
            }
            if (this.cbe_TargetStation.Properties.Items.Count > 0)
            {
                this.cbe_TargetStation.SelectedIndex = 0;
            }
        }
    
   

        private void sb_InputTask_Click(object sender, EventArgs e)
        {
            int status = this.AskMessage("信息提示", "您确定上架当前选中托盘么？");
            if (status != 0)
            {
                return;
            }

            this.presenter.PutawayTask(this.te_PalletCode.Text.Trim(),this.cbe_HouseName.Text.Trim(), this.cbe_StartStation.Text.Trim(), 
                this.ce_CheckPos.Checked, this.cbe_TargetStation.Text.Trim(),this.ce_IsNullPallet.Checked);
        }

        private void sb_TrayQuery_Click(object sender, EventArgs e)
        {
            this.presenter.QueryPalletInfor(this.te_PalletCode.Text.Trim());
        }

        private void ce_CheckPos_CheckedChanged(object sender, EventArgs e)
        {
            if(this.ce_CheckPos.Checked == true)
            {
                this.cbe_TargetStation.Enabled = true;
            }
            else
            {
                this.cbe_TargetStation.Enabled = false;
            }
        }

        private void cbe_StartStation_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void cbe_HouseName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            this.presenter.IniCellList(this.cbe_HouseName.Text.Trim());
        }

       
    }
}