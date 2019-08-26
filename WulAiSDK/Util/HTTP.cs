using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WulAiSDK.Util
{
    public class HTTP
    {
        private static readonly string HOST = "https://openapi.wul.ai/v2";

        private static readonly HttpClient httpClient = new HttpClient();
        
        public static async Task<string> PostAPI(string pubkey, string secret, string api, string requestJson, bool debug = false)
        {
            string result = string.Empty;

            string timestamp = string.Empty, nonce = string.Empty, sign = string.Empty;
            ApiSign.CreateSign(pubkey, secret, ref nonce, ref sign, ref timestamp);


            if (debug)
            {
                Console.WriteLine($"请求api: {HOST}{api}");
                Console.WriteLine($"请求参数: {requestJson}");
                Console.WriteLine($"pubkey: {pubkey}");
                Console.WriteLine($"secret: {secret}");
                Console.WriteLine($"nonce: {nonce}");
                Console.WriteLine($"sign: {sign}");
                Console.WriteLine($"timestamp: {timestamp}");
            }

            HttpContent httpContent = new StringContent(requestJson);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            httpContent.Headers.Add("Api-Auth-pubkey", pubkey);
            httpContent.Headers.Add("Api-Auth-timestamp", timestamp);
            httpContent.Headers.Add("Api-Auth-nonce", nonce);
            httpContent.Headers.Add("Api-Auth-sign", sign);

            


            try
            {
                HttpResponseMessage rel = await httpClient.PostAsync(String.Format("{0}{1}", HOST, api), httpContent);
                result = rel.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    Console.WriteLine(Log.NetworkError($"异步Http请求异常: {ex.ToString()}"));
                }
                throw ex;
            }

            if (debug)
            {
                Console.WriteLine($"服务器返回结果: {result}");
            }

            return result;
        }



    }
}
