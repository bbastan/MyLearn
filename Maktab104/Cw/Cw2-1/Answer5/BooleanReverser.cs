using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer5
{
    internal class BooleanReverser
    {
        //public bool TrueFalse { get; set; }

        internal static void ReversarBool(bool boolean)
        {
            if (boolean == true)
            {
                Console.WriteLine($"Revese Value is : {!boolean}");
            }
            else
            {
                Console.WriteLine($"Reverse Value is : {!boolean}");
            }
        }
    }
}
