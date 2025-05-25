using Answer1_2_2;
using System.Threading.Channels;

Console.WriteLine("Enter 3 number for calcolutor second from hours and minutes and seconds");
Time time = new();
time.Times(int.Parse(Console.ReadLine()) , int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
