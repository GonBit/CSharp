using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NorthwindData.Services;
using Microsoft.EntityFrameworkCore;
using NorthwindData;

namespace NorthwindTests
{
    public class CustomerServiceTests
    {
        private CustomerService _sut;
        private NorthwindContext _context;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var options = new DbContextOptionsBuilder<NorthwindContext>().UseInMemoryDatabase(databaseName: "ExampleDb").Options;
            _context = new NorthwindContext(options);
            _sut = new CustomerService(_context);

            _sut.CreateCustomer(new Customer { CustomerId = "MANDA", ContactName = "Nish Mandal", CompanyName = "Sparta Global", City = "Birmingham" });
            _sut.CreateCustomer(new Customer { CustomerId = "FRENC", ContactName = "Cathy French", CompanyName = "Sparta Global", City = "Ottawa" });

        }

        [Test]
        public void GivenAValidId_CorrectCustomerReturned()
        {
            var result = _sut.GetCustomerById("MANDA");
            Assert.That(result, Is.TypeOf<Customer>());
            Assert.That(result.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(result.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(result.City, Is.EqualTo("Birmingham"));
        }

        [Test]
        public void GivenANewCustomer_CreateCustomerAddsItToTheDatabase()
        {
            var numberOfCustomersBefore = _context.Customers.Count();
            var newCust = new Customer { CustomerId = "MOHGI", ContactName = "Seb Moghim", CompanyName = "Sparta Global", City = "London" };
            _sut.CreateCustomer(newCust);
            var numberOfCustomersAfter = _context.Customers.Count();

            Assert.AreEqual(numberOfCustomersBefore + 1, numberOfCustomersAfter);

            var result = _sut.GetCustomerById("MOHGI");
            Assert.That(result, Is.TypeOf<Customer>());
            Assert.That(result.ContactName, Is.EqualTo("Seb Moghim"));
            Assert.That(result.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(result.City, Is.EqualTo("London"));

            //Cleanup
            _context.Customers.Remove(newCust);
            _context.SaveChanges();

        }

        [Test]
        public void GivenACustomerToRemove_RemovesItOutOfTheDatabase()
        {            
            var newCust = new Customer { CustomerId = "GONC", ContactName = "Goncalo Nunes", CompanyName = "Sparta Interstellar", City = "Sea of Tranquility" };
            _sut.CreateCustomer(newCust);
            var numBefore = _context.Customers.Count();            

            _context.Customers.Remove(newCust);
            _context.SaveChanges();
            var numAfter = _context.Customers.Count();

            Assert.That(numBefore - 1, Is.EqualTo(numAfter));

        }

        [Test]
        public void GivenACustomerList_ReturnsTheRightList()
        {

            //You can use count and compare count 
            var cusList = new List<Customer>();           
            cusList = _sut.GetCustomersList();

            //Assert.That(custList, Does.Contain());

        }

    }
}
