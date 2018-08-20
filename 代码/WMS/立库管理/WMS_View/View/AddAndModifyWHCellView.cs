using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS_Database;
using DevExpress.XtraEditors.Controls;
using WMS_Interface;

namespace WMS_Kernel
{
    public partial class AddAndModifyWHCellView: ChildViewBase,IAddAndModifyWHCellView
    {
        //定义委托
        public delegate void MyDelegate();

        //定义事件
        public event MyDelegate MyEvent;

        /// <summary>
        /// 操作名称
        /// </summary>
        public string operateName = "";

        public WHCell cell = null;
         

        public AddAndModifyWHCellPresenter presenter = null;
        public AddAndModifyWHCellView()
        {
            InitializeComponent();
            this.presenter = new AddAndModifyWHCellPresenter(this);
        }
         public void InitControl()
        {
            this.txtEdit_StationID.Text = "";
            this.txtEdit_CellName.Text = "";
            this.txtEdit_CellType.Text = "";
            this.te_StationCode.Text = "";
        }
        #region 实现方法
        public void ShowAreaIDList(List<string> areaIDList)
        {
            this.cb_AreaID.Properties.Items.Clear();
            if(areaIDList== null || areaIDList.Count == 0)
            {
                return;
            }
            for(int i = 0;i<areaIDList.Count;i++)
            {
                this.cb_AreaID.Properties.Items.Add(areaIDList[i]);
            }
            this.cb_AreaID.SelectedIndex = 0;

        }
        #endregion

      


        private void sb_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sb_Add_Click(object sender, EventArgs e)
        {
            if (this.txtEdit_StationID.Text == null || this.txtEdit_StationID.Text == "")
            {
                this.ShowMessage("信息提示", "请输入工位编码");
                return;
            }
            if(this.te_StationCode.Text =="")
            {
                this.ShowMessage("信息提示", "请输入工位编号");
                return;
            }
            if (this.txtEdit_CellType.Text == null || this.txtEdit_CellType.Text == "")
            {
                this.ShowMessage("信息提示", "请输入工位类型");
                return;
            }
            if (this.txtEdit_CellName.Text == null || this.txtEdit_CellName.Text == "")
            {
                this.ShowMessage("信息提示", "请输入工位名称");
                return;
            }
            if (this.cb_AreaID.SelectedIndex == -1)
            {
                this.ShowMessage("信息提示", "请选择库区编码");
                return;
            }

            if (this.cb_CellDirection.SelectedIndex == -1)
            {
                this.ShowMessage("信息提示", "请选择工位方向");
                return;
            }
            cell.AreaID = this.cb_AreaID.Text.Trim();
            cell.CellID = this.txtEdit_StationID.Text.Trim();
            cell.CellCode = this.te_StationCode.Text.Trim();
            cell.CellInOut = this.cb_CellDirection.Text.Trim();
            cell.CellName = this.txtEdit_CellName.Text;
            cell.CellType = this.txtEdit_CellType.Text;
            cell.DeviceCode = cell.CellCode;
            if (this.operateName == "添加")
            {
                if (this.presenter.AddCellModel(cell))
                {
                    this.ShowMessage("信息提示", "库房工位添加成功");
                }
                else
                {
                    this.ShowMessage("信息提示", "库房工位添加失败");
                }
            }
            else
            {
                if (this.presenter.ModifyCellModel(cell))
                {
                    this.ShowMessage("信息提示", "库房工位修改成功");
                }
                else
                {
                    this.ShowMessage("信息提示", "不存在此工位编号："+cell.CellID+",库房工位修改失败");
                }

            }
            if (MyEvent != null)
            {
                MyEvent();//引发事件
            }
        }

     

        private void AddAndModifyCellView_Load(object sender, EventArgs e)
        {
            if (this.operateName == "添加")
            {
                this.cb_CellDirection.Properties.Items.Clear();
                this.cb_CellDirection.Properties.Items.Add("出入");
                this.cb_CellDirection.Properties.Items.Add("入");
                this.cb_CellDirection.Properties.Items.Add("出");
                this.cb_CellDirection.SelectedIndex = 0;
                this.presenter.RefreshAreaIDList();
                this.Text = "添加工位";
                this.sb_Add.Text = "添加";
            }
            else
            {
                this.cb_CellDirection.Properties.Items.Clear();
                this.cb_CellDirection.Properties.Items.Add("出入");
                this.cb_CellDirection.Properties.Items.Add("入");
                this.cb_CellDirection.Properties.Items.Add("出");
                this.txtEdit_CellType.Text = cell.CellType;
                this.txtEdit_CellName.Text = cell.CellName;
                this.txtEdit_StationID.Text = cell.CellID;
                this.cb_CellDirection.Text = cell.CellInOut;
                this.te_StationCode.Text = cell.CellCode;
                this.cb_AreaID.Text = cell.AreaID;
                this.presenter.RefreshAreaIDList();
                this.Text = "修改工位";
                this.sb_Add.Text = "修改";
            }
        }

    }
}