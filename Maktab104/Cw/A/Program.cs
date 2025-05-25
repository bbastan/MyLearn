

using LoginRegisterUser;
using System.Runtime.CompilerServices;

string input = "0";
var authentication = new Authentication();
while (input != null)
{
    Console.Write("\n1- Register\n2- Login\nE- Exit\nSelect one of the options above:");
    input = Console.ReadLine();
    if (input == "1")
    {
        Console.WriteLine("welcome to the register page, Please input your Personal information for credentials:\n");
        authentication.Register();
    }
    else if (input == "2")
    {
        Console.WriteLine("welcome to the Login page, Please input your Email and Password:\n");
        authentication.Login();
    }
    else if (input == "E")
    {
        Console.WriteLine("You have selected the option to exit the program. Hope to see you again.");
        authentication.ExitProgram();
    }
    else
    {
        throw new Exception("Please select one of the options above.");
    }
}

Console.ReadLine();


