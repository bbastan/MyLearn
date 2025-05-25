using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManage
{
    internal abstract class Building
    {
        public int Id { get; set; }
        public double Area { get; set; }
        public bool IsPublic { get; set; }

    }
}
