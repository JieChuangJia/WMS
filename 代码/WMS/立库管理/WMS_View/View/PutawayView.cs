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
            this.presenter.IniPutawayPalletCode();
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
                this.presenter.IniPutawayPalletCode();
            }
        }
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }

        public void IniPalletCode(List<string> palletCode)
        {
            this.ce_PalletCode.Properties.Items.Clear();

            if (palletCode == null)
            {
                return;
            }
            foreach (string pallet in palletCode)
            {
                this.ce_PalletCode.Properties.Items.Add(pallet);
            }
            if (this.ce_PalletCode.Properties.Items.Count > 0)
            {
                this.ce_PalletCode.SelectedIndex = 0;
            }
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
        public void IniRows(List<string> rows)
        {
            this.cbe_Row.Properties.Items.Clear();

            if (rows == null)
            {
                return;
            }
            foreach (string cell in rows)
            {
                this.cbe_Row.Properties.Items.Add(cell);
            }
            if (this.cbe_Row.Properties.Items.Count > 0)
            {
                this.cbe_Row.SelectedIndex = 0;
            }
        }
        public void IniCols(List<string> cols)
        {
            this.cbe_Col.Properties.Items.Clear();

            if (cols == null)
            {
                return;
            }
            foreach (string cell in cols)
            {
                this.cbe_Col.Properties.Items.Add(cell);
            }
            if (this.cbe_Col.Properties.Items.Count > 0)
            {
                this.cbe_Col.SelectedIndex = 0;
            }
        }
        public void IniLayers(List<string> layers)
        {
            this.cbe_Layer.Properties.Items.Clear();

            if (layers == null)
            {
                return;
            }
            foreach (string cell in layers)
            {
                this.cbe_Layer.Properties.Items.Add(cell);
            }
            if (this.cbe_Layer.Properties.Items.Count > 0)
            {
                this.cbe_Layer.SelectedIndex = 0;
            }
        }
        public void IniPoses(List<string> poses)
        {
            this.cbe_Pos.Properties.Items.Clear();

            if (poses == null)
            {
                return;
            }
            foreach (string cell in poses)
            {
                this.cbe_Pos.Properties.Items.Add(cell);
            }
            if (this.cbe_Pos.Properties.Items.Count > 0)
            {
                this.cbe_Pos.SelectedIndex = 0;
            }
        }
        public void IniCellList(List<View_CellModel> cellList)
        {
            this.cbe_Row.Properties.Items.Clear();
            this.cbe_Row.Text = "";
            if (cellList == null)
            {
                return;
            }
            foreach (View_CellModel cell in cellList)
            {
                //if (cell.Shelf_Type == EnumShelfType.双深.ToString())
                //{
                    this.cbe_Row.Properties.Items.Add(cell.Cell_Name +"-"+cell.Cell_Chlid_Position);
                //}
                //else
                //{
                //    this.cbe_TargetStation.Properties.Items.Add(cell.Cell_Name);
                //}
               
            }
            if (this.cbe_Row.Properties.Items.Count > 0)
            {
                this.cbe_Row.SelectedIndex = 0;
            }
        }
    
   

        private void sb_InputTask_Click(object sender, EventArgs e)
        {
            int status = this.AskMessage("信息提示", "您确定上架当前选中托盘么？");
            if (status != 0)
            {
                return;
            }

            this.presenter.PutawayTask(this.ce_PalletCode.Text.Trim(),this.cbe_HouseName.Text.Trim(), this.cbe_StartStation.Text.Trim(), 
                this.ce_CheckPos.Checked, this.cbe_Row.Text.Trim(),this.cbe_Col.Text.Trim(),this.cbe_Layer.Text.Trim(),this.cbe_Pos.Text.Trim());
        }

        private void sb_TrayQuery_Click(object sender, EventArgs e)
        {
            this.presenter.QueryPalletInfor(this.ce_PalletCode.Text.Trim());
        }

        private void ce_CheckPos_CheckedChanged(object sender, EventArgs e)
        {
            if(this.ce_CheckPos.Checked == true)
            {
                this.cbe_Row.Enabled = true;
                this.cbe_Col.Enabled = true;
                this.cbe_Layer.Enabled = true;
                this.cbe_Pos.Enabled = true;
                this.lc_Col.Enabled = true;
                this.lc_layer.Enabled = true;
                this.lc_Pos.Enabled = true;
                this.lc_row.Enabled = true;
            }
            else
            {
                this.cbe_Row.Enabled = false;
                this.cbe_Col.Enabled = false;
                this.cbe_Layer.Enabled = false;
                this.cbe_Pos.Enabled = false;

                this.lc_Col.Enabled = false;
                this.lc_layer.Enabled = false;
                this.lc_Pos.Enabled = false;
                this.lc_row.Enabled = false;
            }
        }

        private void cbe_StartStation_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void cbe_HouseName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            this.presenter.IniRows(this.cbe_HouseName.Text.Trim());
        }

        private void cbe_Row_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbe_Row.Text.Trim() == "")
            {
                //this.ShowMessage("信息提示","行不能为空");
                return;
            }
            int rowth = int.Parse(this.cbe_Row.Text.Trim());

            this.presenter.IniCols(this.cbe_HouseName.Text.Trim(), rowth);
        }

        private void cbe_Col_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbe_Row.Text.Trim() == "")
            {
                this.ShowMessage("信息提示", "行不能为空");
                return;
            }
            if (this.cbe_Col.Text.Trim() == "")
            {
                this.ShowMessage("信息提示", "列不能为空");
                return;
            }
            int rowth =  int.Parse(this.cbe_Row.Text.Trim());
            int colth = int.Parse(this.cbe_Col.Text.Trim());
            this.presenter.IniLayers(this.cbe_HouseName.Text.Trim(), rowth, colth);
        }

        private void cbe_Layer_SelectedIndexChanged(object sender, EventArgs e)
        {   if (this.cbe_Row.Text.Trim() == "")
            {
                this.ShowMessage("信息提示", "行不能为空");
                return;
            }
            if (this.cbe_Col.Text.Trim() == "")
            {
                this.ShowMessage("信息提示", "列不能为空");
                return;
            }
            if (this.cbe_Layer.Text.Trim() == "")
            {
                this.ShowMessage("信息提示", "层不能为空");
                return;
            }
            int rowth =  int.Parse(this.cbe_Row.Text.Trim());
            int colth = int.Parse(this.cbe_Col.Text.Trim());
            int layerth = int.Parse(this.cbe_Layer.Text.Trim());
            this.presenter.IniLayers(this.cbe_HouseName.Text.Trim(), rowth, colth, layerth);
        }

       
    }
}