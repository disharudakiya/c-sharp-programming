using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class NoPyramid
    {
        static void Main(string[] args)
        {
            int num = 5;
            for (int i = 1; i <= num; i++){
                for (int space = 1; space <= num - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                } 

               for(int k= i-1; k>=1; k++)
                {
                    Console.Write(k);
                }


                Console.WriteLine();

            }
        }
    }
}

//    1
//   121
//  12321
// 1234321
//123454321
