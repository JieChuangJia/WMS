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
    }
}
