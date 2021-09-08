using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using ZL.AbpNext.Poem.Domain.Poems;

namespace ZL.AbpNext.Poem.EF.EntityFramework
{
    [ConnectionStringName("Poem")]
    public interface IPoemDbContext : IEfCoreDbContext
    {
        DbSet<Poet> Poets { get; set; }
    }
}
