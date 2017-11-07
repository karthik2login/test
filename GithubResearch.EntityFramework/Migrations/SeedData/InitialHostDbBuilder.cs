using GithubResearch.EntityFramework;
using EntityFramework.DynamicFilters;

namespace GithubResearch.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly GithubResearchDbContext _context;

        public InitialHostDbBuilder(GithubResearchDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
