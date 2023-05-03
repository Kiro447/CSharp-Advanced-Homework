namespace Homework_Four.Entities;

public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public List<Dog> ListOfDogs { get; set; } = new List<Dog>();

    public Person(string firstName, string lastName, int age, List<Dog> listOfDogs)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        ListOfDogs = listOfDogs;
    }



}
