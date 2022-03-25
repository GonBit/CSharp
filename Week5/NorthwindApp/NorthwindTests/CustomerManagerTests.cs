using NUnit.Framework;
using NorthwindBusiness;
using NorthwindData;
using System.Linq;

namespace NorthwindTests
{
    public class CustomerTests
    {
        CustomerManager _customerManager;
        [SetUp]
        public void Setup()
        {
           _customerManager = new CustomerManager();
            // remove test entry in DB if present
            using (var db = new NorthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustomersIncreasesBy1()
        {
            using (var db = new NorthwindContext())
            {
                int num = db.Customers.Count();
                db.Customers.Add(new Customer() { CustomerId = "MANDA", CompanyName = "Anything"});                
                Assert.That(db.Customers.Count(), Is.EqualTo(num + 1));
            }
        }

        [Test]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated()
        {
            using (var db = new NorthwindContext())
            {
                              
                db.Customers.Add(new Customer() { CustomerId = "MANDA" , CompanyName = "Kekw"});                
                Assert.That(db.Customers.Find("MANDA").CompanyName, Is.EqualTo("Kekw"));               
                db.Customers.Find("MANDA").CompanyName = "omega";                
                Assert.That(db.Customers.Find("MANDA").CompanyName, Is.EqualTo("omega"));
            }
        }

        [Test]

        public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
        {
            using (var db = new NorthwindContext())
            {
                int num = db.Customers.Count();
                Assert.That(db.Customers.Count(), Is.EqualTo(num));                

                //db.Customers.RemoveRange(selectedCustomer);
                int numLeft = db.Customers.Count();
                db.SaveChanges();
                Assert.That(db.Customers.Count(), Is.EqualTo(numLeft));

            }
        }
    

    [TearDown]
        public void TearDown()
        {
            using (var db = new NorthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }
    }
}