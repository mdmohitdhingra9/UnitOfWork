using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitofWork.Core.Interfaces;
using UnitOfWork.Models;

namespace UnitofWork.Dal
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly RestaurantDbContext context;

        public CustomerRepository(RestaurantDbContext context) : base(context)
        {
            this.context = context;
        }

        public void BookTable(Customer customer, List<Table> tables)
        {
            
        }
    }
}
