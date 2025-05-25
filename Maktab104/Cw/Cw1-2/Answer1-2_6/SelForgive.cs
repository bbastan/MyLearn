using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_2_6
{
    internal class SelForgive
    {
        internal void Forgin(int number)
        {
            int remain = number % 10;
            if (remain == 0) return;
            int div = number / 10;
            if ((number % remain == 0) && (number % div == 0 )) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
