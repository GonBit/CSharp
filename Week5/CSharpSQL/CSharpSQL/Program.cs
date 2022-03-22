using System;
using System.Data.SqlClient;

namespace CSharpSQL;

public class Program
{
    private static readonly string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    public static void Main(string[] args)
    {
        var customers = new List<Customer>();
        using (var connection = new SqlConnection(_connectionString))
        { 
            connection.Open();
            Console.WriteLine(connection.State);

            #region SELECT
            /*
            using (var command = new SqlCommand("SELECT * FROM CUSTOMERS", connection))
            {
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var customerId = sqlDataReader["CustomerId"].ToString();
                    var contactName = sqlDataReader["ContactName"].ToString();
                    var companyName = sqlDataReader["CompanyName"].ToString();
                    var city = sqlDataReader["City"].ToString();
                    var contactTitle = sqlDataReader["ContactTitle"].ToString();

                    var customer = new Customer()
                    {
                        ContactTitle = contactTitle,
                        CustomerID = customerId,
                        CompanyName = companyName,
                        ContactName = contactName,
                        City = city,
                    };

                    customers.Add(customer);
                }
            }

            customers.ForEach(x => Console.WriteLine($"{x.GetFullName()} is from {x.City}"));
            */
            #endregion

            #region CREATE
            
            var newCustomer = new Customer()
            {
                CustomerID = "MANDA",
                ContactName = "Nish Mandal",
                City = "Birmingham",
                CompanyName = "Sparta Global"
            };

            string sqlInsertString = $"INSERT INTO Customer(CustomerId, ContactName, CompanyName, City) VALUES('{newCustomer.CustomerID}','{newCustomer.ContactName}','{newCustomer.CompanyName}','{newCustomer.City}')";

            using (var command2 = new SqlCommand(sqlInsertString, connection))
            { 
                int affected = command2.ExecuteNonQuery();
            }
            
            #endregion

            #region UPDATE
            /*
            var newCustomer = new Customer()
            {
                CustomerID = "MANDA",
                ContactName = "Nish Mandal",
                City = "Birmingham",
                CompanyName = "Sparta Global"
            };

            string sqlInsertString = $"UPDATE CUSTOMERS SET City = 'Berlin' WHERE CustomerId = '{newCustomer.CustomerID}'";

            using (var command3 = new SqlCommand(sqlInsertString, connection))
            {
                int affected = command3.ExecuteNonQuery();
            }
            */
            #endregion

            #region DELETE

            var deleteString = $"DELETE FROM Customers WHERE customerID = 'MANDA'";
            using (var command4 = new SqlCommand(deleteString, connection))
            { 
                int affected = command4.ExecuteNonQuery();
            }
            #endregion

        }
    }
}