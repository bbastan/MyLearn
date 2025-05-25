using Answer4;
using FizzWare.NBuilder.Dates;
using System.Transactions;
Calenter calender = new Calenter();
Console.WriteLine("Enter a number from 1 to 12 for month and a number from 1 to 31 for day");
Calenter.CalcolateCalenter(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

