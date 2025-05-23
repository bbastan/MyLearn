

using DigitalLirbrarySample.Entities;
using DigitalLirbrarySample.Enums;
using System.ComponentModel.Design;
LibrarySystem librarySystem = new LibrarySystem();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Menu:\n1-Login\n2-Register");
var input = Console.ReadLine();
if (input == "1")
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Please enter your email: ");
    string email = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Please enter your password: ");
    string password = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Please select your role:(\n1-Librarian\n2-Member)");
    int inputRole = Convert.ToInt32(Console.ReadLine());
    if (inputRole == 1)
    {
        Role role = (Role)inputRole;
        librarySystem.Login(email, password, role);
    }
    else if (inputRole == 2)
    {
        Role role = (Role)inputRole;
        librarySystem.Login(email, password, role);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Role invalid");
    }
}
else if (input == "2")
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Please enter your email: ");
    string email = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Please enter your password: ");
    string password = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Please select new your role:\n1-Librarian\n2-Member");
    int input2 = Convert.ToInt32(Console.ReadLine());
    if (input2 == 1)
    {
        Role role = (Role)input2;
        librarySystem.Register(name, email, password, role);
    }
    else if (input2 == 2)
    {
        Role role = (Role)input2;
        librarySystem.Register(name, email, password, role);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Role invalid - The entered role is invalid.");
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: Input is invalid");
}






