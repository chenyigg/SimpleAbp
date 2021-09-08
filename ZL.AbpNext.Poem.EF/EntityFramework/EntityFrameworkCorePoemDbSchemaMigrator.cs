using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ZL.AbpNext.Poem.EF.EntityFramework
{

    /// <summary>
    /// 强制迁移类
    /// </summary>
    public interface IPoemDbSchemaMigrator
    {
        Task MigrateAsync();
    }

    public class EntityFrameworkCorePoemDbSchemaMigrator
        : IPoemDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePoemDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            await _serviceProvider
                .GetRequiredService<PoemDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
