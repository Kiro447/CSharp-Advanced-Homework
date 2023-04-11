using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Two.Entities
{
    public class Car : Vehicle
    {

        public Car(string type, DateTime yearOfProduction, int batchNumber, int fuelTank, List<string> countries) : base(type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries;
        }

        public int FuelTank { get; set; }

        public List<string> Countries { get; set; } = new List<string>();

        public override void PrintVehicle()
        {
            string countriesList = string.Join(",", Countries);
            Console.WriteLine($"Car Type: {Type} \n Countries it is produced : {countriesList}");
        }
    }
}
