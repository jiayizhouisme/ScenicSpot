using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace 景区系统.EntityFramework.Core;

public class Startup : AppStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDatabaseAccessor(options =>
        {
            options.AddDbPool<DefaultDbContext>();
        }, "景区系统.Database.Migrations");
    }
}
