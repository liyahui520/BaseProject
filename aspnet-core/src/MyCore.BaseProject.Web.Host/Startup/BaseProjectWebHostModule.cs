using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCore.BaseProject.Configuration;

namespace MyCore.BaseProject.Web.Host.Startup
{
    [DependsOn(
       typeof(BaseProjectWebCoreModule))]
    public class BaseProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BaseProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BaseProjectWebHostModule).GetAssembly());
        }
    }
}
