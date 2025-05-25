using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Properies
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //private int _id;
        //private string _name;
        internal void GetUser(string userName)
        {
            Console.WriteLine($"Id is {Id} and Name is {Name} and User name is {userName}");
        }


    }
}
