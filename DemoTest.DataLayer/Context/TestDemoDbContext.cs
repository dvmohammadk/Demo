using DemoTest.Domain.Entites.Product;
using DemoTest.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Type = DemoTest.Domain.Enum.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.DataLayer.Context
{
    public class TestDemoDbContext:DbContext
    {
        #region Cotr   
        //public TestDemoDbContext(DbContextOptions<DbContext> options) : base(options)
        //{
            
        //}
        public TestDemoDbContext(DbContextOptions<TestDemoDbContext> options) : base(options)
        {

        }
        #endregion
        #region products

        public DbSet<Product> Products { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Seed Data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasData(new Product { Id = Guid.NewGuid(), Name = nameof(UserRoles.Customer) });
            modelBuilder.Entity<Product>().HasData(new Product { Id = Guid.NewGuid(),Color  = Color.Blue, Type = Type.Phone });
            modelBuilder.Entity<Product>().HasData(new Product { Id = Guid.NewGuid(),Color  = Color.Red, Type = Type. Mobile});
            modelBuilder.Entity<Product>().HasData(new Product { Id = Guid.NewGuid(),Color  = Color.Orange, Type = Type.Phone });
            modelBuilder.Entity<Product>().HasData(new Product { Id = Guid.NewGuid(),Color  = Color.Blue, Type = Type.Tablet });
        }

    }
}
 