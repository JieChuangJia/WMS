using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonMoudle;
using WMS_Database;
using WMS_Interface;
using System.Xml;

namespace WMS_Kernel
{
    public class WMSManager
    {
        public static  IWMSFrame wmsFrame = null;  
        private  ThreadBaseModel threadTaskHandler = null;
        private View_ManageBLL bllViewManage = new View_ManageBLL();
        WmsViewManager wmsViewManager = new WmsViewManager();
        private WH_CellBll bllCell = new WH_CellBll();
        private WH_Cell_ChildrenBll bllCellChild = new WH_Cell_ChildrenBll();

        XMLOperater xmlOper = new XMLOperater( AppDomain.CurrentDomain.BaseDirectory + @"\data\WMSClientConfig.xml");
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

            IniGoodsSite(ref restr);
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
                    taskContext.ChangeStatus();
                }
                else if(task.Mange_Status == EnumManageTaskStatus.已完成.ToString())
                {
                    taskContext.SetStatus(task, new TaskComplete());
                    taskContext.ChangeStatus(); 
                }
              
            }
        }

        /// <summary>
        ///初始化货位
        /// </summary>
        /// <returns>初始化状态</returns>
        private bool IniGoodsSite(ref string reStr)
        {
            try
            {
                XmlNodeList houseList = xmlOper.GetNodesByName("StoreHouse");
                if (null == houseList)
                {
                    reStr = "获取库房名称失败！";
                    return false;
                }
                for (int i = 0; i < houseList.Count; i++)
                {
                    XmlNode house = houseList[i];
                    bool rebuild = bool.Parse(house.SelectSingleNode("ReBuild").InnerText);
                    if (rebuild == false)//不需要重新创建进行下一个库房
                    {
                        continue;
                    }
                    XmlNode rowsNode = house.SelectSingleNode("GSRows");
                    XmlNodeList rowNodeList = rowsNode.SelectNodes("GSRow");

                    foreach (XmlNode row in rowNodeList)
                    {
                        string rowIndex = row.Attributes["Index"].Value.ToString();
                        string shelfType = row.Attributes["ShelfType"].Value.ToString();
                        string cols = row.Attributes["Cols"].Value.ToString();
                        string layers = row.Attributes["Layers"].Value.ToString();
                        string houseDeviceID = house.Attributes["DeviceID"].Value.ToString();
                        string areaID = house.Attributes["AreaID"].Value.ToString();
                        CreateRowCells(houseDeviceID, areaID, int.Parse(rowIndex), shelfType, int.Parse(cols), int.Parse(layers));

              
                    }
                    ClearInvalidGS(house.Attributes["name"].Value.ToString());
                }
                
                return true;
            }
            catch (Exception ex)
            {
                reStr = ex.StackTrace;
                return false;
            }

        }

        /// <summary>
        /// 清除指定库房货位
        /// </summary>
        /// <param name="houseName"></param>
        private void ClearInvalidGS(string houseName)
        {
            // string houseName = EnumStoreHouse.A库房.ToString();
            XmlNode house = xmlOper.GetNodeByName("StoreHouse", houseName);
            if (house == null)
            {
                return;
            }
            XmlNode gSInvalidNode = house.SelectSingleNode("GSInvalidList");
            if (gSInvalidNode == null)
            {
                return;
            }

            XmlNodeList gsInvalidList = gSInvalidNode.SelectNodes("GSItem");
            if (null == gsInvalidList)//如果都为可用货位就无需操作
            {
                return;
            }
            for (int j = 0; j < gsInvalidList.Count; j++)
            {
                string gsName = gsInvalidList[j].InnerText;
                string[] rclStr = gsName.Split('-');
                int row = int.Parse(rclStr[0]);
                int col = int.Parse(rclStr[1]);
                int layer = int.Parse(rclStr[2]);
                bllCell.DeleteCells(houseName, row, col, layer);
            }

            XmlNodeList gsInvalidCol= gSInvalidNode.SelectNodes("GSInvalidCol");
            if (null == gsInvalidCol)//如果都为可用货位就无需操作
            {
                return;
            }
            foreach(XmlNode node in gsInvalidCol)
            {
                string invalidRow = node.Attributes["row"].Value.ToString();
                string invalidCol = node.InnerText.Trim();
                bllCell.DeleteColCells(houseName, int.Parse(invalidRow), int.Parse(invalidCol));

            }
            XmlNodeList gsInvalidLayer = gSInvalidNode.SelectNodes("GSInvalidLayer");
            if (null == gsInvalidLayer)//如果都为可用货位就无需操作
            {
                return;
            }
            foreach (XmlNode node in gsInvalidLayer)
            {
                string invalidRow = node.Attributes["row"].Value.ToString();
                string invalidLayer= node.InnerText.Trim();
                bllCell.DeleteLayerCells(houseName, int.Parse(invalidRow), int.Parse(invalidLayer));
            }
            for (int j = 0; j < gsInvalidList.Count; j++)
            {
                string gsName = gsInvalidList[j].InnerText;
                string[] rclStr = gsName.Split('-');
                int row = int.Parse(rclStr[0]);
                int col = int.Parse(rclStr[1]);
                int layer = int.Parse(rclStr[2]);
                bllCell.DeleteCells(houseName, row, col, layer);
            }

            //bllCell.DeleteUnnecessaryGs(houseName, totalRow, totalCol, totalLayer);//删除排、列、层以外的

        }
        private bool CreateCell(string houseDeviceID,string areaID, int rowth, int colth, int layerth,string shelfType)
        {
            WH_CellModel cell = new WH_CellModel();
            cell.Area_ID = areaID;
            cell.Cell_Code = rowth.ToString() + "-" + colth.ToString() + "-" + layerth.ToString();
            cell.Cell_Column = colth;
            cell.Cell_ID = Guid.NewGuid().ToString();
            cell.Cell_InOut = "出入";
            cell.Cell_Layer = layerth;
            cell.Cell_Name = rowth.ToString() + "排" + colth.ToString() + "列" + layerth.ToString() + "层";
           
            cell.Cell_Row = rowth;
            cell.Cell_Type = "货位";
            cell.Device_Code = houseDeviceID;
            cell.Shelf_Type = shelfType;
            bllCell.Add(cell);

            if (shelfType == EnumShelfType.双深.ToString())
            {
                for (int i = 0; i < 2; i++)
                {
                    WH_Cell_ChildrenModel cellChild = new WH_Cell_ChildrenModel();
                    cellChild.Cell_Child_Flag = "1";
                    cellChild.Cell_Child_InOut = "出入";
                    cellChild.Cell_Child_Model = "大";

                    cellChild.Cell_Child_Run_Status = EnumGSTaskStatus.完成.ToString();
                    cellChild.Cell_Child_Status = EnumCellStatus.空闲.ToString();
                    cellChild.Cell_Chlid_ID = Guid.NewGuid().ToString();

                    if (i == 0)
                    {
                        cellChild.Cell_Child_Order = 1;
                        cellChild.Cell_Chlid_Position = EnumCellPos.前.ToString();
                    }
                    else
                    {
                        cellChild.Cell_Child_Order = 2;
                        cellChild.Cell_Chlid_Position = EnumCellPos.后.ToString();
                    }
                    cellChild.Cell_ID = cell.Cell_ID;
                    bllCellChild.Add(cellChild);
                }
            }
            else
            {
                WH_Cell_ChildrenModel cellChild = new WH_Cell_ChildrenModel();
                cellChild.Cell_Child_Flag = "1";
                cellChild.Cell_Child_InOut = "出入";
                cellChild.Cell_Child_Model = "大";

                cellChild.Cell_Child_Run_Status = EnumGSTaskStatus.完成.ToString();
                cellChild.Cell_Child_Status = EnumCellStatus.空闲.ToString();
                cellChild.Cell_Chlid_ID = Guid.NewGuid().ToString();
                cellChild.Cell_Child_Order = 1;
                cellChild.Cell_Chlid_Position = EnumCellPos.前.ToString();
                cellChild.Cell_ID = cell.Cell_ID;
                bllCellChild.Add(cellChild);

            }

            return true;
        }
        private void CreateRowCells(string houseDeviceID, string areaID, int rowth, string shelfType,  int colCount, int layerCount)
        {
            for (int c = 1; c < colCount + 1; c++)
            {
                for (int l = 1; l < layerCount + 1; l++)
                {
                    CreateCell(houseDeviceID, areaID, rowth, c, l, shelfType);
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
                if(int.Parse(pl.Plan_List_Finished_Quantity) < int.Parse(pl.Plan_List_Quantity))
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
                    TaskHandleMethod.DeleteStock(manageTask.Mange_Stock_Barcode);
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
