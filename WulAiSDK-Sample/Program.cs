using System;
using System.Threading.Tasks;
using WulAiSDK;
using WulAiSDK.Request;

namespace WulAiSDK_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //await CreateUser();
            Console.ReadKey();
        }


        /*private static async Task CreateUser()
        {
            WulAiClient wulAiClient = new WulAiClient("HOn8N3JudtsASYsEQObvsXzHTWtg5i9X000a3e870eb2eddeb8", "wKDQ5CYpScb56PfoWKBL", true);
            CreateUser rel = await wulAiClient.CreateUser(new CreateUser()
            {
                avatar_url = "",
                nickname = "WulAiSDK",
                user_id = "WulAiSDK"
            });

        }*/



    }
}
