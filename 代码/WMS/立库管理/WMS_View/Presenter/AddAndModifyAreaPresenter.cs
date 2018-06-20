using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class AddAndModifyAreaPresenter : BasePresenter<IAddAndModifyAreaView>
    {
        private WH_AreaBll bllArea = new WH_AreaBll();
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        public AddAndModifyAreaPresenter(IAddAndModifyAreaView view)
            : base(view,null)
        { }


        public bool AddAreaModel(WareArea area)
        {
            WH_AreaModel model = new WH_AreaModel();
            WH_WareHouseModel house = bllWareHouse.GetModelByName(area.WareHouseName);
            if(house == null)
            {
                return false;
            }
            model.WareHouse_ID = house.WareHouse_ID;
            model.Area_BackColor = area.AreaBackColor;
            model.Area_Code = area.AreaCode;
            model.Area_Name = area.AreaName;
            model.Area_Type = area.AreaType;
            model.Area_Flag = area.AreaEnableStatus;
            model.Area_ID = Guid.NewGuid().ToString();
            return bllArea.Add(model);
        }

        public bool ModifyAreaModel(WareArea area)
        {
            WH_AreaModel model = bllArea.GetModel(area.AreaID); 
            if(model == null)
            {
                return false;
            }
            model.WareHouse_ID = area.WareHouseID;
            model.Area_BackColor = area.AreaBackColor;
            model.Area_Code = area.AreaCode;
            model.Area_Name = area.AreaName;
            model.Area_Type = area.AreaType;
            model.Area_Flag = area.AreaEnableStatus;
            return bllArea.Update(model);
        }


    }
}
