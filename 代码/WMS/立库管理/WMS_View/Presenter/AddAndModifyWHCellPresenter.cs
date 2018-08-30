using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Database;
using WMS_Interface;

namespace WMS_Kernel
{
    public class AddAndModifyWHCellPresenter : BasePresenter<IAddAndModifyWHCellView>
    {
        private WH_AreaBll bllArea = new WH_AreaBll();
        private WH_Cell_ChildrenBll bllCellChild = new WH_Cell_ChildrenBll();
        private WH_CellBll bllCell = new WH_CellBll();
        public AddAndModifyWHCellPresenter(IAddAndModifyWHCellView view)
            : base(view,null)
        { }


        public bool AddCellModel(WHCell cell)
        {
          
            WH_Cell_ChildrenModel childModel = new WH_Cell_ChildrenModel();
            WH_AreaModel area = bllArea.GetModelByCode("11001", cell.AreaID);
            if(area == null)
            {
                return false;
            }
            WH_CellModel cellModel = bllCell.GetModel(cell.CellID);
            if(cellModel!= null)
            {
                this.View.ShowMessage("信息提示","此工位编号已存在！");
                return false;
            }
            cellModel = new WH_CellModel();
            cellModel.Cell_ID =cell.CellID;
            cellModel.Area_ID = area.Area_ID;
            cellModel.Cell_Code = cell.CellCode;
            cellModel.Cell_InOut = cell.CellInOut;
            cellModel.Cell_Name = cell.CellName;
            cellModel.Cell_Type = cell.CellType;
            cellModel.Device_Code = cell.CellID;
            cellModel.Cell_Row = 1;
            cellModel.Cell_Column = 1;
            cellModel.Cell_Layer = 1;
            if(bllCell.Add(cellModel))
            {
                childModel.Cell_Child_Flag = "1";
                childModel.Cell_Chlid_ID = cellModel.Cell_ID;
                childModel.Cell_ID = cellModel.Cell_ID;
                return bllCellChild.Add(childModel);
            }
            return false;
        }

        public bool ModifyCellModel(WHCell cell)
        {
            WH_CellModel cellModel = bllCell.GetModel(cell.CellID);
            if (cellModel == null)
            {
                return false;
            }
            WH_AreaModel area = bllArea.GetModelByCode("11001", cell.AreaID);
            if (area == null)
            {
                return false;
            }
            cellModel.Area_ID = area.Area_ID;
            cellModel.Cell_Code = cell.CellCode;
            cellModel.Cell_InOut = cell.CellInOut;
            cellModel.Cell_Name = cell.CellName;
            cellModel.Cell_Type = cell.CellType;
            cellModel.Device_Code = cell.CellID;
            cellModel.Cell_ID = cell.CellID;
            return bllCell.Update(cellModel);
        }

        public void RefreshAreaIDList()
        {
            List<WH_AreaModel> modelList = bllArea.GetModelListByAreaType("暂存区");
            List<string> areaIDList = new List<string>();
            if(modelList != null && modelList.Count != 0)
            {
                for(int i=0;i<modelList.Count;i++)
                {
                    areaIDList.Add(modelList[i].Area_Code);
                }
            }
            this.View.ShowAreaIDList(areaIDList);
        }


    }
}
