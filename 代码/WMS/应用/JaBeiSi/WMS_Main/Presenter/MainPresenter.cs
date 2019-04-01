using CommonMoudle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Database;
using WMS_Interface;
using WMS_Kernel;
using JBS_APPDB;
using WMS_JBS_Service;

namespace WMS_Main
{
    public class MainPresenter
    {
        private View_GoodsBLL bllView_Goods = new View_GoodsBLL();
        private View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
        private SysUserBll bllUser = new SysUserBll();
        private SysRoleBll bllRole = new SysRoleBll();
        private Goods_PropertyBll bllProperty = new Goods_PropertyBll();
        private SysLogBLL bllSysLog = new SysLogBLL();
        private WH_AreaBll bllArea = new WH_AreaBll();
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        private View_Manage_CellBLL bllViewManageCell = new View_Manage_CellBLL();
        private Manage_ListBll bllManageList = new Manage_ListBll();
        //private WmsViewManager wmsViewManager = new WmsViewManager();
        private WMSManager wmsManager = new WMSManager();
        private ERP_Plan_ReportBLL bllErpPlanReport = new ERP_Plan_ReportBLL();
        private List<WMSFuncModule> wmsFuncList = new List<WMSFuncModule>();
        private View_Plan_StockListBLL bllViewPlanStockList = new View_Plan_StockListBLL();
        private ManageBll bllManage = new ManageBll();
        private ThreadBaseModel threadTaskHandler = null;
        public MainPresenter()
        { }
        /// <summary>
        /// 配置wms所具备的功能模块
        /// </summary>
        private void InitWmsModule()
        {   
            wmsFuncList.Add(WMSFuncModule.无计划下架);
            wmsFuncList.Add(WMSFuncModule.无计划配盘);
            wmsFuncList.Add(WMSFuncModule.按计划配盘);
            wmsFuncList.Add(WMSFuncModule.按计划下架);
            wmsFuncList.Add(WMSFuncModule.计划查询);
            wmsFuncList.Add(WMSFuncModule.待办工作);
            wmsFuncList.Add(WMSFuncModule.计划录入);
        }
        public void Init(IWMSFrame wmsFrame)
        {
            InitWmsModule();
            string wmsconfig = AppDomain.CurrentDomain.BaseDirectory + @"\data\WMSClientConfig_JBS.xml";
            wmsManager.Init(wmsFrame, wmsconfig, wmsFuncList);
            wmsManager.ResgistShowMaterialProperty(ShowMaterialProperty);
            wmsManager.RegistAllowPutaway(AllowPutaway);
            wmsManager.RegistUnShelve(AllowUnShelve);

            string restr = "";
            threadTaskHandler = new ThreadBaseModel(1, "计划完成状态监控线程");
            threadTaskHandler.LoopInterval = 100;
            threadTaskHandler.SetThreadRoutine(TaskHandleThread);
            threadTaskHandler.TaskInit(ref restr);
            threadTaskHandler.Start(ref restr);
            
        }
        /// <summary>
        /// 监控erp计划完成状态
        /// </summary>
        private void TaskHandleThread()
        {
            try
            {
                string restr="";
                List<ERP_Plan_ReportModel> reportList = bllErpPlanReport.GetUnReportModelList();
                if (reportList == null || reportList.Count == 0)
                {
                    return;
                }
                for (int i = 0; i < reportList.Count; i++)
                {
                    ERP_Plan_ReportModel erpPlan = reportList[i];
                    List<View_PlanListModel> viewPlan = bllViewPlanList.GetCompleteModelByPlanCode(erpPlan.ERP_Plan_Code);
                    if (viewPlan == null || viewPlan.Count == 0)
                    {
                        continue;
                    }
                    JBS_Service_Manager jbsService = JBS_Service_Manager.GetServiceManager();
                    string jsonStr ="";
                    if (viewPlan[0].Plan_Type_InOut == "1")//入库
                    {
                        bool jsonGetStatus = jbsService.erpSvrPresenter.InHouseResponse(viewPlan, ref jsonStr, ref restr);
                        if(jsonGetStatus==true)
                        {
                            ERP_Plan_ReportModel erpPlanUpdate = bllErpPlanReport.GetModelByPlanCode(viewPlan[0].Plan_Code);
                            erpPlanUpdate.ERP_Plan_IsReported = true;
                            bllErpPlanReport.Update(erpPlanUpdate);
                        }
                        //调用erp接口
                        UploadInHouseInfoToErp(viewPlan);
                    }
                    else
                    {
                        bool jsonGetStatus = jbsService.erpSvrPresenter.OutHouseResponse(viewPlan, ref jsonStr, ref restr);
                        //调用erp接口
                        if (jsonGetStatus == true)
                        {
                            ERP_Plan_ReportModel erpPlanUpdate = bllErpPlanReport.GetModelByPlanCode(viewPlan[0].Plan_Code);
                            erpPlanUpdate.ERP_Plan_IsReported = true;
                            bllErpPlanReport.Update(erpPlanUpdate);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("系统发送异常：" + ex.Message);
            }
            
        }

        private void UploadInHouseInfoToErp(List<View_PlanListModel> planList)//出库入库都一样
        {
            if (planList == null || planList.Count == 0)
            {
                return;
            }
            InHouseOrderResponse inhouseResponse = new InHouseOrderResponse();
            inhouseResponse.order_code = planList[0].Plan_Code;
            inhouseResponse.order_date = planList[0].Plan_Create_Time.ToString();
            inhouseResponse.order_maker = planList[0].Plan_From_User;
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
                inventInfo.inventory_name = manage.Cell_Name;
                Manage_ListModel manageListModel = bllManageList.GetModelByManageID(manage.Mange_ID);
                if (manageListModel != null)
                {
                    inventInfo.quantity = manageListModel.Manage_List_Quantity;
                }

                inventoryList.Add(inventInfo);
            }
            inhouseResponse.InventoryList = inventoryList;


        }
        /// <summary>
        /// 只允许一个待执行或者执行中的任务，否则不允许执行上架
        /// </summary>
        /// <returns></returns>
        private ReturnObject AllowPutaway(PutawayParams param)
        {
            ReturnObject reObject = new ReturnObject();
            List<ManageModel> taskList = bllManage.GetWaitRunTaskListByType("6");//上架任务
            if(taskList==null)
            {
                reObject.Status = false;
                reObject.Describe = "获取上架任务失败！";
                return reObject;
            }
            if (taskList != null&&taskList.Count>0)
            {
                reObject.Status = false;
                reObject.Describe = "当前系统不允许下达上架任务！只允许执行一个任务";
                return reObject;
            }

            View_Plan_StockListModel planStock = bllViewPlanStockList.GetModelByPalletCode(param.PalletCode);
            if(planStock!=null)
            {
                if(param.WareHouseCode!=planStock.Plan_Remark)//不等于计划的上架库房返回false
                {
                    reObject.Status = false;
                    reObject.Describe = "上架库房与计划的上架库房不符，请选择计划的上架库房，计划上架的库房为：" + planStock.Plan_Remark;
                    return reObject;
                }
            }
            reObject.Status = true;
            reObject.Describe = "";
            return reObject;
             
        }
        private ReturnObject AllowUnShelve(UnShelveParams param)
        {
            ReturnObject reObject = new ReturnObject();
            List<ManageModel> taskList = bllManage.GetWaitRunTaskListByType("8");//下架任务
            if (taskList == null)
            {
                reObject.Status = false;
                reObject.Describe = "当前系统不允许下达下架任务！只允许执行一个任务";
                return reObject;
            }
            if (taskList != null && taskList.Count > 0)
            {
                reObject.Status = false;
                reObject.Describe = "当前系统不允许下达下架任务！只允许执行一个任务";
                return reObject;
            }
            View_Plan_StockListModel planStock = bllViewPlanStockList.GetModelByPalletCode(param.PalletCode);
            if (planStock != null)
            {
                if ( param.WareHouseCode != planStock.Plan_Remark)//不等于计划的上架库房返回false
                {
                    reObject.Status = false;
                    reObject.Describe = "下架库房与计划的下架架库房不符，请选择计划的下架库房，计划下架的库房为：" + planStock.Plan_Remark;
                    return reObject;
                }
            }
            reObject.Status = true;
            reObject.Describe = "";
            return reObject;
             
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
