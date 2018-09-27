using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    /// <summary>
    /// 配盘列表数据模型
    /// </summary>
    public class PalletGoodsListModel
    {

        public int 数量 { get; set; }
        //public DateTime 生产日期 { get; set; }
        public string 托盘条码 { get; set; }
        public string 物料编码 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        //public string 保质期 { get; set; }
    }

    public class PalletData
    {
        public string 托盘条码 { get; set; }
        public string 库房 { get; set; }
        public string 存储货位 { get; set; }
        public string 存储库区 { get; set; }
        public string 入库时间 { get; set; }
        public string 更新时间 { get; set; }
    }

    public class PalletListData
    {
        public string 托盘条码 { get; set; }
        public string 配盘工位名称 { get; set; }
        public string 配盘时间 { get; set; }
        public string 按计划配盘 { get; set; }
        public string 计划单号 { get; set; }


        public PalletListData()
        { }
    }
    public class GoodsPropertyModel
    {
        public string 属性名称 { get; set; }
        public string 属性值 { get; set; }
    }
    public class PalletGoodsList
    {

        public int 数量 { get; set; }

        public string 托盘条码 { get; set; }
        public string 物料编码 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        //public string 保质期 { get; set; }
    }
    public class PlanData
    {
        public string 计划单号 { get; set; }
        public string 计划类型 { get; set; }
        public string 状态 { get; set; }
        public string 制单日期 { get; set; }
        public string 开始时间 { get; set; }
        public string 完成时间 { get; set; }
        public string 制单人 { get; set; }
        //public string 供应商 { get; set; }
        //public string 领料部门 { get; set; }
        public string 备注 { get; set; }
        public PlanData()
        { }
    }
    public class PalletInfor
    {
        public string 托盘条码 { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public int 数量 { get; set; }
        //public string 生产日期 { get; set; }
        public string 库房 { get; set; }
        public string 存储货位 { get; set; }
        public string 计量单位 { get; set; }
        public string 是否满盘 { get; set; }
        public string 存储库区 { get; set; }
        public string 入库时间 { get; set; }
        public string 更新时间 { get; set; }


    }
    public class SysLogViewDataModel
    {
        public DataTable SysLogData { get; set; }
        public SysLogViewDataModel()
        { }

    }
    public class UserDataModel
    {
        public string 用户名称 { get; set; }
        public string 用户密码 { get; set; }

        public string 角色名称 { get; set; }
        public string 用户预留 { get; set; }

        public UserDataModel()
        { }

    }
    public class AreaDataModel
    {
        public string 区域编号 { get; set; }
        public string 库房名称 { get; set; }
        public string 区域名称 { get; set; }
        public string 区域编码 { get; set; }
        public string 区域类型 { get; set; }
        //public string 区域启用状态 { get; set; }
        public string 区域颜色 { get; set; }

        public AreaDataModel()
        { }

    }
    public class WHStationDataModel
    {
        public string 工位逻辑编码 { get; set; }
        public string 工位编码 { get; set; }
        public string 库房编码 { get; set; }
        public string 工位逻辑类型 { get; set; }
        public string 工位逻辑名称 { get; set; }

        public WHStationDataModel()
        { }

    }
    public class WHCellDataModel
    {
        public string 工位编号 { get; set; }
        public string 库区编码 { get; set; }
        public string 工位编码 { get; set; }
        public string 工位名称 { get; set; }
        public string 设备编码 { get; set; }
        public string 工位方向 { get; set; }
        public string 工位类型 { get; set; }

        public WHCellDataModel()
        { }

    }

    public class AreaColorModel
    {
        public string 区域名称 { get; set; }
        public string 区域颜色 { get; set; }

        public AreaColorModel()
        { }

    }
    public class TrayGoodsViewModel
    {
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public string 数量 { get; set; }
        public string 存储库房 { get; set; }
        public string 存储库区 { get; set; }
        public string 存储货位 { get; set; }
        public string 托盘条码 { get; set; }
        public string 是否满盘 { get; set; }
        //public string 生产日期 { get; set; }
        public string 入库时间 { get; set; }

        public string 更新时间 { get; set; }

    }

    public class ManageTask
    {
        public string 托盘条码 { get; set; }
        public string 任务类型 { get; set; }
        public string 任务状态 { get; set; }

        public string 起始位置 { get; set; }
        public string 终止位置 { get; set; }
        public string 操作员 { get; set; }
        public string 创建时间 { get; set; }
        //public string 开始时间 { get; set; }
        public string 完成时间 { get; set; }


        public ManageTask()
        { }
    }
    public class CellGoodsDetailModel
    {
        public string 托盘条码 { get; set; }
        public string 物料条码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        //public string 生产日期 { get;set; }

        public string 数量 { get; set; }
        public string 存储货位 { get; set; }
        public string 计量单位 { get; set; }
        public string 是否满盘 { get; set; }
        public string 存储库区 { get; set; }
        public string 入库时间 { get; set; }
        public string 更新时间 { get; set; }
        public CellGoodsDetailModel()
        { }


    }

    public class RoleDataModel
    {
        public string 角色名称 { get; set; }
        public int 角色等级 { get; set; }

        public string 角色描述 { get; set; }
        public string 角色备注 { get; set; }

        public RoleDataModel()
        { }

    }
    public class PlanDataDetail
    {
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        //public string 批次号 { get; set; }
        //public DateTime 生产日期 { get; set; }
        public string 计量单位 { get; set; }
        public string 计划数量 { get; set; }
        //public string 下达数量 { get; set; }
        public string 完成数量 { get; set; }
        public string 备注 { get; set; }
        public PlanDataDetail()
        { }
    }
    public class GoodsDataModel
    {
        public string 物料编码 { get; set; }
        public string 物料类别 { get; set; }

        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        public string 启用 { get; set; }
        //public string 保质期 { get; set; }
        //public string 启用报警 { get; set; }

        public string 物料内部编码 { get; set; }

        public GoodsDataModel()
        { }

    }

    public class WareHouseDataModel
    {
        public string 库房编号 { get; set; }
        public string 库房编码 { get; set; }

        public string 库房名称 { get; set; }
        public string 库房类型 { get; set; }
        public string 库房启用 { get; set; }
        public string 库房备注 { get; set; }
        public WareHouseDataModel()
        { }
    }
}
