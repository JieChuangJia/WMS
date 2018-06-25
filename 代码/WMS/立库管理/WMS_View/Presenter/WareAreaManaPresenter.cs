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
        private WH_CellBll bllCell = new WH_CellBll();
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
            
        
            if( bllArea.Delete(areaID)== false)
            {
                this.View.ShowMessage("信息提示", "删除区域失败（数据库操作）！");
                return false;
            }
            //删除区域前，要讲当前对应的货位区域修改为默认库房区域
            WH_AreaModel defaultArea = bllArea.GetModelByName(areaModel.WareHouse_ID,"默认库区");
            if (defaultArea == null)
            {
                this.View.ShowMessage("信息提示", "获取默认库区失败！");
                return false;
            }
            if (bllCell.UpdateCellArea(areaModel.Area_ID, defaultArea.Area_ID) == false)
            {
                this.View.ShowMessage("信息提示", "更改货位默认区域失败！");
                return false;
            }
            return true;

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
