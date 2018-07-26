using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;
using WMS_Database;

namespace WMS_Kernel
{
    public class RecordQueryPresenter:BasePresenter<IRecordQueryView>
    {
        public RecordQueryPresenter(IRecordQueryView view,IWMSFrame wms):base(view,wms)
        { }

        public void QueryRecord(DateTime startDate,DateTime endDate,string cellCode,string planCode)
        {
            ViewDataManager.RECORDQUERYDATA.RecordList.Clear();
            ViewDataManager.RECORDQUERYDATA.RecordDetailList.Clear();

        }
    }
}
