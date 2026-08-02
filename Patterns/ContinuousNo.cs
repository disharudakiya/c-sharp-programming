using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class ContinuousNo
    {
        static void Main(string[] args)
        {
            int num = 4;
            int Count = 1;

            for(int i=1;i<=num; i++)
            {
                for(int j=1; j<=i; j++)
                    
                {
                    Console.Write(Count + " ");
                    Count++;

                }
                Console.WriteLine();
            }

        }
    }
}
