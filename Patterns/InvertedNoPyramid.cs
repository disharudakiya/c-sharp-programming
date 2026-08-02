using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class InvertedNoPyramid
    {
        static void Main(string[] args)
        {
            int num = 5;
            for (int i = num; i >=1; i--)
            {
                for (int space = 1; space <= num - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                }

                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }


                Console.WriteLine();

            }
        }
    }
}
