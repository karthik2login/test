using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace GithubResearch.EntityFramework.Repositories
{
    public abstract class GithubResearchRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<GithubResearchDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected GithubResearchRepositoryBase(IDbContextProvider<GithubResearchDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class GithubResearchRepositoryBase<TEntity> : GithubResearchRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected GithubResearchRepositoryBase(IDbContextProvider<GithubResearchDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
