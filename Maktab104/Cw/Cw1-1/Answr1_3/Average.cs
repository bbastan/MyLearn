using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answr1_3
{
    internal class Average
    {
        internal double AvgFloat(double number1,double number2)
        { 
            double value = Math.Round(((number1 + number2)/2),2);
            return value;
        }
        
    }
}
