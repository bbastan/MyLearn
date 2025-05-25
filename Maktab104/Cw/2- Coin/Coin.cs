using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__Coin
{
    internal class Coin
    {
        internal void GetCoin(int number)
        {
            int counter = 0;
            while (number >= 50)
            {
                number -= 50;
                counter++;
            }
            Console.WriteLine($"50 is: {counter},");
            
            counter = 0;
            while (number >= 20)
            {
                number -= 20;
                counter++;
            }
            Console.WriteLine($"20 is: {counter},");

            counter = 0;
            while (number >= 10)
            {
                number -= 10;
                counter++;
            }
            Console.WriteLine($"10 is: {counter},");

            counter = 0;
            while (number >= 5)
            {
                number -= 5;
                counter++;
            }
            Console.WriteLine($"5 is: {counter},");


            counter = 0;
            while (number >= 1)
            {
                number -= 1;
                counter++;
            }
            Console.WriteLine($"1 is: {counter},");
           
        }
    }
}
