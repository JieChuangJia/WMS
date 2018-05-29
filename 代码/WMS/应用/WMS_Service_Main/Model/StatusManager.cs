using CommonMoudle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Service_Main
{
    public class StatusManager
    {
        public static IWMSFrame wmsFrame = null;
        private ThreadBaseModel threadTaskHandler = null;
        private View_ManageBLL bllViewManage = new View_ManageBLL();
      
        private WH_CellBll bllCell = new WH_CellBll();
        private WH_Cell_ChildrenBll bllCellChild = new WH_Cell_ChildrenBll();
        public StatusManager()
        { }

        public bool Init(IWMSFrame wmsFrame)
        {
            string restr = "";
            threadTaskHandler = new ThreadBaseModel(1, "任务状态监控线程");
            threadTaskHandler.LoopInterval = 100;
            threadTaskHandler.SetThreadRoutine(TaskHandleThread);
            threadTaskHandler.TaskInit(ref restr);
            threadTaskHandler.Start(ref restr);
            StatusManager.wmsFrame = wmsFrame;
          
            return true;
        }
        /// <summary>
        /// 任务状态监控及处理线程
        /// 计划、管理任务、库存、操作记录、Cell状态
        /// </summary>
        private void TaskHandleThread()
        {
            List<View_ManageModel> manageList = bllViewManage.GetModelList("");
            if (manageList == null)
            {
                return;
            }
            TaskContext taskContext = TaskContext.GetContext();

            foreach (View_ManageModel task in manageList)
            {
                if (task.Mange_Status == EnumManageTaskStatus.执行中.ToString())
                {
                    taskContext.SetStatus(task, new TaskRunning());
                    taskContext.ChangeStatus();
                }
                else if (task.Mange_Status == EnumManageTaskStatus.已完成.ToString())
                {
                    taskContext.SetStatus(task, new TaskComplete());
                    taskContext.ChangeStatus();
                }

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

        public void SetStatus(View_ManageModel manageTask, TaskStatus taskStatus)
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
    
    public class TaskComplete : TaskStatus
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
                string restr = "";
                if (manageTask == null)
                {
                    return false;
                }

                if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘上架.ToString())  //空托盘没有库存，无计划
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_End_Cell_ID, EnumCellStatus.空料框, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_End_Cell_ID, EnumGSOperateType.系统添加空料框, "空托盘上架任务完成，更新货位状态",ref restr);

                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.上架.ToString())
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_End_Cell_ID, EnumCellStatus.满位, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_End_Cell_ID, EnumGSOperateType.系统更新货位操作, "物料上架任务完成，更新货位状态", ref restr);
                    TaskHandleMethod.UpdatePlanCompleteNum(manageTask.Mange_ID);
                    TaskHandleMethod.UpdateStockUpdateTime(manageTask.Mange_Stock_Barcode, DateTime.Now);
                    TaskHandleMethod.UpdateStockPos(manageTask.Mange_Stock_Barcode, manageTask.Mange_End_Cell_ID, ref restr);

                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘下架.ToString())
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.空闲, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_Start_Cell_ID, EnumGSOperateType.系统更新货位操作, "空托盘下架任务完成，更新货位状态", ref restr);
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.下架.ToString())//下架完成后，删除库存
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.空闲, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_Start_Cell_ID, EnumGSOperateType.系统更新货位操作, "货物下架任务完成，更新货位状态", ref restr);
                    TaskHandleMethod.UpdatePlanCompleteNum(manageTask.Mange_ID);
                    TaskHandleMethod.DeleteStock(manageTask.Mange_Stock_Barcode);
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.盘点下架.ToString())
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.空闲, EnumGSTaskStatus.完成);
                    TaskHandleMethod.AddCellOperRecord(manageTask.Mange_Start_Cell_ID, EnumGSOperateType.系统更新货位操作, "货物下架任务完成，更新货位状态", ref restr);
                    //TaskHandleMethod.UpdatePlanCompleteNum(manageTask.Mange_ID);

                    TaskHandleMethod.DeleteStock(manageTask.Mange_ID);
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.拣选下架.ToString())
                { }
                else if(manageTask.Manage_Type_Name == EnumManageTaskType.移库.ToString())
                {
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.空闲, EnumGSTaskStatus.完成);
                    TaskHandleMethod.UpdateCellStatus(manageTask.Mange_End_Cell_ID, EnumCellStatus.满位, EnumGSTaskStatus.完成);
                    TaskHandleMethod.UpdateStockCell(manageTask.Mange_Stock_Barcode, manageTask.Mange_End_Cell_ID, ref restr);

                }
                else
                {
                    return false;
                }
                TaskHandleMethod.CheckPlanCompleteStatus(manageTask.Plan_ID, ref restr);//检查计划是否完成，如果完成自动更新计划通过计划数量和完成数量相等判断
                TaskHandleMethod.DeleteManageTask(manageTask.Mange_ID);//删除管理任务               
                TaskHandleMethod.AddStockRecord(manageTask.Mange_ID);
                StatusManager.wmsFrame.WriteLog("服务管理", "", "提示", restr);
                return true;
            }
            catch (Exception ex)
            {
                StatusManager.wmsFrame.WriteLog("服务管理", "", "错误", "任务完成处理失败！" + ex.Message);
                return false;
            }

        }


    }

    public class TaskRunning : TaskStatus
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
                        StatusManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "计划状态更新失败！");
                        return false;
                    }
                }

                if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘上架.ToString())
                {
                    if (TaskHandleMethod.UpdateCellStatus(manageTask.Mange_End_Cell_ID, EnumCellStatus.空料框, EnumGSTaskStatus.锁定) == false)
                    {
                        StatusManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "货位状态更新失败！");
                        return false;
                    }
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.上架.ToString())
                {
                    if (TaskHandleMethod.UpdateCellStatus(manageTask.Mange_End_Cell_ID, EnumCellStatus.满位, EnumGSTaskStatus.锁定) == false)
                    {
                        StatusManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "货位状态更新失败！");
                        return false;
                    }
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.空托盘下架.ToString())
                {
                    if (TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.空料框, EnumGSTaskStatus.锁定) == false)
                    {
                        StatusManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "货位状态更新失败！");
                        return false;
                    }
                }
                else if (manageTask.Manage_Type_Name == EnumManageTaskType.盘点下架.ToString()
                  || manageTask.Manage_Type_Name == EnumManageTaskType.下架.ToString())
                {
                    if (TaskHandleMethod.UpdateCellStatus(manageTask.Mange_Start_Cell_ID, EnumCellStatus.满位, EnumGSTaskStatus.锁定) == false)
                    {
                        StatusManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "货位状态更新失败！");
                        return false;
                    }
                }
                else
                {
                    StatusManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "任务类型错误！");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                StatusManager.wmsFrame.WriteLog("TaskRunning", "", "错误", "任务执行处理失败！" + ex.Message);
                return false;
            }

        }
    }

    public class TaskWaittingToRun : TaskStatus
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
            else if (manageTask.Manage_Type_Name == EnumManageTaskType.上架.ToString())
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
