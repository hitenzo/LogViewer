using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LogViewer.EntityFrameworkCore
{
    public static class LogViewerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LogViewerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LogViewerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
