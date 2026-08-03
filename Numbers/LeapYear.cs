using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Numbers
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            int year = 2016;
            if(year % 4 ==0 && year%100 !=0 || year % 400 == 0)
            {
                Console.WriteLine(" this is leap year ");
            }
            else {
                Console.WriteLine("this is not leap year ");
            }
        }
    }
}
