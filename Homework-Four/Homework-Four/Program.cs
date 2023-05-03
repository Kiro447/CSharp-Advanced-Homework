using Homework_Four.DataBase;
using Homework_Four.Entities;
using System.Security.Cryptography.X509Certificates;


DataBase db = new DataBase();
Console.WriteLine("Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER");
//Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
List<Person> FirstNameWithR = db.PersonDb.Where(x => x.FirstName[0] == 'R').OrderByDescending(x => x.Age).ToList();
db.PrintNames(FirstNameWithR);

// Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER

Console.WriteLine("\n\nFind and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER");
List<Dog> BrownDogs = db.PersonDb.SelectMany(x => x.ListOfDogs)
    .Where(x => x.Color == "brown" && x.Age > 3)
    .OrderBy(x => x.Age).ToList();
db.PrintDogs(BrownDogs);


//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER

Console.WriteLine("\n\nFind and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER");
List<Person> PersonTwoDogs = db.PersonDb
                            .Where(x => x.ListOfDogs.Count > 2)
                            .OrderBy(x => x.FirstName)
                            .ToList();
db.PrintNames(PersonTwoDogs);

//Find and print all Freddy`s dogs names older than 1 year
Console.WriteLine("\n\nFind and print all Freddy`s dogs names older than 1 year");

List<Person> freddy = db.PersonDb.Where(x => x.FirstName == "Freddy").ToList();
List<Dog> freddyDogs = freddy.SelectMany(x => x.ListOfDogs).Where(x => x.Age > 1).ToList();
db.PrintDogs(freddyDogs);

//Find and print Nathen`s first dog
Console.WriteLine("\n\nFind and print Nathen`s first dog");
Dog NathansDog = db.PersonDb.First(x => x.FirstName == "Nathen").ListOfDogs.First();
Console.WriteLine("Nathens First dog :" + NathansDog.Name);

//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

Console.WriteLine("\n\nFind and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER");


List<Dog> whiteDogs = db.PersonDb
    .Where(p => p.FirstName == "Cristofer" || p.FirstName == "Freddy" || p.FirstName == "Erin" || p.FirstName == "Amelia")
    .SelectMany(p => p.ListOfDogs.Where(d => d.Color == "white"))
    .OrderBy(d => d.Name)
    .ToList();

db.PrintDogs(whiteDogs);
