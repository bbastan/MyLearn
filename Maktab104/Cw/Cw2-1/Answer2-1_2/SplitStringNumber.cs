using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Answer2_1_2
{
    internal class SplitStringNumber
    {
        internal void MySplit(string phrase)
        {
            string pattern = "[a-z]";
            string[] result = Regex.Split(phrase, pattern,
                                    RegexOptions.IgnoreCase,
                                    TimeSpan.FromMilliseconds(500));
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0}", result[i]);
                if (i < result.Length - 1) Console.Write("");               
            }
            
        }
    }
}
