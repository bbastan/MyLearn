using _1;
using System.Numerics;

Console.Write("Enter a number fibonacci: ");
var number = Convert.ToInt32(Console.ReadLine());
int result = Utility.Fibonaccinumber(number);
Console.WriteLine($"Exit Fibonacci number is: {result}");

Console.WriteLine("////////////////////////////////////////////");

Console.Write("Enter a number for factoriel: ");
var number2 = Convert.ToInt32(Console.ReadLine());
int result2 = Utility.Factorielnumber(number2);
Console.WriteLine($"Exit Factoriel number is: {result2}");

Console.WriteLine("////////////////////////////////////////////");

Utility.Multiplicationmatrices();
