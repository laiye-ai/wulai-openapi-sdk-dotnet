using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace WulAiSDK.Util
{
    public class ApiSign
    {
        private static string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static Random random = new Random();



        /// <summary>
        /// 生成随机字符串
        /// </summary>
        /// <returns>The nonce.</returns>
        /// <param name="length">Length.</param>
        private static string GenerateNonce(int length)
        {
            var nonceString = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                nonceString.Append(validChars[random.Next(0, validChars.Length - 1)]);
            }

            return nonceString.ToString();
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <returns>The 1 encrypt.</returns>
        /// <param name="str">String.</param>
        private static string SHA1_Encrypt(string str)
        {
            var strRes = Encoding.Default.GetBytes(str);
            HashAlgorithm iSha = new SHA1CryptoServiceProvider();
            strRes = iSha.ComputeHash(strRes);
            var enText = new StringBuilder();
            foreach (byte iByte in strRes)
            {
                enText.AppendFormat("{0:x2}", iByte);
            }
            return enText.ToString();
        }


        /// <summary>
        /// 生成需要验签的header信息
        /// </summary>
        public static void CreateSign(string pubkey, string secret, ref string nonce, ref string sign, ref string timestamp)
        {
            nonce = GenerateNonce(32);
            timestamp = Convert.ToString((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000);
            sign = SHA1_Encrypt(nonce + timestamp + secret);
        }

    }
}
