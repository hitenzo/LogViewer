using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LogViewer.Configuration;
using LogViewer.Web;

namespace LogViewer.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LogViewerDbContextFactory : IDesignTimeDbContextFactory<LogViewerDbContext>
    {
        public LogViewerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LogViewerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LogViewerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LogViewerConsts.ConnectionStringName));

            return new LogViewerDbContext(builder.Options);
        }
    }
}
