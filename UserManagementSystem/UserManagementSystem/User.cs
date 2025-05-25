using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem
{
    internal class User : Person, IUserOperations
    {
        public string Username { get; set; }
        private string Password;

        public User(string name, int age, string userName, string password)
        {
            Name = name;
            Age = age;
            Username = userName;
            Password = password;
        }
        public void Login(string username, string password)
        {
            if (username == Username && password == Password)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                throw new Exception("Invalid usename or Pasword");
            }
        }
        public void Logout() { Console.WriteLine($"{Username} :logged out"); }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }




    }
}
