using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS_Database;
using WMS_Interface;
using WMS_Kernel;

namespace Aoyou_WMS
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
        public MainPresenter()
        { }
        public void Init(IWMSFrame wmsFrame)
        {
            wmsManager.Init(wmsFrame);
            wmsManager.ResgistShowMaterialProperty(ShowMaterialProperty);
            wmsManager.ResgistShowUserProperty(ShowUserProperty);
            wmsManager.ResgistShowRoleProperty(ShowRoleProperty);
            wmsManager.ResgistShowAreaProperty(ShowAreaProperty);
            
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

            //ViewDataManager.GOODSVIEWDATA.GoodsListData.Clear();
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

        public void ShowUserProperty(string userInfor)
        {
            List<SysUserModel> userList = bllUser.GetModelByUserInfo(userInfor);
            ViewDataManager.USERVIEWDATA.UserListData.Clear();
            if (userList == null)
            {
                return;
            }

            foreach (SysUserModel user in userList)
            {
                UserDataModel userModel = new UserDataModel();
                userModel.用户名称 = user.SysUser_Name;
                userModel.用户预留 = user.SysUser_Reserve;
                userModel.用户密码 = user.SysUser_Password;
                userModel.角色名称 = user.SysRole_Name;
                ViewDataManager.USERVIEWDATA.UserListData.Add(userModel);
            }
        }

        public void ShowRoleProperty(string roleInfor)
        {
            List<SysRoleModel> roleList = bllRole.GetModelByRoleInfo(roleInfor);
            ViewDataManager.ROLEVIEWDATA.RoleListData.Clear();
            if (roleList == null)
            {
                return;
            }

            foreach (SysRoleModel role in roleList)
            {
                RoleDataModel roleModel = new RoleDataModel();
                roleModel.角色名称 = role.SysRole_Name;
                roleModel.角色备注 = role.SysRole_Remark;
                roleModel.角色描述 = role.SysRole_Desc;
                roleModel.角色等级 = role.SysRole_Level;
                ViewDataManager.ROLEVIEWDATA.RoleListData.Add(roleModel);
            }
        }

        public void ShowAreaProperty(string wareInfo)
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
                AreaDataModel model = new AreaDataModel();
                model.区域名称 = area.Area_Name;
                model.区域启用状态 = area.Area_Flag;
                model.区域类型 = area.Area_Type;
                model.区域编号 = area.Area_ID;
                model.区域编码 = area.Area_Code;
                model.区域颜色 = area.Area_BackColor;
                model.库房名称 = area.WareHouse_ID;
                ViewDataManager.WAREAREAVIEWDATA.AreaListData.Add(model);
            }

        }

        public void ShowAreaColorProperty(string wareName)
        {
            ViewDataManager.WAREAREAVIEWDATA.AreaColorListData.Clear();
            WH_WareHouseModel house = bllWareHouse.GetModelByName(wareName);
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
                AreaColorModel model = new AreaColorModel();
                model.区域名称 = area.Area_Name;
                model.区域颜色 = area.Area_BackColor;
                ViewDataManager.WAREAREAVIEWDATA.AreaColorListData.Add(model);
            }
        }
    }
}
