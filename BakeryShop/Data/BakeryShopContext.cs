using BakeryShop.Data.Configurations;
using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
namespace BakeryShop.Data
{
    public class BakeryShopContext:DbContext
    {
        //Name of Database
        public DbSet<Product> Products { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the context to use SQL Server.
            // optionsBuilder.UseSqlServer(@"Data Source=BakeryDB.db");
            optionsBuilder.UseSqlServer(@"Integrated Security=true;Initial Catalog=BakeryShop;Data Source=LAPTOP-08BDR00V\SQLEXPRESS");
        }

        //Apply Configuration  in ProductConfiguration-->Migrate
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
        //Apply Configuration  in ProductConfiguration-->Migrate



    }
}
