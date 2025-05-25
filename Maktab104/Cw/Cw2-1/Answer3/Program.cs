using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Enter five number: ");

int sum = 0;
for (int i = 1; i <= 5; i++)
{
    int temp = 0;
    Console.WriteLine($"Enter number {i}:");
    temp = int.Parse(Console.ReadLine());
    sum += temp;
}
double avg = sum / 5;
Console.Write(($"Average number {sum} is: "));
double result = Math.Round(avg, 0);
Console.WriteLine(result);
if (result % 2 == 0) Console.WriteLine($"average is even: true");
else Console.WriteLine($"average is odd: flase");



