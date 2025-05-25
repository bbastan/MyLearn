
using Answr1_3;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Enetr two float number: ");
Average average = new();
double reslut = average.AvgFloat(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
Console.WriteLine($"Average is : {reslut}");

