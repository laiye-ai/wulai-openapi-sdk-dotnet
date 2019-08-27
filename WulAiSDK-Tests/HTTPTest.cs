using System;
using Xunit;
using WulAiSDK;
using System.Threading.Tasks;
using WulAiSDK.Util;
using Newtonsoft.Json;
using WulAiSDK.Request;

namespace WulAiSDK_Tests
{
    public class HTTPTest
    {
        public async Task PostAPITest()
        {
            string pubkey = "HOn8N3JudtsASYsEQObvsXzHTWtg5i9X000a3e870eb2eddeb8";
            string secret = "wKDQ5CYpScb56PfoWKBL";
            string expected = await HTTP.PostAPI(pubkey, secret, WulAiAPI.CreateUser, JsonConvert.SerializeObject(new CreateUser()
            {
                user_id = "test_user_id",
                nickname = "test_nickname"
            }));


            string actual = "{}";

            Assert.Equal(expected, actual);





        }



    }
}
