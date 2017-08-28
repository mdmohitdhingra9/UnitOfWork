using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
    public class Chair
    {
        public string Title { get; set; }
    }

    public enum TableTypes
    {
        Small = 2,
        Medium = 4,
        Large = 8
    }

    public class Table
    {
        public int TableId { get; set; }
        public string TableNumber { get; set; }
        public List<Chair> Chairs { get; set; }
        public DateTime? BookedTime { get; set; }
        public DateTime? AvailableTime { get; set; }
        public TableTypes TableType { get; set; }
        public bool IsOccupied { get; set; }

    }
}
