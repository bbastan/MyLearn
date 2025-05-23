using DigitalLirbrarySample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLirbrarySample.Entities
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }
        public bool IsAvailable { get; set; }
        public Categories CategoryBook { get; set; }
    }
}
