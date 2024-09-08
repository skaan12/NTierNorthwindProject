using Microsoft.EntityFrameworkCore;
using NTier.DAL.Configuration;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Context
{
    public class NorthwindContext : DbContext
    {
        string connectionString = "server=DESKTOP-P8K1SK9;database=NorthwindCodeFirstDB;Trusted_Connection=true;TrustServerCertificate=true";

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }

        public DbSet<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }

        public DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public DbSet<Employees> Employees { get; set; }

        public DbSet<EmployeeTerritories> EmployeeTerritories { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Products> Products { get; set; }

        public DbSet<Region> Region { get; set; }
        public DbSet<Shippers> Shippers { get; set; }

        public DbSet<Suppliers> Suppliers { get; set; }

        public DbSet<Territories> Territories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());

            modelBuilder.ApplyConfiguration(new CustomerCustomerDemoConfiguration());

            modelBuilder.ApplyConfiguration(new CustomerDemographicsConfiguration());

            modelBuilder.ApplyConfiguration(new CustomersConfiguration());

            modelBuilder.ApplyConfiguration(new EmployeesConfiguration());

            modelBuilder.ApplyConfiguration(new EmployeesTerritoriesConfiguration());

            modelBuilder.ApplyConfiguration(new OrderDetailsConfiguration());

            modelBuilder.ApplyConfiguration(new OrdersConfiguration());

            modelBuilder.ApplyConfiguration(new ProductsConfiguration());

            modelBuilder.ApplyConfiguration(new RegionConfiguration());

            modelBuilder.ApplyConfiguration(new ShippersConfiguration());

            modelBuilder.ApplyConfiguration(new SuppliersConfiguration());

            modelBuilder.ApplyConfiguration(new TerritoriesConfiguration());




            //modelBuilder.Entity<Products>().HasOne(p => p.Categories).WithMany(x=>x.Products).HasForeignKey(pd => pd.CategoryID);

            //modelBuilder.Entity<Products>().HasOne(x=>x.Suppliers).WithMany(xd=>xd.Products).HasForeignKey(xd => xd.SupplierID);


            //modelBuilder.Entity<OrderDetails>().HasOne(x => x.Products).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductID);

            //modelBuilder.Entity<Orders>().HasOne(x => x.Shippers).WithMany(x => x.Orders).HasForeignKey(x => x.ShipVia);

            //modelBuilder.Entity<Employees>().HasOne(x=>x.Manager).WithMany(x=>x.Subordinates).HasForeignKey(x=>x.ReportsTo).IsRequired(false);

            base.OnModelCreating(modelBuilder);
        }

    }
    
}
