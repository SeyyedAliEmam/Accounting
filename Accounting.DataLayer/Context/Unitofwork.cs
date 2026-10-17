using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    public class Unitofwork : IDisposable
    {
        //الگوی یونیت اف رک برای بهینه سازی دسترسی به دیتابیس استفاده میشود 
        //با این کار برای اتصال به دیتا بیس کافی است یک نمونه از این کلاس ایجاد کنیم

        AccountingEntity UnitDB = new AccountingEntity();

        private ICustomerRepository _CustomerRepository;
        public ICustomerRepository CustomerRepository 
        {
            get
            {
                if (_CustomerRepository == null)
                {
                    _CustomerRepository = new CustomerRepository(UnitDB);
                }
                return _CustomerRepository;
            }
           
        }

        private GenericRepository<Accounting> _AccountingRepository;
        public GenericRepository<Accounting> AccountingRepository 
        { 
            get
            {
                if (_AccountingRepository == null)
                {
                    _AccountingRepository = new GenericRepository<Accounting>(UnitDB);
                }
                return _AccountingRepository;
            }
        }
            
        private GenericRepository<Login> _LoginRepository;
        public GenericRepository<Login> LoginRepository
        {
            get
            {
                if (_LoginRepository == null)
                {
                    _LoginRepository = new GenericRepository<Login>(UnitDB);
                }
                return _LoginRepository;
            }
        }
        public void Save()
        {
            UnitDB.SaveChanges();
        }

        public void Dispose()
        {
            UnitDB.Dispose();
        }
    }
}
