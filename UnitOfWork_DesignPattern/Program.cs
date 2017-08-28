using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using UnitofWork.Dal;
using UnitOfWork.Models;

namespace UnitOfWork_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitofWork.Dal.UnitOfWork(new RestaurantDbContext()))
            {
                // Transaction 1
                var freeTable = unitOfWork.Tables.GetUnOccupiedTables().FirstOrDefault();

                // Transaction 2
                unitOfWork.Customers.BookTable(new Customer(), new List<Table>());

                // Physical commit only one time. That's why save method should be in unit of work
                unitOfWork.Save();

            }
        }
    }
}
