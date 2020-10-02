using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesAlipio.BookingSystem.Windows.Models
{
    public class Reservation
    {
        
        public Guid? ReservationID { get; set; }

        public DateTime Arrival { get; set; }

        public DateTime Departure { get; set; }


    }
}
