
DateTime eventDay = new DateTime();
Console.WriteLine("Enter the year: ");
int year = Convert.ToInt32(Console.ReadLine());
eventDay.AddYears(year);
Console.WriteLine("Enter the month: ");
int month = Convert.ToInt32(Console.ReadLine());
eventDay.AddMonths(month);
Console.WriteLine("Enter the day: ");
int day = Convert.ToInt32(Console.ReadLine());
eventDay.AddDays(day);
DateTime eventDays = new DateTime(year,month,day);
TimeSpan remainingTime = DateTime.Now - eventDays;
Console.WriteLine($"Remaining to event is: {remainingTime.Days} day");



