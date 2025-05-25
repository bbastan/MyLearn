using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_7
{
    internal class BinaryToDecimal
    {
        internal void BinaryDecimalMethod(string value)
        {
            double number = 0D;
            string[] des = value.Split(' ');
            for (int i = 0; i < des.Length; i++)
            {
                //Console.WriteLine($"index {i}: {des[i]} ");
                number += (Convert.ToInt32(des[i]) * (Math.Pow(2, i)));               
            }
            Console.WriteLine(number);
        }
    }
}
