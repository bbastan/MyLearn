using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Answer1_2_4
{
    internal class FindNumberfromWord
    {
        internal void Search(string? string7Word)
        {
            int number;
            bool isNumeric = int.TryParse(string7Word, out number);
            if (isNumeric)
            {
                Console.WriteLine($"true, {string7Word}");
            }
            else
            {
                Console.WriteLine($"false, 0");
            }
        }
    }
}
