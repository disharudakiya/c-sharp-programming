using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.OOP
{
    internal class Animal1
    {

        public int age, legs;
        public string name;

       
        public Animal1(int age, string name, int legs)
        {
            this.age = age;
            this.name = name;
            this.legs = legs;
        }
        public void display()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.legs);
        }


    }
    internal class PerameterizedCon
    {
        static void Main(string[] args)
        {
            Animal1 a1 = new Animal1(80, "kutro", 10);
            //Console.WriteLine($"Age :- {a1.age}\nName:- {a1.name} \nLegs= {a1.legs}");

            
            a1.display();

           
            
        }
        
    }
}
