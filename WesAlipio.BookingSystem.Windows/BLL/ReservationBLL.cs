using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WesAlipio.BookingSystem.Windows.DAL;
using WesAlipio.BookingSystem.Windows.Helpers;
using WesAlipio.BookingSystem.Windows.Models;

namespace WesAlipio.BookingSystem.Windows.BLL
{
    public static class ReservationBLL
    {
        private static BookingDBContext db = new BookingDBContext();


        public static Paged<Models.Reservation> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "arrival", string sortOrder = "asc", string keyword = "")
        {
            IQueryable<Reservation> allreservations = (IQueryable<Reservation>)db.Reservations;
            Paged<Models.Reservation> reservations = new Paged<Reservation>();


            var queryCount = allreservations.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "arrival" && sortOrder.ToLower() == "asc")
            {
                reservations.Items = allreservations.OrderBy(e => e.Arrival).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "arrival" && sortOrder.ToLower() == "desc")
            {
                reservations.Items = allreservations.OrderByDescending(e => e.Arrival).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "Departure" && sortOrder.ToLower() == "asc")
            {
                reservations.Items = allreservations.OrderBy(e => e.Departure).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                reservations.Items = allreservations.OrderByDescending(e => e.Departure).Skip(skip).Take(pageSize).ToList();
            }
            reservations.PageCount = pageCount;
            reservations.PageIndex = pageIndex;
            reservations.PageSize = pageSize;
            reservations.QueryCount = queryCount;

            return reservations;
        }
    }
}
