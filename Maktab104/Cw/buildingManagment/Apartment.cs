using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManage
{
    internal class Apartment : Building
    {
        public int CountOfFloor { get; set; }
        public bool HasElevator { get; set; }
       // List<Building> ApartmentsList { get; set; } = new List<Building>();
    }
}
