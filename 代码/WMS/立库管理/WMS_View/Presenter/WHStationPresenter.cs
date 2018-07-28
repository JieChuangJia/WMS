using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WHStationPresenter : BasePresenter<IWHStationView>
    {
        private WH_Station_LogicBLL bllStationLogic = new WH_Station_LogicBLL();
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();

        public WHStationPresenter(IWHStationView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }



        public void QueryStationList(string houseID)
        {
            ViewDataManager.WHSTATIONVIEWDATA.WHStationListData.Clear();
            List<WH_Station_LogicModel> logicModelList = bllStationLogic.GetModelListByHouseID(houseID);
            if(logicModelList == null || logicModelList.Count == 0)
            {
                return;
            }
            for(int i = 0;i<logicModelList.Count;i++)
            {
                WHStationDataModel model = new WHStationDataModel();
                model.工位编码 = logicModelList[i].Cell_Child_ID;
                model.工位逻辑名称 = logicModelList[i].WH_Station_Logic_Name;
                model.工位逻辑类型 = logicModelList[i].WH_Station_Logic_Type;
                model.工位逻辑编码 = logicModelList[i].WH_Station_Logic;
                model.库房编码 = logicModelList[i].WareHouse_ID;
                ViewDataManager.WHSTATIONVIEWDATA.WHStationListData.Add(model);
            }
        }
        

        public bool DeleteStationLogic(string whStationLogic)
        {
            WH_Station_LogicModel stationLogicModel = bllStationLogic.GetModel(whStationLogic);
            if (stationLogicModel == null)
            {
                this.View.ShowMessage("信息提示", "不存在此工位逻辑");
                return false;
            }


            if (bllStationLogic.Delete(whStationLogic) == false)
            {
                this.View.ShowMessage("信息提示", "删除工位逻辑失败（数据库操作）！");
                return false;
            }
            return true;

        }

        public void InitHouseIDList()
        {
            List<WH_WareHouseModel> houseList = bllWareHouse.GetModelList("");
            List<string> houseIDList = new List<string>();
            if (houseList != null && houseList.Count != 0)
            {
                for (int i = 0; i < houseList.Count;i++ )
                {
                    houseIDList.Add(houseList[i].WareHouse_ID);
                }
                   
            }
            this.View.RefreshHouseListData(houseIDList);
        }
    }
}
