using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;
using WMS_Database;

namespace WMS_Kernel
{
    public class TaskListPresenter : BasePresenter<ITaskListView>
    {
        ManageBll bllManage = new ManageBll();
        View_CellBLL bllViewCell = new View_CellBLL();
        View_Plan_ManageBLL bllViewPlanManage = new View_Plan_ManageBLL();
        View_StockListBLL bllViewStockList = new View_StockListBLL();
        View_ManageBLL bllViewManage = new View_ManageBLL();
        public TaskListPresenter(ITaskListView view,IWMSFrame wmsFrame):base(view,wmsFrame)
        { }

        public void Init()
        { 
        
        }

        public void QueryTask(string taskType, string taskStatus)
        {
            List<View_ManageModel> taskList = bllViewManage.GetModelList(taskType, taskStatus);
            ViewDataManager.TASKLISTDATA.TaskListData.Clear();
            if (taskList == null)
            {
                return;
            }
            foreach (View_ManageModel manage in taskList)
            {
                ManageTask task = new ManageTask();
                task.操作员 = manage.Manage_Operater;
                task.结束时间 = manage.Manage_End_Time;
                task.开始时间 = manage.Manage_Begin_Time;
                View_CellModel viewStartCell = bllViewCell.GetModelByChildCellID(manage.Mange_Start_Cell_ID);
                if (manage.Manage_Type_Name == EnumManageTaskType.空托盘上架.ToString()
                    || manage.Manage_Type_Name == EnumManageTaskType.上架.ToString())
                {
                    task.起始位置 = viewStartCell.Cell_Name;
                }
                else if (manage.Manage_Type_Name == EnumManageTaskType.拣选下架.ToString()
                    || manage.Manage_Type_Name == EnumManageTaskType.盘点下架.ToString()
                    || manage.Manage_Type_Name == EnumManageTaskType.下架.ToString())
                {
                    task.起始位置 = viewStartCell.WareHouse_Name + ":" + viewStartCell.Cell_Name;
                }
                View_CellModel viewEndCell = bllViewCell.GetModelByChildCellID(manage.Mange_End_Cell_ID);

                if (manage.Manage_Type_Name == EnumManageTaskType.空托盘上架.ToString()
                   || manage.Manage_Type_Name == EnumManageTaskType.上架.ToString())
                {
                    task.终止位置 = viewEndCell.WareHouse_Name + ":" + viewEndCell.Cell_Name;
                }
                else if (manage.Manage_Type_Name == EnumManageTaskType.拣选下架.ToString()
                    || manage.Manage_Type_Name == EnumManageTaskType.盘点下架.ToString()
                    || manage.Manage_Type_Name == EnumManageTaskType.下架.ToString())
                {
                    task.终止位置 = viewEndCell.Cell_Name;
                }

                task.任务类型 = manage.Manage_Type_Name;
                task.任务状态 = manage.Mange_Status;
                task.托盘条码 = manage.Mange_Stock_Barcode;

                ViewDataManager.TASKLISTDATA.TaskListData.Add(task);
            }
        }
        public void CompleteTaskManual(string palletCode)
        {
            ManageModel task = bllManage.GetModelByPalletCode(palletCode);
            if(task == null)
            {
                this.View.ShowMessage("信息提示", "不存在任务！");
                return;
            }
            task.Mange_Status = EnumManageTaskStatus.完成.ToString();
            bllManage.Update(task);
        }
        public void QueryTaskDetail(string palletCode)
        {
            List<View_StockListModel> stockListModel = bllViewStockList.GetModelListByPalletCode(palletCode);
            ViewDataManager.TASKLISTDATA.TaskDetailData.Clear();
            if(stockListModel == null)
            {
                return;
            }
            foreach(View_StockListModel stockDetail in stockListModel)
            {
                PalletInfor palletInfor = new PalletInfor();
                palletInfor.存储货位 = stockDetail.Cell_Name +"-"+stockDetail.Cell_Chlid_Position;
                palletInfor.存储库区 = stockDetail.Area_Name;
                palletInfor.更新时间 = stockDetail.Stock_List_Update_Time;
                palletInfor.规格型号 = stockDetail.Goods_Model;
                palletInfor.计量单位 = stockDetail.Goods_Unit;
                palletInfor.入库时间 = stockDetail.Stock_List_Entry_Time;
                palletInfor.生产日期 = stockDetail.Goods_ProduceDate;
                if(stockDetail.Stock_Full_Flag == "1")
                {
                   palletInfor.是否满盘 = "是";
                }
                else
                {
                     palletInfor.是否满盘 = "否";
                }

                palletInfor.数量 =int.Parse( stockDetail.Stock_List_Quantity);
                palletInfor.托盘条码 = stockDetail.Stock_Tray_Barcode;
                palletInfor.物料编码 = stockDetail.Goods_Code;
                palletInfor.物料名称 = stockDetail.Goods_Name;

                ViewDataManager.TASKLISTDATA.TaskDetailData.Add(palletInfor);
            }

        }
    }
}
