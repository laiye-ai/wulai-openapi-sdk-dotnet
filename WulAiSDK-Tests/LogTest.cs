using System;
using Xunit;
using WulAiSDK;

namespace WulAiSDK_Tests
{
    public class LogTest
    {
        [Fact]
        public void VerifyServerError()
        {
            string orignalString = "发生了异常";
            string targetString = "[服务端错误]发生了异常";
            var stringResult = WulAiSDK.Util.Log.ServerError(orignalString);
            Assert.Equal(targetString, stringResult);
        }
    }
}
