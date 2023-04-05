using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_One.Models
{
    internal class Cat : Animal, ICat
    {
        public Cat(string name, int age, bool pedigree, string breed) : base(name, age, breed)
        {
            Pedigree = pedigree;
        }
        public bool Pedigree { get; set; }

        public void Eat()
        {
            Console.WriteLine("The cat is eating. Meow meow meow");
        }

        public override void PrintAnimal()
        {
            if (Pedigree) { 
            Console.WriteLine($"This is ${Name} and it is {Age} years old. It has pedigre");
            }
            else { 
            Console.WriteLine($"This is ${Name} and it is {Age} years old. It is a rescue cat.");
            }

        }
    }
}
