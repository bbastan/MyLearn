using DigitalLirbrarySample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLirbrarySample.Entities
{
    internal class Member : Librarian
    {
        public Educate EducateUser { get; set; }
        public int Borrow { get; set; }

    }
}
