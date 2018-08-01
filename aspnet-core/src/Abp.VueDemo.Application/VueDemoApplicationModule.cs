using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.VueDemo.Authorization;

namespace Abp.VueDemo
{
    [DependsOn(
        typeof(VueDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VueDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VueDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VueDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
