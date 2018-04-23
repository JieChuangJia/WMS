using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class MaterialManaPresenter :BasePresenter<IMaterailManaView>
    {
        View_GoodsBLL bllView_Goods = new View_GoodsBLL();
        Goods_PropertyBll bllProperty = new Goods_PropertyBll();
        Action<string> showMaterialProperty = null;
        public MaterialManaPresenter(IMaterailManaView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }
        public void ShowGoodsDetail(string goodsID)
        {
            List<Goods_PropertyModel> propertyList = bllProperty.GetModelListByGoodsID(goodsID);
            ViewDataManager.GOODSVIEWDATA.GoodsPropertyList.Clear();
            if(propertyList == null)
            {
                return;
            }
            foreach (Goods_PropertyModel goods in propertyList)
            { 
                GoodsPropertyModel gsm = new GoodsPropertyModel();
                gsm.属性名称 = goods.Goods_Property_Name;
                gsm.属性值 = goods.Goods_Property_Data;
                ViewDataManager.GOODSVIEWDATA.GoodsPropertyList.Add(gsm);
            }

        }
        public void ResgistShowMaterialProperty(Action<string> showMaterialProperty)
        {
            this.showMaterialProperty = showMaterialProperty; 
        }
        public void QueryGoodsList(string goodsInfor)
        {
            if(this.showMaterialProperty == null)
            {
                return;
            }
            this.showMaterialProperty(goodsInfor);

        }

    }
}
