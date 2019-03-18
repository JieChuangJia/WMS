using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_JBS_Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WMS_To_ERPPresenter : IWMS_To_ERP
    {
        GoodsBll bllGoods = new GoodsBll();
        Goods_ClassBll bllGoods_Class = new Goods_ClassBll();
        Goods_PropertyBll bllGoodsProperty = new Goods_PropertyBll();
        Goods_SupplierBLL bllSupplier = new Goods_SupplierBLL();
        Goods_UnitBLL bllUnit = new Goods_UnitBLL();
        //ERP_WHBLL bllERPWH = new ERP_WHBLL();
        //ERP_Shelf_VGBLL bllERPShelfVG = new ERP_Shelf_VGBLL();
        //ERP_Shelf_VG_VListBLL bllERPShelfVGList = new ERP_Shelf_VG_VListBLL();
        //ERP_WH_VGBLL bllERPWhVG = new ERP_WH_VGBLL();
        //ERP_WH_VG_RELBLL bllWhVgRel = new ERP_WH_VG_RELBLL();
        Plan_TypeBll bllPlanType = new Plan_TypeBll();
        PlanBll bllPlan = new PlanBll();
        Plan_ListBll bllPlanList = new Plan_ListBll();
        

        public WMS_To_ERPPresenter()
        {

        }
        /// <summary>
        /// 基础物料数据信息
        /// </summary>
        /// <param name="materialInfoJson">物料信息json串</param>
        /// <param name="operateType">操作类型：1增加、2更新、3删除</param>
        /// <returns></returns>
        public string MaterialInfo(string materialInfoJson, int operateType)
        {
            materialInfoJson = GetMaterialTestJson();//测试
            ResponseData response = new ResponseData();
            try
            {   
                MaterialInfo materialInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<MaterialInfo>(materialInfoJson);
                if (materialInfo == null)
                {
                    response.Describe = "物料基础数据格式错误！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                    return response.ToJson();
                }
                if (materialInfo.material_class == "" || materialInfo.material_class == null)
                {

                    response.Describe = "物料基础数据的物料大类为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                    return response.ToJson();
                }
                Goods_ClassModel gsClassModel = bllGoods_Class.GetModelByClassName(materialInfo.material_class);//物料大类型

                if (gsClassModel == null)
                {
                    gsClassModel = new Goods_ClassModel();
                    gsClassModel.Goods_Class_Name = materialInfo.material_class;
                    string gsClassMainID = Guid.NewGuid().ToString();
                    gsClassModel.Goods_Class_ID = gsClassMainID;
                    gsClassModel.Goods_Class_Flag = "true";
                    bllGoods_Class.Add(gsClassModel);
                }
                else
                {
                    gsClassModel.Goods_Class_Name = materialInfo.material_class;
                    gsClassModel.Goods_Class_Flag = "true";
                    bllGoods_Class.Update(gsClassModel);
                }
                if (operateType != 1 && operateType != 2 && operateType != 3)
                {
                    response.Describe = "接口操作标识错误！operateType，1为增加，2位更新，3位删除！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                    return response.ToJson();
                }
                switch (operateType)
                {
                    case 1://增加
                        {
                            GoodsModel existgoods = bllGoods.GetModelByCode(materialInfo.material_code);
                            if (existgoods != null)
                            {
                                response.Describe = "物料基础数据添加失败，已经存在此物料编码：" + materialInfo.material_code;
                                response.Status = false;
                                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                                return response.ToJson();
                            }
                            GoodsModel goods = new GoodsModel();
                            goods.Goods_ID = Guid.NewGuid().ToString();
                            goods.Goods_Code = materialInfo.material_code;
                            goods.Goods_Class_ID = gsClassModel.Goods_Class_ID;
                            goods.Goods_Suppier_Code = materialInfo.material_supplier_code;
                            goods.Goods_Category = materialInfo.material_category;

                            goods.Goods_Name = materialInfo.material_name;
                            goods.Goods_Flag = materialInfo.material_enabled;
                            goods.Goods_Type = materialInfo.material_category;
                            goods.Goods_Unit = materialInfo.material_unit;
                            goods.Goods_Model = materialInfo.material_model;
                            bllGoods.Add(goods);
                            GoodsPropertyOperate(goods.Goods_ID, "shelflife", "保质期", materialInfo.material_shelflife, true);//保质期

                            break;
                        }
                    case 2://更新
                        {
                            GoodsModel goods = bllGoods.GetModelByCode(materialInfo.material_code);
                            if (goods == null)
                            {
                                response.Describe = "物料基础数据更新失败，不存此物料编码：" + materialInfo.material_code;
                                response.Status = false;
                                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                                return response.ToJson();
                            }
                            goods.Goods_Code = materialInfo.material_code;
                            goods.Goods_Class_ID = gsClassModel.Goods_Class_ID;
                            goods.Goods_Suppier_Code = materialInfo.material_supplier_code;
                            goods.Goods_Name = materialInfo.material_name;
                            goods.Goods_Flag = materialInfo.material_enabled;
                            goods.Goods_Type = materialInfo.material_category;
                            goods.Goods_Unit = materialInfo.material_unit;
                            goods.Goods_Model = materialInfo.material_model;
                            bllGoods.Update(goods);
                            GoodsPropertyOperate(goods.Goods_ID, "shelflife","保质期", materialInfo.material_shelflife, false);//保质期
                            break;
                        }
                    case 3:
                        {
                            bllGoods.DeleteByCode(materialInfo.material_code);
                            bllGoodsProperty.DeleteByGoodsCode(materialInfo.material_code);
                            break;
                        }
                    default:
                        {
                            response.Status = false;
                            response.Describe = "操作类型错误，operateType，1为增加，2位更新，3位删除！";
                            return response.ToJson();
                        }
                }
 
                response.Describe = "物料基础数据导入成功！";
                response.Status = true;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                return response.ToJson();
             
            }
            catch(Exception ex)
            {
                response.Describe = "物料基础数据导入失败！错误原因：" + ex.StackTrace.ToString();
                response.Status = false;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                return response.ToJson();
             
            }
        }


        public string SupplierInfo(string supplierInfoJson, int operateType)
        {
            ResponseData response = new ResponseData();
            Goods_SupplierModel supplierModel = new Goods_SupplierModel();

            supplierInfoJson = GetSuppierTestJson();//测试
            try
            {
                Supplier supplier = Newtonsoft.Json.JsonConvert.DeserializeObject<Supplier>(supplierInfoJson);
                if (supplier == null)
                {
                    response.Describe = "供应商基础数据格式错误！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                    return response.ToJson();
                }
                if(supplier.supplier_code=="")
                {
                    response.Describe = "供应商编码不能为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                    return response.ToJson();
                }
                if (supplier.supplier_name == "")
                {
                    response.Describe = "供应商名称不能为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                    return response.ToJson();
                }
                if (operateType != 1 && operateType != 2 && operateType != 3)
                {
                    response.Describe = "接口操作标识错误！operateType，1为增加，2位更新，3位删除！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                    return response.ToJson();
                }
                switch (operateType)
                {
                    case 1://增加
                        {
                            supplierModel = bllSupplier.GetModelByCode(supplier.supplier_code);
                            if (supplierModel != null)
                            {
                                response.Describe = "供应商基础数据添加失败，已经存在此供应商编码：" + supplier.supplier_code;
                                response.Status = false;
                                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                                return response.ToJson();
                            }
                            supplierModel = new Goods_SupplierModel();
                            supplierModel.Goods_Supplier_ID = Guid.NewGuid().ToString();
                            supplierModel.Goods_Supplier_Name = supplier.supplier_name;
                            supplierModel.Goods_Supplier_Code = supplier.supplier_code;
                            bllSupplier.Add(supplierModel);
                            break;
                        }
                    case 2://更新
                        {
                            supplierModel = bllSupplier.GetModelByCode(supplier.supplier_code);
                            if (supplierModel == null)
                            {
                                response.Describe = "供应商基础数据更细失败，此供应商编码不存在：" + supplier.supplier_code;
                                response.Status = false;
                                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                                return response.ToJson();
                            }
                            supplierModel.Goods_Supplier_Name = supplier.supplier_name;
                            supplierModel.Goods_Supplier_Code = supplier.supplier_code;
                            bllSupplier.Update(supplierModel);
                            break;
                        }
                    case 3://删除
                        {
                            bllSupplier.DeleteByCode(supplier.supplier_code);
                            break;
                        }
                    default:
                        {
                            response.Status = false;
                            response.Describe = "操作类型错误，operateType，1为增加，2位更新，3位删除！";
                            MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                            return response.ToJson();
                        }

                }
                response.Describe = "物料供应商数据导入成功！"; 
                response.Status = true;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                return response.ToJson();
            }
            catch (Exception ex)
            {
                response.Describe = "物料供应商数据导入失败！错误原因：" + ex.StackTrace.ToString();
                response.Status = false;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                return response.ToJson();
            }
           
        }

        public string MaterialUnit(string materialUnitJson, int operateType)
        {
            ResponseData response = new ResponseData();
            Goods_UnitModel unitDBModel = new Goods_UnitModel();
            materialUnitJson = GetMaterialUnitTestJson();//测试
            try
            {
                MaterialUnit materialUnit = Newtonsoft.Json.JsonConvert.DeserializeObject<MaterialUnit>(materialUnitJson);
                if (materialUnit == null)
                {
                    response.Describe = "物料单位基础数据格式错误！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialUnitJson);
                    return response.ToJson();
                }
                if (materialUnit.unit_code == "")
                {
                    response.Describe = "物料单位不能为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialUnitJson);
                    return response.ToJson();
                }
                if (materialUnit.unit_name == "")
                {
                    response.Describe = "物料单位名称不能为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialUnitJson);
                    return response.ToJson();
                }
                if (operateType != 1 && operateType != 2 && operateType != 3)
                {
                    response.Describe = "接口操作标识错误！operateType，1为增加，2位更新，3位删除！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialUnitJson);
                    return response.ToJson();
                }
                switch (operateType)
                {
                    case 1://增加
                        {
                            unitDBModel =bllUnit.GetModelByCode(materialUnit.unit_code);
                            if (unitDBModel != null)
                            {
                                response.Describe = "物料单位添加失败，已经存在此物料单位编码：" + materialUnit.unit_code;
                                response.Status = false;
                                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialUnitJson);
                                return response.ToJson();
                            }
                            unitDBModel = new Goods_UnitModel();
                            unitDBModel.Goods_Unit_ID = Guid.NewGuid().ToString();
                            unitDBModel.Goods_Unit_Name = materialUnit.unit_name;
                            unitDBModel.Goods_Unit_Code = materialUnit.unit_code;
                            bllUnit.Add(unitDBModel);
                            break;
                        }
                    case 2://更新
                        {
                            unitDBModel = bllUnit.GetModelByCode(materialUnit.unit_code);
                            if (unitDBModel == null)
                            {
                                response.Describe = "物料单位数据更细失败，此物料单位编码不存在：" + materialUnit.unit_code;
                                response.Status = false;
                                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialUnitJson);
                                return response.ToJson();
                            }
                            unitDBModel.Goods_Unit_Name = materialUnit.unit_name;
                            unitDBModel.Goods_Unit_Code = materialUnit.unit_code;
                            bllUnit.Update(unitDBModel);
                            break;
                        }
                    case 3://删除
                        {
                            bllUnit.DeleteByCode(materialUnit.unit_code);
                            break;
                        }
                    default:
                        {
                            response.Status = false;
                            response.Describe = "操作类型错误，operateType，1为增加，2位更新，3位删除！";
                            return response.ToJson();
                        }

                }
                response.Describe = "物料单位数据导入成功！";
                response.Status = true;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialUnitJson);
                return response.ToJson();
            }
            catch (Exception ex)
            {
                response.Describe = "物料单位数据导入失败！错误原因：" + ex.StackTrace.ToString();

                response.Status = false;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "错误", response.Describe + "信息内容：" + materialUnitJson);
                return response.ToJson();
            }
           
        }

        public string WareHouseInfo(string wareHouseInfoJson)
        {
            return "";
        }


        public string MaterialInBoundOrder(string materialInBoundOrderJson)
        {
            return "";
        }

        public string MaterialOutBoundOrder(string materialOutBoundOrderJson)
        {
            return "";
        }

       private void GoodsPropertyOperate(string goodsID, string goodsPropertyCode, string properName,string propertyValue, bool addPreperty)
        {
            if (addPreperty == true)
            {
                Goods_PropertyModel goodsProperty = new Goods_PropertyModel();
                goodsProperty.Goods_Property_ID = Guid.NewGuid().ToString();
                goodsProperty.Goods_ID = goodsID;
                goodsProperty.Goods_Property_Name = properName;
                goodsProperty.Goods_Property_Code = goodsPropertyCode;
                goodsProperty.Goods_Property_Data = propertyValue;
                bllGoodsProperty.Add(goodsProperty);
            }
            else
            {
                Goods_PropertyModel gpm = bllGoodsProperty.GetModelByPropertyCode(goodsID, goodsPropertyCode);
                gpm.Goods_Property_Name = properName;
                gpm.Goods_Property_Code = goodsPropertyCode;
                gpm.Goods_Property_Data = propertyValue;
                bllGoodsProperty.Update(gpm);
            }


        }

       private string GetMaterialTestJson()
       {
           MaterialInfo material = new MaterialInfo();
           material.material_category = "螺丝";
           material.material_class = "成品";
           material.material_code = "1234tyt";
           material.material_enabled = "1";
           material.material_model = "gp2343";
           material.material_name = "螺母";
           material.material_shelflife = "3";
           material.material_supplier_code = "";
           material.material_unit = "个";
           material.op_flag ="1";
           return Newtonsoft.Json.JsonConvert.SerializeObject(material);
       }
       private string GetMaterialUnitTestJson()
       {
           MaterialUnit materialUnit = new MaterialUnit();
           materialUnit.unit_code = "test22";
           materialUnit.unit_name = "个";
           materialUnit.op_flag = 1;
           return Newtonsoft.Json.JsonConvert.SerializeObject(materialUnit);
       }
        private string GetSuppierTestJson()
       {
           Supplier supplier = new Supplier();
           supplier.supplier_code = "sst23";
           supplier.supplier_name = "京东";
           supplier.op_flag = 1;
           return Newtonsoft.Json.JsonConvert.SerializeObject(supplier);
       }
    }
}
