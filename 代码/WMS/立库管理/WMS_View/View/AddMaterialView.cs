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
    public partial class AddMaterialView : DevExpress.XtraEditors.XtraForm,IAddMaterialView
    //public partial class AddMaterialView : ChildViewBase, IAddMaterialView
    {
        //定义委托
        public delegate void MyDelegate();
        //定义事件
        public event MyDelegate MyEvent;


        public AddMaterialPresenter presenter = null;
        public AddMaterialView()
        {
            InitializeComponent();
            this.presenter = new AddMaterialPresenter(this);
        }
        
        #region 实现方法
       

        public void ShowMaterialType(List<string> typeList)
        {
            this.cb_GoodsType.Properties.Items.Clear();
            ComboBoxItemCollection coll = this.cb_GoodsType.Properties.Items;
            coll.BeginUpdate();
            try
            {
                for (int i = 0; i < typeList.Count;i++ )
                {
                    coll.Add(typeList[i]);
                }
            }
            finally
            {
                coll.EndUpdate();
            }
            this.cb_GoodsType.SelectedIndex =0;
  
        }
        #endregion

        #region 私有方法
        private void LoadFlag()
        {
            this.cb_GoodsType.SelectedIndex = 0;
            this.cb_Flag.Properties.Items.Clear();
            this.cb_Flag.Properties.Items.Add("启用");
            this.cb_Flag.Properties.Items.Add("禁用");
            this.cb_Flag.SelectedIndex = 0;
          
        }

        public void ShowMessage(string title, string content)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion



        private void AddMaterialView_Load(object sender, EventArgs e)
        {
            this.presenter.LoadMaterialType();
            LoadFlag();
        }

        private void sb_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sb_Add_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            if (this.cb_Flag.SelectedIndex == -1 )
            {
                this.ShowMessage("信息提示", "请选择启用标识");
                return;
            }
            if(this.cb_Flag.Text == "启用")
            {
                goods.MaterialFlag ="1";
            }
            else
            {
                goods.MaterialFlag = "0";
            }
            
            if (this.cb_GoodsType.SelectedIndex == -1)
            {
                this.ShowMessage("信息提示", "请选择物料类别");
                return;
            }
            goods.MaterialType = this.cb_GoodsType.Text;
            goods.MaterialCode = this.txtEdit_MaterialCode.Text;
            goods.MaterialName = this.txtEdit_GoodsName.Text;
            goods.MaterialUnit = this.txtEdit_MaterialUnit.Text;
            goods.MaterialModel = this.te_Model.Text;
            if (this.presenter.AddMatirialModel(goods))
            {
                this.ShowMessage("信息提示", "物料添加成功");
            }
            else
            {
                this.ShowMessage("信息提示", "物料添加失败");
            }
            if (MyEvent != null)
            {
                MyEvent();//引发事件
            }
        }
    }
}