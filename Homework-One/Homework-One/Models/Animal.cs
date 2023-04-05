using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_One.Models
{
    public abstract class Animal : IAnimal
    {
        private string breed1;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public Animal(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public Animal(string name, int age, string breed, string breed1) : this(name, age, breed)
        {
            this.breed1 = breed1;
        }

        public abstract void PrintAnimal();
      
    }
}
