using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abp.VueDemo.Authorization.Roles;
using Abp.VueDemo.Authorization.Users;
using Abp.VueDemo.MultiTenancy;

namespace Abp.VueDemo.EntityFrameworkCore
{
    public class VueDemoDbContext : AbpZeroDbContext<Tenant, Role, User, VueDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VueDemoDbContext(DbContextOptions<VueDemoDbContext> options)
            : base(options)
        {
        }
    }
}
