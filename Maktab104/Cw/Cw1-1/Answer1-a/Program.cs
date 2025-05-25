// See https://aka.ms/new-console-template for more information
using Answer1_a;

Console.WriteLine("Enter 4 number and one math operation: ");
Calculator calculator = new Calculator();
var result = calculator.MyCalculator(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
Console.WriteLine($"Result is: {result}");