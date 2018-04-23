using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WMS_Database;
using Aoyou_BusinessDB;
using WMS_Interface;

namespace Aoyou_Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WMS_To_ERPPresenter : IWMS_To_ERP
    {
        GoodsBll bllGoods = new GoodsBll();
        Goods_ClassBll bllGoods_Class = new Goods_ClassBll();
        Goods_PropertyBll bllGoodsProperty = new Goods_PropertyBll();
        ERP_WHBLL bllERPWH = new ERP_WHBLL();
        ERP_Shelf_VGBLL bllERPShelfVG = new ERP_Shelf_VGBLL();
        ERP_Shelf_VG_VListBLL bllERPShelfVGList = new ERP_Shelf_VG_VListBLL();
        ERP_WH_VGBLL bllERPWhVG = new ERP_WH_VGBLL();
        ERP_WH_VG_RELBLL bllWhVgRel = new ERP_WH_VG_RELBLL();
        Plan_TypeBll bllPlanType = new Plan_TypeBll();

        PlanBll bllPlan = new PlanBll();
        Plan_ListBll bllPlanList = new Plan_ListBll();

        string userName = "wmstoerpuser";
        string password = "Aa123456";

        Dictionary<string, UserInfor> clientUser = new Dictionary<string, UserInfor>();
        public WMS_To_ERPPresenter()
        {
            Console.WriteLine(this.GetHashCode().ToString("x"));
        }
        //public bool Login(string userName, string password)
        //{
        //    if(this.userName == userName && this.password == password)
        //    {
        //        UserInfor user = new UserInfor();
        //        user.UserName = userName;
        //        user.PassWord = password;
        //        string sessionID = OperationContext.Current.SessionId;
        //        clientUser.Add(sessionID, user);
        //        return true;
        //    }
        //    else
        //    {

        //        return false;
        //    }
        //}
        public ResponseData BasicGoodsInfoImport(BasicGoodsInfo basicGoodsInfo)
        {
            ResponseData response = new ResponseData();
            try
            {

                //if(this.GetSvrEnabled() == false)
                //{
                //    return false;
                //}
                if (basicGoodsInfo == null)
                {
                    response.Describe = "物料基础数据对象为空！";
                    response.Status = false;
                    return response;
                }
                if (basicGoodsInfo.GoodsClass == "" || basicGoodsInfo.GoodsClass == null)
                {

                    response.Describe = "物料基础数据的物料大类为空！";
                    response.Status = false;
                    return response;
                }
                Goods_ClassModel gsClassModel = bllGoods_Class.GetModelByClassName(basicGoodsInfo.GoodsClass);

                if (gsClassModel == null)
                {
                    gsClassModel = new Goods_ClassModel();
                    gsClassModel.Goods_Class_Name = basicGoodsInfo.GoodsClass;
                    string gsClassMainID = Guid.NewGuid().ToString();
                    gsClassModel.Goods_Class_ID = gsClassMainID;
                    gsClassModel.Goods_Class_Flag = "true";
                    bllGoods_Class.Add(gsClassModel);
                }
                else
                {
                    gsClassModel.Goods_Class_Name = basicGoodsInfo.GoodsClass;
                    gsClassModel.Goods_Class_Flag = "true";
                    bllGoods_Class.Update(gsClassModel);
                }
                GoodsModel goods = bllGoods.GetModelByReserve1(basicGoodsInfo.GoodsInnerCode.ToString());



                if (goods == null)//没有就添加否则更新
                {
                    goods = new GoodsModel();
                    goods.Goods_ID = Guid.NewGuid().ToString();
                    goods.Goods_Code = basicGoodsInfo.GoodsID;
                    goods.Goods_Class_ID = gsClassModel.Goods_Class_ID;
                    goods.Goods_Suppier_Code = basicGoodsInfo.GoodsApplierCode;
                    goods.Goods_Reserve1 = basicGoodsInfo.GoodsInnerCode.ToString();
                    goods.Goods_Name = basicGoodsInfo.GoodsName;
                    goods.Goods_Flag = basicGoodsInfo.GoodsStatus;
                    goods.Goods_Type = basicGoodsInfo.GoodsType;
                    goods.Goods_Unit = basicGoodsInfo.GoodsUnit;
                    bllGoods.Add(goods);
                    GoodsPropertyOperate(goods.Goods_ID, "fzxx", basicGoodsInfo.GoodsAssistProperty, true);//辅助信息
                    GoodsPropertyOperate(goods.Goods_ID, "zxbzsl", basicGoodsInfo.GoodsMinPackNum.ToString(), true);//辅助信息
                    GoodsPropertyOperate(goods.Goods_ID, "wljx", basicGoodsInfo.GoodsPolar, true);//辅助信息

                }
                else
                {
                    goods.Goods_Code = basicGoodsInfo.GoodsID;
                    goods.Goods_Class_ID = gsClassModel.Goods_Class_ID;
                    goods.Goods_Suppier_Code = basicGoodsInfo.GoodsApplierCode;
                    goods.Goods_Reserve1 = basicGoodsInfo.GoodsInnerCode.ToString();
                    goods.Goods_Name = basicGoodsInfo.GoodsName;
                    goods.Goods_Flag = basicGoodsInfo.GoodsStatus;
                    goods.Goods_Type = basicGoodsInfo.GoodsType;
                    goods.Goods_Unit = basicGoodsInfo.GoodsUnit;

                    bllGoods.Update(goods);
                    GoodsPropertyOperate(goods.Goods_ID, "fzxx", basicGoodsInfo.GoodsAssistProperty, false);//辅助信息
                    GoodsPropertyOperate(goods.Goods_ID, "zxbzsl", basicGoodsInfo.GoodsMinPackNum.ToString(), false);//辅助信息
                    GoodsPropertyOperate(goods.Goods_ID, "wljx", basicGoodsInfo.GoodsPolar, false);//辅助信息

                }

                response.Describe = "数据导入成功！";
                response.Status = true;
                return response;

            }
            catch (Exception ex)
            {
                response.Describe = "数据导入错误！" + ex.Message;
                response.Status = false;
                return response;
            }
        }

        /// <summary>
        /// 仓库信息
        /// </summary>
        /// <param name="wareHouse"></param>
        /// <param name="vgInfo"></param>
        /// <param name="whShelfRelList"></param>
        /// <returns></returns>
        public ResponseData WareHouseInfor(WareHouse wareHouse, WH_VGInfo vgInfo, List<WH_Shelf_Rel> whShelfRelList)
        {
            ResponseData response = new ResponseData();

            try
            {
                if (wareHouse == null)
                {
                    response.Status = false;
                    response.Describe = "仓库描述类为空！";
                    return response;
                }
                ERP_WHModel erpWhModel = new ERP_WHModel();
                erpWhModel.ERP_WH_Code = wareHouse.Code;
                erpWhModel.ERP_WH_CreateGroup = wareHouse.CreateGroup;
                erpWhModel.ERP_WH_Default_Status = wareHouse.DefaultStatus;
                erpWhModel.ERP_WH_Enabled = wareHouse.EnableMange.ToString().ToUpper();
                erpWhModel.ERP_WH_ID = wareHouse.MainID;
                erpWhModel.ERP_WH_Name = wareHouse.Name;
                erpWhModel.ERP_WH_Property = wareHouse.Property;
                erpWhModel.ERP_WH_UseGroup = wareHouse.UseGroup;
                bllERPWH.UpdateWH(erpWhModel);
                if (wareHouse.EnableMange == true)//启用仓位管理
                {

                    ERP_WH_VGModel erpWhGvData = new ERP_WH_VGModel();
                    erpWhGvData.ERP_WH_ID = erpWhModel.ERP_WH_ID;
                    erpWhGvData.ERP_WH_VG_Code = vgInfo.WH_VG_Code;
                    erpWhGvData.ERP_WH_VG_ID = vgInfo.MainID;
                    bllERPWhVG.UpdateWHVG(erpWhGvData);

                    //ERP_Shelf_VGModel shelfVgData = new ERP_Shelf_VGModel();
                    //shelfVgData.ERP_Shelf_VG_ID = shelfVg.Shelf_VG_MainID;
                    //shelfVgData.ERP_Shelf_VG_Code = shelfVg.Code;
                    //shelfVgData.ERP_Shelf_VG_Name = shelfVg.Name;
                    //bllERPShelfVG.UpdateVG(shelfVgData);

                    //foreach (Shelf_VG_List shelfVgListTemp in shelfVgList)
                    //{
                    //    ERP_Shelf_VG_VListModel shelfVgListData = new ERP_Shelf_VG_VListModel();
                    //    shelfVgListData.ERP_Shelf_VG_ID = shelfVgListTemp.Shelf_VG_MainID;
                    //    shelfVgListData.ERP_Shelf_VG_VList_Code = shelfVgListTemp.Code;
                    //    shelfVgListData.ERP_Shelf_VG_VList_ID = shelfVgListTemp.Shelf_VG_List_MainID;
                    //    shelfVgListData.ERP_Shelf_VG_VList_Name = shelfVgListTemp.Name;
                    //    bllERPShelfVGList.UpdateVGList(shelfVgListData);
                    //}

                    foreach (WH_Shelf_Rel whShelfRel in whShelfRelList)
                    {
                        ERP_WH_VG_RELModel erpVGREL = new ERP_WH_VG_RELModel();
                        erpVGREL.ERP_WH_VG_REL_ID = Guid.NewGuid().ToString();
                        erpVGREL.ERP_Shelf_VG_VList_ID = whShelfRel.WH_Shelf_VG_List_ID;
                        erpVGREL.ERP_WH_VG_ID = whShelfRel.WH_VG_ID;
                        erpVGREL.ERP_WH_VG_REL_Value = whShelfRel.Value;
                        bllWhVgRel.UpdateVGRELList(erpVGREL);
                    }


                }

                response.Status = true;
                response.Describe = "仓库数据更新成功！";
                return response;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Describe = "启用仓库管理错误！" + ex.Message;
                return response;
            }
        }
        /// <summary>
        /// 仓位信息
        /// </summary>
        /// <param name="shelfVg"></param>
        /// <param name="shelfVgList"></param>
        /// <returns></returns>
        public ResponseData CellInfor(Shelf_VG shelfVg, List<Shelf_VG_List> shelfVgList)
        {
            ResponseData response = new ResponseData();
            try
            {
                ERP_Shelf_VGModel shelfVgData = new ERP_Shelf_VGModel();
                shelfVgData.ERP_Shelf_VG_ID = shelfVg.Shelf_VG_MainID;
                shelfVgData.ERP_Shelf_VG_Code = shelfVg.Code;
                shelfVgData.ERP_Shelf_VG_Name = shelfVg.Name;
                bllERPShelfVG.UpdateVG(shelfVgData);

                foreach (Shelf_VG_List shelfVgListTemp in shelfVgList)
                {
                    ERP_Shelf_VG_VListModel shelfVgListData = new ERP_Shelf_VG_VListModel();
                    shelfVgListData.ERP_Shelf_VG_ID = shelfVgListTemp.Shelf_VG_MainID;
                    shelfVgListData.ERP_Shelf_VG_VList_Code = shelfVgListTemp.Code;
                    shelfVgListData.ERP_Shelf_VG_VList_ID = shelfVgListTemp.Shelf_VG_List_MainID;
                    shelfVgListData.ERP_Shelf_VG_VList_Name = shelfVgListTemp.Name;
                    bllERPShelfVGList.UpdateVGList(shelfVgListData);
                }

                response.Describe = "仓位信息设置成功!";
                response.Status = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Describe ="仓位信息设置错误："+ ex.Message;
                return response;
            }


        }

        /// <summary>
        /// 库房启禁用状态
        /// </summary>
        /// <param name="houseCode">库房编码</param>
        /// <param name="enabled">true,启用;false禁用</param>
        /// <returns></returns>
        public ResponseData WareHouseEnabled(string houseCode, bool enabled)
        {
            ResponseData response = new ResponseData();
            try
            {
                ERP_WHModel wareHouse = bllERPWH.GetModelByWHCode(houseCode);
                if(wareHouse == null)
                {
                    response.Status = false;
                    response.Describe = "库房不存在，库房设置失败！";
                    return response;
                }
                wareHouse.ERP_WH_Enabled = enabled.ToString().ToUpper();
                bllERPWH.Update(wareHouse);

                response.Status = true;
                if (enabled == true)
                {
                    response.Describe = "库房启用成功！";
                }
                else
                {
                    response.Describe = "库房禁用成功！";
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Status = false;
                if (enabled == true)
                {
                    response.Describe = "库房启用失败！"+ex.Message;
                }
                else
                {
                    response.Describe = "库房禁用失败！" + ex.Message;
                }
                return response;
            }
        }
        /// <summary>
        /// 收料通知
        /// </summary>
        /// <param name="plan">计划</param>
        /// <param name="planList">计划详细</param>
        /// <returns></returns>

        public ResponseData ReceiveGoodsPlan(Plan plan, List<PlanList> planList)
        {
            ResponseData response = new ResponseData();

            try
            {
                if (plan == null)
                {
                    response.Status = false;
                    response.Describe = "计划单据对象为空！";
                    return response;
                }
                if (planList == null)
                {
                    response.Status = false;
                    response.Describe = "计划单据详单为空！";
                    return response;
                }

                PlanMainModel planMainModel = bllPlan.GetModelByPlanCode(plan.PlanCode);
                if(planMainModel != null)
                {
                    bllPlan.DeleteByPlanCode(planMainModel.Plan_Code);
                }
                planMainModel = new PlanMainModel();
                planMainModel.Plan_ID = Guid.NewGuid().ToString();
                
                planMainModel.Plan_Create_Time = DateTime.Now;
                planMainModel.Plan_Remark = plan.Payee;
                planMainModel.Plan_Code = plan.PlanCode;
                
                Plan_TypeModel planTypeModel = bllPlanType.GetModelByCode(plan.PlanType);

                if (planTypeModel == null)
                {
                    response.Status = false;
                    response.Describe = "不存在[" + plan.PlanCode + "]类型计划！";
                    return response;
                }

                planMainModel.Plan_Type_ID = planTypeModel.Plan_Type_ID;
                DateTime recDate = DateTime.Now;
                bool recDataStatus= DateTime.TryParse(plan.RecvDateTime, out recDate);
                if (recDataStatus == true)
                {
                    planMainModel.Plan_Bill_Time = recDate;
                }
                else
                {
                    response.Status = false;
                    response.Describe = "收料时间格式错误！" + plan.RecvDateTime;
                    return response;
                }
             
                planMainModel.Plan_From_User = plan.Settlement;
                planMainModel.Plan_Reserve1 = plan.SettlementGroup;
                planMainModel.Plan_From_Dept = plan.Supplyer;
                planMainModel.Plan_Status = EnumPlanStatus.待执行.ToString();
                bllPlan.UpdatePlan(planMainModel);

                foreach (PlanList pl in planList)
                {
                    Plan_ListModel planListModel = new Plan_ListModel();
                    planListModel.Plan_ID = planMainModel.Plan_ID;
                    planListModel.Plan_List_ID = Guid.NewGuid().ToString();
                    planListModel.Plan_List_Ordered_Quantity = "0";
                    planListModel.Plan_List_Quantity = pl.RecvNum;
                    planListModel.Plan_List_Finished_Quantity ="0";
                    planListModel.Plan_List_Remark = pl.NeedCheck.ToString();
                    
                    GoodsModel goods = bllGoods.GetModelByCode(pl.GoodsCode);
                    if(goods == null)
                    {
                  
                        response.Status = false;
                        response.Describe = "不存在[" + pl.GoodsCode + "]物料！";
                        return response;
                    }

                    planListModel.Goods_ID = goods.Goods_ID;
                    planListModel.Plan_List_Resever1 = pl.NeedGroup + "," + pl.RecvUnit + "," + pl.StockUnit;
                    planListModel.Plan_List_Resever2 = pl.Sum + "," + pl.UnitPrice + "," + pl.ValuationUnit;

                    bllPlanList.Add(planListModel);

                }


                response.Status = true;
                response.Describe = "收料成功！";
                return response;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Describe = "收料失败：" + ex.Message;
                return response;
            }
        
        }

        /// <summary>
        /// 删除收料计划，只有在待执行的时候可以删除
        /// </summary>
        /// <param name="planCode"></param>
        /// <returns></returns>
        public ResponseData DeletePlan(string planCode)
        {
            ResponseData response = new ResponseData();
            try
            {
                PlanMainModel plan=  bllPlan.GetModelByPlanCode(planCode);
                if(plan==null)
                {
                    response.Status = false;
                    response.Describe = "不存在：[" +planCode+"]计划";
                    return response;
                }
                if(plan.Plan_Status == EnumPlanStatus.执行中.ToString())
                {
                    response.Status = false;
                    response.Describe = "收料计划已经在执行中不允许删除！";
                    return response;
                }
                bllPlan.Delete(plan.Plan_ID);
                response.Status = true;
                response.Describe = "收料计划删除成功！";
                return response;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Describe = "收料计划删除失败：" + ex.Message;
                return response;
            }
        }
        private void GoodsPropertyOperate(string goodsID, string goodsPropertyCode, string propertyValue, bool addPreperty)
        {
            if (addPreperty == true)
            {
                Goods_PropertyModel goodsProperty = new Goods_PropertyModel();
                goodsProperty.Goods_Property_ID = Guid.NewGuid().ToString();
                goodsProperty.Goods_ID = goodsID;
                goodsProperty.Goods_Property_Code = goodsPropertyCode;
                goodsProperty.Goods_Property_Data = propertyValue;
                bllGoodsProperty.Add(goodsProperty);
            }
            else
            {
                Goods_PropertyModel gpm = bllGoodsProperty.GetModelByPropertyCode(goodsID, goodsPropertyCode);

                gpm.Goods_Property_Code = goodsPropertyCode;
                gpm.Goods_Property_Data = propertyValue;
                bllGoodsProperty.Update(gpm);
            }


        }

        //private bool GetSvrEnabled()
        //{
        //    if(this.clientUser.Count ==0)
        //    {
        //        return false;
        //    }
        //    UserInfor user = this.clientUser[this.GetHashCode().ToString("x")];
        //    if(user == null)
        //    {
        //        return false;
        //    }
        //    if(user.UserName == this.userName&&user.PassWord == this.password)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
    }
    public class UserInfor
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public UserInfor()
        { }
    }
}

