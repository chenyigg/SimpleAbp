using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp;

namespace ZL.AbpNext.Poem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var app = AbpApplicationFactory.Create<PoemConsoleClientModule>())
            {
                Console.WriteLine("开始运行");
                var service = app.ServiceProvider.GetService<PoemConsoleClientService>();
                service.Run();
            }
        }
    }
}
