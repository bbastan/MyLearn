

using _3_ValidMobile;
using static System.Runtime.InteropServices.JavaScript.JSType;

Calculator calculator = new Calculator();
Console.WriteLine("Enter a number with 3 digit: ");
string codeNumber = Console.ReadLine();
calculator.Validdatamobile(codeNumber);

Console.Write("Enter a Number for calculate desimal to binary : ");
int number = int.Parse(Console.ReadLine());
calculator.Converttobinary(number);