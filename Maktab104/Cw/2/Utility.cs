using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal static class Utility
    {
        internal static int Fibonaccinumber(int number)
        {

            int num = 1, temp = 0, sum = 1;
            for (int i = 0; i < number; i++)
            {
                num = temp;
                temp = sum;
                sum = num + temp;
            }

            return sum;
        }


        internal static int Factorielnumber(int number2)
        {

            int temp = 1, mult = 1;
            for (int i = 1; i <= number2; i++)
            {
                temp = mult;
                mult = i * temp;
            }
            return mult;
        }

        internal static void Multiplicationmatrices()
        {
            int[] num1 = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.Write($"Enter index {i} for array one-dimensional:");
                num1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            int[,] num2 = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter index {i},{j} for array two-dimensional:");
                    num2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int tempArr = 0;
            int[] num3 = new int[3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tempArr += num1[j] * num2[i, j];
                }
                num3[i] = tempArr;
                tempArr = 0;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Multiplication matrices array is : {num3[i]}");
            }
        }
    }
}
