using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegisterUser
{
    public class Person
    {
        public string? Name { get; set; }
        public string? Family { get; set; }
        public int? Age { get; set; }
        public Gender Gender { get; set; }
        public List<ContactInfo> Contacts { get; set; }
    }
    public enum Gender
    {
        Male = 1, Female = 2
    }
}
