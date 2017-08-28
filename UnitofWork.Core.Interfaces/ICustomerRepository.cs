using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Models;

namespace UnitofWork.Core.Interfaces
{
   public interface ICustomerRepository : IRepository<Customer>
    {
        void BookTable(Customer customer, List<Table> tables);
    }
}
