using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class CharacterTringle
    {
        static void Main(string[] args)
        {
            int num = 4;
            //char ch = 'A';

            for (int i = 1; i <= num; i++) {
                char ch = 'A';
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
//A B
//A B C
//A B C D
