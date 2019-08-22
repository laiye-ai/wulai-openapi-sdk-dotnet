using System;
using WulAiSDK.Response;

namespace WulAiSDK.Util
{
    public class Result
    {
        private readonly int code = 0;
        private readonly string message;
        private readonly ResponseBase data;
        public Result(int code, string message, ResponseBase data)
        {
            this.code = code;
            this.message = message;
            this.data = data;
        }
    }
}
