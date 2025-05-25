using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Triangle : Area
    {
        internal void CalculateArea(int num1, int num2)
        {
            double areaTriangle = (num1 * num2) / 2;
            Console.WriteLine($"Triangle area is: {areaTriangle}");
        }
    }
}
