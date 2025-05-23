using DigitalLirbrarySample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLirbrarySample.Entities
{
    internal abstract class IAuthentication
    {
        internal abstract void Login(string email, string password, Role role);

        //internal abstract void Logou();

        internal abstract void Register(string name, string email, string password, Role role);
        internal abstract void LogOut();
       // internal abstract void LoginAgain();

    }
}
