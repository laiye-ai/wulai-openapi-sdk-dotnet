using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using WulAiSDK.Request;
using WulAiSDK.Util;

namespace WulAiSDK
{
    public class WulAiClient
    {
        private string pubkey;
        private string secrect;
        private bool debug;


        /// <summary>
        /// 初始化WulAiClient
        /// </summary>
        /// <param name="pubkey">吾来平台Pubkey</param>
        /// <param name="secrect">吾来平台Secrect</param>
        /// <param name="debug">是否打开调试模式</param>
        public WulAiClient(string pubkey, string secrect, bool debug = false)
        {
            this.pubkey = pubkey;
            this.secrect = secrect;
            this.debug = debug;
        }


        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="createUser">Create user.</param>
        public async Task<CreateUser> CreateUser(CreateUser createUser)
        {
            /*
            if (createUser == null)
            {
                throw new Exception("用户信息不能为空");
            }
            if (createUser.nickname.Length > 128)
            {
                throw new Exception("用户昵称不能超过128个字符");
            }
            if (createUser.avatar_url.Length > 512)
            {
                throw new Exception("用户头像地址不能超过512个字符");
            }
            if (createUser.user_id == null)
            {
                throw new Exception("用户id不能为空");
            }
            if (createUser.user_id.Length > 128)
            {
                throw new Exception("用户id不能超过128个字符");
            }*/

            string rel = await HTTP.PostAPI(this.pubkey, this.secrect, WulAiAPI.CreateUser, JsonConvert.SerializeObject(createUser), debug);

            WulAiResult wulAiResult = null;
            try
            {
                wulAiResult = JsonConvert.DeserializeObject<WulAiResult>(rel);
            }
            catch (Exception ex)
            {
                throw new Exception(Log.ClientError($"WulAiResult反序列化失败: {ex.ToString()}"));
            }

            if (wulAiResult.code != 0)
            {
                throw new Exception(Log.ServerError($"{wulAiResult.error}"));
            }
            else
            {
                return createUser;
            }

        }

    }
}
