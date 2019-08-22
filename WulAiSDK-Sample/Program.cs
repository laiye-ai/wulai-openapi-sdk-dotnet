using System;
using System.Threading.Tasks;
using WulAiSDK;
using WulAiSDK.Request;
using WulAiSDK.Util;

namespace WulAiSDK_Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {

            await CreateUser();
            Console.WriteLine("Hello World!");

        }



        private static async Task CreateUser()
        {
            WulAiClient wulAiClient = new WulAiClient("HOn8N3JudtsASYsEQObvsXzHTWtg5i9X000a3e870eb2eddeb8", "wKDQ5CYpScb56PfoWKBL", true);
            Result rel = await wulAiClient.CreateUser(new CreateUser()
            {
                avatar_url = "",
                nickname = "WulAiSDK",
                user_id = "WulAiSDK"
            });

        }




    }
}
