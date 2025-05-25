using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1_2_3
{
    internal class Salary
    {
        internal void CalSalary (double resiveSalary)
        {
            double tax = resiveSalary - (resiveSalary * 10 /100);
            double insurence = tax - (tax * 6 /100);
            Console.WriteLine($"Your salary are: {insurence}");
        }
    }
}
