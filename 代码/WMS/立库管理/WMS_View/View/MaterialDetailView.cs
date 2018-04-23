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
    public partial class MaterialDetailView : ChildViewBase
    {
        public MaterialDetailView()
        {
            InitializeComponent();
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);


        }

        private void MaterialDetailView_Load(object sender, EventArgs e)
        {
            MaterialDetailDataBind();
        }
        private void MaterialDetailDataBind()
        {
            this.gc_MaterialDetail.DataBindings.Clear();
            this.gc_MaterialDetail.DataBindings.Add("DataSource", ViewDataManager.GOODSVIEWDATA, "GoodsPropertyList", false, DataSourceUpdateMode.OnPropertyChanged);
        }

       
    }
}
