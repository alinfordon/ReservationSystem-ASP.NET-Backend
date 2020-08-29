using AutoMapper.Configuration;
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
    }
}
