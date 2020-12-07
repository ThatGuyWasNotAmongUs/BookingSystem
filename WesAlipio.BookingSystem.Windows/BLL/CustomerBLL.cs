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
    public static class CustomerBLL
    {
        private static BookingDBContext db = new BookingDBContext();

        public static Paged<Models.Customer> Search(int pageIndex = 1, int pageSize = 5, string sortBy = "lastname", string sortOrder = "asc", string keyword = "")
        {
            IQueryable<Customer> allCustomers = (IQueryable<Customer>)db.Customers;
            Paged<Models.Customer> customers = new Paged<Customer>();
           
            if (!string.IsNullOrEmpty(keyword))
            {
                allCustomers = allCustomers.Where(e => e.FirstName.Contains(keyword) || e.LastName.Contains(keyword));
            }

            var queryCount = allCustomers.Count();
            var skip = pageSize * (pageIndex - 1);
                
            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "firstname" && sortOrder.ToLower() == "asc")
            {
                customers.Items = allCustomers.OrderBy(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "firstname" && sortOrder.ToLower() == "desc")
            {
                customers.Items = allCustomers.OrderByDescending(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "lastname" && sortOrder.ToLower() == "asc")
            {
                customers.Items = allCustomers.OrderBy(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                customers.Items = allCustomers.OrderByDescending(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }

            customers.PageCount = pageCount;
            customers.PageIndex = pageIndex;
            customers.PageSize = pageSize;
            customers.QueryCount = queryCount;

            return customers;

        }
        public static Operation Add(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = customer.Id
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }

        public static Operation Update(Customer newRecord)
        {
            try
            {
                Customer oldRecord = db.Customers.FirstOrDefault(e => e.Id == newRecord.Id);

                if (oldRecord != null)
                {

                    oldRecord.EmailAddress = newRecord.EmailAddress;
                    oldRecord.FirstName = newRecord.FirstName;
                    oldRecord.LastName = newRecord.LastName;
                    oldRecord.ContactNumber = newRecord.ContactNumber;
                    oldRecord.HomeAddress = newRecord.HomeAddress;
                    


                    db.SaveChanges();

                    return new Operation()
                    {
                        Code = "200",
                        Message = "OK"
                    };
                }


                return new Operation()
                {
                    Code = "500",
                    Message = "Not found"
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }
    }


}
