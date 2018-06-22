using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WareAreaManaPresenter : BasePresenter<IWareAreaManaView>
    {
        private WH_AreaBll bllArea = new WH_AreaBll();
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        private Action<string> showAreaProperty = null;
        public WareAreaManaPresenter(IWareAreaManaView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }

        public void ResgistShowAreaProperty(Action<string> showAreaProperty)
        {
            this.showAreaProperty = showAreaProperty;
        }

        public void QueryAreaList(string showAreaProperty)
        {
            if (this.showAreaProperty == null)
            {
                return;
            }
            this.showAreaProperty(showAreaProperty);

        }

        public bool DeleteArea(string areaID)
        {
            WH_AreaModel areaModel = bllArea.GetModel(areaID);
            if(areaID == null)
            {
                this.View.ShowMessage("信息提示", "不存在此区域");
                return false;
            }
            if(areaModel.Area_Type == "暂存区")
            {
                this.View.ShowMessage("信息提示", "暂存区不允许删除！");
                return false;
            }
            return bllArea.Delete(areaID);
        }

        public void InitHouseList()
        {
            List<WH_WareHouseModel> houseList = bllWareHouse.GetModelList("");
            List<string> houseNameList = new List<string>();
            if (houseList != null && houseList.Count != 0)
            {
                for (int i = 0; i < houseList.Count;i++ )
                {
                    houseNameList.Add(houseList[i].WareHouse_Name);
                }
                   
            }
            this.View.RefreshHouseListData(houseNameList);
        }
    }
}
