using Volo.Abp.Domain.Entities;

namespace ZL.AbpNext.Poem.Domain.Poems
{
    /// <summary>
    /// 诗人，从ABP Entity派生
    /// </summary>
    public class Poet : Entity<int>
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public virtual string Description { get; set; }

    }
}
