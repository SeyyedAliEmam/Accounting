using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;
using System;
using System.Linq;

namespace Accounting.Business
{
    public class Account
    {
        public static ReportViewModel Month_account()
        {
            ReportViewModel Report = new ReportViewModel();
            using(Unitofwork DB = new Unitofwork())
            {
                DateTime Date1 = new DateTime(DateTime.Now.Year,DateTime.Now.Month,01);
                DateTime Date2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month,30);

                var recive = DB.AccountingRepository.Get(a => a.TypeID == 1 && a.DateTime >= Date1 && a.DateTime <= Date2).Select(a => a.Amount).ToList();
                var pay = DB.AccountingRepository.Get(a => a.TypeID == 2 && a.DateTime >=Date1 &&a.DateTime <= Date2).Select(a => a.Amount).ToList();

                Report.Recive = recive.Sum();
                Report.Pay = pay.Sum();
                Report.mande = (recive.Sum() - pay.Sum());
            }
            return Report;
        }
    }
}
