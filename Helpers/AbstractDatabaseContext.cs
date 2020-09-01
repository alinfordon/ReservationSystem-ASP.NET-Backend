using AutoMapper.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public abstract class AbstractDatabaseContext : DbContext
    {        
        public AbstractDatabaseContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Available> Availables { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<Order> Orders { get; set; }
        
    }
}
