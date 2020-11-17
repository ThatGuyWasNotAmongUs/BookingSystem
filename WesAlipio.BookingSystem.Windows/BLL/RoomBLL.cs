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
    public static class RoomBLL
    {
        private static BookingDBContext db = new BookingDBContext();


        public static Paged<Models.Room> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "arrival", string sortOrder = "asc", string keyword = "")
        {
            IQueryable<Room> allrooms = (IQueryable<Room>)db.Rooms;
            Paged<Models.Room> rooms = new Paged<Room>();


            var queryCount = allrooms.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "roomnumber" && sortOrder.ToLower() == "asc")
            {
                rooms.Items = allrooms.OrderBy(e => e.RoomNumber).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "roomnumber" && sortOrder.ToLower() == "desc")
            {
                rooms.Items = allrooms.OrderByDescending(e => e.RoomNumber).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "roomdescription" && sortOrder.ToLower() == "asc")
            {
                rooms.Items = allrooms.OrderBy(e => e.RoomDescription).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                rooms.Items = allrooms.OrderByDescending(e => e.RoomDescription).Skip(skip).Take(pageSize).ToList();
            }
            rooms.PageCount = pageCount;
            rooms.PageIndex = pageIndex;
            rooms.PageSize = pageSize;
            rooms.QueryCount = queryCount;

            return rooms;
        }
    }
}
