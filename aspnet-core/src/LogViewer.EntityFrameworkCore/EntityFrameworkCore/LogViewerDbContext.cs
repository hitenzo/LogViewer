using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LogViewer.Authorization.Roles;
using LogViewer.Authorization.Users;
using LogViewer.MultiTenancy;

namespace LogViewer.EntityFrameworkCore
{
    public class LogViewerDbContext : AbpZeroDbContext<Tenant, Role, User, LogViewerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LogViewerDbContext(DbContextOptions<LogViewerDbContext> options)
            : base(options)
        {
        }
    }
}
