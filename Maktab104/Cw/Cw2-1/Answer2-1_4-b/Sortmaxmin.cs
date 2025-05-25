using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer2_1_4_b
{
    internal class Sortmaxmin
    {
        internal static void Mysort()
        {
            int[] arrayString = new int[4];
            
            for (int i = 0; i < arrayString.Length; i++)
            {
                Console.WriteLine($"Input index {i}: ");
                arrayString[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (var i=0; i < arrayString.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (arrayString[i] < arrayString[j])
                    {
                        var x = arrayString[i];
                        arrayString[i] = arrayString[j];
                        arrayString[j] = x;
                    }
                }
                
            }
            for (var i = 0; i < arrayString.Length; i++)
            {
                Console.WriteLine(arrayString[i]);
            }



            }

    }
}
