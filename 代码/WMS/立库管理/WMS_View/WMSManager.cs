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
    public enum WMSFuncModule
    {
        按计划配盘,
        无计划配盘,
        无计划下架,
        按计划下架,
        计划录入,
        计划查询,
        待办工作,
        搬运记录
    }
    public class WMSManager
    {
        public static  IWMSFrame wmsFrame = null;  
        //private  ThreadBaseModel threadTaskHandler = null;
        private View_ManageBLL bllViewManage = new View_ManageBLL();
        WmsViewManager wmsViewManager = new WmsViewManager();
        private WH_CellBll bllCell = new WH_CellBll();
        private WH_Cell_ChildrenBll bllCellChild = new WH_Cell_ChildrenBll();
        private WH_AreaBll bllArea = new WH_AreaBll();
        private WH_WareHouseBll bllHouse = new WH_WareHouseBll();

        XMLOperater xmlOper = null;
        
        public WMSManager()
        { }
        public bool Init(IWMSFrame wmsFrame,string wmsClientCfg,List<WMSFuncModule> moduleList)
        {
            string restr="";
            xmlOper = new XMLOperater(wmsClientCfg);
         
            WMSManager.wmsFrame = wmsFrame;
            wmsViewManager.InitView(wmsFrame, moduleList);

            IniGoodsSite(ref restr);
            return true;
        }


        public void ResgistShowMaterialProperty(Action<string> showMaterialProperty)
        {
            this.wmsViewManager.ResgistShowMaterialProperty(showMaterialProperty);
        }
        public void RegistAllowPutaway(Func<bool> AllowPutaway)
        {
            this.wmsViewManager.RegistAllowPutaway(AllowPutaway);
        }

        //public void ResgistShowUserProperty(Action<string> showUserProperty)
        //{
        //    this.wmsViewManager.ResgistShowUserProperty(showUserProperty);
        //}

        //public void ResgistShowRoleProperty(Action<string> showRoleProperty)
        //{
        //    this.wmsViewManager.ResgistShowRoleProperty(showRoleProperty);
        //}

        //public void ResgistShowAreaProperty(Action<string> showAreaProperty)
        //{
        //    this.wmsViewManager.ResgistShowAreaProperty(showAreaProperty);
        //}


     

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
                    string houseName = house.Attributes["name"].Value.ToString();
                    bool rebuild = bool.Parse(house.SelectSingleNode("ReBuild").InnerText);
                    if (rebuild == false)//不需要重新创建进行下一个库房
                    {
                        continue;
                    }
                   bllCell.DeleteAreaCells(houseName);
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
                    ClearInvalidGS(houseName);
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

}
