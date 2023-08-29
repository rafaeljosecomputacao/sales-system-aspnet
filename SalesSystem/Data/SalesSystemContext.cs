using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesSystem.Models;

namespace SalesSystem.Data
{
    public class SalesSystemContext : DbContext
    {
        public SalesSystemContext (DbContextOptions<SalesSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; } 
        public DbSet<SalesRecord> SalesRecord { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesRecord>()
            .HasOne(p => p.Seller)
            .WithMany(b => b.Sales)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
