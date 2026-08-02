using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class Hollow {
        static void Main(string[] args)
        {
            int num = 5;
            for(int i=1; i<=num; i++)
            {
                for(int j=1;j<=num; j++)
                {
                    if(i==1 || i==num || j==1 || j == num)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


    }
}
//*****
//*   *
//*   *
//*   *
//*****