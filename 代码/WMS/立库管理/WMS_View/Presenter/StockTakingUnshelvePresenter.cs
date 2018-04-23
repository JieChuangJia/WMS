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
        public StockTakingUnshelvePresenter(IStockTakingUnshelveView view,IWMSFrame wmsframe):base(view,wmsframe)
        { }

        public override void Init()
        {
            base.Init();
            InitHouseList();
        }
        public void InitPosList(string houseName, int rowth)
        {
            List<string> posTypeList = bllViewCell.GetCellPositionType(houseName, rowth);
            this.View.InitPosTypeList(posTypeList);
        }
        private void InitHouseList()
        {
            List<WH_WareHouseModel> houseList = bllHouse.GetModelList("");

            this.View.RefreshHouseListData(houseList);
        }
    }
}
