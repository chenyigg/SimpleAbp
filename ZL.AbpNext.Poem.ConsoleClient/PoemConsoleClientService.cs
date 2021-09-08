using System;
using System.Linq;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;
using ZL.AbpNext.Poem.Domain.Poems;

namespace ZL.AbpNext.Poem.ConsoleClient
{
    public class PoemConsoleClientService : ITransientDependency
    {
        IRepository<Poet> repository;
        IUnitOfWorkManager uowManager;
        public PoemConsoleClientService(IRepository<Poet> repository, IUnitOfWorkManager uowManager)
        {
            this.repository = repository;
            this.uowManager = uowManager;
        }


        public void Run()
        {
            //Console.WriteLine("你好");
            using (var uow = uowManager.Begin(new AbpUnitOfWorkOptions()))
            {
                //获取第一个诗人
                var poet = repository.FirstOrDefault();

                Console.WriteLine(poet.Name);
            }
        }
    }
}
