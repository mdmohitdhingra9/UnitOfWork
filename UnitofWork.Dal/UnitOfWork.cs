using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Models;
using UnitofWork.Core.Interfaces;

namespace UnitofWork.Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RestaurantDbContext context;

        public UnitOfWork(RestaurantDbContext context)
        {
            this.context = context;
            Tables = new TableRepository(context);
            Customers = new CustomerRepository(context);
        }
        public ITableRepository Tables { get; private set; }

        public ICustomerRepository Customers { get; private set; }

        public void Dispose()
        {
            context.Dispose();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
