using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS_Interface;
using DevExpress.XtraBars;
using WMS_Database;
using System.Drawing;

namespace WMS_Kernel
{
    public partial class WHStationView : ChildViewBase, IWHStationView
    {
        public WHStationPresenter presenter = null;
        private AddAndModifyWHStationView operStationLogicView = null;
        public WHStationView()
        {
            InitializeComponent();
            operStationLogicView = new AddAndModifyWHStationView();
            operStationLogicView.MyEvent += new AddAndModifyWHStationView.MyDelegate(RefreshStation);
        }

        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new WHStationPresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.stationLogic.ToBitmap();
            this.IWmsFrame.AddTitlePage("系统设置", ref restr);
            this.IWmsFrame.AddGroup("系统设置", "系统设置", ref restr);
            this.IWmsFrame.AddButtonItem("系统设置", "系统设置", "工位逻辑设置", bitmap, ShowTabEventHandler, ref restr);
        }

        #region 实现方法
        public void RefreshHouseListData(List<string> houseCodeList)
        {
            this.cbe_HouseList.Properties.Items.Clear();
            if (houseCodeList == null)
            {
                return;
            }
            foreach (string houseCode in houseCodeList)
            {
                this.cbe_HouseList.Properties.Items.Add(houseCode);
            }
            if (houseCodeList.Count > 0)
            {
                this.cbe_HouseList.SelectedIndex = 0;
            }

        }
        #endregion


        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            if (this.IWmsFrame.RoleLevel >1)
            {
                this.ShowMessage("信息提示", "当前用户没有此操作权限！");
                return;
            }
            this.IWmsFrame.ShowView(this, true);
        }

        private void StationListDataBind()
        {
            this.gc_StationList.DataBindings.Clear();
            this.gc_StationList.DataBindings.Add("DataSource", ViewDataManager.WHSTATIONVIEWDATA, "WHStationListData", false, DataSourceUpdateMode.OnPropertyChanged);
           
        }

        private void RefreshStation()
        {
            this.presenter.QueryStationList(this.cbe_HouseList.Text.Trim());
        }

        private void WHStationView_Load(object sender, EventArgs e)
        {
            this.presenter.InitHouseIDList();
            StationListDataBind();
            RefreshStation();
        }

        private void sb_QueryStation_Click(object sender, EventArgs e)
        {
         
        }

        private void sb_AddStation_Click(object sender, EventArgs e)
        {
            WHStation station = new WHStation();
            //station.WareHouseID = this.cbe_HouseList.Text.Trim();
            operStationLogicView.operateName = "添加";
            operStationLogicView.station = station;
            operStationLogicView.ShowDialog();
        }

        private void sb_DeleteStation_Click(object sender, EventArgs e)
        {
            if (this.AskMessage("信息提示", "您确定要删除选中工位逻辑么？") != 0)
            {
                return;

            }
            if (this.gv_StationList.GetSelectedRows() == null || this.gv_StationList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要删除的工位逻辑！");
                return;
            }
            int currRow = this.gv_StationList.GetSelectedRows()[0];
            string stationLogic = this.gv_StationList.GetRowCellValue(currRow, "工位逻辑编码").ToString();
            if (this.presenter.DeleteStationLogic(stationLogic))
            {
                this.ShowMessage("信息提示", "工位逻辑删除成功！");
            }
            else
            {
                this.ShowMessage("信息提示", "工位逻辑删除失败！");
            }
            RefreshStation();
        }

        private void sb_ModifyStation_Click(object sender, EventArgs e)
        {
             if (this.gv_StationList.GetSelectedRows() == null || this.gv_StationList.GetSelectedRows().Count() == 0)
             {
                 this.ShowMessage("信息提示", "请选择要修改的库房区域！");
                 return;
             }
             int currRow = this.gv_StationList.GetSelectedRows()[0];
             WHStation station = new WHStation();

             station.WHStationLogic = this.gv_StationList.GetRowCellValue(currRow, "工位逻辑编码").ToString();
             station.WHStationLogicName = this.gv_StationList.GetRowCellValue(currRow, "工位逻辑名称").ToString();
             station.WHStationLogicType = this.gv_StationList.GetRowCellValue(currRow, "工位逻辑类型").ToString();
             station.WareHouseID= this.gv_StationList.GetRowCellValue(currRow, "库房编码").ToString();
             station.WHCellID = this.gv_StationList.GetRowCellValue(currRow, "工位编码").ToString();
             operStationLogicView.operateName = "修改";
             operStationLogicView.station = station;
             operStationLogicView.ShowDialog();
        }

        private void sb_query_Click(object sender, EventArgs e)
        {
            RefreshStation();
        }
    }
}