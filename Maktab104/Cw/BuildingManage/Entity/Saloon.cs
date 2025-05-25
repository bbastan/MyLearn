using BuildingManage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManage.Entity
{
    internal class Saloon : Building
    {
        public TimeSpan StartTime { get; set; }
        public FiledType Filed { get; set; }
    }

}
