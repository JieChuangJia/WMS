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
    public partial class AddAndModifyWHHouseView: ChildViewBase,IAddAndModifyWHHouseView
    {
        //定义委托
        public delegate void MyDelegate();

        //定义事件
        public event MyDelegate MyEvent;

        /// <summary>
        /// 操作名称
        /// </summary>
        public string operateName = "";

        public WHHouse house = null;


        public AddAndModifyWHHousePresenter presenter = null;
        public AddAndModifyWHHouseView()
        {
            InitializeComponent();
            this.presenter = new AddAndModifyWHHousePresenter(this);
        }
        
        #region 实现方法
       
        
        #endregion
 



        private void sb_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sb_Add_Click(object sender, EventArgs e)
        {
            if (this.txt_WareHouseID.Text == null || this.txt_WareHouseID.Text == "")
            {
                this.ShowMessage("信息提示", "请输入库房编号");
                return;
            }
            if (this.txt_WareCode.Text == null || this.txt_WareCode.Text == "")
            {
                this.ShowMessage("信息提示", "请输入库房编码");
                return;
            }
            if (this.txt_WareName.Text == null || this.txt_WareName.Text == "")
            {
                this.ShowMessage("信息提示", "请输入库房名称");
                return;
            }

            if (this.txt_WareEnable.Text == null || this.txt_WareEnable.Text == "")
            {
                this.ShowMessage("信息提示", "请输入库房启用标识");
                return;
            }

            house.WareHouse_ID = this.txt_WareHouseID.Text;
            house.WareHouse_Code = this.txt_WareCode.Text;
            house.WareHouse_Name = this.txt_WareName.Text;
            house.WareHouse_Type = this.txt_WareType.Text;
            house.WareHouse_Flag = this.txt_WareEnable.Text;
            house.WareHouse_Remark = this.txt_Remark.Text;

            if (this.operateName == "添加")
            {
               
                if (this.presenter.AddHuouseModel(house))
                {
                    this.ShowMessage("信息提示", "库房添加成功");
                }
                else
                {
                    this.ShowMessage("信息提示", "库房添加失败");
                }
            }
            else
            {
                if (this.presenter.ModifyHouseModel(house))
                {
                    this.ShowMessage("信息提示", "库房修改成功");
                }
                else
                {
                    this.ShowMessage("信息提示", "库房工位修改失败");
                }

            }
            if (MyEvent != null)
            {
                MyEvent();//引发事件
            }
        }

        private void AddAndModifyWHHouseView_Load(object sender, EventArgs e)
        {
            this.presenter.Init();
            if (this.operateName == "添加")
            {
                this.Text = "添加库房";
                this.sb_Add.Text = "添加";
                this.txt_WareHouseID.Enabled = true;
            }
            else
            {
                this.txt_WareHouseID.Text = house.WareHouse_ID;
                this.txt_WareHouseID.Enabled = false;
                this.txt_WareCode.Text = house.WareHouse_Code;
                this.txt_WareEnable.Text = house.WareHouse_Flag;
                this.txt_WareName.Text = house.WareHouse_Name;
                this.txt_WareType.Text = house.WareHouse_Type;
                this.txt_Remark.Text = house.WareHouse_Remark;
                this.Text = "修改库房";
                this.sb_Add.Text = "修改";
            }
        }





    }
}