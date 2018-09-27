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
    public partial class WHManaView : ChildViewBase, IWHManaView
    {
        public WHManaPresenter presenter = null;
        private AddAndModifyWHHouseView operHouseView = null;
        public WHManaView()
        {
            InitializeComponent();
            operHouseView = new AddAndModifyWHHouseView();
            operHouseView.MyEvent += new AddAndModifyWHHouseView.MyDelegate(RefreshHouse);
        }
       
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new WHManaPresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.house.ToBitmap();
            this.IWmsFrame.AddTitlePage("系统设置", ref restr);
            this.IWmsFrame.AddGroup("系统设置", "系统设置", ref restr);
            this.IWmsFrame.AddButtonItem("系统设置", "系统设置", "库房设置", bitmap, ShowTabEventHandler, ref restr);
        }

        #region 实现方法
      
        #endregion


        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            if (this.IWmsFrame.RoleLevel > 1)
            {
                this.ShowMessage("信息提示", "当前用户没有此操作权限！");
                return;
            }
            this.IWmsFrame.ShowView(this, true);
        }

        private void HouseListDataBind()
        {
            this.gc_WHList.DataBindings.Clear();
            this.gc_WHList.DataBindings.Add("DataSource", ViewDataManager.WHVIEWDATA, "WHListData", false, DataSourceUpdateMode.OnPropertyChanged);
           
        }

        private void RefreshHouse()
        {
            this.presenter.QueryWHList();
        }


        private void WHManaView_Load(object sender, EventArgs e)
        {
            HouseListDataBind();
            RefreshHouse();
        }

        private void sb_AddWH_Click(object sender, EventArgs e)
        {
            WHHouse house = new WHHouse();
            operHouseView.operateName = "添加";
            operHouseView.house = house;
            operHouseView.ShowDialog();
        }

        private void sb_DeleteWH_Click(object sender, EventArgs e)
        {
            if (this.AskMessage("信息提示", "您确定要删除选中库房么？") != 0)
            {
                return;

            }
            if (this.gv_WHList.GetSelectedRows() == null || this.gv_WHList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要删除的库房！");
                return;
            }
            int currRow = this.gv_WHList.GetSelectedRows()[0];
            string houseID = this.gv_WHList.GetRowCellValue(currRow, "库房编号").ToString();
            if (this.presenter.DeleteWareHouse(houseID))
            {
                this.ShowMessage("信息提示", "库房删除成功！");
            }
            else
            {
                this.ShowMessage("信息提示", "库房删除失败！");
            }
            RefreshHouse();
        }

        private void sb_ModifyWH_Click(object sender, EventArgs e)
        {
            if (this.gv_WHList.GetSelectedRows() == null || this.gv_WHList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择要修改的库房！");
                return;
            }
            int currRow = this.gv_WHList.GetSelectedRows()[0];
            WHHouse house = new WHHouse();
            house.WareHouse_ID = this.gv_WHList.GetRowCellValue(currRow, "库房编号").ToString();
            house.WareHouse_Code = this.gv_WHList.GetRowCellValue(currRow, "库房编码").ToString();
            house.WareHouse_Name = this.gv_WHList.GetRowCellValue(currRow, "库房名称").ToString();
            house.WareHouse_Type = this.gv_WHList.GetRowCellValue(currRow, "库房类型").ToString();
            house.WareHouse_Flag = this.gv_WHList.GetRowCellValue(currRow, "库房启用").ToString();
            house.WareHouse_Remark = this.gv_WHList.GetRowCellValue(currRow, "库房备注").ToString();

            operHouseView.operateName = "修改";
            operHouseView.house = house;
            operHouseView.ShowDialog();
        }
    }
}