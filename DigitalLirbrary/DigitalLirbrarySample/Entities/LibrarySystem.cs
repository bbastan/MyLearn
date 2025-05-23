using DigitalLirbrarySample.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLirbrarySample.Entities
{
    internal class LibrarySystem : IAuthentication
    {
        LibraryService libraryService = new LibraryService();

        internal override void Login(string email, string password, Role role)
        {
            bool flag = true;
            while (flag == true)
            {
                if (email.Contains("@"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Email is true");
                    if (password.Length >= 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Password is true");
                        flag = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Password invalid - Password must be more than 8 characters.");
                        flag = false;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Email or password invalid - Email must have @ and assword must be more than 8 characters.");
                    flag = false;
                }

                if (flag == true)
                {
                    switch (role)
                    {

                        case Role.Librarian:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Librarian Login Done!");
                            break;
                        case Role.Member:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Member Login done!");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Input is invalid");
                            break;
                    }

                    if (role == Role.Librarian)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Menu:\n1-Add a new book\r\n2-Edit a book\r\nLogout");

                    }
                    else if (role == Role.Member)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Menu Member:\n1-Borrow a book\r\n2-Return a book\r\n3-View borrowed books\r\n4-View all books\r\n5-Logout");
                        //Member member = new Member();
                        var menuUser = Console.ReadLine();
                        if (menuUser == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: menu member cannot null, Please enter a number valid");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Menu Member:\n1-Borrow a book\r\n2-Return a book\r\n3-List borrowed books\r\n4-View all books\r\n5-Logout");
                        }
                        switch (menuUser)
                        {
                            case "1":
                                libraryService.BorrowBook();
                                break;
                            case "2":
                                libraryService.ReturnBook();
                                break;
                            case "3":
                                libraryService.GetListOfLibraryBooks();
                                break;
                            case "4":
                                libraryService.GetListOfUserBooks();
                                break;
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please select:\n1-Login\n2-Logout");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    LoginAgain();
                }
                else
                {
                    LogOut();
                }
            }
        }
        //internal override void LoginAgain()
        //{
        //    if (input == "1")
        //    {
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.WriteLine("Login again!");
        //        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //        Console.Write("Please enter your email: ");
        //        email = Console.ReadLine();
        //        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //        Console.Write("Please enter your password: ");
        //        password = Console.ReadLine();
        //        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //        Console.WriteLine("Please select your role:\n1-Librarian\n2-Member");
        //        role = (Role)Convert.ToInt32(Console.ReadLine());
        //        flag = true;
        //    }
        //    else
        //    {
        //        flag = false;
        //        Console.ForegroundColor = ConsoleColor.DarkRed;
        //        Console.WriteLine("Logout done!");
        //    }
        //}
        internal override void Register(string name, string email, string password, Role role)
        {

            bool flag = true;
            while (flag == true)
            {
                if (email.Contains("@"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Email is true");
                    if (password.Length >= 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Password is true");
                        flag = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Password invalid - Password must be more than 8 characters.");
                        flag = false;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Email or Password invalid - Email must have @ and password must be more than 8 characters.Email is invalid");
                    flag = false;
                }
                if (flag == true)
                {
                    switch (role)
                    {
                        case Role.Librarian:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Librarian Register Done!");
                            break;
                        case Role.Member:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Member Register done!");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Input is invalid");
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please login once to confirm.");

                Login(email, password, role);




            }
        }
        internal override void LogOut()
        {

        }

    }
}
