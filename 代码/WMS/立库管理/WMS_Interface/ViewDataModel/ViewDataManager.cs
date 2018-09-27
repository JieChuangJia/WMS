using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public static class ViewDataManager
    {
        public static GoodsViewData GOODSVIEWDATA = new GoodsViewData();
        public static StockQueryDataViewModel STOCKQUERYDATAVIEWDATA = new StockQueryDataViewModel();

        public static StorageViewData STORAGEVIEWDATA = new StorageViewData();

        public static PlanInputDataViewModel PLANINPUTDATA = new PlanInputDataViewModel();
        public static PlanManageViewData PLANMANAGEDATSA = new PlanManageViewData();

        public static TrayGoodsManageViewData TRAYGOODSMANAGEDATA = new TrayGoodsManageViewData();

        public static PalletWithPlanViewData PALLETWITHPLANDATA = new PalletWithPlanViewData();

        public static UnShelvePlanViewData UNSHELVEPALNDATA = new UnShelvePlanViewData();

        public static PutawayViewData PUTAWAYVIEWDATA = new PutawayViewData();

        public static TaskListViewData TASKLISTDATA = new TaskListViewData();
        public static PlanQueryViewData PLANQUERYDATA = new PlanQueryViewData();
        public static  PlanQueryViewData TODOLISTDATA = new PlanQueryViewData();
        public static PalletManageViewData PALLETMANAGEDATA = new PalletManageViewData();

        public static SysLogViewData SYSLOGVIEWDATA = new SysLogViewData();

        public static UserViewData USERVIEWDATA = new UserViewData();
        public static RoleViewData ROLEVIEWDATA = new RoleViewData();

        public static WareAreaViewData WAREAREAVIEWDATA = new WareAreaViewData();

        public static WHCellViewData WHCELLVIEWDATA = new WHCellViewData();
        public static WHStationViewData WHSTATIONVIEWDATA = new WHStationViewData();
        public static RecordQueryData RECORDQUERYDATA = new RecordQueryData();
        public static PalletWithoutPlanViewData PALLETWITHOUTPLANDATA = new PalletWithoutPlanViewData();
        public static UnShelveWithoutPlanViewData UNSHELVEWITHPPLANVIEWDATA = new UnShelveWithoutPlanViewData();
        public static WareHouseViewData WHVIEWDATA = new WareHouseViewData();
    }
}
