using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class SameAlphabet
    {
        static void Main(string[] args)
        {
            int num = 4;
            for(int i=1; i<=num; i++)
            {
                char ch = (char)('A' + i - 1); // char meaning type casting 
                for(int j=1; j<=i; j++)
                {
                    Console.Write(ch + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine((char)66); // B
            Console.WriteLine((int)'A'); // 65
            Console.WriteLine('A' + 1); //66
        }
          

    }
}

//A
//B B
//C C C
//D D D D
