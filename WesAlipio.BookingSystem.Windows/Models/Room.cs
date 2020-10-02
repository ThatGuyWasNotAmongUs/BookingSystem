using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using WesAlipio.BookingSystem.Windows.Models.Enums;

namespace WesAlipio.BookingSystem.Windows.Models
{
    public class Room
    {
        [Key] public string RoomNumber { get; set; }
         
        public string RoomDescription { get; set; }

        public decimal Pricing{ get; set; }

        public string Occupants { get; set; }

        public Availability Availaibility { get; set; }
    }
}
