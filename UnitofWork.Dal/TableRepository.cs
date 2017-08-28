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
    public class TableRepository : Repository<Table>, ITableRepository
    {
        private readonly RestaurantDbContext context;
        public TableRepository(RestaurantDbContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Table> GetUnOccupiedTables()
        {
            return context.Tables.Where(x => !x.IsOccupied).ToList();
        }
    }
}
