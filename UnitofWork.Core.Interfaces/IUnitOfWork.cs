using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitofWork.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITableRepository Tables { get; }
        ICustomerRepository Customers { get; }
        int Save();
    }
}
