
using System;
using System.Collections.Generic;
using System.Text;

using EF_Core_Fluent_API_Relationship.Entity;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Fluent_API_Relationship
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeptEmployee>()
                    .HasKey(de => new { de.EmployeeId, de.DepartmentId });
        }

        public DbSet<Employee> Employees { get; set; }
        
        public DbSet<Department> Departments { get; set; }
        public DbSet<DeptEmployee> DeptEmployees { get; set; }
    }
}
