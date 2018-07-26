using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class WHCellPresenter : BasePresenter<IWHCellView>
    {
        private WH_CellBll bllCell = new WH_CellBll();
        private WH_Cell_ChildrenBll bllChildCell = new WH_Cell_ChildrenBll();
        public WHCellPresenter(IWHCellView view, IWMSFrame wmsFrame)
            : base(view, wmsFrame)
        { }


        public void QueryCellList()
        {
            ViewDataManager.WHCELLVIEWDATA.WHCellListData.Clear();
            List<WH_CellModel> modelList = null;
       
             modelList = bllCell.GetStationList();
            
            if(modelList == null || modelList.Count == 0)
            {
                return;
            }
            for(int i = 0;i<modelList.Count;i++)
            {
                WHCellDataModel model = new WHCellDataModel();
                model.工位名称 = modelList[i].Cell_Name;
                model.工位方向 = modelList[i].Cell_InOut;
                model.工位类型 = modelList[i].Cell_Type;
                model.工位编号 = modelList[i].Cell_ID;
                model.工位编码 = modelList[i].Cell_Code;
                model.库区编码 = modelList[i].Area_ID;
                model.设备编码 = modelList[i].Device_Code;
                ViewDataManager.WHCELLVIEWDATA.WHCellListData.Add(model);
            }

        }


        public bool DeleteCell(string cellID)
        {
            WH_CellModel cellModel = bllCell.GetModel(cellID);
            if(cellModel == null)
            {
                this.View.ShowMessage("信息提示", "不存在此工位");
                return false;
            }
            if (bllCell.Delete(cellID) == false)
            {
                this.View.ShowMessage("信息提示", "删除工位失败（数据库操作）！");
                return false;
            }
            WH_Cell_ChildrenModel childCellModel = bllChildCell.GetModel(cellID);
            if (childCellModel!= null)
            {
                if (bllChildCell.Delete(cellID) == false)
                {
                    this.View.ShowMessage("信息提示", "删除工位失败（数据库操作）！");
                    return false;
                }
            }
            return true;

        }

    }
}
