using System;
namespace WulAiSDK.Util
{
    public class Log
    {
        public static string ServerError(string msg)
        {
            string message = "[服务端错误]";
            if (!string.IsNullOrEmpty(msg))
            {
                message = $"{message}{msg}";
            }
            return message;
        }

        public static string ClientError(string msg)
        {
            string message = "[客户端错误]";
            if (!string.IsNullOrEmpty(msg))
            {
                message = $"{message}{msg}";
            }
            return message;
        }


        public static string NetworkError(string msg)
        {
            string message = "[网络错误]";
            if (!string.IsNullOrEmpty(msg))
            {
                message = $"{message}{msg}";
            }
            return message;
        }




    }
}
