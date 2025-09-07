using InheritanceExample.Models;
using Microsoft.EntityFrameworkCore;

namespace InheritanceExample.Contexts
{
    internal class AppBdContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPH
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();

            // TPC
            //modelBuilder.Entity<Employee>().ToTable("Employee");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployee");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployee");

            // TPCC


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Server = .; Database = InheritDB; Trusted_Connection = True; TrustServerCertificate = True");
        }

        //public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }
}
