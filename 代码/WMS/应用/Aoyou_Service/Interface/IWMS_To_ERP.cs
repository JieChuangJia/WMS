using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Aoyou_Service
{
    [ServiceContract]
    public interface IWMS_To_ERP
    {
        ///// <summary>
        ///// 服务登录验证
        ///// </summary>
        ///// <param name="userName">用户名</param>
        ///// <param name="password">密码</param>
        ///// <returns></returns>
        //[OperationContract]
        //bool Login(string userName, string password);
        /// <summary>
        /// 基础物料信息导入
        /// </summary>
        /// <param name="basicGoodsInfo"></param>
        /// <returns></returns>
        [OperationContract]
        ResponseData BasicGoodsInfoImport(BasicGoodsInfo basicGoodsInfo);
        /// <summary>
        /// 库房信息
        /// </summary>
        /// <param name="wareHouse">仓库信息</param>
        /// <param name="vgInfo">仓库值集信息</param>
        /// <param name="whShelfRelList">仓库仓位值信息</param>
        /// <returns>执行结果</returns>
        [OperationContract]
        ResponseData WareHouseInfor(WareHouse wareHouse, WH_VGInfo vgInfo, List<WH_Shelf_Rel> whShelfRelList);
        /// <summary>
        /// 仓位信息
        /// </summary>
        /// <param name="shelfVg">仓位值集</param>
        /// <param name="shelfVgList">仓位值</param>
        /// <returns></returns>
        [OperationContract]
        ResponseData CellInfor(Shelf_VG shelfVg, List<Shelf_VG_List> shelfVgList);
        /// <summary>
        /// 收料计划
        /// </summary>
        /// <param name="plan">计划清单</param>
        /// <param name="planList">计划详细列表</param>
        /// <returns></returns>

        [OperationContract]
        ResponseData ReceiveGoodsPlan(Plan plan,List<PlanList> planList) ;
        /// <summary>
        /// 库房启禁用状态
        /// </summary>
        /// <param name="houseCode">库房编码</param>
        /// <param name="enabled">true,启用;false禁用</param>
        /// <returns></returns>
        [OperationContract]
        ResponseData WareHouseEnabled(string houseCode, bool enabled);
        /// <summary>
        /// 删除指定计划
        /// </summary>
        /// <param name="planCode">计划编号</param>
        /// <returns></returns>

        [OperationContract]
        ResponseData DeletePlan(string planCode);
        
    }
    /// <summary>
    /// 物料通知主表
    /// </summary>
    [DataContract]
    public class Plan
    {
        /// <summary>
        /// 单据类型
        /// </summary>
        [DataMember]
        public string PlanType {get;set;}
        /// <summary>
        /// 单据编号
        /// </summary>
        [DataMember]
        public string PlanCode{get;set;}
        /// <summary>
        /// 收料日期
        /// </summary>
        [DataMember]
        public string RecvDateTime{get;set;}
        /// <summary>
        /// 供货方
        /// </summary>
        [DataMember]
        public string Supplyer{get;set;}
        /// <summary>
        /// 结算方
        /// </summary>
        [DataMember]
        public string Settlement{get;set;}

        /// <summary>
        /// 收款方
        /// </summary>
        [DataMember]
        public string Payee{get;set;}

        /// <summary>
        /// 结算组织
        /// </summary>
        [DataMember]
        public string SettlementGroup{get;set;}

        public Plan()
        {}
    }
    /// <summary>
    /// 物料通知表体
    /// </summary>
    [DataContract]
    public class PlanList
    {
        /// <summary>
        /// 物料编码
        /// </summary>
        [DataMember]
        public string GoodsCode { get; set; }
        /// <summary>
        /// 需求组织
        /// </summary>
           [DataMember]
        public string NeedGroup { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
           [DataMember]
        public string GoodsName { get; set; }
        /// <summary>
        /// 物料型号
        /// </summary>
           [DataMember]
        public string GoodsModel { get; set; }
        /// <summary>
        /// 来料检验
        /// </summary>
           [DataMember]
        public bool NeedCheck { get; set; }
        /// <summary>
        /// 收料单位
        /// </summary>
           [DataMember]
        public string RecvUnit { get; set; }
        /// <summary>
        /// 计价单位
        /// </summary>
           [DataMember]
        public string ValuationUnit { get; set; }
        /// <summary>
        /// 库存单位
        /// </summary>
           [DataMember]
        public string StockUnit { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
           [DataMember]
        public string UnitPrice { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [DataMember]
        public string Sum { get; set; }
        /// <summary>
        /// 交货数量
        /// </summary>
        [DataMember]
        public string RecvNum { get; set; }
        
        public PlanList()
        { }
    }
    /// <summary>
    /// 基础物料信息
    /// </summary>
    [DataContract]
    public class BasicGoodsInfo
    {
        /// <summary>
        /// 物料内码
        /// </summary>
        [DataMember]
        public int GoodsInnerCode { get; set; }
        /// <summary>
        /// 物料编码
        /// </summary>
        [DataMember]
        public string GoodsID { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        [DataMember]
        public string GoodsName { get; set; }
        /// <summary>
        /// 物料单位
        /// </summary>
        [DataMember]
        public string GoodsUnit { get; set; }
        /// <summary>
        /// 物料供应商代码
        /// </summary>
        [DataMember]
        public string GoodsApplierCode { get; set; }
        /// <summary>
        /// 物料大类，原材料、半成品、成品
        /// </summary>
        [DataMember]
        public string GoodsClass { get; set; }
        /// <summary>
        /// 物料最小包装数量
        /// </summary>
        [DataMember]
        public int GoodsMinPackNum { get; set; }
        /// <summary>
        /// 物料极性，正极、负极、不区分
        /// </summary>
        [DataMember]
        public string GoodsPolar { get; set; }

        /// <summary>
        /// 物料状态
        /// </summary>
        [DataMember]
        public string GoodsStatus { get; set; }

        /// <summary>
        /// 物料类型模块、五金等
        /// </summary>
        [DataMember]
        public string GoodsType { get; set; }
        /// <summary>
        /// 辅助属性，A等品，B等品
        /// </summary>
        [DataMember]
        public string GoodsAssistProperty { get; set; }

        public BasicGoodsInfo()
        { }

    }
    /// <summary>
    /// 仓库描述类
    /// </summary>

    [DataContract]
    public class WareHouse
    {
        /// <summary>
        /// 仓库主键
        /// </summary>
        [DataMember]
        public string MainID { get; set; }
        /// <summary>
        /// 创建组织
        /// </summary>
        [DataMember]
        public string CreateGroup { get; set; }
        /// <summary>
        /// 使用组织
        /// </summary>
        [DataMember]
        public string UseGroup { get; set; }
        /// <summary>
        /// 仓库编码
        /// </summary>
        [DataMember]
        public string Code { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 仓库属性
        /// </summary>
        [DataMember]
        public string Property { get; set; }
        /// <summary>
        /// 仓库默认状态
        /// </summary>
        [DataMember]
        public string DefaultStatus { get; set; }
        /// <summary>
        /// 启用仓库管理，true：启用，false：不启用
        /// </summary>
        [DataMember]
        public bool EnableMange { get; set; }
        public WareHouse()
        { }

    }
    /// <summary>
    /// 值集信息
    /// </summary>
    [DataContract]
    public class WH_VGInfo
    {

        /// <summary>
        /// 主键
        /// </summary>
        [DataMember]
        public string MainID { get; set; }
        /// <summary>
        /// 仓库主键
        /// </summary>
         [DataMember]
        public string WH_MainID { get; set; }
        /// <summary>
        /// 仓库值集编码
        /// </summary>
         [DataMember]
        public string WH_VG_Code { get; set; }
        /// <summary>
        /// 仓库值集名称
        /// </summary>
         [DataMember]
        public string WH_VG_Name { get; set; }
        public WH_VGInfo()
        { }

    }

    /// <summary>
    /// 仓库、仓位关联类（值信息表）
    /// </summary>
    [DataContract]
    public class WH_Shelf_Rel
    {

        /// <summary>
        /// 极值信息主键
        /// </summary>
         [DataMember]
        public string WH_VG_ID { get; set; }
        /// <summary>
        /// 值
        /// </summary>
         [DataMember]
        public string Value { get; set; }
        /// <summary>
        /// 关联主键
        /// </summary>
         [DataMember]
        public string WH_Shelf_VG_List_ID { get; set; }
        public WH_Shelf_Rel()
        { }
    }
    /// <summary>
    /// 仓位集值
    /// </summary>
    [DataContract]
    public class Shelf_VG
    {
        /// <summary>
        /// 仓位集值主键
        /// </summary>
        [DataMember]
        public string Shelf_VG_MainID { get; set; }
        /// <summary>
        /// 仓位集值编码
        /// </summary>
         [DataMember]
        public string Code { get; set; }
        /// <summary>
        /// 仓位集值名称
        /// </summary>
         [DataMember]
        public string Name { get; set; }
        public Shelf_VG()
        { }

    }
    /// <summary>
    /// 仓位集值列表
    /// </summary>
    [DataContract]
    public class Shelf_VG_List
    {
        /// <summary>
        /// 集值列表主键
        /// </summary>
         [DataMember]
        public string Shelf_VG_List_MainID { get; set; }
        /// <summary>
        /// 集值主键
        /// </summary>
         [DataMember]
        public string Shelf_VG_MainID { get; set; }
        /// <summary>
        /// 集值列表编码
        /// </summary>
         [DataMember]
        public string Code { get; set; }
        /// <summary>
        /// 集值列表名称
        /// </summary>
         [DataMember]
        public string Name { get; set; }
        public Shelf_VG_List()
        { }

    }

}
