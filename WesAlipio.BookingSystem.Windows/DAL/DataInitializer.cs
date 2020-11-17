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
                ContactNumber = "0909181827737"
               
            });

            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("c49c023d-2602-4448-9470-72b97802035d"),
                FirstName = "Marywn",
                LastName = "Lampenmoistened",
                EmailAddress = "NoOilIsSpared@gmail.com",
                HomeAddress = "#3134 Balthazar st.,Kyrat",
                ContactNumber = "09094687143"

            });
            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("b80c8943-14a2-4719-a17d-22fe19677ec1"),
                FirstName = "XCraig",
                LastName = "Bridgeroller",
                EmailAddress = "MoatSpecialist@gmail.com",
                HomeAddress = "#324 Sebede, Ilsumina ",
                ContactNumber = "09094563178"

            });

            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("b80c8943-14a2-4719-a17d-22fe19677ed1"),
                FirstName = "Grapes",
                LastName = "AndCheeseCrackers",
                EmailAddress = "GCcracker@gmail.com",
                HomeAddress = "#412 Slate st. Kynesgrove",
                ContactNumber = "09025486177"

            });

            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("52900e14-a0fd-452c-b1b4-74796e5f4c23"),
                FirstName = "Sinigan",
                LastName = "na Hipon",
                EmailAddress = "MaasimTalaga@gmail.com",
                HomeAddress = "#878",
                ContactNumber = "09451642541"

            });
            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("b80c8943-14a2-4719-a17d-22fe19677ef1"),
                FirstName = "Pot",
                LastName = "Sam",
                EmailAddress = "ThinChops@gmail.com",
                HomeAddress = "Oyster, Bluefences",
                ContactNumber = "09164567854"

            });
            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("3f44dde2-22f3-4fbd-9e04-692090ff65ef"),
                FirstName = "Jillian",
                LastName = "Veridis",
                EmailAddress = "JVLianEri@gmail.com",
                HomeAddress = "#190 Simple st., Yugos",
                ContactNumber = "09751574683"

            });

            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("6cb691cb-af5a-48ef-9789-2d83a1a866aa"),
                FirstName = "Chester",
                LastName = "McKinsley",
                EmailAddress = "CMK0405@gmail.com",
                HomeAddress = "Sabaton, Bismarck",
                ContactNumber = "09489531549"

            });
            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("bbbb3808-5531-41e6-b8f2-1a12d7db797f"),
                FirstName = "Grendel",
                LastName = "Aster",
                EmailAddress = "GDasteR@gmail.com",
                HomeAddress = "Eris, Fortuna",
                ContactNumber = "09124894537"

            });
            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("c701ca53-6d91-47ca-9b07-788911f706a5"),
                FirstName = "Celine",
                LastName = "Fro",
                EmailAddress = "AfroLine@gmail.com",
                HomeAddress = "Gehdan, Fransmarten",
                ContactNumber = "09412587619"

            });
            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("96499e05-4db7-4950-be7e-68ca3f816d0e"),
                FirstName = "Ghok",
                LastName = "Jeremiah",
                EmailAddress = "MiaKohg@gmail.com",
                HomeAddress = "Amten, Frelowshore",
                ContactNumber = "09431534862"

            });
            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("86670d98-b120-4842-bfee-282e119e031c"),
                FirstName = "Hemp",
                LastName = "Grefford",
                EmailAddress = "NotMakingStrings@gmail.com",
                HomeAddress = "Aplidel, Gristsceine" ,
                ContactNumber = "09146874821"

            });
            context.Customers.Add(new Models.Customer()
            {
                Id = Guid.Parse("11d8b5c9-d00f-415a-a827-ff7f6ae4555e"),
                FirstName = "Wu Xuan",
                LastName = "Lan",
                EmailAddress = "OrangeFur@gmail.com",
                HomeAddress = "Jiang Li, Meilan",
                ContactNumber = "09158841357"

            });

            context.Rooms.Add(new Models.Room()
            {
                RoomNumber = "123",
                RoomDescription = "Testing",
                Pricing = 250,
                Occupants = "8",
                Availaibility = Models.Enums.Availability.Booked
            });

            context.Rooms.Add(new Models.Room()
            {
                RoomNumber = "456",
                RoomDescription = "Testing2",
                Pricing = 300,
                Occupants = "10",
                Availaibility = Models.Enums.Availability.Available
            });


            context.Reservations.Add(new Models.Reservation()
            {
                Arrival = DateTime.Parse("11/12/2020 12:00:00 AM"),
                Departure = DateTime.Parse("11/12/2020 01:00:00 PM"),
                ReservationID = Guid.Parse("11d8b5c9-d00f-415a-a827-ff7f6ae4555e")
            });


        }
    }

}
