using Microsoft.EntityFrameworkCore;
using OrderingSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSample.DataAccess.Context
{
    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.; Database=OrderDb;  Uid=sa; pwd=123;");
        }
    }
}
