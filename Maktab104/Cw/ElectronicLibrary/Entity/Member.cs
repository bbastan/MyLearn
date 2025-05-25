using ElectronicLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Entity
{
    internal class Member : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //public string LastName { get; set; }
        //public int IdentityCode { get; set; }
        //public int Age { get; set; }
        //public ELevel EducationLevel { get; set; }
        //public DateOnly MembershipExpireDate { get; set; }

    }
}
