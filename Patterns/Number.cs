using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter No :- ");
            int num = Convert.ToInt32((Console.ReadLine()));
            //int num = 4;
            for (int i=1; i<=num; i++)
            {
                for(int j=num; j>=i; j--)
                {
                   Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

//4321
//432
//43
//4