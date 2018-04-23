using System;
using System.Configuration;

namespace WMS_Database
{
    
    public class PubConstant
    {        
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get;
            set;
            //get 
            //{
            //    string connectStr = "Data Source =DESKTOP-62J36HM;Initial Catalog=WMSDB2;User ID= sa;Password=123456;timeout = 5000";
            //    //string connectStr = "Data Source = " + ConfigurationManager.AppSettings["DataSource"] + ";Initial Catalog=Aplors;User ID= yuncheng;Password=123456;timeout = 5000000";
            //    string _connectionString = connectStr;
            //    return _connectionString; 
            //}
        }
    }
}
