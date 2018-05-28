using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class AddMaterialPresenter : BasePresenter<IAddMaterialView>
    {
        private Goods_ClassBll bllGoodsClass = new Goods_ClassBll();
        private GoodsBll bllGoods = new GoodsBll();
        public AddMaterialPresenter(IAddMaterialView view)
            : base(view,null)
        { }

        public void LoadMaterialType()
        {
            List<Goods_ClassModel> modelList = bllGoodsClass.GetModelList("");
            List<string> typeList = new List<string>();
            if(modelList != null)
            {
                for (int i = 0; i < modelList.Count; i++)
                {
                    typeList.Add(modelList[i].Goods_Class_Name);
                }
            }
            this.View.ShowMaterialType(typeList);
        }
        public bool AddMatirialModel(Goods goods)
        {
            GoodsModel model = new GoodsModel();
            Goods_ClassModel classModel = bllGoodsClass.GetModelByClassName(goods.MaterialType);
            model.Goods_Class_ID = classModel.Goods_Class_ID;
            model.Goods_Code = goods.MaterialCode;
            model.Goods_Flag = goods.MaterialFlag;
            model.Goods_Name = goods.MaterialName;
            model.Goods_Unit = goods.MaterialUnit;
            model.Goods_ID = Guid.NewGuid().ToString();
            model.Goods_Category = goods.MaterialType;
            model.Goods_Model = goods.MaterialModel;
            return bllGoods.Add(model);
        }

        public bool ModifyMatirialModel(Goods goods)
        {
            GoodsModel model = bllGoods.GetModel(goods.MaterialID);
            if(model == null)
            {
                return false;
            }
            Goods_ClassModel classModel = bllGoodsClass.GetModelByClassName(goods.MaterialType);
            model.Goods_Class_ID = classModel.Goods_Class_ID;
            model.Goods_Code = goods.MaterialCode;
            model.Goods_Flag = goods.MaterialFlag;
            model.Goods_Name = goods.MaterialName;
            model.Goods_Unit = goods.MaterialUnit;
            model.Goods_Category = goods.MaterialType;
            model.Goods_Model = goods.MaterialModel;
            return bllGoods.Update(model);
        }

    }
}
