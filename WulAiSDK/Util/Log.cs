using System;
using System.Collections.Generic;
using System.Text;

namespace WulAiSDK.Util
{
    public class Log
    {
        public static string ServerError(string msg)
        {
            string message = "[ServerError]";
            if (!string.IsNullOrEmpty(msg))
            {
                message = $"{message}{msg}";
            }
            return message;
        }

        public static string ClientError(string msg)
        {
            string message = "[ClientError]";
            if (!string.IsNullOrEmpty(msg))
            {
                message = $"{message}{msg}";
            }
            return message;
        }


        public static string NetworkError(string msg)
        {
            string message = "[NetworkError]";
            if (!string.IsNullOrEmpty(msg))
            {
                message = $"{message}{msg}";
            }
            return message;
        }
    }
}
