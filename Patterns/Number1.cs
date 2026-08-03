using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class Number1
    {
        static void Main(string[] args)
        {
            int num = 4;
            for(int i=1; i<=num; i++)
            {
                for(int j=i; j>=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

//1
//21
//321
//4321


