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

        //public void ResgistShowAreaProperty(Action<string> showAreaProperty)
        //{
        //    this.showAreaProperty = showAreaProperty;
        //}

        public void QueryAreaList(string wareInfo)
        {
            
                ViewDataManager.WAREAREAVIEWDATA.AreaListData.Clear();
                WH_WareHouseModel house = bllWareHouse.GetModelByName(wareInfo);
                if (house == null)
                {
                    return;
                }
                List<WH_AreaModel> areaList = bllArea.GetModels(house.WareHouse_ID);
                if (areaList == null)
                {
                    return;
                }

                foreach (WH_AreaModel area in areaList)
                {
                    if(area.Area_Type == "暂存区")
                    {
                        continue;//暂存区不显示
                    }
                    AreaDataModel model = new AreaDataModel();
                    model.区域名称 = area.Area_Name;
                    //model.区域启用状态 = area.Area_Flag;
                    model.区域类型 = area.Area_Type;
                    model.区域编号 = area.Area_ID;
                    model.区域编码 = area.Area_Code;
                    model.区域颜色 = area.Area_BackColor;
                    //if(area.Area_Flag =="1")
                    //{
                    //    model.区域启用状态 = "是";
                    //}
                    //else
                    //{
                    //    model.区域启用状态 = "否";
                    //}

                    model.库房名称 = area.WareHouse_ID;
                    ViewDataManager.WAREAREAVIEWDATA.AreaListData.Add(model);
                }

            

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
        /// <summary>
        /// 添加工位区域，工位区域为暂存区
        /// </summary>
        public void AddStationArea()
        {
            List<WH_WareHouseModel> houseList = bllWareHouse.GetModelList("");
            if(houseList==null||houseList.Count==0)
            {
                this.View.ShowMessage("信息提示","请添加库房配置！");
                return;
            }
            WH_AreaModel areaModel = new WH_AreaModel();
            areaModel.Area_BackColor = "12,23,12";
            areaModel.Area_Code = "ZCQ";
            areaModel.Area_Flag = "1";
            areaModel.Area_ID = "ZCQ123456";
            areaModel.Area_Name = "工位暂存区";
            areaModel.Area_Order = 1;
            areaModel.Area_Type="暂存区";

            areaModel.WareHouse_ID = houseList[0].WareHouse_ID;

            WH_AreaModel temp = bllArea.GetModel(areaModel.Area_ID);
            if(temp!=null)
            {
                this.View.ShowMessage("信息提示", "工位暂存区已经存在不需要添加！");
                return;
            }
            bllArea.Add(areaModel);
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
