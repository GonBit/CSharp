using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindData;

namespace NorthwindBusiness
{
    public class CustomerManager
    {
        public Customer SelectedCustomer { get; set; }

        public void Create(string customerId, string contactName, string companyName, string city = null)
        {
            var newCust = new Customer() { CustomerId = customerId, ContactName = contactName, CompanyName = companyName };
            using (var db = new NorthwindContext())
            {
                db.Customers.Add(newCust);
                db.SaveChanges();
            }
        }

        public void UpdateCustomer(string customerId, string contactName, string city, string postcode, string country)
        {
            using (var db = new NorthwindContext())
            {
                SelectedCustomer = db.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();
                SelectedCustomer.ContactName = contactName;
                SelectedCustomer.City = city;
                SelectedCustomer.PostalCode = postcode;
                SelectedCustomer.Country = country;
                // write changes to database
                db.SaveChanges();
            }
        }


        public List<Customer> RetrieveAllCustomers()
        {
            using (var db = new NorthwindContext())
            {
                return db.Customers.ToList();
            }
        }

        public void SetSelectedCustomer(object selectedItem)
        {
            SelectedCustomer = (Customer)selectedItem;
        }

        public void DeleteCustomer(string customerid)
        {
            using (var db = new NorthwindContext())
            {
                var selectedCustomer =
            from c in db.Customers
            where c.CustomerId == customerid
            select c;

                db.Customers.RemoveRange(selectedCustomer);


                db.SaveChanges();
            }
        }
    }
}
