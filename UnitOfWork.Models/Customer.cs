using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
   public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Int64 PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

    }
}
