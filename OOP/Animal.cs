using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernings.OOP
{
    internal class DemoAnimal
    {
        public string name ;
        public int age;
        public int legs;

    }
    internal class Animal
    {
        static void Main(string[] args)
        {
            DemoAnimal a1 = new DemoAnimal();
            a1.name = "cat";
            a1.age = 80;
            a1.legs = 6;

            Console.WriteLine($"Name :- {a1.name} \nAge :- {a1.age}\nLegs :- {a1.legs}");
            
        }

    }
}
