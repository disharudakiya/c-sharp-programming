using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class RightTriangle
    {
        static void Main(string[] args)
        {
            int num = 4;
            for(int i=1; i<=num; i++)
            {
                for(int space=1; space<=num-i; space++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
