using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using ZL.AbpNext.Poem.Domain.Poems;

namespace ZL.AbpNext.Poem.EF.EntityFramework
{
    /// <summary>
    /// 配置实体与数据库之间的联系（映射）
    /// </summary>
    public static class PoemDbContextModelCreatingExtensions
    {
        /// <summary>
        /// 配置实体与数据库之间的联系（映射）
        /// </summary>
        /// <param name="builder"></param>
        public static void ConfigurePoem(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Poet>(b =>
            {
                b.ToTable("T_", string.Empty);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.HasKey(u => u.Id);
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}
