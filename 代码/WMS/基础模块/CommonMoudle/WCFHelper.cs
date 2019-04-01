using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web.Services.Description;
using System.Xml.Serialization;

namespace CommonMoudle
{
    public static class WCFHelper
    {
        

        /// < summary>           
        /// 动态调用web服务         
        /// < /summary>          
        /// < param name="url">WSDL服务地址< /param> 
        /// < param name="methodname">方法名< /param>           
        /// < param name="args">参数< /param>           
        /// < returns>< /returns>          
        public static object InvokeWebService(string url, string methodname, object[] args)
        {
            return InvokeWebService(url, null, methodname, args);
        }

        public static object InvokeWebService(string url, string classname, string methodname, object[] args)
        {
            string @namespace = "EnterpriseServerBase.WebService.DynamicWebCalling";
            if ((classname == null) || (classname == ""))
            {
                classname = GetWsClassName(url);
            }

            try
            {
                //获取WSDL
                WebClient wc = new WebClient();
                Stream stream = wc.OpenRead(url + "?wsdl");
                ServiceDescription sd = ServiceDescription.Read(stream);
                ServiceDescriptionImporter sdi = new ServiceDescriptionImporter();
                sdi.ProtocolName = "Soap12";
                  sdi.Style = System.Web.Services.Description.ServiceDescriptionImportStyle.Client; //生成客户端代理。 
                  sdi.CodeGenerationOptions = CodeGenerationOptions.GenerateProperties | CodeGenerationOptions.GenerateNewAsync;
                sdi.AddServiceDescription(sd, null, null);
                CodeNamespace cn = new CodeNamespace(@namespace);
                cn.Name = "WMS_JBS_Service";
                //生成客户端代理类代码
                CodeCompileUnit ccu = new CodeCompileUnit();
                ccu.Namespaces.Add(cn);
                sdi.Import(cn, ccu);
                CodeDomProvider provider = new CSharpCodeProvider();//设定编译参数
                CompilerParameters cplist = new CompilerParameters();
                cplist.GenerateExecutable = false;
                cplist.GenerateInMemory = true;
               
                cplist.ReferencedAssemblies.Add("System.dll");
                cplist.ReferencedAssemblies.Add("System.XML.dll");
                cplist.ReferencedAssemblies.Add("System.Web.Services.dll");
                cplist.ReferencedAssemblies.Add("System.Data.dll");

                //编译代理类
                CompilerResults cr = provider.CompileAssemblyFromDom(cplist, ccu);
                if (true == cr.Errors.HasErrors)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    foreach (System.CodeDom.Compiler.CompilerError ce in cr.Errors)
                    {
                        sb.Append(ce.ToString());
                        sb.Append(System.Environment.NewLine);
                    }
                    throw new Exception(sb.ToString());
                }

                //生成代理实例，并调用方法
                System.Reflection.Assembly assembly = cr.CompiledAssembly;
                Type t = assembly.GetType(@namespace + "." + classname, true, true);
                object obj = Activator.CreateInstance(t);
                System.Reflection.MethodInfo mi = t.GetMethod(methodname);

                return mi.Invoke(obj, args);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message, new Exception(ex.InnerException.StackTrace));
            }
        }

  
        private static string GetWsClassName(string wsUrl)
        {
            string[] parts = wsUrl.Split('/');
            string[] pps = parts[parts.Length - 1].Split('.');
            return pps[0];
        }

        /// <summary>
        /// Http Get请求
        /// </summary>
        /// <param name="url">请求地址</param> 
        /// <param name="postData">请求参数</param> 
        /// <param name="result">返回结果</param>
        /// <returns></returns>
        public static bool WebHttpGet(string url, string postData, out string result)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url  + postData);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "text/html;charset=UTF-8";
               
                WebResponse webResponse = httpWebRequest.GetResponse();
                HttpWebResponse httpWebResponse = (HttpWebResponse)webResponse;
                System.IO.Stream stream = httpWebResponse.GetResponseStream();
                System.IO.StreamReader streamReader = new System.IO.StreamReader(stream, Encoding.GetEncoding("UTF-8"));
                result = streamReader.ReadToEnd(); //请求返回的数据
                streamReader.Close();
                stream.Close();
                return true;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Http Post请求
        /// </summary>
        /// <param name="postUrl">请求地址</param>
        /// <param name="postData">请求参数(json格式请求数据时contentType必须指定为application/json)</param>
        /// <param name="result">返回结果</param>
        /// <returns></returns>
        public static bool WebHttpPost(string postUrl, string postData, out string result)
        {
            try
            {
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(postData);

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(postUrl);
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                //httpWebRequest.ContentType = "text/html;charset=UTF-8";
                //httpWebRequest.ContentType = "application/json;";

               
                httpWebRequest.ContentLength = byteArray.Length;

                using (System.IO.Stream stream = httpWebRequest.GetRequestStream())
                {
                    stream.Write(byteArray, 0, byteArray.Length); //写入参数                  
                }

                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
                using (System.IO.Stream responseStream = httpWebResponse.GetResponseStream())
                {
                    System.IO.StreamReader streamReader = new System.IO.StreamReader(responseStream, Encoding.GetEncoding("UTF-8"));
                    result = streamReader.ReadToEnd(); //请求返回的数据
                    streamReader.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return false;
            }
        }

        public static string postSend(string url, string param)
        {
            Encoding myEncode = Encoding.GetEncoding("UTF-8");
            byte[] postBytes = Encoding.UTF8.GetBytes(param);
 
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
            req.ContentLength = postBytes.Length;
 
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(postBytes, 0, postBytes.Length);
                }
                using (WebResponse res = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(res.GetResponseStream(), myEncode))
                    {
                        string strResult = sr.ReadToEnd();
                        return strResult;
                    }
                }
            }
            catch (WebException ex)
            {
                return "无法连接到服务器\r\n错误信息：" + ex.Message;
            }
        }
 
    }
}
