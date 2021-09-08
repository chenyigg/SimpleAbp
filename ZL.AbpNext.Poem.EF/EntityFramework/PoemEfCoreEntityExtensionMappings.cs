using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Threading;

namespace ZL.AbpNext.Poem.EF.EntityFramework
{
    public class PoemEfCoreEntityExtensionMappings
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            PoemModulePropertyConfigurator.Configure();

            OneTimeRunner.Run(() =>
            {

            });
        }
    }

    public static class PoemModulePropertyConfigurator
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                ConfigureExistingProperties();
            });
        }

        private static void ConfigureExistingProperties()
        {
        }
    }
}
