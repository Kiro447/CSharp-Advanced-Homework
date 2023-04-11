using Homework_Two.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Two.Database
{
    public static class Db
    {
        public static List<Vehicle> VehichleDb;


        static Db()
        {
            VehichleDb = new List<Vehicle>()
            {
                new Car("BMW",new DateTime(1997,06,28),16,100,new List<string>(){"skopje","ukraina","rusija"}),
                new Car("Skoda",new DateTime(1997,06,28),15,120,new List<string>(){"zanzibar"}),
                new Car("Citroen",new DateTime(1997,06,28),14,130,new List<string>(){"brazil","USA"}),
                new Car("Mazda",new DateTime(1997,06,28),13,140,new List<string>(){"bajro"}),
                new Car("Alfa",new DateTime(1997,1,1),12,150,new List<string>(){"Serbia"}),
                new Bike("", new DateTime(2018,12,12),12,"blue"),
                new Bike("Ducati", new DateTime(2023,12,12),13,"green"),
                new Bike("BMW", new DateTime(2012,12,12),14,"red"),
            };
        }
        public static void PrintAllCars()
        {
            foreach (Vehicle vehicle in VehichleDb)
            {
                if (vehicle is Car car)
                {
                    Console.WriteLine($"Car model: {car.Type} \n Production Year: {car.YearOfProduction.Year}");
                }
            }
        }

        public static void PrintAllBikes()
        {
            foreach (Vehicle vehicle in VehichleDb)
            {
                if (vehicle is Bike bike)
                {
                    Console.WriteLine($"Bike Model: {bike.Type} \n Bike Color: {bike.Color} \n Production Year: {bike.YearOfProduction.Year}");
                }
            }
        }

    }
}
