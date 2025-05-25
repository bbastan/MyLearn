using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__ConvertMiladiToShamsi
{
    public static class ConvertMiladiToShamsi 
    {
        public static string ToShamsi(this DateTime datetime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetYear(datetime) + "/" + persianCalendar.GetMonth(datetime) + "/" + persianCalendar.GetDayOfMonth(datetime);
        }
    }
}




