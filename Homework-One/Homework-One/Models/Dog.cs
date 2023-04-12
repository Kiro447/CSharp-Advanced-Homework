using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_One.Models.Interfaces;

namespace Homework_One.Models
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, int age, bool isAggresive, string breed) : base(name, age, breed)
        {
            IsAggresive = isAggresive;
        }
        public bool IsAggresive { get; set; }
        public void Bark()
        {
            if (IsAggresive)
            {
                Console.WriteLine("Aggresive dog barking: aw aw aw");
            }
            else { 
            Console.WriteLine("Non Aggressive dog barking : meow meow ");
            }
        }

        public override void PrintAnimal()
        {
            if (IsAggresive)
            {
                Console.WriteLine($"This is {Name}. He/She is a {Breed} and is {Age} years old. He is an aggresive dog");
            }
            else { 
            Console.WriteLine($"This is {Name}. He/She is a {Breed} and is {Age} years old. He is friendly dog");
            }
        }
    }
}

