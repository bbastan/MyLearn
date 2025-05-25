using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_1
{
    internal class SumDigit
    {
        internal void Sum(int number)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                int remina = number % 10;
                number /= 10;
                sum += remina;
            }
            Console.WriteLine($"Sum of number is : {sum}");
        }
    }
}
