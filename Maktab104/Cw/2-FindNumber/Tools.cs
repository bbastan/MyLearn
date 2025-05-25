using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FindNumber
{
    internal class Tools
    {
        internal void FindMostNumber(string value)
        {
            int[] str = new int[10];
            for (int i = 0; i < value.Length; i++)
            {
                str[i] = Convert.ToInt32(value.Substring(i, 1));
            }
            int[] Counter = new int[10];
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        Counter[i]++;
                    }                
                }
            }

            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine($"digit {str[i]} is Reaper: {Counter[i]} times.");
            }

        }
    }
}
