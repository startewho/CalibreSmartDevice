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
                        var msg = IOperation<GetInitializationInfoReq>.OpString(initInform);
                        await s.SendAsync(Encoding.UTF8.GetBytes(msg));
                        var p = await ReceiveNext(channel);
                        if (p?.Op == OperationType.OK)
                        {
                            var initRes = IOperation<GetInitializationInfoRes>.FromString(p.Message);
                            if (initRes != null)
                            {
                                var devInform = new GetDeviceInformationReq();
                                msg = IOperation<GetDeviceInformationReq>.OpString(devInform);
                                await s.SendAsync(Encoding.UTF8.GetBytes(msg));
                                p = await ReceiveNext(channel);
                                if (p?.Op == OperationType.OK)
                                {
                                    var devInformRes = IOperation<GetDeviceInformationRes>.FromString(p.Message);
                                    if (devInformRes != null)
                                    {
                                        var freeSpace = new FreeSpaceReq();
                                        msg = IOperation<FreeSpaceReq>.OpString(freeSpace);
                                        await s.SendAsync(Encoding.UTF8.GetBytes(msg));
                                    }


                                }
                            }
                        }
                    }


                })
                .UsePackageHandler(async (s, p) =>
                {

                    Logger.LogInformation($"Revice from client:Op:{p.Op},Message:{p.Message}");
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
        /// 获取返回
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

    }



}