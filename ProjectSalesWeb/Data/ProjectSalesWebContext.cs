using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSalesWeb.Models;

namespace ProjectSalesWeb.Models
{
    public class ProjectSalesWebContext : DbContext
    {
        public ProjectSalesWebContext (DbContextOptions<ProjectSalesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
