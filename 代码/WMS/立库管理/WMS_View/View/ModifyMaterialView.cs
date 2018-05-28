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
    public partial class ModifyMaterialView : DevExpress.XtraEditors.XtraForm,IAddMaterialView
    //public partial class AddMaterialView : ChildViewBase, IAddMaterialView
    {
        //定义委托
        public delegate void MyDelegate();
        //定义事件
        public event MyDelegate MyEvent;


        public AddMaterialPresenter presenter = null;

        public Goods modGoods = null;
        public ModifyMaterialView()
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
            this.cb_GoodsType.SelectedIndex = -1;
  
        }
        #endregion

        #region 私有方法
        private void LoadFlag()
        {
            this.cb_Flag.Properties.Items.Clear();
            ComboBoxItemCollection coll = this.cb_Flag.Properties.Items;
            coll.BeginUpdate();
            try
            {
                coll.Add("1");
                coll.Add("0");
            }
            finally
            {
                coll.EndUpdate();
            }
            this.cb_GoodsType.SelectedIndex = -1;
        }

        public void ShowMessage(string title, string content)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion


        private void ModifyMaterialView_Load(object sender, EventArgs e)
        {
            this.presenter.LoadMaterialType();
            LoadFlag();
            if (modGoods.MaterialFlag == "1")
            {
                this.cb_Flag.SelectedText ="启用";
            }
            else
            {
                this.cb_Flag.SelectedText = "禁用";
            }
            
            this.cb_GoodsType.SelectedText = modGoods.MaterialType;
            this.txtEdit_GoodsName.Text = modGoods.MaterialName;
            this.txtEdit_MaterialCode.Text = modGoods.MaterialCode;
            this.txtEdit_MaterialUnit.Text = modGoods.MaterialUnit;
            this.te_Model.Text = modGoods.MaterialModel;
        }

        private void sb_Save_Click(object sender, EventArgs e)
        {
           // if (this.cb_Flag.SelectedText == "" || this.cb_Flag.SelectedText == null)
            if (this.cb_Flag.SelectedIndex == -1)
            {
                this.ShowMessage("信息提示", "请选择启用标识");
                return;
            }
            if (this.cb_Flag.SelectedText == "启用")
            {
                modGoods.MaterialFlag ="1";
            }
            else
            {
                modGoods.MaterialFlag ="0";
            }
         
            //if (this.cb_GoodsType.SelectedText == "" || this.cb_GoodsType.SelectedText == null)
            if (this.cb_GoodsType.SelectedIndex == -1)
            {
                this.ShowMessage("信息提示", "请选择物料类别");
                return;
            }
            modGoods.MaterialType = this.cb_GoodsType.Text;
            modGoods.MaterialCode = this.txtEdit_MaterialCode.Text;
            modGoods.MaterialName = this.txtEdit_GoodsName.Text;
            modGoods.MaterialUnit = this.txtEdit_MaterialUnit.Text;
            modGoods.MaterialModel = this.te_Model.Text.Trim();
           
            if (this.presenter.ModifyMatirialModel(modGoods))
            {
                this.ShowMessage("信息提示", "物料修改成功");
            }
            else
            {
                this.ShowMessage("信息提示", "物料修改失败");
            }
            if (MyEvent != null)
            {
                MyEvent();//引发事件
            }
        }

        private void sb_can_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}