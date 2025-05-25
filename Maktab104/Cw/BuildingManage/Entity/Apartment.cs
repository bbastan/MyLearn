using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManage.Entity
{
    internal class Apartment : Building
    {
        public int CountOfFloor { get; set; }
        public bool HasElevetor { get; set; }

    }
}
