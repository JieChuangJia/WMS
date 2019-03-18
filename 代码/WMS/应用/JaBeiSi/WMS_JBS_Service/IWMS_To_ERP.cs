using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WMS_JBS_Service
{

    [ServiceContract]
    public interface IWMS_To_ERP
    {
        [OperationContract]
        string MaterialInfo(string materialInfoJson, int operateType);

        [OperationContract]
        string SupplierInfo(string supplierInfoJson, int operateType);

        [OperationContract]
        string MaterialUnit(string materialUnitJson, int operateType);

        [OperationContract]
        string WareHouseInfo(string wareHouseInfoJson);

        [OperationContract]
        string MaterialInBoundOrder(string materialInBoundOrderJson);

        [OperationContract]
        string MaterialOutBoundOrder(string materialOutBoundOrderJson);

    }

}
