using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Numbers
{
    internal class SumNo
    {
        static void Main(string[] args)
        {
            int num = 5;
            int sum = 0;

            for(int i=1; i<=num; i++)
            {
                sum += i;
                Console.WriteLine(sum);
            }
           
        }
    }
}
