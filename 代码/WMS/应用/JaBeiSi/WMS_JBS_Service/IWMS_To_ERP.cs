using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WMS_JBS_Service
{

    [ServiceContract]
    public interface IWMS_To_ERP
    {
        [OperationContract]
        //[WebGet(UriTemplate = "/MaterialInfo/{materialInfoJson}/{operateType}", RequestFormat = WebMessageFormat.Json, 
        //ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        //string MaterialInfo(string materialInfoJson, string operateType);

        [WebInvoke(Method = "POST", UriTemplate = "MaterialInfo", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string MaterialInfo(string materialInfoJson, string operateType);

        [OperationContract]
        [WebGet(UriTemplate = "/SupplierInfo/{supplierInfoJson}/{operateType}", RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string SupplierInfo(string supplierInfoJson, string operateType);

        [OperationContract]
        [WebGet(UriTemplate = "/MaterialUnit/{materialUnitJson}/{operateType}", RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string MaterialUnit(string materialUnitJson, string operateType);

        [OperationContract]
        [WebGet(UriTemplate = "/WareHouseInfo/{wareHouseInfoJson}/{operateType}", RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]

        //[WebInvoke(Method = "POST", UriTemplate = "/WareHouseInfo/{wareHouseInfoJson}/{operateType}", RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string WareHouseInfo(string wareHouseInfoJson, string operateType);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "MaterialPlanOrder", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string MaterialPlanOrder(string materialPlanOrderJson);
        //string MaterialPlanOrder(Stream planStream);
       

    }

}
