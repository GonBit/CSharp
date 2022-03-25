using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindData.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomersList();
        Customer GetCustomerById(string id);
        void CreateCustomer(Customer c);
        void SaveCustomerChanges();
        void RemoveCustomer(Customer c);
    }
}
