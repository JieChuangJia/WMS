using System;
using System.Configuration;

namespace JBS_APPDB
{
    
    public class PubConstant
    {
        public static string ConnectionString = "";
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static void SetConnectStr(string connectStr)
        {
            ConnectionString = connectStr;
            DbHelperSQL.connectionString = connectStr;
        }
     
    }
}
