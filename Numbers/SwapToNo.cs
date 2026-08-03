using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Numbers
{
    internal class SwapToNo
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 7;

            //int temp = num1; //4
            //num1 = num2; // 7
            //num2 = temp; // //4

            // without temp use

            int sum = num1 + num2; // 11
            num1 = sum - num1; // 11 - 4 = 7
            num2 = sum - num2; // 11 - 7 = 4    



            Console.WriteLine("After swapping: ");
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);

        }
    }
}
