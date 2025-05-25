using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Area
    {
        const double pi = 3.14F;
        internal void CalculateArea(int num1)
        {
            double areaCircle = pi * num1;
            Console.WriteLine($"Cyrcle area is: {areaCircle}");
        }
            
    }
}
