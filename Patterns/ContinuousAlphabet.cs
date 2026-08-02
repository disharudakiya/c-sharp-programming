using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class ContinuousAlphabet
    {
        static void Main(string[] args)
        {
            int num = 4;
            char ch = 'A';
            for (int i=1; i<=num; i++)
            {
                
                for(int j=1; j<=i; j++)
                {
                    Console.Write(ch + " ");
                    ch++;
                }
                Console.WriteLine();
            }
        }
    }
}

//A
//B C
//D E F
//G H I J
