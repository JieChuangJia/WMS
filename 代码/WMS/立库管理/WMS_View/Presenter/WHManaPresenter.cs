using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WHManaPresenter : BasePresenter<IWHManaView>
    {
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        private WH_AreaBll bllArea = new WH_AreaBll();
        public WHManaPresenter(IWHManaView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }


        public void QueryWHList()
        {
            ViewDataManager.WHVIEWDATA.WHListData.Clear();
            List<WH_WareHouseModel> modelList = null;

            modelList = bllWareHouse.GetModelList("");
            
            if(modelList == null || modelList.Count == 0)
            {
                return;
            }
            for(int i = 0;i<modelList.Count;i++)
            {
                WareHouseDataModel model = new WareHouseDataModel();
                model.库房编号 = modelList[i].WareHouse_ID;
                model.库房编码 = modelList[i].WareHouse_Code;
                model.库房名称 = modelList[i].WareHouse_Name;
                model.库房类型 = modelList[i].WareHouse_Type;
                model.库房启用 = modelList[i].WareHouse_Flag;
                model.库房备注 = modelList[i].WareHouse_Remark;
                ViewDataManager.WHVIEWDATA.WHListData.Add(model);
            }

        }


        public bool DeleteWareHouse(string whID)
        {
            WH_WareHouseModel whModel = bllWareHouse.GetModel(whID);
            if (whModel == null)
            {
                this.View.ShowMessage("信息提示", "不存在此库房");
                return false;
            }
          
            List<WH_AreaModel> areaList = bllArea.GetModels(whID);
            bool isDel = true;
            if (areaList != null && areaList.Count() != 0)
            {
                
                for (int i = 0; i < areaList.Count;i++ )
                {
                    if (bllArea.Delete(areaList[i].Area_ID) == false)
                    {
                        isDel = false;
                        break; ;
                    }
                }
                   
            }
            if (isDel == false)
            {
                this.View.ShowMessage("信息提示", "删除库房区域失败（数据库操作）！");
                return false;
            }
            if (bllWareHouse.Delete(whID) == false)
            {
                this.View.ShowMessage("信息提示", "删除库房失败（数据库操作）！");
                return false;
            }
            return true;

        }

    }
}
