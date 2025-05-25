using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Entity
{
    internal class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        //public string? Translator { get; set; }
        public string ISBN { get; set; }
        //public string Publicate { get; set; }
    }
}
