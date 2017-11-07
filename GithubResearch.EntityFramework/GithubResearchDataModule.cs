using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using GithubResearch.EntityFramework;

namespace GithubResearch
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(GithubResearchCoreModule))]
    public class GithubResearchDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<GithubResearchDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
