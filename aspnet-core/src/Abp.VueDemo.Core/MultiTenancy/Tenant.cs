using Abp.MultiTenancy;
using Abp.VueDemo.Authorization.Users;

namespace Abp.VueDemo.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
