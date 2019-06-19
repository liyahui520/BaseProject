using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCore.BaseProject.EntityFrameworkCore
{
    public static class BaseProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BaseProjectDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BaseProjectDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
