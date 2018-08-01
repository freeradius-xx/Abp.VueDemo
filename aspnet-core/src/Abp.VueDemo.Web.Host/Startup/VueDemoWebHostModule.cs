using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.VueDemo.Configuration;

namespace Abp.VueDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(VueDemoWebCoreModule))]
    public class VueDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VueDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VueDemoWebHostModule).GetAssembly());
        }
    }
}
