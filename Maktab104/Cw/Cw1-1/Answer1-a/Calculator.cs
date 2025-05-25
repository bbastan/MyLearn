using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_a
{
    internal class Calculator
    {
        double number;
        internal double MyCalculator(double number1, double number2, double number3, double number4, char opt)
        {
            switch (opt)
            {
                case '+': number = (number1 + number2 + number3 + number4); break;
                case '-': number = (number1 - number2 - number3 - number4); break;
                case '*': number = (number1 * number2 * number3 * number4); break;
                case '/': number = (number1 / number2 / number3 / number4); break;   
            }
            return number;
        }
    }
}
