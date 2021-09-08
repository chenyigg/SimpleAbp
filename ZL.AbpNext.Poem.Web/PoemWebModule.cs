using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using ZL.AbpNext.Poem.EF;

namespace ZL.AbpNext.Poem.Web
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PoemDBModule),
        typeof(AbpAspNetCoreMvcModule)
        )]
    public class PoemWebModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
            context.Services.AddRazorPages();
            //context.Services.AddControllersWithViews();
        }

        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
            {
                options.AddAssemblyResource(
                   typeof(AbpAutofacModule),
                    typeof(PoemDBModule).Assembly,
                    typeof(AbpAspNetCoreMvcModule).Assembly
                );
            });
        }



        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {

            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
