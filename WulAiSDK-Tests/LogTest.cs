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


        [Fact]
        public void VerifyClientError()
        {
            string orignalString = "whoo";
            string targetString = "[ClientError]whoo";
            var stringResult = WulAiSDK.Util.Log.ServerError(orignalString);
            Assert.Equal(targetString, stringResult);
        }


        [Fact]
        public void VerifyNetworkError()
        {
            string orignalString = "whoo";
            string targetString = "[NetworkError]whoo";
            var stringResult = WulAiSDK.Util.Log.ServerError(orignalString);
            Assert.Equal(targetString, stringResult);
        }



    }
}
