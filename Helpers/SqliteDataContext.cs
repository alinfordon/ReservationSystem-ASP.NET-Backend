using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApi.Helpers
{
    public class SqliteDataContext : AbstractDatabaseContext
    {
        public SqliteDataContext(DbContextOptions<SqliteDataContext> options) : base(options)
        {

        }
    }
}