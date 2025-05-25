using ElectronicLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Entity
{
    internal class Login
    {
        public ERole Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
