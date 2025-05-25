using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_4
{
    internal class SubString
    {
        internal void SubstringMethod(string date) 
        {
            Console.WriteLine($"Year: {date.Substring(0, 4)}");
            Console.WriteLine($"Month: {date.Substring(4, 2)}");
            Console.WriteLine($"day: {date.Substring(6, 2)}");
        }
    }
}
