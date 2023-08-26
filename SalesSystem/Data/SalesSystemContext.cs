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

        public DbSet<SalesSystem.Models.Department> Department { get; set; } = default!;
        public DbSet<SalesSystem.Models.Seller> Seller { get; set; } = default!;
        public DbSet<SalesSystem.Models.SalesRecord> SalesRecord { get; set; } = default!;
    }
}
