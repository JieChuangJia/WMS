using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS_Interface;
using DevExpress.XtraBars;
namespace WMS_Kernel
{
    public partial class PlanImportView : ChildViewBase,IPlanInputView
    {
        PlanInputPresenter presenter = null;
        public PlanImportView()
        {
            InitializeComponent();
         
        }
        private void PlanManaView_Load(object sender, EventArgs e)
        {
            BindMaterialList();
            de_PlanDate.EditValue = DateTime.Now;
        }
        public override void Init(IWMSFrame wmsFrame)
        {
            base.Init(wmsFrame);
            this.presenter = new PlanInputPresenter(this, wmsFrame);
            string restr = "";
            this.presenter.Init();
            Bitmap bitmap = ImageResource.PlanMana.ToBitmap();
            this.IWmsFrame.AddTitlePage("计划管理", ref restr);
            this.IWmsFrame.AddGroup("计划管理", "计划操作", ref restr);
            this.IWmsFrame.AddButtonItem("计划管理", "计划操作", "计划录入", bitmap, ShowTabEventHandler, ref restr);
        }
        public void IniPlanType(List<string> typeList)
        {
            this.cbe_PlanType.Properties.Items.Clear();

            if (typeList == null)
            {
                return;
            }
            foreach (string planType in typeList)
            {
                this.cbe_PlanType.Properties.Items.Add(planType);
            }
            if (this.cbe_PlanType.Properties.Items.Count > 0)
            {
                this.cbe_PlanType.SelectedIndex = 0;
            }
        }
    
        private void BindMaterialList()
        {
            this.gc_MaterialList.DataBindings.Clear();
            this.gc_MaterialList.DataBindings.Add("DataSource", ViewDataManager.PLANINPUTDATA, "GoodsListData", false, DataSourceUpdateMode.OnPropertyChanged);

            this.gc_PlanGoodsList.DataBindings.Clear();
            this.gc_PlanGoodsList.DataBindings.Add("DataSource", ViewDataManager.PLANINPUTDATA, "PlanListData", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        
        private void ShowTabEventHandler(object sender, ItemClickEventArgs e)
        {
            this.IWmsFrame.ShowView(this, true);
        }
    

        private void sBtn_Query_Click(object sender, EventArgs e)
        {
            string trayCode = this.txtEdit_MaterialInfo.Text.Trim();
            //if(trayCode == "")
            //{
            //    this.ShowMessage("信息提示", "请输入物料信息！");
            //    return;
            //}
            this.presenter.ShowGoodsList(trayCode);
        }

        private void sb_AddGoods_Click(object sender, EventArgs e)
        {
            if (this.gv_GoodsList.GetSelectedRows() == null || this.gv_GoodsList.GetSelectedRows().Count() == 0)
            {
                this.ShowMessage("信息提示", "请选择物料！");
                return;
            }
            int currRow = this.gv_GoodsList.GetSelectedRows()[0];
            string goodsCode = this.gv_GoodsList.GetRowCellValue(currRow, "物料编码").ToString();

            this.presenter.AddPlanGoods(goodsCode, this.se_PlanNum.Value, te_PlanCode.Text.Trim());

        }

        private void sb_DeleteGoods_Click(object sender, EventArgs e)
        {
            if(this.gv_PlanGoodsList.GetSelectedRows().Count()==0)
            {
                return;
            }
            int currRow = this.gv_PlanGoodsList.GetSelectedRows()[0];
            string goodsCode = this.gv_PlanGoodsList.GetRowCellValue(currRow, "物料编码").ToString();
            if (goodsCode == "")
            {
                this.ShowMessage("信息提示", "物料编码错误！");

                return;
            }
            this.presenter.DeletePlanGoods(goodsCode);
        }

        private void sb_AddPlan_Click(object sender, EventArgs e)
        {
            this.presenter.AddPlan(this.te_PlanCode.Text.Trim(), this.cbe_PlanType.Text.Trim(),this.te_CreatePerson.Text.Trim(), de_PlanDate.DateTime, this.te_Remark.Text);
        }

     
    }
}