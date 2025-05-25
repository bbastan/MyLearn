using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem
{
    internal interface IUserOperations
    {
        internal void Login(string username, string password);
        internal void Logout();
    }
}
