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
    public partial class AddAndModifyAreaView: ChildViewBase,IAddAndModifyAreaView
    {
        //定义委托
        public delegate void MyDelegate();

        //定义事件
        public event MyDelegate MyEvent;

        /// <summary>
        /// 操作名称
        /// </summary>
        public string operateName = "";

        public WareArea area = null;
         

        public AddAndModifyAreaPresenter presenter = null;
        public AddAndModifyAreaView()
        {
            InitializeComponent();
            this.presenter = new AddAndModifyAreaPresenter(this);
        }
        
        #region 实现方法
       
        #endregion

        #region 私有方法

        public void ShowMessage(string title, string content)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion



        private void sb_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sb_Add_Click(object sender, EventArgs e)
        {
            if (this.txtEdit_AreaName.Text == null || this.txtEdit_AreaName.Text == "")
            {
                this.ShowMessage("信息提示", "请输入区域名称");
                return;
            }
            if (this.cb_AreaEnable.SelectedIndex == -1)
            {
                this.ShowMessage("信息提示", "请选择启用/停用标识");
                return;
            }
            if(this.txtEdit_AreaColor.Text == null || this.txtEdit_AreaColor.Text == "")
            {
                this.ShowMessage("信息提示", "请设置颜色");
                return;
            }
            //if(this.txtEdit_AreaName.Text=="默认库区")
            //{
            //    this.ShowMessage("信息提示", "默认库区为系统关键词，请重启设定库区名称");
            //    return;
            //}
            area.AreaBackColor = this.txtEdit_AreaColor.Text;
            area.AreaCode = this.textEdit_AreaCode.Text;
            if (this.cb_AreaEnable.Text.Trim() == "是")
            {
                area.AreaEnableStatus = "1";
            }
            else
            {
                area.AreaEnableStatus = "0";
            }
         
            area.AreaName = this.txtEdit_AreaName.Text;
            area.AreaType = this.txtEdit_AreaType.Text;
            if(this.operateName == "添加")
            {
                
                //需要给areaID赋值
                if (this.presenter.AddAreaModel(area))
                {
                    this.ShowMessage("信息提示", "库房区域添加成功");
                }
                else
                {
                    this.ShowMessage("信息提示", "库房区域添加失败");
                }
            }
            else
            {
                if (this.presenter.ModifyAreaModel(area))
                {
                    this.ShowMessage("信息提示", "库房区域修改成功");
                }
                else
                {
                    this.ShowMessage("信息提示", "库房区域修改失败");
                }
               
            }
            if (MyEvent != null)
            {
                MyEvent();//引发事件
            }
        }

        private void AddAndModifyAreaView_Load(object sender, EventArgs e)
        {
            if (this.operateName == "添加")
            {
                this.cb_AreaEnable.Properties.Items.Clear();
                this.cb_AreaEnable.Properties.Items.Add("是");
                this.cb_AreaEnable.Properties.Items.Add("否");
                this.cb_AreaEnable.SelectedIndex = 0;
                this.Text = "添加库房区域";
                this.sb_Add.Text = "添加";
            }
            else
            {
                this.cb_AreaEnable.Properties.Items.Clear();
                this.cb_AreaEnable.Properties.Items.Add("是");
                this.cb_AreaEnable.Properties.Items.Add("否");
                if (area.AreaEnableStatus == "是")
                {
                    this.cb_AreaEnable.SelectedIndex = 0;
                }
                else
                {
                    this.cb_AreaEnable.SelectedIndex = 1;
                }
                this.textEdit_AreaCode.Text = area.AreaCode;
                this.txtEdit_AreaName.Text = area.AreaName;
                this.txtEdit_AreaType.Text = area.AreaType;
                this.txtEdit_AreaColor.Text = area.AreaBackColor;
                int r = int.Parse(area.AreaBackColor.Split(',')[0]);
                int g = int.Parse(area.AreaBackColor.Split(',')[1]);
                int b = int.Parse(area.AreaBackColor.Split(',')[2]);
                this.txtEdit_AreaColor.BackColor = Color.FromArgb(r, g, b);
                this.Text = "修改库房区域";
                this.sb_Add.Text = "修改";
            }
            
        }

        private void sb_SetColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.txtEdit_AreaColor.Text = colorDialog.Color.R.ToString() + "," + colorDialog.Color.G.ToString() + "," + colorDialog.Color.B.ToString();
                txtEdit_AreaColor.BackColor = colorDialog.Color;
            }
            
        }

    }
}