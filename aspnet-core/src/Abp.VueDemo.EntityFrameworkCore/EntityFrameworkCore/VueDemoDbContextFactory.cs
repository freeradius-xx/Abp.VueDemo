using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Abp.VueDemo.Configuration;
using Abp.VueDemo.Web;

namespace Abp.VueDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VueDemoDbContextFactory : IDesignTimeDbContextFactory<VueDemoDbContext>
    {
        public VueDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VueDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VueDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VueDemoConsts.ConnectionStringName));

            return new VueDemoDbContext(builder.Options);
        }
    }
}
