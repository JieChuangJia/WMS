using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace CommonMoudle
{
    public static class TaskHandleMethod
    {
        private static PlanBll bllPlan = new PlanBll();
        private static WH_Cell_ChildrenBll bllCellChild = new WH_Cell_ChildrenBll();
        private static WH_CellBll bllCell = new WH_CellBll();
        private static ManageBll bllManage = new ManageBll();
        private static Stock_ListBll bllStockList = new Stock_ListBll();
        private static WH_Cell_Operate_RecordBLL bllCellOperateRecord = new WH_Cell_Operate_RecordBLL();
        private static View_CellBLL bllViewCell = new View_CellBLL();
        private static View_ManageStockListBLL bllViewManageStockList = new View_ManageStockListBLL();
        private static View_PlanListBLL bllViewPlanList = new View_PlanListBLL();
        private static Plan_ListBll bllPlanList = new Plan_ListBll();
        private static StockBll bllStock = new StockBll();
        private static RecordBll bllRecord = new RecordBll();
        private static WH_Station_LogicBLL bllStationLogic = new WH_Station_LogicBLL();
        private static Record_ListBll bllRecordList = new Record_ListBll();
        private static View_StockListBLL bllViewStockList = new View_StockListBLL();
        private static WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        private static View_Plan_StockListBLL bllViewPalnStockList = new View_Plan_StockListBLL();
        
        private static Manage_ListBll bllManageList = new Manage_ListBll();
        public static bool UpdatePlanStatus(string planID, EnumPlanStatus planStatus)
        {
            PlanMainModel planModel = bllPlan.GetModel(planID);
            if (planModel == null)
            {
                return false;
            }
            planModel.Plan_Status = planStatus.ToString();
            if (planStatus == EnumPlanStatus.完成)
            {
                planModel.Plan_End_Time = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
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
                    plm.Plan_List_Finished_Quantity = (int.Parse(plm.Plan_List_Finished_Quantity) + int.Parse(manageStock.Manage_List_Quantity)).ToString();
                    //plm.Plan_List_Ordered_Quantity = (int.Parse(plm.Plan_List_Ordered_Quantity) - int.Parse(manageStock.Manage_List_Quantity)).ToString();
                    bllPlanList.Update(plm);
                }
            }

            return true;
        }
        public static bool UpdateCellStatus(string childCellID, EnumCellStatus cellStatus, EnumGSTaskStatus cellRunStatus,EnumGSOperate gsoperate)
        {
            WH_Cell_ChildrenModel childCell = bllCellChild.GetModel(childCellID);
            if (childCell == null)
            {
                return false;
            }
            childCell.Cell_Child_Status = cellStatus.ToString();
            childCell.Cell_Child_Run_Status = cellRunStatus.ToString();
            childCell.Cell_Child_Operate_Type = gsoperate.ToString();
            bllCellChild.Update(childCell);
            return true;
        }

        public static bool UpdateStockCell(string pallet,string cellchlidID,ref string restr)
        {
            StockModel stock = bllStock.GetModelByTrayCode(pallet);
            if(stock == null)
            {
                restr = "库存ID错误！";
                return false;
            }
            stock.Cell_Child_ID = cellchlidID;
            bllStock.Update(stock);
            return true;
        }

        public static bool UpdateManageStartTime(string manageTaskID, DateTime startTime)
        {
            ManageModel manage = bllManage.GetModel(manageTaskID);
            if (manage == null)
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
        public static bool UpdateManageHandleStatus(string manageTaskID, EnumBreakDowmStatus handleStatus)
        {
            ManageModel manage = bllManage.GetModel(manageTaskID);
            if (manage == null)
            {
                return false;
            }
            manage.Manage_BreakDown_Status = handleStatus.ToString();
            return bllManage.Update(manage);
        }

        public static bool UpdateStockUpdateTime(string palletCode, DateTime updateTime)
        {
            List<Stock_ListModel> stockList = bllStockList.GetModelListByPalletCode(palletCode);
            if (stockList == null)
            {
                return false;
            }
            foreach (Stock_ListModel slm in stockList)
            {
                slm.Stock_List_Update_Time = updateTime;
                bllStockList.Update(slm);
            }
            return true;
        }

        public static bool DeleteManageTask(int days)
        {
            return bllManage.DeleteManage(days);
        }

        public static bool AddCellOperRecord(string cellChildID, EnumGSOperateType operType, string operDetail,ref string restr)
        {
            View_CellModel cell = bllViewCell.GetModelByChildCellID(cellChildID);
            if (cell == null)
            {
                restr = "添加Cell操作记录失败，Cell编码错误！";
                return false;
            }
            WH_Cell_Operate_RecordModel cellOperate = new WH_Cell_Operate_RecordModel();
            cellOperate.WareHouse_ID = cell.WareHouse_ID;
            cellOperate.WH_Cell_Code = cell.Cell_Code + ":" + cell.Cell_Chlid_Position;
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
        public static bool UpdateStockPos(string palletID, string cellChildID,ref string restr)
        {
            StockModel stock = bllStock.GetModelByTrayCode(palletID);
            if (stock == null)
            {
              restr ="更新物料位置错误，无此物料货位！";
                return false;
            }
            stock.Cell_Child_ID = cellChildID;
            bllStock.Update(stock);
            restr = "更新成功";
            return true;
        }
        public static bool CheckPlanCompleteStatus(string planID,ref string restr)
        {
            List<Plan_ListModel> planList = bllPlanList.GetModelListByPlanID(planID);
            if (planList == null)
            {
             restr="更新计划状态，没有" + planID + "计划编号！";
             return false;
            }
            bool completeStatus = true;
            foreach (Plan_ListModel pl in planList)
            {
                if (int.Parse(pl.Plan_List_Finished_Quantity) < int.Parse(pl.Plan_List_Quantity))
                {
                    completeStatus = false;
                    break;
                }
            }
            if (completeStatus == true)
            {
                UpdatePlanStatus(planID, EnumPlanStatus.完成);
            }
            restr = "更新计划完成状态成功！";
            return true;
        }

        
        public static bool AddStockRecord(string manageID)
        {
            List<View_ManageStockListModel> manageStockList = bllViewManageStockList.GetModelListByManageID(manageID);

         
           var sdf = manageStockList.Distinct(new ListCompare<View_ManageStockListModel>((x, y) 
                => x.Stock_Tray_Barcode == y.Stock_Tray_Barcode));

           List<View_ManageStockListModel> distintStockList = sdf.ToList();

            if (distintStockList == null && distintStockList.Count == 0)
            {
                return false;
            }
            if (manageStockList == null && manageStockList.Count == 0)
            {
                return false;
            }
            foreach (View_ManageStockListModel manageStock in distintStockList)
            {
                RecordModel record = new RecordModel();

                record.Manage_Begin_Time = manageStock.Manage_Begin_Time;
                record.Manage_End_Time = manageStock.Manage_End_Time;
                record.Manage_Type_Code = manageStock.Mange_Type_ID;


                record.Plan_ID = manageStock.Plan_ID;
                record.Record_ID = Guid.NewGuid().ToString();
                record.Start_Cell_ID = manageStock.Mange_Start_Cell_ID;
                record.End_Cell_ID = manageStock.Mange_End_Cell_ID;

                View_CellModel startCell = bllViewCell.GetModelByChildCellID(manageStock.Mange_Start_Cell_ID);
                View_CellModel endCell = bllViewCell.GetModelByChildCellID(manageStock.Mange_End_Cell_ID);
                if (startCell.Cell_Type == EnumCellType.货位.ToString() && endCell.Cell_Type == EnumCellType.货位.ToString())
                {
                    record.Record_OperateType = EnumCellTransferType.移库.ToString();
                }
                else if (startCell.Cell_Type == EnumCellType.货位.ToString() && endCell.Cell_Type != EnumCellType.货位.ToString())
                {
                    record.Record_OperateType = EnumCellTransferType.出库.ToString();
                }
                else if (startCell.Cell_Type != EnumCellType.货位.ToString() && endCell.Cell_Type == EnumCellType.货位.ToString())
                {
                    record.Record_OperateType = EnumCellTransferType.入库.ToString();
                }

                record.Stock_Tray_Barcode = manageStock.Stock_Tray_Barcode;
                bllRecord.Add(record);
                foreach (View_ManageStockListModel stockList in manageStockList)
                {


                    Record_ListModel recordList = new Record_ListModel();
                    recordList.Goods_ID = stockList.Goods_ID;
                    recordList.Plan_List_ID = stockList.Plan_List_ID;
                    recordList.Record_Box_Barcode = stockList.Stock_List_Box_Barcode;
                    recordList.Record_ID = record.Record_ID;
                    recordList.Record_List_ID = Guid.NewGuid().ToString();
                    recordList.Record_List_Quantity = stockList.Stock_List_Quantity;
                    bllRecordList.Add(recordList);
                }
            }
          
            return true;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="palletCode"></param>
        /// <param name="houseName"></param>
        /// <param name="putawayStationName"></param>
        /// <param name="isAssign"></param>
        /// <param name="targetStation"></param>
        /// <param name="taskType">任务类型</param>
        /// <param name="manageID"></param>
        /// <param name="restr"></param>
        /// <returns></returns>
        public static bool CreatePutawayManageTask(string palletCode, string houseName, string putawayStationName,
            bool isAssign, string targetStation, EnumManageTaskType taskType, ref string manageID, ref string restr)
        {
            ManageModel manage = new ManageModel();
            manage.Mange_CreateTime = DateTime.Now;
            WH_WareHouseModel house = bllWareHouse.GetModelByName(houseName);
            if(house == null)
            {
                restr = "库房对象为空！";
                return false;
            }
            WH_Station_LogicModel stationCell = bllStationLogic.GetStationByName(house.WareHouse_ID,putawayStationName);
            if (stationCell == null)
            {
               restr="上架站台不存在！";
                return false;
            }
            WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
            if (wareHouse == null)
            {
                restr = "库房名称错误！";
                return false;
            }
            View_StockListModel stock = bllViewStockList.GetModelByPalletCode(palletCode, EnumCellType.货位.ToString());
            if (stock != null)
            {
               restr="库存中已经有此托盘条码！";
                return false;
            } 
            View_CellModel targetCell = null;
            if (isAssign == true)//分配货位要做校验
            {
                string[] targetPos = targetStation.Split('-');
                if (targetPos == null || targetPos.Length != 2)
                {
                   restr="指定货位格式错误！";
                    return false;
                }
                string cellName = targetPos[0];
                string cellPos = targetPos[1];
                targetCell = bllViewCell.GetCell(wareHouse.WareHouse_ID, cellName, cellPos);
                if (targetCell == null || targetCell.Cell_Child_Status != EnumCellStatus.空闲.ToString() || targetCell.Cell_Child_Run_Status != EnumGSTaskStatus.完成.ToString())
                {
                    restr = "当前货位不可用！";
                    return false;
                }
            }
            else
            {
                targetCell = bllViewCell.ApplyCell(wareHouse.WareHouse_ID);
            }

            if (targetCell == null)
            {
                restr = "库房已满，没有货位可以申请了！";
                return false;
            }
            if(targetCell.Shelf_Type == EnumShelfType.双深.ToString()&&targetCell.Cell_Chlid_Position ==EnumCellPos.前.ToString())//双深工位如果选中前面的工位要判断后面是否有料
            {
                View_CellModel backCell = bllViewCell.GetCell(wareHouse.WareHouse_ID, targetCell.Cell_Name, EnumCellPos.后.ToString());

                 
                if (backCell != null && backCell.Cell_Child_Run_Status == EnumGSTaskStatus.完成.ToString()&& backCell.Cell_Child_Status== EnumCellStatus.空闲.ToString())
                {
                    restr = "此货位为双深工位 ，需要先送入后面的货位再入前面的货位！";
                    return false;
                }
                if (backCell != null && backCell.Cell_Child_Run_Status == EnumGSTaskStatus.锁定.ToString())
                {
                    restr = "此货位为双深工位 ，需要先送入后面的货位再入前面的货位,后面的工位处于锁定状态！";
                    return false;
                }
            }
            if (targetCell.Cell_Child_Run_Status != EnumGSTaskStatus.完成.ToString() && targetCell.Cell_Child_Status != EnumCellStatus.空闲.ToString())
            {
                restr= "指定货位已经被占用！";
                return false;
            }

            manage.Mange_ID = Guid.NewGuid().ToString();

            manage.Mange_Start_Cell_ID = stationCell.Cell_Child_ID;
            manage.Mange_End_Cell_ID = targetCell.Cell_Chlid_ID;
            manage.Mange_Status = EnumManageTaskStatus.待执行.ToString();
            manage.Manage_BreakDown_Status = "待分解";
            manage.Mange_Stock_Barcode = palletCode;
            if (taskType ==  EnumManageTaskType.空托盘上架)
            {
                manage.Mange_Type_ID = "7";// EnumManageTaskType.空托盘上架.ToString();
            }
            else if(taskType == EnumManageTaskType.上架)
            {
                manage.Mange_Type_ID = "6";//上架
            }
            else
            {
                restr = "任务类型错误！";
                return false;
            }
            View_StockListModel vslm = bllViewStockList.GetModelByPalletCode(palletCode, EnumCellType.配盘工位.ToString());//
            if(vslm == null)
            {
                restr = "没有配盘，请查看！";
                return false;
            }
            EnumOrderType orderType = EnumOrderType.计划;
            if (vslm.Plan_List_ID == "-1")//无计划的
            {
                manage.Plan_ID = "-1";
                orderType = EnumOrderType.非计划;
            }
            else
            {
                orderType = EnumOrderType.计划;
                View_Plan_StockListModel plan = bllViewPalnStockList.GetModelByPalletCode(palletCode);
                if (plan == null)
                {
                    restr = "当前库存没有对应计划！";
                    return false;
                }
                manage.Plan_ID = plan.Plan_ID;
            }
            manageID = manage.Mange_ID;
            bllManage.Add(manage);
            bool status = CreatePutawayManageListTask(manage.Mange_ID,orderType, palletCode, ref restr); 
            if(status == true)
            {
                restr += "生成托盘["+palletCode+"]上架任务成功：终点：" + houseName + targetCell.Cell_Name + targetCell.Cell_Chlid_Position;
                UpdateCellStatus(targetCell.Cell_Chlid_ID, EnumCellStatus.空闲, EnumGSTaskStatus.锁定,  EnumGSOperate.入库);
                return true;
            }
            else
            {
                restr += "生成托盘[" + palletCode + "]上架任务失败：终点：" + houseName + targetCell.Cell_Name + targetCell.Cell_Chlid_Position;
                return false;
            }
        }
       

        public static bool CreateUnshelveManageTask(string planCode, string palletCode,string houseName, string unshelveStationName, ref string manageID,ref string restr)
        {
            ManageModel manage = new ManageModel();
            manage.Mange_CreateTime = DateTime.Now;
            WH_WareHouseModel wareHouse = bllWareHouse.GetModelByName(houseName);
            if (wareHouse == null)
            {
                restr = "库房名称错误！";
                return false;
            }
            WH_Station_LogicModel targetCell = bllStationLogic.GetStationByName(wareHouse.WareHouse_ID,unshelveStationName);
            if (targetCell == null)
            {
                restr = "下架站台不存在！";
                return false;

            }

            View_CellModel startCell = null;
            View_StockListModel stockModel = bllViewStockList.GetModelByPalletCode(palletCode, EnumCellType.货位.ToString());
            if (stockModel == null)
            {
              restr="没有找到所选物料库存！";
                return false;
            }
            startCell = bllViewCell.GetModelByWHAndCellName(stockModel.WareHouse_Name, stockModel.Cell_Name, stockModel.Cell_Chlid_Position);
            if (startCell == null)
            {
                restr = "没有找到所选物料货位！";
                return false;
            }
            if (startCell.Shelf_Type == EnumShelfType.双深.ToString() && startCell.Cell_Chlid_Position == EnumCellPos.后.ToString())//双深工位如果选中前面的工位要判断后面是否有料
            {
                View_CellModel forwordCell = bllViewCell.GetCell(stockModel.WareHouse_ID, stockModel.Cell_Name,EnumCellPos.前.ToString());


                if (forwordCell != null && forwordCell.Cell_Child_Status == "空闲" && forwordCell.Cell_Child_Run_Status== "完成")//前面的已经出去了
                {
                   
                }
                else
                {
                    restr = "双深工位出库需要先将外面的库存出库，再出库里面的！";
                    return false;
                }
            }


            manage.Mange_ID = Guid.NewGuid().ToString();

            manage.Mange_Start_Cell_ID = startCell.Cell_Chlid_ID;
            manage.Mange_End_Cell_ID = targetCell.Cell_Child_ID;
            manage.Mange_Status = EnumManageTaskStatus.待执行.ToString();
            manage.Manage_BreakDown_Status = "待分解";
            manage.Mange_Stock_Barcode = palletCode;

            //manage.Mange_Type_ID = EnumManageTaskType.下架.ToString();
            manage.Mange_Type_ID = "8";//下架
            PlanMainModel planModel = null;
            if (planCode == "-1")
            {
                manage.Plan_ID = "-1";
           
            }
            else
            {
                planModel = bllPlan.GetModelByPlanCode(planCode);
                if (planModel == null)
                {
                    restr = "不存在此计划！";
                    return false;
                }
                manage.Plan_ID = planModel.Plan_ID;
            }
                 
            manageID = manage.Mange_ID;
            bllManage.Add(manage);

            bool status = CreateUnshelveManageListTask(planCode, manage.Mange_ID, palletCode, ref restr);
            if (status == true)
            {
                restr += "生成托盘[" + palletCode + "]下架任务成功：起点：" + startCell.WareHouse_Name + startCell.Cell_Name + startCell.Cell_Chlid_Position;
                EnumCellStatus cellStatus = (EnumCellStatus)Enum.Parse(typeof(EnumCellStatus), startCell.Cell_Child_Status);
                UpdateCellStatus(startCell.Cell_Chlid_ID, cellStatus, EnumGSTaskStatus.锁定,  EnumGSOperate.出库);
                return true;
            }
            else
            {
                restr += "生成托盘[" + palletCode + "]下架任务失败：起点：" + startCell.WareHouse_Name + startCell.Cell_Name + startCell.Cell_Chlid_Position;
                return false;
            }
        }
        public static bool CreateMoveManageTask(string startCellID,string endCellID,ref string restr)
        {
            View_CellModel startCell = bllViewCell.GetModelByChildCellID(startCellID);
            if(startCell == null)
            {
                restr ="起始货位为空！";
                return false;
            }
            View_CellModel endCell = bllViewCell.GetModelByChildCellID(endCellID);
            if(endCell == null)
            {
                restr ="终止货位为空！";
                return false;
            }
            if(startCell.Cell_Child_Status!=EnumCellStatus.满位.ToString()||startCell.Cell_Child_Run_Status!=EnumGSTaskStatus.完成.ToString())
            {
                restr = "起始货位状态错误，不能移库！";
                return false;
            }
            if (endCell.Cell_Child_Status != EnumCellStatus.空闲.ToString() || endCell.Cell_Child_Run_Status != EnumGSTaskStatus.完成.ToString())
            {
                restr = "终止货位状态错误，不能移库！";
                return false;
            }
            List<View_StockListModel> stockList = bllViewStockList.GetModelListByCellID(startCellID);
            //if(stockList== null)
            ManageModel manage = new ManageModel();
            manage.Mange_CreateTime = DateTime.Now;
            manage.Mange_ID = Guid.NewGuid().ToString();
            manage.Manage_BreakDown_Status = "待分解";
            manage.Mange_Start_Cell_ID = startCellID;
            manage.Mange_End_Cell_ID = endCellID;
            manage.Mange_Type_ID = "5";
            if(stockList!=null&&stockList.Count>0)
            {
                manage.Mange_Full_Flag = stockList[0].Stock_Full_Flag;
                manage.Mange_Status = EnumManageTaskStatus.待执行.ToString();
                manage.Mange_Stock_Barcode = stockList[0].Stock_Tray_Barcode;
                manage.Mange_Type_ID = "5";
                Plan_ListModel planList = bllPlanList.GetModel(stockList[0].Plan_List_ID);
                if(planList!= null)
                {
                    manage.Plan_ID = planList.Plan_ID;
                }
                else
                {
                     manage.Plan_ID = "-1";
                }
            }
            else//空托盘
            { 
            
            }
            bllManage.Add(manage);
            bool status = CreateMoveMangeListTask(startCellID, manage.Mange_ID, ref restr);
            if (status == true)
            {
                restr += "生成托盘[" + manage.Mange_Stock_Barcode + "]移库任务成功：起点：" + startCell.WareHouse_Name + startCell.Cell_Name + startCell.Cell_Chlid_Position
                    + "终点：" + endCell.WareHouse_Name + endCell.Cell_Name + endCell.Cell_Chlid_Position ;

                EnumCellStatus cellStatus = (EnumCellStatus)Enum.Parse(typeof(EnumCellStatus), startCell.Cell_Child_Status);
                UpdateCellStatus(startCell.Cell_Chlid_ID, cellStatus, EnumGSTaskStatus.锁定, EnumGSOperate.出库);
                UpdateCellStatus(endCell.Cell_Chlid_ID, EnumCellStatus.空闲, EnumGSTaskStatus.锁定, EnumGSOperate.入库);
                return true;
            }
            else
            {
                restr += "生成托盘[" + manage.Mange_Stock_Barcode + "]移库任务失败：起点：" + startCell.WareHouse_Name + startCell.Cell_Name + startCell.Cell_Chlid_Position
                   + "终点：" + endCell.WareHouse_Name + endCell.Cell_Name + endCell.Cell_Chlid_Position;
                return false;
            }
            
        }

        private static bool CreateMoveMangeListTask(string cellchildID,string manageID,ref string restr)
        {
            List<View_StockListModel> stockList = bllViewStockList.GetModelListByCellID(cellchildID);
            if (stockList == null)
            {
                restr = "储存为空！";
                return false;
            }

            foreach (View_StockListModel stock in stockList)
            {
                Manage_ListModel manageListModel = new Manage_ListModel();

                manageListModel.Manage_List_ID = Guid.NewGuid().ToString();
                
                manageListModel.Manage_List_Quantity = stock.Stock_List_Quantity;
                manageListModel.Mange_ID = manageID;
                manageListModel.Stock_List_ID = stock.Stock_List_ID;
                bllManageList.Add(manageListModel);
            }
            return true;
          
        }
        
        private static bool CreateUnshelveManageListTask(string planCode, string manageID, string palletCode,ref string restr)
        {
            List<View_StockListModel> stockList = bllViewStockList.GetModelListByPalletCode(palletCode, EnumCellType.货位.ToString());
            if (stockList == null)
            {
              restr = "储存为空！";
                return false;
            }

            foreach (View_StockListModel stock in stockList)
            {
                Manage_ListModel manageListModel = new Manage_ListModel();

                manageListModel.Manage_List_ID = Guid.NewGuid().ToString();
                //PlanMainModel plan = bllPlan.GetModelByPlanCode(planCode);

                //Plan_ListModel planList = bllPlanList.GetModelByPlanIDAndGoodsID(plan.Plan_ID, stock.Goods_ID);

                //if (int.Parse(planList.Plan_List_Quantity) > int.Parse(stock.Stock_List_Quantity))
                //{
                //    this.WmsFrame.WriteLog("下架逻辑", "", "提示", "库存数量不足！");
                //    return false;
                //}
                manageListModel.Manage_List_Quantity = stock.Stock_List_Quantity;
                manageListModel.Mange_ID = manageID;
                manageListModel.Stock_List_ID = stock.Stock_List_ID;
                bllManageList.Add(manageListModel);
            }
            return true;
        }
        private static bool CreatePutawayManageListTask(string manageID, EnumOrderType orderType,string palletCode, ref string restr)
        {
            List<View_StockListModel> stockList = bllViewStockList.GetModelListByPalletCode(palletCode, EnumCellType.配盘工位.ToString());
            if (stockList == null)
            {
                restr = "储存为空！";
                return false;
            }
           

            foreach (View_StockListModel stock in stockList)
            {
                Manage_ListModel manageListModel = new Manage_ListModel();
                if(orderType == EnumOrderType.计划)
                {
                    Plan_ListModel planList = bllPlanList.GetModel(stock.Plan_List_ID);

                    planList.Plan_List_Ordered_Quantity = stock.Stock_List_Quantity;
                    bllPlanList.Update(planList);
                }
               
            

                manageListModel.Manage_List_ID = Guid.NewGuid().ToString();
                manageListModel.Manage_List_Quantity = stock.Stock_List_Quantity;
                manageListModel.Mange_ID = manageID;
                manageListModel.Stock_List_ID = stock.Stock_List_ID;
                bllManageList.Add(manageListModel);
            }
            return true;
        }

        
    }

    

    public delegate bool CompareDelegate<T>(T x, T y);
    public class ListCompare<T> : IEqualityComparer<T>
    {
        private CompareDelegate<T> _compare;
        public ListCompare(CompareDelegate<T> d)
        {
            this._compare = d;
        }

        public bool Equals(T x, T y)
        {
            if (_compare != null)
            {
                return this._compare(x, y);
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(T obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}
