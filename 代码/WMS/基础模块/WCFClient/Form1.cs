using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonMoudle;
using System.Net;
using WMS_JBS_Service;
using Newtonsoft.Json.Linq;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GetMaterialInfoJosb( )
        {
            
            MaterialInfo mater = new MaterialInfo();
            mater.material_category = "成品";
            mater.material_code = "234234";
            mater.material_enabled = true;
            mater.material_model = "50A/60B";
            mater.material_name = "eqweq";

            MaterialJson maJson = new MaterialJson();
            maJson.materialInfoJson = Newtonsoft.Json.JsonConvert.SerializeObject(mater);
            maJson.operateType = "1";
            return Newtonsoft.Json.JsonConvert.SerializeObject(maJson);
        }
        private string GetInBoundOrderTestJson(string planType,string planCode)
        {
            InHouseOrder inHouseOrder = new InHouseOrder();
            inHouseOrder.order_code = planCode;
            inHouseOrder.order_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            inHouseOrder.order_maker = "admin";
            if(planType == "入库")
            {
                inHouseOrder.InOut_Flag = "1";
            }
            else
            {
                inHouseOrder.InOut_Flag = "2";
            }
          
            inHouseOrder.order_voucherType = planType;
            inHouseOrder.warehouse_code = "A1";
            OderMaterialInfo materialInfo = new OderMaterialInfo();
            materialInfo.material_batch = "b123";
            materialInfo.material_code = "LSTL0001";
            materialInfo.material_makedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            materialInfo.material_model = "TB009";
            materialInfo.material_name = "极片";
            materialInfo.material_unit = "片";
            materialInfo.material_number = "2";

            //OderMaterialInfo materialInfo2 = new OderMaterialInfo();
            //materialInfo2.material_batch = "b123";
            //materialInfo2.material_code = "CSM-BT-001";
            //materialInfo2.material_code = "KS-60001";
            //materialInfo2.material_makedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //materialInfo2.material_model = "TB009";
            //materialInfo2.material_name = "极片";
            //materialInfo2.material_unit = "片";
            //materialInfo2.material_number = "2.3";
            List<OderMaterialInfo> materialList = new List<OderMaterialInfo>();
            materialList.Add(materialInfo);
            //materialList.Add(materialInfo2);
            inHouseOrder.MaterilaList = materialList;
            return Newtonsoft.Json.JsonConvert.SerializeObject(inHouseOrder);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.comboBox1.Text == "物料")
            {
                this.tb_json.Text = GetMaterialInfoJosb();
            }
            else
            {
                string planOrder = GetInBoundOrderTestJson(this.comboBox1.Text.Trim(), this.tb_PlanCode.Text.Trim());
                //}
                //else if(this.comboBox1.Text == "领用出库")
                //{

                //}
                //else if (this.comboBox1.Text == "报废入库")
                //{

                //}

                TestClass tc = new TestClass();
                tc.materialPlanOrderJson = planOrder;

                string strs = Newtonsoft.Json.JsonConvert.SerializeObject(tc);
                if (strs != "")
                { }
                this.tb_json.Text = strs;
            }
            //if(this.comboBox1.Text == "采购接收")
            //{
          
            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json; charset=utf-8");
            //client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            object ob = null;
            //var result = client.UploadString("http://localhost/WMS_To_ERP_Svc/MaterialPlanOrder", "POST", "{\"order_code\":\"K8\",\"order_date\":\"2019-03-30 11:41:33\",\"order_maker\":\"admin\",\"warehouse_code\":\"A1\",\"order_voucherType\":\"采购接收\",\"MaterilaList\":[{\"material_code\":\"LSTL0001\",\"material_name\":\"极片\",\"material_model\":\"TB009\",\"material_unit\":\"片\",\"material_makedate\":\"2019-03-30 11:41:33\",\"material_batch\":\"b123\",\"material_number\":\"2\"},{\"material_code\":\"KS-60001\",\"material_name\":\"极片\",\"material_model\":\"TB009\",\"material_unit\":\"片\",\"material_makedate\":\"2019-03-30 11:41:33\",\"material_batch\":\"b123\",\"material_number\":\"2.3\"}]}");
            //var result = client.UploadString("http://localhost/WMS_To_ERP_Svc/MaterialPlanOrder", "POST", "{\"order_code\":\"K8\"}");
            string str = "";

            //ob = WCFHelper.WebHttpGet("http://localhost/WMS_To_ERP_Svc/MaterialInfo", "/12errrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr/1", out str);
            //ob = WCFHelper.WebHttpPost("http://localhost/WMS_To_ERP_Svc/MaterialPlanOrder", "{\"order_code\":\"K8\",\"order_date\":\"2019-03-30 11:41:33\",\"order_maker\":\"admin\",\"warehouse_code\":\"A1\",\"order_voucherType\":\"采购接收\",\"MaterilaList\":[{\"material_code\":\"LSTL0001\",\"material_name\":\"极片\",\"material_model\":\"TB009\",\"material_unit\":\"片\",\"material_makedate\":\"2019-03-30 11:41:33\",\"material_batch\":\"b123\",\"material_number\":\"2\"},{\"material_code\":\"KS-60001\",\"material_name\":\"极片\",\"material_model\":\"TB009\",\"material_unit\":\"片\",\"material_makedate\":\"2019-03-30 11:41:33\",\"material_batch\":\"b123\",\"material_number\":\"2.3\"}]}", out str);
            //ob = WCFHelper.WebHttpPost("http://localhost/WMS_To_ERP_Svc/MaterialPlanOrder", "{\"materialPlanOrderJson\":{\"order_code\":\"K8\",\"order_date\":\"2019-03-30 21:34:46\",\"order_maker\":\"admin\",\"warehouse_code\":\"A1\",\"order_voucherType\":\"采购接收\",\"MaterilaList\":[{\"material_code\":\"LSTL0001\",\"material_name\":\"极片\",\"material_model\":\"TB009\",\"material_unit\":\"片\",\"material_makedate\":\"2019-03-30 21:34:46\",\"material_batch\":\"b123\",\"material_number\":\"2\"},{\"material_code\":\"KS-60001\",\"material_name\":\"极片\",\"material_model\":\"TB009\",\"material_unit\":\"片\",\"material_makedate\":\"2019-03-30 21:34:46\",\"material_batch\":\"b123\",\"material_number\":\"2.3\"}]}}", out str);
            //ob = WCFHelper.WebHttpPost("http://192.168.40.141/WMS_To_ERP_Svc/MaterialPlanOrder", strs, out str);
            //ob = WCFHelper.WebHttpPost("http://localhost/WMS_To_ERP_Svc/MaterialPlanOrder", strs, out str);
            //if (ob == null)
            //{

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            bool ob = WCFHelper.WebHttpPost(this.tb_SvrAddr.Text.Trim(), this.tb_json.Text.Trim(), out str);
            Dictionary<string,string> dic = new Dictionary<string,string>();
            //dic.Add("method","puApi");

            dic.Add("method", "produceApi");
            dic.Add("param",this.tb_json.Text.Trim());
            //str = APIRequst.Send("POST", this.tb_SvrAddr.Text.Trim(), dic);

            str = SendToErp(this.tb_SvrAddr.Text.Trim(), "MaterialInfo", this.tb_json.Text.Trim());
            //var jObject = JObject.Parse(str);
            //string desc = jObject["Desc"].ToString();
            //if(desc!="")
            //{ }
            //ErpResponse erpRes = (ErpResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(str);
            MessageBox.Show(str);
        }

        private string SendToErp(string url, string methodName, string paramStr)
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("method", methodName);
                dic.Add("param", paramStr);
                string restr = APIRequst.Send("POST", url, dic);
                string log = "发送数据：" + paramStr + ",erp返回：" + restr;
                return log;

            }
            catch (Exception ex)
            {
                return "";
            }

        }

    }
}
