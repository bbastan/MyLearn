using _2;
using static _1.Emathematic;

Console.WriteLine("Enter a number from 1 to 3: ");
var value = Convert.ToInt32(Console.ReadLine());

if (((int)Emathematic.EmathematicType.Fibonaccinumber) == value)
{
    Console.Write("Enter a number fibonacci: ");
    var number = Convert.ToInt32(Console.ReadLine());
    int result = Utility.Fibonaccinumber(number);
    Console.WriteLine($"Exit Fibonacci number is: {result}");
}
else if (((int)Emathematic.EmathematicType.Factorielnumber) == value)
{
    Console.Write("Enter a number for factoriel: ");
    var number2 = Convert.ToInt32(Console.ReadLine());
    int result2 = Utility.Factorielnumber(number2);
    Console.WriteLine($"Exit Factoriel number is: {result2}");
}
else if (((int)Emathematic.EmathematicType.Multiplicationmatrices) == value)
{
    Utility.Multiplicationmatrices();
}