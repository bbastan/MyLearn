using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_5
{
    internal class ReverseNumber
    {
        internal void Revese(int number)
        {
            int remain;
            while (number> 0)
            {
                remain = number % 10;
                Console.Write(remain);
                number /= 10;
            }
        }
    }
}
