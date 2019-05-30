using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCore.BaseProject.Authorization;

namespace MyCore.BaseProject
{
    [DependsOn(
        typeof(BaseProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BaseProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BaseProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BaseProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
