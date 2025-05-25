using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManage
{
    internal class Saloon : Building
    {
        public FiledType Filed { get; set; }
        public TimeSpan StratTime { get; set; }

        
        // List<Building> SaloonsList { get; set; } = new List<Building>();

    }
    public enum FiledType
    {
        Footsal = 1,
        Valibol = 2
    } 
}
