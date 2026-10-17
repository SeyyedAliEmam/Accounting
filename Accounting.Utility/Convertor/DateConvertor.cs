using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Accounting.Utility.Convertor;


namespace Accounting.Utility.Convertor
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar PC = new PersianCalendar();
            return PC.GetYear(value)+"/"+PC.GetMonth(value).ToString("00")+"/"+PC.GetDayOfMonth(value).ToString("00");
        }
        public static DateTime ToMiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }

    }
}
