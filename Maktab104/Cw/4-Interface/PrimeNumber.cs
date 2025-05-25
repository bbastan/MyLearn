using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface
{
    internal class PrimeNumber : Interface1
    {
        public int CheckPrime(int num)
        {
            if ((num % 2 == 0))
            {
                Console.WriteLine($"Number is not prime: ");
            }
            else 
            { 
                Console.WriteLine($"Number is prime: ");
            }
            return num;
        }
    }
}
