using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public enum EnumAsrsCheckoutMode
    {
        计时出库 =1,
        条件出库 = 2,
        其它=3
    }
    /// <summary>
    /// 货位状态枚举
    /// </summary>
    public enum EnumCellStatus
    {
        空闲,
        满位,
        空料框
    }
    public enum EnumLoglevel
    {
        调试,
        提示,
        警告,
        错误
    }
    /// <summary>
    /// 货位启用状态
    /// </summary>
    public enum EnumGSEnabledStatus
    {
        禁用 = 0,
        启用 = 1

    }
	///库存货位的任务状态
    public enum EnumGSTaskStatus
    {
        锁定,
        完成,
        //出库允许
    }
    /// <summary>
    /// 货位操作状态，申请任务，完成任务后都调用
    /// </summary>
    public enum EnumGSOperate
    {
        无,
        入库,
        出库,
        移入库,
        移出库
    }
    /// <summary>
    /// 货位操作类型，内部记录用，任务完成时调用
    /// </summary>
    public enum EnumGSOperateType
    {
        入库,
        系统修改状态,
        系统自动出库,
        系统更新货位操作,
        系统添加库存,
        系统移除库存,
        手动出库,
        系统添加空料框,
   
        手动修改状态,
        手动移库,
        出厂设置,
        手动删除货位,
        手动增加库存,
        手动删除库存,
        手动启用货位,
        手动禁用货位,
        手动移出库房,
        手动移入库房,
        库存区域设置
    }
   public enum EnumManageTaskStatus
   {
       待执行,
       执行中,
       已完成
   }

    public enum EnumBreakDowmStatus
    {
        待分解,
        已处理
    }
    public enum EnumManageTaskType
    {
        上架,
        下架,
        移库,
        盘点下架,
        拣选下架,
        空托盘上架,
        空托盘下架
    }
    public enum EnumShelfType
    {
        单深,
        双深
    }
    public enum EnumPlanStatus
    {
        待执行,
        执行中,
        完成
    }
    public enum EnumCellType
    {
        货位,
        工位,
        配盘工位,
        上架工位,
        下架工位,
        分选下架
    }
    public enum EnumCellPos
    {
        前,
        后
    }
}
