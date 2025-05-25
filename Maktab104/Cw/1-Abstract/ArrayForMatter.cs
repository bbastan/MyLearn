using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Abstract
{
    internal abstract class ArrayForMatter
    {
        internal abstract void Matters();
        
        internal void Arrayformatter(int num1, int num2, int num3)
        {
            int[,] array = new int[2, 3];
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    Console.Write($"Enter a number {i},{j}:");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 1; i >= 0; i--)
            {
                for (int j = 2; j >= 0; j--)
                {
                    Console.WriteLine($"Opposite array is {i},{j}:{array[i, j]}");
                }
            }
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    array[i, j] *= num3;
                    Console.WriteLine($"Calculator array is {i},{j}*{num3}={array[i, j]}");
                }
            }
        }
        
    }
}
