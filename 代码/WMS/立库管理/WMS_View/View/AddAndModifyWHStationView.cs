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
    public partial class AddAndModifyWHStationView: ChildViewBase,IAddAndModifyWHStationView
    {
        //定义委托
        public delegate void MyDelegate();

        //定义事件
        public event MyDelegate MyEvent;

        /// <summary>
        /// 操作名称
        /// </summary>
        public string operateName = "";

        public WHStation station = null;
         

        public AddAndModifyWHStationPresenter presenter = null;
        public AddAndModifyWHStationView()
        {
            InitializeComponent();
            this.presenter = new AddAndModifyWHStationPresenter(this,this.IWmsFrame);
        }
        
        #region 实现方法
        public void ShowWareHouseCodeList(List<string> wareHouseCodeList)
        {
            this.cb_WareCode.Properties.Items.Clear();
            if (wareHouseCodeList == null)
            {
                return;
            }
            foreach (string houseCode in wareHouseCodeList)
            {
                this.cb_WareCode.Properties.Items.Add(houseCode);
            }
            if (wareHouseCodeList.Count > 0)
            {
                this.cb_WareCode.SelectedIndex = 0;
            }
        }

        public void ShowStationIDList(List<string> items)
        {
            this.cbe_StationID.Properties.Items.Clear();
            if(items == null)
            {
                return;
            }
            foreach(string item in items)
            {
                this.cbe_StationID.Properties.Items.Add(item);
            }
            if(this.cbe_StationID.Properties.Items.Count>0)
            {
                this.cbe_StationID.SelectedIndex = 0;
            }
        }
        public void ShowStationTypeList(List<string> items)
        {
            this.cbe_StaionLogicCate.Properties.Items.Clear();
            if (items == null)
            {
                return;
            }
            foreach (string item in items)
            {
                this.cbe_StaionLogicCate.Properties.Items.Add(item);
            }
            if (this.cbe_StaionLogicCate.Properties.Items.Count > 0)
            {
                this.cbe_StaionLogicCate.SelectedIndex = 0;
            }
        }
        
        #endregion
 



        private void sb_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sb_Add_Click(object sender, EventArgs e)
        {
            if (this.cbe_StationID.Text == null || this.cbe_StationID.Text == "")
            {
                this.ShowMessage("信息提示", "请输入工位编码");
                return;
            }
            if (this.cb_WareCode.SelectedIndex == -1)
            {
                this.ShowMessage("信息提示", "请选择库房编码");
                return;
            }
            if (this.cbe_StaionLogicCate.Text == null || this.cbe_StaionLogicCate.Text == "")
            {
                this.ShowMessage("信息提示", "请输入工位逻辑类型");
                return;
            }
            if (this.txtEdit_StationLogicName.Text == null || this.txtEdit_StationLogicName.Text == "")
            {
                this.ShowMessage("信息提示", "请输入工位逻辑名称");
                return;
            }
            string oldCellID = station.WHCellID;
            station.WareHouseID = this.cb_WareCode.Text;
            station.WHCellID = this.cbe_StationID.Text;
            station.WHStationLogicName = this.txtEdit_StationLogicName.Text;
            station.WHStationLogicType = this.cbe_StaionLogicCate.Text;
           
            if (this.operateName == "添加")
            {
                if (this.presenter.IsSaveSameName(station))
                {
                    this.ShowMessage("信息提示", "该工位逻辑名称已经存在数据库中，请重新输入！");
                    return;
                }

                //需要给areaID赋值
                if (this.presenter.AddStationModel(station))
                {
                    this.ShowMessage("信息提示", "库房工位逻辑添加成功");
                }
                else
                {
                    this.ShowMessage("信息提示", "库房工位逻辑添加失败");
                }
            }
            else
            {
                if (this.presenter.ModifyStationModel(oldCellID,station))
                {
                    this.ShowMessage("信息提示", "库房工位逻辑修改成功");
                }
                else
                {
                    this.ShowMessage("信息提示", "库房工位逻辑修改失败");
                }

            }
            if (MyEvent != null)
            {
                MyEvent();//引发事件
            }
        }

        private void AddAndModifyAreaView_Load(object sender, EventArgs e)
        {
            this.presenter.Init();
            if (this.operateName == "添加")
            {
                
                this.Text = "添加库房工位逻辑";
                this.sb_Add.Text = "添加";
            }
            else
            {
                this.cb_WareCode.Text = station.WareHouseID;
                this.cbe_StaionLogicCate.Text = station.WHStationLogicType;
                this.txtEdit_StationLogicName.Text = station.WHStationLogicName;
                this.cbe_StationID.Text = station.WHCellID;
                this.Text = "修改库房工位逻辑";
                this.sb_Add.Text = "修改";
            }
            
        }


     



    }
}