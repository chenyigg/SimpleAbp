namespace ZL.AbpNext.Poem.EF.EntityFramework
{
    //public class PoemMigrationsDbContextFactory : IDesignTimeDbContextFactory<PoemDbContext>
    //{
    //    public PoemDbContext CreateDbContext(string[] args)
    //    {
    //        PoemEfCoreEntityExtensionMappings.Configure();
    //        #region 读取配置文件，返回DbContext对象

    //        var configuration = BuildConfiguration();

    //        var builder = new DbContextOptionsBuilder<PoemDbContext>()
    //            .UseSqlServer(configuration.GetConnectionString("Poem"));

    //        return new PoemDbContext(builder.Options);

    //        #endregion

    //    }

    //    private static IConfigurationRoot BuildConfiguration()
    //    {
    //        var builder = new ConfigurationBuilder()
    //            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
    //            .AddJsonFile("appsettings.json", optional: false);

    //        return builder.Build();
    //    }

    //}

}