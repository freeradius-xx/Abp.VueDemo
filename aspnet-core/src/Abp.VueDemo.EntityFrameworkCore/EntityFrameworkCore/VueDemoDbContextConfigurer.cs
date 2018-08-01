using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Abp.VueDemo.EntityFrameworkCore
{
    public static class VueDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VueDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VueDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
