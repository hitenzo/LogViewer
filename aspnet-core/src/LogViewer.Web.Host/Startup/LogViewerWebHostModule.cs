using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LogViewer.Configuration;

namespace LogViewer.Web.Host.Startup
{
    [DependsOn(
       typeof(LogViewerWebCoreModule))]
    public class LogViewerWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LogViewerWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LogViewerWebHostModule).GetAssembly());
        }
    }
}
