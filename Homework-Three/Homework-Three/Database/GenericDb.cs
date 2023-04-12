using Homework_Three.Entities;
using Homework_Three.Entities.Enum;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Three.Database
{
    public static class GenericDb<T> where T : BaseEntity
    {
        public static List<T> Db;
        static GenericDb()
        {
            Db = new List<T>();
        }

        public static void AddCar(T car) => Db.Add(car);
        public static T GetCar(int id)
        {
            return Db.FirstOrDefault(x => x.Id == id);
        }
        public static void PrintAll()
        {
            foreach (T car in Db)
            {
                Console.WriteLine($"{car.Id}): Car Model: {car.Model} \n Fuel type: {car.FuelType} \n Max speed: {car.MaxSpeed} kmh");
                Console.WriteLine("-----------------------------------------------------------------");
            }
        }
        public static void RemoveCar(int id)
        {
            T carToRemove = GetCar(id);
            if (carToRemove != null)
            {
                Db.Remove(carToRemove);
                Console.WriteLine($"Car with Id {id} was removed.");
            }
            else
            {
                Console.WriteLine($"Car with Id {id} does not exist.");
            }
        }

    }

}
