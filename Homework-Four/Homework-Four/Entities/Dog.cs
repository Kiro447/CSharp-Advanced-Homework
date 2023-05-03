using Homework_Four.Entities.Enum;

namespace Homework_Four.Entities;

public class Dog
{
    public string Name { get; set; } = string.Empty;
    public Breed Breed { get; set; }
    public int Age { get; set; }
    public string Color { get; set; } = string.Empty;
    public Dog(string name, Breed breed, int age, string color)
    {
        Name = name;
        Breed = breed;
        Age = age;
        Color = color;
    }

}
