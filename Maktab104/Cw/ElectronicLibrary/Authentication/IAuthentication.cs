using ElectronicLibrary.Entity;
using ElectronicLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Interface
{
    internal interface IAuthentication 
    {
        bool Login(string email, string password);
        bool Register(string name, string email, string password, int role);

    }
}
