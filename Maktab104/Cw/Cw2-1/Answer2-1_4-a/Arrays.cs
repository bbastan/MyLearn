using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Answer2_1_4_a
{
    internal class Arrays
    {
        public void MyArrays()
        {
            string[] arrayString = new string[7];

            for (int i = 0; i < arrayString.Length; i++)
            {
                Console.WriteLine($"Input index {i} that seprete with cama(,): ");
                arrayString[i] = Console.ReadLine();  
            }

            if ((Convert.ToInt32(arrayString[0]) > (Convert.ToInt32(arrayString[2]))) && ((Convert.ToInt32(arrayString[0]) > (Convert.ToInt32(arrayString[4]))) && (Convert.ToInt32(arrayString[0]) > (Convert.ToInt32(arrayString[6]))))) Console.WriteLine($"Number {arrayString[0]} is Maximum.");
            else if ((Convert.ToInt32(arrayString[2]) > (Convert.ToInt32(arrayString[0]))) && ((Convert.ToInt32(arrayString[2]) > (Convert.ToInt32(arrayString[4]))) && (Convert.ToInt32(arrayString[2]) > (Convert.ToInt32(arrayString[6]))))) Console.WriteLine($"Number {arrayString[2]} is Maximum.");
            else if ((Convert.ToInt32(arrayString[4]) > (Convert.ToInt32(arrayString[0]))) && ((Convert.ToInt32(arrayString[4]) > (Convert.ToInt32(arrayString[2]))) && (Convert.ToInt32(arrayString[4]) > (Convert.ToInt32(arrayString[6]))))) Console.WriteLine($"Number {arrayString[4]} is Maximum.");
            else Console.WriteLine($"Number {arrayString[6]} is Maximum.");

            if ((Convert.ToInt32(arrayString[0]) < (Convert.ToInt32(arrayString[2]))) && ((Convert.ToInt32(arrayString[0]) < (Convert.ToInt32(arrayString[4]))) && (Convert.ToInt32(arrayString[0]) < (Convert.ToInt32(arrayString[6]))))) Console.WriteLine($"Number {arrayString[0]} is Minimum.");
            else if ((Convert.ToInt32(arrayString[2]) < (Convert.ToInt32(arrayString[0]))) && ((Convert.ToInt32(arrayString[2]) < (Convert.ToInt32(arrayString[4]))) && (Convert.ToInt32(arrayString[2]) < (Convert.ToInt32(arrayString[6]))))) Console.WriteLine($"Number {arrayString[2]} is Minimum.");
            else if ((Convert.ToInt32(arrayString[4]) < (Convert.ToInt32(arrayString[0]))) && ((Convert.ToInt32(arrayString[4]) < (Convert.ToInt32(arrayString[2]))) && (Convert.ToInt32(arrayString[4]) < (Convert.ToInt32(arrayString[6]))))) Console.WriteLine($"Number {arrayString[4]} is Minimum.");
            else Console.WriteLine($"Number {arrayString[6]} is Minimum.");

        }

    }
}
