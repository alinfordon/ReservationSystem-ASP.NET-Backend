using AutoMapper.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services
{
    public class OrderService : ControllerBase
    {
        private AbstractDatabaseContext _context;

        public OrderService(AbstractDatabaseContext context)
        {
            _context = context;
        }

        
    }
}
