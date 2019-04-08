using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WMS_Database;
using WMS_Interface;
using WMS_Kernel;
using JBS_APPDB;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.IO;
namespace WMS_JBS_Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class WMS_To_ERPPresenter : IWMS_To_ERP
    {
        GoodsBll bllGoods = new GoodsBll();
        Goods_ClassBll bllGoods_Class = new Goods_ClassBll();
        Goods_PropertyBll bllGoodsProperty = new Goods_PropertyBll();
        Goods_SupplierBLL bllSupplier = new Goods_SupplierBLL();
        Goods_UnitBLL bllUnit = new Goods_UnitBLL();
        
        Plan_TypeBll bllPlanType = new Plan_TypeBll();
        PlanBll bllPlan = new PlanBll();
        Plan_ListBll bllPlanList = new Plan_ListBll();
        WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        
        View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
        View_StockListBLL bllViewStockList = new View_StockListBLL();
        ERP_Plan_ReportBLL bllErpPlanReport = new ERP_Plan_ReportBLL();
        private View_Manage_CellBLL bllViewManageCell = new View_Manage_CellBLL();
        private Manage_ListBll bllManageList = new Manage_ListBll();
        IWMSExtern wmsExtern = null;
        public WMS_To_ERPPresenter()
        {
          wmsExtern=  WMSExtern.GetWMSExtern();
          //wmsExtern.ExePlanEventHandler += WmsExtern_ExePlanEventHandler;
        }
        /// <summary>
        /// 基础物料数据信息
        /// </summary>
        /// <param name="materialInfoJson">物料信息json串</param>
        /// <param name="operateType">操作类型：1增加、2更新、3删除</param>
        /// <returns></returns>
        public string MaterialInfo(string materialInfoJson, string operateType)
        {
            //materialInfoJson = GetMaterialTestJson();//测试
        
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
                if (operateType != "1" && operateType != "2" && operateType != "3")
                {
                    response.Describe = "接口操作标识错误！operateType，1为增加，2为更新，3为删除！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                    return response.ToJson();
                }
                switch (operateType)
                {
                    case "1"://增加
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
                            if (materialInfo.material_enabled == true)
                            {
                                goods.Goods_Flag = "1";
                            }
                            else
                            {
                                goods.Goods_Flag = "0";
                            }

                            goods.Goods_Type = materialInfo.material_category;
                            goods.Goods_Unit = materialInfo.material_unit;
                            goods.Goods_Model = materialInfo.material_model;
                            bllGoods.Add(goods);
                            GoodsPropertyOperate(goods.Goods_ID, "shelflife", "保质期", materialInfo.material_shelflife.ToString(), true);//保质期

                            break;
                        }
                    case "2"://更新
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
                            if (materialInfo.material_enabled == true)
                            {
                                goods.Goods_Flag = "1";
                            }
                            else
                            {
                                goods.Goods_Flag = "0";
                            }

                            goods.Goods_Type = materialInfo.material_category;
                            goods.Goods_Unit = materialInfo.material_unit;
                            goods.Goods_Model = materialInfo.material_model;
                            bllGoods.Update(goods);
                            GoodsPropertyOperate(goods.Goods_ID, "shelflife", "保质期", materialInfo.material_shelflife.ToString(), false);//保质期
                            break;
                        }
                    case "3":
                        {
                            bllGoods.DeleteByCode(materialInfo.material_code);
                            bllGoodsProperty.DeleteByGoodsCode(materialInfo.material_code);
                            break;
                        }
                    default:
                        {
                            response.Status = false;
                            response.Describe = "操作类型错误，operateType，1为增加，2为更新，3为删除！";
                            return response.ToJson();
                        }
                }

                response.Describe = "物料基础数据导入成功！";
                response.Status = true;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                return response.ToJson();

            }
            catch (Exception ex)
            {
                response.Describe = "物料基础数据导入失败！错误原因：" + ex.StackTrace.ToString();
                response.Status = false;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInfoJson);
                return response.ToJson();

            }
        }


        public string SupplierInfo(string supplierInfoJson, string operateType)
        {
            ResponseData response = new ResponseData();
            Goods_SupplierModel supplierModel = new Goods_SupplierModel();

            //supplierInfoJson = GetSuppierTestJson();//测试
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
                if (supplier.supplier_code == "")
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
                if (operateType != "1" && operateType != "2" && operateType != "3")
                {
                    response.Describe = "接口操作标识错误！operateType，1为增加，2为更新，3为删除！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + supplierInfoJson);
                    return response.ToJson();
                }
                switch (operateType)
                {
                    case "1"://增加
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
                    case "2"://更新
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
                    case "3"://删除
                        {
                            bllSupplier.DeleteByCode(supplier.supplier_code);
                            break;
                        }
                    default:
                        {
                            response.Status = false;
                            response.Describe = "操作类型错误，operateType，1为增加，2为更新，3为删除！";
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

        public string MaterialUnit(string materialUnitJson, string operateType)
        {
            ResponseData response = new ResponseData();
            Goods_UnitModel unitDBModel = new Goods_UnitModel();
            //materialUnitJson = GetMaterialUnitTestJson();//测试
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
                if (operateType != "1"&& operateType != "2" && operateType != "3")
                {
                    response.Describe = "接口操作标识错误！operateType，1为增加，2为更新，3为删除！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialUnitJson);
                    return response.ToJson();
                }
                switch (operateType)
                {
                    case "1"://增加
                        {
                            unitDBModel = bllUnit.GetModelByCode(materialUnit.unit_code);
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
                    case "2"://更新
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
                    case "3"://删除
                        {
                            bllUnit.DeleteByCode(materialUnit.unit_code);
                            break;
                        }
                    default:
                        {
                            response.Status = false;
                            response.Describe = "操作类型错误，operateType，1为增加，2为更新，3为删除！";
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

        public string WareHouseInfo(string wareHouseInfoJson, string operateType)
        {
            ResponseData response = new ResponseData();
            WH_WareHouseModel wareHouseDb = new WH_WareHouseModel();
            //WareHouse wareHouse = new WareHouse();
            //wareHouseInfoJson = GetWareHouseTestJson();//测试
            try
            {
                WareHouse wareHouse = Newtonsoft.Json.JsonConvert.DeserializeObject<WareHouse>(wareHouseInfoJson);
                if (wareHouse == null)
                {
                    response.Describe = "库房档案数据格式错误！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + wareHouseInfoJson);
                    return response.ToJson();
                }
                if (wareHouse.warehouse_code == "")
                {
                    response.Describe = "库房编码不能为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + wareHouseInfoJson);
                    return response.ToJson();
                }
                if (wareHouse.warehouse_name == "")
                {
                    response.Describe = "库房名称不能为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + wareHouseInfoJson);
                    return response.ToJson();
                }
                if (operateType != "1" && operateType !="2" && operateType != "3")
                {
                    response.Describe = "接口操作标识错误！operateType，1为增加，2为更新，3为删除！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + wareHouseInfoJson);
                    return response.ToJson();
                }
                switch (operateType)
                {
                    case "1"://增加
                        {
                            wareHouseDb = bllWareHouse.GetModelByCode(wareHouse.warehouse_code);
                            if (wareHouseDb != null)
                            {
                                response.Describe = "库房档案添加失败，已经存在此库房编码：" + wareHouse.warehouse_code;
                                response.Status = false;
                                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + wareHouseInfoJson);
                                return response.ToJson();
                            }
                            wareHouseDb = new WH_WareHouseModel();
                            wareHouseDb.WareHouse_ID = Guid.NewGuid().ToString();
                            wareHouseDb.WareHouse_Code = wareHouse.warehouse_code;
                            wareHouseDb.WareHouse_Name = wareHouse.warehouse_name;
                            bllWareHouse.Add(wareHouseDb);
                            break;
                        }
                    case "2"://更新
                        {
                            wareHouseDb = bllWareHouse.GetModelByCode(wareHouse.warehouse_code);
                            if (wareHouseDb == null)
                            {
                                response.Describe = "库房档案数据更细失败，此库房编码不存在：" + wareHouse.warehouse_code;
                                response.Status = false;
                                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + wareHouseInfoJson);
                                return response.ToJson();
                            }
                            wareHouseDb.WareHouse_Code = wareHouse.warehouse_code;
                            wareHouseDb.WareHouse_Name = wareHouse.warehouse_name;
                            bllWareHouse.Update(wareHouseDb);
                            break;
                        }
                    case "3"://删除
                        {
                            bllWareHouse.DeleteByCode(wareHouse.warehouse_code);
                            break;
                        }
                    default:
                        {
                            response.Status = false;
                            response.Describe = "操作类型错误，operateType，1为增加，2为更新，3为删除！";
                            return response.ToJson();
                        }

                }
                response.Describe = "库存档案数据导入成功！";
                response.Status = true;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + wareHouseInfoJson);
                return response.ToJson();

            }

            catch (Exception ex)
            {
                response.Describe = "物料单位数据导入失败！错误原因：" + ex.StackTrace.ToString();

                response.Status = false;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "错误", response.Describe + "信息内容：" + wareHouseInfoJson);
                return response.ToJson();
            }
        }
        /// <summary>
        /// 出入库订单用一个接口，只是订单类型不同
        /// </summary>
        /// <param name="materialInBoundOrderJson"></param>
        /// <returns></returns>

        public string MaterialPlanOrder(string materialPlanOrderJson)
        {
          

            ResponseData response = new ResponseData();
            try
            {
                Console.WriteLine(materialPlanOrderJson);
                //materialPlanOrderJson = GetInBoundOrderTestJson();
                InHouseOrder inHouseOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<InHouseOrder>(materialPlanOrderJson);
                if (inHouseOrder == null)
                {
                    response.Describe = "订单数据格式错误！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialPlanOrderJson);
                    return response.ToJson();
                }

                if (inHouseOrder.order_code == "")
                {
                    response.Describe = "订单编码不能为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialPlanOrderJson);
                    return response.ToJson();
                }
                if (inHouseOrder.order_voucherType == "")
                {
                    response.Describe = "采购类型不能为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialPlanOrderJson);
                    return response.ToJson();
                }
                if (inHouseOrder.warehouse_code == "")
                {
                    response.Describe = "库房编码不能为空！";
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialPlanOrderJson);
                    return response.ToJson();
                }

                List<PlanListModel> planList = new List<PlanListModel>();
                foreach (OderMaterialInfo material in inHouseOrder.MaterilaList)
                {
                    PlanListModel plm = new PlanListModel();
                    plm.规格型号 = material.material_model;
                    plm.计划创建时间 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    plm.计划单号 = inHouseOrder.order_code;
                    plm.计划列表编码 = Guid.NewGuid().ToString();
                    plm.计划数量 = material.material_number;
                    plm.计量单位 = material.material_unit;
                    plm.物料编码 = material.material_code;
                    plm.物料名称 = material.material_name;
                    plm.物料批次 = material.material_batch;
                    planList.Add(plm);

                }
              
                string restr = "";
                bool status = wmsExtern.AddExternPlan(inHouseOrder.order_code, inHouseOrder.order_voucherType,
                    inHouseOrder.order_maker, DateTime.Parse(inHouseOrder.order_date), inHouseOrder.warehouse_code, planList, ref restr);
                if (status == false)
                {
                    response.Describe = "入库订单数据导入失败！" + restr;
                    response.Status = false;
                    MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialPlanOrderJson);
                    return response.ToJson();
                }
                ERP_Plan_ReportModel existPlan = bllErpPlanReport.GetModelByPlanCode(inHouseOrder.order_code);
                if (existPlan == null)
                {
                    ERP_Plan_ReportModel erpReport = new ERP_Plan_ReportModel();
                    erpReport.ERP_Plan_Code = inHouseOrder.order_code;
                    erpReport.ERP_Plan_IsReported = false;
                    erpReport.ERP_Plan_Report_Content = materialPlanOrderJson;
                    erpReport.ERP_Plan_Report_ID = Guid.NewGuid().ToString();
                    bllErpPlanReport.Add(erpReport);
                }
              
                response.Describe = "订单数据导入成功！";
                response.Status = true;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialPlanOrderJson);
                return response.ToJson();
            }
            catch (Exception ex)
            {
                response.Describe = "订单数据导入失败！错误原因：" + ex.StackTrace.ToString();
                response.Status = false;
                MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "错误", response.Describe + "信息内容：" + materialPlanOrderJson);
                return response.ToJson();
            }
        }

        
        public  bool InHouseResponse(List<View_PlanListModel> planList,ref string jsonStr,ref string reStr)
        {
            try
            {
                if (planList == null || planList.Count == 0)
                {
                    return false;
                }
                InHouseOrderResponse inHouseResponse = new InHouseOrderResponse();//入库完成给erp反馈，否则没有货位信息
                inHouseResponse.wms_order_code = planList[0].Plan_Code;
                inHouseResponse.order_code = Guid.NewGuid().ToString();
                if (planList[0].Plan_Create_Time != null)
                {
                    inHouseResponse.order_date = planList[0].Plan_Create_Time.ToString();
                }
                inHouseResponse.order_maker = planList[0].Plan_From_User;
                inHouseResponse.order_voucherType = planList[0].Plan_Type_Name;
                inHouseResponse.warehouse_code = planList[0].Plan_Remark;
                WH_WareHouseModel house = bllWareHouse.GetModelByCode(planList[0].Plan_Remark);
                if (house != null)
                {
                    inHouseResponse.warehouse_name = house.WareHouse_Name;
                }
                List<InventoryInfo> inventoryInfoList = new List<InventoryInfo>();
                foreach (View_PlanListModel plan in planList)
                {
                    InventoryInfo inventoryInfo = new InventoryInfo();
                    inventoryInfo.serial = plan.Plan_List_Remark;//批次
                    View_StockListModel stock = bllViewStockList.GetModeByPlanListID(plan.Plan_List_ID);
                    if (stock != null)
                    {
                        inventoryInfo.inventory_code = stock.Cell_Code;
                        inventoryInfo.inventory_name = stock.Cell_Name+"-"+stock.Cell_Chlid_Position;
                    }
                    inventoryInfo.quantity = plan.Plan_List_Finished_Quantity;
                    inventoryInfo.serial = plan.Plan_List_Remark;

                    inventoryInfoList.Add(inventoryInfo);
                }
                inHouseResponse.InventoryList = inventoryInfoList;
                reStr = "获取成功！";
                jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(inHouseResponse);
                 
                return true;
            }
            catch(Exception ex)
            {
                reStr = ex.StackTrace;
                return false;
            }
          
        }
        public bool OutHouseResponse(List<View_PlanListModel> planList, ref string jsonStr, ref string reStr)
        {
            try
            {
                if (planList == null || planList.Count == 0)
                {
                    return false;
                }
                OutHouseOrderResponse inhouseResponse = new OutHouseOrderResponse();
                inhouseResponse.order_code = planList[0].Plan_Code;
                inhouseResponse.order_date = planList[0].Plan_Create_Time.ToString();
                inhouseResponse.order_maker = planList[0].Plan_Operater;
                inhouseResponse.order_voucherType = planList[0].Plan_Type_Name;
                inhouseResponse.warehouse_code = planList[0].Plan_Remark;
                WH_WareHouseModel wareHouse = bllWareHouse.GetModelByCode(planList[0].Plan_Remark);
                if (wareHouse != null)
                {
                    inhouseResponse.warehouse_name = wareHouse.WareHouse_Name;
                }

                List<InventoryInfo> inventoryList = new List<InventoryInfo>();
                List<View_Manage_CellModel> manageList = bllViewManageCell.GetListByPlanID(planList[0].Plan_ID);
                foreach (View_Manage_CellModel manage in manageList)
                {
                    InventoryInfo inventInfo = new InventoryInfo();
                    inventInfo.inventory_code = manage.Cell_Code;
                    inventInfo.inventory_name = manage.Cell_Name+"-" + manage.Cell_Chlid_Position;
                    Manage_ListModel manageListModel = bllManageList.GetModelByManageID(manage.Mange_ID);
                    if (manageListModel != null)
                    {
                        inventInfo.quantity = manageListModel.Manage_List_Quantity;
                    }

                    inventoryList.Add(inventInfo);
                }
                inhouseResponse.MaterilaList = inventoryList;

                reStr = "获取成功！";
                jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(inhouseResponse);
                return true;
            }
            catch(Exception ex)
            {
                reStr = ex.StackTrace;
                return false;
            }
           
        }

        //public string MaterialOutBoundOrder(string materialOutBoundOrderJson)
        //{
        //    ResponseData response = new ResponseData();
        //    try
        //    {
        //        materialOutBoundOrderJson = GetOutBoundOrderTestJson();
        //        OutHouseOrder outHouseOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<OutHouseOrder>(materialOutBoundOrderJson);
        //        if (outHouseOrder == null)
        //        {
        //            response.Describe = "出库订单数据格式错误！";
        //            response.Status = false;
        //            MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialOutBoundOrderJson);
        //            return response.ToJson();
        //        }

        //        if (inHouseOrder.order_code == "")
        //        {
        //            response.Describe = "入库订单编码不能为空！";
        //            response.Status = false;
        //            MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInBoundOrderJson);
        //            return response.ToJson();
        //        }
        //        if (inHouseOrder.order_voucherType == "")
        //        {
        //            response.Describe = "采购类型不能为空！";
        //            response.Status = false;
        //            MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInBoundOrderJson);
        //            return response.ToJson();
        //        }
        //        if (inHouseOrder.warehouse_code == "")
        //        {
        //            response.Describe = "库房编码不能为空！";
        //            response.Status = false;
        //            MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInBoundOrderJson);
        //            return response.ToJson();
        //        }

        //        List<PlanListModel> planList = new List<PlanListModel>();
        //        foreach (OderMaterialInfo material in inHouseOrder.MaterilaList)
        //        {
        //            PlanListModel plm = new PlanListModel();
        //            plm.规格型号 = material.material_model;
        //            plm.计划创建时间 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //            plm.计划单号 = inHouseOrder.order_code;
        //            plm.计划列表编码 = Guid.NewGuid().ToString();
        //            plm.计划数量 = material.material_number;
        //            plm.计量单位 = material.material_unit;
        //            plm.物料编码 = material.material_code;
        //            plm.物料名称 = material.material_name;
        //            plm.物料批次 = material.material_batch;
        //            planList.Add(plm);

        //        }

        //        string restr = "";
        //        bool status = wmsExtern.AddExternPlan(inHouseOrder.order_code, inHouseOrder.order_voucherType,
        //            inHouseOrder.order_maker, DateTime.Parse(inHouseOrder.order_date), inHouseOrder.warehouse_code, planList, ref restr);
        //        if (status == false)
        //        {
        //            response.Describe = "入库订单数据导入失败！" + restr;
        //            response.Status = false;
        //            MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInBoundOrderJson);
        //            return response.ToJson();
        //        }
        //        ERP_Plan_ReportModel existPlan = bllErpPlanReport.GetModelByPlanCode(inHouseOrder.order_code);
        //        if (existPlan == null)
        //        {
        //            ERP_Plan_ReportModel erpReport = new ERP_Plan_ReportModel();
        //            erpReport.ERP_Plan_Code = inHouseOrder.order_code;
        //            erpReport.ERP_Plan_IsReported = false;
        //            erpReport.ERP_Plan_Report_Content = materialInBoundOrderJson;
        //            erpReport.ERP_Plan_Report_ID = Guid.NewGuid().ToString();
        //            bllErpPlanReport.Add(erpReport);
        //        }

        //        response.Describe = "入库订单数据导入成功！";
        //        response.Status = true;
        //        MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "提示", response.Describe + "信息内容：" + materialInBoundOrderJson);
        //        return response.ToJson();
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Describe = "入库订单数据导入失败！错误原因：" + ex.StackTrace.ToString();
        //        response.Status = false;
        //        MainFrameHandler.GetMainFrame().WriteLog("WMS_To_ERP服务", "", "错误", response.Describe + "信息内容：" + materialInBoundOrderJson);
        //        return response.ToJson();
        //    }
        //}

        private void GoodsPropertyOperate(string goodsID, string goodsPropertyCode, string properName, string propertyValue, bool addPreperty)
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
            material.material_enabled = true;
            material.material_model = "gp2343";
            material.material_name = "螺母";
            material.material_shelflife = 3;
            material.material_supplier_code = "";
            material.material_unit = "个";
            material.op_flag = 1;
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
        private string GetWareHouseTestJson()
        {
            WareHouse wh = new WareHouse();
            wh.warehouse_code = "A1";
            wh.warehouse_name = "A1库房";
            wh.op_flag = 1;
            return Newtonsoft.Json.JsonConvert.SerializeObject(wh);
        }

        private string GetInBoundOrderTestJson()
        {
            InHouseOrder inHouseOrder = new InHouseOrder();
            inHouseOrder.order_code = "K8";
            inHouseOrder.order_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            inHouseOrder.order_maker = "admin";
            inHouseOrder.order_voucherType = "采购接收";
            inHouseOrder.warehouse_code = "A1";
            OderMaterialInfo materialInfo = new OderMaterialInfo();
            materialInfo.material_batch = "b123";
            materialInfo.material_code = "LSTL0001";
            materialInfo.material_makedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            materialInfo.material_model = "TB009";
            materialInfo.material_name = "极片";
            materialInfo.material_unit = "片";
            materialInfo.material_number = "2";

            OderMaterialInfo materialInfo2 = new OderMaterialInfo();
            materialInfo2.material_batch = "b123";
            materialInfo2.material_code = "KS-60001";
            materialInfo2.material_makedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            materialInfo2.material_model = "TB009";
            materialInfo2.material_name = "极片";
            materialInfo2.material_unit = "片";
            materialInfo2.material_number = "2.3";
            List<OderMaterialInfo> materialList = new List<OderMaterialInfo>();
            materialList.Add(materialInfo);
            materialList.Add(materialInfo2);
            inHouseOrder.MaterilaList = materialList;
            return Newtonsoft.Json.JsonConvert.SerializeObject(inHouseOrder);
        }

        //private string GetOutBoundOrderTestJson()
        //{
        //    OutHouseOrder outHouseOrder = new OutHouseOrder();
        //    outHouseOrder.order_code = "K85";
        //    outHouseOrder.order_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //    outHouseOrder.order_maker = "admin";
        //    outHouseOrder.order_voucherType = "调拨出库";
        //    outHouseOrder.warehouse_code = "A1";
          
        //    OderMaterialInfo materialInfo = new OderMaterialInfo();
        //    materialInfo.material_batch = "b123";
        //    materialInfo.material_code = "KS-60001";
        //    materialInfo.material_makedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //    materialInfo.material_model = "TB009";
        //    materialInfo.material_name = "极片";
        //    materialInfo.material_unit = "片";
        //    materialInfo.material_number = "2";

        //    OderMaterialInfo materialInfo2 = new OderMaterialInfo();
        //    materialInfo2.material_batch = "b123";
        //    materialInfo2.material_code = "KS-60001";
        //    materialInfo2.material_makedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //    materialInfo2.material_model = "TB009";
        //    materialInfo2.material_name = "极片";
        //    materialInfo2.material_unit = "片";
        //    materialInfo.material_number = "2.3";
        //    List<OderMaterialInfo> materialList = new List<OderMaterialInfo>();
        //    materialList.Add(materialInfo);
        //    materialList.Add(materialInfo2);
        //    outHouseOrder.MaterilaList = materialList;
        //    return Newtonsoft.Json.JsonConvert.SerializeObject(outHouseOrder);
        //}


    }
}
