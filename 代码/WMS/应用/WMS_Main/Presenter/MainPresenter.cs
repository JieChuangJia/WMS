using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Database;
using WMS_Interface;
using WMS_Kernel;

namespace Aoyou_WMS
{
    public class MainPresenter
    {
        private View_GoodsBLL bllView_Goods = new View_GoodsBLL();
        private Goods_PropertyBll bllProperty = new Goods_PropertyBll();
        private SysLogBLL bllSysLog = new SysLogBLL();
        //private WmsViewManager wmsViewManager = new WmsViewManager();
        private WMSManager wmsManager = new WMSManager();
        public MainPresenter()
        { }
        public void Init(IWMSFrame wmsFrame)
        {
            wmsManager.Init(wmsFrame);
            wmsManager.ResgistShowMaterialProperty(ShowMaterialProperty);
        }

        public bool AddDBLog(SysLogModel logModel)
        {
            if(logModel == null)
            {
                return false;
            }
            return bllSysLog.Add(logModel);
        }
        public void ShowMaterialProperty(string goodsInfor)
        {
            List<View_GoodsModel> goodsList = bllView_Goods.GetModelByGoosInfo(goodsInfor);
            ViewDataManager.GOODSVIEWDATA.GoodsListData.Clear();
            if (goodsList == null)
            {
                return;
            }

            //ViewDataManager.GOODSVIEWDATA.GoodsListData.Clear();
            foreach (View_GoodsModel goods in goodsList)
            {
                GoodsDataModel gsdModel = new GoodsDataModel();
                gsdModel.单位 = goods.Goods_Unit;
                gsdModel.启用 = goods.Goods_Flag;
                gsdModel.规格型号 = goods.Goods_Model;
                gsdModel.物料编码 = goods.Goods_Code;
                gsdModel.物料类别 = goods.Goods_Category;
                gsdModel.物料名称 = goods.Goods_Name;
                gsdModel.物料内部编码 = goods.Goods_ID.ToString();

                ViewDataManager.GOODSVIEWDATA.GoodsListData.Add(gsdModel);
            }
        }
    }
}
