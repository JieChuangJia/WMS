using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;
 
using System.Data;
using Storage;
using System.Drawing;
using WMS_Database;
 

namespace WMS_Kernel
{
    public class StorageViewPresenter:BasePresenter<IStorageView>
    {
        WH_WareHouseBll bllHouse = new WH_WareHouseBll();
        WH_AreaBll bllArea = new WH_AreaBll();

        View_Plan_StockListBLL bllViewPlanStockList = new View_Plan_StockListBLL();

        View_CellBLL bllViewCell = new View_CellBLL();
        View_StockListBLL bllViewStockList = new View_StockListBLL();
        Dictionary<string, Color> gsStatusColor = new Dictionary<string, Color>();

        WH_Cell_ChildrenBll bllChildCell = new WH_Cell_ChildrenBll();
        WH_CellBll bllCell = new WH_CellBll();
        string currHouseName = "A库房";
        string currRowth = "1";
        string currCellPos = "前";
        public StorageViewPresenter(IStorageView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        {
            IniCellStatusColor();
        }
        public void Init()
        {
            InitHouseList();
          
        }
        private void IniCellStatusColor()
        {
            gsStatusColor[EnumCellStatus.空料框.ToString()] = Color.Yellow;
            gsStatusColor[EnumCellStatus.空闲.ToString()] = Color.Transparent;
            gsStatusColor[EnumCellStatus.满位.ToString()] = Color.Green;
            gsStatusColor[EnumGSEnabledStatus.禁用.ToString()] = Color.Red;
            gsStatusColor[EnumGSTaskStatus.锁定.ToString()] = Color.Blue;
            //gsStatusColor[EnumGSTaskStatus.出库允许.ToString()] = Color.Blue;
        }
        private void InitHouseList()
        {
            List<WH_WareHouseModel> houseList = bllHouse.GetModelList("");

            this.View.RefreshHouseListData(houseList);
        }
        public void InitPosList(string houseName,int rowth)
        {
            List<string> posTypeList = bllViewCell.GetCellPositionType(houseName, rowth);
            this.View.InitPosTypeList(posTypeList);
        }
        public void RefreshPosData(string houseName,string row,string posType)
        {
            List<Positions> allPos = new List<Positions>();
            List<View_CellModel> cellList = bllViewCell.GetHouseRowCells(houseName, row, posType);
            foreach (View_CellModel cell in cellList)
           {
                
                Positions posTemp = new Positions();
                bool status = CreatePos(cell, ref posTemp);
                if (status == false)
                {
                    continue;
                }
                allPos.Add(posTemp);
            }
            this.View.RefreshPos(allPos);
            this.currHouseName = houseName;
            this.currRowth = row;
            this.currCellPos = posType;
            //RefreshGsStatusNum(house.StoreHouseID, queryRow);
        }
        public void ModifyGsStatus(string cellChildID, string cellStatus, string cellTaskStatus)
        {
           
            WH_Cell_ChildrenModel oldgsm =  bllChildCell.GetModel(cellChildID);
            if (oldgsm == null)
            {
                return;
            }
            if (oldgsm.Cell_Child_Flag != "1")
            {
                this.WmsFrame.WriteLog("库存看板", "","提示","被禁用的货位不允许修改状态!");
                return;
            }
            View_CellModel cellModel = bllViewCell.GetModelByChildCellID(cellChildID);

            string operteDetail =  cellModel .WareHouse_Name+ "：[" + cellModel.Cell_Name + "]货位状态由[" + oldgsm.Cell_Child_Status + "]变更为[" + cellStatus + "]；" + "货位任务状态由[" + oldgsm.Cell_Child_Run_Status + "]变更为[" + cellTaskStatus + "]";

            oldgsm.Cell_Child_Status =cellStatus;
            oldgsm.Cell_Child_Run_Status = cellTaskStatus;
            bllChildCell.Update(oldgsm);
           TaskHandleMethod.AddCellOperRecord(cellChildID, EnumGSOperateType.手动修改状态,operteDetail);


           this.View.RefreshData();
        }
        public void GetGSDetail(string cellID)
        {

            List<View_StockListModel> modelList =bllViewStockList.GetModelListByCellID(cellID);
            //this.view.RefreshGSDetail(modelList);
            ViewDataManager.STORAGEVIEWDATA.CellGoodsDetailData.Clear();
            if (modelList == null && modelList.Count == 0)
            {
              
                return;
            }
            foreach (View_StockListModel cellGoods in modelList)
            {
                CellGoodsDetailModel cellDetailModel = new CellGoodsDetailModel();
                cellDetailModel.存储货位 = cellGoods.Cell_Name;
                cellDetailModel.存储库区 = cellGoods.Area_Name;
                cellDetailModel.更新时间 = cellGoods.Stock_List_Update_Time.ToString();
                cellDetailModel.规格型号 = cellGoods.Goods_Model;
                cellDetailModel.计量单位 = cellGoods.Goods_Unit;
                cellDetailModel.托盘条码 = cellGoods.Stock_Tray_Barcode;
                cellDetailModel.入库时间 = cellGoods.Stock_List_Entry_Time.ToString();
                cellDetailModel.是否满盘 = cellGoods.Stock_Full_Flag;
                cellDetailModel.数量 = cellGoods.Stock_List_Quantity;
                cellDetailModel.物料名称 = cellGoods.Goods_Name;
                cellDetailModel.物料条码 = cellGoods.Goods_Code;
                ViewDataManager.STORAGEVIEWDATA.CellGoodsDetailData.Add(cellDetailModel);
            }

            //this.currHouseName = modelList[0].StoreHouseName;
            //this.currRowth = modelList[0].GoodsSiteRow;
        }

        public void GetCellDetailByPalletCode(string palletCode)
        {
            View_StockListModel stockModel = bllViewStockList.GetModelByPalletCode(palletCode,EnumCellType.货位.ToString());
            if(stockModel == null)
            {
                this.View.ShowMessage("信息提示", "无此托盘库存信息!");
                return;
            }
            GetGSDetail(stockModel.Cell_Child_ID);
            this.View.SetPosTxt(stockModel.Cell_Chlid_Position);
            this.View.GsSearch((int)stockModel.Cell_Column, (int)stockModel.Cell_Layer);
     
            
        }

        private bool CreatePos(View_CellModel gsModel, ref Positions posRef)
        {
            if (gsModel == null)
            {
                return false;
            }
            Positions pos = new Positions();
            pos.Columnth = (int)gsModel.Cell_Column;
            pos.Layer = (int)gsModel.Cell_Layer;
            pos.Rowth = (int)gsModel.Cell_Row;
            pos.StoreStatus = gsModel.Cell_Child_Status;
            pos.TaskType = gsModel.Cell_Child_Run_Status;
            pos.GoodsSiteID = gsModel.Cell_Chlid_ID;
            if (gsModel.Cell_Child_Flag == "1")
            {
                pos.enbled = true;
            }
            else
            {
                pos.enbled = false;
            }

            pos.Visible = true;
            posRef = pos;
            //此处增加库房和库房区域ID

            pos.Color = gsStatusColor[gsModel.Cell_Child_Status];
            int r = int.Parse(gsModel.Area_BackColor.Split(',')[0]);
            int g = int.Parse(gsModel.Area_BackColor.Split(',')[1]);
            int b = int.Parse(gsModel.Area_BackColor.Split(',')[2]);
            Color areaColor = Color.FromArgb(r, g, b);

            pos.BorderColor = areaColor;


            // pos.BorderColor = Color.LightGray;
            if (gsModel.Cell_Child_Run_Status == EnumGSTaskStatus.锁定.ToString())
            {
                pos.Color = gsStatusColor[gsModel.Cell_Child_Run_Status];
                if (gsModel.Cell_Child_Operate_Type == EnumGSOperate.出库.ToString())
                {
                    pos.PosText = "出";
                }
                else if (gsModel.Cell_Child_Operate_Type == EnumGSOperate.入库.ToString())
                {
                    pos.PosText = "入";
                }
                else if (gsModel.Cell_Child_Operate_Type == EnumGSOperate.移入库.ToString())
                { }
                else if (gsModel.Cell_Child_Operate_Type == EnumGSOperate.移出库.ToString())
                { }
                else
                { }
            }
            if (gsModel.Cell_Child_Run_Status == "出库允许")
            {
                pos.Style = 2;
            }
            else
            {
                pos.Style = 1;
            }

            if (pos.Enbled == false)
            {
                pos.Color = gsStatusColor[EnumGSEnabledStatus.禁用.ToString()];
            }
            return true;
        }
        public void InitHouseRowList(string houseName)
        {
            List<string> rowList = bllViewCell.GetRowListByHouseName(houseName);
            this.View.BingHouseRowData(rowList);
        }

        /// <summary>
        /// 设置整列逻辑区域
        /// </summary>
        /// <param name="houseName"></param>
        /// <param name="colth"></param>
        /// <returns></returns>
        public bool SetMulLayerMulColArea(string logicAreaName, int rowth, int stCol, int edCol, int stLayer, int edLayer)
        {
            //string reStr = "";
          
            //for (int i = stCol; i <= edCol; i++)
            //{
            WH_AreaModel area = bllArea.GetModelByName(logicAreaName);
            if(area == null)
            {
                this.View.ShowMessage("信息提示", "区域名称错误！");
                return false;
            }
            bool status = bllCell.SetMulLayerMulColGsArea(area.Area_ID,  rowth, stCol, edCol, stLayer, edLayer);
            if (status == false)
            {
                this.View.ShowMessage("信息提示", "区域设置错误！");
                return false;
            }
            ////for (int layer = stLayer; layer <= edLayer;layer ++ )
            ////{
            ////    for(int col = stCol;col<=edCol;col++)
            ////    {
            //this.iStorageManage.AddGSOperRecord(houseName, new CellCoordModel(rowth, stCol, stLayer)
            //    , EnumGSOperateType.库存区域设置, "手动多层多列库存区域设置:起始列[" + stCol + "]终止列[" + edCol + "] 起始层[" + stLayer + "]"
            //    + "终止层[" + edLayer + "] 为->" + logicArea.StoreHouseAreaName, ref reStr);
            ////    }
            ////}


            ////}
            this.View.RefreshData();
            
            return true;

        }

        //public bool SetSingleLayerGsArea(string logicAreaName, int rowth, int layer)
        //{
        //    WH_AreaModel area = bllArea.GetModelByName(logicAreaName);
        //    if (area == null)
        //    {
        //        this.View.ShowMessage("信息提示", "区域名称错误！");
        //        return false;
        //    }
        //    return bllCell.gets(logicAreaName, rowth, layer);
        //}

      
        //public bool SetSingleColGsArea(long houseID, long houseAreaID, int rowth, int colth)
        //{
        //    string strSql = "StoreHouseID =" + houseID + " and GoodsSiteRow = " + rowth + " and GoodsSiteColumn =" + colth;
        //    List<GoodsSiteModel> gsList = GetModelList(strSql);
        //    if (gsList == null)
        //    {
        //        return false;
        //    }
        //    for (int i = 0; i < gsList.Count; i++)
        //    {
        //        gsList[i].StoreHouseLogicAreaID = houseAreaID;
        //        Update(gsList[i]);
        //    }
        //    return true;
        //}
    }
}
