using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SuperSocket;
using SuperSocket.ProtoBase;
using CalibreSmartServer;
using System.Text;
using System.Text.Encodings;
using SuperSocket.Channel;
using CalibreSmartServer.Message;
using System.Threading.Channels;

namespace CalibreSmartDevice
{
    class Program
    {
        public static ILogger Logger { get; private set; }
        static async Task Main(string[] args)
        {
            var host = SuperSocketHostBuilder.Create<SmartPackage, SmartPackageFliter>(args)
                .UseSessionHandler(async (s) =>
                {
                    Logger = s.GetDefaultLogger();

                    IChannel<SmartPackage>? channel = s.Channel as IChannel<SmartPackage>;

                    if (channel != null)
                    {

                        var initInform = new GetInitializationInfoReq();
                        var initRes=await SendMessage< GetInitializationInfoReq,GetInitializationInfoRes>(s,channel,initInform);
                        if (initRes==null)
                        {
                            Logger.LogError("初始化系统出错");
                        }

                        var devInform = new GetDeviceInformationReq();
                        var devRes = await SendMessage<GetDeviceInformationReq, GetDeviceInformationRes>(s, channel, devInform);
                        if (initRes == null)
                        {
                            Logger.LogError("初始化设备出错");
                        }

                        var freeSpace = new FreeSpaceReq();
                        var freeSpaceRes = await SendMessage<FreeSpaceReq, FreeSpaceRes>(s, channel, freeSpace);

                        if (freeSpaceRes == null)
                        {
                            Logger.LogError("获取剩余出错");
                        }
                        
                    }


                })
                .UsePackageHandler(async (s, p) =>
                {

                    Logger.LogInformation($"Revice Package from client:Op:{p.Op},Message:{p.Message}");
                    // handle package
                    await Task.Delay(0);

                })
                .ConfigureSuperSocket(options =>
                {
                    options.Name = "CalibreProtocol Server";
                    options.Listeners = new List<ListenOptions>
                    {
                        new ListenOptions
                        {
                            Ip = "0.0.0.0",
                            Port = 9090
                        }
                    };
                })
                .ConfigureLogging((hostCtx, loggingBuilder) =>
                {
                    loggingBuilder.AddConsole();
                }).Build();

            await host.RunAsync();
        }



        /// <summary>
        /// 获取响应消息结果
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>

        public static async Task<SmartPackage?> ReceiveNext(IChannel<SmartPackage> channel)
        {
            SmartPackage? package = null;
            if (channel != null)
            {
                package = await channel.RunAsync().GetAsyncEnumerator().ReceiveAsync();
            }
            Logger.LogInformation($"Revice from client:Op:{package?.Op},Message:{package?.Message}");
            return package;
        }






       /// <summary>
       /// 发送消息
       /// </summary>
       /// <typeparam name="R">请求</typeparam>
       /// <typeparam name="E">响应</typeparam>
       /// <param name="session"></param>
       /// <param name="channel"></param>
       /// <param name="req"></param>
       /// <returns></returns>

        public static async Task<E> SendMessage<R, E>(IAppSession session, IChannel<SmartPackage> channel, R req) where E : IOperation<E>, new() where R : IOperation<R>, new()
        {
            var msg = IOperation<R>.ToString(req);

            await session.SendAsync(Encoding.UTF8.GetBytes(msg));

            var p = await ReceiveNext(channel);

            if (p?.Op==OperationType.OK)
            {
                var e = IOperation<E>.FromString(p.Message);
                return e;
            }
            return default;
        }
    }



}