using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyCore.BaseProject.Configuration;
using MyCore.BaseProject.Web;

namespace MyCore.BaseProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BaseProjectDbContextFactory : IDesignTimeDbContextFactory<BaseProjectDbContext>
    {
        public BaseProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BaseProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BaseProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BaseProjectConsts.ConnectionStringName));

            return new BaseProjectDbContext(builder.Options);
        }
    }
}
