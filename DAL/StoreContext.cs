using DAL.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<EmployeeMail> EmployeeMails { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(em => em.Trainer)
                .WithMany(e => e.Staffs)
                .HasForeignKey(e => e.TrainerID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EmployeeMail>().HasKey(em => new { em.Email, em.EmployeeId });

            modelBuilder.Entity<Ingredient>().HasKey(i => new { i.Contains, i.ProductBarcode });

            modelBuilder.Entity<DepartmentProduct>().HasKey(i => new { i.DepartmentName, i.ProductBarcode });
            modelBuilder.Entity<DepartmentProduct>()
                .HasOne(d => d.Department)
                .WithMany(d => d.Products)
                .HasForeignKey(d => d.DepartmentName)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<DepartmentProduct>()
                .HasOne(d => d.Product)
                .WithMany(d => d.Departments)
                .HasForeignKey(d => d.ProductBarcode)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Seed();
        }
    }
}
