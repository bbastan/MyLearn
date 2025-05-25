using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_b
{
    internal class Calculator
    {
        internal double MyCalculator(double result)
        {
            
            int[] number = new int[4];
            char[] chars = new char[4];
            
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1} from three");
                number[i] = int.Parse(Console.ReadLine());

                if (i == 3) Console.WriteLine($"Enter character '=' for see result: ");
                else Console.WriteLine($"Enter operation {i} from 3:");
                chars[i] = char.Parse(Console.ReadLine());

                if (chars[i] != '=')
                {
                    switch (chars[i])
                    {
                        case '+': result += number[i]; continue;
                        case '-': result -= number[i]; continue;
                        case '*': result *= number[i]; continue;
                        case '/': result /= number[i]; continue;
                    }
                }
                else if (chars[2] == '+')
                {
                    result += number[i]; break;
                }
                else if (chars[2] == '-')
                {
                    result -= number[i]; break;
                }
                else if (chars[2] == '*')
                {
                    result *= number[i]; break;
                }
                else if (chars[2] == '/')
                {
                    result /= number[i]; break;
                }
            }

            return result;

        }
    }
}
