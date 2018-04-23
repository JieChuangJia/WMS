using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonMoudle;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WMSManager
    {
        public static  IWMSFrame wmsFrame = null;  
        private  ThreadBaseModel threadTaskHandler = null;
        private View_ManageBLL bllViewManage = new View_ManageBLL();
        WmsViewManager wmsViewManager = new WmsViewManager();
        public WMSManager()
        { }
        public bool Init(IWMSFrame wmsFrame)
        {
            string restr="";
            threadTaskHandler = new ThreadBaseModel(1, "任务状态监控线程");
            threadTaskHandler.LoopInterval = 100;
            threadTaskHandler.SetThreadRoutine(TaskHandleThread);
            threadTaskHandler.TaskInit(ref restr);
            threadTaskHandler.Start(ref restr);

            WMSManager.wmsFrame = wmsFrame;
            wmsViewManager.InitView(wmsFrame);
            return true;
        }

        public void ResgistShowMaterialProperty(Action<string> showMaterialProperty)
        {
            this.wmsViewManager.ResgistShowMaterialProperty(showMaterialProperty);
        }
        /// <summary>
        /// 任务状态监控及处理线程
        /// 计划、管理任务、库存、操作记录、Cell状态
        /// </summary>
        private void TaskHandleThread()
        {
            List<View_ManageModel> manageList = bllViewManage.GetModelList("");
            if(manageList == null)
            {
                return;
            }
            TaskContext taskContext = TaskContext.GetContext();

            foreach(View_ManageModel task in manageList)
            {
                if(task.Mange_Status == EnumManageTaskStatus.执行中.ToString())
                {
                    taskContext.SetStatus(task, new TaskRunning());
                }
                else if(task.Mange_Status == EnumManageTaskStatus.完成.ToString())
                {
                    taskContext.SetStatus(task, new TaskComplete());
                }
                taskContext.ChangeStatus();
            }
        }

    }

    public class TaskContext
    {
        private static TaskContext taskContext = null;
        private static TaskStatus taskStatus = null;
        private static View_ManageModel manageTask = null;
        private TaskContext()
        { }
        public static TaskContext GetContext()
        {
            if (taskContext == null)
            {
                taskContext = new TaskContext();
                return taskContext;
            }
            else
            {
                return taskContext;
            }
        }

        public void SetStatus(View_ManageModel manageTask,TaskStatus taskStatus)
        {
            TaskContext.taskStatus = taskStatus;
            TaskContext.manageTask = manageTask;
        }
        public bool ChangeStatus()
        {
            if (TaskContext.taskStatus == null || TaskContext.manageTask == null)
            {
                return false;
            }
            return TaskContext.taskStatus.ChangeStatus(TaskContext.manageTask);
        }
    }
    public abstract class TaskStatus
    {
        public abstract bool ChangeStatus(View_ManageModel manageTask);
      
    }
    public static class TaskHandleMethod
    {
        private static PlanBll bllPlan = new PlanBll();
        private static WH_Cell_ChildrenBll bllCellChild= new WH_Cell_ChildrenBll();
        private static ManageBll bllManage = new ManageBll();
        private static Stock_ListBll bllStockList = new Stock_ListBll();
        private static WH_Cell_Operate_RecordBLL bllCellOperateRecord = new WH_Cell_Operate_RecordBLL();
        private static View_CellBLL bllViewCell = new View_CellBLL();
        private static View_ManageStockListBLL bllViewManageStockList = new View_ManageStockListBLL();
        private static View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
        private static Plan_ListBll bllPlanList = new Plan_ListBll();
        private static StockBll bllStock = new StockBll();
        private static RecordBll bllRecord = new RecordBll();
        private static Record_ListBll bllRecordList = new Record_ListBll();
        private static View_StockListBLL bllViewStockList = new View_StockListBLL();
        public static bool UpdatePlanStatus(string planID, EnumPlanStatus planStatus)
        {
            PlanMainModel planModel = bllPlan.GetModel(planID);
            if(planModel == null)
            {
                return false;
            }
            planModel.Plan_Status = planStatus.ToString();
            if(planStatus == EnumPlanStatus.完成)
            {
                planModel.Plan_End_Time =DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            bllPlan.Update(planModel);
            return true;
        }
       public static bool UpdatePlanOrderedNum(string manageID)
        {
            List<View_ManageStockListModel> stockList = bllViewManageStockList.GetModelListByManageID(manageID);
            if (stockList == null)
            {
                return false;
            }
            foreach (View_ManageStockListModel manageStock in stockList)
            {
                List<View_PlanListModel> planList = bllViewPlanList.GetModelListByPlanAndGoodsID(manageStock.Plan_ID, manageStock.Goods_ID);
                if (planList == null)
                {
                    return false;
                }
                foreach (View_PlanListModel pl in planList)
                {
                    Plan_ListModel plm = bllPlanList.GetModel(pl.Plan_List_ID);
                    plm.Plan_List_Ordered_Quantity = (int.Parse(plm.Plan_List_Ordered_Quantity) + int.Parse(manageStock.Manage_List_Quantity)).ToString();
                    bllPlanList.Update(plm);
                }
            }
            return true;
        }
        public static bool UpdatePlanCompleteNum(string manageID)
        {
            List<View_ManageStockListModel> stockList = bllViewManageStockList.GetModelListByManageID(manageID);
            if(stockList == null)
            {
                return false;
            }
            foreach(View_ManageStockListModel manageStock in stockList)
            {
                List<View_PlanListModel> planList = bllViewPlanList.GetModelListByPlanAndGoodsID(manageStock.Plan_ID, manageStock.Goods_ID);
                if(planList ==null)
                {
                    return false;
                }
                foreach(View_PlanListModel pl in planList)
                {
                    Plan_ListModel plm = bllPlanList.GetModel(pl.Plan_List_ID);
                    plm.Plan_List_Finished_Quantity = (int.Parse(plm.Plan_List_Finished_Quantity) + int.Parse(manageStock.Manage_List_Quantity)).ToString();
                    plm.Plan_List_Ordered_Quantity = (int.Parse(plm.Plan_List_Ordered_Quantity) -int.Parse(manageStock.Manage_List_Quantity)).ToString();
                    bllPlanList.Update(plm);
                }
            }
            
            return true;
        }
        public static bool UpdateCellStatus(string childCellID,EnumCellStatus cellStatus,EnumGSTaskStatus cellRunStatus)
        {
            WH_Cell_ChildrenModel childCell = bllCellChild.GetModel(childCellID);
            if(childCell == null)
            {
                return false;
            }
            childCell.Cell_Child_Status = cellStatus.ToString();
            childCell.Cell_Child_Run_Status = cellRunStatus.ToString();
            bllCellChild.Update(childCell);
            return true;
        }

        public static bool UpdateManageStartTime(string manageTaskID,  DateTime startTime )
        {
            ManageModel manage=bllManage.GetModel(manageTaskID);
            if(manage == null)
            {
                return false;
            }
            manage.Manage_Begin_Time = startTime;
            return bllManage.Update(manage);
        }
        public static bool UpdateManageCompleteTime(string manageTaskID, DateTime completeTime)
        {
            ManageModel manage = bllManage.GetModel(manageTaskID);
            if (manage == null)
            {
                return false;
            }
            manage.Manage_End_Time = completeTime;
            return bllManage.Update(manage);
        }

        public static bool UpdateStockUpdateTime(string palletCode, DateTime updateTime)
        {
            Stock_ListModel stockList = bllStockList.GetModelByPalletCode(palletCode);
            if (stockList == null)
            {
                return false;
            }
            stockList.Stock_List_Update_Time = updateTime;
            return bllStockList.Update(stockList);
        }

        public static bool DeleteManageTask(int days)
        {
            return bllManage.DeleteManage(days);
        }

        public static bool AddCellOperRecord(string cellChildID,EnumGSOperateType operType,string operDetail)
        {
            View_CellModel cell = bllViewCell.GetModelByChildCellID(cellChildID);
            if(cell==null)
            {
                WMSManager.wmsFrame.WriteLog("TaskHandleMethod", "", "错误", "添加Cell操作记录失败，Cell编码错误！");
                return false;
            }
            WH_Cell_Operate_RecordModel cellOperate = new WH_Cell_Operate_RecordModel();
            cellOperate.WareHouse_ID = cell.WareHouse_ID;
            cellOperate.WH_Cell_Code = cell.Cell_Code + ":"+cell.Cell_Chlid_Position;
            cellOperate.WH_Cell_Oper_Datetime = DateTime.Now;
            cellOperate.WH_Cell_Oper_Detail = operDetail;
            cellOperate.WH_Cell_Oper_RecID = Guid.NewGuid().ToString();
            return bllCellOperateRecord.Add(cellOperate);
        }
        /// <summary>
        /// 删除库存
        /// </summary>
        /// <param name="manageID"></param>
        /// <returns></returns>
        public static bool DeleteStock(string palletCode)
        {

            View_StockListModel stockModel = bllViewStockList.GetModelByPalletCode(palletCode, EnumCellType.货位.ToString());
            if (stockModel == null)
            {
                return false;
            }
            return bllStock.Delete(stockModel.Stock_ID);
        }
        public static bool DeleteManageTask(string manageID)
        {
            return bllManage.Delete(manageID);
        }
        /// <summary>
        /// 更新货位位置
        /// </summary>
        /// <param name="palletID">托盘ID</param>
        /// <param name="cellChildID">位置编码</param>
        /// <returns></returns>
        public static bool UpdateStockPos(string palletID,string cellChildID)
        {
            StockModel stock = bllStock.GetModelByTrayCode(palletID);
            if(stock == null)
            {
                WMSManager.wmsFrame.WriteLog("TaskHandleMethod", "UpdateStockPos", "错误", "更新物料位置错误，无此物料货位！");
                return false;
            }
            stock.Cell_Child_ID = cellChildID;
            bllStock.Update(stock);
            return true;
        }
        public static bool CheckPlanCompleteStatus(string planID)
        {
            List<Plan_ListModel> planList = bllPlanList.GetModelListByPlanID(planID);
            if (planList == null)
            {
                WMSManager.wmsFrame.WriteLog("TaskHandleMethod", "UpdatePlanStatus", "错误", "更新计划状态，没有"+planID+"计划编号！");
            }
            bool completeStatus = true;
            foreach (Plan_ListModel pl in planList)
            {
                if(pl.Plan_List_Finished_Quantity != pl.Plan_List_Quantity)
                {
                    completeStatus = false;
                    break;
                }
            }
            if(completeStatus == true)
            {
                UpdatePlanStatus(planID, EnumPlanStatus.完成);
            }
            return true;
        }
        public static bool AddStockRecord(string manageID)
        {
            List<View_ManageStockListModel> manageStockList = bllViewManageStockList.GetModelListByManageID(manageID);
            if (manageStockList == null && manageStockList.Count == 0)
            {
                return false;
            }
            foreach(View_ManageStockListModel manageStock in manageStockList)
            {
                RecordModel record = new RecordModel();
                record.End_Cell_ID = manageStock.Mange_End_Cell_ID;
                record.Manage_Begin_Time = manageStock.Manage_Begin_Time;
                record.Manage_End_Time = manageStock.Manage_End_Time;
                record.Manage_Type_Code = manageStock.Mange_Type_ID;
                record.Plan_ID = manageStock.Plan_ID;
                record.Record_ID = Guid.NewGuid().ToString();
                record.Start_Cell_ID = manageStock.Mange_Start_Cell_ID;
                record.Stock_Tray_Barcode = manageStock.Stock_Tray_Barcode;
                bllRecord.Add(record);

                Record_ListModel recordList = new Record_ListModel();
                recordList.Goods_ID = manageStock.Goods_ID;
                recordList.Plan_List_ID = manageStock.Plan_List_ID;
                recordList.Record_Box_Barcode = manageStock.Stock_List_Box_Barcode;
                recordList.Record_ID = record.Record_ID;
                recordList.Record_List_ID = Guid.NewGuid().ToString();
                recordList.Record_List_Quantity = manageStock.Stock_List_Quantity;
                bllRecordList.Add(recordList);
            }
            return true;
           
        }
    }
    public class TaskComplete:TaskStatus
    {
        public TaskComplete()
        { }
        /// <summary>
        /// 任务完成：更新货位状态；更新库存（出库库操作不同）；更新计划状态及当前完成数量；管理任务删除（保留15天数据）；出入库记录更新；
        /// </summary>
        /// <param name="manageTask"></param>
        /// <returns></returns>
        public override bool ChangeStatus(View_ManageModel manageTask)
        {
            try
            {
                if (manageTask == null)
                {
                    return false;
                }
            
                if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘上架.ToString())  //空托盘没有库存，无计划
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_End_Cell_ID, EnumCellStatus.空料框, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_End_Cell_ID, EnumGSOperateType.系统添加空料框, "空托盘上架任务完成，更新货位状态");

                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.上架.ToString())
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_End_Cell_ID, EnumCellStatus.满位, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_End_Cell_ID, EnumGSOperateType.系统更新货位操作, "物料上架任务完成，更新货位状态");
                    TaskHandleMethod.UpdatePlanCompleteNum(manageTask.Mange_ID);
                    TaskHandleMethod.UpdateStockUpdateTime(manageTask.Mange_Stock_Barcode, DateTime.Now);
                    TaskHandleMethod.UpdateStockPos(manageTask.Mange_Stock_Barcode, manageTask.Mange_End_Cell_ID);
                    
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘下架.ToString())
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.空闲, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_Start_Cell_ID, EnumGSOperateType.系统更新货位操作, "空托盘下架任务完成，更新货位状态");
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.下架.ToString())//下架完成后，删除库存
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.空闲, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_Start_Cell_ID, EnumGSOperateType.系统更新货位操作, "货物下架任务完成，更新货位状态");
                    TaskHandleMethod.UpdatePlanCompleteNum(manageTask.Mange_ID);
                    TaskHandleMethod.DeleteStock(manageTask.Mange_ID);
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.盘点下架.ToString() )
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.空闲, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_Start_Cell_ID, EnumGSOperateType.系统更新货位操作, "货物下架任务完成，更新货位状态");
                    //TaskHandleMethod.UpdatePlanCompleteNum(manageTask.Mange_ID);

                    TaskHandleMethod.DeleteStock(manageTask.Mange_ID);
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.拣选下架.ToString())
                { }
                else
                {
                    return false;
                }
                TaskHandleMethod.CheckPlanCompleteStatus(manageTask.Plan_ID);//检查计划是否完成，如果完成自动更新计划通过计划数量和完成数量相等判断
                TaskHandleMethod.DeleteManageTask(manageTask.Mange_ID);//删除管理任务
                
                TaskHandleMethod.AddStockRecord(manageTask.Mange_ID);
                return true;
            }
            catch(Exception ex)
            {
                WMSManager.wmsFrame.WriteLog("TaskComplete", "", "错误", "任务完成处理失败！"+ex.Message);
                return false;
            }
                 
        }


    }

    public class TaskRunning:TaskStatus
    {
        public TaskRunning()
        { }
        /// <summary>
        /// 任务开始所关联的计划更改为执行中；货位状态锁定（配盘时已经更改成锁定）； 
        /// </summary>
        /// <param name="manageTask"></param>
        /// <returns></returns>
        public override bool ChangeStatus(View_ManageModel manageTask)
        {
            try
            {
                if (manageTask == null)
                {
                    return false;
                }
                //更新计划，无计划可不更新，无计划的计划ID为-1
                if (manageTask.Plan_ID != "-1")//有计划任务
                {
                    if (TaskHandleMethod.UpdatePlanStatus(manageTask.Plan_ID, EnumPlanStatus.执行中) == false)
                    {
                        WMSManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "计划状态更新失败！");
                        return false;
                    }
                }

                if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘上架.ToString())
                {
                    if (TaskHandleMethod.UpdateCellStatus(manageTask.Mange_End_Cell_ID, EnumCellStatus.空料框, EnumGSTaskStatus.锁定) == false)
                    {
                        WMSManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "货位状态更新失败！");
                        return false;
                    }
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.上架.ToString())
                {
                    if (TaskHandleMethod.UpdateCellStatus(manageTask.Mange_End_Cell_ID, EnumCellStatus.满位, EnumGSTaskStatus.锁定) == false)
                    {
                        WMSManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "货位状态更新失败！");
                        return false;
                    }
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘下架.ToString())
                {
                    if (TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.空料框, EnumGSTaskStatus.锁定) == false)
                    {
                        WMSManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "货位状态更新失败！");
                        return false;
                    }
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.盘点下架.ToString()
                  || manageTask.Manage_Type_Name == EnumManageTaskType.下架.ToString())
                {
                    if (TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.满位, EnumGSTaskStatus.锁定) == false)
                    {
                        WMSManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "货位状态更新失败！");
                        return false;
                    }
                }
                else
                {
                    WMSManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "任务类型错误！");
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                WMSManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "任务执行处理失败！"+ex.Message);
                return false;
            }

        }
    }

    public class TaskWaittingToRun:TaskStatus
    {
        public TaskWaittingToRun()
        { }
        public override bool ChangeStatus(View_ManageModel manageTask)
        {
            if (manageTask == null)
            {
                return false;
            }

            if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘上架.ToString())
               
            {

            }
            else if(manageTask.Manage_Type_Name == EnumManageTaskType.上架.ToString())
            {
            
            }
            else if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘下架.ToString()
                || manageTask.Manage_Type_Name == EnumManageTaskType.盘点下架.ToString()
                || manageTask.Manage_Type_Name == EnumManageTaskType.下架.ToString())
            {

            }
            else
            {
                return false;
            }
            return true;

        }
    }
}
