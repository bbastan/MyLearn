using System.ComponentModel.Design;

namespace Answer4
{
    internal class Calenter
    {
        
        public static int Month { get; set; }
        public static int Day { get; set; }

        internal static void CalcolateCalenter(int month, int day)
        {
            int _days = 0;
            if (month <= 6)
            {
                _days = ((month - 1) * 31) + day;
            }
            else if (month == 7)
            {
                month -= 1;
                _days = (month * 31) + day;
            }
            else
            {
                _days = ((month - 1) * 30 + day) + 6;
            }
            Console.WriteLine($"Day is: {_days}");
        }

       
    }
}

