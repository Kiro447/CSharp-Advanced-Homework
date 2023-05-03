#region JSON Reader Writer
using Homework_Five;
using Newtonsoft.Json;

string folderPath = "../../../JSONData";
string filePath = folderPath + "/Dogs.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

void JsonWriter(string json)
{
    using (StreamWriter sw = new StreamWriter(filePath,true))
    {
        sw.WriteLine(json);
    }
}

void JsonReader()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        Console.WriteLine("JSON FORMAT:");
        Console.WriteLine(sr.ReadToEnd());
    }
}
#endregion
while (true)
{
    Console.WriteLine("Enter your dog's name");
    string dogName = Console.ReadLine();
    Console.WriteLine("Enter your dog's age");
    int dogAge = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter your dog's color");
    string dogColor = Console.ReadLine();
    Dog sarko = new Dog(dogName, dogAge, dogColor);
    string jsonDogSerealized = JsonConvert.SerializeObject(sarko);
    JsonWriter(jsonDogSerealized);
    JsonReader();
    Console.WriteLine("Press enter to clear");
    Console.ReadKey();
    Console.Clear();
}