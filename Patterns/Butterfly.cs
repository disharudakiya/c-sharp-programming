using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class Butterfly
    {
        static void Main(string[] args)
        {
            int num = 4;
            for(int i=1; i<=num; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                for(int space=1; space<= (num-i)*2; space++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = num; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int space = 1; space <= (num - i) * 2; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}


//*      *
//**    **
//***  ***
//********
//********
//***  ***
//**    **
//*      *
