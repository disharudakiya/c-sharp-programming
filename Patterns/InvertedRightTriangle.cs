using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class InvertedRightTriangle
    {
        static void Main(string[] args)
        {
            int num = 4;
            for(int i=num; i>=1; i--)
            {
                for(int space=0; space<num-i; space++) //1 
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
            
    }
}

//****
// ***
//  **
//   *
