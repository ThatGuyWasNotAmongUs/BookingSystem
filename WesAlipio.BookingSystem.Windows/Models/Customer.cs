using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesAlipio.BookingSystem.Windows.Models
{
    public class Customer
    {
        public Guid? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string HomeAddress { get; set; }

        public string ContactNumber { get; set; }
    }
}
