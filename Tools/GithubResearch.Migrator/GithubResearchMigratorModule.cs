using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using GithubResearch.EntityFramework;

namespace GithubResearch.Migrator
{
    [DependsOn(typeof(GithubResearchDataModule))]
    public class GithubResearchMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<GithubResearchDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}