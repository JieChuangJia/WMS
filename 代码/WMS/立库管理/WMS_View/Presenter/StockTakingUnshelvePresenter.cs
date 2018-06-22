using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class StockTakingUnshelvePresenter:BasePresenter<IStockTakingUnshelveView>
    {
        WH_WareHouseBll bllHouse = new WH_WareHouseBll();
        View_CellBLL bllViewCell = new View_CellBLL();
        WH_CellBll bllCell = new WH_CellBll();
        public StockTakingUnshelvePresenter(IStockTakingUnshelveView view,IWMSFrame wmsframe):base(view,wmsframe)
        { }

        public override void Init()
        {
            base.Init();
            InitHouseList();
        }
        public void InitPosList(string houseName, int rowth)
        {
            WH_WareHouseModel house = bllHouse.GetModelByName(houseName);
            if(house==null)
            {
                return;
            }
            List<string> posTypeList = bllCell.GetCellPositionType(house.WareHouse_ID, rowth);
            this.View.InitPosTypeList(posTypeList);
        }
        private void InitHouseList()
        {
            List<WH_WareHouseModel> houseList = bllHouse.GetModelList("");

            this.View.RefreshHouseListData(houseList);
        }
    }
}
