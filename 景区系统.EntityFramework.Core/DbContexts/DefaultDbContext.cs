using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace 景区系统.EntityFramework.Core;

[AppDbContext("景区系统", DbProvider.Sqlite)]
public class DefaultDbContext : AppDbContext<DefaultDbContext>
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }
}
