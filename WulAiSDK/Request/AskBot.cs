using System;
namespace WulAiSDK.Request
{
    public class AskBot
    {
        /// <summary>
        /// 消息体格式，任意选择一种消息类型（文本 / 图片 / 语音 / 视频 / 文件 / 图文 / 自定义消息）填充
        /// </summary>
        /// <value>The message body.</value>
        public msg_body msg_body { get; set; }

        /// <summary>
        /// 用户唯一标识
        /// </summary>
        /// <value>The user identifier.</value>
        public string user_id { get; set; }


        /// <summary>
        /// 自定义字段 (小于1024个字符)
        /// </summary>
        /// <value>The extra.</value>
        public string extra { get; set; }


    }

    public class msg_body
    {

    }

    public class text
    {

    }










}
