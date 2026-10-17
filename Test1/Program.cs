using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer;
namespace Test1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Unitofwork DB = new Unitofwork();
            Customers Customer1 = new Customers();
            Customer1.FullName = "kartar";
            Customer1.Phone = "09356124165";
            Customer1.Image = "None";
            Customer1.Addres = "Tehran";
            DB.CustomerRepository.InsertCustomer(Customer1);
            DB.CustomerRepository.Save(); 
            var list = DB.CustomerRepository.GetAllCustomers();
            DB.Dispose();
        }
    }
}
