using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.Patterns
{
    internal class InvertedLeftTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no : ");
            int num = Convert.ToInt32(Console.ReadLine());
            //int num = 5;
            for(int i=num; i>=1; i--){
                for(int j=1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }
            
           
        }
    }
}

//****
//***
//**
//*
