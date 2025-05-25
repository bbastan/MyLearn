using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManage.Entity
{
    internal class Counter
    {
        int _counter = 0;
        internal int GetCounter()
        {
            return _counter += 1;
        }

    }
}
