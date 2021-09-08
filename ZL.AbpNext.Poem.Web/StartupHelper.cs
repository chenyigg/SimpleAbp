using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Volo.Abp.Autofac;

namespace ZL.AbpNext.Poem.Web
{
    public static class StartupHelper
    {
        public static IHostBuilder UseAutofacMySelf(this IHostBuilder hostBuilder)
        {
            ContainerBuilder builder = new ContainerBuilder();
            return hostBuilder.ConfigureServices(
                (_, services)
                    =>
                {
                    services.AddObjectAccessor(builder);
                })
                .UseServiceProviderFactory(
                    new AbpAutofacServiceProviderFactory(builder));
        }


        //public static void InitializeApplication(this IApplicationBuilder app)
        //{
        //    Check.NotNull<IApplicationBuilder>(app, nameof(app));
        //    app.ApplicationServices.GetRequiredService<ObjectAccessor<IApplicationBuilder>>().Value = app;
        //    IAbpApplicationWithExternalServiceProvider application = app.ApplicationServices.GetRequiredService<IAbpApplicationWithExternalServiceProvider>();
        //    IHostApplicationLifetime requiredService = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();
        //    requiredService.ApplicationStopping.Register((Action)(() => application.Shutdown()));
        //    requiredService.ApplicationStopped.Register((Action)(() => application.Dispose()));
        //    application.Initialize(app.ApplicationServices);
        //}
    }
}
