using Volo.Abp.Modularity;
using ZL.AbpNext.Poem.EF;
using ZL.AbpNext.Poem.Domain;

namespace ZL.AbpNext.Poem.ConsoleClient
{
    [DependsOn(
        typeof(PoemDomainModule),
        typeof(PoemDBModule)
    )]
    public class PoemConsoleClientModule : AbpModule
    {

    }
}
