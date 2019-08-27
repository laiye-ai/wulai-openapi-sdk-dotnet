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
            string orignalString = "whoo";
            string targetString = "[ServerError]whoo";
            var stringResult = WulAiSDK.Util.Log.ServerError(orignalString);
            Assert.Equal(targetString, stringResult);
        }
    }
}
