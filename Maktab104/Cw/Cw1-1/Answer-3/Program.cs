


using Answer_3;
using static System.Runtime.InteropServices.JavaScript.JSType;

CustomDate customDate = new CustomDate();
DateTime? today = DateTime.Now;
Console.WriteLine($"DateTime today is: {today}, Please input a date time: ");
customDate.MyDate = Console.ReadLine();




//Console.WriteLine($"output is: {customDate.MyDate}");

//DateTime? today = DateTime.Now;
//Console.WriteLine($"DateTime today is: {today} ");
//Console.WriteLine("Enter a date time:");
//string? myDate = Console.ReadLine();

//if (Convert.ToString(today) == myDate) Console.WriteLine("True");
//else
//{
//    Console.WriteLine("False");
//}
