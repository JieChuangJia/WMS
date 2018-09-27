using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Database;
using WMS_Interface;
using WMS_Kernel;

namespace WMS_Main
{
    public class MainPresenter
    {
        private View_GoodsBLL bllView_Goods = new View_GoodsBLL();
        private SysUserBll bllUser = new SysUserBll();
        private SysRoleBll bllRole = new SysRoleBll();
        private Goods_PropertyBll bllProperty = new Goods_PropertyBll();
        private SysLogBLL bllSysLog = new SysLogBLL();
        private WH_AreaBll bllArea = new WH_AreaBll();
        private WH_WareHouseBll bllWareHouse = new WH_WareHouseBll();
        //private WmsViewManager wmsViewManager = new WmsViewManager();
        private WMSManager wmsManager = new WMSManager();
        private List<WMSFuncModule> wmsFuncList = new List<WMSFuncModule>();
        private ManageBll bllManage = new ManageBll();
        public MainPresenter()
        { }
        /// <summary>
        /// 配置wms所具备的功能模块
        /// </summary>
        private void InitWmsModule()
        {   
            wmsFuncList.Add(WMSFuncModule.无计划下架);
            wmsFuncList.Add(WMSFuncModule.无计划配盘);
          
        }
        public void Init(IWMSFrame wmsFrame)
        {
            InitWmsModule();
            string wmsconfig = AppDomain.CurrentDomain.BaseDirectory + @"\data\WMSClientConfig_JBS.xml";
            wmsManager.Init(wmsFrame, wmsconfig, wmsFuncList);
            wmsManager.ResgistShowMaterialProperty(ShowMaterialProperty);
            wmsManager.RegistAllowPutaway(AllowPutaway);
         
            
        }
        /// <summary>
        /// 只允许一个待执行或者执行中的任务，否则不允许执行上架
        /// </summary>
        /// <returns></returns>
        private bool AllowPutaway()
        {
            List<ManageModel> taskList = bllManage.GetWaitRunTaskListByType("6");//上架任务
            if(taskList==null)
            {
                return false;
            }
            if (taskList != null&&taskList.Count>0)
            {
                return false;
            }
            return true;
        }

        public bool AddDBLog(SysLogModel logModel)
        {
            if(logModel == null)
            {
                return false;
            }
            return bllSysLog.Add(logModel);
        }
        public void ShowMaterialProperty(string goodsInfor)
        {
            List<View_GoodsModel> goodsList = bllView_Goods.GetModelByGoosInfo(goodsInfor);
            ViewDataManager.GOODSVIEWDATA.GoodsListData.Clear();
            if (goodsList == null)
            {
                return;
            }

          
            foreach (View_GoodsModel goods in goodsList)
            {
                GoodsDataModel gsdModel = new GoodsDataModel();
                gsdModel.单位 = goods.Goods_Unit;
                gsdModel.启用 = goods.Goods_Flag;
                gsdModel.规格型号 = goods.Goods_Model;
                gsdModel.物料编码 = goods.Goods_Code;
                gsdModel.物料类别 = goods.Goods_Category;
                gsdModel.物料名称 = goods.Goods_Name;
                gsdModel.物料内部编码 = goods.Goods_ID.ToString();

                ViewDataManager.GOODSVIEWDATA.GoodsListData.Add(gsdModel);
            }
        }

      
    }
}
