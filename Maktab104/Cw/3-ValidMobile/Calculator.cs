using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ValidMobile
{
    internal class Calculator : ValidDataMobile
    {
        internal override void Validdatamobile(string codeNumber)
        {
            if ((codeNumber.Length == 3) && (codeNumber.Substring(0, 1) == "+"))
            {
                string prefix = codeNumber.Substring(0, 1).Replace("+", "0");
                Console.WriteLine($"Code NUmber is: {prefix}{codeNumber.Substring(1, 1)}{codeNumber.Substring(2, 1)}\n\n\n");
            }
            else if ((codeNumber.Length == 3) && (codeNumber.Substring(0, 1) == "0"))
            {
                Console.WriteLine($"Code NUmber is: {codeNumber}\n\n\n");
            }
            else if ((codeNumber.Length == 3) || !(codeNumber.Substring(0, 1) == "0") || !(codeNumber.Substring(0, 1) == "+"))
            {
                Console.WriteLine("Number must begin with 0 or + \n\n\n");
            }
            else
            {
                Console.WriteLine("Enter again <Code Number is 3 digit>: \n\n\n");
            }
            
        }
        internal override void Converttobinary(int num)
        {
            int divided;
            string remainder = "";
            while (num >= 1)
            {
                divided = num / 2;
                remainder += (num % 2).ToString();
                num = divided;
            }
            string binary = "";
            for (int i = remainder.Length - 1; i >= 0; i--)
            {
                binary = binary + remainder[i];
            }
            Console.WriteLine("The Binary format for given number is {0}", binary);
            Console.Read();
            //throw new NotImplementedException();
        }
    }
}
