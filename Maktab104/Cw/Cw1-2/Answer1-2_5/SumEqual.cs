using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_2_5
{
    internal class SumEqual
    {
        internal void Sum(int number)
        {
            
            int[] number1 = new int[3];
            for (int i = 0; i < number1.Length; i++)
            {
                int remain = (number % 10);
                number1 [i] = remain;
                number = number / 10;
                //Console.WriteLine(number1[i]);
            }
            if ((number1[0] + number1[2]) == number1[1]) Console.WriteLine("True");
            else Console.WriteLine("false");

        }

    }
}
