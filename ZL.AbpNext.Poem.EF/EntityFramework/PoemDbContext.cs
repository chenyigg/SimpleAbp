using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using ZL.AbpNext.Poem.Domain.Poems;

namespace ZL.AbpNext.Poem.EF.EntityFramework
{
    [ConnectionStringName("Poem")]
    public class PoemDbContext : AbpDbContext<PoemDbContext>//, IPoemDbContext
    {
        public virtual DbSet<Poet> Poets { get; set; }

        public PoemDbContext(DbContextOptions<PoemDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //配置Abp默认实体用
            //builder.ConfigurePermissionManagement();
            //builder.ConfigureSettingManagement();
            //builder.ConfigureBackgroundJobs();
            //builder.ConfigureAuditLogging();
            //builder.ConfigureIdentity();
            //builder.ConfigureIdentityServer();
            //builder.ConfigureFeatureManagement();
            //builder.ConfigureTenantManagement();

            //PoemDbContextModelCreatingExtensions => ConfigurePoem()
            //builder.ConfigurePoem();
        }
    }
}
