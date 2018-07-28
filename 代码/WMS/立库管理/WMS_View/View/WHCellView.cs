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
    public partial class WHCellView : ChildViewBase, IWHCellView
    {
        public WHCellPresenter presenter = null;
        private AddAndModifyWHCellView operCellView = null;
        public WHCellView()
        {
            InitializeComponent();
            operCellView = new AddAndModifyWHCellView();
            operCellView.MyEvent += new AddAndModifyWHCellView.MyDelegate(RefreshCell);
        }
       
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new WHCellPresenter(this, wmsFrame);
            this.presenter.Init();
            string restr = "";

            Bitmap bitmap = ImageResource.cell.ToBitmap();
            this.IWmsFrame.AddTitlePage("系统设置", ref restr);
            this.IWmsFrame.AddGroup("系统设置", "系统设置", ref restr);
            this.IWmsFrame.AddButtonItem("系统设置", "系统设置", "工位设置", bitmap, ShowTabEventHandler, ref restr);
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

        private void CellListDataBind()
        {
            this.gc_CellList.DataBindings.Clear();
            this.gc_CellList.DataBindings.Add("DataSource", ViewDataManager.WHCELLVIEWDATA, "WHCellListData", false, DataSourceUpdateMode.OnPropertyChanged);
           
        }

        private void RefreshCell()
        {
            this.presenter.QueryCellList();
        }
        //private void sb_DeleteArea_Click(object sender, EventArgs e)
        //{
        //    if (this.AskMessage("信息提示", "您确定要删除选中库房区域么？") != 0)
        //    {
        //        return;

        //    }
         
          
        //    if (this.gv_CellList.GetSelectedRows() == null || this.gv_CellList.GetSelectedRows().Count() == 0)
        //    {
        //        this.ShowMessage("信息提示", "请选择要删除的库房区域！");
        //        return;
        //    }
        //    int currRow = this.gv_CellList.GetSelectedRows()[0];
        //    string areaID = this.gv_CellList.GetRowCellValue(currRow, "区域编号").ToString();
        //    string areaName = this.gv_CellList.GetRowCellValue(currRow, "区域名称").ToString();
        //    if(areaName == "默认库区")
        //    {
        //        this.ShowMessage("信息提示", "默认库区，不允许删除！");
        //        return;
        //    }
        //    if (this.presenter.DeleteArea(areaID))
        //    {
        //        this.ShowMessage("信息提示", "库房区域删除成功！");
        //    }
        //    else
        //    {
        //        this.ShowMessage("信息提示", "库房区域删除失败！");
        //    }
        //    RefreshArea();
        //}

        //private void sb_AddArea_Click(object sender, EventArgs e)
        //{
        //    WareArea area = new WareArea();
        //    area.WareHouseName = this.cb_CellType.Text.Trim();
        //    operAreaView.operateName = "添加";
        //    operAreaView.area = area;
        //    operAreaView.ShowDialog();
        //}

       




        private void sb_QueryCell_Click(object sender, EventArgs e)
        {
            RefreshCell();
        }

        private void sb_AddCell_Click(object sender, EventArgs e)
        {
            WHCell cell = new WHCell();
            //cell.CellType = this.txtEdit_CellType.Text.Trim();
            operCellView.InitControl();
            operCellView.operateName = "添加";
            operCellView.cell = cell;
            operCellView.ShowDialog();

        }

        private void sb_DeleteCell_Click(object sender, EventArgs e)
        {
             if (this.AskMessage("信息提示", "您确定要删除选中库房工位么？") != 0)
             {
                 return;

             }
             if (this.gv_CellList.GetSelectedRows() == null || this.gv_CellList.GetSelectedRows().Count() == 0)
             {
                 this.ShowMessage("信息提示", "请选择要删除的库房工位！");
                 return;
             }
             int currRow = this.gv_CellList.GetSelectedRows()[0];
             string cellID = this.gv_CellList.GetRowCellValue(currRow, "工位编号").ToString();
             if (this.presenter.DeleteCell(cellID))
             {
                 this.ShowMessage("信息提示", "库房工位删除成功！");
             }
             else
             {
                 this.ShowMessage("信息提示", "库房工位删除失败！");
             }
             RefreshCell();
        }

        private void sb_ModifyCell_Click(object sender, EventArgs e)
        {
             if (this.gv_CellList.GetSelectedRows() == null || this.gv_CellList.GetSelectedRows().Count() == 0)
             {
                 this.ShowMessage("信息提示", "请选择要修改的库房区域！");
                 return;
             }
             int currRow = this.gv_CellList.GetSelectedRows()[0];
             WHCell cell = new WHCell();
             cell.CellID= this.gv_CellList.GetRowCellValue(currRow, "工位编号").ToString();
             cell.AreaID = this.gv_CellList.GetRowCellValue(currRow, "库区编码").ToString();
             cell.CellCode = this.gv_CellList.GetRowCellValue(currRow, "工位编码").ToString();
             cell.CellName= this.gv_CellList.GetRowCellValue(currRow, "工位名称").ToString();
             cell.DeviceCode = this.gv_CellList.GetRowCellValue(currRow, "设备编码").ToString();
             cell.CellInOut = this.gv_CellList.GetRowCellValue(currRow, "工位方向").ToString();
             cell.CellType = this.gv_CellList.GetRowCellValue(currRow, "工位类型").ToString();

             operCellView.operateName = "修改";
             operCellView.cell = cell;
             operCellView.ShowDialog();
        }

        private void WHCellView_Load(object sender, EventArgs e)
        {
            CellListDataBind();
            RefreshCell();
        }
    }
}