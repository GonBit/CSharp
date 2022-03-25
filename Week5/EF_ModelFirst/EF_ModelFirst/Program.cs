using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SouthwindContext())
            {
                #region Create
                
                Console.WriteLine("Creating some Customers");
                db.AddRange(
                    new Customer { CustomerId = "MANDA", City = "Brum", ContactName = "Nish Mandal", PostalCode = "B74BB"},
                    new Customer { CustomerId = "FRENC", City = "Brum", ContactName = "Cathy French", PostalCode = "A1B2C"}
                    );
                db.SaveChanges();
                
                #endregion

                #region Read
                Console.WriteLine("Querying customers");
                var customerQuery = db.Customers.OrderBy(c => c.ContactName);
                customerQuery.ToList().ForEach(c => Console.WriteLine($"{c.ContactName} lives in  {c.City}"));

                #endregion

                #region Update

                var customer = db.Customers.Find("FRENC");
                customer.City = "Ottawa";
                db.SaveChanges();
                customerQuery.ToList().ForEach(c => Console.WriteLine($"{c.ContactName} lives in  {c.City}"));
                #endregion

                #region Update with a related entity

                var nish = db.Customers.Find("MANDA");
                nish.Orders.Add(new Order() { CustomerId = nish.CustomerId, OrderDate = DateTime.Now, ShipCountry = "Brazil" });
                nish.Orders.Add(new Order() { CustomerId = nish.CustomerId, OrderDate = DateTime.Now, ShipCountry = "Brazil" });
                nish.Orders.Where(x => x.OrderId == 2).FirstOrDefault().ShipCountry = "Japan";
                db.SaveChanges();

                foreach (var item in nish.Orders)
                {
                    Console.WriteLine($"{item.OrderDate} {item.ShipCountry}");
                }

                #endregion

                #region Update - Add order details to an order

                var order = db.Orders.Find(1);
                var orderDetails1 = new OrderDetail { UnitPrice = 30.00m, Discount = 0.5f, Quantity = 2 };
                var orderDetails2 = new OrderDetail { UnitPrice = 10.00m, Discount = 0.25f, Quantity = 1 };
                order.OrderDetails = new List<OrderDetail> { orderDetails1 ,orderDetails2};
                db.SaveChanges();

                Console.WriteLine("Querying orders");
                var customerQuery2 = db.Customers.OrderBy(x => x.ContactName);
                foreach (var c in customerQuery2.Include(c => c.Orders))
                {
                    Console.WriteLine($"{c.ContactName} lives in {c.City}");
                    if (c.Orders.Count > 0)
                    {
                        foreach (var o in c.Orders)
                        {
                            Console.WriteLine($"Order {o.OrderId} by {order.Customer.ContactName} made on {order.OrderDate.Value.Date}");
                        }
                    }

                }

                #endregion

                #region Update with new column
                db.Customers.Find("FRENCH").Country = "Canada";
                db.Customers.Find("MANDA").Country = "England";
                db.SaveChanges();

                foreach (var item in db.Customers)
                {
                    Console.WriteLine(item.Country);
                }
                #endregion

            }
        }
    }
}
