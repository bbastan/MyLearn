using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1
{
    internal class CalculatorCircle
    {
        const float piNUmber = 3.14F;
        //public double Radius { get; set; }
        internal static void CalCircle(double Radius)
        {
            double _area = Radius * 2 * piNUmber;
            double _evirom = Radius * Radius * piNUmber;
            Console.WriteLine($"Area circle is {_area} and Evironment circle is: {_evirom}");
        }
    }  
}
