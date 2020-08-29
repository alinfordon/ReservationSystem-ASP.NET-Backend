using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Helpers
{
    public class SqlServerDataContext : AbstractDatabaseContext
    {

        public SqlServerDataContext(DbContextOptions<SqlServerDataContext> options) : base(options)
        {
            
        }       

    }
}