using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class MarketDBContext : DbContext
    {
        public MarketDBContext() : base("Data source=DESKTOP-RQ3BRI1\\SQLEXPRESS;initial catalog=master;persist security info=True;user id=sa;password=000;Connect Timeout=30;MultipleActiveResultSets=true")
        {
        }

        public DbSet<Products> Products { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<MainCategories> MainCategories { get; set; }

        public DbSet<Attributes> Attributes { get; set; }

        public DbSet<Attribute_Values> Attribute_Values { get; set; }

        public DbSet<Product_Attributes> Product_Attributes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // for table Product_Attributes, productsID and AttributesID is composite key
            modelBuilder.Entity<Product_Attributes>()
            .HasKey(pa => new { pa.ProductsID, pa.AttributesID });

            modelBuilder.Entity<Product_Attributes>()
            .HasOptional(pa => pa.Attribute_Values)
            .WithMany(av => av.Product_Attributes)
            .HasForeignKey(pa => pa.Discrete_Attribute_Value_ID);
        }
    }
}

// How to do Initial Migration 

// 1.Open the Package Manager Console in Visual Studio and run the following command to enable migrations for your project.( select repositoryLayer as default)
// 2.run the following command  "Enable-Migrations"   to enable migrations
// 3.Write you code in Configuration.cs to add your data. 
// 4.Run the following command  "Add-Migration InitialCreate"   to generate an initial migration
// 5.Run the following command  "Update-Database"  to apply the migration and create the database
