using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindData.Services
{
    //CustomerManager will call the methods from this class
    public class CustomerService : ICustomerService
    {
        //We are using dependency injection to inject a NorthwindContext object into a
        //new Customer Service object via the construtor
        private readonly NorthwindContext _context;
        public CustomerService(NorthwindContext context) 
        {
            _context = context;
        }
        //We are providing a no-argument construtor that constructs a NorthwindContext Object
        public CustomerService() 
        {
            _context = new NorthwindContext();
        }

        public void CreateCustomer(Customer c)
        {
            _context.Customers.Add(c);
            _context.SaveChanges();
        }

        public Customer GetCustomerById(string id)
        {
            return _context.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
        }

        public List<Customer> GetCustomersList()
        {
            return _context.Customers.ToList();
        }

        public void RemoveCustomer(Customer c)
        {
            _context.Customers.Remove(c);
            _context.SaveChanges();
        }

        public void SaveCustomerChanges()
        {
            _context.SaveChanges(); ;
        }
    }
}
