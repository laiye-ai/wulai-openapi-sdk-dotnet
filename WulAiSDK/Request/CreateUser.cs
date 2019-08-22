using System;
using WulAiSDK.Response;

namespace WulAiSDK.Request
{
    public class CreateUser:ResponseBase
    {
        /// <summary>
        /// 用户昵称 (少于128个字符)
        /// </summary>
        /// <value>The nickname.</value>
        public string nickname { get; set; }


        /// <summary>
        /// 用户头像地址。用户头像会展示在吾来SaaS的用户列表、消息记录等任何展示用户信息的地方 (少于512个字符)
        /// </summary>
        /// <value>The avatar URL.</value>
        public string avatar_url { get; set; }



        /// <summary>
        /// 用户id。用户的唯一识别。如果调用方客户端用户没有唯一标识，尽量通过其他标识来唯一区分用户，如设备号 (少于128个字符)
        /// </summary>
        /// <value>The user identifier.</value>
        public string user_id { get; set; }


    }
}
