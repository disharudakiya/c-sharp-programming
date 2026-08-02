using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class InvertedPyramid
    {
        static void Main(string[] args)
        {
            int num = 4;
            for (int i = num; i >= 1; i--){
                for (int space = 1; space <= num-i; space++) {
                    Console.Write(" ");

                }
                for (int j = 1; j <= i * 2 - 1; j++) { 
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

//*******
// *****
//  ***
//   *