using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManage
{
    internal class Counters
    {
        int _count = 0;
        internal int GetCounters() => _count++;
    }
}
