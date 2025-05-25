using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer_3
{
    internal class CustomDate
    {
        private DateTime? _mydate;
        

        public string MyDate
        {   
            get => Convert.ToString(_mydate);
            
            set
            {
                _mydate = Convert.ToDateTime(MyDate);
                DateTime today = DateTime.Now;
                DateTime twoDaysBefore = today.AddDays(-2);
                DateTime fourteenDaysBefore = today.AddDays(-14);
                if ((_mydate > twoDaysBefore) || (_mydate < fourteenDaysBefore))
                    Console.WriteLine($"{_mydate} is True");
                else
                    _mydate = null;
                
            }
        }
    }
}
