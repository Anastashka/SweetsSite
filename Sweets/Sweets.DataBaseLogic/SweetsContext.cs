using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sweets.Entities;

namespace Sweets.DataBaseLogic
{
    public class SweetsContext : DbContext
    {
        /// <summary>
        /// Gets or sets category
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets customer orders
        /// </summary>
        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        /// <summary>
        /// Gets or sets customer orders
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets users
        /// </summary>
        public DbSet<User> Users { get; set; }
        public SweetsContext() : base("name=SweetsConnectionString") 
        {
            //Database.SetInitializer<SweetsContext>(new CreateDatabaseIfNotExists<SweetsContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.ID);
            modelBuilder.Entity<Product>().HasKey(x => x.ID);
            modelBuilder.Entity<Category>().HasKey(x => x.ID);
            modelBuilder.Entity<Category>().HasMany(x => x.Products).WithRequired(x => x.Category);
            modelBuilder.Entity<CustomerOrder>().HasKey(x => x.ID);
            modelBuilder.Entity<CustomerOrder>().HasMany(x => x.OrderProduts).WithMany(x => x.Orders);

        }
      
    }
}

