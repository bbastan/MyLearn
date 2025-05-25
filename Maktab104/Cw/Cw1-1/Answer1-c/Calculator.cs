using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_c
{
    internal class Calculator
    {
        internal double Mycalculator(int number)
        {
            int[] desiredNumber = new int[number];
            double result = 0;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"This loop is {i+1} to {number} so enter a desired number: ");
                desiredNumber[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a operator:");
            char chars = char.Parse(Console.ReadLine());
            for (int j = 0; j < number; j++)
            {
                switch (chars)
                {
                    case '+': result += desiredNumber[j]; continue;
                    case '-': result -= desiredNumber[j]; continue;
                    case '*': result *= desiredNumber[j] * 1; continue;
                    case '/': result /= desiredNumber[j] / 1; continue;
                }
            }
            return result;
        } 
    }
}
