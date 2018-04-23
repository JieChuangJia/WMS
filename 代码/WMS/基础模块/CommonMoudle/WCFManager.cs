using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

using System.Security.Cryptography.X509Certificates;
 
using System.ServiceModel.Security;

namespace CommonMoudle
{
    public class WCFManager<IContractObj>
    {
        private ServiceHost SelfHost { get; set; }
        private IContractObj ServiceContractObj { get; set; }
         
        public WCFManager()
        {
         
        }
        /// <summary>
        /// 设置服务宿主对象
        /// </summary>
        /// <param name="servCttObj"></param>
        public void SetServiceContractObj(IContractObj servCttObj)
        {
            this.ServiceContractObj = servCttObj;
        }
        /// <summary>
        /// 启动指定地址服务
        /// </summary>
        /// <param name="servAddr">服务地址</param>
        /// <param name="restr">执行描述</param>
        /// <returns>执行标志</returns>
        public bool Start(Uri servAddr,ref string restr)
        {

            //承载和运行服务（MSDN第三步）  
            //为服务配置基址  
            //1.为服务的基址创建 Uri 实例。此 URI 指定 HTTP 方案、本地计算机、端口号 8000，以及服务协定中为服务命名空间指定的服务路径 ServiceModelSample/Service。  
            //Uri baseAddress = new Uri("http://localhost:8000/ServiceModelSamples/Service");

            //承载服务  
            //1.导入 System.ServiceModel.Description 命名空间。这行代码应该与 using 或 imports 语句的其余部分一起放置在 Program.cs/Program.vb 文件的顶部。  
            //2.创建一个新的 ServiceHost 实例以承载服务。必须指定实现服务协定和基址的类型。对于此示例，基址为 http://localhost:8000/ServiceModelSamples/Service，CalculatorService 为实现服务协定的类型。  
         
            //3.添加一个捕获 CommunicationException 的 try-catch 语句，并在接下来的三个步骤中将该代码添加到 try 块中。catch 子句应该显示错误信息，然后调用 selfHost.Abort()。  
            try
                
            {
                if(this.ServiceContractObj == null)
                {
                    restr = "服务宿主对象未设置！";
                    return false;
                }
                if(servAddr == null)
                {
                    restr = "服务器地址为空！";
                    return false;
                }
                this.Stop(ref restr);
                //4.添加公开服务的终结点。为此，必须指定终结点公开的协议、绑定和终结点的地址。对于此示例，将 ICalculator 指定为协定，将 WSHttpBinding 指定为绑定，并将 CalculatorService 指定为地址。在这里请注意，终结点地址是相对地址。终结点的完整地址是基址和终结点地址的组合。在此例中，完整地址是 http://localhost:8000/ServiceModelSamples/Service/CalculatorService。  
                EndpointAddress _address = new EndpointAddress(servAddr);
                BasicHttpBinding _binding = new BasicHttpBinding();
               
             
                ContractDescription _contract = ContractDescription.GetContract(typeof(IContractObj));
                ServiceEndpoint endpoint = new ServiceEndpoint(_contract, _binding, _address);

                this.SelfHost = new ServiceHost(this.ServiceContractObj, servAddr);
                //添加终结点ABC
                this.SelfHost.Description.Endpoints.Add(endpoint);
                //启用元数据交换
                ServiceMetadataBehavior meta = new ServiceMetadataBehavior();
                
                meta.HttpGetEnabled = true;
                this.SelfHost.Description.Behaviors.Add(meta);
                this.SelfHost.Open();


                return true;

            }
            catch (CommunicationException ce)
            {
                restr = ce.StackTrace;
                this.SelfHost.Abort();
                return false;
            }
        }
        public bool Stop(ref string restr)
        {
            try
            {
                if (this.SelfHost == null)
                {
                    return false;
                }
                this.SelfHost.Close();
                return true;
            }
            catch(Exception ex)
            {
                restr = ex.StackTrace;
                return false;
            }

        }
    }





    //public class WCF_WS_Manager
    //{
    //    public WCF_WS_Manager()
    //    {

    //    }
    //    public bool Start(Uri servAddr, ref string restr)
    //    {
    //        //string addressHttp = String.Format("http://{0}:8002/hello", System.Net.Dns.GetHostEntry("").HostName);
    //        //Uri baseAddress = new Uri(addressHttp);
    //        WSHttpBinding b = new WSHttpBinding();
    //        b.Security.Mode = SecurityMode.Transport;
    //        b.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
    //        //Uri a = new Uri(addressHttp);
    //        Uri[] baseAddresses = new Uri[] { servAddr };
    //        ServiceHost sh = new ServiceHost(typeof(HelloWorldService), baseAddresses);
    //        Type c = typeof(IHelloWorldService);
    //        sh.AddServiceEndpoint(c, b, servAddr);
    //        sh.Credentials.ServiceCertificate.SetCertificate(
    //            StoreLocation.LocalMachine,
    //            StoreName.My,
    //            X509FindType.FindBySubjectName, "myCert");
    //        sh.Credentials.ClientCertificate.Authentication.CertificateValidationMode =
    //        X509CertificateValidationMode.PeerOrChainTrust;
    //        try
    //        {
    //            sh.Open();

    //            string address = sh.Description.Endpoints[0].ListenUri.AbsoluteUri;
    //            Console.WriteLine("Listening @ {0}", address);
    //            Console.WriteLine("Press enter to close the service");
    //            Console.ReadLine();
    //            //sh.Close();
    //        }
    //        catch (CommunicationException ce)
    //        {
    //            Console.WriteLine("A commmunication error occurred: {0}", ce.Message);
    //            Console.WriteLine();
    //        }
    //        catch (System.Exception exc)
    //        {
    //            Console.WriteLine("An unforseen error occurred: {0}", exc.Message);
    //            Console.ReadLine();
    //        }
    //        return true;
    //    }
       
    //}
    //[ServiceContract]
    //public interface IHelloWorldService
    //{
    //    [OperationContract]
    //    string SayHello(string name);
    //}

    //public class HelloWorldService : IHelloWorldService
    //{
    //    public string SayHello(string name)
    //    {
    //        return string.Format("Hello, {0}", name);
    //    }
    //}

}
