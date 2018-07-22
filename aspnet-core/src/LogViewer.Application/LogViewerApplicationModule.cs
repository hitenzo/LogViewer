using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LogViewer.Authorization;

namespace LogViewer
{
    [DependsOn(
        typeof(LogViewerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LogViewerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LogViewerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LogViewerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
