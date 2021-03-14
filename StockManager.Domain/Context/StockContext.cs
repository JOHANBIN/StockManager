using StockManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StockManager.Domain.Context
{
   public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<UniqueNo> UniqueNos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Stock_product");
            modelBuilder.Entity<UniqueNo>().ToTable("Unique_No");
        }
    }
}
