using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Interface;


namespace WMS_Kernel
{
    public enum EnumGoodsEdit
    {
        添加,
        编辑
    }
    public partial class GoodsDataManageView : ChildViewBase
    {
        public EnumGoodsEdit GoodsEdit { get; set; }
        public GoodsDataManageView(string captionName,EnumGoodsEdit goodsEdit)
        {
            InitializeComponent();
            this.Text = captionName;
            this.GoodsEdit = goodsEdit;
        }

       
    }
}
