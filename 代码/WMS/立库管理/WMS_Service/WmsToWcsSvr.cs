using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WMS_Database;
using WMS_Interface;


namespace WMS_Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WmsToWcsSvr : IWMSToWCSSvr
    {
        View_Manage_CellBLL bllViewManageCell = new View_Manage_CellBLL();
        View_CellBLL bllViewCell = new View_CellBLL();
        ManageBll bllManage = new ManageBll();
        WH_Station_LogicBLL bllStationLogic = new WH_Station_LogicBLL();

        #region 老版本wms接口
        public EventHandler EventUpateGsStatus;
        /// <summary>
        /// 货位申请(排、列、层都从1开始计数)
        /// </summary>
        /// <param name="houseName">库名称,管理层、控制层约定好即可</param>
        /// <param name="logicAreaName">库房逻辑区域名称，可以为空为空代表没有分区查询所有</param>
        /// <param name="goodsInfo">货物信息</param>
        /// <param name="cellCoord">若申请成功，返回货位坐标</param>
        /// <param name="reStr">若申请失败，返回原因信息</param>
        /// <returns>申请成功返回true，否则返回false</returns>
        public bool CellRequire(string houseName, string logicAreaName, ref CellCoordModel cellCoord, ref string reStr)
        {

            //View_GoodsSiteModel viewGSModel = bllViewGoodsSite.GetModelByHouseAndAreaName(houseName, logicAreaName);
            //if (viewGSModel == null)
            //{
            //    reStr = "不存在'" + houseName + "'库房！" + logicAreaName + "分区！";
            //    return false;
            //}
            //int requireCellRule = 1;//默认是从最小列开始
            //XmlNode houseCfgNode = xmlOper.GetNodeByName("StoreHouse", houseName);
            //if (houseCfgNode != null)
            //{
            //    XmlNode requireCellRuleNode = houseCfgNode.SelectSingleNode("RequireCellRule");
            //    if (requireCellRuleNode != null)
            //    {
            //        int.TryParse(requireCellRuleNode.InnerText.Trim(), out requireCellRule);
            //    }
            //}
            //View_GoodsSiteModel gsModel = bllViewGoodsSite.ApplyGoodsSite(houseName, logicAreaName, requireCellRule);
            //if (gsModel == null)
            //{
            //    reStr = "没有货位可申请！";
            //    return false;
            //}
            //else
            //{
            //    cellCoord = new CellCoordModel(gsModel.GoodsSiteRow, gsModel.GoodsSiteColumn, gsModel.GoodsSiteLayer);

            //    reStr = "货位申请成功";
            //}

            return true;
        }
        public bool CellRequireByRow(string houseName, string logicAreaName, int row, ref CellCoordModel cellCoord, ref string reStr)
        {

            //View_GoodsSiteModel viewGSModel = bllViewGoodsSite.GetModelByHouseAndAreaName(houseName, logicAreaName);
            //if (viewGSModel == null)
            //{
            //    reStr = "不存在'" + houseName + "'库房！" + logicAreaName + "分区！";
            //    return false;
            //}
            //int requireCellRule = 1;//默认是从最小列开始
            //XmlNode houseCfgNode = xmlOper.GetNodeByName("StoreHouse", houseName);
            //if (houseCfgNode != null)
            //{
            //    XmlNode requireCellRuleNode = houseCfgNode.SelectSingleNode("RequireCellRule");
            //    if (requireCellRuleNode != null)
            //    {
            //        int.TryParse(requireCellRuleNode.InnerText.Trim(), out requireCellRule);
            //    }
            //}
            //View_GoodsSiteModel gsModel = bllViewGoodsSite.ApplyGoodsSiteByRow(houseName, logicAreaName, row, requireCellRule);
            //if (gsModel == null)
            //{
            //    reStr = "没有货位可申请！";
            //    return false;
            //}
            //else
            //{
            //    cellCoord = new CellCoordModel(gsModel.GoodsSiteRow, gsModel.GoodsSiteColumn, gsModel.GoodsSiteLayer);

            //    reStr = "货位申请成功";
            //}

            return true;
        }


        /// <summary>
        /// 获取库存货位剩余量
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="houseAreaName">逻辑库存名称</param>
        /// <param name="gsCount">货位数量</param>
        /// <returns>查询状态</returns>
        public bool GetHouseAreaLeftGs(string houseName, string houseAreaName, ref int gsCount, string reStr)
        {
            //View_GoodsSiteModel viewGSModel = bllViewGoodsSite.GetModelByHouseAndAreaName(houseName, houseAreaName);
            //if (viewGSModel == null)
            //{
            //    reStr = "不存在'" + houseName + "'库房！" + houseAreaName + "分区！";
            //    return false;
            //}
            //gsCount = bllViewGoodsSite.GetHouseAreaLeftGs(houseName, houseAreaName);
            //reStr = "查询成功！";
            return true;
        }
        /// <summary>
        /// 获取库存料框条码列表
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">货位位置</param>
        /// <param name="boxCodeList">料框条码列表</param>
        /// <returns>查询状态</returns>
        public bool GetStockDetail(string houseName, CellCoordModel cellCoord, ref List<string> boxCodeList)
        {
            //boxCodeList = new List<string>();
            //if (cellCoord == null)
            //{
            //    return false;
            //}
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{
            //    return false;
            //}
            //List<View_StockModel> stockList = bllViewStock.GetStockDetail(houseName, cellCoord.Row, cellCoord.Col, cellCoord.Layer);
            //if (stockList == null)
            //{
            //    return false;
            //}
            //for (int i = 0; i < stockList.Count; i++)
            //{
            //    boxCodeList.Add(stockList[i].MeterialboxCode);
            //}
            return true;
        }
        /// <summary>
        /// 查询货位状态
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">货位位置</param>
        /// <param name="cellStatus">货位状态</param>
        /// <param name="taskStatus">货位任务状态</param>
        /// <returns>查询状态</returns>
        public bool GetCellStatus(string houseName, CellCoordModel cellCoord, ref EnumCellStatus cellStatus, ref EnumGSTaskStatus taskStatus)
        {
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{

            //    return false;
            //}
            //GoodsSiteModel gsm = bllGoodsSite.GetModelByRCL(houseModel.StoreHouseID, cellCoord.Row, cellCoord.Col, cellCoord.Layer);
            //if (gsm == null)
            //{
            //    return false;
            //}
            //cellStatus = (EnumCellStatus)Enum.Parse(typeof(EnumCellStatus), gsm.GoodsSiteStatus);
            //taskStatus = (EnumGSTaskStatus)Enum.Parse(typeof(EnumGSTaskStatus), gsm.GoodsSiteTaskStatus);
            return true;
        }
        
        public bool GetLogicAreaName(string houseName, CellCoordModel cell, ref string logicArea)
        {
            //try
            //{
            //    StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //    if (houseModel == null)
            //    {
            //        return false;
            //    }
            //    if (cell == null)
            //    {
            //        return false;
            //    }
            //    GoodsSiteModel gsm = bllGoodsSite.GetModelByRCL(houseModel.StoreHouseID, cell.Row, cell.Col, cell.Layer);
            //    if (gsm == null)
            //    {
            //        return false;
            //    }
            //    View_GoodsSiteModel viewGsm = bllViewGoodsSite.GetModelByGSID(gsm.GoodsSiteID);
            //    if (viewGsm == null)
            //    {
            //        return false;
            //    }
            //    logicArea = viewGsm.StoreHouseAreaName;// (EnumLogicArea)Enum.Parse(typeof(EnumLogicArea), viewGsm.StoreHouseAreaName);
            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}

            return true;
        }
        /// 删除过时的数据
        /// </summary>
        /// <param name="days">天</param>
        /// <returns>删除状态</returns>
        public bool DeletePreviousData(int days)
        {
            //bllStackOper.DeletePreviousData(days);
            return true;
        }
        /// <summary>
        ///查询货位启用状态
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="celCoord">货位位置</param>
        /// <param name="gsEnabledStatus">货位启用状态</param>
        /// <returns>查询状态</returns>
        public bool GetCellEnabledStatus(string houseName, CellCoordModel cellCoord, ref EnumGSEnabledStatus gsEnabledStatus)
        {
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{

            //    return false;
            //}
            //GoodsSiteModel gsm = bllGoodsSite.GetModelByRCL(houseModel.StoreHouseID, cellCoord.Row, cellCoord.Col, cellCoord.Layer);
            //if (gsm == null)
            //{
            //    return false;
            //}
            //if (gsm.GsEnabled == true)
            //{
            //    gsEnabledStatus = EnumGSEnabledStatus.启用;
            //}
            //else
            //{
            //    gsEnabledStatus = EnumGSEnabledStatus.禁用;
            //}

            return true;
        }
        /// <summary>
        /// 货位状态更新,货位申请、出库、入库等改变货位状态后需要调用
        /// </summary>
        /// <param name="houseName"></param>
        /// <param name="cellCoord"></param>
        /// <param name="cellStat"></param>
        /// <param name="taskStatus"></param>
        /// <param name="reStr"></param>
        /// <returns></returns>
        public bool UpdateCellStatus(string houseName, CellCoordModel cellCoord, EnumCellStatus cellStat, EnumGSTaskStatus taskStatus, ref string reStr)
        {
            //bool updateStatus = bllGoodsSite.UpdateModelByRCL(houseName, cellCoord.Row, cellCoord.Col, cellCoord.Layer, cellStat, taskStatus);

            //if (updateStatus == true)
            //{
            //    OnUpdateGsStatus();
            //    //string operateStr = "库房：" + houseName + ",货位：" + cellCoord.Row + "排" + cellCoord.Col + "列" + cellCoord.Layer + "层，" + "货位状态更改为：" + cellStat.ToString() + ";货位任务状态更改为：" + taskStatus.ToString();
            //    //AddGSOperRecord(houseName, cellCoord, EnumGSOperateType.系统修改状态, operateStr,ref reStr);
            //    reStr = "货位更新成功！";
            //    return true;
            //}
            //else
            //{
            //    reStr = "货位更新失败！";
            //    return false;
            //}
            return true;
        }
        /// <summary>
        /// 更新货位启用状态
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">货位位置</param>
        /// <param name="enabledStatus">货位禁用状态</param>
        /// <param name="reStr">执行状态描述</param>
        /// <returns>执行状态</returns>
        public bool UpdateGsEnabledStatus(string houseName, CellCoordModel cellCoord, EnumGSEnabledStatus enabledStatus, ref string reStr)
        {
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{

            //    return false;
            //}
            //GoodsSiteModel gsm = bllGoodsSite.GetModelByRCL(houseModel.StoreHouseID, cellCoord.Row, cellCoord.Col, cellCoord.Layer);
            //if (gsm == null)
            //{
            //    return false;
            //}
            //bool gsEnabledSta = false;
            //if (enabledStatus == EnumGSEnabledStatus.启用)
            //{
            //    gsEnabledSta = true;
            //}
            //else
            //{
            //    gsEnabledSta = false;
            //}
            //bool updateStatus = bllGoodsSite.UpdateGSEnabledStatusByID(gsm.GoodsSiteID, gsEnabledSta);

            //if (updateStatus == true)
            //{
            //    OnUpdateGsStatus();
            //    //string operateStr = "库房：" + houseName + ",货位：" + cellCoord.Row + "排" + cellCoord.Col + "列" + cellCoord.Layer + "层，" + "货位启用状态更改为：" + enabledStatus.ToString();
            //    //AddGSOperRecord(houseName, cellCoord, EnumGSOperateType.系统修改状态, operateStr, ref reStr);

            //    reStr = "货位更新成功！";
            //    return true;
            //}
            //else
            //{
            //    reStr = "货位更新失败！";
            //    return false;
            //}
            return true;
        }
        /// <summary>
        /// 更新货位状态，货位申请、出库、入库等改变货位状态后需要调用
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">货位位置</param>
        /// <param name="cellStat">货位状态</param>
        /// <param name="reStr">执行状态描述</param>
        /// <returns>执行结果</returns>
        public bool UpdateGsStatus(string houseName, CellCoordModel cellCoord, EnumCellStatus cellStat, ref string reStr)
        {
            //bool updateStatus = bllGoodsSite.UpdateGSStatusByRCL(houseName, cellCoord.Row, cellCoord.Col, cellCoord.Layer, cellStat);
            //if (updateStatus == true)
            //{
            //    OnUpdateGsStatus();
            //    //string operateStr = "库房："+houseName+"，货位：" + cellCoord.Row + "排" + cellCoord.Col + "列" + cellCoord.Layer + "层，" + "货位状态更改为：" + cellStat.ToString();
            //    //AddGSOperRecord(houseName, cellCoord, EnumGSOperateType.系统修改状态, operateStr, ref reStr);
            //    reStr = "货位更新成功！";

            //    return true;
            //}
            //else
            //{
            //    reStr = "货位更新失败！";
            //    return false;
            //}
            return true;
        }
        /// <summary>
        /// 更新货位任务状态，货位申请、出库、入库等改变货位状态后需要调用
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">货位位置</param>
        /// <param name="taskStatus">货位任务状态</param>
        /// <param name="reStr">执行状态描述</param>
        /// <returns>执行结果</returns>
        public bool UpdateGsTaskStatus(string houseName, CellCoordModel cellCoord, EnumGSTaskStatus taskStatus, ref string reStr)
        {
            //bool updateStatus = bllGoodsSite.UpdateGsTaskStatusByRCL(houseName, cellCoord.Row, cellCoord.Col, cellCoord.Layer, taskStatus);
            //if (updateStatus == true)
            //{
            //    OnUpdateGsStatus();

            //    //string operateStr = "库房：" + houseName + "，货位：" + cellCoord.Row + "排" + cellCoord.Col + "列" + cellCoord.Layer + "层，" + "货位任务状态更改为：" + taskStatus.ToString();
            //    //AddGSOperRecord(houseName, cellCoord, EnumGSOperateType.系统修改状态, operateStr, ref reStr);
            //    reStr = "货位更新成功！";
            //    return true;
            //}
            //else
            //{
            //    reStr = "货位更新失败！";
            //    return false;
            //}
            return true;
        }

        /// <summary>
        /// 更新货位操作，任务申请，完成后调用
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">库存位置</param>
        /// <param name="gsOper">库存操作</param>
        /// <param name="reStr">执行状态描述</param>
        /// <returns>执行状态结果</returns>
        public bool UpdateGSOper(string houseName, CellCoordModel cellCoord, EnumGSOperate gsOper, ref string reStr)
        {
            //bool updateStatus = bllGoodsSite.UpdateOperateByRCL(houseName, cellCoord.Row, cellCoord.Col, cellCoord.Layer, gsOper);
            //if (updateStatus == false)
            //{
            //    reStr = "数据库更新失败！";
            //    return false;
            //}
            
            return true;
        }

        /// <summary>
        /// 添加货位操作记录，任务完成时调用
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">库存位置</param>
        /// <param name="gsOperType">货位操作类型</param>
        /// <param name="reStr">执行状态描述</param>
        /// <returns>执行状态结果</returns>
        public bool AddGSOperRecord(string houseName, CellCoordModel cellCoord, EnumGSOperateType gsOperType, string operateDetail, ref string reStr)
        {
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{
            //    reStr = "不存在此库房！";
            //    return false;
            //}
            //StockOperRecdModel sorm = new StockOperRecdModel();
            //sorm.GoodsSitePos = cellCoord.Row.ToString() + "-" + cellCoord.Col.ToString() + "-" + cellCoord.Layer.ToString();
            //sorm.OPerateTime = DateTime.Now;
            //sorm.OPerateType = gsOperType.ToString();
            //sorm.OperateDetail = operateDetail;
            //sorm.StoreHouseID = houseModel.StoreHouseID;
            //long addsta = bllStackOper.Add(sorm);
            //if (addsta == 0)
            //{
            //    reStr = "数据添加数据失败！";
            //    return false;
            //}
            //OnUpdateGsStatus();

            return true;
        }
        /// <summary>
        /// 添加库存
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">货位位置</param>
        /// <param name="goodsInfo">库存信息</param>
        /// <param name="reStr">执行状态描述</param>
        /// <returns>执行状态结果</returns>
        public bool AddStack(string houseName, CellCoordModel cellCoord, string proBatch, string[] goodsInfo, ref string reStr)
        {
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{
            //    reStr = "不存在此库房！";
            //    return false;
            //}
            //GoodsSiteModel gsm = bllGoodsSite.GetModelByRCL(houseModel.StoreHouseID, cellCoord.Row, cellCoord.Col, cellCoord.Layer);
            //if (gsm == null)
            //{
            //    reStr = "不存在此库存！";
            //    return false;
            //}
            //if (goodsInfo == null)
            //{
            //    reStr = "传入空货位信息！";
            //    return false;
            //}
            //StockModel sm = new StockModel();
            //sm.GoodsSiteID = gsm.GoodsSiteID;
            //sm.IsFull = true;
            //sm.TrayID = "12345678";//测试
            //long stockID = bllStock.Add(sm);
            //for (int i = 0; i < goodsInfo.Length; i++)
            //{
            //    StockListModel slm = new StockListModel();
            //    slm.StockID = stockID;
            //    slm.InHouseTime = DateTime.Now;
            //    slm.MeterialBatch = proBatch;//暂时没有
            //    slm.MeterialboxCode = goodsInfo[i];
            //    slm.MeterialStatus = "";//暂时没有赋值，若有库存详细应在此增加
            //    long stockListID = bllStockList.Add(slm);

            //    StockDetailModel sdm = new StockDetailModel();
            //    sdm.StockListID = stockListID;
            //    sdm.MeterialName = "电芯";
            //    bllStockDetail.Add(sdm);
            //}
            //string goodsInforStr = "";
            //for (int i = 0; i < goodsInfo.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        goodsInforStr += goodsInfo[i];
            //    }
            //    else
            //    {
            //        goodsInforStr += "," + goodsInfo[i];

            //    }
            //}
           
            return true;
        }

        /// <summary>
        /// 移除库存
        /// </summary>
        /// <param name="houseName">库房信息</param>
        /// <param name="cellCoord">货位位置</param>
        /// <param name="reStr">执行状态描述</param>
        /// <returns>执行状态结果</returns>
        public bool RemoveStack(string houseName, CellCoordModel cellCoord, ref string reStr)
        {
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{
            //    reStr = "不存在此库房！";
            //    return false;
            //}
            //GoodsSiteModel gsm = bllGoodsSite.GetModelByRCL(houseModel.StoreHouseID, cellCoord.Row, cellCoord.Col, cellCoord.Layer);
            //if (gsm == null)
            //{
            //    reStr = "不存在此库存！";
            //    return false;
            //}
            //bool deleSta = bllStock.DeleteModelByGSID(gsm.GoodsSiteID);
            //if (deleSta == false)
            //{
            //    reStr = "数据删除失败！";
            //    return false;
            //}
             
            return true;
        }
        /// <summary>
        /// 添加空料筐库存
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">货位位置</param>
        /// <param name="reStr">执行状态描述</param>
        /// <returns>执行状态结果</returns>
        public bool AddEmptyMeterialBox(string houseName, CellCoordModel cellCoord, ref string reStr)
        {
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{
            //    reStr = "不存在此库房！";
            //    return false;
            //}
            //GoodsSiteModel gsm = bllGoodsSite.GetModelByRCL(houseModel.StoreHouseID, cellCoord.Row, cellCoord.Col, cellCoord.Layer);
            //if (gsm == null)
            //{
            //    reStr = "不存在此库存！";
            //    return false;
            //}
            //gsm.Reserve = cellCoord.ExtProp1;//保存货位扩展属性，目前为空托盘型号 
            //bllGoodsSite.Update(gsm);

            //StockModel sm = new StockModel();
            //sm.GoodsSiteID = gsm.GoodsSiteID;
            //sm.IsFull = true;
            //sm.TrayID = "12345678";//测试
            //long stockID = bllStock.Add(sm);

            //StockListModel slm = new StockListModel();
            //slm.InHouseTime = DateTime.Now;
            //slm.StockID = stockID;
            //slm.MeterialBatch = "";//暂时没有
            //slm.MeterialboxCode = "";
            //slm.MeterialStatus = "";//暂时没有赋值，若有库存详细应在此增加
            //long stockListID = bllStockList.Add(slm);

            //StockDetailModel sdm = new StockDetailModel();
            //sdm.StockListID = stockListID;
            //sdm.MeterialName = "空料筐";
            //bllStockDetail.Add(sdm);

           
            return true;
        }
        /// <summary>
        /// 查询入库时间
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="cellCoord">库存位置</param>
        /// <param name="inputDT">入库时间</param>
        /// <returns>若货位空，返回false</returns>
        public bool GetCellInputTime(string houseName, CellCoordModel cellCoord, ref System.DateTime inputDT)
        {
            //if (cellCoord == null)
            //{
            //    return false;
            //}
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{
            //    return false;
            //}
            //GoodsSiteModel gsm = bllGoodsSite.GetModelByRCL(houseModel.StoreHouseID, cellCoord.Row, cellCoord.Col, cellCoord.Layer);
            //if (gsm == null)
            //{
            //    return false;
            //}
            //StockModel sm = bllStock.GetModelByGSID(gsm.GoodsSiteID);
            //if (sm == null)
            //{
            //    return false;
            //}
            //StockListModel slm = bllStockList.GetModelByStockID(sm.StockID);
            //if (slm == null)
            //{
            //    return false;
            //}

            //inputDT = slm.InHouseTime;
            return true;
        }
        /// <summary>
        /// 获取所有可以出库的货位，自动出库时调用
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="gsList">货位列表</param>
        /// <param name="reStr">执行状态描述</param>
        /// <returns>执行状态结果</returns>
        public bool GetAllowLeftHouseGs(string houseName, ref List<CellCoordModel> gsList, ref string reStr)
        {
            //gsList = new List<CellCoordModel>();
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);
            //if (houseModel == null)
            //{
            //    reStr = "不存在此库房！";
            //    return false;
            //}
            //DataTable allowOutDt = bllGoodsSite.GetModelListByTaskSta(houseModel.StoreHouseID, EnumGSTaskStatus.出库允许.ToString());

            //if (allowOutDt == null)
            //{
            //    reStr = "没有允许出库的库存！";
            //    return false;
            //}

            //for (int i = 0; i < allowOutDt.Rows.Count; i++)
            //{
            //    int rowth = int.Parse(allowOutDt.Rows[i]["GoodsSiteRow"].ToString());
            //    int colth = int.Parse(allowOutDt.Rows[i]["GoodsSiteColumn"].ToString());
            //    int layerth = int.Parse(allowOutDt.Rows[i]["GoodsSiteLayer"].ToString());
            //    CellCoordModel ccm = new CellCoordModel(rowth, colth, layerth);
            //    gsList.Add(ccm);
            //}
            return true;
        }
        /// <summary>
        /// 获取立库单元格数量情况
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="row">排 </param>
        /// <param name="col">列</param>
        /// <param name="layer">层</param>
        /// <param name="reStr">若失败，返回错误信息</param>
        /// <returns></returns>
        public bool GetCellCount(string houseName, ref int row, ref int col, ref int layer, ref string reStr)
        {
            //StoreHouseModel house = bllStoreHouse.GetModelByName(houseName);
            //if (house == null)
            //{
            //    reStr = "库房名称错误！";
            //    return false;
            //}

            //List<int> rows = bllGoodsSite.GetGsRCLData(house.StoreHouseID, 0);
            //List<int> cols = bllGoodsSite.GetGsRCLData(house.StoreHouseID, 1);
            //List<int> layers = bllGoodsSite.GetGsRCLData(house.StoreHouseID, 2);
            //if (rows == null || cols == null || layers == null)
            //{
            //    reStr = "数据库错误！";
            //    return false;
            //}
            //row = rows.Count;
            //col = cols.Count;
            //layer = layers.Count;

            return true;
        }

        /// <summary>
        /// 获取所有货位信息
        /// </summary>
        /// <param name="gsList">所有货位集合</param>
        /// <returns></returns>
        public bool GetAllGsModel(ref  Dictionary<string, GSMemTempModel> gsTempDic, ref string reStr)
        {
            //gsTempDic = new Dictionary<string, GSMemTempModel>();

            //List<View_GoodsSiteModel> allGses = bllViewGoodsSite.GetModelList("");
            //if (allGses == null)
            //{
            //    reStr = "库存货位为空!";
            //    return false;
            //}
            //for (int i = 0; i < allGses.Count; i++)
            //{
            //    GSMemTempModel gsModel = new GSMemTempModel();
            //    gsModel.StoreHouseName = allGses[i].StoreHouseName;
            //    gsModel.StoreAreaName = allGses[i].StoreHouseAreaName;
            //    gsModel.GSEnabled = allGses[i].GsEnabled;
            //    gsModel.GSOperate = allGses[i].GoodsSiteOperate;
            //    gsModel.GSPos = allGses[i].GoodsSitePos;
            //    gsModel.GSStatus = allGses[i].GoodsSiteStatus;
            //    gsModel.GSTaskStatus = allGses[i].GoodsSiteTaskStatus;
            //    gsModel.ExtProp1 = allGses[i].GoodsSite_Reserve;
            //    string keyStr = allGses[i].StoreHouseName + ":" + allGses[i].GoodsSitePos;
            //    gsTempDic[keyStr] = gsModel;
            //}
            //List<View_StockModel> stockList = bllViewStock.GetModelList("");
            //if (stockList == null)//所有货位没有库存的情况直接返回true
            //{
            //    reStr = "查询完毕，此时库房没有库存！";
            //    return true;
            //}

            //for (int i = 0; i < stockList.Count; i++)
            //{
            //    string keyStr = stockList[i].StoreHouseName + ":" + stockList[i].GoodsSitePos;
            //    gsTempDic[keyStr].InHouseDate = stockList[i].InHouseTime;
            //}
            //reStr = "查询完毕！";
            return true;
        }
        /// <summary>
        /// 初始化库存管理层
        /// </summary>
        /// <returns>返回状态</returns>
        public bool Initialize(ref string reStr)
        {
            IniStorage(ref reStr);

            return true;
        }

        /// <summary>
        /// 查询当前库存的产品批次列表
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="batchList">批次列表</param>
        /// <returns>执行状态结果</returns>
        public bool GetStockProductBatch(string houseName, ref  List<string> batchList)
        {
            //if (houseName == "")
            //{
            //    return false;
            //}
            //batchList = new List<string>();
            //batchList = bllViewStock.GetAllBatches(houseName);
            return true;
        }

        /// <summary>
        /// 获取指定库区的出库批次号
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="houseAreaName">库区名称</param>
        /// <param name="batch">批次</param>
        /// <returns>执行状态</returns>
        public bool GetOutBatch(string houseName, string houseAreaName, ref string batch, ref string reStr)
        {

            //View_OutHouseBatchSetModel batchSetModel = bllOutHouseBatch.GetModel(houseName, houseAreaName);
            //if (batchSetModel == null)
            //{
            //    reStr = "此库区无出库批次配置！";
            //    return false;
            //}
            //else
            //{
            //    batch = batchSetModel.Batch;
            //    reStr = "查询成功！";
            //    return true;
            //}
            return true;
        }

        /// <summary>
        /// 产品条码是否在库
        /// </summary>
        /// <param name="houseName">库房名称</param>
        /// <param name="productCode">产品二维码</param>
        /// <param name="reStr">执行结果描述</param>
        /// <returns>若在库则返回在库货位，否则返回空字符串</returns>
        public string IsProductCodeInStore(string houseName, string productCode, ref string reStr)
        {
            //StoreHouseModel house = bllStoreHouse.GetModelByName(houseName);
            //if (house == null)
            //{
            //    reStr = "系统不存在此库房！";
            //    return string.Empty;
            //}

            //View_StockModel stockModel = bllViewStock.GetModel(houseName, productCode);

            //if (stockModel == null)//所有货位没有库存的情况直接返回true
            //{
            //    reStr = "此库房不存在此条码！";
            //    return string.Empty;
            //}
            //return stockModel.GoodsSitePos;
            return string.Empty;
        }
        /// <summary>
        /// 初始化仓库货位（由于数据库操作需要占用几秒时间）
        /// 如果感觉耗时在货位没有发生变化时可以不调用
        /// </summary>
        /// <returns>返回状态</returns>
        private bool IniStorage(ref string reStr)
        {
            IniGoodsSite(ref reStr);
            return true;
        }

        /// <summary>
        ///初始化货位
        /// </summary>
        /// <returns>初始化状态</returns>
        private bool IniGoodsSite(ref string reStr)
        {
            //try
            //{
            //    XmlNodeList houseList = xmlOper.GetNodesByName("StoreHouse");
            //    if (null == houseList)
            //    {
            //        reStr = "获取库房名称失败！";
            //        return false;
            //    }
            //    for (int i = 0; i < houseList.Count; i++)
            //    {
            //        XmlNode house = houseList[i];
            //        bool rebuild = bool.Parse(house.SelectSingleNode("ReBuild").InnerText);
            //        if (rebuild == false)//不需要重新创建进行下一个库房
            //        {
            //            continue;
            //        }
            //        int totalRow = int.Parse(house.SelectSingleNode("GSRowCount").InnerText);
            //        int totalCol = int.Parse(house.SelectSingleNode("GSColCount").InnerText);
            //        int totalLayer = int.Parse(house.SelectSingleNode("GSLayerCount").InnerText);

            //        foreach (XmlAttribute xmlAttri in house.Attributes)
            //        {
            //            string houseName = house.Attributes["name"].Value.ToString();
            //            CreateGoodsSite(houseName, totalRow, totalCol, totalLayer);
            //            ClearInvalidGS(houseName, totalRow, totalCol, totalLayer);
                        
            //        }

            //    }
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    reStr = ex.StackTrace;
            //    return false;
            //}
            return true;
        }
        /// <summary>
        /// 更改货位时的事件触发函数(更改货位颜色)
        /// </summary>
        private void OnUpdateGsStatus()
        {
            if (this.EventUpateGsStatus != null)
            {
                this.EventUpateGsStatus.Invoke(this, null);
            }
        }

        /// <summary>
        /// 清除指定库房货位
        /// </summary>
        /// <param name="houseName"></param>
        private void ClearInvalidGS(string houseName, int totalRow, int totalCol, int totalLayer)
        {
            
            //XmlNode house = xmlOper.GetNodeByName("StoreHouse", houseName);
            //if (house == null)
            //{
            //    return;
            //}
            //XmlNode gSInvalidNode = house.SelectSingleNode("GSInvalidList");
            //if (gSInvalidNode == null)
            //{
            //    return;
            //}

            //XmlNodeList gsInvalidList = gSInvalidNode.SelectNodes("GSItem");
            //if (null == gsInvalidList)//如果都为可用货位就无需操作
            //{
            //    return;
            //}
            //for (int j = 0; j < gsInvalidList.Count; j++)
            //{
            //    string gsName = gsInvalidList[j].InnerText;
            //    string[] rclStr = gsName.Split('-');
            //    int row = int.Parse(rclStr[0]);
            //    int col = int.Parse(rclStr[1]);
            //    int layer = int.Parse(rclStr[2]);
            //    bllGoodsSite.DeleteModelByRCL(houseName, row, col, layer);
            //}

            //bllGoodsSite.DeleteUnnecessaryGs(houseName, totalRow, totalCol, totalLayer);//删除排、列、层以外的

        }
        private bool CreateNewGS(string houseName, int rowth, int colth, int layerth, ref WH_CellModel gsModel)
        {
            //GoodsSiteModel gsm = new GoodsSiteModel();
            //gsm.GoodsSiteColumn = colth;
            //gsm.GoodsSiteOperate = EnumGSOperate.入库.ToString();
            //gsm.GoodsSiteLayer = layerth;
            //gsm.GoodsSiteName = rowth.ToString() + "排" + colth.ToString() + "列" + layerth.ToString() + "层";
            //gsm.GoodsSitePos = rowth.ToString() + "-" + colth.ToString() + "-" + layerth.ToString();
            //gsm.GoodsSiteRow = rowth;
            //gsm.GoodsSiteStatus = EnumCellStatus.空闲.ToString();
            //gsm.GsEnabled = true;
            //StoreHouseModel houseModel = bllStoreHouse.GetModelByName(houseName);//默认简历库区1
            //if (houseModel == null)
            //{
            //    return false;
            //}
            //gsm.StoreHouseID = houseModel.StoreHouseID;
            //gsm.GoodsSiteTaskStatus = EnumGSTaskStatus.完成.ToString();

            //gsModel = gsm;
            return true;
        }
        private void CreateGoodsSite(string houseName, int rowCount, int colCount, int layerCount)
        {
            //for (int r = 1; r < rowCount + 1; r++)
            //{
            //    for (int c = 1; c < colCount + 1; c++)
            //    {
            //        for (int l = 1; l < layerCount + 1; l++)
            //        {
            //            GoodsSiteModel gsm = new GoodsSiteModel();
            //            bool status = CreateNewGS(houseName, r, c, l, ref gsm);
            //            if (false == status)
            //            {
            //                continue;
            //            }
            //            bllGoodsSite.AddModelUntilRemove(gsm);
            //        }
            //    }
            //}
        }
        #endregion

        #region 新版wms接口
        /// <summary>
        /// 获取所有待执行任务,wcs分解完一个管理任务后要将此任务状态更新为执行中状态 
        /// </summary>
        /// <param name="manageTaskList"></param>
        /// <returns></returns>
        public ResposeData GetWaittingToRunTaskList(TaskDeviceModel stDevice, ref List<ManageTaskModel> manageTaskList)
        {
            ResposeData response = new ResposeData();
            manageTaskList = new List<ManageTaskModel>();
            try
            {
                List<View_Manage_CellModel> taskList = bllViewManageCell.GetWattingTaskByDeviceCode(stDevice.DeviceCode);
                if (taskList == null)
                {
                    response.Status = true;
                    response.Describe = "没有待执行的任务！";
                    return response;
                }

                foreach (View_Manage_CellModel manageModel in taskList)
                {
                    ManageTaskModel manage = new ManageTaskModel();
                    manage.PalletCode = manageModel.Mange_Stock_Barcode;
                    TaskDeviceModel startDevice = new TaskDeviceModel();
                    View_CellModel startCell = bllViewCell.GetModelByChildCellID(manageModel.Mange_Start_Cell_ID);
                    if (startCell == null)
                    {
                        response.Status = false;
                        response.Describe = "起始设备编码错误！";
                        return response;
                    }
                    startDevice = FillTaskDevice(startCell, manageModel.Mange_Start_Cell_ID);
                  
                    manage.StartDevice = startDevice;
                    manage.Status = manageModel.Mange_Status;
                    View_CellModel targetCell = bllViewCell.GetModelByChildCellID(manageModel.Mange_End_Cell_ID);
                    if (targetCell == null)
                    {
                        response.Status = false;
                        response.Describe = "目标设备编码错误！";
                        return response;
                    }

                    TaskDeviceModel targetDevice = FillTaskDevice(targetCell, manageModel.Mange_End_Cell_ID);

                    manage.TargetDevice = targetDevice;
                    manage.TaskID = manageModel.Mange_ID;
                    manage.Type = manageModel.Manage_Type_Name;
                    manageTaskList.Add(manage);
                }
                response.Status = true;
                response.Describe = "获取等待执行任务成功！";
                return response;
            }
            catch (Exception ex)
            {
                response.Status = true;
                response.Describe = "获取等待执行任务失败！" + ex.Message;
                return response;
            }
        }
        /// <summary>
        /// 更新指定管理任务状态
        /// </summary>
        /// <param name="manageTaskID">管理任务ID</param>
        /// <param name="taskStatus">管理任务状态：待执行,执行中,完成</param>
        /// <returns></returns>
        public ResposeData UpdateManageTaskStatus(string manageTaskID, string taskStatus)
        {
            ResposeData response = new ResposeData();
            try
            {
                ManageModel task = bllManage.GetModel(manageTaskID);
                if(task == null)
                {
                    response.Status = false;
                    response.Describe = "任务状态更改失败！无此任务ID！";
                }
                task.Mange_Status = taskStatus;
                bllManage.Update(task);
                response.Status = true;
                response.Describe = "任务状态更改成功！";
                return response;
            }
            catch(Exception ex)
            {
                response.Status = false;
                response.Describe = "任务状态更改失败！"+ex.Message;
                return response;
            }
          
        }
        /// <summary>
        /// wcs向wms请求任务
        /// </summary>
        /// <param name="applyTask"></param>
        /// <returns></returns>
        public ResposeData RequireTask(RequireTaskModel requireTask)
        {
            ResposeData response = new ResposeData();
            if(requireTask == null)
            {
                response.Status = false;
                response.Describe = "请求任务对象为空！";
                return response;
            }
            

            try
            {

                ManageModel existMana = bllManage.GetModelByPalletCode(requireTask.PalletCode);
                if(existMana != null)
                {
                    response.Status = false;
                    response.Describe = "此托盘任务已经生成！";
                    return response;
                }
                ManageModel manage = new ManageModel();
                manage.Mange_ID = Guid.NewGuid().ToString();
                WH_Station_LogicModel stationLogic = bllStationLogic.GetModelByCellID(requireTask.RequireDevice.DeviceCode);
                if (stationLogic == null)
                {
                    response.Status = false;
                    response.Describe = "请求设备编号错误！";
                    return response;
                }

                if (requireTask.RequireType == EnumRequireTaskType.空筐入库.ToString())//入库请求设备对应指定库房编码，库房编码和堆垛机编码一致
                {
                    //通过stationLogic得知申请的是哪个库房的入库
                    View_CellModel targetModel = bllViewCell.ApplyCell(stationLogic.WareHouse_ID);
                    if (targetModel == null)
                    {
                        response.Status = false;
                        response.Describe = "已经没有货位可以申请了！";
                        return response; 
                    }
                   
                    manage.Mange_Stock_Barcode = requireTask.PalletCode;
                    manage.Manage_BreakDown_Status ="FALSE";
                    manage.Mange_End_Cell_ID = targetModel.Cell_Chlid_ID;
                    manage.Mange_Full_Flag = "0";
                    manage.Mange_Start_Cell_ID = requireTask.RequireDevice.DeviceCode;
                    manage.Mange_Status = EnumManageTaskStatus.待执行.ToString();
                    manage.Mange_Type_ID = "7";//空托盘上架
                   
                }
                else if (requireTask.RequireType == EnumRequireTaskType.空筐出库.ToString())
                {
                    
                    View_CellModel emptyPalletCell = bllViewCell.GetEmptyPalletCell();
                    if(emptyPalletCell == null)
                    {
                        response.Status = false;
                        response.Describe = "已经没有空托盘可以申请了！";
                        return response; 
                    }
                   
                    manage.Manage_BreakDown_Status  = "FALSE";
                    manage.Mange_End_Cell_ID = requireTask.RequireDevice.DeviceCode;
                    manage.Mange_Full_Flag = "0";

                    manage.Mange_Start_Cell_ID = emptyPalletCell.Cell_Chlid_ID;
                    manage.Mange_Status = EnumManageTaskStatus.待执行.ToString();
                    manage.Mange_Stock_Barcode = requireTask.PalletCode;
                    manage.Mange_Type_ID = "9";//空托盘下架
                    
                }
                else
                {
                    response.Status = false;
                    response.Describe = "请求任务类型错误！";
                    return response;
                }
                bllManage.Add(manage);

                response.Status = true;
                response.Describe = "任务请求成功！";
                return response;
            }
            catch(Exception ex)
            {
                response.Status = false;
                response.Describe = "任务请求失败！"+ex.Message;
                return response;
            }
            
        }
        /// <summary>
        ///taskdevice任务数据赋值
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        private TaskDeviceModel FillTaskDevice(View_CellModel cell,string deviceID)
        {
            TaskDeviceModel taskDevice = new TaskDeviceModel();
            if (cell.Cell_Type == EnumCellType.货位.ToString())
            {
                taskDevice.DeviceType = "货位";
                taskDevice.DeviceCode = cell.WareHouse_ID;
                taskDevice.ExtParam = GetWCSCellCode(cell);
            }
            else
            {
                taskDevice.DeviceType = "工位";
                taskDevice.DeviceCode = deviceID;
            }
            return taskDevice;
        }
        /// <summary>
        /// 获取双深工位排列层编码，wcs双深工位算为两排，wms是一排两个位置，做个转换
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        private string GetWCSCellCode(View_CellModel cell)
        {
            string cellCode = "";
            if (cell.Shelf_Type == EnumShelfType.单深.ToString())
            {
                ////wcs是把双深工位看成两排,需要转换下
                //string[] cellCodeArr = cell.Cell_Code.Split('-');
                cellCode = cell.Cell_Code;
            }
            else//双深
            {
                //wcs是把双深工位看成两排
                 
                string[] cellCodeArr = cell.Cell_Code.Split('-');
                if (cellCodeArr[0] == "1")
                {
                    if (cell.Cell_Chlid_Position == EnumCellPos.前.ToString())
                    {
                        cellCode = (int.Parse(cellCodeArr[0]) + 1).ToString() + "-" + cellCodeArr[1] + "-" + cellCodeArr[2];
                       
                    }
                    else
                    {
                        cellCode = cell.Cell_Code;
                    }
                }
                else //等于2的时候
                {
                    if (cell.Cell_Chlid_Position == EnumCellPos.前.ToString())
                    {
                        cellCode = (int.Parse(cellCodeArr[0]) + 1).ToString() + "-" + cellCodeArr[1] + "-" + cellCodeArr[2];

                    }
                    else
                    {
                        cellCode = (int.Parse(cellCodeArr[0]) + 2).ToString() + "-" + cellCodeArr[1] + "-" + cellCodeArr[2];

                    }
                
                }

            }
            return cellCode;
                 
        }

     
        #endregion

    
    }
}
