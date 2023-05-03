using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Five;

public class Dog
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Color { get; set; }
    public Dog(string name, int age, string color)
    {
        Name = name;
        Age = age;
        Color = color;
    }
}
