using System.Linq;
using GithubResearch.EntityFramework;
using GithubResearch.MultiTenancy;

namespace GithubResearch.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly GithubResearchDbContext _context;

        public DefaultTenantCreator(GithubResearchDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
