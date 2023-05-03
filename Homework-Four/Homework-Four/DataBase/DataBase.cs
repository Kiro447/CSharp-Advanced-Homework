using Homework_Four.Entities;
using Homework_Four.Entities.Enum;

namespace Homework_Four.DataBase;

public  class DataBase
{
    public List<Person> PersonDb;

    public DataBase()
    {
        PersonDb = new List<Person>();
        {
            PersonDb.Add(new Person("Robert", "Jordanov", 24, new List<Dog>()));
            PersonDb.Add(new Person("Stefan", "Stefanov", 22, new List<Dog>()));
            PersonDb.Add(new Person("Amelia", "Trendafilov", 44, new List<Dog>()));
            PersonDb.Add(new Person("Erin", "Stefanov", 36, new List<Dog>()));
            PersonDb.Add(new Person("Freddy", "Popovski", 42, new List<Dog>()));
            PersonDb.Add(new Person("Cristofer", "Popovski", 32, new List<Dog>()));
            PersonDb.Add(new Person("Ratko", "Popovski", 22, new List<Dog>()));
            PersonDb.Add(new Person("Nathen", "Popovski", 22, new List<Dog>()));

        }
        PersonDb[0].ListOfDogs.Add(new Dog("Sarko", Breed.LabradorRetriever, 7, "brown"));
        PersonDb[0].ListOfDogs.Add(new Dog("King", Breed.Beagle, 5, "brown"));
        PersonDb[1].ListOfDogs.Add(new Dog("Oscar", Breed.GermanShepherd, 4, "brown"));
        PersonDb[2].ListOfDogs.Add(new Dog("Lea", Breed.LabradorRetriever, 2, "golden"));
        PersonDb[2].ListOfDogs.Add(new Dog("Lina", Breed.Rottweiler, 2, "white"));
        PersonDb[3].ListOfDogs.Add(new Dog("Sarko", Breed.Poodle, 4, "yellow"));
        PersonDb[3].ListOfDogs.Add(new Dog("King", Breed.Poodle, 4, "white"));
        PersonDb[4].ListOfDogs.Add(new Dog("Freddy", Breed.GermanShorthaired, 1, "yellow"));
        PersonDb[4].ListOfDogs.Add(new Dog("Krueger", Breed.Dachshund, 6, "black"));
        PersonDb[4].ListOfDogs.Add(new Dog("Baron", Breed.GoldenRetriever, 5, "golden"));
        PersonDb[4].ListOfDogs.Add(new Dog("Sarko", Breed.GoldenRetriever, 5, "white"));
        PersonDb[5].ListOfDogs.Add(new Dog("Mende", Breed.GermanShepherd, 8, "white"));
        PersonDb[7].ListOfDogs.Add(new Dog("Lara", Breed.Poodle, 8, "white"));
        PersonDb[7].ListOfDogs.Add(new Dog("Lara", Breed.Beagle, 2, "brown"));
    }
    public void PrintNames(List<Person> people)
    {
        foreach (Person person in people)
        {
            Console.WriteLine($"Person first name: {person.FirstName} Age: {person.Age}");
        }
    }
    public void PrintDogs(List<Dog> dogs)
    {
        foreach(Dog dog in dogs)
        {
            Console.WriteLine($"Dog name: {dog.Name} Dog Age: {dog.Age} Dog Color: {dog.Color}");
        }
    }
}
