﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SuperSocket;
using SuperSocket.ProtoBase;
using CalibreSmartServer;
using System.Text;
using System.Text.Encodings;

namespace CalibreSmartDevice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = SuperSocketHostBuilder.Create<SmartPackage, SmartPackageFliter>(args)
                .UseSessionHandler(async (s) =>
                {
                    var noop=new NOOP();
                  
                    var msg = IOp<NOOP>.OpString(noop);
                    await s.SendAsync(Encoding.UTF8.GetBytes(msg));
                })
                .UsePackageHandler(async (s, p) =>
                {
                   
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
    }
}