using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class BinaryNoTringle
    {
        static void Main(string[] args)
        {
            int num = 4;
            for(int i=1; i<=num; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    if((i+j) % 2 == 0)
                    {
                        Console.Write("1");
                    }
                    else {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
