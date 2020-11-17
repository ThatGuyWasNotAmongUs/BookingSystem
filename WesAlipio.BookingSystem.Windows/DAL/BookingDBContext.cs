using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WesAlipio.BookingSystem.Windows.Models;

namespace WesAlipio.BookingSystem.Windows.DAL
{
    public class BookingDBContext : DbContext
    {
        public BookingDBContext() : base("myConnectionString")
        {
            Database.SetInitializer(new WesAlipio.BookingSystem.Windows.DAL.DataInitializer());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
