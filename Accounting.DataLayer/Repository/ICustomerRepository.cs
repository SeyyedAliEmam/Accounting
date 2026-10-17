using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Repository
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCustomersBySearch(String Parameter);
        List<ListCustomerViewModel> GetCustomersFullName(string filter = "");
        int GetIDByFullName(string FullName);
        string GetFullNameByID(int CustomerID);
        Customers GetCustomer(int CustomerID);
        bool InsertCustomer(Customers Customer);
        bool UpdateCustomer(Customers Customer);
        bool DeleteCustomer(Customers Customer);
        bool DeleteCustomer(int CustomerID);
    }
}
