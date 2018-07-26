using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class AddAndModifyWHStationPresenter : BasePresenter<IAddAndModifyWHStationView>
    {
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        private WH_Station_LogicBLL bllStationLogic = new WH_Station_LogicBLL();
        private WH_Cell_ChildrenBll bllCellChild = new WH_Cell_ChildrenBll();
        private WH_CellBll bllCell = new WH_CellBll();
        public AddAndModifyWHStationPresenter(IAddAndModifyWHStationView view,IWMSFrame wms)
            : base(view, wms)
        { }

        public override void Init()
        {
            RefreshWareHouseID();
            RefreshStationList();
            RefreshStaionCate();
        }
        public bool AddStationModel(WHStation station)
        {
            WH_Station_LogicModel model = new WH_Station_LogicModel();
            model.WH_Station_Logic = Guid.NewGuid().ToString();
            model.WH_Station_Logic_Name = station.WHStationLogicName;
            model.WH_Station_Logic_Type = station.WHStationLogicType;
            model.WareHouse_ID = station.WareHouseID;
            model.Cell_Child_ID = station.WHCellID;
            //WH_Cell_ChildrenModel child = new WH_Cell_ChildrenModel();
            //child.Cell_Child_Flag = "1";
            //child.Cell_Chlid_ID = station.WHCellID;
            //child.Cell_ID = station.WHCellID;
            //WH_CellModel cellModel = new WH_CellModel();
            //cellModel.Cell_ID = station.WHCellID;
            //cellModel.Cell_Row = 1;
            //cellModel.Cell_Column = 1;
            //cellModel.Cell_Layer = 1;
            //if (!bllCell.Add(cellModel))
            //{
            //    return false;
            //}
            //if (!bllCellChild.Add(child))
            //{
            //    return false;
            //}
            return bllStationLogic.Add(model);
        }

        public bool ModifyStationModel(string oldCellID,WHStation station)
        {
            WH_Station_LogicModel model = bllStationLogic.GetModelByHouseIDAndCellChlidID(station.WareHouseID, oldCellID); 
            if(model == null)
            {
                return false;
            }
            model.WH_Station_Logic_Name = station.WHStationLogicName;
            model.WH_Station_Logic_Type = station.WHStationLogicType;
            model.WareHouse_ID = station.WareHouseID;
            model.Cell_Child_ID = station.WHCellID;

            //WH_Cell_ChildrenModel child = new WH_Cell_ChildrenModel();
            //child.Cell_Child_Flag = "1";
            //child.Cell_Chlid_ID = station.WHCellID;
            //child.Cell_ID = station.WHCellID;
            //if (!bllStationLogic.Delete(station.WHStationLogic))
            //{
            //    return false;
            //}
            //if (!bllCellChild.Delete(oldCellID))
            //{
            //    return false;
            //}
            //if (!bllCell.Delete(oldCellID))
            //{
            //    return false;
            //}
            //WH_CellModel cellModel = new WH_CellModel();
            //cellModel.Cell_ID = station.WHCellID;
            //cellModel.Cell_Row = 1;
            //cellModel.Cell_Column = 1;
            //cellModel.Cell_Layer = 1;
            //if (!bllCell.Add(cellModel))
            //{
            //    return false;
            //}
            //if (!bllCellChild.Add(child))
            //{
            //    return false;
            //}
            if(!bllStationLogic.Update(model))
            {
                return false;
            }
            return true;

            
        }

        private void RefreshWareHouseID()
        {
            List<WH_WareHouseModel> modelList = bllWareHouse.GetModelList("");
            if (modelList == null && modelList.Count == 0)
            {
                return;
            }
            List<string> wareHouseIDList = new List<string>();
            for (int i = 0; i < modelList.Count; i++)
            {
                wareHouseIDList.Add(modelList[i].WareHouse_ID);
            }
            this.View.ShowWareHouseCodeList(wareHouseIDList);
        }

        private void RefreshStationList()
        {
            List<WH_CellModel> stationList = bllCell.GetStationList();
            List<string> items = new List<string>();
            if(stationList== null)
            {
                return;
            }
            foreach(WH_CellModel item in stationList)
            {
                items.Add(item.Cell_ID);
            }
            this.View.ShowStationIDList(items);
        }
        private void RefreshStaionCate()
        {
            //List<string> staionLogicList = bllStationLogic.GetDistinctStationCate();
            List<string> staionLogicList = new List<string>();
            foreach (string item in Enum.GetNames(typeof(EnumStationCate)))
            {
                staionLogicList.Add(item);
            }
            this.View.ShowStationTypeList(staionLogicList);
        }
        public bool IsSaveSameName(WHStation station)
        {
            
            WH_Station_LogicModel model = bllStationLogic.GetStationByName( station.WareHouseID,station.WHStationLogicName);
            if(model != null)
            {
                return true;
            }
            return false;
        }

    }
}
