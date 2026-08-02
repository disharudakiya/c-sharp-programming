using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class NoTringle
    {
        static void Main(string[] args)
        {
            int num = 4;
            for(int i=1; i<=num; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }
}

//1
//22
//333
//4444

