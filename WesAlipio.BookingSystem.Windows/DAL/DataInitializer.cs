using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesAlipio.BookingSystem.Windows.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<BookingDBContext>
    {
        protected override void Seed(BookingDBContext context)
        {
            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("b80c8943-14a2-4719-a17d-22fe19677eb1"),
                FirstName = "Giorno",
                LastName = "Giovanna",
                EmailAddress = "IHaveADream@gmail.com",
                HomeAddress = "# 277 ThisStreet,ThisTown,ThisProvince",
                ContactNumber = "09091818277"
               
            });

            
        }
    }

}
