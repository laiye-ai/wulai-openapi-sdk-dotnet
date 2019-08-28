# wulai-openapi-sdk-dotnet

<a href="https://travis-ci.org/laiye-ai/wulai-openapi-sdk-dotnet"><img src="https://travis-ci.org/laiye-ai/wulai-openapi-sdk-dotnet.svg?branch=master" alt="Travis Build Status"></a>
<a href="https://codecov.io/gh/laiye-ai/wulai-openapi-sdk-dotnet" alt="Codecov"><img src="https://codecov.io/gh/laiye-ai/wulai-openapi-sdk-dotnet/branch/master/graph/badge.svg"/></a>
<a href="https://badge.fury.io/nu/Laiye.Nuget.WulAiSDK"><img src="https://badge.fury.io/nu/Laiye.Nuget.WulAiSDK.svg" alt="Nuget Version"></a>
<a href="https://www.nuget.org/packages/Laiye.Nuget.WulAiSDK/"><img src="https://img.shields.io/nuget/dt/Laiye.Nuget.WulAiSDK.svg?label=Nuget%20Download&style=flat" alt="Nuget Version"></a>
<a href="https://github.com/laiye-ai/wulai-openapi-sdk-dotnet/blob/master/LICENSE"><img src="https://img.shields.io/badge/License-Apache%202.0-blue.svg" alt="LICENSE"></a>


欢迎使用 WulAi SDK for .NET ，让您不用复杂编程即可访问吾来平台。


## 使用Demo及其示例
您可以在 [WulAiSDK-Sample](https://github.com/laiye-ai/wulai-openapi-sdk-dotnet/tree/master/WulAiSDK-Sample) 中查看代码示例。


## 环境要求
WulAi SDK for .NET 适用于:
- **.NET Framework 4.5** 及其以上版本
- **.NET Standard 2.0** 及其以上版本。
- **C# 4.0** 及其以上版本


## 安装
您可以通过 NuGet 程序包管理器来安装：

* 在 `解决方案资源管理器面板` 中右击您的项目选择 `管理 NuGet 程序包` 菜单，在打开的 `NuGet 管理面板` 中点击 `浏览` 选项卡输入 `Laiye.Nuget.WulAiSDK`，在下方列表中选择 `Authors` 为 `yangjiangtao@laiye.com` 由官方发布的模块，选择您期望的模块点击 **安装** 即可。

或者通过 .NET CLI 工具来安装

    dotnet add package Laiye.Nuget.WulAiSDK



## 快速开始
- 要使用 WulAi SDK for .NET，您需要一个吾来平台账号以及一对 Pubkey 和 Secret。请在吾来平台中的 [机器人应用设置 - 渠道设置 - 开放平台](http://platform.wul.ai/bot_setting/channel/openapi) 上查看您的 Pubkey 和 Secret，或者联系您的系统管理员。

以下这个代码示例向您展示了调用WulAi .NET SDK 的 3 个主要步骤：

1. 创建 `WulAiClient` 实例并初始化；
2. 创建 API 请求并设置参数；
3. 发起请求并处理返回。

```csharp
using WulAiSDK;
using WulAiSDK.Request;

class Program
{
    static async Task Main(string[] args)
    {
        // 构建一个 Client，用于发起请求
        WulAiClient wulAiClient = new WulAiClient("<your-Pubkey>", "<your-Secret>");
        try
        {
            //发起创建用户请求
            CreateUser rel = await wulAiClient.CreateUser(new CreateUser()
            {
                avatar_url = "",
                nickname = "WulAiSDK_Test",
                user_id = "WulAiSDK_Test"
            });
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
    }
}
```

在创建 WulAiClient 实例并初始化时，您需要填写 3 个参数：`Pubkey`、`Secret` 和 `debug`。其中`debug`默认为`false`。

