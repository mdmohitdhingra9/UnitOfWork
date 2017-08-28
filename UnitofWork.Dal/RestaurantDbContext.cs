using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using UnitOfWork.Models;

namespace UnitofWork.Dal
{
   public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext():base()
        {

        }

        public DbSet<Table> Tables { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
