using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class AddAndModifyWHHousePresenter: BasePresenter<IAddAndModifyWHHouseView>
    {
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        private WH_AreaBll bllArea = new WH_AreaBll();
        public AddAndModifyWHHousePresenter(IAddAndModifyWHHouseView view)
            : base(view,null)
        { }


        public bool AddHuouseModel(WHHouse house)
        {
            WH_WareHouseModel houseModel = bllWareHouse.GetModel(house.WareHouse_ID);
            if (houseModel != null)
            {
                this.View.ShowMessage("信息提示", "此库房编号已存在！");
                return false;
            }
            houseModel = new WH_WareHouseModel();
            houseModel.WareHouse_ID = house.WareHouse_ID;
            houseModel.WareHouse_Code = house.WareHouse_Code;
            houseModel.WareHouse_Flag = house.WareHouse_Flag;
            houseModel.WareHouse_Name = house.WareHouse_Name;
            houseModel.WareHouse_Remark = house.WareHouse_Remark;
            houseModel.WareHouse_Type = house.WareHouse_Type;
            return bllWareHouse.Add(houseModel);
        }

        public bool ModifyHouseModel(WHHouse house)
        {
            WH_WareHouseModel houseModel = bllWareHouse.GetModel(house.WareHouse_ID);
            if (houseModel == null)
            {
                return false;
            }
            houseModel.WareHouse_Code = house.WareHouse_Code;
            houseModel.WareHouse_Flag = house.WareHouse_Flag; 
            houseModel.WareHouse_Name = house.WareHouse_Name;
            houseModel.WareHouse_Remark = house.WareHouse_Remark;
            houseModel.WareHouse_Type = house.WareHouse_Type;

            return bllWareHouse.Update(houseModel);
        }

   

    }
}
