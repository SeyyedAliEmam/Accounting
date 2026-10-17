using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Accounting.DataLayer.Repository;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private AccountingEntity DB ; 
        public CustomerRepository(AccountingEntity context)
        {
            DB = context ;
        }
        //کد های بالا برای تزریق وابستگی به کار میروند 
        //با این کار هنگام فراخوانی کلاس وابستگی آن که نماینده دیتا بیس است به کانستراکتور کلاس تزریق میشود

        public List<Customers> GetAllCustomers()
        {
            return DB.Customers.ToList();
        }

        public Customers GetCustomer(int CustomerID)
        {
            return DB.Customers.Find(CustomerID);
        }

        public bool InsertCustomer(Customers Customer)
        {
            try
            {
                DB.Customers.Add(Customer);
                return true;
            }
            catch 
            { 
                return false; 
            } 
        }

        public bool UpdateCustomer(Customers Customer)
        {
            try
            {
                DB.Entry(Customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customers Customer)
        {
            try 
            {
                DB.Entry(Customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int CustomerID)
        {
            try
            {
                var Customer = GetCustomer(CustomerID);
                DeleteCustomer(Customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Customers> GetCustomersBySearch(string Parameter)
        {
            return DB.Customers.Where(C => C.FullName.Contains(Parameter) || C.Addres.Contains(Parameter) || C.Phone.Contains(Parameter)).ToList();
        }

        public List<ListCustomerViewModel> GetCustomersFullName(string Search = "")
        {
            if (Search == "")
            {
                return DB.Customers.Select(C => new ListCustomerViewModel() {CustomerID= C.CustomerID,FullName= C.FullName}).ToList();
            }
            return DB.Customers.Where(C => C.FullName.Contains(Search)).Select(C => new ListCustomerViewModel() {CustomerID = C.CustomerID, FullName=C.FullName}).ToList();
        }

        public int GetIDByFullName(string FullName)
        {
            return DB.Customers.First(C => C.FullName == FullName).CustomerID;
        }

        public string GetFullNameByID(int CustomerID)
        {
            return DB.Customers.Find(CustomerID).FullName;
        } 
    }
}
