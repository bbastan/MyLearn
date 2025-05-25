using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer6
{
    internal class Dvisibility
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        internal static void Divisible(int number1, int number2)
        {
            if (number1 > number2)
            {
                if (number1 % number2 == 0)
                {
                    Console.WriteLine($"number1 is Dvisibility number2");
                }
                else
                {
                    Console.WriteLine($"number 1 is not dvisibility number2");
                }
            }
            else
            {
                Console.WriteLine("number 1  is not the bigger number2");
            }
        }
    }
}
