using System;
using Xunit;
using WulAiSDK;
using WulAiSDK.Request;
using System.Threading.Tasks;

namespace WulAiSDK_Tests
{
    public class WulAiClientTest
    {
        [Fact]
        public async Task CreateUserTest()
        {
            string pubkey = "HOn8N3JudtsASYsEQObvsXzHTWtg5i9X000a3e870eb2eddeb8";
            string secret = "wKDQ5CYpScb56PfoWKBL";
            WulAiClient wulAiClient = new WulAiClient(pubkey, secret);
            CreateUser rel = await wulAiClient.CreateUser(new CreateUser()
            {
                avatar_url = "",
                nickname = "WulAiSDK",
                user_id = "WulAiSDK"
            });

            string actual = "WulAiSDK";


            Assert.Equal(rel.nickname, actual);

            Assert.Equal(rel.user_id, actual);

        }



    }
}
